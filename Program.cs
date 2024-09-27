using StructAndClassPOC.Models;

namespace StructAndClassPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassCircle c1 = new ClassCircle();
            c1.Radius = 10;
            Console.WriteLine($"\nI'm Cricle-1 with radius of {c1.Radius} and circumference {c1.CalculateCircumference()} ");

            //Here I'm making a second circle which is identical to first circle
            ClassCircle c2 = c1;
            // I have updated the value of the second circle but if the value of the first circle also gets changed
            // then it will be proved that the classes are referenced type which means 
            // I just assigned the first circle object to the second circle object means the object c2 is now refering
            // object c1 that's why if I try to make any changes in c2 it will be reflected in c1 too.
            c2.Radius = 100;

            Console.WriteLine($"\nI'm Cricle-2 with radius of {c2.Radius} and circumference {c2.CalculateCircumference()} ");
            Console.WriteLine($"\nI'm Cricle-1 with radius of {c1.Radius} and circumference {c1.CalculateCircumference()} ");

            StructureRectangle r1;
            r1.length = 10;
            r1.breadth = 10;
            Console.WriteLine($"\nI'm Rectangle R1 length {r1.length} and breadth {r1.breadth} " +
                $"the area of the R1 is {r1.CalculateArea()}");

            // Here I have assigned the first rectangle r1 to the second rectangle 
            StructureRectangle r2 = r1;
            Console.WriteLine($"\nI'm Rectangle R2 brfore modification length {r2.length} and breadth {r2.breadth} " +
                $"the area of the R2 is {r2.CalculateArea()}");

            // Modified the value of the second rectangle r2 now, if the modification done in r2 will effect the r1
            // then structure is also referenced type but it doesn't happens in structure case
            // But after modification in r2, r1 is not affected which means the sturctures are of value type
            // when a new variable of structure is declared then new memory location is assigned.
            r2.length = 20;
            r2.breadth = 20;
            Console.WriteLine($"\nI'm Rectangle R2 after modification length {r2.length} and breadth {r2.breadth} " +
                $"the area of the R2 is {r2.CalculateArea()}");
            Console.WriteLine($"\nI'm Rectangle R1 length {r1.length} and breadth {r1.breadth} " +
                $"the area of the R1 is {r1.CalculateArea()}");
        }
    }
}
