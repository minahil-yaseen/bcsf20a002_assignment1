using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcsf20a002_assignment1
{
    public partial class Form1 : Form
    {
        string[] sub = { "mathematics", "physics", "english", "computer", "web", "OOP" };
        string[] selected;
        public Form1()
        {
            InitializeComponent();
            Box1.Items.AddRange(sub);
            selected = new string[Box1.Items.Count];
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string first_name = textBox1.Text.ToString().Trim();
            string last_name = textBox2.Text.ToString().Trim();

            int i = 0;
            foreach (var s in Box1.CheckedItems)
            {
                selected[i] = s.ToString();
                i++;
            }
            bool pre_requisit = checkBox1.Checked;
            string pre;

            if (pre_requisit)
            {
                pre = "yes";
            }
            else
            {
                pre = "no";
            }

            result.Text = $"First Name: {first_name}\n" +
                   $"Last Name: {last_name}\n" +
                   $"Selected Subjects: {string.Join(", ", selected)}\n" +
                   $"Prerequisite Clearance: {pre}";
        }
    }
}
