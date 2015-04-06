using System;
using System.Runtime.Serialization;
using Core.Common.Core;
using Core.Common.Contracts;

namespace ROM.Business.Entities
{
    [DataContract]
    public class Order : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int OrderId { get; set; }
        
        [DataMember]
        public DateTime TimeOrdered { get; set; }

        [DataMember]
        public DateTime TimeReady { get; set; }
        
        [DataMember]
        public DateTime TimeDelivered { get; set; }
        
        [DataMember]
        public string Status { get; set; }
        
        [DataMember]
        public decimal Total { get; set; }


        #region IIdentifiableEntity members

        public int EntityId
        {
            get
            {
                return OrderId;
            }
            set
            {
                OrderId = value;
            }
        }

        #endregion
    }
}
