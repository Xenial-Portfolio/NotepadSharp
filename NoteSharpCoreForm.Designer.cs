
namespace NotepadSharp
{
    partial class NoteSharpCoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotepadTextBox = new System.Windows.Forms.RichTextBox();
            this.HeaderSettingsPanel = new System.Windows.Forms.Panel();
            this.ZoomOutButton = new System.Windows.Forms.Button();
            this.ZoomInButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.TextSizeLabel = new System.Windows.Forms.Label();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.MenuSettingsToolStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textSizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDefaultRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.HeaderSettingsPanel.SuspendLayout();
            this.MenuSettingsToolStrip.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotepadTextBox
            // 
            this.NotepadTextBox.BackColor = System.Drawing.Color.Black;
            this.NotepadTextBox.ForeColor = System.Drawing.Color.White;
            this.NotepadTextBox.Location = new System.Drawing.Point(1, 68);
            this.NotepadTextBox.Name = "NotepadTextBox";
            this.NotepadTextBox.Size = new System.Drawing.Size(1268, 569);
            this.NotepadTextBox.TabIndex = 4;
            this.NotepadTextBox.Text = "";
            // 
            // HeaderSettingsPanel
            // 
            this.HeaderSettingsPanel.BackColor = System.Drawing.Color.Black;
            this.HeaderSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderSettingsPanel.Controls.Add(this.ZoomOutButton);
            this.HeaderSettingsPanel.Controls.Add(this.ZoomInButton);
            this.HeaderSettingsPanel.Controls.Add(this.NewButton);
            this.HeaderSettingsPanel.Controls.Add(this.FindButton);
            this.HeaderSettingsPanel.Controls.Add(this.RedoButton);
            this.HeaderSettingsPanel.Controls.Add(this.UndoButton);
            this.HeaderSettingsPanel.Controls.Add(this.TextSizeLabel);
            this.HeaderSettingsPanel.Controls.Add(this.SaveAsButton);
            this.HeaderSettingsPanel.Controls.Add(this.SaveButton);
            this.HeaderSettingsPanel.Controls.Add(this.OpenButton);
            this.HeaderSettingsPanel.Controls.Add(this.MenuSettingsToolStrip);
            this.HeaderSettingsPanel.Location = new System.Drawing.Point(0, 3);
            this.HeaderSettingsPanel.Name = "HeaderSettingsPanel";
            this.HeaderSettingsPanel.Size = new System.Drawing.Size(1270, 59);
            this.HeaderSettingsPanel.TabIndex = 3;
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomOutButton.ForeColor = System.Drawing.Color.Wheat;
            this.ZoomOutButton.Location = new System.Drawing.Point(743, 28);
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.ZoomOutButton.Size = new System.Drawing.Size(75, 23);
            this.ZoomOutButton.TabIndex = 11;
            this.ZoomOutButton.Text = "Zoom Out";
            this.ZoomOutButton.UseVisualStyleBackColor = true;
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomInButton.ForeColor = System.Drawing.Color.Wheat;
            this.ZoomInButton.Location = new System.Drawing.Point(662, 28);
            this.ZoomInButton.Name = "ZoomInButton";
            this.ZoomInButton.Size = new System.Drawing.Size(75, 23);
            this.ZoomInButton.TabIndex = 10;
            this.ZoomInButton.Text = "Zoom In";
            this.ZoomInButton.UseVisualStyleBackColor = true;
            this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.ForeColor = System.Drawing.Color.Wheat;
            this.NewButton.Location = new System.Drawing.Point(13, 27);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 9;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.ForeColor = System.Drawing.Color.Wheat;
            this.FindButton.Location = new System.Drawing.Point(566, 28);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedoButton.ForeColor = System.Drawing.Color.Wheat;
            this.RedoButton.Location = new System.Drawing.Point(466, 28);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(75, 23);
            this.RedoButton.TabIndex = 7;
            this.RedoButton.Text = "Redo";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.ForeColor = System.Drawing.Color.Wheat;
            this.UndoButton.Location = new System.Drawing.Point(385, 28);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 6;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // TextSizeLabel
            // 
            this.TextSizeLabel.AutoSize = true;
            this.TextSizeLabel.ForeColor = System.Drawing.Color.Wheat;
            this.TextSizeLabel.Location = new System.Drawing.Point(823, 36);
            this.TextSizeLabel.Name = "TextSizeLabel";
            this.TextSizeLabel.Size = new System.Drawing.Size(66, 15);
            this.TextSizeLabel.TabIndex = 5;
            this.TextSizeLabel.Text = "TextSize: 24";
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsButton.ForeColor = System.Drawing.Color.Wheat;
            this.SaveAsButton.Location = new System.Drawing.Point(284, 28);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveAsButton.TabIndex = 3;
            this.SaveAsButton.Text = "Save As";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.Color.Wheat;
            this.SaveButton.Location = new System.Drawing.Point(202, 28);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.ForeColor = System.Drawing.Color.Wheat;
            this.OpenButton.Location = new System.Drawing.Point(93, 28);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // MenuSettingsToolStrip
            // 
            this.MenuSettingsToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuSettingsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.VewToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.MenuSettingsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuSettingsToolStrip.Name = "MenuSettingsToolStrip";
            this.MenuSettingsToolStrip.Size = new System.Drawing.Size(1268, 24);
            this.MenuSettingsToolStrip.TabIndex = 0;
            this.MenuSettingsToolStrip.Text = "SettingsMenuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator2,
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.toolStripSeparator1,
            this.newToolStripMenuItem});
            this.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Wheat;
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.SaveAsToolStripMenuItem.Text = "Save As";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectAllToolStripMenuItem});
            this.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Wheat;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
            this.SearchToolStripMenuItem.ForeColor = System.Drawing.Color.Wheat;
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.SearchToolStripMenuItem.Text = "Search";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // VewToolStripMenuItem
            // 
            this.VewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textSizeToolStripMenuItem,
            this.textSizeToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.alwaysOnTopToolStripMenuItem,
            this.restoreDefaultRoomToolStripMenuItem});
            this.VewToolStripMenuItem.ForeColor = System.Drawing.Color.Wheat;
            this.VewToolStripMenuItem.Name = "VewToolStripMenuItem";
            this.VewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.VewToolStripMenuItem.Text = "View";
            // 
            // textSizeToolStripMenuItem
            // 
            this.textSizeToolStripMenuItem.Name = "textSizeToolStripMenuItem";
            this.textSizeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.textSizeToolStripMenuItem.Text = "Text Size+";
            this.textSizeToolStripMenuItem.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // textSizeToolStripMenuItem1
            // 
            this.textSizeToolStripMenuItem1.Name = "textSizeToolStripMenuItem1";
            this.textSizeToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.textSizeToolStripMenuItem1.Text = "Text Size-";
            this.textSizeToolStripMenuItem1.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 6);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // restoreDefaultRoomToolStripMenuItem
            // 
            this.restoreDefaultRoomToolStripMenuItem.Name = "restoreDefaultRoomToolStripMenuItem";
            this.restoreDefaultRoomToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.restoreDefaultRoomToolStripMenuItem.Text = "Restore Default Zoom";
            this.restoreDefaultRoomToolStripMenuItem.Click += new System.EventHandler(this.restoreDefaultRoomToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.Wheat;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.toolStripSeparator4,
            this.blueToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.toolStripSeparator5,
            this.greenToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(102, 6);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greyToolStripMenuItem.Text = "Grey";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.greyToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(102, 6);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // OpenTextFileDialog
            // 
            this.OpenTextFileDialog.DefaultExt = "txt";
            this.OpenTextFileDialog.Filter = "*.txt|";
            this.OpenTextFileDialog.Title = "Open File";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "txt";
            this.SaveFileDialog.Filter = "*.txt|";
            this.SaveFileDialog.Title = "Save As";
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Black;
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.CloseButton);
            this.SearchPanel.Controls.Add(this.ReplaceButton);
            this.SearchPanel.Controls.Add(this.NextButton);
            this.SearchPanel.Controls.Add(this.ReplaceTextBox);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Controls.Add(this.FindLabel);
            this.SearchPanel.Location = new System.Drawing.Point(974, 77);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(284, 100);
            this.SearchPanel.TabIndex = 12;
            this.SearchPanel.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.Wheat;
            this.CloseButton.Location = new System.Drawing.Point(259, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 20);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "X";
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceButton.ForeColor = System.Drawing.Color.Wheat;
            this.ReplaceButton.Location = new System.Drawing.Point(200, 59);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(75, 23);
            this.ReplaceButton.TabIndex = 15;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.ForeColor = System.Drawing.Color.Wheat;
            this.NextButton.Location = new System.Drawing.Point(200, 29);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 12;
            this.NextButton.Text = "Find";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.Location = new System.Drawing.Point(13, 59);
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(181, 23);
            this.ReplaceTextBox.TabIndex = 14;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(13, 30);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(181, 23);
            this.SearchTextBox.TabIndex = 13;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindLabel.ForeColor = System.Drawing.Color.Wheat;
            this.FindLabel.Location = new System.Drawing.Point(111, 2);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(69, 25);
            this.FindLabel.TabIndex = 12;
            this.FindLabel.Text = "Search";
            // 
            // NoteSharpCoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1270, 640);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.NotepadTextBox);
            this.Controls.Add(this.HeaderSettingsPanel);
            this.Name = "NoteSharpCoreForm";
            this.Text = "NotepadSharp";
            this.Load += new System.EventHandler(this.NoteSharpCoreForm_Load);
            this.Resize += new System.EventHandler(this.NoteSharpCoreForm_Resize);
            this.HeaderSettingsPanel.ResumeLayout(false);
            this.HeaderSettingsPanel.PerformLayout();
            this.MenuSettingsToolStrip.ResumeLayout(false);
            this.MenuSettingsToolStrip.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NotepadTextBox;
        private System.Windows.Forms.Panel HeaderSettingsPanel;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.MenuStrip MenuSettingsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textSizeToolStripMenuItem1;
        private System.Windows.Forms.Label TextSizeLabel;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreDefaultRoomToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenTextFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button ZoomOutButton;
        private System.Windows.Forms.Button ZoomInButton;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox ReplaceTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

