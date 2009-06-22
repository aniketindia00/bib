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
    public class ChartRepository : Repository<Chart>, IChartRepository
    {
        public List<Chart> LoadByUser(string username)
        {
            ICriteria queryCriteria = Session.CreateCriteria(typeof (Chart))
                .Add(Restrictions.Eq("Creator", username))
                .SetResultTransformer(new DistinctRootEntityResultTransformer());

            return queryCriteria.List<Chart>() as List<Chart>;
        }

        public List<Chart> LoadByBoard(Board board)
        {
            ICriteria queryCriteria = Session.CreateCriteria(typeof (Chart))
                .Add(Restrictions.Eq("Board", board))
                .SetResultTransformer(new DistinctRootEntityResultTransformer());

            return queryCriteria.List<Chart>() as List<Chart>;
        }
    }
}