#region < References >
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using Infoboard.Core;
#endregion

namespace Infoboard.Data.NHibernateMaps
{
    public class BoardMap : IAutoMappingOverride<Board>
    {
        public void Override(AutoMap<Board> mapping) {
            mapping.Id(x => x.Id)
                .GeneratedBy.Identity();

            mapping.Map(x => x.Title);
            mapping.Map(x => x.Description);

            mapping.HasManyToMany(x => x.Visualizations)
                .WithTableName("BoardToVisualization");
            
            mapping.HasManyToMany(x => x.Subscribers)
                .Inverse()
                .WithTableName("UserToBoard");
        }
    }
}