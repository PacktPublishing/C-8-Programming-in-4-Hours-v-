using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    /// <summary>
    /// AutomaticTransmission Car Inheriting base class CAR
    /// </summary>
    public class AutomaticTransmissionCar : Car, IConvertibleCar
    {
        /// <summary>
        /// Constructor Method
        /// </summary>
        public AutomaticTransmissionCar()
        {
            Console.WriteLine("AutomaticTransmissionCar constructor");
        }        

        /// <summary>
        /// Implemneting/Overriding base class abstrtact method ChangeGear 
        /// </summary>
        public override void ChangeGear()
        {
            Console.WriteLine("Gear changes automatically");
        }

        /// <summary>
        /// Implememnting interface method
        /// </summary>
        /// <returns></returns>
        public bool changeRoofTop()
        {
            Console.WriteLine("Toggled roof in Automatic Car");
            return true;
        }

        //Overriding Base Class Run method
        public override void Run(int speed)
        {
            base.Run(speed);//Calling Base Class Run method implementation.
            Console.WriteLine($"Car is running with Automatic Transmission");
        }


    }
}
