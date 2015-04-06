using System.Runtime.Serialization;
using Core.Common.Core;
using Core.Common.Contracts;

namespace ROM.Business.Entities
{
    [DataContract]
    public class Food : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int FoodId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public string Type { get; set; }


        #region IIdentifiableEntity members

        public int EntityId
        {
            get
            {
                return FoodId;
            }
            set
            {
                FoodId = value;
            }
        }

        #endregion
    }
}
