namespace SlaughterHouse.Entities;

public class Tray
{
    public int TrayId { get; set; }
    public PartType partType { get; set; }
    public decimal maxCapacity { get; set; }
    public decimal currentWeight { get; set; }

    public Tray(int trayId, PartType partType, int maxCapacity)
    {
        TrayId = trayId;
        this.partType = partType;
        this.maxCapacity = maxCapacity;
    }
}