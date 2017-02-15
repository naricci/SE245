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

            // return feedback
            return strFeedback;
        }
    }
}
