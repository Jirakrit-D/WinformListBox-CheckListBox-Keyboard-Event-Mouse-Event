using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabArray
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // ตั้งค่าข้อมูลใน listBox1
            string[] products = { "เบียร์", "เหล้าสีขาว", "โสม", "น้ำแดง", "น้ำเปล่า", "น้ำโค๊ก" };
            listBox1.Items.AddRange(products);

            // เปิดใช้งานการ Drag and Drop สำหรับ listBox2
            listBox2.AllowDrop = true;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // ตรวจสอบว่ามีการเลือกไอเท็มหรือไม่ก่อนเริ่ม Drag
            int idx = listBox1.SelectedIndex;
            if (idx != -1)
            {
                // เริ่มต้นการลากข้อมูล
                listBox1.DoDragDrop(listBox1.Items[idx].ToString(), DragDropEffects.Copy);
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            // ตรวจสอบว่าข้อมูลเป็นประเภท Text หรือไม่
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            // รับข้อมูลและตรวจสอบความซ้ำซ้อนก่อนเพิ่มเข้า listBox2
            string data = e.Data.GetData(DataFormats.Text)?.ToString();
            if (!string.IsNullOrEmpty(data) && listBox2.FindStringExact(data) == -1)
            {
                listBox2.Items.Add(data);
            }
        }
    }
}
