using CatG.Core.Utils;

namespace CatG.Core.CObject;

internal class CObjectManager: Singleton<CObjectManager> {
    
    
    public static T Instantiate<T>() where T : CObject, new() {
        return null;
    }
}