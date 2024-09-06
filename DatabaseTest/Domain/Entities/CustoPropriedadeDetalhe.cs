namespace DatabaseTest.Domain.Entities;

public class CustoPropriedadeDetalhe
{
    private string formula;

    public CustoPropriedadeDetalhe()
    {
        Valor = 0;
        formula = string.Empty;
    }

    public string Formula {
        get => formula;
        set => formula = value ?? string.Empty;
    }

    public double Valor { get; set; }
}