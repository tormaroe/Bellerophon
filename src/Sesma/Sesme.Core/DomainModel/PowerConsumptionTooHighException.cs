using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sesme.Core.DomainModel
{
    public class PowerConsumptionTooHighException : Exception
    {
        public int ExcessConsumption { get; set; }
    }
}
