using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestGetSetPropriedades()
    {
        //Arrange
        var veiculo = new Veiculo();

        //Act
        veiculo.Id = 1;
        veiculo.Nome = "Ford Mustang";
        veiculo.Marca = "Ford";
        veiculo.Ano = 1967;

        //Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Ford Mustang", veiculo.Nome);
        Assert.AreEqual("Ford", veiculo.Marca);
        Assert.AreEqual(1967, veiculo.Ano);
    }
}
