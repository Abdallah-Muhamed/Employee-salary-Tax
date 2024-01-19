using System.Windows.Forms;
using System;
using System.Drawing;
namespace Employee_salary
{
    partial class Form1
    {
        private void InitializeComponent()
        {

            //
            //panels
            //
            Panel1 = new Panel();
            Panel1.Size = new System.Drawing.Size(400, 170);
            Panel1.Location = new System.Drawing.Point(25, 15);
            Panel1.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(Panel1);


            Panel2 = new Panel();
            Panel2.Size = new System.Drawing.Size(400, 120);
            Panel2.Location = new System.Drawing.Point(25, 200);
            Panel2.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(Panel2);


            //
            // Labels
            //
            NumH = new Label();
            NumH.Size = new System.Drawing.Size(145,25);
            NumH.Text = "Number of hours";
            NumH.Location = new System.Drawing.Point(25,20);
            NumH.BackColor = Color.Transparent;
            NumH.ForeColor = Color.White;
            NumH.Font = new Font("Arial Rounded MT Bold", 10, FontStyle.Regular);
            Panel1.Controls.Add(NumH);

            RateH = new Label();
            RateH.Size = new System.Drawing.Size(110,25);
            RateH.Text = "Rate of hour";
            RateH.Location = new System.Drawing.Point(25,70);
            RateH.BackColor = Color.Transparent;
            RateH.ForeColor = Color.White;
            RateH.Font = new Font("Arial Rounded MT Bold", 10, FontStyle.Regular);
            Panel1.Controls.Add(RateH);

            Tax = new Label();
            Tax.Size = new System.Drawing.Size(145, 25);
            Tax.Text = "Tax";
            Tax.Location = new System.Drawing.Point(25, 120);
            Tax.BackColor = Color.Transparent;
            Tax.ForeColor = Color.White;
            Tax.Font = new Font("Arial Rounded MT Bold", 10, FontStyle.Regular);
            Panel1.Controls.Add(Tax);

            LWage = new Label();
            LWage.Size = new System.Drawing.Size(145, 25);
            LWage.Text = "Wage";
            LWage.Location = new System.Drawing.Point(25, 20);
            LWage.BackColor = Color.Transparent;
            LWage.ForeColor = Color.White;
            LWage.Font = new Font("Arial Rounded MT Bold", 10, FontStyle.Regular);
            Panel2.Controls.Add(LWage);

            LSalary = new Label();
            LSalary.Size = new System.Drawing.Size(145, 25);
            LSalary.Text = "Salary";
            LSalary.Location = new System.Drawing.Point(25, 70);
            LSalary.BackColor = Color.Transparent;
            LSalary.ForeColor = Color.White;
            LSalary.Font = new Font("Arial Rounded MT Bold", 10, FontStyle.Regular);
            Panel2.Controls.Add(LSalary);
            //
            // TextBoxes
            //
            TNumH = new TextBox();
            TNumH.BackColor = Color.DarkGray;
            TNumH.Size = new Size(200, 25);
            TNumH.Location = new System.Drawing.Point(170, 20);
            Panel1.Controls.Add(TNumH);


            TRateH = new TextBox();
            TRateH.BackColor = Color.DarkGray;
            TRateH.Size = new Size(200, 25);
            TRateH.Location = new System.Drawing.Point(170, 70);
            Panel1.Controls.Add(TRateH);

            TTax = new TextBox();
            TTax.BackColor = Color.DarkGray;
            TTax.Size = new Size(200, 25);
            TTax.Location = new System.Drawing.Point(170, 120);
            Panel1.Controls.Add(TTax);

            TWage = new TextBox();
            TWage.BackColor = Color.DarkGray;
            TWage.Size = new Size(200, 25);
            TWage.Location = new System.Drawing.Point(170, 20);
            TWage.ReadOnly = true;
            Panel2.Controls.Add(TWage);

            TSalary = new TextBox();
            TSalary.BackColor = Color.DarkGray;
            TSalary.Size = new Size(200, 25);
            TSalary.Location = new System.Drawing.Point(170, 70);
            TSalary.ReadOnly = true;
            Panel2.Controls.Add(TSalary);

            //
            // Buttons
            //
            Wage = new Button();
            Wage.FlatStyle = FlatStyle.Flat;
            Wage.FlatAppearance.BorderSize = 0;
            Wage.ForeColor = Color.White;
            Wage.BackColor = Color.FromArgb(50,50,50);
            Wage.Size = new Size(100, 40);
            Wage.Location = new System.Drawing.Point(100, 340);
            Wage.Text = "Wage";
            Wage.Click += Wage_Click;
            Controls.Add(Wage);

            Salary = new Button();
            Salary.FlatStyle = FlatStyle.Flat;
            Salary.FlatAppearance.BorderSize = 0;
            Salary.ForeColor = Color.White;
            Salary.BackColor = Color.FromArgb(50, 50, 50);
            Salary.Size = new Size(100, 40);
            Salary.Location = new System.Drawing.Point(250, 340);
            Salary.Text = "Salary";
            Salary.Click += Salary_Click;
            Controls.Add(Salary);

            //
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Name = "Form1";
            this.Text = "Employee salary";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.FromArgb(33, 33, 33);
            this.Icon = Properties.Resources.icon;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        private Panel Panel1;
        private Panel Panel2;

        private Label NumH;
        private Label RateH;
        private Label Tax;
        private Label LWage;
        private Label LSalary;

        private Button Wage;
        private Button Salary;

        private TextBox TNumH;
        private TextBox TRateH;
        private TextBox TTax;

        private TextBox TWage;
        private TextBox TSalary;
    }
}

