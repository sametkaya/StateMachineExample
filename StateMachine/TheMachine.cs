using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    
    class TheMachine
    {
        public enum States {A,B,C,D}
        public static char[] Alphabet = new char[] {'a','b' };
        public static States[] FiniteStates = new States[] { States.A, States.D };
        public static  bool CheckIt(string word)
        {

            Console.Write(word + " is ");
            bool isAccepted = false;
            States state = States.A; //initial contition

            foreach (char c in word)
            {

                if (!Alphabet.Contains(c))
                {
                    Console.WriteLine(c+ " Not In The Alphabet");
                    isAccepted = false;
                    return isAccepted;
                }
                switch (c)
                {
                    case 'a':
                        switch (state)
                        {
                            case States.A:
                                state = States.B;
                                break;
                            case States.B:
                                state = States.D;
                                break;
                            case States.C:
                                state = States.C;
                                break;
                            case States.D:
                                state = States.B;
                                break;
                       
                        }
                        break;
                    case 'b':
                        switch (state)
                        {
                            case States.A:
                                state = States.C;
                                break;
                            case States.B:
                                state = States.A;
                                break;
                            case States.C:
                                state = States.A;
                                break;
                            case States.D:
                                state = States.D;
                                break;
                            default:
                                break;
                        }
                        break; 
                }
            }

            if (FiniteStates.Contains(state))
            {
                isAccepted = true;
            }
            else
            {
                isAccepted = false;
            }

            return isAccepted;

        }

    }
}
