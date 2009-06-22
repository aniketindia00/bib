#region < References >
using System;
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using FluentNHibernate.Mapping;
using Infoboard.Core;

#endregion

namespace Infoboard.Data.NHibernateMaps
{
    public class QueryMap : IAutoMappingOverride<Query>
    {
        public void Override(AutoMap<Query> mapping) {
            mapping.Id(x => x.Id)
                .WithUnsavedValue(0)
                .GeneratedBy
                .Identity();

            mapping.Map(x => x.Title);
            mapping.Map(x => x.Description);
            mapping.Map(x => x.Command);

            mapping.HasMany(x => x.Charts)
                .Inverse()
                .KeyColumnNames.Add("QueryID")
                .LazyLoad()
                .AsBag();

            mapping.HasMany(x => x.Columns)
                .Inverse()
                .KeyColumnNames.Add("QueryID")
                .LazyLoad()
                .AsBag();
        }
    }
}