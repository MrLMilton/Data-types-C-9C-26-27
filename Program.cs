using System.Reflection.Metadata;

namespace Data_types_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 3.642f;
            char myChar = '*';
            string MyString = "this is the meaning of life";
            int myInt = 76;
            double myDouble = 846.23523;
            bool myBool = false;

            Console.WriteLine(MyString);
            Console.WriteLine(myChar + MyString);
            Console.WriteLine(MyString + myChar + myInt);

            string numForConverting = "5";
            //casting/converting datatypes
            //string to int
            Console.WriteLine(Convert.ToInt32(numForConverting));
            //string to double

            //char to Int
            Console.WriteLine(Convert.ToInt32(myChar));
            //int to string

            //int to char

            //int to double

            //double to int

            //how to take an Int as input
            Console.WriteLine("how old are you? ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you will be " + (userAge+4) + " in 2030");
        }
    }
}
