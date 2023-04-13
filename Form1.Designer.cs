namespace ColorSelectionChanger
{
    partial class Main
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
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.CurrentColorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentColor = new System.Windows.Forms.PictureBox();
            this.RestoreDefaultSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColor)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.BackColor = System.Drawing.Color.White;
            this.ChangeColorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(2)))), ((int)(((byte)(238)))));
            this.ChangeColorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChangeColorButton.Location = new System.Drawing.Point(3, 67);
            this.ChangeColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(148, 35);
            this.ChangeColorButton.TabIndex = 0;
            this.ChangeColorButton.Text = "Select color";
            this.ChangeColorButton.UseVisualStyleBackColor = false;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // CurrentColorTextBox
            // 
            this.CurrentColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentColorTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentColorTextBox.Location = new System.Drawing.Point(3, 21);
            this.CurrentColorTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentColorTextBox.Multiline = true;
            this.CurrentColorTextBox.Name = "CurrentColorTextBox";
            this.CurrentColorTextBox.Size = new System.Drawing.Size(100, 25);
            this.CurrentColorTextBox.TabIndex = 5;
            this.CurrentColorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CurrentColor);
            this.groupBox1.Controls.Add(this.ChangeColorButton);
            this.groupBox1.Controls.Add(this.RestoreDefaultSettings);
            this.groupBox1.Controls.Add(this.CurrentColorTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current color";
            // 
            // CurrentColor
            // 
            this.CurrentColor.BackColor = System.Drawing.Color.DimGray;
            this.CurrentColor.Location = new System.Drawing.Point(106, 21);
            this.CurrentColor.Name = "CurrentColor";
            this.CurrentColor.Size = new System.Drawing.Size(60, 25);
            this.CurrentColor.TabIndex = 9;
            this.CurrentColor.TabStop = false;
            // 
            // RestoreDefaultSettings
            // 
            this.RestoreDefaultSettings.BackColor = System.Drawing.SystemColors.Control;
            this.RestoreDefaultSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RestoreDefaultSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RestoreDefaultSettings.Location = new System.Drawing.Point(170, 67);
            this.RestoreDefaultSettings.Margin = new System.Windows.Forms.Padding(0);
            this.RestoreDefaultSettings.Name = "RestoreDefaultSettings";
            this.RestoreDefaultSettings.Size = new System.Drawing.Size(148, 35);
            this.RestoreDefaultSettings.TabIndex = 8;
            this.RestoreDefaultSettings.Text = "Restore default color";
            this.RestoreDefaultSettings.UseVisualStyleBackColor = false;
            this.RestoreDefaultSettings.Click += new System.EventHandler(this.RestoreDefaultSettings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 127);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ChangeColorButton;
        private ColorDialog ColorPicker;
        private TextBox CurrentColorTextBox;
        private GroupBox groupBox1;
        private Button RestoreDefaultSettings;
        private PictureBox CurrentColor;
    }
}