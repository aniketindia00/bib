#region < References >
using NHibernate.Validator.Constraints;
using SharpArch.Core.DomainModel;
#endregion

namespace Infoboard.Core
{
    public sealed class Column : Entity
    {
        public Column() {
        }

        public Column(string columnName, Query query)
        {
            Name = columnName;
            Query = query;
        }

        [DomainSignature, NotNullNotEmpty(Message = "A name must be provided")]
        public string Name { get; set; }

        public string Alias { get; set; }

        [DomainSignature, NotNull(Message = "A query must be provided")]
        public Query Query { get; protected set; }
    }
}