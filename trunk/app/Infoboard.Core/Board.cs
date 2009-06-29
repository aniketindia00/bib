#region < References >
using System.Collections.Generic;
using NHibernate.Validator.Constraints;
using SharpArch.Core.DomainModel;
#endregion

namespace Infoboard.Core
{
    public class Board : Entity
    {
        public Board() {
            InitializeMembers();
        }

        public Board(string title, User user) : this()
        {
            Title = title;
            Creator = user;
        }

        private void InitializeMembers() {
            Visualizations = new List<Visualization>();
            Subscribers = new List<User>();
        }

        [DomainSignature, NotNullNotEmpty(Message = "A title must be provided")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [DomainSignature, NotNull(Message = "A user must be provided")]
        public virtual User Creator { get; private set; }

        public virtual IList<Visualization> Visualizations { get; private set; }
        public virtual IList<User> Subscribers { get; private set; }

        public virtual void AddVisualization(Visualization visualization) {
            visualization.BoardsShownOn.Add(this);
            Visualizations.Add(visualization);
        }

        public virtual void AddSubscriber(User user) {
            user.Boards.Add(this);
            Subscribers.Add(user);
        }
    }
}