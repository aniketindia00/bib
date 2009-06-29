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

        public Board(string title) : this()
        {
            Title = title;
        }

        private void InitializeMembers() {
            Visualizations = new List<Visualization>();
            Subscribers = new List<User>();
        }

        [DomainSignature, NotNullNotEmpty(Message = "A title must be provided")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

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