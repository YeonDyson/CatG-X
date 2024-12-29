namespace CatG.Core.Serialization;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property)]
public class NonSerializable: Attribute {
    
}