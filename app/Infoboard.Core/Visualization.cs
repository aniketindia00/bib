#region < References >
using System.Collections.Generic;
using NHibernate.Validator.Constraints;
using SharpArch.Core.DomainModel;
#endregion

namespace Infoboard.Core
{
    public class Visualization : Entity
    {
        public Visualization() {
            InitializeMembers();
        }

        public Visualization(Query query, User creator, string title) : this()
        {
            Query = query;
            Creator = creator;
            Title = title;
        }

        private void InitializeMembers() {
            BoardsShownOn = new List<Board>();
            Subscribers = new List<User>();
        }

        [DomainSignature, NotNullNotEmpty(Message = "A title must be provided")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [DomainSignature, NotNull(Message = "A type must be provided")]
        public virtual Type Type { get; set; }

        [DomainSignature, NotNull(Message = "A query must be provided")]
        public virtual Query Query { get; set; }

        [DomainSignature, NotNull(Message = "A user must be provided")]
        public virtual User Creator { get; protected set; }

        public virtual IList<Board> BoardsShownOn { get; private set; }
        public virtual IList<User> Subscribers { get; private set; }

        public virtual void AddToBoard(Board board) {
            board.Visualizations.Add(this);
            BoardsShownOn.Add(board);
        }
    }
}