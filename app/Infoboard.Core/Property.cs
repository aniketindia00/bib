using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpArch.Core.DomainModel;

namespace Infoboard.Core
{
    public class Property : Entity
    {
        public Property() {
            
        }

        public Property(string propertyName) {
            Name = propertyName;
        }

        public virtual string Name { get; set; }

        public virtual Type Type { get; set; }
    }
}
