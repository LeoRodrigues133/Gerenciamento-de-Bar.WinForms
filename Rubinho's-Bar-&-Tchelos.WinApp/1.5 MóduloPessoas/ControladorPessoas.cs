﻿using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloPedido;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.WinApp.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.WinApp.MóduloPessoas
{
    public class ControladorPessoas : ControladorBase, IControladorEditavel
    {

        IRepositorioPessoas repositorioPessoas;

        TabelaPessoaControl tabelaPessoas;

        public ControladorPessoas(IRepositorioPessoas repositorioPessoas)
        {
            this.repositorioPessoas = repositorioPessoas;
        }

        public override string TipoCadastro => "Pessoas";
        public override string ToolTipAdicionar => "Cadastrar uma nova pessoa";
        string IControladorEditavel.ToolTipEditar => "Editar um cadastro de pessoa";
        public override string ToolTipExcluir => "Excluir um cadastro de pessoa";

        public override void Adicionar()
        {
            TelaPessoasForm tela = new TelaPessoasForm();

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Garçom novoGarçom = tela.Garçom;

            List<Garçom> funcionarios = repositorioPessoas.SelecionarTodos();

            foreach (Garçom p in funcionarios)
            {
                if (p.Cpf == novoGarçom.Cpf)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Já existe um funcionário com este Cpf registrado");
                    return;
                }
            }

            repositorioPessoas.Cadastrar(novoGarçom);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoGarçom.Nome}\" foi criado com sucesso!");

        }

        void IControladorEditavel.Editar()
        {
            TelaPessoasForm tela = new TelaPessoasForm();

            int idSelecionado = tabelaPessoas.ObterRegistroSelecionado();

            Garçom Selecionado = repositorioPessoas.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    "Não é possível realizar esta ação sem um registro selecionado");
                return;
            }

            tela.Garçom = Selecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Garçom funcionarioEditado = tela.Garçom;

            repositorioPessoas.Editar(Selecionado.Id, funcionarioEditado);

            CarregarRegistros();

        }

        public override void Excluir()
        {
            int idSelecionado = tabelaPessoas.ObterRegistroSelecionado();

            Garçom Selecionado = repositorioPessoas.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    "Não é possível realizar esta ação sem um registro selecionado");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente demitir o \"{Selecionado.Nome}\"?",
                "Confirmar Demissão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                repositorioPessoas.Excluir(Selecionado.Id);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Você demitiu {Selecionado.Nome}!");
                CarregarRegistros();
                return;
            }


        }

        public override void CarregarRegistros()
        {
            List<Garçom> garçons = repositorioPessoas.SelecionarTodos();

            tabelaPessoas.AtualizarRegistros(garçons);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaPessoas == null)
                tabelaPessoas = new TabelaPessoaControl();

            CarregarRegistros();

            return tabelaPessoas;
        }
    }
}
