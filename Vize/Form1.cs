using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random r = new Random();
            int[] sayi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                sayi[i]= r.Next(100);
                
            }
            Array.Sort(sayi);
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(sayi[i]);
            }


        }
    }
}
