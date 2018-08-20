using System;
using System.IO;

namespace FolderSize
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"../../../Resources/05. Folder Size/TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText(@"../../../Resources/05. Folder Size/TestFolder/output.txt", sum.ToString());
        }
    }
}
