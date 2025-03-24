using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermExamProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void UpdateColor()
        {
            int red = trackBar1.Value;
            int green = vScrollBar1.Value;
            int blue = hScrollBar1.Value;

            Color selectedColor = Color.FromArgb(red, green, blue);
            lbl_color.BackColor = selectedColor;
            lbl_color.Text = $"Current Color: {selectedColor.ToString()}";
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void btn_mainform_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
