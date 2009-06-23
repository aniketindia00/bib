#region < References >
using System.Collections.Generic;
using NHibernate.Validator.Constraints;
using SharpArch.Core.DomainModel;
#endregion

namespace Infoboard.Core
{
    public sealed class User : Entity
    {
        public User() {
            InitializeMembers();
           
        }

        public User(string username) : this() {
            Username = username;
        }

        private void InitializeMembers() {
            Charts = new List<Chart>();
            Boards = new List<Board>();
            Rotation = new List<Chart>();
        }

        [DomainSignature, NotNullNotEmpty(Message = "A username must be provided")]
        public string Username { get; set; }

        public IList<Chart> Rotation { get; protected set; }
        public IList<Chart> Charts { get; protected set; }
        public IList<Board> Boards { get; protected set; }


    }
}