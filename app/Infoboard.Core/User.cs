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
    public class User : Entity
    {
        public User() { initializeMembers(); }
        public User(string username) : this() { Username = username; }

        [DomainSignature, NotNullNotEmpty(Message = "A username must be provided")]
        public virtual string Username { get; set; }

        public virtual IList<Chart> Rotation { get; protected set; }
        public virtual IList<Chart> Charts { get; protected set; }
        public virtual IList<Board> Boards { get; protected set; }

        private void initializeMembers()
        {
            Charts = new List<Chart>();
            Boards = new List<Board>();
        }
    }
}