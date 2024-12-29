namespace CatG.Core.CObject;

public abstract class CObject {
    private bool _enabled;

    public Guid Id { get; } = Guid.NewGuid();
    public bool Enabled {
        get {
            return _enabled;
        }
        set {
            if (_enabled == value) return;
            
            _enabled = value;
            if (_enabled) {
                OnEnable();
            } else {
                OnDisable();
            }
        }
    }

    protected abstract void OnEnable();
    protected abstract void OnDisable();
    virtual public void OnStart() {}
    virtual public void OnCreate() {}
    virtual public void OnDestroy() {}

    public static T Instantiate<T>() where T : CObject, new() {
        return CObjectManager.Instantiate<T>();
    }
}