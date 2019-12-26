using System;

namespace OER2.WebApi.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
