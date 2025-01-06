namespace LabArray
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 53);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 0;
            label1.Text = "สินค้าที่มีอยู่";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(462, 53);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "สินค้าที่เลือก";
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(79, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(255, 264);
            listBox1.TabIndex = 2;
            listBox1.MouseDown += listBox1_MouseDown;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(462, 84);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(255, 264);
            listBox2.TabIndex = 3;
            listBox2.DragDrop += listBox2_DragDrop;
            listBox2.DragEnter += listBox2_DragEnter;
            // 
            // Form2
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}