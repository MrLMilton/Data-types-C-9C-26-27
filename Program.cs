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
        }
    }
}
