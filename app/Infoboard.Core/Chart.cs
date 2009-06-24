#region < References >
using System.Collections.Generic;
using NHibernate.Validator.Constraints;
using SharpArch.Core.DomainModel;
#endregion

namespace Infoboard.Core
{
    public class Chart : Entity
    {
        public Chart() {
            InitializeMembers();
        }

        public Chart(Query query, User creator, string title) : this()
        {
            Query = query;
            Creator = creator;
            Title = title;
        }

        private void InitializeMembers() {
            Charts = new List<Chart>();
            Subscribers = new List<User>();
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

        
    }
}