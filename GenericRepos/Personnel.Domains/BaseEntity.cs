using System;
namespace Personnel.Domains
{
    public class BaseEntity
    {
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool isActive { get; set; }

        

    }
}