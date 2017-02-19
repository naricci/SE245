using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            // string results = "OK";
            
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
        // Receives filename (including absolute address) as myFileName for 
        //   dynamic file access
        //*******************************************************************************
        public static string readFile(string myFileName)
        {
            //create string var to hold textfile contents
            string myFileString = "";
            //Declare StreamReader object
            StreamReader sr;
            //Use error-trapping whenever accessing files or servers...
            // they may not be accessible at some point!
            try
            {
                //Create object and set file and how file is to be handled
                sr = new StreamReader(File.Open(@myFileName,
                    FileMode.Open));
                try
                {
                    //Read file from top to bottom and store it in string var
                    myFileString = sr.ReadToEnd();
                }
                finally
                {
                    sr.Close(); //Close the text file with or without errors
                }
            }
            catch (Exception exc)
            {
                string x = "ERROR: " + exc.Message; //Store error msg 
                return x;
            }
            return myFileString;   //Return the string for use by the driver program
        }
        //*******************************************************************************


        //*******************************************************************************
        // Reads and parses Contacts CSV File into array and displays each contact's info
        // line-by-line, one record per row... 
        //*******************************************************************************
        public static double parseFile(string myFileName)
        {

        }
        //*******************************************************************************
    }
}
