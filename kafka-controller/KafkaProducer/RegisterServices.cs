using AutoMapper;
using KafkaProducer.Appplication;
using KafkaProducer.Domain.Common;
using KafkaProducer.Utils;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaProducer
{
    public static class RegisterServices
    {
        public static IServiceCollection AddMyLibraryServices(this IServiceCollection services)
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var jsonFilePath = Path.Combine(currentDirectory, "libraryconfigs.json");
            var jsonContent = File.ReadAllText(jsonFilePath);
            var config = JsonConvert.DeserializeObject<LibraryConfigs>(jsonContent);

            services.AddSingleton(typeof(LibraryConfigs), config);

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddTransient<IKafkaService, KafkaService>();
            return services;
        }
    }
}
