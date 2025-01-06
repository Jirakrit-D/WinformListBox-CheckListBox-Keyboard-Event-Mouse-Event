namespace LabArray
{
    partial class Form3
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
            label3 = new Label();
            txtKeyCode = new TextBox();
            txtKeyValue = new TextBox();
            txtKeyData = new TextBox();
            chkShift = new CheckBox();
            chkControl = new CheckBox();
            chkAlt = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 76);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 0;
            label1.Text = "KeyCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 145);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 1;
            label2.Text = "KeyValue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 218);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 2;
            label3.Text = "KeyData";
            // 
            // txtKeyCode
            // 
            txtKeyCode.Location = new Point(211, 76);
            txtKeyCode.Name = "txtKeyCode";
            txtKeyCode.Size = new Size(300, 34);
            txtKeyCode.TabIndex = 3;
            // 
            // txtKeyValue
            // 
            txtKeyValue.Location = new Point(211, 145);
            txtKeyValue.Name = "txtKeyValue";
            txtKeyValue.Size = new Size(300, 34);
            txtKeyValue.TabIndex = 4;
            // 
            // txtKeyData
            // 
            txtKeyData.Location = new Point(211, 218);
            txtKeyData.Name = "txtKeyData";
            txtKeyData.Size = new Size(300, 34);
            txtKeyData.TabIndex = 5;
            // 
            // chkShift
            // 
            chkShift.AutoSize = true;
            chkShift.Location = new Point(113, 291);
            chkShift.Name = "chkShift";
            chkShift.Size = new Size(74, 32);
            chkShift.TabIndex = 6;
            chkShift.Text = "Shift";
            chkShift.UseVisualStyleBackColor = true;
            // 
            // chkControl
            // 
            chkControl.AutoSize = true;
            chkControl.Location = new Point(259, 291);
            chkControl.Name = "chkControl";
            chkControl.Size = new Size(100, 32);
            chkControl.TabIndex = 7;
            chkControl.Text = "Control";
            chkControl.UseVisualStyleBackColor = true;
            // 
            // chkAlt
            // 
            chkAlt.AutoSize = true;
            chkAlt.Location = new Point(408, 291);
            chkAlt.Name = "chkAlt";
            chkAlt.Size = new Size(59, 32);
            chkAlt.TabIndex = 8;
            chkAlt.Text = "Alt";
            chkAlt.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 419);
            Controls.Add(chkAlt);
            Controls.Add(chkControl);
            Controls.Add(chkShift);
            Controls.Add(txtKeyData);
            Controls.Add(txtKeyValue);
            Controls.Add(txtKeyCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            KeyDown += Form3_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKeyCode;
        private TextBox txtKeyValue;
        private TextBox txtKeyData;
        private CheckBox chkShift;
        private CheckBox chkControl;
        private CheckBox chkAlt;
    }
}