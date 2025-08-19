using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_c__EF_01.Data.Models
{ // poco class => plain old CLR object
    // we have 4 ways to map classes
    //1-By convention=> if the class name is same as table name=> default mapping
    internal class employ
    {
        public int id { get; set; }
        public string Empname { get; set; } // converts to nvarchar(max) by default
        // .net 5 : reference type allow null [optional]
        // .net 6 : reference type not allow null [required]
        public double salary { get; set; }// decimal type (18 number then ,2)
        public int age { get; set; } // nullable type

    }
}
