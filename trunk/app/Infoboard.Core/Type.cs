using System.Collections.Generic;
using NHibernate.Validator.Constraints;
using SharpArch.Core.DomainModel;

namespace Infoboard.Core
{
    public class Type : Entity
    {
        public Type() {
            
        }

        public Type(string name) : this() {
            Name = name;
        }

        [DomainSignature, NotNullNotEmpty(Message = "A name must be specified")]
        public virtual string Name { get; set; }

        public virtual IList<Visualization> VisualizationsUsedOn { get; private set; }
        public virtual IList<Property> Properties { get; private set; }

        public virtual void AddVisualization(Visualization visualization) {
            visualization.Type = this;
            VisualizationsUsedOn.Add(visualization);
        }

        public virtual void AddProperty(Property property) {
            property.Type = this;
            Properties.Add(property);
        }
    }
}
