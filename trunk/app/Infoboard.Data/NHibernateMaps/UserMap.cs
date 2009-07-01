#region < References >
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using Infoboard.Core;
#endregion

namespace Infoboard.Data.NHibernateMaps
{
    public class UserMap : IAutoMappingOverride<User>
    {
        public void Override(AutoMap<User> mapping) {
            mapping.Id(x => x.Id)
                .GeneratedBy.Identity();

            mapping.Map(x => x.Initials);

            mapping.HasManyToMany(x => x.Boards)
                .WithTableName("UserToBoard");
        }
    }
}