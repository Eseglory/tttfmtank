using Fill.My.Tank.Common.Contracts;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Fill.My.Tank.Common.Core.Entities
{
    [DataContract]
    public partial class AddressType : EntityBase, IIdentifiableEntity
    {
        public AddressType()
        {
        }

        /// <summary>
        /// Gets or sets a long value for the AddressTypeId column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public long AddressTypeId { get; set; }

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
            get { return AddressTypeId; }
            set { AddressTypeId = value; }
        }

        #endregion
    }
}
