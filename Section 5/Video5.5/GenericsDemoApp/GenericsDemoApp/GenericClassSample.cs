using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemoApp
{
    public class GenericClassSample<T>
    {
        public void Print(T param)
        {
            Console.WriteLine($"Parameter :{param}");
        }
    }
}
