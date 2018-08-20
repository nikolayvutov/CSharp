using System;
using System.IO;
using System.Text;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = new FileStream("../Resources/copyMe.png", FileMode.Open))
            {
                using (var secondStream = new FileStream("copyMe-Copy.png", FileMode.Create))
                {
                    var bytesOfImage = Encoding.UTF8.GetBytes("copyMe");

                    int read;
                    while ((read = fileStream.Read(bytesOfImage, 0, bytesOfImage.Length)) > 0)
                    {
                        secondStream.Write(bytesOfImage, 0, read);
                    }
                }

            }
        }
    }
}
