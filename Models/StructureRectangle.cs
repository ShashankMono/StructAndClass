using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndClassPOC.Models
{
    // struecture are of value type in which we can create variables with different data and it can be used
    // used by creating variable with refrence to structure 
    // if s1=s2 the new memory location is allocated .
    public struct StructureRectangle
    {
        public int length;
        public int breadth;
        
        public int CalculateArea()
        {
            return length * breadth;
        }

    }
}
