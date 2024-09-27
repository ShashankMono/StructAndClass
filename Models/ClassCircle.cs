using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndClassPOC.Models
{
    //The class is user defined data type which is accessed using object an instance
    // the objects are created in the heap memory and the reference are stored in the stack memory
    // if two objects are same then they will refer to the same object obj1=obj2 
    internal class ClassCircle
    {
        public int Radius { get; set; }
        private readonly double PI = 3.14;

        public double CalculateCircumference()
        {
            return (2 * PI * Radius);
        }
    }
}
