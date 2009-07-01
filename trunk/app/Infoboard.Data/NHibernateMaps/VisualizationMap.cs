#region < References >
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using Infoboard.Core;
#endregion

namespace Infoboard.Data.NHibernateMaps
{
    public class VisualizationMap : IAutoMappingOverride<Visualization>
    {
        public void Override(AutoMap<Visualization> mapping) {
            mapping.Id(x => x.Id)
                .GeneratedBy.Identity();

            mapping.Map(x => x.Title);
            mapping.Map(x => x.Description);

            mapping.References(x => x.Query);

            mapping.HasManyToMany(x => x.BoardsShownOn)
                .Inverse()
                .WithTableName("BoardToVisualization");
        }
    }
}