using AutoMapper;
using Confluent.Kafka;
using KafkaProducer.Appplication.DTOs;
using KafkaProducer.Domain;
using KafkaProducer.Domain.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaProducer.Appplication
{
    public class KafkaService: IKafkaService
    {
        private readonly LibraryConfigs _libraryConfig;
        private readonly IMapper _mapper;
        public KafkaService(IMapper mapper, LibraryConfigs appConfig) {
            _mapper = mapper;
            _libraryConfig = appConfig;
        }

        public async Task PushKafka(RequestDto requestDto)
        {
            try
            {
                var config = new ProducerConfig
                {
                    BootstrapServers = _libraryConfig.kafkaConfigs.BootstrapServers,
                    SecurityProtocol = SecurityProtocol.SaslPlaintext,
                    SaslMechanism = SaslMechanism.Plain,
                    SaslUsername = _libraryConfig.kafkaConfigs.Username,
                    SaslPassword = _libraryConfig.kafkaConfigs.Password,
                };

                using (var producer = new ProducerBuilder<Null, string>(config).Build())
                {
                    var request = _mapper.Map<Request>(requestDto);
                    //await producer.ProduceAsync(_libraryConfig.Topic, new Message<Null, string> { Value = JsonConvert.SerializeObject(request) });

                    Console.WriteLine("PushKafkaForSendMail");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //throw ex;
            }
        }

    }
}
