namespace CatG.Core.CObject;

public abstract class UpdatableCObject: CObject, IUpdatable {
    virtual public void PreUpdate() {}
    virtual public void Update() {}
    virtual public void LateUpdate() {}
}