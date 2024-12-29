namespace CatG.Core.CObject;

public class GameCObject: UpdatableCObject {
    private List<CScript> _cObjectList = [];

    public string Name;
    public List<string> Tag = [];
    public int Layer;
    
    public Level.Level Level { get; }

    protected override void OnEnable() {
        
    }
    
    protected override void OnDisable() {
        
    }
}