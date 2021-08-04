using System;

namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Hunter h = new Hunter("Marion", "Jones", "Canon") { Age = 32 };
            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());

            //Hunter h2 = new Hunter("Marion", "Jones", "Nikon") { Age = 32 };
            //Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            //Console.WriteLine($"h HashCode: {h.GetHashCode()}");
            //Console.WriteLine($"Type: {h.GetType()}");
            //Console.WriteLine($"h ToString: {h.ToString()}");

            //Console.WriteLine($"h: {h}");

            //Rectangle r = new Rectangle(5, 7);
            //int a = r.CalculateArea();

            Airplane a = new Airplane(200, 100, "JetsRUs")
            {
                NumPassengers = 150
            };
            a.Ascend(500);
            Console.WriteLine(a.Move(3));
            Console.WriteLine(a);
            a.Descend(200);
            Console.WriteLine(a.Move());
            a.Move();
            Console.WriteLine(a);
        }
        //    Person martin = new Person("Martin", "Beard", 21);
        //    Person alex = new Person("Alex", "Rae", 24);
        //    Person ben = new Person("Benjamin", "Fung", 21);
        //    Console.WriteLine(alex.GetFullName());
        //    Console.WriteLine(alex.Age);

        //    Person nish = new Person("Nishant");
        //    Person abiola = new Person("Abiola", "Kuku");

        //    alex.Age = 30;
        //    Console.WriteLine($"Alex's age is now {alex.Age}");

        //    var zoe = new Person("Zoe", "Okereke") { Age = 31 };

        //    var list = new ShoppingList() { Bread = 2, Potato = 6, Milk = 2 };

        //    var paula = new Person() { FirstName = "Paula", LastName = "Kendra", Age = 23 };

        //    Point3D p = new Point3D(3, 6, 2);
        //    var p2 = new Point3D();
        //    Point3D p3;
        //    Point3D p4 = new Point3D(1, 7);

        //    Person john = new Person("John", "Doe") { Age = 20 };
        //    Point3D pt3D = new Point3D(5, 8, 2);
        //    DemoMethod(pt3D, john);
        //}

        //public struct Point3D
        //{
        //    public int x;
        //    public int y, z;
        //    public Point3D(int x, int y, int z = 5)
        //    {
        //        this.x = x;
        //        this.y = y;
        //        this.z = z;
        //    }
        //}
        //static void DemoMethod(Point3D pt, Person p)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;


        
    }
    

}
