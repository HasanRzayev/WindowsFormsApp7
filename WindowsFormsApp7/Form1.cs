using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           comboBox_size.Items.Add(8);

           comboBox_size.Items.Add(9);
      
           comboBox_size.Items.Add(10);
           
           comboBox_size.Items.Add(11);
           
           comboBox_size.Items.Add(12);
           
           comboBox_size.Items.Add(14);
           
           comboBox_size.Items.Add(16);
           
           comboBox_size.Items.Add(18);
           
           comboBox_size.Items.Add(20);
           
           comboBox_size.Items.Add(22);
           
           comboBox_size.Items.Add(24);
           
           comboBox_size.Items.Add(26);
           
           comboBox_size.Items.Add(28);
           
           comboBox_size.Items.Add(36);
           
           comboBox_size.Items.Add(48);
           
           comboBox_size.Items.Add(72);

            //      comboBox_font.DataSource = System.Drawing.FontFamily.Families.ToList();
            //       comboBox1.DataSource = typeof(Color).GetProperties()
            //.Where(x => x.PropertyType == typeof(Color))
            //.Select(x => x.GetValue(null)).ToList();
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    comboBox1.Items.Add(prop.Name);
            }

            //comboBox1.Items.Add("Red");
            //comboBox1.SelectedItem = null;
            //comboBox1.SelectedText = "Black";
            //comboBox_font.SelectedItem = null;
            //comboBox_font.SelectedText = "[FontFamily: Name=Arial Narrow]";
            comboBox_size.SelectedItem = null;
            comboBox_size.SelectedText = "8";
        }

        private void comboBox_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), FontStyle.Italic);
        }

        private void button6_Click(object sender, EventArgs e)
        {
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            /*comboBox1.SelectedItem as string*/;


            richTextBox1.ForeColor = Color.FromName((comboBox1.SelectedItem as  string));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), FontStyle.Underline);
        }

        private void comboBox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), FontStyle.Underline);
        }
    }
}
