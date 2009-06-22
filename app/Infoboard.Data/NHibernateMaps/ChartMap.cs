#region < References >
using System;
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using FluentNHibernate.Mapping;
using Infoboard.Core;

#endregion

namespace Infoboard.Data.NHibernateMaps
{
    public class ChartMap : IAutoMappingOverride<Chart>
    {
        public void Override(AutoMap<Chart> mapping) {
            mapping.Id(x => x.Id, "ChartId")
                .WithUnsavedValue(0)
                .GeneratedBy
                .Identity();

            mapping.Map(x => x.Title);
            mapping.Map(x => x.Description);

            mapping.References(x => x.Creator, "UserId")
                .SetAttribute("not-null", "true");

            mapping.References(x => x.Query, "QueryId")
                .SetAttribute("not-null", "true");

            mapping.HasManyToMany<Board>(x => x.Charts)
                .WithTableName("BoardContent")
                .Inverse()
                .WithParentKeyColumn("ChartID")
                .WithChildKeyColumn("BoardID")
                .LazyLoad()
                .AsBag();

            mapping.HasManyToMany(x => x.Subscribers)
                .WithTableName("Rotations")
                .WithParentKeyColumn("ChartID")
                .WithChildKeyColumn("UserID")
                .LazyLoad()
                .AsBag();
        }
    }
}