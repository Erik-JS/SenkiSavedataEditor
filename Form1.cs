using SenkiSavedataEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenkiSaveEditor
{
    public partial class Form1 : Form
    {
        private TextBox[] GeneralInfoTextBoxes;

        private TextBox[] StatsTextBoxes;

        private Savedata.CharacterInfo _currentCharInfo;

        private int _currentCharIndex = 0;

        private string _savedatafile;

        public Form1()
        {
            InitializeComponent();
            GeneralInfoTextBoxes = new TextBox[] { txtGe0, txtGe1, txtGe2, txtGe3, txtGe4, txtGe5, txtGe6, txtGe7, txtGe8, txtGe9, txtGe10 };
            StatsTextBoxes = new TextBox[] { txtSt0, txtSt1, txtSt2, txtSt3, txtSt4, txtSt5 };
            foreach (var c in Savedata.CharacterDescriptions)
                lstChar.Items.Add(c);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetUpGeneralInfoTextBoxesTagsAndEvents();
            SetUpStatsTextBoxesTagsAndEvents();
        }

        private void SetUpGeneralInfoTextBoxesTagsAndEvents()
        {
            for (int i = 0; i < GeneralInfoTextBoxes.Length; i++)
            {
                GeneralInfoTextBoxes[i].TextChanged += GeneralInfoTextBox_TextChanged;
                GeneralInfoTextBoxes[i].Leave += GeneralInfoTextBox_Leave;
                GeneralInfoTextBoxes[i].Tag = i;
            }
        }

        private void SetUpStatsTextBoxesTagsAndEvents()
        {
            for (int i = 0; i < StatsTextBoxes.Length; i++)
            {
                StatsTextBoxes[i].TextChanged += StatsTextBox_TextChanged;
                StatsTextBoxes[i].Leave += StatsTextBox_Leave;
                StatsTextBoxes[i].Tag = i;
            }
        }

        private void GeneralInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox giTextBox = (TextBox)sender;
            if (!int.TryParse(giTextBox.Text, out int newValue))
                return;
            int GeIdx = (int)giTextBox.Tag;
            _currentCharInfo.GeneralInfo[GeIdx] = newValue;
            Savedata.SetCharacterInfo(_currentCharIndex, _currentCharInfo);
        }

        private void GeneralInfoTextBox_Leave(object sender, EventArgs e)
        {
            TextBox giTextBox = (TextBox)sender;
            int GeIdx = (int)giTextBox.Tag;
            giTextBox.Text = _currentCharInfo.GeneralInfo[GeIdx].ToString();
        }

        private void StatsTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox statTextBox = (TextBox)sender;
            if (!ushort.TryParse(statTextBox.Text, out ushort newValue))
                return;
            int StIdx = (int)statTextBox.Tag;
            _currentCharInfo.Stats[StIdx] = newValue;
            Savedata.SetCharacterInfo(_currentCharIndex, _currentCharInfo);
        }

        private void StatsTextBox_Leave(object sender, EventArgs e)
        {
            TextBox statTextBox = (TextBox)sender;
            int StIdx = (int)statTextBox.Tag;
            statTextBox.Text = _currentCharInfo.Stats[StIdx].ToString();
        }

        private void UpdateGeStTextBoxes()
        {
            var charInfo = Savedata.GetCharacterInfo(_currentCharIndex);

            _currentCharInfo = charInfo;

            for (int i = 0; i < GeneralInfoTextBoxes.Length; i++)
                GeneralInfoTextBoxes[i].Text = _currentCharInfo.GeneralInfo[i].ToString();

            for (int i = 0; i < StatsTextBoxes.Length; i++)
                StatsTextBoxes[i].Text = _currentCharInfo.Stats[i].ToString();
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "SAVEDATA|SAVEDATA|*.*|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            if (!Savedata.LoadFromFile(openFileDialog1.FileName))
                return;
            _savedatafile = openFileDialog1.FileName;
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            tabControl1.Visible = true;
            label2.Text = _savedatafile;
            lstChar.SelectedIndex = -1;
            TextBoxesSetEnabledState(false);
            TextBoxesClearAll();
        }

        private void TextBoxesSetEnabledState(bool v)
        {
            foreach (var g in GeneralInfoTextBoxes)
                g.Enabled = v;
            foreach (var s in StatsTextBoxes)
                s.Enabled = v;
        }

        private void TextBoxesClearAll()
        {
            foreach (var g in GeneralInfoTextBoxes)
                g.Clear();
            foreach (var s in StatsTextBoxes)
                s.Clear();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SAVEDATA|SAVEDATA|*.*|*.*";
            sfd.FileName = "SAVEDATA";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            if (!Savedata.WriteToFile(sfd.FileName))
                return;
            MessageBox.Show("Saved as:\n" + sfd.FileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            _savedatafile = sfd.FileName;
            label2.Text = sfd.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Savedata.WriteToFile(_savedatafile))
                MessageBox.Show("Done.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void lstChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstChar.SelectedIndex == -1)
                return;
            _currentCharIndex = lstChar.SelectedIndex;
            TextBoxesSetEnabledState(true);
            UpdateGeStTextBoxes();
        }
    }
}
