using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;

namespace RubinhosBarETchelos.Testes.Unidade
{
    [TestClass] // Atributos
    public class ComandaTests
    {
        [TestMethod]
        [TestCategory("Testes Unitarios para comanda")]
        public void Deve_Validar_Conta_Corretamente()
        {
            // AAA = Triple A

            //arrange(preparação do teste)

            Comanda comandaInvalida = new(null, 0, null, null);

            List<string> errosEsperados =
                [
                "Não é possivel iniciar uma comanda sem definir um garçom",
                "Não é possivel iniciar uma comanda sem definir uma mesa",
                "Deve haver ao menos um produto no pedido para iniciar a comanda"
                ];
            // Act (Ação do teste)
            List<string> erros = comandaInvalida.Validar();

            // Asserts (asserção do teste)
            CollectionAssert.AreEqual(errosEsperados, erros);
        }

        [TestMethod]
        public void Deve_Fechar_Comanda_Corretamente()
        {
            // Arrange
            List<Pedido> pedidos = new();
            Mesa mesa = new(1);
            Garçom garçom = new("Tchelo", "156.156.155-98", 0);


            Comanda novaComanda = new(garçom, EnumStatusPagamento.Fechada, mesa, pedidos);

            // Act
            novaComanda.Concluir();

            // Assert 
            Assert.IsTrue(novaComanda.Status == EnumStatusPagamento.Fechada);
            Assert.IsFalse(novaComanda.Mesa.Status);

        }

    }
}