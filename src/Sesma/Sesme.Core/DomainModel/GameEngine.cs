using System;
using System.Collections.Generic;
using System.Linq;

namespace Sesme.Core.DomainModel
{
    public class GameEngine
    {
        public UInt32 Time { get; private set; }
        public SpaceShip Ship { get; set; }
        
        public void Tick()
        {
            Time++;
            TickPower();
        }

        private void TickPower()
        {
            var totalConsumption = (from item in Ship
                                    where item.State == Power.On
                                    select item.PowerConsumption).Sum();
            try
            {
                Ship.Battery.Charge += Ship.PowerSource.Output - totalConsumption;
            }
            catch (PowerConsumptionTooHighException ex)
            {
                //TODO: use ex.ExcessConsumption to cause power-failure in some items
            }
        }

    }
}
