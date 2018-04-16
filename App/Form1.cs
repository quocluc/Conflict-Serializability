using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string nhap = txtNhap.Text;
            string[] arrStringNhap = nhap.Split(':');
            string arr = arrStringNhap[1];
            int n = arr.Length;
            int nx = n / 5;
            string[] arrNx = new string[nx];
            for (int i = 0; i<nx-5; i++)
            {
                arrNx[i] = arr.Substring(i*5,i*5+5);
            }
            for (int i = 0; i < nx; i++)
            {
                dataGrid.Columns.Add(new DataGridViewColumn());
            }
            foreach (string sell in arrNx)
            {
                
            }
            
        }
        private static int getNum(string str)
        {
            int num = 0;
            foreach (char c in str)
            {
                if (Char.IsNumber(c))
                {
                    return (int) c;
                }
            }

            return num;
        }
    }
}

//S:R1(A)W1(A)R2(A)W2(A)R1(B)W1(B)R2(B)W2(B)	
