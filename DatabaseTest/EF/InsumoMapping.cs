using DatabaseTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseTest.EF;

public class InsumoMapping : IEntityTypeConfiguration<Insumo>
{
    private const string NomeTabela = "INSUMOS";
    public void Configure(EntityTypeBuilder<Insumo> builder)
    {
                
        builder.ToTable(NomeTabela);
        builder.OwnsOne(
            a => a.DNITEquipamento, 
            dnit =>
            {
                dnit.ToTable(NomeTabela);
                dnit.Property(x => x.InsumoImprodutivoId)
                    .HasColumnName("INSUMOIMPRODUTIVOID");
                dnit.Property(x => x.NaoUtilizarFormula)
                    .HasColumnName("NAOUTILIZARFORMULA");

                dnit.OwnsOne(
                    x => x.CustoPropriedade,
                    custoPropriedade =>
                    {
                        custoPropriedade.ToTable(NomeTabela);

                        custoPropriedade.Property(cp => cp.Total)
                            .HasColumnName("DNITCPTOTAL");
                        /*
                        custoPropriedade.OwnsOne(
                            cp => cp.Depreciacao,
                            cpBuild =>
                            {
                                cpBuild.ToTable(NomeTabela);
                                cpBuild.Property(x => x.Formula)
                                    .HasColumnName("DNITCPDEPREFORM")
                                    .HasMaxLength(50);
                                cpBuild.Property(x => x.Valor)
                                    .HasColumnName("DNITCPDEPREVALOR");
                            });
                        * /
                        custoPropriedade.OwnsOne(
                            cp => cp.Juros,
                            cpBuild =>
                            {
                                cpBuild.ToTable(NomeTabela);
                                cpBuild.Property(x => x.Formula)
                                    .HasColumnName("DNITCPJUROSFORM")
                                    .HasMaxLength(50);
                                cpBuild.Property(x => x.Valor)
                                    .HasColumnName("DNITCPJUROSVALOR");
                            });
                        */
                        custoPropriedade.OwnsOne(
                            cp => cp.Manutencao,
                            cpBuild =>
                            {
                                cpBuild.ToTable(NomeTabela);
                                cpBuild.Property(x => x.Formula)
                                    .HasColumnName("DNITCPMANUTFORM")
                                    .HasMaxLength(50);
                                cpBuild.Property(x => x.Valor)
                                    .HasColumnName("DNITCPMANUTVALOR");
                            });
                    });
            });

    }
}