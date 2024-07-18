using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa;

namespace RubinhosBarETchelos.Testes.Integração
{
    [TestClass] // Atributos
    [TestCategory("Teste de integração de mesas")]
    public class RepositorioMesasEmOrmTest
    {
        RepositorioMesaEmOrm repositorioMesas;
        BotecoDbContext dbContext;

        [TestMethod]
        public void Deve_Inserir_Mesa()
        {
            //Arrange
            Mesa novaMesa = new(30);

            dbContext = new BotecoDbContext();
            repositorioMesas = new RepositorioMesaEmOrm(dbContext);

            //Act
            repositorioMesas.Cadastrar(novaMesa);

            Mesa mesaSelecionada = repositorioMesas.SelecionarPorId(novaMesa.Id);

            //Assert
            Assert.AreEqual(novaMesa, mesaSelecionada);
        }
    }
}