using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using NLog;

namespace ConsoleApp1
{
    class FileProcessor
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public void ProcessFile(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            ProcessLine(line);
                        }
                        catch (Exception ex)
                        {
                            Logger.Error(ex, "Error processing line: " + line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Fatal(ex, "An error occurred while reading the file.");
            }
        }

        private void ProcessLine(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                throw new InvalidOperationException("Line is empty.");
            }
            Console.WriteLine("Processed line: " + line);
        }
    }

}
