using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.Servicos;
using minimal_api.Infraestrutura.Db;
using System.Reflection;

namespace Test.Domain.Servicos;

[TestClass]
public class VeiculoServicoTest
{
    private DbContexto CriarContextoTeste()
    {
        var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

        var builder = new ConfigurationBuilder()
            .SetBasePath(path ?? Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        var configuration = builder.Build();

        return new DbContexto(configuration);
    }

    [TestMethod]
    public void TestandoSalvarVeiculo()
    {
        //Arrange
        var context = CriarContextoTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var veiculo = new Veiculo();
        veiculo.Nome = "Ford Mustang";
        veiculo.Marca = "Ford";
        veiculo.Ano = 1967;

        var veiculoServico = new VeiculoServico(context);

        //Act
        veiculoServico.Incluir(veiculo);

        //Assert
        Assert.AreEqual(1, veiculoServico.Todos(1).Count());
    }

    [TestMethod]
    public void TestandoBuscaPorid()
    {
        //Arrange
        var context = CriarContextoTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var veiculo = new Veiculo();
        veiculo.Nome = "Ford Mustang";
        veiculo.Marca = "Ford";
        veiculo.Ano = 1967;

        var veiculoServico = new VeiculoServico(context);

        //Act
        veiculoServico.Incluir(veiculo);
        var veiculoDobanco = veiculoServico.Buscaporid(veiculo.Id);

        //Assert
        Assert.AreEqual(1, veiculoDobanco?.Id);
    }
}
