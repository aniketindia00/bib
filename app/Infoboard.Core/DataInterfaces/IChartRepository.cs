#region < References >
using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport;

#endregion

namespace Infoboard.Core.DataInterfaces
{
    public interface IChartRepository : IRepository<Visualization>
    {
        List<Visualization> LoadByUser(string username);
        List<Visualization> LoadByBoard(Board board);
    }
}