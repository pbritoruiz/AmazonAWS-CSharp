using System;
using System.IO;

namespace S3Upload
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String path = @"C:\Upload\CSharp";

            Console.WriteLine(String.Concat("Monitoring directory: ", path));

            String[] files = Directory.GetFiles(path);

            if (files != null)
            {
                AmazonS3Uploader amazonS3Uploader = new AmazonS3Uploader();

                foreach (String file in files)
                {
                    Console.WriteLine(String.Concat("Uploading files: " + Path.GetFileName(file)));

                    amazonS3Uploader.UploadFile(file);
                }
            }

            Console.ReadKey();
        }
    }
}
