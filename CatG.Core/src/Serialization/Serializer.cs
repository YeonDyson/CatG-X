using CatG.Core.Containers;
using Newtonsoft.Json;

namespace CatG.Core.Serialization;

public static class Serializer {
    public static string Serialize(ContainerCObject obj) {
        throw new NotImplementedException();
    }
    
    public static T Deserialize<T>(string json) where T : ContainerCObject {
        var rootObject = JsonToDictionary(json);
        
        
        throw new NotImplementedException();
    }

    private static Dictionary<object, object> JsonToDictionary(string json) {
        
        throw new NotImplementedException();
    }
}