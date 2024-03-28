using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.Interfaces;

namespace Test.Mocks;

public class VeiculoServicoMock : IVeiculoServico
{
    private static List<Veiculo> veiculos = new List<Veiculo>(){
        new Veiculo {
            Id = 1,
            Nome = "Toyota Corolla",
            Marca = "Toyota",
            Ano = 2021
        },
        new Veiculo {
            Id = 2,
            Nome = "Volkswagen Golf",
            Marca = "Volkswagen",
            Ano = 2019
        },
    };

    public void Apagar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public Veiculo? Buscaporid(int id)
    {
        return veiculos.Find(a => a.Id == id);
    }

    public void Incluir(Veiculo veiculo)
    {
        veiculo.Id = veiculos.Count() + 1;
        veiculos.Add(veiculo);
    }

    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        return veiculos;
    }
}
