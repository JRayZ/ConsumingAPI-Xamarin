using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsumingAPIXamarin.Services
{
    public class SerializerService : ISerializerService
    {
        public T Deserialize<T>(string payload)
        {
            return JsonSerializer.Deserialize<T>(payload);
        }

        public string Serialize(object data)
        {
            return JsonSerializer.Serialize(data);
        }
    }
}
