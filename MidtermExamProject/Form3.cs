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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != null)
            {
                resultlabel.Text = $"You selected grade {comboBox1.SelectedIndex}";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_task.Text))
            {
                lst_tasks.Items.Add(txt_task.Text);
                txt_task.Clear();
            }
            else
            {
                MessageBox.Show("Enter a task before adding task", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lst_tasks.SelectedItems != null)
            {
                lst_tasks.Items.Remove(lst_tasks.SelectedItems);
            }
            else
            {
                MessageBox.Show("First select a task to remove", "Select a Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
