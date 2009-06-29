using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using Type = Infoboard.Core.Type;

namespace Infoboard.Data.NHibernateMaps
{
    public class TypeMap : IAutoMappingOverride<Type>
    {
        public void Override(AutoMap<Type> mapping) {
            mapping.Id(x => x.Id)
                .WithUnsavedValue(0)
                .GeneratedBy.Identity();

            mapping.Map(x => x.Name);

            mapping.HasMany(x => x.VisualizationsUsedOn);
            mapping.HasMany(x => x.Properties);
        }
    }
}
