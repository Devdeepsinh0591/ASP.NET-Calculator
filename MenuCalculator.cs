using System;

namespace consoleApp2
{

    public class program
    {
        /* telling the user to choose any type of calculator */
        public void name()
        {
            Console.WriteLine("Please Enter Your Name ");   
            String name = Console.ReadLine();
            Console.WriteLine("Welcome To " + name + " This Calculation In Console ");
        }
        public void Mainmenu()
        {

          


            /* telling the user to choose any type of calculator */
            Console.WriteLine("please choose what you want to do with your values\n");
            Console.WriteLine("1- Sum\n");
            Console.WriteLine("2- substracttion\n");
            Console.WriteLine("3- multiplay\n");
            Console.WriteLine("4- devision\n");
            Console.WriteLine("5- Go Back To Main Menu \n");
            int operation;
            operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:

                    new program().Add();

                    break;

                case 2:
                    new program().subtract();

                    break;

                case 3:
                    new program().multiplication();
                    break;

                case 4:
                    new program().Division();
                    break;
                case 5:
                    program p1 = new program();
                    p1.Mainmenu();
                    break;




            }
        }

        public void Add()
        {
         
            Console.WriteLine("Please Enter Your data ");
            string array = Console.ReadLine();
            string[] split = array.Split(',');
            int sum = 0;
            //Console.WriteLine(array);
            foreach(string strnum in split)
            { 
                sum+=int.Parse(strnum);
                
            }
            Console.WriteLine("The Addition Of Total Element In Array is \n" + sum);


            Mainmenu();

        }
        public void subtract()
        {
            int a, b;
            Console.WriteLine("Please Enter First Number ");
             a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please Enter Second Number ");
             b = Convert.ToInt32(Console.ReadLine());
            int sub;
            sub = a - b;
            Console.WriteLine(a + "-" + b + " is: " +sub);
            Mainmenu();

        }

        public void multiplication()
        {
            Console.WriteLine("Please Enter Your data ");
            string array = Console.ReadLine();
            string[] split = array.Split(',');
            int mul = 1;


            //foreach (int i in array)
            //{
            //    Console.WriteLine("The Total Element Of in Array Is: ",i);
            //}
            Console.WriteLine("Your Entered Array Is:  "+ array);
            foreach (string strnum in split)
            {
                mul *= int.Parse(strnum);
            }

            Console.WriteLine("The Multiplication of your Array: "+ array + " is : " +   mul);
            program p1 = new program();
            p1.Mainmenu();
        }

        public void Division()
        {
            int a, b;
            Console.WriteLine("Please Enter Your First Number ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Second Number ");
            b = Convert.ToInt32(Console.ReadLine());
            int div ;
            div = a/b;
            Console.WriteLine("The Division of :"+ a +" And " + b + " is "+div);

        }
                
    }
    class mainhere
    {
        static void Main(string[] args)
        {
            // Here mainMenu Will Be Called From Below to Show Repeat of 
            program p1 = new program();
            p1.name();
            p1.Mainmenu();
        }
        
    }
}











//Console.WriteLine(array);
//int[] arr = new int[100];

//int sum = 0;

//Console.WriteLine("Enter The Total Number That you Want To Print");
//int n = int.Parse(Console.ReadLine());


//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Element The Element {0} ", i);
//    arr[i] = Convert.ToInt32(Console.ReadLine());

//}
//sum = arr.Sum();