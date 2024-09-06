namespace DatabaseTest.Domain.Entities;
public record DNITEquipamento
{
    public DNITEquipamento()
    {
        CustoPropriedade = new();
    }
    public Guid? InsumoImprodutivoId { get; set; }
    public bool NaoUtilizarFormula { get; set; }
    public CustoPropriedade CustoPropriedade { get; set; }
}
