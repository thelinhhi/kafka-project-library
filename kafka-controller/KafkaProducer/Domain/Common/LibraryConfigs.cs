using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaProducer.Domain.Common
{
    public class LibraryConfigs
    {
        public KafkaConfigs kafkaConfigs { get; set; }
    }

    public class KafkaConfigs
    {
        public bool IsActive { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? BootstrapServers { get; set; }
        public string? Topic { get; set; }
        public string? GroupId { get; set; }
    }
}
