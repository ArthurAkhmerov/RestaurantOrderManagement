using System.Runtime.Serialization;
using Core.Common.Core;
using Core.Common.Contracts;

namespace ROM.Business.Entities
{
    [DataContract]
    public class Table : EntityBase, IIdentifiableEntity, IAccountOwnedEntity
    {
        [DataMember]
        public int TableId { get; set; }

        [DataMember]
        public int AccountId { get; set; }
        
        [DataMember]
        public string Status { get; set; }

        #region IIdentifiableEntity members

        public int EntityId
        {
            get
            {
                return TableId;
            }
            set
            {
                TableId = value;
            }
        }

        #endregion


        #region IAccountOwnedIdentity members
        
        public int OwnerAccountId
        {
            get { return AccountId; }
        }

        #endregion
    }
}
