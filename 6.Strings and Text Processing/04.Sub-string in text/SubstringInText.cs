//Problem 4. Sub-string in text
//
//    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Text;
using System.IO;
using System.Security;

class SubstringInText
{
    //The file text.txt is in directory bin/Debug
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader("text.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                string keyword = "in";
                int index = line.IndexOf(keyword);
                int counter = 1;

                while (line != null)
                {
                    while (true)
                    {
                        index = line.ToLower().IndexOf(keyword, index + 1);

                        if (index == -1)
                        {
                            break;
                        }
                        counter++;
                    }
                    line = reader.ReadLine();
                }
                Console.WriteLine("The substring \"{0}\" is contained {1} times in the text!", keyword, counter);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}