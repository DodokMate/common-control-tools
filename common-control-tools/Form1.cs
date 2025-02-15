using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common_control_tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gomb megnyomva!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Be van jelölve!");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Elem1");
            comboBox1.Items.Add("Elem2");
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Új szöveg";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.Mask = "(999) 000-0000";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Elem1");
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem("Elem1"));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 10;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToShortDateString());
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "Értesítés", "Üzenet", ToolTipIcon.Info);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("kép.png");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Kiválasztva!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Új szöveg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
        }
    }
}
