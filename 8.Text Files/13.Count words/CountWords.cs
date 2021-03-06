﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;

class CountWords
{
    static void Main()
    {
        try
        {
            StreamReader readerWord = new StreamReader("words.txt");
            List<int> count = new List<int>();

            using (readerWord)
            {
                string lineWord = readerWord.ReadLine();

                while (lineWord != null)
                {
                    int counter = 0;
                    StreamReader readerText = new StreamReader("test.txt");

                    using (readerText)
                    {
                        string lineText = readerText.ReadLine();
                        while (lineText != null)
                        {
                            if (lineText.Contains(lineWord) == true)
                            {
                                counter++;
                            }
                            lineText = readerText.ReadLine();
                        }
                        count.Add(counter);
                    }
                    lineWord = readerWord.ReadLine();
                }
            }

            string[] wordCount = new string[count.Count];
            StreamReader reader = new StreamReader("words.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int temp = 0;

                while (line != null)
                {
                    wordCount[temp] = count[temp].ToString() + " times - " + line;

                    line = reader.ReadLine();
                    temp++;
                }
            }
            Array.Sort(wordCount);
            Array.Reverse(wordCount);

            StreamWriter writer = new StreamWriter("result.txt");
            using (writer)
            {
                for (int i = 0; i < wordCount.Length; i++)
                {
                    writer.WriteLine(wordCount[i]);
                }
            }

            Console.WriteLine("Done!");
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