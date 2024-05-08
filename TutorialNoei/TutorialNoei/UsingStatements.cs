using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialNoei
{
    internal class UsingStatements
    {
        public UsingStatements()
        {
            // IDisposable
            using (StreamReader reader = File.OpenText(@"D:\audio.log"))
            {
                var a = reader.ReadToEnd();
                // ...
            }

            using (GholamDisposable disposable = new GholamDisposable())
            {

            }

            StreamReader reader2 = File.OpenText("file.txt");
            try
            {
                // 
            }
            finally
            {
                if (reader2 != null)
                    ((IDisposable)reader2).Dispose();
            }

            // using declaration
            if (File.Exists(@"D:\audio.log"))
            {
                // Ends whenever the enclosing block finishes.
                
                using var reader = File.OpenText(@"D:\audio.log");
                using GholamDisposable disposable = new GholamDisposable();

                Console.WriteLine(reader.ReadLine());
            }
        }

        public class GholamDisposable : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Gholam is free now.");
            }
        }
    }
}
