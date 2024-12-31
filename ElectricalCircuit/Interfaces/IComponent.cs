namespace ElectricalCircuit.Interfaces;

public interface IComponent
{
    IReadOnlySet<IComponent> Components { get; }
    
    bool IsGround { get; }
    
    void AddComponent(IComponent component);
    
    void ProcessVoltage(float voltage);
}