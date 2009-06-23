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
            Charts = new List<Chart>();
        }

        [DomainSignature, NotNullNotEmpty(Message = "A title must be provided")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [DomainSignature, NotNull(Message = "A user must be provided")]
        public virtual User Creator { get; protected set; }

        public virtual IList<Chart> Charts { get; protected set; }
        
    }
}