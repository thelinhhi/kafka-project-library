using KafkaProducer.Appplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaProducer.Appplication
{
    public interface IKafkaService
    {
        public Task PushKafka(RequestDto requestDto);
    }
}
