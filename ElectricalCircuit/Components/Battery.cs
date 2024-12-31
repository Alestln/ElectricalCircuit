namespace ElectricalCircuit.Components;

public class Battery : ElectricalBaseComponent
{
    public float Voltage { get; }

    public Battery(float voltage)
    {
        Voltage = voltage;
    }
    
    protected override float ProcessSpecificVoltage(float voltage)
    {
        if (IsGround)
        {
            return voltage + Voltage;
        }

        return 0.0f;
    }
}