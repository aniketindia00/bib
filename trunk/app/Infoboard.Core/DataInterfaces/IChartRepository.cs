#region < References >
using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport;

#endregion

namespace Infoboard.Core.DataInterfaces
{
    public interface IChartRepository : IRepository<Chart>
    {
        List<Chart> LoadByUser(string username);
        List<Chart> LoadByBoard(Board board);
    }
}