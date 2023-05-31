namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*****Important Things to Know About C#*******
            * 
            * 
            * C# curly braces are used to define the scope of something. They say, all of the content inside of them relates to this one thing. Here all the code inside of the curly 
            * braces relates to the Main(). 
            * 
            * A semicolon is used like a period to show the end of a line of code
            * 
            * C# largely ignores whitespace, except when inside of string (i.e. "Hello, world!" above)
            * 
            * C# is case sensitive meaning that example and Example could refer to different things. 
            * 
            * C# is type-safe which means when something is created you define what type of thing it is and it stays that type forever.
            */


            //*******Variables******//
            //A variable is just a container to hold information. When a container is created, you must define what type of data it will hold (type-safety).
            //The data stored in a container can be changed. 
            //Variables are traditionally defined using the camelCase naming convention. 
            //Variable names can ....
            //   - only begin with alphabetic characters or underscores
            //   - cannot contain spaces
            //   - must contain at least 1 alpha or numeric character
            //   - cannot be a reserved keyword (i.e. class, static, void...all shown in dark blue)
            //   - be unique within their scope {}

            //When making a variable you go through three steps: Declaration, Initialization, and Assignment
            //1. Declaration: this is when the container is created. It is given a name and a data type.
            //
            string firstName;
            int age = 24;

            //2. Initialization: this is when the container is given a value for the first time.
            //
            firstName = "Alex";
            Console.WriteLine(firstName + " is " + age);
            //3. Assignment: giving the container a new value, after the first time



            //***Creating Variables***//
            //declaration - data type then name (camelCase)


            //initialization 


            //assignment




            //*****Declaring Multiple Variables****//
            //You can make many variables at one time
            string myName, lastName, order, time;

            myName = "Lisa";
            lastName = "Acup";
            order = "burger";
            time = "11";

            Console.WriteLine(myName + " " + lastName + " ordered a " + order + " at " + time);


            //You can also declare and initialize many variables at the same time or do a mix of both




            //*****Constants****//
            //You can declare variables whose value never changes. These are called constants and they must be declared and initialized at the same time.

            int nyNum1 = 3;
            nyNum1 = 4;

            double myNum2 = 5.5;
            float myNum3 = 4.4f;
            decimal myNum4 = 7.5m;
            bool myNum5 = false;

            const int myNumber = 1;

            Console.WriteLine(myNumber);



            //****Literal Values****//
            //difference between variables and literal values

            Console.WriteLine(myNumber + "2");
            Console.WriteLine(myNumber + 2);

            //***Difference Between String and Int***//
            //Strings store an unlimited number of text characters (alpha, numeric, and symbols)
            //Ints store only numeric values 


            //Add two ints together



            //***Generating Output***//


            Console.WriteLine("Hello, World!");
        }
    }
}