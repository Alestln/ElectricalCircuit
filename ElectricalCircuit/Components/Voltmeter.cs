namespace ElectricalCircuit.Components;

public class Voltmeter : ElectricalBaseComponent
{
    private float _measuredVoltage = 0.0f;
    
    public void MeasureVoltage()
    {
        Console.WriteLine($"Measured Voltage: {_measuredVoltage} V");
    }
    
    protected override float ProcessSpecificVoltage(float voltage)
    {
        _measuredVoltage = voltage;
        return voltage;
    }
}