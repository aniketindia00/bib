using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Infoboard.Data.NHibernateMaps.Conventions
{
    public class HasManyToManyConvention : IHasManyToManyConvention
    {
        public bool Accept(IManyToManyPart target) {
            return true;
        }

        public void Apply(IManyToManyPart target) {
            target.WithParentKeyColumn(target.EntityType.Name + "Fk");
            target.WithChildKeyColumn(target.ChildType.Name + "Fk");
            target.Cascade.All();
        }
    }
}
