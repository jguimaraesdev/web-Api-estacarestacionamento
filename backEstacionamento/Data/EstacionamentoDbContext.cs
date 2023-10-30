using Microsoft.EntityFrameworkCore;

public class EstacionamentoDbContext : DbContext
{
    public DbSet<Marca>? marca {get; set;}
    public DbSet<Veiculo>? veiculo {get; set;}
    public DbSet<Carro>? carro {get; set;}
    public DbSet<Cliente>? cliente {get; set;}
    public DbSet<NotaFiscal>? notafiscal {get; set;}
    public DbSet<Servico>? servico {get; set;}
    public DbSet<Periodo>? periodo {get; set;}
    public DbSet<Ticket>? ticket {get; set;}
    public DbSet<Modelo>? modelo {get; set;}
    public DbSet<Caminhonete>? caminhonete {get; set;}

    public DbSet<Moto>? moto {get; set;}
    //----------------------------------------------------------------------------------
    //configuração de conexão com o banco
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "DataSource=estacionamento.db;Cache=Shared");
    }


    //------------------------------------------------------------------------------------
   
    
}