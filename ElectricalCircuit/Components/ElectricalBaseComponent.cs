using ElectricalCircuit.Interfaces;

namespace ElectricalCircuit.Components;

public abstract class ElectricalBaseComponent : IComponent
{
    private readonly HashSet<IComponent> _components = [];
    private readonly HashSet<IComponent> _visited = [];

    public IReadOnlySet<IComponent> Components => _components;

    public virtual bool IsGround => CheckIfGround(this);

    private bool CheckIfGround(IComponent component)
    {
        return Components.Any(c => c != component && component.IsGround);
    }
    
    public void AddComponent(IComponent component)
    {
        _components.Add(component);
    }

    public void ProcessVoltage(float voltage)
    {
        if (!_visited.Add(this))
        {
            return;
        }
        
        voltage = ProcessSpecificVoltage(voltage);

        foreach (var component in Components)
        {
            component.ProcessVoltage(voltage);
        }
    }
    
    protected abstract float ProcessSpecificVoltage(float voltage);
}