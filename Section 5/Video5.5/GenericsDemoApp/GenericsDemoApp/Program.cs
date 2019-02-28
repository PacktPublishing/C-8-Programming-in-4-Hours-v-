using System;
using System.Collections.Generic;

namespace GenericsDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics
            //Syntax <T> , T is the type parameter

            GenericClassSample<int> intGenericObject = new GenericClassSample<int>();
            intGenericObject.Print(10);

            GenericClassSample<string> strGenericObject = new GenericClassSample<string>();
            strGenericObject.Print("Test");

            // Important Generic Collection
            // List<T> --> Preferred over Arrays(no length restriction)

            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);

            //intList[1] : For retrieving a value;
        }
    }
}
