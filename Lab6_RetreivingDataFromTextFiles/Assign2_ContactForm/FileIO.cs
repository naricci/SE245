using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;  // Added to know what a listbox is...

namespace Assign2_ContactForm
{
    class FileIO
    {
        //*******************************************************************************
        // Creates and/or Opens Contacts CSV File and writes/appends data to end of file.
        //*******************************************************************************
        public static string writeFile(string myFileName, string myString)
        {
            // Declare StreamWriter Object
            StreamWriter sw;

            // String for Feedback
            string strFeedback = "Record Added Successfully";

            // Try Catch Block
            try
            {
                // Create StreamWriter and set filename/mode
                sw =
                    new StreamWriter(File.Open(myFileName,
                    FileMode.OpenOrCreate));

                // Place cursor at first column on new row at end of last record
                sw.BaseStream.Seek(0, SeekOrigin.End);

                // Write Data to bottom of File
                sw.WriteLine(myString);

                // Force the File to Write, Save and Clear Buffer
                sw.Flush();

                // Close File whether or not there was an Error
                sw.Close();
            }
            catch (Exception err)
            {
                string x = err.Message;
                strFeedback = "ERROR: " + x;
            }
            finally
            {
            }

            // return Feedback
            return strFeedback;
        } 
        //*******************************************************************************
        

        //*******************************************************************************
        // Reads total file into string variable and returns it for use by driver program
        // Receives filename (including absolute address) as myFileName for dynamic file
        // access.
        //*******************************************************************************
        public static string readFile(string myFileName)
        {
            // Create string var to hold textfile contents
            string myFileString = "";
            // Declare StreamReader object
            StreamReader sr;
            // Use error-trapping whenever accessing files or servers...
            // They may not be accessible at some point!
            try
            {
                // Create object and set file and how file is to be handled
                sr = new StreamReader(File.Open(@myFileName,
                    FileMode.Open));
                try
                {
                    // Read file from top to bottom and store it in string var
                    myFileString = sr.ReadToEnd();
                }
                finally
                {
                    sr.Close(); // Close the text file with or without errors
                }
            }
            catch (Exception exc)
            {
                string x = "ERROR: " + exc.Message; // Store error msg 
                return x;
            }
            return myFileString;   // Return the string for use by the driver program
        }
        //*******************************************************************************


        //*******************************************************************************
        // 
        //*******************************************************************************
        public static ListBox ListAllContacts(string myFileName)
        {
            //Var to hold our pays (Create an instance of a ListBox in Memory)
            ListBox LBTemp = new ListBox();

            // Create our StreamReader object
            StreamReader sr;

            try
            {
                //Open the specified file for Input
                sr = new StreamReader(File.Open(@myFileName,
                    FileMode.Open));

                try
                {
                    //While the end of file is not reached
                    //*****************************************
                    while (sr.Peek() != -1)
                    {
                        //row contains the string from one line of the textfile
                        string row = sr.ReadLine();

                        //Creates an array of strings called columns
                        // then...Parses the string (split) by each comma (',')
                        // and stores each parsed piece into the array (columns)
                        //Therefore columns[0] should be the date, columns[1] should
                        // be the first name, etc
                        string[] columns = row.Split(',');

                        //Column [6] should be the paycheck amount
                        // we convert that amount from a string to a double
                        // then add to listbox
                        string info = columns[1] + "," + columns[2] + "," + columns[7];
                        // double.Parse(columns[14])
                        LBTemp.Items.Add(info);
                    }
                    //*****************************************
                }
                finally
                {
                    //Close the file with or without the error
                    sr.Close();
                }
            }
            catch (Exception exc)
            {
                //store the error message...so far, we are doing nothing with it
                string x = exc.Message;
            }

            //Return the var (LBTemp), which should have the total payout for all the checks
            return LBTemp;
        }
        //*******************************************************************************


    }
}
