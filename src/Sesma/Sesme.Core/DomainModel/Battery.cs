using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sesme.Core.DomainModel
{
    public class Battery
    {
        private int _Charge;
        public int Charge
        {
            get
            {
                return _Charge;
            }
            set
            {
                if (0 > _Charge || _Charge > MaxCharge)
                    throw new ArgumentOutOfRangeException(
                        "Charge must not be lower then zero or higher than max charge.");
                _Charge = value;
            }
        }
        public int MaxCharge { get; set; }
    }
}
