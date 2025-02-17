using CatG.Core.CObject;
using CatG.Core.Containers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CatG.Core.Serialization;

public static class Serializer {
    public static string Serialize(ContainerCObject obj) {
        throw new NotImplementedException();
    }
    
    public static T Deserialize<T>(string json) where T : ContainerCObject {
        var rootObject = JsonConvert.DeserializeObject<JObject>(json)
            ?? throw new JsonException("Invalid JSON format.");

        var metaKeys = rootObject["$types"]?.ToObject<Dictionary<string, string>>()
            ?? throw new JsonException("Invalid or missing '$types' key.");
        
        rootObject.Remove("$types");

        var rootKey = rootObject.Properties().First().Name;
        if (!CObjectManager.Instance.IsCObject(metaKeys[rootKey])) {
            throw new InvalidOperationException($"The key '{rootKey}' is not a valid CObject.");
        }
        
        DeserializeCObject(metaKeys, rootObject);
        
        throw new NotImplementedException();
    }

    private static CObject.CObject DeserializeCObject(Dictionary<string, string> metaKeys, JObject rootObject) {
        if (!CObjectManager.Instance.IsCObject(rootObject.Properties().First().Name)) {
            throw new InvalidOperationException($"The key '{rootObject.Properties().First().Name}' is not a valid CObject. 좆까!");
        }
        
        foreach (var (key, value) in rootObject) {
             
        }

        throw new NotImplementedException();
    }

    private static object DeserializeNonCObject() {
        
        throw new NotImplementedException();
    }
}