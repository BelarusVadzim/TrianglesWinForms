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
            this.pictureBox1 = new PictureBox();
            this.panel1 = new Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            this.panel1.SuspendLayout();
            SuspendLayout();
            // 
            // infoTextLabel
            // 
            this.infoTextLabel.AutoEllipsis = true;
            this.infoTextLabel.AutoSize = true;
            this.infoTextLabel.Location = new Point(6, 19);
            this.infoTextLabel.MaximumSize = new Size(155, 0);
            this.infoTextLabel.Name = "infoTextLabel";
            this.infoTextLabel.Size = new Size(51, 15);
            this.infoTextLabel.TabIndex = 0;
            this.infoTextLabel.Text = "Info text";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoTextLabel);
            this.groupBox1.Location = new Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(167, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Location = new Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(760, 520);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.panel1.BackColor = Color.White;
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new Point(195, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(780, 540);
            this.panel1.TabIndex = 4;
            // 
            // TrianglesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(this.panel1);
            Controls.Add(this.groupBox1);
            Name = "TrianglesForm";
            Text = "TrianglesForm";
            Load += TrianglesForm_Load;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            this.panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label infoTextLabel;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}