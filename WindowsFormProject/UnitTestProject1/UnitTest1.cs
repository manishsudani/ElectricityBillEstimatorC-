using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormProject;

//Author: Manish R Sudani
//Course: Rapid Application Developement
//Assignment: Lab 2
namespace UnitTestProject1
{
    [TestClass()]
    public class CalculateCharge
    {
        [TestMethod()]
        public void TestRes() //First test to calculate residential charge
        {
            double Kwh = 100;
            double Base = 6;
            double PerHour = 0.052;
            double expectedCharge = 11.20;
            double actualCharge;

            Customer Test = new Customer();
            Test.CalculateResidential(Kwh, Base, PerHour, out actualCharge);
            Assert.AreEqual(actualCharge, expectedCharge);
        }
        [TestMethod()] //Second test to calculate residential charge
        public void TestRes2() 
        {
            double Kwh = 200;
            double Base = 6;
            double PerHour = 0.052;
            double expectedCharge = 16.4;
            double actualCharge;

            Customer Test = new Customer();
            Test.CalculateResidential(Kwh, Base, PerHour, out actualCharge);
            Assert.AreEqual(actualCharge, expectedCharge);
        }

        [TestMethod()] //First test to calculate commercial charge
        public void TestCom()
        {
            double Kwh = 100;
            double Base = 60.00;
            double PerHour = 0.045;
            double expectedCharge = 60.00;
            double actualCharge;

            Customer Test = new Customer();
            Test.CalculateCommercial(Kwh, Base, PerHour, out actualCharge);
            Assert.AreEqual(actualCharge, expectedCharge);
        }
        [TestMethod()] //Second test to calculate commercial charge
        public void TestCom2()
        {
            double Kwh = 1100;
            double Base = 60.00;
            double PerHour = 0.045;
            double expectedCharge = 64.50;
            double actualCharge;

            Customer Test = new Customer();
            Test.CalculateCommercial(Kwh, Base, PerHour, out actualCharge);
            Assert.AreEqual(actualCharge, expectedCharge);
        }


         
        [TestMethod()] //First test to calculate Industrial charge
        public void TestInd()
        {
            double KwhPeak = 100;
            double OffPeak = 100;
            double BasePeak = 76.00;
            double BaseOff = 40.00;
            double PerHourPeak = 0.065;
            double PerHourOff = 0.028;
            double expectedCharge = 116.00;
            double actualCharge;

            Customer Test = new Customer();
            Test.CalculateIndustrial(KwhPeak, BasePeak, PerHourPeak, OffPeak, BaseOff, PerHourOff, out actualCharge);
            Assert.AreEqual(actualCharge, expectedCharge);
        }
        [TestMethod()] //Second test to calculate Industrial charge
        public void TestInd2()
        {
            double KwhPeak = 1100;
            double OffPeak = 1100;
            double BasePeak = 76.00;
            double BaseOff = 40.00;
            double PerHourPeak = 0.065;
            double PerHourOff = 0.028;
            double expectedCharge = 125.30;
            double actualCharge;

            Customer Test = new Customer();
            Test.CalculateIndustrial(KwhPeak, BasePeak, PerHourPeak, OffPeak, BaseOff, PerHourOff, out actualCharge);
            Assert.AreEqual(actualCharge, expectedCharge);
        }
    }

} //namespace
