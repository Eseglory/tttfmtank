using Fill.My.Tank.Common.Contracts;
using Fill.My.Tank.Framework.Admission;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Fill.My.Tank.Common.Core.Entities
{
    [DataContract]
    public partial class StudentAccount : EntityBase, IIdentifiableEntity
    {
        public StudentAccount()
        {
        }

        /// <summary>
        /// Gets or sets a long value for the UserId column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public long UserId { get; set; }

        [DataMember]
        [Required]
        public string GroupCode { get; set; }

        [DataMember]
        [Required]
        public string Type { get; set; }

        [DataMember]
        [Required]
        public string Code { get; set; }

        [DataMember]
        [Required]
        public string Name { get; set; }

        [DataMember]
        [Required]
        public string Email { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public string LoginID { get; set; }

        [DataMember]
        public string Skype { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public DateTime DOB { get; set; }

        [DataMember]
        public DateTime LastLoginDate { get; set; }

        [DataMember]
        public bool IsLock { get; set; }


        [DataMember]
        public bool Verified { get; set; }

        [DataMember]
        public AdmissionAccountStatusEnum Status { get; set; }

        [DataMember]
        public bool Active { get; set; }

        #region IIdentifiableEntity members

        public long EntityId
        {
            get { return UserId; }
            set { UserId = value; }
        }

        #endregion
    }
}
