using ElectricalCircuit.Components;

namespace ElectricalCircuit;

class Program
{
    static void Main(string[] args)
    {
        var battery = new Battery(5);
        var battery2 = new Battery(5);
        var voltmeter = new Voltmeter();
        var ground = new Ground();
        
        battery.AddComponent(battery2);
        battery2.AddComponent(voltmeter);
        voltmeter.AddComponent(battery);
        //ground.AddComponent(battery);
        
        battery.ProcessVoltage(0);
        
        voltmeter.MeasureVoltage();
    }
}