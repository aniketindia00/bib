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
        public string Title { get; set; }

        public string Description { get; set; }

        [DomainSignature, NotNull(Message = "A query must be provided")]
        public Query Query { get; protected set; }

        [DomainSignature, NotNull(Message = "A user must be provided")]
        public User Creator { get; protected set; }

        public IList<Chart> Charts { get; protected set; }
        public IList<User> Subscribers { get; protected set; }

        
    }
}