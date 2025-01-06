namespace LabArray
{
    partial class Form5
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
            pictureBox1 = new PictureBox();
            cboColor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cboWidth = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(34, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 282);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(60, 323);
            cboColor.Margin = new Padding(3, 2, 3, 2);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(148, 23);
            cboColor.TabIndex = 1;
            cboColor.SelectedIndexChanged += cboColor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 323);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 2;
            label1.Text = "สี";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 320);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 3;
            label2.Text = "ขนาด";
            // 
            // cboWidth
            // 
            cboWidth.FormattingEnabled = true;
            cboWidth.Location = new Point(339, 323);
            cboWidth.Margin = new Padding(3, 2, 3, 2);
            cboWidth.Name = "cboWidth";
            cboWidth.Size = new Size(148, 23);
            cboWidth.TabIndex = 4;
            cboWidth.SelectedIndexChanged += cboWidth_SelectedIndexChanged;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 376);
            Controls.Add(cboWidth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboColor);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cboColor;
        private Label label1;
        private Label label2;
        private ComboBox cboWidth;
    }
}