using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaProducer.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string? Source { get; set; }
        public string? Destination { get; set; } 
        public string? Request { get;set; }
        public string? Method { get; set; }
        public string? Type { get; set; }
        public int Status { get; set; }
        public string? Message { get; set; }
        public DateTime? CreateDate { get; set; }
    }

    

}
