using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sesme.Core.DomainModel
{
    [TestFixture]
    public class GameEngine_Spec
    {
        public void Test()
        {
            var engine = new GameEngine
            {
                Ship = new SpaceShip(new[] 
                {
		            new SpaceShipItem("Main Shields", ItemCategory.Shields)
		            {
		                PowerConsumption = 10,
		                State = Power.On,
		            },
		            new SpaceShipItem("Secondery Shields", ItemCategory.Shields)
		            {
		                PowerConsumption = 4,
		                State = Power.Off,
		            },
		        })
                {
                    Battery = new Battery
                    {
                        MaxCharge = 10000,
                        Charge = 1000,
                    },
                    PowerSource = new PowerPlant
                    {
                        Output = 0,
                    }
                },
            };
            int expectedCharge = 1000;

            engine.Tick();
            expectedCharge -= 10;
            engine.Ship.Battery.Charge.ShouldEqual(expectedCharge);

            engine.Ship.Single(item => item.Description == "Secondery Shields").State = Power.On;
            engine.Tick();
            expectedCharge -= 10 + 4;
            engine.Ship.Battery.Charge.ShouldEqual(expectedCharge);

            engine.Ship.PowerSource.Output = 100;
            engine.Tick();
            expectedCharge -= 10 + 4;
            expectedCharge += 100;
            engine.Ship.Battery.Charge.ShouldEqual(expectedCharge);

            engine.Time.ShouldEqual(3);

            
        }
    }
}
