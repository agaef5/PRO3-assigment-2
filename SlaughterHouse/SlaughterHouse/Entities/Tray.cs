namespace SlaughterHouse.Entities;

public class Tray
{
    public int TrayId { get; set; }
    public int partType { get; set; }
    public int maxCapacity { get; set; }
    public int currentWeight { get; set; }

    public Tray(int trayId, int partType, int maxCapacity)
    {
        TrayId = trayId;
        this.partType = partType;
        this.maxCapacity = maxCapacity;
    }
}