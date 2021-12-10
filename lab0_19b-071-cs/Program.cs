using System;

namespace lab0
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
            //Console.WriteLine("enter 1st number");
            //var a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter 2nd number");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter 3rd number");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter 4th number");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter 5th number");
            //int e = Convert.ToInt32(Console.ReadLine());
            //int result = (a + b + c + d + e) / 5;
            //Console.WriteLine("average of 5 numbers:" + result);



            //Console.WriteLine("Circle");
            //Console.WriteLine("Enter Radius of circle");
            //double RadiusCircle = Convert.ToDouble(Console.ReadLine());

            //double areaOfCircle = 3.14 * (RadiusCircle * RadiusCircle);
            //Console.WriteLine("Area of circle is :" + areaOfCircle);

            //Console.WriteLine("Triangle");
            //Console.WriteLine("enter lenght of triangle : ");
            //double l = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter breadth of triangle : ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Area of triangle is :" + l * b);



            //Console.WriteLine("Basic arithmetic operators");
            //Console.WriteLine("enter a value : ");

            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter b value : ");

            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("result of A + B :" + (a + b));
            //Console.WriteLine("result of A - B :" + (a - b));
            //Console.WriteLine("result of A * B :" + (a * b));
            //Console.WriteLine("result of A / B :" + (a / b));
            //Console.WriteLine("result of A % B :" + (a % b));
            //Console.WriteLine("result of A ++ :" + a++);
            //Console.WriteLine("result of A -- :" + a--);


            //Console.WriteLine("even odd program");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("enter number is even");
            //}
            //else
            //{
            //    Console.WriteLine("enter number is odd");

            //}

            //Console.WriteLine("marks1");
            //double m1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("marks2");
            //double m2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("marks3");
            //double m3 = Convert.ToDouble(Console.ReadLine());
            //double total = m1 + m2 + m3;
            //double percentage = (total / 300) * 100;
            //if(percentage>= 85)
            //{
            //    Console.WriteLine("A+");
            //}
            //else if (percentage >= 75)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (percentage >= 65)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (percentage >= 55)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (percentage >= 40)
            //{
            //    Console.WriteLine("F");
            //}

            //Console.WriteLine("OPERAND 1 : ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("OPERAND 2 : ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("operator   : ");
            //char c = Convert.ToChar(Console.ReadLine());
            //if(c == '+')
            //{
            //    Console.WriteLine("addition : " + (a + b));
            //}
            //else if (c == '-')
            //{
            //    Console.WriteLine("substraction : " + (a - b));
            //}
            //else if (c == '*')
            //{
            //    Console.WriteLine("multiplication : " + (a * b));
            //}
            //else if (c == '/')
            //{
            //    Console.WriteLine("division : " + (a / b));
            //}

            //Console.WriteLine("enter a number to print it's table");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(a + " x " + i + " = " + (a * i));
            //}


            //Console.WriteLine("enter a string to be reversed");
            //string a = Console.ReadLine();
            //string b = "";
            //for (int i = a.Length - 1; i >= 0; i--)
            //{
            //    b = b + a[i];
            //}
            //Console.WriteLine("the reverse string is : " + b);


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    for (int k = 2; k <= (6 - i); k++)
            //    {
            //        Console.Write(k + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("enter num1 ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter num2 ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //while(a < b)
            //{
            //    if(a%2 == 0)
            //    {
            //        Console.WriteLine("Even number : " + a);
            //    }
            //    else
            //    {
            //        Console.WriteLine("odd number : " + a);

            //    }
            //    a++;    
            //}
            //bool flag = true;
            //do
            //{
            //    Console.WriteLine("enter username");
            //    string a = Console.ReadLine();
            //    Console.WriteLine("enter password");
            //    string b = Console.ReadLine();
            //    if (a == "muhammad nameer" & b == "hello")
            //    {
            //        Console.WriteLine("succes");
            //        flag = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("enter correct credentials again");
            //    }
            //} while (flag);





            //int[] arr = new int[5] {1,2,3,4,5};
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            //String[] arr = new String[4] { "mango", "apple", "grapes", "banana" };
            //Console.WriteLine("enter a string to search in array");
            //String a = Console.ReadLine();
            //bool exists;
            //if ( exists = arr.Contains(a))
            //{
            //    Console.WriteLine(a+" found");
            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}


            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 9 } };
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine("arr[{0},{1}] = {2}", i, j, arr[i, j]);
            //    }
            //}



            //List<int> numbers = new List<int> { 3, 14, 15, 92, 6 };
            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();


            class Box {
            public double length; // Length of a box
            public double breadth; // Breadth of a box
            public double height; // Height of a box
        }
        class Boxtester
        {
            static void Main(string[] args)
            {
                Box Box1 = new Box(); // Declare Box1 of type Box
                Box Box2 = new Box(); // Declare Box2 of type Box
                double volume = 0.0; // Store the volume of a box here
                                     // box 1 specification
                Box1.height = 5.0;
                Box1.length = 6.0;
                Box1.breadth = 7.0;
                // box 2 specification
                Box2.height = 10.0;
                Box2.length = 12.0;
                Box2.breadth = 13.0;

                // volume of box 1
                volume = Box1.height * Box1.length * Box1.breadth;
                Console.WriteLine("Volume of Box1 : {0}", volume);
                // volume of box 2
                volume = Box2.height * Box2.length * Box2.breadth;
                Console.WriteLine("Volume of Box2 : {0}", volume);
                Console.ReadKey();
            }
        }
    }









    
    
