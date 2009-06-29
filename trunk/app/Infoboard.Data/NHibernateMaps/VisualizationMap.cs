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
            mapping.Id(x => x.Id, "ChartId")
                .WithUnsavedValue(0)
                .GeneratedBy
                .Identity();

            mapping.Map(x => x.Title);
            mapping.Map(x => x.Description);

            mapping.References(x => x.Creator);
            mapping.References(x => x.Query);

            mapping.HasManyToMany(x => x.BoardsShownOn)
                .Cascade.All()
                .Inverse()
                .WithTableName("BoardToVisualization");

            mapping.HasManyToMany(x => x.Subscribers)
                .Cascade.All()
                .Inverse()
                .WithTableName("UserToVisualization");
        }
    }
}