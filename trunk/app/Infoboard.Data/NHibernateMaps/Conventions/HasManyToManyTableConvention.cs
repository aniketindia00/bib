using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;

namespace Infoboard.Data.NHibernateMaps.Conventions
{
    public class HasManyToManyTableConvention : IHasManyToManyConvention
    {
        public bool Accept(IManyToManyPart target) {
            return true;
        }

        public void Apply(IManyToManyPart target) {
            target.WithTableName(target.ChildType.Name);
        }
    }
}
