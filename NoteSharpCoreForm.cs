using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NotepadSharp.Classes;

namespace NotepadSharp
{
    public partial class NoteSharpCoreForm : Form
    {
        private bool _isSaved;
        private string _path = string.Empty;
        private int _fontSize = 24;

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

        private void NextButton_Click(object sender, EventArgs e)
        {
            HighLightText();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ReplaceText();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = !SearchPanel.Visible;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = !SearchPanel.Visible;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _themeController.SetTheme(this, MenuSettingsToolStrip.Items, Color.Black, Color.White);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _themeController.SetTheme(this, MenuSettingsToolStrip.Items, Color.Wheat, Color.Black);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _themeController.SetTheme(this, MenuSettingsToolStrip.Items, Color.WhiteSmoke, Color.DodgerBlue);
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _themeController.SetTheme(this, MenuSettingsToolStrip.Items, Color.LightBlue, Color.DarkSlateGray);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _themeController.SetTheme(this, MenuSettingsToolStrip.Items, Color.DarkSlateGray, Color.SpringGreen);
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        private void restoreDefaultRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fontSize = 24;
            NotepadTextBox.Font = new Font("Arial", _fontSize, FontStyle.Bold);
            TextSizeLabel.Text = $@"TextSize: {NotepadTextBox.Font.Size}";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadTextBox.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NotepadTextBox.SelectedText);
        }

        private void decodeSelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotepadTextBox.SelectionLength < 1) return;
            var decodedText = Base64Encoder.Decode(NotepadTextBox.SelectedText);

            MessageBox.Show($@"The Following - {decodedText} was copied to clipboard", @"Decoded Text - Copied To Clipboard",
                 MessageBoxButtons.OK);

            Clipboard.SetText(decodedText);
        }

        private void encodeSelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotepadTextBox.SelectionLength < 1) return;
            var encodedText = Base64Encoder.Encode(NotepadTextBox.SelectedText);

            MessageBox.Show($@"The Following - {encodedText} was copied to clipboard", @"Encoded Text - Copied To Clipboard", MessageBoxButtons.OK);
            Clipboard.SetText(encodedText);
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
            SaveFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(SaveFileDialog.FileName)) return;

            File.WriteAllText(SaveFileDialog.FileName, NotepadTextBox.Text);

            _path = SaveFileDialog.FileName;
            Text = _path;

            _isSaved = true;
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
            if (NotepadTextBox.Font.Size == 50f) return;
            NotepadTextBox.Font = new Font("Arial", _fontSize++, FontStyle.Bold);

            TextSizeLabel.Text = $@"TextSize: {NotepadTextBox.Font.Size}";
        }

        private void ZoomOut()
        {
            if (NotepadTextBox.Font.Size == 1f) return;
            NotepadTextBox.Font = new Font("Arial", _fontSize--, FontStyle.Bold);

            TextSizeLabel.Text = $@"TextSize: {NotepadTextBox.Font.Size}";
        }

        private void HighLightText()
        {
            var flags = TextFormatFlags.Left | TextFormatFlags.Top |
                        TextFormatFlags.NoPadding | TextFormatFlags.WordBreak |
                        TextFormatFlags.TextBoxControl;

            var compareText = SearchTextBox.Text;
            
            var matchesIndex = Regex.Matches(NotepadTextBox.Text, compareText)
                .Select(chr => chr.Index).ToList();

            if (matchesIndex.Count <= 0) return;
            foreach (var position in matchesIndex)
            {
                var p = NotepadTextBox.GetPositionFromCharIndex(position);
                using var g = NotepadTextBox.CreateGraphics();
                
                TextRenderer.DrawText(g, compareText, NotepadTextBox.Font, p,
                    NotepadTextBox.ForeColor, Color.LightGreen, flags);
            }
        }

        private void ReplaceText()
        {
            var compareText = SearchTextBox.Text;
            var replaceText = ReplaceTextBox.Text;

            var notepadNewText = NotepadTextBox.Text.Replace(compareText, replaceText);
            NotepadTextBox.Text = notepadNewText;
        }
        #endregion
    }
}