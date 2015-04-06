using System.Runtime.Serialization;
using Core.Common.Core;
using Core.Common.Contracts;

namespace ROM.Business.Entities
{
    [DataContract]
    public class Ingridient : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int IngridientId { get; set; }

        [DataMember]
        public string Name { get; set; }


        #region IIdentifiableEntity members

        public int EntityId
        {
            get
            {
                return IngridientId;
            }
            set
            {
                IngridientId = value;
            }
        }

        #endregion
    }
}
