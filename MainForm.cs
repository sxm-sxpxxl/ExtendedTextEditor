using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

/// <summary>
/// Ближайшие планы:
///     > Привести систему сохранений в удобный для пользователя вид. Создать вспомогательную форму, предлагающую сохранить текущий документ;
///         > Резерв под логику: стр. 509, 451
/// </summary>

namespace ExtendedTextEditor
{
    public partial class MainForm : Form
    {
        private const String COURIER_NEW_FONT_FAMILY_NAME = "Courier New";
        private const String VERDANA_FONT_FAMILY_NAME = "Verdana";
        private const String LUCIDA_CONSOLE_FONT_FAMILY_NAME = "Lucida Console";
        private const String ARIAL_FONT_FAMILY_NAME = "Arial";

        private const String SAVED_FILE_STATUS = "Saved";
        private const String CHANGED_FILE_STATUS = "Changed";
        private const String CREATED_FILE_STATUS = "Created Document";
        private const String NONE_FILE_STATUS = "No Document";

        private readonly String KEY_ACTIVE_RICH_TEXT_BOX = "ActiveRichTextBox";
        private readonly Int32 WIDTH_LINE_NUMBERS_BOX = 30;
        private readonly String XML_PATH = null; // init in .ctor
        private readonly String XML_NAME = "info_recent_files.xml";
        private readonly String XML_NAME_ACTIVE_RECENT_FILE_PATH = "ActiveRecentFilePath";
        private readonly String XML_NAME_RECENT_FILES = "RecentFiles";


        private RichTextBox activeRichTextBox = null;
        private Graphics g = null;
        private ClassPrinter printer = null;
        private ClassFonter fonter = null;
        private ClassMacros macro = null;
        private XmlDocument xInfoDocument = new XmlDocument();

        private readonly String PROJECT_PATH = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName;

        public MainForm()
        {
            InitializeComponent();
            XML_PATH = XML_NAME;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                xInfoDocument.Load(XML_PATH);
            }
            catch (FileNotFoundException)
            {
                using (FileStream xml_file = new FileStream(XML_PATH, FileMode.CreateNew))
                {
                    String data = Properties.Resources.info_recent_files_base;
                    xml_file.Write(Encoding.UTF8.GetBytes(data), 0, data.Length);
                }
                xInfoDocument.Load(XML_PATH);
            }

            String activeRecentFilePath = xInfoDocument.DocumentElement.GetElementsByTagName(XML_NAME_ACTIVE_RECENT_FILE_PATH)[0].InnerText;
            if (!File.Exists(activeRecentFilePath)) NewToolStripMenuItem_Click(this, new EventArgs());
            else OpenTextFile(activeRecentFilePath);

            for (Int32 i = xInfoDocument.DocumentElement.GetElementsByTagName(XML_NAME_RECENT_FILES)[0].ChildNodes.Count - 1; i > 0; i--)
            {
                AddToRecentFiles(xInfoDocument.DocumentElement.GetElementsByTagName(XML_NAME_RECENT_FILES)[0].ChildNodes[i].InnerText);
            }
            if (File.Exists(activeRecentFilePath)) AddToRecentFiles(activeRecentFilePath);
        }

        public RichTextBox ActiveRichTextBox { get => activeRichTextBox; }

        private String CurrentFileName
        {
            get { return (activeRichTextBox.Tag as RichTextBoxData).fileName; }
            set { (activeRichTextBox.Tag as RichTextBoxData).fileName = value; }
        }

        private MyListBox ActiveLineNumbersListBox
        {
            get { return (activeRichTextBox.Tag as RichTextBoxData).activeListBox; }
        }

        private bool IsSavedCurrentFile
        {
            get { if (activeRichTextBox != null) return (activeRichTextBox.Tag as RichTextBoxData).isSaved; else return true; }
            set
            {
                RichTextBoxData data = (activeRichTextBox.Tag as RichTextBoxData);
                data.isSaved = value;
                if (data.isSaved) FileStatus = SAVED_FILE_STATUS;
                else FileStatus = CHANGED_FILE_STATUS;
            }
        }

        private TabPage ParentTabPageOfActiveRichTextBox
        {
            get { return (activeRichTextBox.Tag as RichTextBoxData).parentTabPage; }
        }

        private String FileStatus
        {
            get { return (activeRichTextBox.Tag as RichTextBoxData).fileStatus; }
            set { if (activeRichTextBox != null) (activeRichTextBox.Tag as RichTextBoxData).fileStatus = value; UpdateFileStatus(value); }
        }

        private ClassPrinter Printer
        {
            get { if (printer == null) printer = new ClassPrinter(activeRichTextBox); return printer; }
        }

        private ClassFonter Fonter
        {
            get { if (fonter == null) fonter = new ClassFonter(null); return fonter; }
        }

        private void UpdateFileStatus(String status)
        {
            fileStatusToolStripStatusLabel.Text = status;
        }

        private void SetLineNumbers(MyListBox listBox, Int32 countOfLines)
        {
            listBox.Items.Clear();
            for (Int32 i = 1; i <= countOfLines; i++) listBox.Items.Add(i);
        }

        private Int32 GetCountLinesOfString(String baseString)
        {
            Int32 countOfLines = 1;
            for(Int32 i = 0; i < baseString.Length; i++) if (baseString[i] == '\n') countOfLines++;
            return countOfLines;
        }

        private Int32 GetCurrentCursorLine(String baseString, Int32 indexInText)
        {
            Int32 numberOfCurrentLine = 1;
            for (Int32 i = 0; i < indexInText; i++) if (baseString[i] == '\n') numberOfCurrentLine++;
            return numberOfCurrentLine;
        }

        private String GetCutNameForPath(String fullPath)
        {
            return fullPath.Remove(0, fullPath.LastIndexOf('\\') + 1);
        }

        // Произвести рефакторинг данного участка кода
        private void CreateNewTextFile(String name)
        {
            if (MainTabControl.TabPages.Count <= 1) SetEnabledMode(true);
            TabPage tabPage = new TabPage(name);
            tabPage.ContextMenuStrip = TabPageContextMenuStrip;

            Panel panel = new Panel() { Parent = tabPage, Dock = DockStyle.Fill };

            activeRichTextBox = new RichTextBox {
                Parent = panel,
                Dock = DockStyle.Fill,
                Name = KEY_ACTIVE_RICH_TEXT_BOX,
                ScrollBars = RichTextBoxScrollBars.ForcedVertical,
                WordWrap = false,
                AcceptsTab = true
            };
            g = activeRichTextBox.CreateGraphics();

            MyListBox listBox = new MyListBox() {
                Parent = panel,
                Dock = DockStyle.Left,
                Width = WIDTH_LINE_NUMBERS_BOX,
                SelectionMode = SelectionMode.None,
                RightToLeft = RightToLeft.Yes,
                ShowScrollbar = false,
                IntegralHeight = false
            };
            listBox.Items.Add(1);


            activeRichTextBox.Tag = new RichTextBoxData
            {
                isSaved = false,
                fileName = String.Empty,
                parentTabPage = tabPage,
                fileStatus = CREATED_FILE_STATUS,
                activeListBox = listBox
            };
            activeRichTextBox.TextChanged += ActiveRichTextBox_TextChanged;
            activeRichTextBox.VScroll += ActiveRichTextBox_VScroll;

            // Default Font
            activeRichTextBox.Font = Fonter.GetFont(new FontFamily(COURIER_NEW_FONT_FAMILY_NAME));
            listBox.Font = Fonter.GetFont(new FontFamily(COURIER_NEW_FONT_FAMILY_NAME));
            Fonter.SwitchFont(defaultToolStripMenuItem);
            FileStatus = CREATED_FILE_STATUS;

            MainTabControl.TabPages.Add(tabPage);
            MainTabControl.SelectedTab = tabPage;
        }

        private void OpenTextFile(String path)
        {
            if (!File.Exists(path)) return;

            String cutFileName = GetCutNameForPath(path);
            foreach(TabPage page in MainTabControl.TabPages)
            {
                // У текущей просматриваемой страницы обращаемся к panel, у которой обращаемся к RichTextBox, у которого берем Tag и смотрим на свойство fileName, которое там содержится, и сравниваем его
                if ( ((page.Controls[0].Controls.Find(KEY_ACTIVE_RICH_TEXT_BOX, false)[0] as RichTextBox).Tag as RichTextBoxData).fileName == path )
                {
                    MainTabControl.SelectedTab = page;
                    return;
                }
            }

            CreateNewTextFile(cutFileName);

            try
            {
                if (path.EndsWith("rtf")) activeRichTextBox.LoadFile(path, RichTextBoxStreamType.RichText);
                else activeRichTextBox.LoadFile(path, RichTextBoxStreamType.PlainText);
            }
            catch(Exception) { activeRichTextBox.LoadFile(path, RichTextBoxStreamType.PlainText); }

            activeRichTextBox.Font = Fonter.GetFont(new FontFamily(COURIER_NEW_FONT_FAMILY_NAME));
            ActiveLineNumbersListBox.Font = Fonter.GetFont(new FontFamily(COURIER_NEW_FONT_FAMILY_NAME));

            ParentTabPageOfActiveRichTextBox.Text = cutFileName;
            CurrentFileName = path;
            IsSavedCurrentFile = true;
        }

        private void ActiveRichTextBox_VScroll(object sender, EventArgs e)
        {
            UpdateLineNumbers();
        }

        // ------------------------------------------

        private void CloseCurrentTextFile()
        {
            MainTabControl.TabPages.Remove(MainTabControl.SelectedTab);
            if (MainTabControl.TabPages.Count == 0)
            {
                activeRichTextBox = null;
                SetEnabledMode(false);
                FileStatus = NONE_FILE_STATUS;
            }
        }


        private void SetEnabledMode(bool isTabExist)
        {
            // close
            closeToolStripButton.Enabled = isTabExist;
            closeToolStripMenuItem.Enabled = isTabExist;
            closeOtherToolStripMenuItem.Enabled = isTabExist;
            closeAllToolStripMenuItem.Enabled = isTabExist;

            // save
            saveToolStripButton.Enabled = isTabExist;
            saveToolStripMenuItem.Enabled = isTabExist;
            saveAsToolStripMenuItem.Enabled = isTabExist;
            saveAllToolStripButton.Enabled = isTabExist;
            saveAllToolStripMenuItem.Enabled = isTabExist;

            // printing
            printToolStripButton.Enabled = isTabExist;
            printToolStripMenuItem.Enabled = isTabExist;
            printPreviewToolStripButton.Enabled = isTabExist;
            printPreviewToolStripMenuItem.Enabled = isTabExist;

            // edit
            cutToolStripButton.Enabled = isTabExist;
            cutToolStripMenuItem.Enabled = isTabExist;
            copyToolStripButton.Enabled = isTabExist;
            copyToolStripMenuItem.Enabled = isTabExist;
            pasteToolStripButton.Enabled = isTabExist;
            pasteToolStripMenuItem.Enabled = isTabExist;
            deleteToolStripMenuItem.Enabled = isTabExist;
            selectAllToolStripMenuItem.Enabled = isTabExist;
            undoToolStripButton.Enabled = isTabExist;
            undoToolStripMenuItem.Enabled = isTabExist;
            redoToolStripButton.Enabled = isTabExist;
            redoToolStripMenuItem.Enabled = isTabExist;

            // fonts
            custom1ToolStripMenuItem.Enabled = isTabExist;
            custom2LucideConsole10ToolStripMenuItem.Enabled = isTabExist;
            custom3Arial10ToolStripMenuItem.Enabled = isTabExist;
            setFontsToolStripMenuItem.Enabled = isTabExist;
            boldToolStripMenuItem.Enabled = isTabExist;
            italicToolStripMenuItem.Enabled = isTabExist;
            underlineToolStripMenuItem.Enabled = isTabExist;
            strikeoutToolStripMenuItem.Enabled = isTabExist;

            // find / replace
            findReplaceToolStripButton.Enabled = isTabExist;
            findToolStripMenuItem.Enabled = isTabExist;

            // line numbers
            lineNumbersToolStripMenuItem.Enabled = isTabExist;
            lineNumbersToolStripButton.Enabled = isTabExist;

            // run macro
            runMacroToolStripButton.Enabled = isTabExist;
            runMacroToolStripMenuItem.Enabled = isTabExist;
        }

        #region Find / Replace System

        public void Find(RequestIndexes indexes)
        {
            activeRichTextBox.SelectionStart = indexes.IndexStart;
            activeRichTextBox.SelectionLength = indexes.IndexEnd - indexes.IndexStart;
            activeRichTextBox.Focus();
        }

        public void ReplaceCurrent(String replaceString)
        {
            Clipboard.SetText(replaceString);
            activeRichTextBox.Paste();
        }

        public void ReplaceAll(RequestIndexes[] indexesArray, String replaceString)
        {
            for(Int32 i = 0; i < indexesArray.Length; i++)
            {
                Find(indexesArray[i]);
                ReplaceCurrent(replaceString);
            }
        }
        #endregion

        #region Recent Files System

        private void AddToRecentFiles(String pathToRecentFile)
        {
            XmlNode recentFilesNode = xInfoDocument.DocumentElement.GetElementsByTagName(XML_NAME_RECENT_FILES)[0];
            if (recentFilesNode.ChildNodes.Count >= 5 && recentFilesToolStripMenuItem.DropDownItems.Count >= 5 && GetNodeInXmlDocument(pathToRecentFile) == null)
            {
                recentFilesNode.RemoveChild(recentFilesNode.LastChild);
                recentFilesToolStripMenuItem.DropDownItems.RemoveAt(recentFilesToolStripMenuItem.DropDownItems.Count - 1);
            }

            if (GetNodeInXmlDocument(pathToRecentFile) != null && IsFileExistInRecentFilesMenuItems(pathToRecentFile))
            {
                recentFilesNode.RemoveChild(GetNodeInXmlDocument(pathToRecentFile));
                recentFilesToolStripMenuItem.DropDownItems.RemoveByKey(GetCutNameForPath(pathToRecentFile));
            }

            if (GetNodeInXmlDocument(pathToRecentFile) == null && !IsFileExistInRecentFilesMenuItems(pathToRecentFile))
            {
                XmlNode newRecentFileXmlNode = xInfoDocument.CreateNode(XmlNodeType.Element, "FilePath", recentFilesNode.NamespaceURI);
                newRecentFileXmlNode.InnerText = pathToRecentFile;
                recentFilesNode.InsertBefore(newRecentFileXmlNode, recentFilesNode.FirstChild);

                xInfoDocument.GetElementsByTagName(XML_NAME_ACTIVE_RECENT_FILE_PATH)[0].InnerText = pathToRecentFile;
                xInfoDocument.Save(XML_PATH);

            }

            if (IsFileExistInRecentFilesMenuItems(pathToRecentFile)) return;

            ToolStripMenuItem newRecentFile = new ToolStripMenuItem()
            {
                Name = GetCutNameForPath(pathToRecentFile),
                Text = "1. " + GetCutNameForPath(pathToRecentFile),
                Size = new Size(235, 22),
                Tag = pathToRecentFile
            };
            newRecentFile.Click += new EventHandler(RecentFile_ToolStripMenuItem_Click);
            newRecentFile.MouseEnter += new EventHandler(ToolStripItems_MouseEnter);
            newRecentFile.MouseLeave += new EventHandler(ToolStripItems_MouseLeave);
            newRecentFile.MouseDown += new MouseEventHandler(CheckedRecentFilesToolStripMenuItem_MouseDown);

            UpdateNumbersInResentFiles(true);

            recentFilesToolStripMenuItem.DropDownItems.Insert(0, newRecentFile);
            if (recentFilesToolStripMenuItem.DropDownItems.Count == 2) recentFilesClearToolStripMenuItem.Enabled = true;
        }

        private XmlNode GetNodeInXmlDocument(String comparePath)
        {
            foreach(XmlNode node in xInfoDocument.DocumentElement.GetElementsByTagName(XML_NAME_RECENT_FILES)[0].ChildNodes)
            {
                if (node.InnerText == comparePath) return node;
            }
            return null;
        }

        private bool IsFileExistInRecentFilesMenuItems(String comparePath)
        {
            foreach (ToolStripDropDownItem item in recentFilesToolStripMenuItem.DropDownItems)
            {
                if ( (item.Tag as String) == comparePath ) return true;
            }
            return false;
        }

        private Int32 CountCheckedToolStripMenuItems(ToolStripItemCollection itemCollection)
        {
            Int32 result = 0;
            System.Collections.IEnumerator iter = itemCollection.GetEnumerator();
            while (iter.MoveNext())
            {
                var menuItem = iter.Current as ToolStripMenuItem;
                if (menuItem == null) throw new ArgumentException();

                if (menuItem.Checked) result++;
            }

            return result;
        }
        
        private void UpdateNumbersInResentFiles(bool withCreatedNewResentFile)
        {
            Int32 magicNumber = 0;
            if (withCreatedNewResentFile) magicNumber = 1;

            for (Int32 i = 0; i < recentFilesToolStripMenuItem.DropDownItems.Count; i++)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(?!\d*(\W|\s))(\W|\w|\s)*");
                String currentText = regex.Match(recentFilesToolStripMenuItem.DropDownItems[i].Text).Value;
                recentFilesToolStripMenuItem.DropDownItems[i].Text = ((i + 1 + magicNumber) + ". " + currentText);
            }
        }

        #region Recent Files Events
        private void RecentFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedRecentFileItem = sender as ToolStripMenuItem;
            if (clickedRecentFileItem == null) return;

            String pathToRecentFile = (String) clickedRecentFileItem.Tag;
            OpenTextFile(pathToRecentFile);
        }

        private void RecentFilesClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Если пользователь отказался от сохранения несозданного документа, то не производим никаких действий (эл-ты "Recent Files" должны ссылаться на существующие файлы)
            if (CurrentFileName == String.Empty)
            {
                MessageBox.Show("You don't save the document!");
                // reserve for save system ...
                return;
            }

            xInfoDocument.DocumentElement.GetElementsByTagName(XML_NAME_RECENT_FILES)[0].RemoveAll();
            recentFilesToolStripMenuItem.DropDownItems.Clear();

            AddToRecentFiles(CurrentFileName);
            recentFilesClearToolStripMenuItem.Enabled = false;
        }

        private void CheckedRecentFilesToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            // Если не была нажата требуемая кнопка или выделены все эл-ты в "Recent Files" меню кроме одного (у пользователя не должно быть возможности удалить все эл-ты)
            if (e.Button != MouseButtons.Right) return;

            var item = sender as ToolStripMenuItem;
            if (item == null) return;

            if (item.Checked) item.Checked = !item.Checked;
            else
            {
                if (CountCheckedToolStripMenuItems(recentFilesToolStripMenuItem.DropDownItems) == recentFilesToolStripMenuItem.DropDownItems.Count - 1) return;
                else item.Checked = !item.Checked;
            }

            Int32 countCheckedItems = CountCheckedToolStripMenuItems(recentFilesToolStripMenuItem.DropDownItems);
            if (countCheckedItems > 0) clearSelectedRecentFilesToolStripMenuItem.Enabled = true;
            else clearSelectedRecentFilesToolStripMenuItem.Enabled = false;
        }

        private void ClearSelectedRecentFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Вынесение всех выделенных DrowDownItem'ов в отдельный List<...> для дальнейшего удаления
            var listDropDownItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem item in recentFilesToolStripMenuItem.DropDownItems) if (item.Checked) listDropDownItems.Add(item);

            // Удаление выделенных элементов из коллекции recentFilesToolStripMenuItem.DrowDownItems
            List<ToolStripMenuItem>.Enumerator iter = listDropDownItems.GetEnumerator();
            while (iter.MoveNext()) recentFilesToolStripMenuItem.DropDownItems.Remove(iter.Current);

            UpdateNumbersInResentFiles(false);
            clearSelectedRecentFilesToolStripMenuItem.Enabled = false;
        }
        #endregion

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewTextFile("Text file #" + (MainTabControl.TabPages.Count + 1));
        }
        #endregion

        #region Close Tabs
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsSavedCurrentFile)
            {
                MessageBox.Show("You don't save the document!");
                // reserve for save system ...
            }
            CloseCurrentTextFile();
        }

        private void CloseOtherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentSelectedTab = MainTabControl.SelectedTab;
            Int32 currentCounfOfTabPages = MainTabControl.TabPages.Count;
            for (Int32 i = 0; i < currentCounfOfTabPages - 1; i++)
            {
                if (MainTabControl.TabPages[0] != currentSelectedTab) { MainTabControl.TabPages.Remove(MainTabControl.TabPages[0]); continue; }
                if (MainTabControl.TabPages[1] != currentSelectedTab) { MainTabControl.TabPages.Remove(MainTabControl.TabPages[1]); continue; }
            }
            closeOtherToolStripMenuItem.Enabled = false;
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 currentCounfOfTabPages = MainTabControl.TabPages.Count;
            for (Int32 i = 0; i < currentCounfOfTabPages; i++) CloseCurrentTextFile();
        }
        #endregion

        #region Open Tabs
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenTextFile(OpenFileDialog.FileName);
                AddToRecentFiles(OpenFileDialog.FileName);
            }
        }
        #endregion

        #region Save Tabs
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(CurrentFileName)) { SaveAsToolStripMenuItem_Click(this, new EventArgs()); return; }

            if (SaveFileDialog.FileName.EndsWith("rtf")) activeRichTextBox.SaveFile(CurrentFileName, RichTextBoxStreamType.RichText);
            else activeRichTextBox.SaveFile(CurrentFileName, RichTextBoxStreamType.PlainText);

            IsSavedCurrentFile = true;
            AddToRecentFiles(CurrentFileName);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.FileName = ParentTabPageOfActiveRichTextBox.Text;
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (SaveFileDialog.FileName.EndsWith("rtf")) activeRichTextBox.SaveFile(SaveFileDialog.FileName, RichTextBoxStreamType.RichText);
                else activeRichTextBox.SaveFile(SaveFileDialog.FileName, RichTextBoxStreamType.PlainText);

                CurrentFileName = SaveFileDialog.FileName;
                IsSavedCurrentFile = true;

                String cutFileName = SaveFileDialog.FileName.Remove(0, SaveFileDialog.FileName.LastIndexOf('\\') + 1);
                ParentTabPageOfActiveRichTextBox.Text = cutFileName;

                AddToRecentFiles(CurrentFileName);
            }
        }

        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentSelectedTab = MainTabControl.SelectedTab;
            Int32 currentCounfOfTabPages = MainTabControl.TabPages.Count;
            for (Int32 i = 0; i < currentCounfOfTabPages; i++)
            {
                MainTabControl.SelectedTab = MainTabControl.TabPages[i];
                SaveToolStripMenuItem_Click(this, new EventArgs());
            }
            MainTabControl.SelectedTab = currentSelectedTab;
        }
        #endregion

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsSavedCurrentFile) Application.Exit();
            else MessageBox.Show("You don't save your current file. Please, do it.");
        }

        private void MainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == null) return;
            activeRichTextBox = e.TabPage.Controls[0].Controls.Find(KEY_ACTIVE_RICH_TEXT_BOX, false)[0] as RichTextBox;
            UpdateFileStatus(FileStatus);
        }

        #region Printing
        private void PageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog.ShowDialog();
        }

        private void PrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Printer.PrintPreview(PrintDocument, PrintPreviewDialog);
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Printer.PrintFile(PrintDocument, PrintDialog);
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Printer.BuildDocument(e);
        }
        #endregion

        // Произвести рефакторинг
        private void ActiveRichTextBox_TextChanged(object sender, EventArgs e)
        {
            IsSavedCurrentFile = false;
            if (activeRichTextBox.CanRedo) { redoToolStripMenuItem.Enabled = true; redoToolStripButton.Enabled = true; }
            if (activeRichTextBox.CanUndo) { undoToolStripMenuItem.Enabled = true; undoToolStripButton.Enabled = true; }
            UpdateLineNumbers();

            //var line = activeRichTextBox.GetLineFromCharIndex(activeRichTextBox.GetCharIndexFromPosition(new Point(1, 1))) - 5;
            //Int32 a = 0;
            //if (line > 0)
            //    a = activeRichTextBox.GetFirstCharIndexFromLine(
            //        activeRichTextBox.GetLineFromCharIndex(
            //            activeRichTextBox.GetCharIndexFromPosition(new Point(1, 1))) - 5);

            //if (a >= 0)
            //    activeRichTextBox.SelectionStart = a;

            //activeRichTextBox.SelectionStart = LengthLineInTextBox(activeRichTextBox.SelectionStart) - 1;

            //if (g.MeasureString(activeRichTextBox.Text, activeRichTextBox.Font).Width > activeRichTextBox.Width) hScrollBarTextBox.Enabled = true;
            //else hScrollBarTextBox.Enabled = false;


        }

        #region Update line numbers | Not finished
        private void UpdateLineNumbers()
        {
            SetLineNumbers(ActiveLineNumbersListBox, GetCountLinesOfString(activeRichTextBox.Text));
            ActiveLineNumbersListBox.TopIndex = activeRichTextBox.GetLineFromCharIndex(activeRichTextBox.GetCharIndexFromPosition(
                new Point(1, 1)));
        }

        private bool IsHScrollNeed()
        {
            bool isNeed = false;
            Int32 countOfLines = GetCountLinesOfString(activeRichTextBox.Text);
            for (Int32 i = 0; i < countOfLines; i++)
            {
                // ...
            }
            return isNeed;
        }

        private Int32 LengthLineInTextBox(Int32 selectionStart)
        {
            Int32 lengthCurrentLine = 0;
            Int32 startIndexCurrentLine = activeRichTextBox.GetFirstCharIndexFromLine(activeRichTextBox.GetLineFromCharIndex(selectionStart));
            for (Int32 i = 0; activeRichTextBox.Text[startIndexCurrentLine + i] != '\n'; i++) lengthCurrentLine++;

            String currentLine = activeRichTextBox.Text.Substring(startIndexCurrentLine, lengthCurrentLine - 1);
            return lengthCurrentLine;
        }

        private void LineNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lineNumbersToolStripMenuItem.Checked)
            {
                ActiveLineNumbersListBox.Visible = false;
                lineNumbersToolStripMenuItem.Checked = false;
                lineNumbersToolStripButton.Image = Properties.Resources.line_numbers_no_enabled_icon;
                lineNumbersToolStripButton.BackColor = Color.FromKnownColor(KnownColor.Control);
                
            }
            else
            {
                ActiveLineNumbersListBox.Visible = true;
                lineNumbersToolStripMenuItem.Checked = true;
                lineNumbersToolStripButton.Image = Properties.Resources.line_numbers_enabled_icon;
                lineNumbersToolStripButton.BackColor = Color.FromKnownColor(KnownColor.GradientActiveCaption);
            } 
        }
        #endregion

        #region Edit
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeRichTextBox.CanUndo) activeRichTextBox.Undo();
            if (!activeRichTextBox.CanUndo) { undoToolStripMenuItem.Enabled = false; undoToolStripButton.Enabled = false; }
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeRichTextBox.CanRedo) activeRichTextBox.Redo();
            if (!activeRichTextBox.CanRedo) { redoToolStripMenuItem.Enabled = false; redoToolStripButton.Enabled = false; }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeRichTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeRichTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeRichTextBox.Paste();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activeRichTextBox.SelectionLength == 0) activeRichTextBox.SelectionLength = 1;
            activeRichTextBox.Cut();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeRichTextBox.SelectAll();
        }
        #endregion

        #region Font
        private void SetFontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                activeRichTextBox.Font = FontDialog.Font;
                ActiveLineNumbersListBox.Font = activeRichTextBox.Font;
                Fonter.SwitchFont(sender as ToolStripMenuItem);
            }
        }

        private void Default_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeRichTextBox.Font = Fonter.GetFont(new FontFamily(COURIER_NEW_FONT_FAMILY_NAME), activeRichTextBox.Font.Style, activeRichTextBox.Font.Size);
            ActiveLineNumbersListBox.Font = activeRichTextBox.Font;
            Fonter.SwitchFont(sender as ToolStripMenuItem);
        }

        private void Custom1_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeRichTextBox.Font = Fonter.GetFont(new FontFamily(VERDANA_FONT_FAMILY_NAME), activeRichTextBox.Font.Style, activeRichTextBox.Font.Size);
            ActiveLineNumbersListBox.Font = activeRichTextBox.Font;
            Fonter.SwitchFont(sender as ToolStripMenuItem);
        }

        private void Custom2_LucideConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeRichTextBox.Font =Fonter.GetFont(new FontFamily(LUCIDA_CONSOLE_FONT_FAMILY_NAME), activeRichTextBox.Font.Style, activeRichTextBox.Font.Size);
            ActiveLineNumbersListBox.Font = activeRichTextBox.Font;
            Fonter.SwitchFont(sender as ToolStripMenuItem);
        }

        private void Custom3_ArialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeRichTextBox.Font = Fonter.GetFont(new FontFamily(ARIAL_FONT_FAMILY_NAME), activeRichTextBox.Font.Style, activeRichTextBox.Font.Size);
            ActiveLineNumbersListBox.Font = activeRichTextBox.Font;
            Fonter.SwitchFont(sender as ToolStripMenuItem);
        }
        #endregion

        #region Characters Style and ToolStripItems Events
        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fonter.SwitchCharStyle(sender as ToolStripMenuItem)) activeRichTextBox.Font = Fonter.GetFont(activeRichTextBox.Font.FontFamily, FontStyle.Bold);
            else activeRichTextBox.Font = Fonter.GetFont(activeRichTextBox.Font.FontFamily);
        }

        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fonter.SwitchCharStyle(sender as ToolStripMenuItem)) activeRichTextBox.Font = Fonter.GetFont(activeRichTextBox.Font.FontFamily, FontStyle.Italic);
            else activeRichTextBox.Font = Fonter.GetFont(activeRichTextBox.Font.FontFamily);
        }

        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fonter.SwitchCharStyle(sender as ToolStripMenuItem)) activeRichTextBox.Font = Fonter.GetFont(activeRichTextBox.Font.FontFamily, FontStyle.Underline);
            else activeRichTextBox.Font = Fonter.GetFont(activeRichTextBox.Font.FontFamily);
        }

        private void StrikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fonter.SwitchCharStyle(sender as ToolStripMenuItem)) activeRichTextBox.Font = Fonter.GetFont(activeRichTextBox.Font.FontFamily, FontStyle.Strikeout);
            else activeRichTextBox.Font = Fonter.GetFont(activeRichTextBox.Font.FontFamily);
        }

        private void ToolStripItems_MouseEnter(object sender, EventArgs e)
        {
            String strResult = null;
            switch( (sender as ToolStripItem).Text )
            {
                case "New": case "&New": strResult = "Create a new document"; break;
                case "Open": case "&Open...": strResult = "Open an existing document"; break;
                case "Close": case "&Close": strResult = "Close the active document (without saving)"; break;
                case "&Close Other": strResult = "Close all documents except the current one (without saving)"; break;
                case "&Close All": strResult = "Close all documents (without saving)"; break;
                case "Save": case "&Save": strResult = "Save the active document"; break;
                case "&Save As...": strResult = "Save the active document with a new name"; break;
                case "Save All": case "&Save All": strResult = "Save all documents"; break;
                case "Print": case "&Print...": strResult = "Print the active document"; break;
                case "Print Preview": case "&Print Preview": strResult = "Display full pages"; break;
                case "&Page Setup...": strResult = "Change the page options"; break;
                case "&Exit": strResult = "Quit the application; prompts to save documents"; break;
                case "Undo": case "&Undo": strResult = "Undo the last action"; break;
                case "Redo": case "&Redo": strResult = "Redo the previously undone action"; break;
                case "Cut": case "&Cut": strResult = "Cut it selection and put it on the Clipboard"; break;
                case "Copy": case "&Copy": strResult = "Copy it selection and put it on the Clipboard"; break;
                case "Paste": case "&Paste": strResult = "Insert Clipboards content"; break;
                case "Delete": case "&Delete": strResult = "Delete the selection"; break;
                case "&Select All": strResult = "Select the entire document"; break;
                case "&Default (Courier New, 10)": strResult = "Default (Font Family: Courier New, Size: 10, Font Style: Regular)"; break;
                case "&Custom 1 (Verdana, 10)": strResult = "Custom 1 (Font Family: Verdana, Size: 10, Font Style: Regular)"; break;
                case "&Custom 2 (Lucida Console, 10)": strResult = "Custom 2 (Font Family: Lucida Console, Size: 10, Font Style: Regular)"; break;
                case "&Custom 3 (Arial, 10)": strResult = "Custom 3 (Font Family: Arial, Size: 10, Font Style: Regular)"; break;
                case "&Set Fonts...": strResult = "Configure font settings"; break;
                case "&Bold": strResult = "Set bold characters style"; break;
                case "&Italic": strResult = "Set italic characters style"; break;
                case "&Underline": strResult = "Set underline characters style"; break;
                case "&Strikeout": strResult = "Set strikeout characters style"; break;
                case "&Line Numbers": case "Line Numbers": strResult = "Show line numbers"; break;
                case "&Compile and Run Macro": case "Compile and Run Macro": strResult = "Compile macro and run it"; break;
                default:
                    {
                        if ((sender as ToolStripItem).OwnerItem == recentFilesToolStripMenuItem) {
                            strResult = "Open this document";
                        }
                        break;
                    }
            }
            actionStatusToolStripStatusLabel.Text = strResult;
        }

        private void ToolStripItems_MouseLeave(object sender, EventArgs e)
        {
            actionStatusToolStripStatusLabel.Text = String.Empty;
        }

        #endregion

        #region Context Menu
        private void TabPageContextMenuStrip_VisibleChanged(object sender, EventArgs e)
        {
            if (!TabPageContextMenuStrip.Visible) return;
            if (File.Exists(CurrentFileName)) { showExplorerToolStripContextMenuItem.Enabled = true; copyFilePathToolStripContextMenuItem.Enabled = true; }
            else { showExplorerToolStripContextMenuItem.Enabled = false; copyFilePathToolStripContextMenuItem.Enabled = false; }
        }

        private void ShowExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String pathToFolder = CurrentFileName.Remove(CurrentFileName.LastIndexOf('\\'), CurrentFileName.Length - CurrentFileName.LastIndexOf('\\'));
            System.Diagnostics.Process.Start("Explorer.exe", "/n," + pathToFolder);
        }

        private void CopyFilePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CurrentFileName);
        }
        #endregion

        #region Find / Replace Menu
        private void FindToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FindReplaceForm().Show(this);
        }
        #endregion

        #region Macros Menu | Not Finished
        private void AddAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (macro == null) macro = new ClassMacros();
            //macro.AddAssembly(CurrentFileName);//.Remove(0, CurrentFileName.LastIndexOf(@"\") + 1));
        }

        private void RunMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (macro == null) macro = new ClassMacros();
            macro.RunMacro(CurrentFileName);
        }
        #endregion
    }

    public class RichTextBoxData
    {
        public bool isSaved;
        public String fileName;
        public String fileStatus;
        public TabPage parentTabPage;
        public MyListBox activeListBox;
    }
}