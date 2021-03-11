using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SortingSearchingAssignment
{
    class SortingSearchingAssignment
    {
        public static void Do()
        {
            //WriteLine();
            ReadLine();
            //LinearSearch(names);

        }
       /* private static void WriteLine()
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
            wrt.WriteLine("Shinee, 21, ECE");
            wrt.WriteLine("Minho, 20, IT");
            wrt.WriteLine("Jjong, 20, CSE");
            wrt.WriteLine("Key, 19, IT");
            wrt.WriteLine("Onew, 21, IT");
            wrt.WriteLine("Taemin, 19, CSE");
            wrt.Close();
            Console.WriteLine("student data entered into the file");
        }
       */
        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\studentDetails.txt";
            //lets declare array for names here
           // string[] names = new string[4];
            if (File.Exists(filename))
            {
                int j = 0;
                Console.WriteLine("File exists");
                string[] contents = File.ReadAllLines(filename);
                string[] names = new string[contents.Length];
                string[] classes = new string[contents.Length];
                foreach (var content in contents)
                {
                    string[] parts = content.Split(", ");
                    classes[j] = parts[1];
                    names[j] = parts[0];
                    j++;
                }
                BubbleSort(names, classes);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
        public static void BubbleSort(string[] names,string[] classes)
        {
            string temp;
            string temp2;
            Console.WriteLine("Before sorting names: ");
            Print(names, classes) ;
            for (int i = 0; i < names.Length-1; i++)
            {
                //Console.WriteLine("\n\nStarting Pass " + i.ToString());
                //Print(names);
                for (int j = 0; j < names.Length-i-1; j++)
                {
                    if (names[j + 1].CompareTo(names[j]) < 0)
                    {
                        temp2 = classes[j];
                        classes[j] = classes[j + 1];
                        classes[j + 1] = temp2;
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                        //Console.WriteLine("\nSwapped");
                        //Print(names);
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("After sorting names : ");
            Print(names, classes);
            LinearSearch(names);
        }

        private static void Print(string[] names, string[] classes)
        {
            // Console.WriteLine("");
            for(int i=0; i< names.Length;i++)
            {
                Console.WriteLine(names[i] + " "+classes[i]);
            }
            //Console.WriteLine("");

        }
        private static void LinearSearch(string[] names)
        {
            Console.WriteLine("\n\nEnter name to search");
            string input = Console.ReadLine();
            bool fg = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (input == names[i])
                {
                    fg = true;
                    Console.WriteLine("search name is found at " + i);

                }
            }
            if (!fg)
            {
                Console.WriteLine("Does not exist");
            }
        }

    }
}
