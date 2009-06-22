#region < References >
using System;
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using FluentNHibernate.Mapping;
using Infoboard.Core;

#endregion

namespace Infoboard.Data.NHibernateMaps
{
    public class BoardMap : IAutoMappingOverride<Board>
    {
        public void Override(AutoMap<Board> mapping) {
            mapping.Id(x => x.Id)
                .WithUnsavedValue(0)
                .GeneratedBy
                .Identity();

            mapping.Map(x => x.Title);
            mapping.Map(x => x.Description);

            mapping.References(x => x.Creator, "UserID");

            mapping.HasManyToMany(x => x.Charts)
                .WithTableName("BoardContent")
                .WithParentKeyColumn("BoardID")
                .WithChildKeyColumn("ChartID")
                .LazyLoad()
                .AsBag();
        }
    }
}