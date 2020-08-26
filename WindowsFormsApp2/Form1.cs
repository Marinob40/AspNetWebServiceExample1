using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.ServiceReference1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       WebService1SoapClient obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxNum1.Text == "" || txtBoxNum2.Text == "")
            {
                MessageBox.Show("Please add values in both fields.");
            }
            else
            {
                int a = Convert.ToInt32(txtBoxNum1.Text);
                int b = Convert.ToInt32(txtBoxNum2.Text);
                int ans = obj.Add(a, b);
                MessageBox.Show("The two numbers added equal to " + ans);
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtBoxNum1.Text == "" || txtBoxNum2.Text == "")
            {
                MessageBox.Show("Please add values in both fields.");
            }
            else
            {
                int a = Convert.ToInt32(txtBoxNum1.Text);
                int b = Convert.ToInt32(txtBoxNum2.Text);
                int ans = obj.Subtract(a, b);
                MessageBox.Show("The two numbers subtracted equal to " + ans);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtBoxNum1.Text == "" || txtBoxNum2.Text == "")
            {
                MessageBox.Show("Please add values in both fields.");
            }
            else
            {
                int a = Convert.ToInt32(txtBoxNum1.Text);
                int b = Convert.ToInt32(txtBoxNum2.Text);
                int ans = obj.Multiply(a, b);
                MessageBox.Show("The two numbers multiplied equal to " + ans);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtBoxNum1.Text == "" || txtBoxNum2.Text == "")
            {
                MessageBox.Show("Please add values in both fields.");
            }
            else
            {
                int a = Convert.ToInt32(txtBoxNum1.Text);
                int b = Convert.ToInt32(txtBoxNum2.Text);
                int ans = obj.Divide(a, b);
                MessageBox.Show("The two numbers dividied equal to " + ans);
            }
        }
    }
}
