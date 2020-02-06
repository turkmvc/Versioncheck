using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace versioncheck
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://raw.githubusercontent.com/0x21/Versioncheck/master/version.txt");
            string text = System.IO.File.ReadAllText(@"Version.txt");
            if (text != reply)
            {
                Console.WriteLine("Yazılım güncel değil");
                Console.WriteLine(reply);
                Console.WriteLine(text);
                
            }
            else
            {
                Console.WriteLine("Yazılımın Güncel");
            }
            Console.ReadKey();
        }
    }
}
