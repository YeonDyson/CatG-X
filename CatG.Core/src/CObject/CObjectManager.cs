using CatG.Core.Utils;

namespace CatG.Core.CObject;

internal class CObjectManager: Singleton<CObjectManager> {
    private List<Type> _cObjectTypes = [];

    public CObjectManager() {
        CachingCObjects();
    }

    private void CachingCObjects() {
        _cObjectTypes.AddRange(
            AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => type.IsSubclassOf(typeof(CObject)))
        );
        
        Console.WriteLine(string.Join(", ", _cObjectTypes.Select(type => type.FullName)));
    }

    public bool IsCObject(string cObjectPath) {
        return _cObjectTypes.Any(type => type.FullName == cObjectPath);;
    }
    
    public static T Instantiate<T>() where T : CObject, new() {
        return null;
    }
}