using SlaughterHouse.Entities;

namespace SlaughterHouse.Services;

public class TrayService
{
    private List<AnimalPart> _trayContents = new();
    public void AddPart(AnimalPart part, Tray tray)
    {
        if (part.partType != tray.partType)
        {
            Console.WriteLine("Type mismatch");
        }

        if (part.partWeight + tray.currentWeight > tray.maxCapacity)
        {
            Console.WriteLine("Capacity exceeded");
        }
    }
    
    
    public bool ContainsPart(int partID)
    {
        return _trayContents.Any(c => c.partID == partID);
    }
}