using System;
using System.Collections.Generic;

namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IShootable> shootables = new List<IShootable>()
            {
                new Hunter("Nish", "Mandal", new Camera("Pentax")),
                new Hunter("Nish", "Mandal", new WaterPistol("Supersoaker")),
                new Hunter("Nish", "Mandal", new LaserGun("Acme")),
                new Hunter("Nish", "Mandal", new WaterPistol("Acme"))
            };
            foreach (Hunter gameObj in shootables)
            {
                Console.WriteLine(gameObj.Shoot());
            }

            #region movable example
            //list<imovable> movablegameobjects = new list<imovable>()
            //{
            //    new person("michael", "jordan"),
            //    new airplane(400, 200, "airbus") { numpassengers = 57 },
            //    new vehicle(12, 20) { numpassengers = 4 },
            //    new hunter("barack", "obama", "nikon")
            //};
            //foreach (var gameobj in movablegameobjects)
            //{
            //    console.writeline(gameobj.move());
            //}
            #endregion
        }
        //    List<Object> gameObjects = new List<object>()
        //        {
        //            new Person("Cathy", "French"),
        //            new Airplane(400, 200, "Boeing") {NumPassengers = 55},
        //            new Vehicle(12, 20) {NumPassengers = 6},
        //            new Hunter("Henry", "Hodgkins", "Pentax")

        //        };
        //        foreach (var gameObj in gameObjects)
        //        {
        //            Console.WriteLine(gameObj);
        //        }

        //Person yolanda = new Person("Yolanda", "Young");
        //Hunter henry = new Hunter("Henry", "Hodgkins", "Pentax");
        //SpartaWrite(yolanda);
        //SpartaWrite(henry);
        //public static void SpartaWrite(Object obj)
        //{
        //    Console.WriteLine(obj.ToString());
        //    if (obj is Hunter)
        //    {
        //        var hunterObj = (Hunter)obj;
        //        Console.WriteLine(hunterObj.Shoot());
        //    }
        //}
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

        //Airplane a = new Airplane(200, 100, "JetsRUs")
        //{
        //    NumPassengers = 150
        //};
        //a.Ascend(500);
        //Console.WriteLine(a.Move(3));
        //Console.WriteLine(a);
        //a.Descend(200);
        //Console.WriteLine(a.Move());
        //a.Move();
        //Console.WriteLine(a);

    }


}
