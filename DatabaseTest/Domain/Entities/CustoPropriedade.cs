namespace DatabaseTest.Domain.Entities;

public class CustoPropriedade
{
    public CustoPropriedade()
    {
        //Depreciacao = new();
        //Juros = new();
        Manutencao = new();
    }
    //public CustoPropriedadeDetalhe Depreciacao { get; set; }
    //public CustoPropriedadeDetalhe Juros { get; set; }
    public CustoPropriedadeDetalhe Manutencao { get; set; }
    public double Total { get; set; }

    
}