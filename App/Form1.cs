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
            //string nhap = txtNhap.Text;
            string nhap = "S:R1(A)W1(A)R2(A)W2(A)R1(B)W1(B)R2(B)W2(B)";
            string[] arrStringNhap = nhap.Split(':');
            string arr = arrStringNhap[1];
            int n = arr.Length;
            int nx = n / 5;
            string[] arrNx = new string[nx];
            for (int i = 0; i < nx - 5; i++)
            {
                arrNx[i] = arr.Substring(i * 5, i * 5 + 5);
            }
            int maxT = getMaxNum(arrNx);

            for (int i = 0; i < maxT; i++)
            {
                dataGrid.Columns.Add("T" + (i + 1), "T" + (i + 1));
            }

            foreach (string sell in arrNx)
            {
                if (sell != null)
                {
                    int i = dataGrid.Rows.Add();
                    int num = getNum(sell)-1;
                    dataGrid.Rows[i].Cells[num].Value = sell;
                }

            }

        }
        private static int getNum(string str)
        {

            if (str != null)
            {
                char[] arr = str.ToCharArray();
                foreach (char c in arr)
                {
                    if (char.IsDigit(c))
                    {

                        return (int)Char.GetNumericValue(c);
                    }
                }

            }
            return 0;


        }
        private static int getMaxNum(Array array)
        {
            int maxNum = 0;
            foreach (string st in array)
            {
                int num = getNum(st);
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            return maxNum;
        }
    }
}

//S:R1(A)W1(A)R2(A)W2(A)R1(B)W1(B)R2(B)W2(B)	
