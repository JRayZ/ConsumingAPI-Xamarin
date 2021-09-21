using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumingAPIXamarin.Services
{
    public interface ISerializerService
    {
        string Serialize(object data);
        T Deserialize<T>(string payload);
    }
}
