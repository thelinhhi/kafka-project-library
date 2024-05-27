using KafkaProducer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KafkaProducer.Utils
{
    public static class ConvertFunction
    {
        public static List<NameTypeValueModel> ConvertObjectToNameTypeValueModel(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            var result = new List<NameTypeValueModel>();
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (var property in properties)
            {
                var nameTypeValue = new NameTypeValueModel
                {
                    Name = property.Name,
                    Value = property.GetValue(obj)?.ToString(),
                    Type = property.PropertyType.Name
                };
                result.Add(nameTypeValue);
            }

            return result;
        }
    }
}
