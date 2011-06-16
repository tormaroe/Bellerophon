using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Diagnostics.Contracts;

namespace Sesme.Core.DomainModel
{
    public class SpaceShipItem : DynamicObject
    {
        private Dictionary<string, object> _properties = new Dictionary<string, object>();

        public SpaceShipItem(string description, ItemCategory category, params object[] args)
        {
            Contract.Requires(args.Length % 2 == 0, 
                "args must be even, containing pairs of property names and values.");

            Id = Guid.NewGuid();
            Description = description;
            Category = category;

            for (int i = 0; i < args.Length; i += 2)
                _properties[args[i].ToString()] = args[i + 1];
        }         

        public Guid Id { get; private set; }
        public ItemCategory Category { get; private set; }
        public string Description { get; private set; }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (!_properties.ContainsKey(binder.Name))
            {
                result = null;
                return false;
            }

            result = _properties[binder.Name];
            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _properties[binder.Name] = value;
            return true;
        }
    }
}