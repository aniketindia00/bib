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
    public class Board : Entity
    {
        public Board() { InitializeMembers(); }

        public Board(string title, User user) : this()
        {
            Title = title;
            Creator = user;
        }

        [DomainSignature, NotNullNotEmpty(Message = "A title must be provided")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [DomainSignature, NotNull(Message = "A user must be provided")]
        public virtual User Creator { get; protected set; }

        public virtual IList<Chart> Charts { get; protected set; }
        private void InitializeMembers() { Charts = new List<Chart>(); }
    }
}