namespace Beeptastic
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
			this.tuneListBox = new System.Windows.Forms.ListBox();
			this.savedTunesLabel = new System.Windows.Forms.Label();
			this.newButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.helpButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.scriptTextBox = new System.Windows.Forms.RichTextBox();
			this.beepButton = new System.Windows.Forms.Button();
			this.codeButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.partTabControl = new System.Windows.Forms.TabControl();
			this.scriptLabel = new System.Windows.Forms.Label();
			this.addPartButton = new System.Windows.Forms.Button();
			this.deletePartButton = new System.Windows.Forms.Button();
			this.masterControlGroupBox = new System.Windows.Forms.GroupBox();
			this.standardFreqLabel = new System.Windows.Forms.Label();
			this.masterVolumeLabel = new System.Windows.Forms.Label();
			this.muteAllTextBox = new System.Windows.Forms.Button();
			this.standardFreqTextBox = new System.Windows.Forms.TextBox();
			this.masterVolumeTextBox = new System.Windows.Forms.TextBox();
			this.volumeLabel = new System.Windows.Forms.Label();
			this.keyLabel = new System.Windows.Forms.Label();
			this.volumeTextBox = new System.Windows.Forms.TextBox();
			this.keyTextBox = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.bpmLabel = new System.Windows.Forms.Label();
			this.bpmTextBox = new System.Windows.Forms.TextBox();
			this.muteCheckBox = new System.Windows.Forms.CheckBox();
			this.loopCheckBox = new System.Windows.Forms.CheckBox();
			this.partTabControl.SuspendLayout();
			this.masterControlGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// tuneListBox
			// 
			this.tuneListBox.FormattingEnabled = true;
			this.tuneListBox.ItemHeight = 23;
			this.tuneListBox.Location = new System.Drawing.Point(16, 35);
			this.tuneListBox.Name = "tuneListBox";
			this.tuneListBox.Size = new System.Drawing.Size(180, 441);
			this.tuneListBox.TabIndex = 0;
			// 
			// savedTunesLabel
			// 
			this.savedTunesLabel.AutoSize = true;
			this.savedTunesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.savedTunesLabel.Location = new System.Drawing.Point(12, 9);
			this.savedTunesLabel.Name = "savedTunesLabel";
			this.savedTunesLabel.Size = new System.Drawing.Size(115, 23);
			this.savedTunesLabel.TabIndex = 1;
			this.savedTunesLabel.Text = "saved tunes:";
			// 
			// newButton
			// 
			this.newButton.Location = new System.Drawing.Point(16, 486);
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(87, 36);
			this.newButton.TabIndex = 2;
			this.newButton.Text = "new";
			this.newButton.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Proxima Nova Rg", 14F);
			this.saveButton.Location = new System.Drawing.Point(109, 486);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(87, 36);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "save";
			this.saveButton.UseVisualStyleBackColor = true;
			// 
			// helpButton
			// 
			this.helpButton.Location = new System.Drawing.Point(109, 528);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(87, 36);
			this.helpButton.TabIndex = 5;
			this.helpButton.Text = "help";
			this.helpButton.UseVisualStyleBackColor = true;
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(16, 528);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(87, 36);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.titleLabel.Location = new System.Drawing.Point(216, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(87, 23);
			this.titleLabel.TabIndex = 6;
			this.titleLabel.Text = "tune title:";
			// 
			// titleTextBox
			// 
			this.titleTextBox.Location = new System.Drawing.Point(220, 35);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(632, 30);
			this.titleTextBox.TabIndex = 7;
			// 
			// scriptTextBox
			// 
			this.scriptTextBox.Location = new System.Drawing.Point(220, 108);
			this.scriptTextBox.Name = "scriptTextBox";
			this.scriptTextBox.Size = new System.Drawing.Size(632, 312);
			this.scriptTextBox.TabIndex = 9;
			this.scriptTextBox.Text = "";
			// 
			// beepButton
			// 
			this.beepButton.Font = new System.Drawing.Font("Proxima Nova Lt", 16F, System.Drawing.FontStyle.Bold);
			this.beepButton.Location = new System.Drawing.Point(672, 456);
			this.beepButton.Name = "beepButton";
			this.beepButton.Size = new System.Drawing.Size(180, 66);
			this.beepButton.TabIndex = 10;
			this.beepButton.Text = "beep!";
			this.beepButton.UseVisualStyleBackColor = true;
			// 
			// codeButton
			// 
			this.codeButton.Location = new System.Drawing.Point(765, 528);
			this.codeButton.Name = "codeButton";
			this.codeButton.Size = new System.Drawing.Size(87, 36);
			this.codeButton.TabIndex = 11;
			this.codeButton.Text = "code";
			this.codeButton.UseVisualStyleBackColor = true;
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(672, 528);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(87, 36);
			this.stopButton.TabIndex = 12;
			this.stopButton.Text = "stop";
			this.stopButton.UseVisualStyleBackColor = true;
			// 
			// partTabControl
			// 
			this.partTabControl.Controls.Add(this.tabPage1);
			this.partTabControl.Font = new System.Drawing.Font("Proxima Nova Rg", 12F);
			this.partTabControl.ItemSize = new System.Drawing.Size(60, 24);
			this.partTabControl.Location = new System.Drawing.Point(323, 82);
			this.partTabControl.Name = "partTabControl";
			this.partTabControl.Padding = new System.Drawing.Point(0, 3);
			this.partTabControl.SelectedIndex = 0;
			this.partTabControl.Size = new System.Drawing.Size(471, 26);
			this.partTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.partTabControl.TabIndex = 13;
			// 
			// scriptLabel
			// 
			this.scriptLabel.AutoSize = true;
			this.scriptLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.scriptLabel.Location = new System.Drawing.Point(216, 82);
			this.scriptLabel.Name = "scriptLabel";
			this.scriptLabel.Size = new System.Drawing.Size(101, 23);
			this.scriptLabel.TabIndex = 14;
			this.scriptLabel.Text = "tune script:";
			// 
			// addPartButton
			// 
			this.addPartButton.Font = new System.Drawing.Font("Proxima Nova Rg", 12F);
			this.addPartButton.Location = new System.Drawing.Point(800, 83);
			this.addPartButton.Name = "addPartButton";
			this.addPartButton.Size = new System.Drawing.Size(24, 24);
			this.addPartButton.TabIndex = 15;
			this.addPartButton.Text = "+";
			this.addPartButton.UseVisualStyleBackColor = true;
			// 
			// deletePartButton
			// 
			this.deletePartButton.Font = new System.Drawing.Font("Proxima Nova Rg", 12F);
			this.deletePartButton.Location = new System.Drawing.Point(828, 83);
			this.deletePartButton.Name = "deletePartButton";
			this.deletePartButton.Size = new System.Drawing.Size(24, 24);
			this.deletePartButton.TabIndex = 16;
			this.deletePartButton.Text = "-";
			this.deletePartButton.UseVisualStyleBackColor = true;
			// 
			// masterControlGroupBox
			// 
			this.masterControlGroupBox.Controls.Add(this.masterVolumeLabel);
			this.masterControlGroupBox.Controls.Add(this.muteAllTextBox);
			this.masterControlGroupBox.Controls.Add(this.standardFreqLabel);
			this.masterControlGroupBox.Controls.Add(this.masterVolumeTextBox);
			this.masterControlGroupBox.Controls.Add(this.standardFreqTextBox);
			this.masterControlGroupBox.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.masterControlGroupBox.Location = new System.Drawing.Point(220, 426);
			this.masterControlGroupBox.Name = "masterControlGroupBox";
			this.masterControlGroupBox.Size = new System.Drawing.Size(160, 138);
			this.masterControlGroupBox.TabIndex = 17;
			this.masterControlGroupBox.TabStop = false;
			this.masterControlGroupBox.Text = "master";
			// 
			// standardFreqLabel
			// 
			this.standardFreqLabel.AutoSize = true;
			this.standardFreqLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.standardFreqLabel.Location = new System.Drawing.Point(48, 27);
			this.standardFreqLabel.Name = "standardFreqLabel";
			this.standardFreqLabel.Size = new System.Drawing.Size(43, 23);
			this.standardFreqLabel.TabIndex = 0;
			this.standardFreqLabel.Text = "A4=";
			// 
			// masterVolumeLabel
			// 
			this.masterVolumeLabel.AutoSize = true;
			this.masterVolumeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.masterVolumeLabel.Location = new System.Drawing.Point(17, 64);
			this.masterVolumeLabel.Name = "masterVolumeLabel";
			this.masterVolumeLabel.Size = new System.Drawing.Size(74, 23);
			this.masterVolumeLabel.TabIndex = 1;
			this.masterVolumeLabel.Text = "volume:";
			// 
			// muteAllTextBox
			// 
			this.muteAllTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.muteAllTextBox.Location = new System.Drawing.Point(29, 100);
			this.muteAllTextBox.Name = "muteAllTextBox";
			this.muteAllTextBox.Size = new System.Drawing.Size(110, 30);
			this.muteAllTextBox.TabIndex = 18;
			this.muteAllTextBox.Text = "mute all";
			this.muteAllTextBox.UseVisualStyleBackColor = true;
			// 
			// standardFreqTextBox
			// 
			this.standardFreqTextBox.Location = new System.Drawing.Point(97, 24);
			this.standardFreqTextBox.Name = "standardFreqTextBox";
			this.standardFreqTextBox.Size = new System.Drawing.Size(48, 30);
			this.standardFreqTextBox.TabIndex = 18;
			this.standardFreqTextBox.Text = "440";
			// 
			// masterVolumeTextBox
			// 
			this.masterVolumeTextBox.Location = new System.Drawing.Point(97, 61);
			this.masterVolumeTextBox.Name = "masterVolumeTextBox";
			this.masterVolumeTextBox.Size = new System.Drawing.Size(48, 30);
			this.masterVolumeTextBox.TabIndex = 19;
			this.masterVolumeTextBox.Text = "100";
			// 
			// volumeLabel
			// 
			this.volumeLabel.AutoSize = true;
			this.volumeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.volumeLabel.Location = new System.Drawing.Point(408, 492);
			this.volumeLabel.Name = "volumeLabel";
			this.volumeLabel.Size = new System.Drawing.Size(74, 23);
			this.volumeLabel.TabIndex = 21;
			this.volumeLabel.Text = "volume:";
			// 
			// keyLabel
			// 
			this.keyLabel.AutoSize = true;
			this.keyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.keyLabel.Location = new System.Drawing.Point(438, 453);
			this.keyLabel.Name = "keyLabel";
			this.keyLabel.Size = new System.Drawing.Size(44, 23);
			this.keyLabel.TabIndex = 20;
			this.keyLabel.Text = "key:";
			// 
			// volumeTextBox
			// 
			this.volumeTextBox.Location = new System.Drawing.Point(488, 489);
			this.volumeTextBox.Name = "volumeTextBox";
			this.volumeTextBox.Size = new System.Drawing.Size(48, 30);
			this.volumeTextBox.TabIndex = 23;
			this.volumeTextBox.Text = "100";
			// 
			// keyTextBox
			// 
			this.keyTextBox.Location = new System.Drawing.Point(488, 450);
			this.keyTextBox.Name = "keyTextBox";
			this.keyTextBox.Size = new System.Drawing.Size(48, 30);
			this.keyTextBox.TabIndex = 22;
			this.keyTextBox.Text = "C5";
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(463, 0);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "part 1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// bpmLabel
			// 
			this.bpmLabel.AutoSize = true;
			this.bpmLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.bpmLabel.Location = new System.Drawing.Point(431, 528);
			this.bpmLabel.Name = "bpmLabel";
			this.bpmLabel.Size = new System.Drawing.Size(51, 23);
			this.bpmLabel.TabIndex = 24;
			this.bpmLabel.Text = "bpm:";
			// 
			// bpmTextBox
			// 
			this.bpmTextBox.Location = new System.Drawing.Point(488, 528);
			this.bpmTextBox.Name = "bpmTextBox";
			this.bpmTextBox.Size = new System.Drawing.Size(48, 30);
			this.bpmTextBox.TabIndex = 25;
			this.bpmTextBox.Text = "120";
			// 
			// muteCheckBox
			// 
			this.muteCheckBox.AutoSize = true;
			this.muteCheckBox.Location = new System.Drawing.Point(566, 490);
			this.muteCheckBox.Name = "muteCheckBox";
			this.muteCheckBox.Size = new System.Drawing.Size(71, 27);
			this.muteCheckBox.TabIndex = 26;
			this.muteCheckBox.Text = "mute";
			this.muteCheckBox.UseVisualStyleBackColor = true;
			// 
			// loopCheckBox
			// 
			this.loopCheckBox.AutoSize = true;
			this.loopCheckBox.Location = new System.Drawing.Point(566, 527);
			this.loopCheckBox.Name = "loopCheckBox";
			this.loopCheckBox.Size = new System.Drawing.Size(66, 27);
			this.loopCheckBox.TabIndex = 27;
			this.loopCheckBox.Text = "loop";
			this.loopCheckBox.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(864, 576);
			this.Controls.Add(this.loopCheckBox);
			this.Controls.Add(this.muteCheckBox);
			this.Controls.Add(this.bpmLabel);
			this.Controls.Add(this.bpmTextBox);
			this.Controls.Add(this.volumeLabel);
			this.Controls.Add(this.masterControlGroupBox);
			this.Controls.Add(this.keyLabel);
			this.Controls.Add(this.deletePartButton);
			this.Controls.Add(this.volumeTextBox);
			this.Controls.Add(this.addPartButton);
			this.Controls.Add(this.keyTextBox);
			this.Controls.Add(this.scriptLabel);
			this.Controls.Add(this.partTabControl);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.codeButton);
			this.Controls.Add(this.beepButton);
			this.Controls.Add(this.scriptTextBox);
			this.Controls.Add(this.titleTextBox);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.helpButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.newButton);
			this.Controls.Add(this.savedTunesLabel);
			this.Controls.Add(this.tuneListBox);
			this.Font = new System.Drawing.Font("Proxima Nova Rg", 14F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(648, 384);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "beeptastic";
			this.partTabControl.ResumeLayout(false);
			this.masterControlGroupBox.ResumeLayout(false);
			this.masterControlGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox tuneListBox;
		private System.Windows.Forms.Label savedTunesLabel;
		private System.Windows.Forms.Button newButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button helpButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.RichTextBox scriptTextBox;
		private System.Windows.Forms.Button beepButton;
		private System.Windows.Forms.Button codeButton;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.TabControl partTabControl;
		private System.Windows.Forms.Label scriptLabel;
		private System.Windows.Forms.Button addPartButton;
		private System.Windows.Forms.Button deletePartButton;
		private System.Windows.Forms.GroupBox masterControlGroupBox;
		private System.Windows.Forms.Button muteAllTextBox;
		private System.Windows.Forms.Label masterVolumeLabel;
		private System.Windows.Forms.Label standardFreqLabel;
		private System.Windows.Forms.TextBox masterVolumeTextBox;
		private System.Windows.Forms.TextBox standardFreqTextBox;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label volumeLabel;
		private System.Windows.Forms.Label keyLabel;
		private System.Windows.Forms.TextBox volumeTextBox;
		private System.Windows.Forms.TextBox keyTextBox;
		private System.Windows.Forms.Label bpmLabel;
		private System.Windows.Forms.TextBox bpmTextBox;
		private System.Windows.Forms.CheckBox muteCheckBox;
		private System.Windows.Forms.CheckBox loopCheckBox;
	}
}

