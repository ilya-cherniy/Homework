using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectOOPOne
{
    class Airplane : IMovable
    {
        public string ObjectName { get; set; }
        public int MaxSpeed { get; set; }

        public void Move()
        {
            Console.WriteLine("Airplane");
        }
    }
}
