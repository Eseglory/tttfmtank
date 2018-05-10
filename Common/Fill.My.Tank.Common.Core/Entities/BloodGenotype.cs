using Fill.My.Tank.Common.Contracts;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Fill.My.Tank.Common.Core.Entities
{
    [DataContract]
    public partial class BloodGenotype : EntityBase, IIdentifiableEntity
    {
        public BloodGenotype()
        {
        }

        /// <summary>
        /// Gets or sets a long value for the BloodGenotypeId column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public long BloodGenotypeId { get; set; }

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
            get { return BloodGenotypeId; }
            set { BloodGenotypeId = value; }
        }

        #endregion
    }
}
