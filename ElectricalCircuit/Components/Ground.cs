namespace ElectricalCircuit.Components;

public class Ground : ElectricalBaseComponent
{
    public override bool IsGround => true;

    protected override float ProcessSpecificVoltage(float voltage)
    {
        return 0.0f;
    }
}