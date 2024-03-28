using minimal_api.Dominio.DTOs;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.ModelViews;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Test.Helpers;

namespace Test.Requests;

[TestClass]
public class VeiculoRequestTest
{
    [ClassInitialize]
    public static void ClassInit(TestContext testContext)
    {
        Setup.ClassInit(testContext);
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Setup.ClassCleanup();
    }

    [TestMethod]
    public async Task TestarGetSetPropriedades()
    {
        //Arrange
        var loginDTO = new LoginDTO
        {
            Email = "adm@teste.com",
            Senha = "123456"
        };

        var content = new StringContent(JsonSerializer.Serialize(loginDTO), Encoding.UTF8, "Application/json");
        var response = await Setup.client.PostAsync("/administradores/login", content);
        var result = await response.Content.ReadAsStringAsync();
        var admLogado = JsonSerializer.Deserialize<AdministradorLogado>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Setup.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", admLogado?.Token);

        var veiculoDTO = new VeiculoDTO{
            Nome = "Chevrolet Camaro",
            Marca = "Chevrolet",
            Ano = 2018,
        };

        content = new StringContent(JsonSerializer.Serialize(veiculoDTO), Encoding.UTF8,  "Application/json");

        //Act
        response = await Setup.client.PostAsync("/veiculos", content);

        //Assert
        Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

        result = await response.Content.ReadAsStringAsync();
        var veiculo = JsonSerializer.Deserialize<Veiculo>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Assert.IsNotNull(veiculo?.Nome);
        Assert.IsNotNull(veiculo.Marca);
        Assert.IsNotNull(veiculo.Ano);
    }
}
