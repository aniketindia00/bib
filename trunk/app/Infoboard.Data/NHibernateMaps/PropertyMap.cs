using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using Infoboard.Core;

namespace Infoboard.Data.NHibernateMaps
{
    public class PropertyMap : IAutoMappingOverride<Property>
    {
        public void Override(AutoMap<Property> mapping) {
            mapping.Id(x => x.Id)
                .GeneratedBy.Identity();

            mapping.Map(x => x.Name);

            mapping.References(x => x.Type);
        }
    }
}
