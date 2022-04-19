using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dragon
{
    public partial class Form1 : Form
    {

        int n;
        string[] a= new String[1024];

        int w = 1920, h = 1080;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            
            Int32.TryParse(textBox1.Text, out n);
            if(n <2){
                //MessageBox.Show("too small!");
                return;
            }
            a[2] = "\\";

            for(int i = 3; i <= n; i++)
            {
                a[i] = "";
                string org=a[i-1];
                for(int j = org.Length-1;j>=0 ; j--)
                {
                    if(org[j] == '\\')
                    {
                        a[i] += '/';
                    }
                    else
                    {
                        a[i] += '\\';
                    }
                }
                a[i] += '\\';
                for(int j = 0; j < org.Length; j++)
                {
                    a[i]+=org[j];
                }
            }
            Graphics g = this.CreateGraphics();

            int len;
            int siz;
            Int32.TryParse(textBox3.Text, out len);

            Int32.TryParse(textBox2.Text, out siz);

            if (checkBox2.Checked)
            {
                len = 40;
                if (n > 10) len = 12;
                if (n > 14) len = 6;
                if (n > 15) len = 3;
                if (n > 17) len = 2;
                if (n > 18) len = 1;
                if (w < 2000) len /= 2;
            }

            Pen pen = new Pen(Brushes.White, siz);
            g.FillRectangle(Brushes.Black, 0, 0, w, h);
            int x, y;
            int xo, yo;
            
            int dir = 1;
            
            g.DrawLine(pen, w/2, h/2, w/2, h/2 - len);
            xo = w/2; yo = h/2 - len;
            g.DrawLine(pen, xo, yo, xo + len, yo);
            xo = xo + len;

            for (int i = 2; i <= n; i++)
            {
                g.DrawLine(pen, xo, yo, xo, yo + len);
                yo = yo + len;
                dir = 1;//down, 1down 2right 3up 4left
                for (int j = 0; j < a[i].Length; j++)
                {
                    char turn = a[i][j];
                    if (turn == '\\')
                    {
                        dir++;
                    }
                    else
                    {
                        dir--;
                    }
                    if (dir == 0)
                    {
                        dir = 4;
                    }
                    else if (dir == 5)
                    {
                        dir = 1;
                    }
                    if (dir == 1)
                    {
                        g.DrawLine(pen, xo, yo, xo, yo + len);
                        yo = yo + len;
                    }
                    else if (dir == 2)
                    {
                        g.DrawLine(pen, xo, yo, xo + len, yo);
                        xo = xo + len;
                    }
                    else if (dir == 3)
                    {
                        g.DrawLine(pen, xo, yo, xo, yo - len);
                        yo = yo - len;
                    }
                    else if (dir == 4)
                    {
                        g.DrawLine(pen, xo, yo, xo - len, yo);
                        xo = xo - len;
                    }
                }

            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            Int32.TryParse(textBox1.Text, out n);
            n++;
            textBox1.Text = n.ToString();
            if (checkBox1.Checked)
            {
                button3.PerformClick();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBox1.Text, out n);
            n--;
            textBox1.Text = n.ToString();
            if (checkBox1.Checked)
            {
                button3.PerformClick();
            }
        }
    }
}
