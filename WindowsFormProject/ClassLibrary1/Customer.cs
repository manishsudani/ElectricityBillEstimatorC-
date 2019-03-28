using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Author: Manish R Sudani
//Course: Rapid Application Developement
//Assignment: Lab 2
namespace WindowsFormProject
{
    public class Customer
    {
        //private data
        private string customerName;
        private int accountNumber;
        private char customerType;
        private decimal chargeAmount;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set
            { accountNumber = value; }
        }
        public char CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }
        public decimal ChargeAmount
        {
            get { return chargeAmount; }
            set
            {
                if (value >= 0) { chargeAmount = value; }
            }
        }

        

        
        public Customer(string c = "Unknown", int a = 0, char t = 'R', decimal cr = 0)
        {
            CustomerName = c;
            AccountNumber = a;
            CustomerType = t;
            ChargeAmount = cr;
        }
        public override string ToString()
        {
            return CustomerName + "," + AccountNumber.ToString() + "," + CustomerType.ToString()+ "," + ChargeAmount.ToString();
        }

        public string ToDisplay()
        {
            return AccountNumber.ToString() + "\t\t" + CustomerName + "\t" +
                "\t" + CustomerType.ToString() + "\t" + ChargeAmount.ToString();
        }
       
        public double CalculateResidential(double Kwh, double Base, double PerHour, out double charge)
        {
            if (Kwh > 0)
            {
                charge = Base + (Kwh * PerHour); //Base charge plus hourly rate times hours
                return charge; //returns calculated charge

            }
            else
            {
                charge = Base; // Base charge if Zero hours used or Entered
                return charge; //returns calculated charge
            }
        }
        //Method for Calculating Commercial Charges
        public double CalculateCommercial(double KwhCom, double BaseCom, double PerHourCom, out double chargeCom)
        {
        

            double KwhOverCom; //declaration of double for over 1000 kwh
            if (KwhCom > 1000)
            {
                KwhOverCom = KwhCom - 1000; //calculates charge over 1000 kwh
                chargeCom = BaseCom + (KwhOverCom * PerHourCom); //Base charge plus hourly rate times hours
                return chargeCom; //returns calculated charge

            }
            else
            {
                chargeCom = BaseCom; // Base charge if Zero hours used or Entered
                return chargeCom; //returns calculated charge
            }
        }
        //Method for Calculating Commercial Charges
        public double CalculateIndustrial(double KwhPeak, double BasePeak, double PerHourPeak,
                            double KwhOff, double BaseOff, double PerHourOff, out double chargeInd)
        {
           

            double KwhOverPeak; //declaration of double for over 1000 kwh during Peak Hour
            double KwhOverOff;      //declaration of double for over 1000 kwh during off peak hour

            if (KwhPeak > 1000 || KwhOff > 1000)
            {
                KwhOverPeak = KwhPeak - 1000; //calculates charge over 1000 kwh during Peak Hour
                KwhOverOff = KwhOff - 1000;  //calculates charge over 1000 kwh during off peak hour

                //Base charge plus hourly rate times hours(total of peak and off peak hours)
                chargeInd = (BasePeak + (KwhOverPeak * PerHourPeak)) + (BaseOff + (KwhOverOff * PerHourOff));
                return chargeInd; //returns calculated charge

            }
            else
            {
                chargeInd = (BasePeak + BaseOff); //If hours entered are zero (total of peak and off peak hours)
                return chargeInd; //returns calculated charge
            }

        }

    }
}

