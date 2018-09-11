using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LİSTBOX_TAN_LİSTBOXA_EKLEME_ARAMA
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger = -1;
            for (int i = 0; i < listBox1.Items.Count; i++) 
            {
                if (listBox1.Items[i].ToString() == textBox1.Text)
                {
                    deger = i;
                }
                if (deger == -1)
                {
                    MessageBox.Show("Girilen Değer Bulunamadı");
                }
                else
                {
                    listBox2.Items.Add(listBox1.Items[deger].ToString());
                    listBox1.Items.RemoveAt(deger);
                }
            }
        }
    }
}

        
    
    



