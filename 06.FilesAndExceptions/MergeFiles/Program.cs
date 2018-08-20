using System;
using System.Linq;
using System.IO;

namespace MergeFiles
{
    class MainClass
    {
        public static void Main()
        {
            var firstInput = File.ReadAllText(@"../../../Resources/04. Merge Files/FileOne.txt");
            var secondInput = File.ReadAllText(@"../../../Resources/04. Merge Files/FileTwo.txt");

            File.WriteAllText(@"../../../Resources/04. Merge Files/merged.txt",
                              firstInput + Environment.NewLine + secondInput);
        }
    }
}
