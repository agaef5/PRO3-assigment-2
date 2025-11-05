namespace SlaughterHouse.Entities;

public class AnimalPart
{
    public int AnimalId { get; set; }
    public int partID  { get; set; }
    public decimal partWeight { get; set; }
    public PartType partType { get; set; }
}