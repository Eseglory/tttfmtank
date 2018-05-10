using Fill.My.Tank.Common.Contracts;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Fill.My.Tank.Common.Core.Entities
{
    [DataContract]
    public partial class Theme : EntityBase, IIdentifiableEntity
    {
        public Theme()
        {
        }

        /// <summary>
        /// Gets or sets a long value for the ThemeId column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public long ThemeId { get; set; }

        [DataMember]
        [Required]
        public string Code { get; set; }

        [DataMember]
        public bool Active { get; set; }

        #region IIdentifiableEntity members

        public long EntityId
        {
            get { return ThemeId; }
            set { ThemeId = value; }
        }

        #endregion
    }
}
