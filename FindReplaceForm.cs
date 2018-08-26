using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedTextEditor
{
    public partial class FindReplaceForm : Form
    {
        private delegate RequestIndexes Operation();
        private ClassFinder finderRequest = null;
        private string activeValueFindWhat = null;

        public FindReplaceForm()
        {
            InitializeComponent();
        }

        private void CreateFinderRequest()
        {
            finderRequest = new ClassFinder((Owner as MainForm).ActiveRichTextBox.Text, FindWhatComboBox.Text, MatchWholeWordCheckBox.Checked, MatchCaseCheckBox.Checked);
            activeValueFindWhat = FindWhatComboBox.Text;
        }

        private void FindNextButton_Click(object sender, EventArgs e)
        {
            if (activeValueFindWhat != FindWhatComboBox.Text) CreateFinderRequest();
            DoOperation(new Operation(finderRequest.Next));
        }

        private void FindPrevButton_Click(object sender, EventArgs e)
        {
            if (activeValueFindWhat != FindWhatComboBox.Text) CreateFinderRequest();
            DoOperation(new Operation(finderRequest.Prev));
        }

        private void DoOperation(Operation operation)
        {
            if (activeValueFindWhat != FindWhatComboBox.Text) CreateFinderRequest();

            if (!finderRequest.IsEmpty())
            {
                (Owner as MainForm).Find(operation());
                SetEnabledForVCLComponents(true);
            }
            else
            {
                MessageBox.Show("Not found! Try again!");
                SetEnabledForVCLComponents(false);
            }
        }

        private void SetEnabledForVCLComponents(bool value)
        {
            FindPrevButton.Enabled = value;
            ReplaceCurrentButton.Enabled = value;
            ReplaceAllButton.Enabled = value;
        }

        private void ReplaceCurrentButton_Click(object sender, EventArgs e)
        {
            if (ReplaceWithComboBox.Text == String.Empty || ReplaceWithComboBox.Text == FindWhatComboBox.Text) { MessageBox.Show("Replace string is empty or it's the same."); return; }

            if (activeValueFindWhat != FindWhatComboBox.Text)
            {
                FindNextButton_Click(this, new EventArgs());
                ReplaceCurrentButton_Click(this, new EventArgs());
                return;
            }

            (Owner as MainForm).ReplaceCurrent(ReplaceWithComboBox.Text);
            finderRequest.RemoveCurrentMatch();

            if (finderRequest.IsEmpty())
            {
                SetEnabledForVCLComponents(false);
                return;
            }

            FindNextButton_Click(this, new EventArgs());
        }

        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {
            if (ReplaceWithComboBox.Text == String.Empty || ReplaceWithComboBox.Text == FindWhatComboBox.Text) { MessageBox.Show("Replace string is empty or it's the same."); return; }

            (Owner as MainForm).ReplaceAll(finderRequest.RequestIndexesArray, ReplaceWithComboBox.Text);
            finderRequest.RemoveAllMatch();

            SetEnabledForVCLComponents(false);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
