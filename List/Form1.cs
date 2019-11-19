using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Random R;
        private void Form1_Load(object sender, EventArgs e)
        {
            R = new Random();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            R = new Random();
            List<int> list = new List<int>(); // создали ПУСТОЙ ЛИСТ
            list.Add(15);
            list.Add(23);
            list.Add(5);
            for (int i =0;i<3;i++)
            {
               // richTextBox1.Text += list[i] + "\n"; 
            }
            list = new List<int>();
            for (int i =0; i<10;i++)
            {
                list.Add(R.Next(10, 100));
                richTextBox1.Text += list[i] + "\n";
            }
            for (int i = 0; i<list.Count; i++)
            {
                if (list[i]>50)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i< list.Count; i++)
            {
                richTextBox2.Text += list[i] + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            List<int> ls = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                ls.Add(R.Next(10, 100));
                richTextBox1.Text += ls[i] + " ";
            }
            int OSTANOVITE = ls.Count;
            for (int i = 0; i < OSTANOVITE; i++)
            {
                if (ls[i] < 40)
                {
                    ls.Add(ls[i]);
                    ls.RemoveAt(i);
                    i--;
                    OSTANOVITE--;
                }
            }
            for(int i =0; i < ls.Count; i++)
            {
                richTextBox2.Text += ls[i] + " ";
            }
        }

        
    }
}
