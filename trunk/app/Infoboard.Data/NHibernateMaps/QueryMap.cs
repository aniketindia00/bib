#region < References >
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using Infoboard.Core;
#endregion

namespace Infoboard.Data.NHibernateMaps
{
    public class QueryMap : IAutoMappingOverride<Query>
    {
        public void Override(AutoMap<Query> mapping) {
            mapping.Id(x => x.Id)
                .GeneratedBy.Identity();

            mapping.Map(x => x.Title);
            mapping.Map(x => x.Description);
            mapping.Map(x => x.Connection);
            mapping.Map(x => x.Command);

            mapping.HasMany(x => x.Visualizations);
            mapping.HasMany(x => x.Columns);
        }
    }
}