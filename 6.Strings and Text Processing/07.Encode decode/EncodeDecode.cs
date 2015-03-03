//Problem 7. Encode/decode
//
//    Write a program that encodes and decodes a string using given encryption key (cipher).
//    The key consists of a sequence of characters.
//    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeDecode
{
    static void Main(string[] args)
    {
        string textToEncode = "Encode me.";
        string encryptionKey = "abc";

        Console.WriteLine(EncodeString(textToEncode, encryptionKey));
    }

    static string EncodeString(string input, string cypher)
    {
        StringBuilder encoded = new StringBuilder();
        int keyLength = cypher.Length;

        for (int i = 0; i < cypher.Length; i++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                encoded.Append((char)(input[j] ^ cypher[i]));
            }
        }

        return encoded.ToString();
    }
}
