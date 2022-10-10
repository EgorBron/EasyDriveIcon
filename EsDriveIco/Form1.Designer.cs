using System.Windows.Forms;

namespace EsDriveIco {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.driveLetterComboBox = new System.Windows.Forms.ComboBox();
            this.driveLetterLabel = new System.Windows.Forms.Label();
            this.pathToIcoLabel = new System.Windows.Forms.Label();
            this.pathToIcoTextbox = new System.Windows.Forms.TextBox();
            this.pathToIcoButton = new System.Windows.Forms.Button();
            this.whatToDoLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driveLetterComboBox
            // 
            this.driveLetterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveLetterComboBox.FormattingEnabled = true;
            this.driveLetterComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.driveLetterComboBox.Location = new System.Drawing.Point(152, 25);
            this.driveLetterComboBox.Name = "driveLetterComboBox";
            this.driveLetterComboBox.Size = new System.Drawing.Size(42, 21);
            this.driveLetterComboBox.TabIndex = 0;
            // 
            // driveLetterLabel
            // 
            this.driveLetterLabel.AutoSize = true;
            this.driveLetterLabel.Location = new System.Drawing.Point(15, 28);
            this.driveLetterLabel.Name = "driveLetterLabel";
            this.driveLetterLabel.Size = new System.Drawing.Size(58, 13);
            this.driveLetterLabel.TabIndex = 1;
            this.driveLetterLabel.Text = "Drive letter";
            // 
            // pathToIcoLabel
            // 
            this.pathToIcoLabel.AutoSize = true;
            this.pathToIcoLabel.Location = new System.Drawing.Point(15, 59);
            this.pathToIcoLabel.Name = "pathToIcoLabel";
            this.pathToIcoLabel.Size = new System.Drawing.Size(64, 13);
            this.pathToIcoLabel.TabIndex = 2;
            this.pathToIcoLabel.Text = "Path to icon";
            // 
            // pathToIcoTextbox
            // 
            this.pathToIcoTextbox.Location = new System.Drawing.Point(18, 76);
            this.pathToIcoTextbox.Name = "pathToIcoTextbox";
            this.pathToIcoTextbox.Size = new System.Drawing.Size(142, 20);
            this.pathToIcoTextbox.TabIndex = 3;
            // 
            // pathToIcoButton
            // 
            this.pathToIcoButton.Location = new System.Drawing.Point(166, 76);
            this.pathToIcoButton.Name = "pathToIcoButton";
            this.pathToIcoButton.Size = new System.Drawing.Size(28, 20);
            this.pathToIcoButton.TabIndex = 4;
            this.pathToIcoButton.Text = "...";
            this.pathToIcoButton.UseVisualStyleBackColor = true;
            this.pathToIcoButton.Click += new System.EventHandler(this.pathToIcoButton_Click);
            // 
            // whatToDoLabel
            // 
            this.whatToDoLabel.AutoSize = true;
            this.whatToDoLabel.Location = new System.Drawing.Point(18, 117);
            this.whatToDoLabel.Name = "whatToDoLabel";
            this.whatToDoLabel.Size = new System.Drawing.Size(130, 13);
            this.whatToDoLabel.TabIndex = 5;
            this.whatToDoLabel.Text = "What are you want to do?";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(18, 149);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update icon";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(110, 149);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset icon";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 202);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.whatToDoLabel);
            this.Controls.Add(this.pathToIcoButton);
            this.Controls.Add(this.pathToIcoTextbox);
            this.Controls.Add(this.pathToIcoLabel);
            this.Controls.Add(this.driveLetterLabel);
            this.Controls.Add(this.driveLetterComboBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EsDriveIco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox driveLetterComboBox;
        private Label driveLetterLabel;
        private Label pathToIcoLabel;
        private TextBox pathToIcoTextbox;
        private Button pathToIcoButton;
        private Label whatToDoLabel;
        private Button updateButton;
        private Button resetButton;
    }
}