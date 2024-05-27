using KafkaProducer.Appplication.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaProducer.Appplication.DTOs
{
    public class RequestDto : BaseDto
    {
        public object? Data { get; set; }
    }
}
