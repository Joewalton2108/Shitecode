using System;
using System.Collections.Generic;
using System.IO;


namespace O.O.P_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1="";//intialising all the variable used within the main 
            string file2="";
            string[] text1 = { };
            string[] text2= { };
            while (true)
            {
                Console.WriteLine("Whats the name of the first file?");//user input for the file that wants to be read
                try
                {

                    file1 = Console.ReadLine();
                    text1 = FileReader2(file1);//calls method to read and convert txt file into an array
                    break;
                }
                catch (Exception)//if the users enters something invalid this will run and the input will loop
                {
                    Console.WriteLine("enter a valid file name");
                   
                }
            }
            while (true)
            {
                Console.WriteLine("Whats the name of the second file?");
                try
                {
                 
                    file2 = Console.ReadLine();
                    text2 = FileReader2(file1);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("enter a valid file name");
                    break;
                }
            }    
            Boolean Result=comparison(text1, text2);//method that compares the two arrays 
            if (Result == true)//checks the result from the comparison
            {
                Console.WriteLine(file1 + ".txt and" + file2 + ".txt are not different");
            }
            else
            {
                Console.WriteLine(file1 + ".txt and " + file2 + ".txt are different");
            }
            Console.ReadLine();
        }
        static string[] FileReader2 (string file)//method that converts files to arrays
        {
            string path = Directory.GetCurrentDirectory();
            string[] array = File.ReadAllLines(path.Substring(0, path.IndexOf("bin")) + (file + ".txt"));//searches for a file called bin and searches in it's location for a file.
            return array;
        }
        static Boolean comparison (string[] text1, string[] text2)//method that compares arrays 
        {
            int sameLines = 0;//creating variables for the method
            int diferentLine = 0;
            if (text1.Length == text2.Length)//checks if the arrays are the same size, if not return false
            {
                for (int i = 0; i < text1.Length;i++)//runs through each index of the array 
                {
                    if (text1[i] != text2[i])//compares each index within the array
                    {
                        diferentLine++;
                    }
                    else { sameLines++;}
                }
                if (diferentLine == 0)//if no differnt lines returns true
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }

        }
    }
}
