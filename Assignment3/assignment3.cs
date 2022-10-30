using System;


namespace Program
{
    class Program
    {




        class Employee
        {
            private int EmpNo;
            private string EmpName;
            private double Salary;
            private double HRA;
            private double TA;
            private double DA;
            private double PF;
            private double TDS;
            private double NetSalary;
            private double GrossSalary;

            public void setEmployee(int EmpNo, string EmpName, double Salary)
            {
                this.EmpNo = EmpNo;
                int Eno = this.EmpNo;
                this.EmpName = EmpName;
                string Ena = this.EmpName;
                this.Salary = Salary;
                double GS = 0.00;
                double NS = 0.00;
                // double sal = this.Salary;
                if (this.Salary < 5000)
                {
                    this.HRA = this.Salary * .10;
                    this.TA = this.Salary * .05;
                    this.DA = this.Salary * .15;
                    double S = this.Salary;
                    double H = this.HRA;
                    double T = this.TA;
                    double D = this.DA;
                    this.GrossSalary = S + H + T + D;
                    GS = this.GrossSalary;
                    this.PF = (GS / 100) * 10;
                    this.TDS = (GS / 100) * 18;
                    this.NetSalary = GS - (this.PF + this.TDS);
                    NS = this.NetSalary;

                }
                else if (this.Salary < 10000)
                {
                    this.HRA = this.Salary * .15;
                    this.TA = this.Salary * .10;
                    this.DA = this.Salary * .20;
                    double S = this.Salary;
                    double H = this.HRA;
                    double T = this.TA;
                    double D = this.DA;
                    this.GrossSalary = S + H + T + D;
                    GS = this.GrossSalary;
                    this.PF = (GS / 100) * 10;
                    this.TDS = (GS / 100) * 18;
                    this.NetSalary = GS - (this.PF + this.TDS);
                    NS = this.NetSalary;
                }
                else if (this.Salary < 15000)
                {
                    this.HRA = this.Salary * .20;
                    this.TA = this.Salary * .15;
                    this.DA = this.Salary * .25;
                    double S = this.Salary;
                    double H = this.HRA;
                    double T = this.TA;
                    double D = this.DA;
                    this.GrossSalary = S + H + T + D;
                    GS = this.GrossSalary;
                    this.PF = (GS / 100) * 10;
                    this.TDS = (GS / 100) * 18;
                    this.NetSalary = GS - (this.PF + this.TDS);
                    NS = this.NetSalary;
                }
                else if (this.Salary < 20000)
                {
                    this.HRA = this.Salary * .25;
                    this.TA = this.Salary * .20;
                    this.DA = this.Salary * .30;
                    double S = this.Salary;
                    double H = this.HRA;
                    double T = this.TA;
                    double D = this.DA;
                    this.GrossSalary = S + H + T + D;
                    GS = this.GrossSalary;
                    this.PF = (GS / 100) * 10;
                    this.TDS = (GS / 100) * 18;
                    this.NetSalary = GS - (this.PF + this.TDS);
                    NS = this.NetSalary;
                }
                else if (this.Salary >= 20000)
                {
                    this.HRA = this.Salary * .30;
                    this.TA = this.Salary * .25;
                    this.DA = this.Salary * .35;
                    double S = this.Salary;
                    double H = this.HRA;
                    double T = this.TA;
                    double D = this.DA;
                    this.GrossSalary = S + H + T + D;
                    GS = this.GrossSalary;
                    this.PF = (GS / 100) * 10;
                    this.TDS = (GS / 100) * 18;
                    this.NetSalary = GS - (this.PF + this.TDS);
                    NS = this.NetSalary;
                }
                Console.WriteLine("\n Salary = " + this.Salary + "\n Emp Name = " + Ena + "\n Emp Number = " + Eno + "\n Emp Gross Salary = " + GS + "\n Emp net Salary = " + NS);
            }
            public void CalculateSalary()
            {

            }

        }


        public static void Main(string[] arga)
        {
            Console.Write("Enter Employee ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            double Salary = double.Parse(Console.ReadLine());
            Employee emp = new Employee();
            emp.setEmployee(ID, Name, Salary);


            //Console.WriteLine( " Employee Number  =  " + emp.EmpNo + " \n Employee Name = " +  emp.EmpName + " \n Employee Salary = "+emp.Salary);
            // Console.WriteLine(" Gross Salary = " + " \n PF = " + "\n Net Salary = ");

        }
    }
}