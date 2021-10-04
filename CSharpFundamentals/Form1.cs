using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentals
{
    public partial class Form1 : Form
    {
        public delegate int IntDelegate(int a); // declare a delegate
        const double pi = 3.14;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // declare an array
                int[] arr = new int[2];
                arr[0] = 1;
                arr[1] = 2;
                textBox1.Text = "Array value : " + arr[0].ToString() + " , " + arr[1].ToString();
                textBox1.Text +=  ", Constant value : "  + pi.ToString();

                // nullable type variable
                DateTime? todayDate = null;
                textBox2.Text = "Date : " +  todayDate == null ? DateTime.Now.ToString() : "null";

                IntDelegate objDel = new IntDelegate(calcualtor.Square); // assign method to delegate
                textBox2.Text += ", Delegate execute :" + objDel.Invoke(5);

                int? i = null; // nullable variable
                int? j = 30;  // nullable variable
                int k;

                k = i ?? 25;    // if i is null then show right hand value else show I variable value
                textBox2.Text += ", (??) Null coalescing : " + k.ToString();

                // is to check datatpye and as to cast data type
                bool result = false;
                result = j is int;

                

            }
            catch (Exception ex)
            {
              
            }
        }
    }
}
