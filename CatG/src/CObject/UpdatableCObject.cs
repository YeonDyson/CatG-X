namespace CatG.Core.CObject;

public abstract class UpdatableCObject: CObject {
    public abstract void PreUpdate();
    public abstract void Update();
    public abstract void LateUpdate();
}