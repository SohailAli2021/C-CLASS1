using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppFisrtConsole
{

   

    internal class Program
    {
        public static void sum(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        public static void Ap()
        {
            Console.WriteLine("Aptech Korangi");
        }

        static void Main(string[] args)
        {
            Program.sum(3, 3);
            Program.Ap();


            //class 1

            //sbyte a = 127;
            //Console.WriteLine(a);
            //byte b = 255;
            //    Console.WriteLine(b);
            //short c = 32767;
            //    Console.WriteLine(c);
            //ushort d = 65535;
            //Console.WriteLine(d);
            //int e = 2147483647;
            //Console.WriteLine(e);
            //uint f = 4294967295;
            //Console.WriteLine(f);
            //Double dd = 15.22;
            //Console.WriteLine(dd);


            //int a = 20;
            //int b = 23;
            //bool c = a > b;
            //Console.WriteLine(c);
            //Console.ReadLine();


            //float salary = 12.5f;
            //Console.WriteLine(salary);
            //double b = 46767678.4554;
            //Console.WriteLine(b);







            //char a = 'A';
            //string b = "Farhana";

            //Console.Write(a +"\n");

            //Console.Write(b);

            //Console.ReadLine();

            //Console.WriteLine(" \" welcome   \" ");
            //Console.WriteLine(" \' welcome   \' ");
            //Console.WriteLine(" \\ welcome   \\ ");
            //Console.WriteLine(" welcome   \n ");
            //Console.WriteLine(" welcomeb  \b ");
            //Console.WriteLine(" welcomeb  \a ");
            //Console.WriteLine(" welcomeb  \r ");
            //Console.WriteLine(" Google \t\t \t"+ "welcome    \n ");


            //Console.WriteLine(" \a ");



            //------------------ //Class #2--------------------------------------------------

            //Console.WriteLine(Console.CapsLock);

            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(Console.BackgroundColor);

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(Console.ForegroundColor);


            //Console.WindowWidth = 20;
            //Console.WriteLine("Wellcome to Pakistan!");


            //Console.WriteLine("Your Name is :");
            //string name = Console.ReadLine();
            //Console.WriteLine("USER NAME IS :" + name);


            //With PlaceHolder
            //string name = Console.ReadLine();
            //Console.WriteLine("Your Name is:{0}",name);
            //Console.ReadKey();





            //-----------------------------------Mark sheet--------------------------------------------------

            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter Your Father Name");
            //string Fname = Console.ReadLine();


            //Console.WriteLine("Enter Your Bio Mark");
            //int bio = int.Parse(Console.ReadLine());


            //Console.WriteLine("Enter Your Chemistry Mark");
            //int che = int.Parse(Console.ReadLine());


            //Console.WriteLine("Enter Your Physics Mark");
            //int phy = int.Parse(Console.ReadLine());

            //int tm = 300;

            //int marks = bio+che+phy;
            //double per = (double)marks / tm * 100;



            //Console.WriteLine("Student Name is " + name);
            //Console.WriteLine("Student Father Name is " + Fname);
            //Console.WriteLine("Student Obtain Marks is " + marks);
            //Console.WriteLine("Student Total Marks is " + tm);
            //Console.WriteLine("Student Percentage is {0}% " , per);


            //if (per >= 80)
            //{
            //    Console.WriteLine("Student Grade is A+");
            //}

            //else if (per >= 70)
            //{
            //    Console.WriteLine("Student Grade is A");
            //}

            //else if (per >= 60)
            //{
            //    Console.WriteLine("Student Grade is B");
            //}

            //else if (per >= 50)
            //{
            //    Console.WriteLine("Student Grade is C");
            //}

            //else if (per >= 40)
            //{
            //    Console.WriteLine("Student Grade is D");
            //}

            //else
            //{
            //    Console.WriteLine("Student  is  Fail");
            //}

            //Console.ReadKey();


            //------Class #3---------------------------------------------------------------------------------

            //int num1 = int.Parse(Console.ReadLine());
            //string oprate = Console.ReadLine();
            //int num2 = int.Parse(Console.ReadLine());


            //switch(oprate)
            //{
            //    case "+":
            //        Console.WriteLine(num1 + num2);
            //        break;


            //    case "-":
            //        Console.WriteLine(num1 - num2);
            //        break;

            //    case "*":
            //        Console.WriteLine(num1 * num2);
            //        break;


            //    case "/":
            //        Console.WriteLine(num1 / num2);
            //        break;

            //        default: Console.WriteLine("Data Not Found");
            //        break;
            //}


            /// Aithmatic Operater

            //int a = 1;
            //int b = 2;
            //Console.WriteLine(a + b);


            //int a = 1;
            //int b = 2;
            //Console.WriteLine(a - b);

            //int a = 1;
            //int b = 2;
            //Console.WriteLine(a * b);


            //int a = 1;
            //int b = 2;
            //Console.WriteLine(a / b);

            //int a = 5;
            //a++;
            //Console.WriteLine(a);

            //int a = 5;
            //a--;
            //Console.WriteLine(a);

            //int a = 13;
            //int b = 2;
            //Console.WriteLine(a % b);


            //Assignment Operater


            // int valueOne = 5;
            // int valuetwo = 10;


            // Console.WriteLine("value1 =" + valueOne); //5
            // valueOne += 4;
            // Console.WriteLine("Value 1 + = 4=" + valueOne);//9
            //valueOne -= 8;
            // Console.WriteLine("value 1 - = 8=" + valueOne);//1

            // valueOne *= 7;
            // Console.WriteLine("value 1 * = 7=" + valueOne);//7
            // valueOne /= 2;
            // Console.WriteLine("value 1 / = 2=" + valueOne);//3
            // valueOne %= 3;
            // Console.WriteLine("value 1 % = 3=" + valueOne);

            // Console.WriteLine("value 1 = = Value2:{0}", (valueOne == valuetwo));


            // Console.WriteLine("value 1 = = Value2:{0}", (valueOne > valuetwo));

            // Console.WriteLine("value 1 = = Value2:{0}", (valueOne < valuetwo));

            //-----------Class 4---------------------------
            //Logic Operater

            //Console.WriteLine("Please Enter Your User Name:");
            // string username = Console.ReadLine();

            //Console.WriteLine("Please Enter Your Password:");
            //string password = Console.ReadLine();

            //if (username == "Ali"|| password == "Aptech123@")
            //{
            //    Console.WriteLine("User is Login!");
            //}
            //else
            //{
            //    Console.WriteLine("User data is not found!");
            //}

            //            int qty = 3000;
            //            double price = 11.5;

            //if ((qty == 2000)^(price == 10.5))
            //            {
            //                Console.WriteLine("You have to Compromise between qty and price");  
            //            }
            //            else
            //            {
            //                Console.WriteLine("Else");
            //            }


            //var a = false;
            //Console.WriteLine(!a);


            //Console.WriteLine(8 / 2 - 3 + 2 * 2);


            //Console.WriteLine(8 / (2 - 3) + 2 * 2);

            //-------------loops Start---------


            //for(int i = 0;i<=10;i++)
            // {
            //     Console.WriteLine(i);
            // }

            //Console.WriteLine("Enter Table");
            //int table = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter End");

            //int end = int.Parse(Console.ReadLine());

            //for(int i = 1;i<= end;i++) 
            //    {
            //    int res = table * i;
            //    Console.WriteLine(table + "X" + i + "=" + res);
            //    }
            // --------------class #5------------------



            //int e = 21;
            //while (e <= 20)
            //{
            //    Console.WriteLine(e);
            //    e++;
            //}


            //int a = 12;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            //while (a <= 10);



            // string[] cars = { "Civic", "BMW", "Cultus", "Mazad", "Civic", "BMW", "Cultus", "Mazad" , "Civic", "BMW", "Cultus", "Mazad" };

            //foreach (string car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            //for (int i = 0; i <=10; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}




            //int i;
            //for (i = 1; i <= 100; i=i+10)
            //{
            //    for(int j = i; j <i+10; j++)
            //    {
            //        Console.WriteLine(j);
            //    }

            //    Console.WriteLine("\n");
            //}

            //int[] myarr = { 1, 2, 3, 4, 5, };
            //myarr[0] = 1;
            //myarr[1] = 2;
            //myarr[2] = 3;
            //myarr[3]= 4;
            //foreach (var i in myarr)
            //{
            //    Console.WriteLine(i);
            //}


            //string[] color = { "red", "green", "white", "pink", "purple" };
            //foreach(var c in color)
            //{
            //    Console.WriteLine(c);
            //}


            //Console.WriteLine("Hello World");


            //----------------Class #6----------------------


            //int[,] num = new int[3,6]
            //{
            //    {0,1,2,3,4,5 },
            //    {1,2,3,4,5,6},
            //    {2,3,4,5,6,7}

            //};

            ////Console.WriteLine(num[0,0]);
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}



            //-------------------Class #7------------------------------


















































































































































            Console.ReadLine();















        }
    }



    public class Calculator
    {

        int num1 ;
        int num2;
        int res;


        void Add()
        {
            res = num1 + num2;
            Console.WriteLine(res);
            Console.ReadLine();
        }


    }

}

