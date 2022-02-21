using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            //       comboBox1.DataSource = typeof(Color).GetProperties()
            //.Where(x => x.PropertyType == typeof(Color))
            //.Select(x => x.GetValue(null)).ToList();
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    comboBox1.Items.Add(prop.Name);
            }
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                comboBox_font.Items.Add(font.Name);
            }
            //comboBox1.Items.Add("Red");
            //comboBox1.SelectedItem = null;
            //comboBox1.SelectedText = "Black";
            //comboBox_font.SelectedItem = null;
            //comboBox_font.SelectedText = "[FontFamily: Name=Arial Narrow]";
            comboBox_size.SelectedItem = null;
            comboBox_size.SelectedText = "8";
     
        }
        List<FontStyle> fontstyles = new List<FontStyle>();
     
        private void comboBox_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontstyles.Clear(); 
            if (button1.BackColor != Color.Green)
            {

                button1.BackColor = Color.Green;
                fontstyles.Add(FontStyle.Bold);
                
            }
            else
            {
                button1.BackColor = Color.Transparent;
            }
            if (button3.BackColor == Color.Green)
            {
                fontstyles.Add(FontStyle.Italic);
            }
            if (button2.BackColor == Color.Green)
            {
                fontstyles.Add(FontStyle.Underline);
            }

            if (fontstyles.Count == 3)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text),fontstyles[0] | fontstyles[1] | fontstyles[2]);
            }
            else if (fontstyles.Count == 2)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), fontstyles[0] | fontstyles[1] );
            }
            else if (fontstyles.Count == 1)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), fontstyles[0]);
            }
            else if (fontstyles.Count == 0)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontstyles.Clear();
            if (button3.BackColor != Color.Green)
            {

                button3.BackColor = Color.Green;
                fontstyles.Add(FontStyle.Italic);
              
            }
            else
            {
                button3.BackColor = Color.Transparent;
            }
            if (button1.BackColor == Color.Green)
            {
                fontstyles.Add(FontStyle.Bold);
            }
            if (button2.BackColor == Color.Green)
            {
                fontstyles.Add(FontStyle.Underline);
            }

            if (fontstyles.Count == 3)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), fontstyles[0] | fontstyles[1] | fontstyles[2]);
            }
            else if (fontstyles.Count == 2)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), fontstyles[0] | fontstyles[1]);
            }
            else if (fontstyles.Count == 1)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), fontstyles[0]);
            }
            else if (fontstyles.Count == 0)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text));
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           


            richTextBox1.SelectionColor = Color.FromName((comboBox1.SelectedItem as  string));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontstyles.Clear();
            if (button2.BackColor != Color.Green)
            {

                button2.BackColor = Color.Green;
                fontstyles.Add(FontStyle.Underline);

            }
            else
            {
                button2.BackColor = Color.Transparent;
            }
            if (button1.BackColor == Color.Green)
            {
                fontstyles.Add(FontStyle.Bold);
            }
            if (button3.BackColor == Color.Green)
            {
                fontstyles.Add(FontStyle.Italic);
            }

            if (fontstyles.Count == 3)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), fontstyles[0] | fontstyles[1] | fontstyles[2]);
            }
            else if (fontstyles.Count == 2)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), fontstyles[0] | fontstyles[1]);
            }
            else if (fontstyles.Count == 1)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text), fontstyles[0]);
            }
            else if (fontstyles.Count == 0)
            {
                richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text));
            }
        }

        private void comboBox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox_font.Text, int.Parse(comboBox_size.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filename = textBox1.Text;

            using (StreamReader sr = new StreamReader(filename))
            {
                richTextBox1.Text = sr.ReadToEnd();
            }
            textBox1.Text = null;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filename = textBox2.Text;
            using (StreamWriter sr = new StreamWriter(filename))
            {
                sr.Write(richTextBox1.Text);
            }
            textBox2.Text = null;
        }
    }
}
