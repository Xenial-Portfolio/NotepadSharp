using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NotepadSharp.Classes;

namespace NotepadSharp
{
    public partial class NoteSharpCoreForm : Form
    {
        private bool _isSaved;
        private string _path = string.Empty;
        private string _undoText = string.Empty;

        private ThemeController _themeController = new ThemeController();

        public NoteSharpCoreForm()
        {
            InitializeComponent();
        }

        private void NoteSharpCoreForm_Load(object sender, EventArgs e)
        {
            MenuSettingsToolStrip.ForeColor = Color.Wheat;
            KeyPreview = true;
        }

        private void NoteSharpCoreForm_Resize(object sender, EventArgs e)
        {
            HeaderSettingsPanel.Size = new Size(Size.Width, 59);
            NotepadTextBox.Size = new Size(Size.Width - 18, Size.Height - 125);
        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            New();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (NotepadTextBox.CanUndo) NotepadTextBox.Undo();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (NotepadTextBox.CanRedo) NotepadTextBox.Redo();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            
        }

        #region Functions
        private void SaveFile()
        {
            if (!_isSaved)
            {
                SaveAs();
                return;
            }

            File.WriteAllText(_path, NotepadTextBox.Text);
        }

        private void SaveAs()
        {
            _isSaved = true;

            SaveFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(SaveFileDialog.FileName)) return;

            File.WriteAllText(SaveFileDialog.FileName, NotepadTextBox.Text);

            _path = SaveFileDialog.FileName;
            Text = _path;
        }

        private void Open()
        {
            if (!_isSaved && !string.IsNullOrEmpty(NotepadTextBox.Text))
            {
                var msg = MessageBox.Show(@"Do You Want So Save Your Work?", @"Unsaved Work", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes) SaveAs();
            }
            OpenTextFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(OpenTextFileDialog.FileName)) return;

            NotepadTextBox.Text = File.ReadAllText(OpenTextFileDialog.FileName);
            _path = OpenTextFileDialog.FileName;
            Text = _path;
        }

        private void New()
        {
            if (!_isSaved && !string.IsNullOrEmpty(NotepadTextBox.Text))
            {
                var msg = MessageBox.Show(@"Do You Want So Save Your Work?", @"Unsaved Work", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes) SaveAs();
                if (msg == DialogResult.No) Text = @"Blank";
            }
            NotepadTextBox.Text = string.Empty;
        }

        private void ZoomIn()
        {
            if (NotepadTextBox.ZoomFactor == 50f) return;
            NotepadTextBox.ZoomFactor++;

            TextSizeLabel.Text = $@"TextSize: {NotepadTextBox.ZoomFactor}";
        }

        private void ZoomOut()
        {
            if (NotepadTextBox.ZoomFactor == 1f) return;
            NotepadTextBox.ZoomFactor--;

            TextSizeLabel.Text = $@"TextSize: {NotepadTextBox.ZoomFactor}";
        }

        private void FindText()
        {

        }
        #endregion

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _themeController.SetTheme(this);
        }
    }
}