using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_salary
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Wage_Click(object sender, EventArgs e)
        {
            double tx = double.Parse(TTax.Text);
            TWage.Text = (CalculateWage()-(tx/4)).ToString("C");
        }

        private void Salary_Click(object sender, EventArgs e)
        {
            double tx = double.Parse(TTax.Text);
            TSalary.Text= ((CalculateWage()*4)-tx).ToString("C");
        }
       private double CalculateWage()
        {
            double hours = double.Parse(TNumH.Text);
            double rate = double.Parse(TRateH.Text);
            double normalHours = Math.Min(hours, 40);
            double overtimeHours = Math.Max(hours - 40, 0);

            double wage = (normalHours * rate) + (overtimeHours * (rate * 2));
            return wage;
        }

    }
}
