using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace basicsofCSharp
{
    class FileAssign
    {
        public static void Do()
        {
            WriteLine();
            ReadLine();
        }
        private static void WriteLine()
        {
            //Console.WriteLine("student details entered into the file");
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            StreamWriter wrt = File.CreateText(filename);
            wrt.WriteLine("abcd, 21, ECE");
            wrt.WriteLine("efgh, 20, IT");
            wrt.WriteLine("ijkl, 20, CSE");
            wrt.WriteLine("lmno, 19, IT");
            wrt.WriteLine("pqrs, 21, IT");
            wrt.WriteLine("tuvw, 19, CSE");
            wrt.Close();
            Console.WriteLine("student data entered into the file");
        }
    private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
           string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
                string[] contents = File.ReadAllLines(filename);
                foreach (var content in contents)
                {
                    string[] parts = content.Split(", ");
                    Console.Write("Name: {0}", parts[0]);
                    Console.Write(", Age: {0}", parts[1]);
                    Console.WriteLine(", Dept: {0}", parts[2]);
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
        }
    }
