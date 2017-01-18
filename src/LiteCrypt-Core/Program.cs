﻿using System;
using System.Text;
using System.IO;

namespace LiteCryptConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("LiteCrypt Core");
            Console.WriteLine("Copyright @ MerryGoRound Club.");
            Console.WriteLine();

            Console.WriteLine("1.TripleDES\t2.MD5\t3.SHA1");
            Console.Write("Choose Cryptography: ");
            while (true)
            {
                ch = Console.ReadKey().KeyChar;
                if (ch == '1')
                {
                    LiteCrypt.TripleDES tdes = new LiteCrypt.TripleDES();
                    Console.Write("\nChoose Encrypt or Decrypt [e/d]: ");

                    while (true)
                    {
                        ch = Console.ReadKey().KeyChar;
                        if (ch == 'e' || ch == 'E')
                        {
                            Console.Write("\nInput PlainText: ");
                            tdes.Text = Console.ReadLine();

                            string cipherText = tdes.Encrypt();
                            Console.WriteLine($"Get Random Key: {tdes.Key}");
                            Console.WriteLine($"Get Random IV: {tdes.IV}");
                            Console.WriteLine($"The Cipher Text is: {cipherText}");
                            break;
                        }
                        else if (ch == 'd' || ch == 'D')
                        {
                            Console.Write("\nInput CipherText: ");
                            tdes.Text = Console.ReadLine();

                            Console.Write("Input Key: ");
                            tdes.Key = Console.ReadLine();
                            Console.Write("Input IV: ");
                            tdes.IV = Console.ReadLine();

                            string plainText = tdes.Decrypt();
                            Console.WriteLine($"The Plain Text is: {plainText}");
                            break;
                        }
                    }
                    break;
                }
                else if (ch == '2')
                {
                    LiteCrypt.MD5 md5 = new LiteCrypt.MD5();
                    Console.Write("\nInput Text: ");
                    md5.Text = Console.ReadLine();
                    string md5Code = md5.ComputeHashFromText();
                    Console.WriteLine($"The MD5 Code is: {md5Code}");
                    break;
                }
                else if (ch == '3')
                {
                    LiteCrypt.SHA1 sha1 = new LiteCrypt.SHA1();
                    Console.Write("\nInput Text: ");
                    sha1.Text = Console.ReadLine();
                    string sha1Code = sha1.ComputeHashFromText();
                    Console.WriteLine($"The SHA1 Code is: {sha1Code}");
                    break;
                }  
            }
            Console.ReadKey();
        }
    }
}