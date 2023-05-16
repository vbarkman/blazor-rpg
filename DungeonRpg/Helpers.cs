using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;

namespace DungeonRpg
{
    public static class Helpers
    {
        public static T DeepClone<T>(T obj)
        {
            var json = JsonSerializer.Serialize(obj);

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
