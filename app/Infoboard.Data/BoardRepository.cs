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
    public class BoardRepository : Repository<Board>, IBoardRepository
    {
        public List<Board> LoadByUser(string username)
        {
            ICriteria queryCriteria = Session.CreateCriteria(typeof (Board))
                .CreateAlias("Creator", "user")
                .Add(Restrictions.Eq("user.Username", username))
                .SetResultTransformer(new DistinctRootEntityResultTransformer());

            return queryCriteria.List<Board>() as List<Board>;
        }

        public List<Board> LoadByQuery(Query query)
        {
            ICriteria queryCriteria = Session.CreateCriteria(typeof (Board))
                .Add(Restrictions.Eq("Query", query))
                .SetResultTransformer(new DistinctRootEntityResultTransformer());

            return queryCriteria.List<Board>() as List<Board>;
        }
    }
}