#region < References >
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using Infoboard.Core;
#endregion

namespace Infoboard.Data.NHibernateMaps
{
    public class ColumnMap : IAutoMappingOverride<Column>
    {
        public void Override(AutoMap<Column> mapping) {
            mapping.Id(x => x.Id)
                .GeneratedBy.Identity();

            mapping.Map(x => x.Name);
            mapping.Map(x => x.Alias);

            mapping.References(x => x.Query);
        }
    }
}