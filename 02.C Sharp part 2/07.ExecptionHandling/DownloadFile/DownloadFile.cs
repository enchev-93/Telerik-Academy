//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        try
        {
            // unncomment this to select your own path and file for download

            //Console.Write("Enter file address: ");
            //string fileAddress = Console.ReadLine();
            //Console.Write("Enter the item to download with extension: ");
            //string item = Console.ReadLine();
            //WebClient client = new WebClient();
            //client.DownloadFile(fileAddress, item);
            //Console.WriteLine("Image was downloaded in bin/Debug folder of this project.");

            WebClient downloadedClient = new WebClient();
            downloadedClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
            Console.WriteLine("Image was downloaded in bin/Debug folder of this project.");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
