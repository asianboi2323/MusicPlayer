namespace System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.PlayButton = new System.Windows.Forms.Button();
			this.KeyText = new System.Windows.Forms.TextBox();
			this.BpmText = new System.Windows.Forms.TextBox();
			this.BpmLabel = new System.Windows.Forms.Label();
			this.KeyLabel = new System.Windows.Forms.Label();
			this.RepeatCheck = new System.Windows.Forms.CheckBox();
			this.StopButton = new System.Windows.Forms.Button();
			this.MusicList = new System.Windows.Forms.ListBox();
			this.MusicListLabel = new System.Windows.Forms.Label();
			this.ScriptLabel = new System.Windows.Forms.Label();
			this.NameText = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NewButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.HelpWindowButton = new System.Windows.Forms.Button();
			this.ScriptText = new System.Windows.Forms.RichTextBox();
			this.PinCheck = new System.Windows.Forms.CheckBox();
			this.VolumeText = new System.Windows.Forms.TextBox();
			this.VolumeLabel = new System.Windows.Forms.Label();
			this.ScriptTabList = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.AddPartButton = new System.Windows.Forms.Button();
			this.DeletePartButton = new System.Windows.Forms.Button();
			this.PlayPartButton = new System.Windows.Forms.Button();
			this.OutputButton = new System.Windows.Forms.Button();
			this.ScriptTabList.SuspendLayout();
			this.SuspendLayout();
			// 
			// PlayButton
			// 
			this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.PlayButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayButton.Location = new System.Drawing.Point(652, 384);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(163, 70);
			this.PlayButton.TabIndex = 1;
			this.PlayButton.Text = "Beep!";
			this.PlayButton.UseVisualStyleBackColor = true;
			this.PlayButton.Click += new System.EventHandler(this.OnPlayButtonClick);
			// 
			// KeyText
			// 
			this.KeyText.Location = new System.Drawing.Point(336, 408);
			this.KeyText.Name = "KeyText";
			this.KeyText.Size = new System.Drawing.Size(106, 25);
			this.KeyText.TabIndex = 12;
			this.KeyText.Text = "C5";
			// 
			// BpmText
			// 
			this.BpmText.Location = new System.Drawing.Point(336, 444);
			this.BpmText.Name = "BpmText";
			this.BpmText.Size = new System.Drawing.Size(106, 25);
			this.BpmText.TabIndex = 13;
			this.BpmText.Text = "120";
			// 
			// BpmLabel
			// 
			this.BpmLabel.AutoSize = true;
			this.BpmLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BpmLabel.Location = new System.Drawing.Point(268, 447);
			this.BpmLabel.Name = "BpmLabel";
			this.BpmLabel.Size = new System.Drawing.Size(45, 17);
			this.BpmLabel.TabIndex = 4;
			this.BpmLabel.Text = "BPM:";
			// 
			// KeyLabel
			// 
			this.KeyLabel.AutoSize = true;
			this.KeyLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyLabel.Location = new System.Drawing.Point(270, 411);
			this.KeyLabel.Name = "KeyLabel";
			this.KeyLabel.Size = new System.Drawing.Size(38, 17);
			this.KeyLabel.TabIndex = 5;
			this.KeyLabel.Text = "Key:";
			// 
			// RepeatCheck
			// 
			this.RepeatCheck.AutoSize = true;
			this.RepeatCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.RepeatCheck.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RepeatCheck.Location = new System.Drawing.Point(464, 442);
			this.RepeatCheck.Name = "RepeatCheck";
			this.RepeatCheck.Size = new System.Drawing.Size(80, 22);
			this.RepeatCheck.TabIndex = 15;
			this.RepeatCheck.Text = "Repeat";
			this.RepeatCheck.UseVisualStyleBackColor = true;
			this.RepeatCheck.CheckedChanged += new System.EventHandler(this.OnRepeatCheckCheckedChanged);
			// 
			// StopButton
			// 
			this.StopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.StopButton.Location = new System.Drawing.Point(736, 460);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(79, 29);
			this.StopButton.TabIndex = 0;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.OnStopButtonClick);
			// 
			// MusicList
			// 
			this.MusicList.FormattingEnabled = true;
			this.MusicList.ItemHeight = 17;
			this.MusicList.Location = new System.Drawing.Point(18, 33);
			this.MusicList.Name = "MusicList";
			this.MusicList.Size = new System.Drawing.Size(222, 412);
			this.MusicList.TabIndex = 3;
			this.MusicList.SelectedIndexChanged += new System.EventHandler(this.OnMusicListSelectedIndexChanged);
			this.MusicList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnMusicListKeyDown);
			// 
			// MusicListLabel
			// 
			this.MusicListLabel.AutoSize = true;
			this.MusicListLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MusicListLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.MusicListLabel.Location = new System.Drawing.Point(16, 13);
			this.MusicListLabel.Name = "MusicListLabel";
			this.MusicListLabel.Size = new System.Drawing.Size(106, 17);
			this.MusicListLabel.TabIndex = 4;
			this.MusicListLabel.Text = "Saved Musics:";
			// 
			// ScriptLabel
			// 
			this.ScriptLabel.AutoSize = true;
			this.ScriptLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScriptLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ScriptLabel.Location = new System.Drawing.Point(264, 61);
			this.ScriptLabel.Name = "ScriptLabel";
			this.ScriptLabel.Size = new System.Drawing.Size(50, 17);
			this.ScriptLabel.TabIndex = 5;
			this.ScriptLabel.Text = "Script:";
			// 
			// NameText
			// 
			this.NameText.Location = new System.Drawing.Point(267, 33);
			this.NameText.Name = "NameText";
			this.NameText.Size = new System.Drawing.Size(549, 25);
			this.NameText.TabIndex = 10;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.NameLabel.Location = new System.Drawing.Point(264, 13);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(52, 17);
			this.NameLabel.TabIndex = 5;
			this.NameLabel.Text = "Name:";
			// 
			// NewButton
			// 
			this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.NewButton.Location = new System.Drawing.Point(131, 456);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(109, 29);
			this.NewButton.TabIndex = 5;
			this.NewButton.Text = "New";
			this.NewButton.UseVisualStyleBackColor = true;
			this.NewButton.Click += new System.EventHandler(this.OnNewButtonClick);
			// 
			// DeleteButton
			// 
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DeleteButton.Location = new System.Drawing.Point(16, 491);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(109, 29);
			this.DeleteButton.TabIndex = 6;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.OnDeleteButtonClick);
			// 
			// SaveButton
			// 
			this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SaveButton.Location = new System.Drawing.Point(131, 491);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(109, 29);
			this.SaveButton.TabIndex = 7;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
			// 
			// HelpWindowButton
			// 
			this.HelpWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.HelpWindowButton.Location = new System.Drawing.Point(16, 456);
			this.HelpWindowButton.Name = "HelpWindowButton";
			this.HelpWindowButton.Size = new System.Drawing.Size(109, 29);
			this.HelpWindowButton.TabIndex = 4;
			this.HelpWindowButton.Text = "Help";
			this.HelpWindowButton.UseVisualStyleBackColor = true;
			this.HelpWindowButton.Click += new System.EventHandler(this.OnHelpButtonClick);
			// 
			// ScriptText
			// 
			this.ScriptText.Location = new System.Drawing.Point(267, 81);
			this.ScriptText.Name = "ScriptText";
			this.ScriptText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.ScriptText.Size = new System.Drawing.Size(549, 254);
			this.ScriptText.TabIndex = 11;
			this.ScriptText.Text = "";
			this.ScriptText.TextChanged += new System.EventHandler(this.OnScriptTextTextChanged);
			// 
			// PinCheck
			// 
			this.PinCheck.AutoSize = true;
			this.PinCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.PinCheck.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PinCheck.Location = new System.Drawing.Point(464, 478);
			this.PinCheck.Name = "PinCheck";
			this.PinCheck.Size = new System.Drawing.Size(102, 22);
			this.PinCheck.TabIndex = 18;
			this.PinCheck.Text = "Pin on Top";
			this.PinCheck.UseVisualStyleBackColor = true;
			this.PinCheck.CheckedChanged += new System.EventHandler(this.OnPinCheckCheckedChanged);
			// 
			// VolumeText
			// 
			this.VolumeText.Location = new System.Drawing.Point(336, 480);
			this.VolumeText.Name = "VolumeText";
			this.VolumeText.Size = new System.Drawing.Size(106, 25);
			this.VolumeText.TabIndex = 14;
			this.VolumeText.Text = "100";
			this.VolumeText.TextChanged += new System.EventHandler(this.OnVolumeTextTextChanged);
			// 
			// VolumeLabel
			// 
			this.VolumeLabel.AutoSize = true;
			this.VolumeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VolumeLabel.Location = new System.Drawing.Point(268, 483);
			this.VolumeLabel.Name = "VolumeLabel";
			this.VolumeLabel.Size = new System.Drawing.Size(61, 17);
			this.VolumeLabel.TabIndex = 4;
			this.VolumeLabel.Text = "Volume:";
			// 
			// ScriptTabList
			// 
			this.ScriptTabList.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.ScriptTabList.Controls.Add(this.tabPage1);
			this.ScriptTabList.ItemSize = new System.Drawing.Size(32, 22);
			this.ScriptTabList.Location = new System.Drawing.Point(267, 81);
			this.ScriptTabList.Name = "ScriptTabList";
			this.ScriptTabList.SelectedIndex = 0;
			this.ScriptTabList.Size = new System.Drawing.Size(548, 279);
			this.ScriptTabList.TabIndex = 19;
			this.ScriptTabList.SelectedIndexChanged += new System.EventHandler(this.OnScriptTabControlSelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(540, 249);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Part 1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// AddPartButton
			// 
			this.AddPartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.AddPartButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddPartButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.AddPartButton.Location = new System.Drawing.Point(765, 338);
			this.AddPartButton.Name = "AddPartButton";
			this.AddPartButton.Size = new System.Drawing.Size(22, 22);
			this.AddPartButton.TabIndex = 20;
			this.AddPartButton.Text = "+";
			this.AddPartButton.UseVisualStyleBackColor = true;
			this.AddPartButton.Click += new System.EventHandler(this.OnAddPartButtonClick);
			// 
			// DeletePartButton
			// 
			this.DeletePartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DeletePartButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeletePartButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.DeletePartButton.Location = new System.Drawing.Point(793, 338);
			this.DeletePartButton.Name = "DeletePartButton";
			this.DeletePartButton.Size = new System.Drawing.Size(22, 22);
			this.DeletePartButton.TabIndex = 20;
			this.DeletePartButton.Text = "-";
			this.DeletePartButton.UseVisualStyleBackColor = true;
			this.DeletePartButton.Click += new System.EventHandler(this.OnDeletePartButtonClick);
			// 
			// PlayPartButton
			// 
			this.PlayPartButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.PlayPartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.PlayPartButton.Font = new System.Drawing.Font("Arial", 10F);
			this.PlayPartButton.Location = new System.Drawing.Point(652, 460);
			this.PlayPartButton.Name = "PlayPartButton";
			this.PlayPartButton.Size = new System.Drawing.Size(79, 29);
			this.PlayPartButton.TabIndex = 0;
			this.PlayPartButton.Text = "Play Part";
			this.PlayPartButton.UseVisualStyleBackColor = true;
			this.PlayPartButton.Click += new System.EventHandler(this.OnPlayPartButtonClick);
			// 
			// OutputButton
			// 
			this.OutputButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OutputButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.OutputButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutputButton.Location = new System.Drawing.Point(652, 496);
			this.OutputButton.Name = "OutputButton";
			this.OutputButton.Size = new System.Drawing.Size(163, 21);
			this.OutputButton.TabIndex = 0;
			this.OutputButton.Text = "Output Part as Code";
			this.OutputButton.UseVisualStyleBackColor = true;
			this.OutputButton.Click += new System.EventHandler(this.OnOutputButtonClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.StopButton;
			this.ClientSize = new System.Drawing.Size(834, 535);
			this.Controls.Add(this.DeletePartButton);
			this.Controls.Add(this.AddPartButton);
			this.Controls.Add(this.ScriptText);
			this.Controls.Add(this.ScriptTabList);
			this.Controls.Add(this.MusicListLabel);
			this.Controls.Add(this.MusicList);
			this.Controls.Add(this.PlayButton);
			this.Controls.Add(this.PinCheck);
			this.Controls.Add(this.RepeatCheck);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.ScriptLabel);
			this.Controls.Add(this.KeyLabel);
			this.Controls.Add(this.VolumeLabel);
			this.Controls.Add(this.BpmLabel);
			this.Controls.Add(this.VolumeText);
			this.Controls.Add(this.BpmText);
			this.Controls.Add(this.KeyText);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.HelpWindowButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.PlayPartButton);
			this.Controls.Add(this.OutputButton);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.NameText);
			this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.ScriptTabList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		public System.Windows.Forms.Button PlayButton;
		public System.Windows.Forms.TextBox KeyText;
		public System.Windows.Forms.TextBox BpmText;
		public System.Windows.Forms.Label BpmLabel;
		public System.Windows.Forms.Label KeyLabel;
		public System.Windows.Forms.CheckBox RepeatCheck;
		public System.Windows.Forms.Button StopButton;
		public System.Windows.Forms.ListBox MusicList;
		public System.Windows.Forms.Label MusicListLabel;
		public System.Windows.Forms.Label ScriptLabel;
		public System.Windows.Forms.TextBox NameText;
		public System.Windows.Forms.Label NameLabel;
		public System.Windows.Forms.Button NewButton;
		public System.Windows.Forms.Button DeleteButton;
		public System.Windows.Forms.Button SaveButton;
		public System.Windows.Forms.Button HelpWindowButton;
		public System.Windows.Forms.RichTextBox ScriptText;
		public System.Windows.Forms.CheckBox PinCheck;
		public System.Windows.Forms.TextBox VolumeText;
		public System.Windows.Forms.Label VolumeLabel;
		public System.Windows.Forms.Button AddPartButton;
		public System.Windows.Forms.TabControl ScriptTabList;
		public System.Windows.Forms.Button DeletePartButton;
		public System.Windows.Forms.Button PlayPartButton;
		public System.Windows.Forms.TabPage tabPage1;
		public Windows.Forms.Button OutputButton;
	}
}

