﻿using Rubinho_s_Bar___Tchelos.Dominio.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido.Pedidos;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloProduto;

namespace Rubinho_s_Bar___Tchelos.Dominio.MóduloPedido
{
    public class Comanda : EntidadeBase
    {
        public decimal ValorTotal { get; set; }
        public Mesa Mesa { get; set; }
        public Garçom Garçom { get; set; }
        public EnumStatusPagamento Status { get; set; }
        public DateTime DataConclusao { get; private set; }
        public List<Pedido> Pedidos { get; set; }
        public Comanda() { }

        public Comanda(Garçom garçom, EnumStatusPagamento status, Mesa mesa, List<Pedido> pedidos)
        {
            Mesa = mesa;
            Status = status;
            Pedidos = pedidos;
            Garçom = garçom;
            DataConclusao = DateTime.Now;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Comanda a = (Comanda)novoRegistro;

            Pedidos = a.Pedidos;
            ValorTotal = CalcularValor(Pedidos);
        }

        public override List<string> Validar()  
        {
            List<string> erros = new();

            if (Garçom.Id == null)
                erros.Add("Não é possivel iniciar uma comanda sem definir um garçom");

            if (Mesa.Id == null)
                erros.Add("Não é possivel iniciar uma comanda sem definir uma mesa");

            if (Status == null)
                erros.Add("Não é possível iniciar uma comanda sem definir o status de pagamento");

            if (Pedidos == null)
                erros.Add("Deve haver ao menos um produto no pedido para iniciar a comanda");

            return erros;
        }

        public decimal CalcularValor(List<Pedido> pedidos)
        {
            ValorTotal = 0;


            foreach (Pedido p in pedidos)
                ValorTotal += p.Produto.Valor * p.Quantidade;

            return ValorTotal;
        }

        public void Concluir()
        {
            Status = EnumStatusPagamento.Fechada;
            DataConclusao = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Comanda {Id}: {DataConclusao.ToShortDateString()} - Valor: {ValorTotal:C}";
        }
    }
}
