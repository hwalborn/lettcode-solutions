using System;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using Problems;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("./Problems/Algorithms"))
            {
                var directoryInfo = new DirectoryInfo("./Problems/Algorithms");
                var firstFile = directoryInfo.GetFiles().OrderByDescending(f => f.CreationTime).FirstOrDefault();
                if (firstFile == null)
                {
                    throw new Exception("THERE AIN'T NO FILES HERE");
                }
                // var className = firstFile.Name.Split('.').FirstOrDefault();
                var className = "FirstBadVersion";
                var obj = Activator.CreateInstance(null, $"Problems.Algorithms.{className}") as ObjectHandle;
                ITest testFile = (ITest)obj.Unwrap();
                testFile.Go();
            }
            else
            {
                Console.WriteLine("Something's mess up about your directory structure, Holt");
            }
            // var test = "ArrayForm";
            // var woo = (ITest) new $"{test}"();
            // new ArrayForm().Go();
        }
    }
}
