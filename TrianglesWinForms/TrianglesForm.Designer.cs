namespace TrianglesWinForms
{
    partial class TrianglesForm
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
            this.infoTextLabel = new Label();
            this.groupBox1 = new GroupBox();
            this.textBox1 = new TextBox();
            this.pictureBox1 = new PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // infoTextLabel
            // 
            this.infoTextLabel.AutoEllipsis = true;
            this.infoTextLabel.AutoSize = true;
            this.infoTextLabel.Location = new Point(6, 19);
            this.infoTextLabel.Name = "infoTextLabel";
            this.infoTextLabel.Size = new Size(51, 15);
            this.infoTextLabel.TabIndex = 0;
            this.infoTextLabel.Text = "Info text";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.infoTextLabel);
            this.groupBox1.Location = new Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(167, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = SystemColors.Control;
            this.textBox1.BorderStyle = BorderStyle.None;
            this.textBox1.Location = new Point(6, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(155, 143);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox1.Location = new Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(836, 497);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TrianglesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 521);
            Controls.Add(this.pictureBox1);
            Controls.Add(this.groupBox1);
            Name = "TrianglesForm";
            Text = "TrianglesForm";
            Load += TrianglesForm_Load;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label infoTextLabel;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}