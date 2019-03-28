
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Author: Manish R Sudani
//Course: Rapid Application Developement
//Assignment: Lab 2

namespace WindowsFormProject
{


    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>(); // empty list
        //class level declaration

        const double BASE_RESIDENTIAL = 6.00; //base cost for residential customers
        const double RES_PER_KWH = 0.052; // additional charge per kwh for residential

        const double BASE_COMMERCIAL = 60.00; //base cost for commercial customers
        const double COM_PER_KWH = 0.045; // additional charge per kwh for commercial

        const double BASE_INDUSTRIAL_PEAK = 76.00; //base cost for industrial customers during peak hours
        const double IND_PER_KWH_PEAK = 0.065; // additional charge per kwh for industrial during peak


        const double BASE_INDUSTRIAL_OFF = 40.00; //base cost for industrial customers off peak hours
        const double IND_PER_KWH_OFF = 0.028; // additional charge per kwh for industrial off peak hours

        char type; // To Auto fill Customer type (Industrial, Residential or Commercial)

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //when clicked Residential radio button
            if (btnRes.Checked)
            {     //Validates for Number and if the text boxes are Empty
                if (Validator.IsProvided(txtKwh, "Hours") &&
                   Validator.IsNonNegativeDouble(txtKwh, "Hours"))
                {
                    //local declarations
                    double kwh = 0;     //input kwh
                    double charge = 0;

                    //converts entered kwh to double
                    kwh = Convert.ToDouble(txtKwh.Text);

                    //Calls method for calculating Residential Charges
                    Customer nc = new Customer();

                    nc.CalculateResidential(kwh, BASE_RESIDENTIAL, RES_PER_KWH, out charge);

                    txtCharge.Text = charge.ToString("c"); //displays Calculated Charge and converts it to a string
                }
            }
            //when clicked Commercial radio button
            if (btnCom.Checked)
            {
                if (Validator.IsProvided(txtKwh, "Hours") &&
                   Validator.IsNonNegativeDouble(txtKwh, "Hours"))
                {
                    //local declarations
                    double kwh = 0;     //input kwh
                    double charge = 0;

                    //converts entered kwh to double
                    kwh = Convert.ToDouble(txtKwh.Text);

                    Customer nc = new Customer();
                    //Calls method for calculating Commercial Charges
                    nc.CalculateCommercial(kwh, BASE_COMMERCIAL, COM_PER_KWH, out charge);

                    txtCharge.Text = charge.ToString("c"); //displays Calculated Charge and converts it to a string
                }
            }
            //when clicked Industrial radio button
            if (btnInd.Checked)
            {
                if (Validator.IsProvided(txtPeak, "Hours") && Validator.IsNonNegativeDouble(txtPeak, "Hours") &&
                    Validator.IsProvided(txtOff, "Hours") && Validator.IsNonNegativeDouble(txtOff, "Hours"))
                {
                    //local declarations
                    double kwhPeak = 0;     //input kwhPeak
                    double kwhOff = 0;     //input kwhOff Peak
                    double charge = 0;

                    //converts entered kwhPeak and Off Peak to double
                    kwhPeak = Convert.ToDouble(txtPeak.Text);
                    kwhOff = Convert.ToDouble(txtOff.Text);

                    Customer nc = new Customer();
                    //Calls method for calculating Industrial Charges
                    nc.CalculateIndustrial(kwhPeak, BASE_INDUSTRIAL_PEAK, IND_PER_KWH_PEAK,
                                        kwhOff, BASE_INDUSTRIAL_OFF, IND_PER_KWH_OFF, out charge);
                    txtCharge.Text = charge.ToString("c"); //displays Calculated Charge and converts it to a string

                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSubmit_Click(object sender, EventArgs e) //find a place to detect the type
        {
            if (Validator.IsProvided(txtCharge, "Calculate Charge") && Validator.IsProvided(txtCustomerName, "Name") &&
                Validator.IsProvided(txtAccountNo, "Account Number") &&
                Validator.IsNonNegativeInt(txtAccountNo, "Account Number"))
            {
                if (btnRes.Checked) type = 'R';
                else if (btnCom.Checked) type = 'C';
                else if (btnInd.Checked) type = 'I';


                // create a customer object using data from text boxes
                Customer c = new Customer(txtCustomerName.Text,
                             Convert.ToInt32(txtAccountNo.Text),
                             type,
                             Convert.ToDecimal(txtCharge.Text.Replace("$", String.Empty)));

                // add it to the list and display
                customers.Add(c);
                DisplayCustomers();

                FileIO.WriteData(customers);
            }

        }

        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear(); // start with empty list box
                                        // go through the list and add each customer to the list box
            lstCustomers.Items.Add("Account#\tName\t\tType\tCharge");
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.ToDisplay());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRes.Checked = true;
            customers = FileIO.ReadData();
            DisplayCustomers();
            txtTotalCustomer.Text = customers.Count.ToString();


             //Display sum of all charges
            decimal total = 0;
            foreach (Customer cus in customers)
            {
                string[] Customersplit = new string[4];
                Customersplit = cus.ToString().Split(',');
                total =total +  Convert.ToDecimal(Customersplit[3]);

            }
            txtTotalCharge.Text = total.ToString("c");

            //Display sum of Residential Charges
            decimal totalRes = 0;
            foreach (Customer cus in customers)
            {
                string[] Customersplit = new string[4];
                Customersplit = cus.ToString().Split(',');
                if (Customersplit[2] == "R")
                {
                    totalRes = totalRes + Convert.ToDecimal(Customersplit[3]);
                }
             
            }
            txtResCharge.Text = totalRes.ToString("c");

            //Display sum of Commercial Charges
            decimal totalCom = 0;
            foreach (Customer cus in customers)
            {
                string[] Customersplit = new string[4];
                Customersplit = cus.ToString().Split(',');
                if (Customersplit[2] == "C")
                {
                    totalCom = totalCom + Convert.ToDecimal(Customersplit[3]);
                }

            }
            txtComCharge.Text = totalCom.ToString("c");

            //Display sum of Industrial Charges
            decimal totalInd = 0;
            foreach (Customer cus in customers)
            {
                string[] Customersplit = new string[4];
                Customersplit = cus.ToString().Split(',');
                if (Customersplit[2] == "I")
                {
                    totalInd = totalInd + Convert.ToDecimal(Customersplit[3]);
                }

            }
            txtIndCharge.Text = totalInd.ToString("c");
        }



        private void btnRes_CheckedChanged(object sender, EventArgs e)
        {
            txtKwh.Visible = true; //Shows textbox Kwh for residential customers
            txtOff.Visible = false; //hides textbox Kwh off for non-Industrial customers
            txtPeak.Visible = false; //hides textbox Kwh peak for non-Industrial customers
            lblOff.Visible = false; //hides label Kwh off for non-Industrial customers
            lblPeak.Visible = false; //hides label Kwh peak for non-Industrial customers
            lblKwh.Visible = true; //shows label Kwh for residential customers
            txtKwh.Focus(); //focuses on kwh for convinient entering of hours 
            
        }

        private void btnCom_CheckedChanged(object sender, EventArgs e)
        {
            txtKwh.Visible = true; //Shows textbox Kwh for commercial customers
            txtOff.Visible = false; //hides textbox Kwh off for non-Industrial customers
            txtPeak.Visible = false; //hides textbox Kwh peak for non-Industrial customers
            lblOff.Visible = false; //hides label Kwh off for non-Industrial customers
            lblPeak.Visible = false; //hides label Kwh peak for non-Industrial customers
            lblKwh.Visible = true; //shows label Kwh for residential customers
            txtKwh.Focus(); //focuses on kwh for convinient entering of hours
            txtKwh.Text = ""; //clears textbox Peak kwh
        }

        private void btnInd_CheckedChanged(object sender, EventArgs e)
        {
            txtKwh.Visible = false; //hides textbox Kwh for non-residential customers
            txtOff.Visible = true; //Shows textbox Kwh Off Peak for Industrial customers
            txtPeak.Visible = true; // Shows textbox Kwh Peak for Industrial customers
            lblOff.Visible = true; //Shows label Kwh off peak for Industrial customers
            lblPeak.Visible = true; //Shows label Kwh peak for Industrial customers
            lblKwh.Visible = false; //hides label Kwh for Industrial customers
            txtPeak.Focus();        //focuses on Peak kwh
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPeak.Text = ""; //clears textbox Peak kwh peak
            txtKwh.Text = ""; //clears textbox Peak kwh 
            txtOff.Text = ""; //clears textbox Peak kwh off peak
            txtCharge.Text = ""; //clears calculated charge 
            txtKwh.Focus(); //focuses on kwh for convinient entering of new data
            txtCustomerName.Text = ""; //clears customer name
            txtAccountNo.Text = ""; //clears account number box
            btnRes.Checked = true;
        }
        // This adds the event handler for the control
        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

    } // end form

}// end namespace

