using CS_ADV_1.Generics;

namespace CS_ADV_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics [sawp example]

            //int a = 5; int b = 10;
            //Console.WriteLine(a);  //5
            //Console.WriteLine(b);  //10
            //Console.WriteLine("\n");

            //Helper.swap<int>(ref a, ref b); // ---> after calling swap();
            //Console.WriteLine(a); // 10
            //Console.WriteLine(b); //5
            //Console.WriteLine("\n");

            //---------------------------------------------------------------------------------------------

            //double x = 5.5; double y = 6.6;
            //Console.WriteLine(x); // 5.5
            //Console.WriteLine(y); // 6.6
            //Console.WriteLine("\n");

            //Helper.swap<double>(ref x, ref y); // ---> after calling swap();
            //Console.WriteLine(x);   // 6.6
            //Console.WriteLine(y);  //5.5
            //Console.WriteLine("\n");

            //---------------------------------------------------------------------------------------------

            //Point p1 = new Point(10, 20);
            //Point p2 = new Point(100, 200);

            //Console.WriteLine(p1.ToString()); // (10 , 20)
            //Console.WriteLine(p2.ToString()); // (100 , 200)
            //Console.WriteLine("\n");

            //Helper.swap<Point>(ref p1, ref p2);  // ---> after calling swap();
            //Console.WriteLine(p1.ToString()); // (100 , 200)
            //Console.WriteLine(p2.ToString()); // (10 , 20)
            //Console.WriteLine("\n");

            //---------------------------------------------------------------------------------------------

            #endregion


            #region Generics [search example]

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            //Helper.search<int>(numbers, 7); // the index of 7 is: 6
            //Helper.search<int>(numbers, 15); //  can not find the index of selected value.
            //Console.WriteLine("\n");


            //--------------------------------------------------------------------------------------------------------

            //Employee[] employees  = 
            //{ 
            //    new Employee(){id = 1 , name = "Omar" , salary = 5000},
            //    new Employee(){id = 2 , name = "Mona" , salary = 7500},
            //    new Employee(){id = 3 , name = "Ahmed" , salary = 10000}

            //};



            //Helper.search<Employee>(employees, new Employee() { id = 1, name = "Omar", salary = 5000 });
            //// the index of (id: 1 :: name: Omar :: salary: 5000) is: 0
            //Console.WriteLine("\n");


            //-----------------------------------------------------------------------------------------------------------------

            #endregion


            #region Generics [sort Example]

            //int[] numbers = { 12, 3, 8, 9, 1, 0 };
            //Helper<int>.BubbleSort(numbers);
            //foreach (int num in numbers)  // ----> after BubbleSort();
            //{
            //    Console.Write(num + " ");  // output: 0 1 3 8 9 12
            //}
            //Console.WriteLine("\n");


            //----------------------------------------------------------------------------

            //Employee[] employees = new Employee[]
            //{
            //    new Employee(){id = 1 , name = "Omar" , salary = 5000},
            //    new Employee(){id = 2 , name = "Mona" , salary = 7500},
            //    new Employee(){id = 3 , name = "Ahmed" , salary = 10000}

            //};


            //Helper<Employee>.BubbleSort(employees); // ---> after BubbleSort();
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee.ToString());
            //}


            // output:
            //(id: 1 :: name: Omar::salary: 5000)
            //(id: 2 :: name: Mona::salary: 7500)
            //(id: 3 :: name: Ahmed::salary: 10000)



            //-----------------------------------------------------------------------------------

            //Point[] points =
            //{
            //    new Point(5,6),
            //    new Point(1,3),
            //    new Point(8,4)
            //};

            //Helper<Point>.BubbleSort(points);  // ----> after calling BubbleSort();

            //foreach (Point p in points)
            //{
            //    Console.WriteLine(p);
            //}

                 // output
                 // (1, 3)
                //(5, 6)
                //(8, 4)



            //---------------------------------------------------------------------------------
             #endregion


            #region Equality (== , Equals() ) in [struct] VS [class]


            //Employee e1 = new Employee(1, "Omar", 1000);
            //Employee e2 = new Employee(2, "Mona", 3000);
            //Employee e3 = new Employee(1, "Omar", 1000);


            //Console.WriteLine($"e1-HC: {e1.GetHashCode()}"); //e1-HC: 54267293
            //Console.WriteLine($"e2-HC: {e2.GetHashCode()}"); //e2-HC: 18643596
            //Console.WriteLine("\n");


            //* after override on Equals(); and GetHashCode(); methods in class Employee
            //* same HachCode but not the same  objects 
            //Console.WriteLine($"e1-HC: {e1.GetHashCode()}"); // e1-HC: 1351789234
            //Console.WriteLine($"e3-HC: {e3.GetHashCode()}"); // e3-HC: 1351789234
            //Console.WriteLine("\n");


            // if (e1==e2)
            //     Console.WriteLine("equal");
            //else
            //     Console.WriteLine("not equal");


            // if (e1.Equals(e2))
            //     Console.WriteLine("equal");
            // else
            //     Console.WriteLine("not equal");


            /*===================NOTES:==============*/

            //* == in [class] it compare between references, you don't need to overload on == to used in class it is already valid with class.
            //* Equals(); in [class] it compare between references.
            //* ممكن اخليهم يقارنو بالقيمة بتاعت الكائن من خلال اني اعمل override Equals();
            //* او اعمل overload == 

            //*  == in [struct] it compare between object state "data". , and must be make an overloading on == operator to enable you used in struct. 
            //*  Equals(); in [struct] it compare between object state "data".

            /*===================NOTES:==============*/

            #endregion




        }
    }
}
