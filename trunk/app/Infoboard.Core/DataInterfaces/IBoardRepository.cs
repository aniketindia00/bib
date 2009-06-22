#region < References >
using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport;

#endregion

namespace Infoboard.Core.DataInterfaces
{
    public interface IBoardRepository : IRepository<Board>
    {
        List<Board> LoadByUser(string username);
        List<Board> LoadByQuery(Query query);
    }
}