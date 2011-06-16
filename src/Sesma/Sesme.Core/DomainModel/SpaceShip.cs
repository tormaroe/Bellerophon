using System;
using System.Collections.Generic;

namespace Sesme.Core.DomainModel
{
    public class SpaceShip : List<SpaceShipItem>, IObservable<SpaceShipItem>
    {
        public static SpaceShip Create()
        {
            return new SpaceShip(new[]
            {
                new SpaceShipItem("Dorsal torpedo", ItemCategory.Armament),
            });
        }

        private List<IObserver<SpaceShipItem>> _observers = new List<IObserver<SpaceShipItem>>();

        public SpaceShip(IEnumerable<SpaceShipItem> items) : base(items) { }
        
        // Possibly move the CurrentItem / Subscribe stuff to an application service

        private SpaceShipItem _currentItem;
        public SpaceShipItem CurrentItem
        {
            get
            {
                return _currentItem;
            }
            set
            {
                _currentItem = value;
                _observers.ForEach(o => o.OnNext(value));
            }
        }
        
        public IDisposable Subscribe(IObserver<SpaceShipItem> observer)
        {
            _observers.Add(observer);
            return (IDisposable)null; // TODO: return a real, usable object..
        }
    }
}