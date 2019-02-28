using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    /// <summary>
    /// ManualTransmission Car Inheriting base class CAR
    /// </summary>
    public class ManualTransmissionCar : Car, IConvertibleCar
    {
        /// <summary>
        /// Implemneting/Overriding base class abstrtact method ChangeGear 
        /// </summary>
        public override void ChangeGear()
        {
            Console.WriteLine("Gear changes Manually");
        }


        /// <summary>
        /// Implememnting interface method
        /// </summary>
        /// <returns></returns>
        public bool changeRoofTop()
        {
            Console.WriteLine("Toggled roof in Manual Car");
            return true;
        }        
    }
}
