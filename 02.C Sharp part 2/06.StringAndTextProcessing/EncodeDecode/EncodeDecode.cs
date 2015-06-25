//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation 
//over the first letter of the string with the first of the key, the 
//second – with the second, etc. When the last key character is reached, the next is the first.

using System;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        Console.Write("Enter key: ");
        string key = Console.ReadLine();
        Console.WriteLine("Encoded message: {0}", Encoder(text, key));
        Console.WriteLine("Decoded message: {0}", Decoder(Encoder(text, key), key));
    }

    static string Encoder(string text, string key)
    {
        string encoded = string.Empty;
        for (int i = 0, j = 0; i < text.Length; i++, j++)
        {
            if (j >= key.Length)
            {
                j = 0;
            }
            encoded += (char)(text[i] ^ key[j]);
        }

        return encoded;
    }

    static string Decoder(string encoded, string key)
    {
        string decoded = string.Empty;
        for (int i = 0, j = 0; i < encoded.Length; i++, j++)
        {
            if (j >= key.Length)
            {
                j = 0;
            }
            decoded += (char)(encoded[i] ^ key[j]);
        }

        return decoded;
    }
}
