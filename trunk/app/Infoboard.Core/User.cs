#region < References >
using System.Collections.Generic;
using NHibernate.Validator.Constraints;
using SharpArch.Core.DomainModel;
#endregion

namespace Infoboard.Core
{
    public class User : Entity
    {
        public User() {
            InitializeMembers();
        }

        public User(string username) : this() {
            Initials = username;
        }

        private void InitializeMembers() {
            Boards = new List<Board>();
            //Rotation = new List<Visualization>();
        }

        [DomainSignature, NotNullNotEmpty(Message = "A username must be provided")]
        public virtual string Initials { get; set; }

        //public virtual IList<Visualization> Rotation { get; protected set; }
        public virtual IList<Board> Boards { get; private set; }

        public virtual void AddSubscription(Board board) {
            board.Subscribers.Add(this);
            Boards.Add(board);
        }
    }
}
