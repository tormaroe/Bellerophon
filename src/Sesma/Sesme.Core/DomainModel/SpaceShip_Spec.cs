using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sesme.Core.DomainModel
{
    [TestFixture]
    public class SpaceShip_Spec : IObserver<SpaceShipItem>
    {
        [Test]
        public void set_current_item__must_notify_observer()
        {
            SpaceShipItem 
                item1 = new SpaceShipItem("A", ItemCategory.Misc),
                item2 = new SpaceShipItem("B", ItemCategory.Misc),
                item3 = new SpaceShipItem("C", ItemCategory.Misc);

            var ship = new SpaceShip(new[] { item1, item2, item3 });
            ship.Subscribe(this);

            ship.CurrentItem = item2;
            most_recently_observed_item.ShouldBeSameAs(item2);
        }

        #region IObserver<SpaceShipItem> Members

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        private SpaceShipItem most_recently_observed_item;

        public void OnNext(SpaceShipItem value)
        {
            most_recently_observed_item = value;
        }

        #endregion
    }
}
