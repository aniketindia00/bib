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

        public Query(string title, string connection, string command)
        {
            Title = title;
            Connection = connection;
            Command = command;
        }

        private void InitializeMembers() {
            Visualizations = new List<Visualization>();
            Columns = new List<Column>();
        }

        [DomainSignature, NotNullNotEmpty(Message = "A title must be provided")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [DomainSignature, NotNullNotEmpty(Message = "A connection must be provided")]
        public virtual string Connection { get; set; }

        [DomainSignature, NotNullNotEmpty(Message = "A query must be provided")]
        public virtual string Command { get; set; }

        public virtual IList<Visualization> Visualizations { get; protected set; }
        public virtual IList<Column> Columns { get; protected set; }
    }
}