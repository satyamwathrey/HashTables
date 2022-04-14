using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("=-=-=-=-=-Welcome To The Hash Tables Program-=-=-=-=-=");

            //Variable
            int key = 0;

            //Paragraph words assign to array
            string paragraphPhrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paragraph = paragraphPhrase.Split(' ');

            //Object of class MyMapNode
            MyMapNode<int, string> myMapNode = new MyMapNode<int, string>(paragraph.Length);

            //Add 
            foreach (string word in paragraph)
            {
                myMapNode.Add(key, word);
                key++;
            }

            //Display
            Console.WriteLine("--------------------------------");
            Console.WriteLine("frequency of words ");
            Console.WriteLine("--------------------------------");

            myMapNode.Display();
        
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.ReadLine();
        }
    }
}
