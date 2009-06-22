#region < References >
using System.Collections.Generic;
using NHibernate.Validator;
using NHibernate.Validator.Constraints;
using SharpArch.Core;
using SharpArch.Core.DomainModel;
using SharpArch.Core.PersistenceSupport;

#endregion

namespace Infoboard.Core
{
    public class Query : Entity
    {
        public Query() { initializeMembers(); }

        public Query(string title, string sqlCommand)
        {
            Title = title;
            Command = sqlCommand;
        }

        [DomainSignature, NotNullNotEmpty(Message = "A title must be provided")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [DomainSignature, NotNullNotEmpty(Message = "A command must be provided")]
        public virtual string Command { get; set; }

        public virtual IList<Chart> Charts { get; protected set; }
        public virtual IList<Column> Columns { get; protected set; }

        private void initializeMembers()
        {
            Charts = new List<Chart>();
            Columns = new List<Column>();
        }
    }
}