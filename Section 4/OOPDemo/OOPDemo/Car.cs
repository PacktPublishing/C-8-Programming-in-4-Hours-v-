using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    /// <summary>
    /// Abstract Base class
    /// </summary>
    public abstract class Car
    {
        //Constructor

        public Car()
        {
            Console.WriteLine("Constructor is called.");
        }
        public Car(int enginePower)
        {
            Console.WriteLine("Constructor is called with Parameterised Constructor.");
            _enginePower = enginePower;
        }

        // Access Modifiers - Public, Private
        //private string _make; // Private member, can be accessed within class.        
        //private string _model;
        //private string _color;

        private int _enginePower;

        public int Engine
        {
            get { return _enginePower; }
            set { _enginePower = value; }
        }



        // Encapsulation - Providing access to private members thru Public Properties


        public string Make { get; set; }// Public Property no access restriction.
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        //Virtual Method, can be overridden in child classes.
        public virtual void Run(int speed)
        {
            Console.WriteLine($"Car is running at speed {speed}");
        }

        /// <summary>
        /// Abstrtact Method, should be implemented by child classes.
        /// </summary>
        public abstract void ChangeGear();
    }
}