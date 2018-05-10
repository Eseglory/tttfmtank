using Fill.My.Tank.Common.Contracts;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Fill.My.Tank.Common.Core.Entities
{
    [DataContract]
    public partial class FamilyType : EntityBase, IIdentifiableEntity
    {
        public FamilyType()
        {
        }

        /// <summary>
        /// Gets or sets a long value for the FamilyTypeId column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public long FamilyTypeId { get; set; }

        [DataMember]
        [Required]
        public string Name { get; set; }

        [DataMember]
       
        public string Description { get; set; }

        [DataMember]
        public bool Active { get; set; }

        #region IIdentifiableEntity members

        public long EntityId
        {
            get { return FamilyTypeId; }
            set { FamilyTypeId = value; }
        }

        #endregion
    }
}
