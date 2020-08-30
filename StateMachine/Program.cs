using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Console.WriteLine(TheMachine.CheckIt("aab"));
            Console.WriteLine(TheMachine.CheckIt("aabb"));
            Console.WriteLine(TheMachine.CheckIt("aa"));
            Console.WriteLine(TheMachine.CheckIt("aabaabb"));
            Console.WriteLine(TheMachine.CheckIt(""));
            Console.WriteLine(TheMachine.CheckIt("aaa"));*/
            string exit = "Y";
            Console.WriteLine("((a+b)*ab+(aa)*(bb)*)*");
            while (exit == "Y")
            {
                Console.WriteLine("Type A Word With Alphabet {a,b} : ");
                string word=Console.ReadLine();
                Console.WriteLine(TheMachine.CheckIt(word));

                Console.WriteLine("Do You Want To Exit Y/N");
                exit=Console.ReadLine();

            }
            


            Console.ReadKey();
        }



    }
}
