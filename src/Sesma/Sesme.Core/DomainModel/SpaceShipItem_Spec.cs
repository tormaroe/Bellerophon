using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sesme.Core.DomainModel
{
    [TestFixture]
    public class SpaceShipItem_Spec
    {
        [Test]
        public void accept_random_properties()
        {
            dynamic item = new SpaceShipItem("Thingamabat", ItemCategory.Misc);
            item.Foo = "foo";
            item.Bar = 123;
            Assert.AreEqual("foo", item.Foo);
            Assert.AreEqual(123, item.Bar);
        }

        [Test]
        public void construct_with_properties()
        {
            dynamic item = new SpaceShipItem("Zoidbiip", ItemCategory.Misc, 
                "Prop1", 123, 
                "Prop2", DateTime.Now);
            Assert.AreEqual(123, item.Prop1);
            Assert.IsInstanceOfType(typeof(DateTime), item.Prop2);
        }


    }
}
