namespace LabArray
{
    partial class Form1
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
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(34, 23);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(242, 378);
            checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(317, 86);
            button1.Name = "button1";
            button1.Size = new Size(139, 59);
            button1.TabIndex = 1;
            button1.Text = ">>>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(317, 206);
            button2.Name = "button2";
            button2.Size = new Size(139, 59);
            button2.TabIndex = 2;
            button2.Text = "<<<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(513, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(257, 384);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
    }
}
