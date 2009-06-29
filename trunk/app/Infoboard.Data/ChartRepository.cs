#region < References >
using System.Collections.Generic;
using Infoboard.Core;
using Infoboard.Core.DataInterfaces;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using SharpArch.Data.NHibernate;

#endregion

namespace Infoboard.Data
{
    public class ChartRepository : Repository<Visualization>, IChartRepository
    {
        public List<Visualization> LoadByUser(string username)
        {
            ICriteria queryCriteria = Session.CreateCriteria(typeof (Visualization))
                .Add(Restrictions.Eq("Creator", username))
                .SetResultTransformer(new DistinctRootEntityResultTransformer());

            return queryCriteria.List<Visualization>() as List<Visualization>;
        }

        public List<Visualization> LoadByBoard(Board board)
        {
            ICriteria queryCriteria = Session.CreateCriteria(typeof (Visualization))
                .Add(Restrictions.Eq("Board", board))
                .SetResultTransformer(new DistinctRootEntityResultTransformer());

            return queryCriteria.List<Visualization>() as List<Visualization>;
        }
    }
}