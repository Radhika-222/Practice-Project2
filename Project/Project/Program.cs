using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr;
            try
            {
                string fpath = "E:\\Mphasis\\Project\\Student_data.txt";
                Console.WriteLine("Student data:");
                sr = new StreamReader(fpath);
                string textfile = "";
                while ((textfile = sr.ReadLine()) != null)
                {
                    Console.WriteLine(textfile);
                }
                sr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
        
    

