using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace SlicingFile
{
    class Program
    {
        private const int bufferSize = 4096;

        static void Main(string[] args)
        {
            string sourceFile = "../Resources/sliceMe.mp4";
            string destination = "";
            int parts = 5;

            Zip(sourceFile, destination, parts);

            var files = new List<string>
            {
                "Part-0.mp4.gz",
                "Part-1.mp4.gz",
                "Part-2.mp4.gz",
                "Part-3.mp4.gz",
                "Part-4.mp4.gz",
            };


            Assemble(files, destination);

        }

        private static void Zip(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream reader = new FileStream(sourceFile, FileMode.Open))
            {
                string extension = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);

                long pieceSize = (long)Math.Ceiling((double)reader.Length / parts);


                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;

                    if (destinationDirectory == string.Empty)
                    {
                        destinationDirectory = "./";
                    }

                    string currentPart = destinationDirectory + $"Part-{i}.{extension}.gz";

                    using (GZipStream writer = new GZipStream(new FileStream(currentPart, FileMode.Create), CompressionLevel.NoCompression))
                    {
                        byte[] buffer = new byte[bufferSize];
                        while (reader.Read(buffer, 0, bufferSize) == bufferSize)
                        {
                            writer.Write(buffer, 0, bufferSize);
                            currentPieceSize += bufferSize;

                            if (currentPieceSize >= pieceSize)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            string extension = files[0].Substring(files[0].LastIndexOf('.') + 1);

            if (destinationDirectory == string.Empty)
            {
                destinationDirectory = "./";
            }

            if (!destinationDirectory.EndsWith('/'))
            {
                destinationDirectory += "/";
            }

            string assembledFile = $"{destinationDirectory}Assembled.{extension}";

            using (GZipStream writer = new GZipStream(new FileStream(assembledFile, FileMode.Create), CompressionLevel.NoCompression))
            {
                byte[] buffer = new byte[bufferSize];
                foreach (var file in files)
                {
                    using (FileStream reader = new FileStream(file, FileMode.Open))
                    {
                        while (reader.Read(buffer, 0, bufferSize) == bufferSize)
                        {
                            writer.Write(buffer, 0, bufferSize);

                        }
                    }
                }
            }

        }
    }
}
