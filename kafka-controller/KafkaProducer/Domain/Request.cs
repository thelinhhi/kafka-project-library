using KafkaProducer.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaProducer.Domain
{
    public class Request: BaseEntity
    {
        public List<NameTypeValueModel> Params { get; set; } = new List<NameTypeValueModel>();
        //public List<NameTypeValueModel> Result { get; set; }
    }

    public class NameTypeValueModel
    {
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Type { get; set; }
    }
}
