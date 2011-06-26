using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sesme.Core.DomainModel
{
    public class Battery
    {
        private int _Charge;

        /// <summary>
        /// Gets or sets current charge. 
        /// If new value is higher than MaxCharge, MaxCharge will become the current value.
        /// If new value is below zero, the new charge will be zero, and a 
        /// PowerConsumptionTooHighException will be thrown.
        /// </summary>
        public int Charge
        {
            get
            {
                return _Charge;
            }
            set
            {
                if (value > MaxCharge)
                    _Charge = MaxCharge;
                else
                {
                    if (value < 0)
                    {
                        _Charge = 0;
                        throw new PowerConsumptionTooHighException { ExcessConsumption = value * -1 };
                    }
                    _Charge = value;
                }
            }
        }
        public int MaxCharge { get; set; }
    }
}
