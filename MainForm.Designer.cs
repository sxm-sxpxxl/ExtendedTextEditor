namespace ExtendedTextEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (!IsSavedCurrentFile) SaveAsToolStripMenuItem_Click(this, new System.EventArgs());

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectedRecentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOtherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPrevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.findInFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarsViewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.lineNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenFontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custom1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custom2LucideConsole10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custom3Arial10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.setFontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.macrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TabPageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOtherToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewPrintToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.showExplorerToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFilePathToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarIconImageList = new System.Windows.Forms.ImageList(this.components);
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.findReplaceToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lineNumbersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.runMacroToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.actionStatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileStatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.hScrollBarTextBox = new System.Windows.Forms.HScrollBar();
            this.vScrollBarTextBox = new System.Windows.Forms.VScrollBar();
            this.MenuStrip.SuspendLayout();
            this.TabPageContextMenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.macrosToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(978, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.recentFilesToolStripMenuItem,
            this.clearSelectedRecentFilesToolStripMenuItem,
            this.recentFilesClearToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem,
            this.closeOtherToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            this.newToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.newToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            this.openToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.openToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.recentFilesToolStripMenuItem.Text = "&Recent Files";
            // 
            // clearSelectedRecentFilesToolStripMenuItem
            // 
            this.clearSelectedRecentFilesToolStripMenuItem.Enabled = false;
            this.clearSelectedRecentFilesToolStripMenuItem.Name = "clearSelectedRecentFilesToolStripMenuItem";
            this.clearSelectedRecentFilesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.clearSelectedRecentFilesToolStripMenuItem.Text = "&Clear Selected Recent Files";
            this.clearSelectedRecentFilesToolStripMenuItem.Click += new System.EventHandler(this.ClearSelectedRecentFilesToolStripMenuItem_Click);
            // 
            // recentFilesClearToolStripMenuItem
            // 
            this.recentFilesClearToolStripMenuItem.Enabled = false;
            this.recentFilesClearToolStripMenuItem.Name = "recentFilesClearToolStripMenuItem";
            this.recentFilesClearToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.recentFilesClearToolStripMenuItem.Text = "&Clear Recent Files";
            this.recentFilesClearToolStripMenuItem.Click += new System.EventHandler(this.RecentFilesClearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            this.closeToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.closeToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // closeOtherToolStripMenuItem
            // 
            this.closeOtherToolStripMenuItem.Enabled = false;
            this.closeOtherToolStripMenuItem.Name = "closeOtherToolStripMenuItem";
            this.closeOtherToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.closeOtherToolStripMenuItem.Text = "&Close Other";
            this.closeOtherToolStripMenuItem.Click += new System.EventHandler(this.CloseOtherToolStripMenuItem_Click);
            this.closeOtherToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.closeOtherToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Enabled = false;
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.closeAllToolStripMenuItem.Text = "&Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            this.closeAllToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.closeAllToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            this.saveToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.saveToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            this.saveAsToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.saveAsToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Enabled = false;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveAllToolStripMenuItem.Text = "&Save All";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.SaveAllToolStripMenuItem_Click);
            this.saveAllToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.saveAllToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.printToolStripMenuItem.Text = "&Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            this.printToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.printToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Enabled = false;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.printPreviewToolStripMenuItem.Text = "&Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItem_Click);
            this.printPreviewToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.printPreviewToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.pageSetupToolStripMenuItem.Text = "&Page Setup...";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.PageSetupToolStripMenuItem_Click);
            this.pageSetupToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.pageSetupToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(210, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator5,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator6,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            this.undoToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.undoToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            this.redoToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.redoToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            this.toolStripSeparator5.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "&Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            this.cutToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.cutToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            this.copyToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.copyToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            this.pasteToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.pasteToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            this.deleteToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.deleteToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            this.toolStripSeparator6.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Enabled = false;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "&Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            this.selectAllToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.selectAllToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.toolStripSeparator7,
            this.findNextToolStripMenuItem,
            this.findPrevToolStripMenuItem,
            this.toolStripSeparator8,
            this.findInFilesToolStripMenuItem,
            this.goToToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findToolStripMenuItem.Text = "&Find / Replace...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.FindToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Enabled = false;
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findNextToolStripMenuItem.Text = "&Find Next";
            // 
            // findPrevToolStripMenuItem
            // 
            this.findPrevToolStripMenuItem.Enabled = false;
            this.findPrevToolStripMenuItem.Name = "findPrevToolStripMenuItem";
            this.findPrevToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findPrevToolStripMenuItem.Text = "&Find Prev";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // findInFilesToolStripMenuItem
            // 
            this.findInFilesToolStripMenuItem.Enabled = false;
            this.findInFilesToolStripMenuItem.Name = "findInFilesToolStripMenuItem";
            this.findInFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findInFilesToolStripMenuItem.Text = "&Find in Files...";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Enabled = false;
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToToolStripMenuItem.Text = "&Go To...";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarsViewsToolStripMenuItem,
            this.toolStripSeparator9,
            this.lineNumbersToolStripMenuItem,
            this.screenFontsToolStripMenuItem,
            this.charactersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // toolbarsViewsToolStripMenuItem
            // 
            this.toolbarsViewsToolStripMenuItem.Enabled = false;
            this.toolbarsViewsToolStripMenuItem.Name = "toolbarsViewsToolStripMenuItem";
            this.toolbarsViewsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.toolbarsViewsToolStripMenuItem.Text = "&Toolbars/Views";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(155, 6);
            // 
            // lineNumbersToolStripMenuItem
            // 
            this.lineNumbersToolStripMenuItem.Checked = true;
            this.lineNumbersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineNumbersToolStripMenuItem.Name = "lineNumbersToolStripMenuItem";
            this.lineNumbersToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.lineNumbersToolStripMenuItem.Text = "&Line Numbers";
            this.lineNumbersToolStripMenuItem.Click += new System.EventHandler(this.LineNumbersToolStripMenuItem_Click);
            this.lineNumbersToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.lineNumbersToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // screenFontsToolStripMenuItem
            // 
            this.screenFontsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.custom1ToolStripMenuItem,
            this.custom2LucideConsole10ToolStripMenuItem,
            this.custom3Arial10ToolStripMenuItem,
            this.toolStripSeparator13,
            this.setFontsToolStripMenuItem});
            this.screenFontsToolStripMenuItem.Name = "screenFontsToolStripMenuItem";
            this.screenFontsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.screenFontsToolStripMenuItem.Text = "&Fonts";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Checked = true;
            this.defaultToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.defaultToolStripMenuItem.Text = "&Default (Courier New, 10)";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.Default_ToolStripMenuItem_Click);
            this.defaultToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.defaultToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // custom1ToolStripMenuItem
            // 
            this.custom1ToolStripMenuItem.Enabled = false;
            this.custom1ToolStripMenuItem.Name = "custom1ToolStripMenuItem";
            this.custom1ToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.custom1ToolStripMenuItem.Text = "&Custom 1 (Verdana, 10)";
            this.custom1ToolStripMenuItem.Click += new System.EventHandler(this.Custom1_ToolStripMenuItem_Click);
            this.custom1ToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.custom1ToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // custom2LucideConsole10ToolStripMenuItem
            // 
            this.custom2LucideConsole10ToolStripMenuItem.Enabled = false;
            this.custom2LucideConsole10ToolStripMenuItem.Name = "custom2LucideConsole10ToolStripMenuItem";
            this.custom2LucideConsole10ToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.custom2LucideConsole10ToolStripMenuItem.Text = "&Custom 2 (Lucida Console, 10)";
            this.custom2LucideConsole10ToolStripMenuItem.Click += new System.EventHandler(this.Custom2_LucideConsoleToolStripMenuItem_Click);
            this.custom2LucideConsole10ToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.custom2LucideConsole10ToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // custom3Arial10ToolStripMenuItem
            // 
            this.custom3Arial10ToolStripMenuItem.Enabled = false;
            this.custom3Arial10ToolStripMenuItem.Name = "custom3Arial10ToolStripMenuItem";
            this.custom3Arial10ToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.custom3Arial10ToolStripMenuItem.Text = "&Custom 3 (Arial, 10)";
            this.custom3Arial10ToolStripMenuItem.Click += new System.EventHandler(this.Custom3_ArialToolStripMenuItem_Click);
            this.custom3Arial10ToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.custom3Arial10ToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(232, 6);
            this.toolStripSeparator13.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            // 
            // setFontsToolStripMenuItem
            // 
            this.setFontsToolStripMenuItem.Enabled = false;
            this.setFontsToolStripMenuItem.Name = "setFontsToolStripMenuItem";
            this.setFontsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.setFontsToolStripMenuItem.Text = "&Set Fonts...";
            this.setFontsToolStripMenuItem.Click += new System.EventHandler(this.SetFontsToolStripMenuItem_Click);
            this.setFontsToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.setFontsToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikeoutToolStripMenuItem});
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.charactersToolStripMenuItem.Text = "&Characters Style";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Enabled = false;
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.boldToolStripMenuItem.Text = "&Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.BoldToolStripMenuItem_Click);
            this.boldToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.boldToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Enabled = false;
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.italicToolStripMenuItem.Text = "&Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolStripMenuItem_Click);
            this.italicToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.italicToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Enabled = false;
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.underlineToolStripMenuItem.Text = "&Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.UnderlineToolStripMenuItem_Click);
            this.underlineToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.underlineToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // strikeoutToolStripMenuItem
            // 
            this.strikeoutToolStripMenuItem.Enabled = false;
            this.strikeoutToolStripMenuItem.Name = "strikeoutToolStripMenuItem";
            this.strikeoutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.strikeoutToolStripMenuItem.Text = "&Strikeout";
            this.strikeoutToolStripMenuItem.Click += new System.EventHandler(this.StrikeoutToolStripMenuItem_Click);
            this.strikeoutToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.strikeoutToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // macrosToolStripMenuItem
            // 
            this.macrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runMacroToolStripMenuItem,
            this.toolStripSeparator21,
            this.macrosToolStripMenuItem1});
            this.macrosToolStripMenuItem.Name = "macrosToolStripMenuItem";
            this.macrosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.macrosToolStripMenuItem.Text = "&Macros";
            // 
            // runMacroToolStripMenuItem
            // 
            this.runMacroToolStripMenuItem.Name = "runMacroToolStripMenuItem";
            this.runMacroToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.runMacroToolStripMenuItem.Text = "&Compile and Run Macro";
            this.runMacroToolStripMenuItem.Click += new System.EventHandler(this.RunMacroToolStripMenuItem_Click);
            this.runMacroToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.runMacroToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(200, 6);
            // 
            // macrosToolStripMenuItem1
            // 
            this.macrosToolStripMenuItem1.Enabled = false;
            this.macrosToolStripMenuItem1.Name = "macrosToolStripMenuItem1";
            this.macrosToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.macrosToolStripMenuItem1.Text = "&Macros";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Enabled = false;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // MainTabControl
            // 
            this.MainTabControl.ContextMenuStrip = this.TabPageContextMenuStrip;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ImageList = this.ToolbarIconImageList;
            this.MainTabControl.Location = new System.Drawing.Point(0, 49);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(961, 354);
            this.MainTabControl.TabIndex = 1;
            this.MainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.MainTabControl_Selected);
            // 
            // TabPageContextMenuStrip
            // 
            this.TabPageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripContextMenuItem,
            this.openToolStripContextMenuItem,
            this.toolStripSeparator20,
            this.closeToolStripContextMenuItem,
            this.closeOtherToolStripContextMenuItem,
            this.closeAllToolStripContextMenuItem,
            this.toolStripSeparator17,
            this.saveToolStripContextMenuItem,
            this.saveAsToolStripContextMenuItem,
            this.toolStripSeparator18,
            this.printToolStripContextMenuItem,
            this.previewPrintToolStripContextMenuItem,
            this.toolStripSeparator19,
            this.showExplorerToolStripContextMenuItem,
            this.copyFilePathToolStripContextMenuItem});
            this.TabPageContextMenuStrip.Name = "TabPageContextMenuStrip";
            this.TabPageContextMenuStrip.Size = new System.Drawing.Size(196, 270);
            this.TabPageContextMenuStrip.VisibleChanged += new System.EventHandler(this.TabPageContextMenuStrip_VisibleChanged);
            // 
            // newToolStripContextMenuItem
            // 
            this.newToolStripContextMenuItem.Name = "newToolStripContextMenuItem";
            this.newToolStripContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.newToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newToolStripContextMenuItem.Text = "New";
            this.newToolStripContextMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripContextMenuItem
            // 
            this.openToolStripContextMenuItem.Name = "openToolStripContextMenuItem";
            this.openToolStripContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.openToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openToolStripContextMenuItem.Text = "Open...";
            this.openToolStripContextMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(192, 6);
            // 
            // closeToolStripContextMenuItem
            // 
            this.closeToolStripContextMenuItem.Name = "closeToolStripContextMenuItem";
            this.closeToolStripContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.closeToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.closeToolStripContextMenuItem.Text = "Close";
            this.closeToolStripContextMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // closeOtherToolStripContextMenuItem
            // 
            this.closeOtherToolStripContextMenuItem.Name = "closeOtherToolStripContextMenuItem";
            this.closeOtherToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.closeOtherToolStripContextMenuItem.Text = "Close Other";
            this.closeOtherToolStripContextMenuItem.Click += new System.EventHandler(this.CloseOtherToolStripMenuItem_Click);
            // 
            // closeAllToolStripContextMenuItem
            // 
            this.closeAllToolStripContextMenuItem.Name = "closeAllToolStripContextMenuItem";
            this.closeAllToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.closeAllToolStripContextMenuItem.Text = "Close All";
            this.closeAllToolStripContextMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(192, 6);
            // 
            // saveToolStripContextMenuItem
            // 
            this.saveToolStripContextMenuItem.Name = "saveToolStripContextMenuItem";
            this.saveToolStripContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripContextMenuItem.Text = "Save";
            this.saveToolStripContextMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripContextMenuItem
            // 
            this.saveAsToolStripContextMenuItem.Name = "saveAsToolStripContextMenuItem";
            this.saveAsToolStripContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripContextMenuItem.Text = "Save As...";
            this.saveAsToolStripContextMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(192, 6);
            // 
            // printToolStripContextMenuItem
            // 
            this.printToolStripContextMenuItem.Name = "printToolStripContextMenuItem";
            this.printToolStripContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.printToolStripContextMenuItem.Text = "Print...";
            this.printToolStripContextMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // previewPrintToolStripContextMenuItem
            // 
            this.previewPrintToolStripContextMenuItem.Name = "previewPrintToolStripContextMenuItem";
            this.previewPrintToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.previewPrintToolStripContextMenuItem.Text = "Print Preview";
            this.previewPrintToolStripContextMenuItem.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(192, 6);
            // 
            // showExplorerToolStripContextMenuItem
            // 
            this.showExplorerToolStripContextMenuItem.Enabled = false;
            this.showExplorerToolStripContextMenuItem.Name = "showExplorerToolStripContextMenuItem";
            this.showExplorerToolStripContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.showExplorerToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.showExplorerToolStripContextMenuItem.Text = "Show Explorer";
            this.showExplorerToolStripContextMenuItem.Click += new System.EventHandler(this.ShowExplorerToolStripMenuItem_Click);
            // 
            // copyFilePathToolStripContextMenuItem
            // 
            this.copyFilePathToolStripContextMenuItem.Enabled = false;
            this.copyFilePathToolStripContextMenuItem.Name = "copyFilePathToolStripContextMenuItem";
            this.copyFilePathToolStripContextMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.copyFilePathToolStripContextMenuItem.Size = new System.Drawing.Size(195, 22);
            this.copyFilePathToolStripContextMenuItem.Text = "Copy File Path";
            this.copyFilePathToolStripContextMenuItem.Click += new System.EventHandler(this.CopyFilePathToolStripMenuItem_Click);
            // 
            // ToolbarIconImageList
            // 
            this.ToolbarIconImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ToolbarIconImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ToolbarIconImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "RTF files|*.rtf|Text files|*.txt|CSharp Files(*.cs)|*.cs|All files|*.*";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileName = "NewTextFile";
            this.SaveFileDialog.Filter = "RTF files|*.rtf|Text files|*.txt|CSharp Files(*.cs)|*.cs";
            // 
            // PrintDocument
            // 
            this.PrintDocument.DocumentName = "Extended Text Editor Document";
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // PrintDialog
            // 
            this.PrintDialog.Document = this.PrintDocument;
            this.PrintDialog.UseEXDialog = true;
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Document = this.PrintDocument;
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // PageSetupDialog
            // 
            this.PageSetupDialog.Document = this.PrintDocument;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.closeToolStripButton,
            this.toolStripSeparator10,
            this.saveToolStripButton,
            this.saveAllToolStripButton,
            this.toolStripSeparator11,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator14,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator15,
            this.undoToolStripButton,
            this.redoToolStripButton,
            this.toolStripSeparator16,
            this.findReplaceToolStripButton,
            this.lineNumbersToolStripButton,
            this.runMacroToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(978, 25);
            this.ToolStrip.Stretch = true;
            this.ToolStrip.TabIndex = 3;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.create_file_icon;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            this.newToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.newToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.BackColor = System.Drawing.SystemColors.Control;
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.open_file_icon;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            this.openToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.openToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // closeToolStripButton
            // 
            this.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeToolStripButton.Enabled = false;
            this.closeToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.close_file_icon;
            this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolStripButton.Name = "closeToolStripButton";
            this.closeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.closeToolStripButton.Text = "Close";
            this.closeToolStripButton.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            this.closeToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.closeToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.save_file_icon;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            this.saveToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.saveToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // saveAllToolStripButton
            // 
            this.saveAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAllToolStripButton.Enabled = false;
            this.saveAllToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.save_all_files_icon;
            this.saveAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAllToolStripButton.Name = "saveAllToolStripButton";
            this.saveAllToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveAllToolStripButton.Text = "Save All";
            this.saveAllToolStripButton.Click += new System.EventHandler(this.SaveAllToolStripMenuItem_Click);
            this.saveAllToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.saveAllToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Enabled = false;
            this.printToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.print_file_icon;
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Print";
            this.printToolStripButton.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            this.printToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.printToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Enabled = false;
            this.printPreviewToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.print_preview_file_icon;
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Print Preview";
            this.printPreviewToolStripButton.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItem_Click);
            this.printPreviewToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.printPreviewToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Enabled = false;
            this.cutToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.cut_icon;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "Cut";
            this.cutToolStripButton.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            this.cutToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.cutToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Enabled = false;
            this.copyToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.copy_icon;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            this.copyToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.copyToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Enabled = false;
            this.pasteToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.paste_icon;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            this.pasteToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.pasteToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // undoToolStripButton
            // 
            this.undoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoToolStripButton.Enabled = false;
            this.undoToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.undo_icon;
            this.undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStripButton.Name = "undoToolStripButton";
            this.undoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.undoToolStripButton.Text = "Undo";
            this.undoToolStripButton.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            this.undoToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.undoToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // redoToolStripButton
            // 
            this.redoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoToolStripButton.Enabled = false;
            this.redoToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.redo_icon;
            this.redoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoToolStripButton.Name = "redoToolStripButton";
            this.redoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.redoToolStripButton.Text = "Redo";
            this.redoToolStripButton.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            this.redoToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.redoToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // findReplaceToolStripButton
            // 
            this.findReplaceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findReplaceToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.find_icon;
            this.findReplaceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findReplaceToolStripButton.Name = "findReplaceToolStripButton";
            this.findReplaceToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.findReplaceToolStripButton.Text = "Find / Replace";
            // 
            // lineNumbersToolStripButton
            // 
            this.lineNumbersToolStripButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lineNumbersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineNumbersToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.line_numbers_enabled_icon;
            this.lineNumbersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineNumbersToolStripButton.Name = "lineNumbersToolStripButton";
            this.lineNumbersToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.lineNumbersToolStripButton.Text = "Line Numbers";
            this.lineNumbersToolStripButton.Click += new System.EventHandler(this.LineNumbersToolStripMenuItem_Click);
            this.lineNumbersToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.lineNumbersToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // runMacroToolStripButton
            // 
            this.runMacroToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runMacroToolStripButton.Image = global::ExtendedTextEditor.Properties.Resources.run_macro_icon;
            this.runMacroToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runMacroToolStripButton.Name = "runMacroToolStripButton";
            this.runMacroToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.runMacroToolStripButton.Text = "Compile and Run Macro";
            this.runMacroToolStripButton.Click += new System.EventHandler(this.RunMacroToolStripMenuItem_Click);
            this.runMacroToolStripButton.MouseEnter += new System.EventHandler(this.ToolStripItems_MouseEnter);
            this.runMacroToolStripButton.MouseLeave += new System.EventHandler(this.ToolStripItems_MouseLeave);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionStatusToolStripStatusLabel,
            this.fileStatusToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 420);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(978, 22);
            this.StatusStrip.TabIndex = 4;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // actionStatusToolStripStatusLabel
            // 
            this.actionStatusToolStripStatusLabel.Name = "actionStatusToolStripStatusLabel";
            this.actionStatusToolStripStatusLabel.Size = new System.Drawing.Size(861, 17);
            this.actionStatusToolStripStatusLabel.Spring = true;
            this.actionStatusToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileStatusToolStripStatusLabel
            // 
            this.fileStatusToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.fileStatusToolStripStatusLabel.Name = "fileStatusToolStripStatusLabel";
            this.fileStatusToolStripStatusLabel.Size = new System.Drawing.Size(82, 17);
            this.fileStatusToolStripStatusLabel.Text = "No Document";
            this.fileStatusToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hScrollBarTextBox
            // 
            this.hScrollBarTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBarTextBox.Enabled = false;
            this.hScrollBarTextBox.LargeChange = 1;
            this.hScrollBarTextBox.Location = new System.Drawing.Point(0, 403);
            this.hScrollBarTextBox.Maximum = 10;
            this.hScrollBarTextBox.Name = "hScrollBarTextBox";
            this.hScrollBarTextBox.Size = new System.Drawing.Size(978, 17);
            this.hScrollBarTextBox.TabIndex = 3;
            // 
            // vScrollBarTextBox
            // 
            this.vScrollBarTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBarTextBox.Enabled = false;
            this.vScrollBarTextBox.LargeChange = 1;
            this.vScrollBarTextBox.Location = new System.Drawing.Point(961, 49);
            this.vScrollBarTextBox.Maximum = 10;
            this.vScrollBarTextBox.Name = "vScrollBarTextBox";
            this.vScrollBarTextBox.Size = new System.Drawing.Size(17, 354);
            this.vScrollBarTextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 442);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.vScrollBarTextBox);
            this.Controls.Add(this.hScrollBarTextBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Extended Text Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TabPageContextMenuStrip.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeOtherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPrevToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem findInFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarsViewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem lineNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenFontsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem setFontsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Windows.Forms.PageSetupDialog PageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeoutToolStripMenuItem;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custom1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custom2LucideConsole10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custom3Arial10ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton saveAllToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton undoToolStripButton;
        private System.Windows.Forms.ToolStripButton redoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel actionStatusToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel fileStatusToolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.HScrollBar hScrollBarTextBox;
        private System.Windows.Forms.VScrollBar vScrollBarTextBox;
        private System.Windows.Forms.ContextMenuStrip TabPageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeOtherToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem printToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewPrintToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem showExplorerToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFilePathToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentFilesClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripMenuItem macrosToolStripMenuItem1;
        private System.Windows.Forms.ImageList ToolbarIconImageList;
        private System.Windows.Forms.ToolStripButton findReplaceToolStripButton;
        private System.Windows.Forms.ToolStripButton lineNumbersToolStripButton;
        private System.Windows.Forms.ToolStripButton runMacroToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem clearSelectedRecentFilesToolStripMenuItem;
    }
}

