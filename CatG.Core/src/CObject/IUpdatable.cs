namespace CatG.Core.CObject;

public interface IUpdatable {
    public void PreUpdate();
    public void Update();
    public void LateUpdate();
}