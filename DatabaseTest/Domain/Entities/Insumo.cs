namespace DatabaseTest.Domain.Entities;

public class Insumo
{
    public Insumo()
    {
        DNITEquipamento = new();
    }

    public Guid Id { get; set; }
    public DNITEquipamento DNITEquipamento { get; set; }
}