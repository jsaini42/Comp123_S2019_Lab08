namespace Comp123_S2019_Lab08
{
    partial class Lab08
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(22, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(99, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Lab08";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.BackColor = System.Drawing.Color.Silver;
            this.InfoGroupBox.Controls.Add(this.AgeTextBox);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Controls.Add(this.AgeLabel);
            this.InfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoGroupBox.Location = new System.Drawing.Point(28, 62);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(705, 220);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(225, 88);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(456, 38);
            this.AgeTextBox.TabIndex = 2;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(225, 44);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(456, 38);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 44);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(219, 31);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Enter Name:";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(48, 88);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(219, 35);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "Enter Age:";
            this.AgeLabel.Click += new System.EventHandler(this.AgeLabel_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(638, 388);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 50);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.Color.LightGray;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(41, 388);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(591, 48);
            this.OutputLabel.TabIndex = 4;
            // 
            // Lab08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Lab08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab08";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

