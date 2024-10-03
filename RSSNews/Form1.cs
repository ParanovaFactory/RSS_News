using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSSNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string link()
        {
            return textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader reader = new XmlTextReader(link());
            while (reader.Read())
            {
                if (reader.Name == "title")
                {
                    listBox1.Items.Add(reader.ReadString());
                }
            }
        }
    }
}
