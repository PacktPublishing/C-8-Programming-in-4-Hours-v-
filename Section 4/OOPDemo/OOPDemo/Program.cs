using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation
            //Car myCarObject = new Car(1500);
            //myCarObject.Make = "Toyota";
            //myCarObject.Model = "Camry LT";
            //myCarObject.Year = 2018;
            //myCarObject.Color = "Red";

            //myCarObject.Run(65);

            //Console.WriteLine($"My car has make - {myCarObject.Make}, Model - {myCarObject.Model}, Engine - {myCarObject.Engine}");

            //Inheritance

            AutomaticTransmissionCar myAutomaticCarObject = new AutomaticTransmissionCar();
            myAutomaticCarObject.Make = "Toyota";
            myAutomaticCarObject.Model = "Camry XLT";
            myAutomaticCarObject.Year = 2019;
            myAutomaticCarObject.Color = "White";

            myAutomaticCarObject.Run(65);
            myAutomaticCarObject.ChangeGear();
            Console.WriteLine($"My car has make - {myAutomaticCarObject.Make}, Model - {myAutomaticCarObject.Model}");

            //Abstraction

            ManualTransmissionCar myManualCarObject = new ManualTransmissionCar();
            myManualCarObject.Make = "Toyota";
            myManualCarObject.Model = "Camry XLT";
            myManualCarObject.Year = 2019;
            myManualCarObject.Color = "White";

            myManualCarObject.Run(65);
            myManualCarObject.ChangeGear();
            Console.WriteLine($"My car has make - {myManualCarObject.Make}, Model - {myManualCarObject.Model}");

            //Car car = new Car();

            //Polymorphism
            Car car;
            Console.WriteLine("Enter 1 for Automatic Transmission Car and 2 for Manual Transmission car");
            int enteredValue =Convert.ToInt32(Console.ReadLine());

            if (enteredValue == 1)
            {
                car = new AutomaticTransmissionCar();
            }
            else
            {
                car = new ManualTransmissionCar();
            }

            car.ChangeGear();

            IConvertibleCar convertibleCar = new AutomaticTransmissionCar();
            convertibleCar.changeRoofTop();
        }
    }
}
