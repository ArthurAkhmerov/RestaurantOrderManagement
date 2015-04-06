using Core.Common.Core;

namespace ROM.Business.Entities
{
    public class Table : ObjectBase
    {
        public int TableId { get; set; }

        public int AccountId { get; set; }
        
        public string Status { get; set; }
    }
}
