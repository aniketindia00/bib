#region < References >
using System.Collections.Generic;
using NHibernate.Validator.Constraints;
using SharpArch.Core.DomainModel;
#endregion

namespace Infoboard.Core
{
    public class Query : Entity
    {
        public Query() {
            InitializeMembers();
        }

        public Query(string title, string sqlCommand)
        {
            Title = title;
            Command = sqlCommand;
        }

        private void InitializeMembers() {
            Charts = new List<Chart>();
            Columns = new List<Column>();
        }

        [DomainSignature, NotNullNotEmpty(Message = "A title must be provided")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [DomainSignature, NotNullNotEmpty(Message = "A command must be provided")]
        public virtual string Command { get; set; }

        public virtual IList<Chart> Charts { get; protected set; }
        public virtual IList<Column> Columns { get; protected set; }
    }
}