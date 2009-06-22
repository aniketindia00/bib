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
    public class Chart : Entity
    {
        public Chart() { initializeMembers(); }

        public Chart(Query query, User creator, string title) : this()
        {
            Query = query;
            Creator = creator;
            Title = title;
        }

        [DomainSignature, NotNullNotEmpty(Message = "A title must be provided")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [DomainSignature, NotNull(Message = "A query must be provided")]
        public virtual Query Query { get; protected set; }

        [DomainSignature, NotNull(Message = "A user must be provided")]
        public virtual User Creator { get; protected set; }

        public virtual IList<Chart> Charts { get; protected set; }
        public virtual IList<User> Subscribers { get; protected set; }
        private void initializeMembers() { Charts = new List<Chart>(); }
    }
}