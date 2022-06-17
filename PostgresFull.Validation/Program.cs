using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgresFull.Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var ret = context.Person.Select(x => x).ToList();
                Console.WriteLine(ret.FirstOrDefault()?.name);
            }
        }
    }
}
