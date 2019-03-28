
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Manish R Sudani
//Course: Rapid Application Developement
//Assignment: Lab 2

namespace WindowsFormProject
{
    public static class FileIO
    {
        const string path = "customers.txt";

        // writes data from the array to the file
        public static void WriteData(List<Customer> customers)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                // open the file for writing; overwrite old content
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                // write data
                foreach (Customer c in customers)
                    sw.WriteLine(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while writing to the file: " +
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null) sw.Close(); // also closes fs
            }
            //return customers;
        }

        // reads data from the file, puts in a list, and returns it
        public static List<Customer> ReadData()
        {
            List<Customer>customers = new List<Customer>();
            FileStream fs = null;
            StreamReader sr = null;
            string line; // for reading
            string[] fields; // result from splitting the line
            // open the file for reading and read number into data
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream) // while there is data in the file
                {
                    line = sr.ReadLine(); // read the next line
                    fields = line.Split(','); // split line into fields
                    Customer c = new Customer(fields[0], Convert.ToInt32(fields[1]), 
                        Convert.ToChar(fields[2]), Convert.ToDecimal(fields[3].Substring(0)));
                    customers.Add(c);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("File contains bad format data. Aborting reading");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading the file: "
                    + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                // close the file if open
                if (sr != null) sr.Close(); //file stream gets closed too
            }
            return customers;
        }
    }
}

