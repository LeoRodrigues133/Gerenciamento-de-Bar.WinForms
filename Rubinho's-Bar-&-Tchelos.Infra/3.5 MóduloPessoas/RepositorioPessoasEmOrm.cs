using Microsoft.EntityFrameworkCore;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;

namespace Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloPessoas
{
    public class RepositorioPessoasEmOrm : IRepositorioPessoas
    {
        BotecoDbContext dbContext;
        public RepositorioPessoasEmOrm(BotecoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Cadastrar(Garçom novoRegistro)
        {
            dbContext.Garçons.Add(novoRegistro);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Garçom editarRegistro)
        {
            Garçom garçomSelecionado = dbContext.Garçons.Find(id);

            if (garçomSelecionado == null)
                return false;

            garçomSelecionado.AtualizarRegistro(editarRegistro);

            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Garçom garçomSelecionado = dbContext.Garçons.Find(id);

            if (garçomSelecionado == null)
                return false;

            garçomSelecionado.AtualizarRegistro(garçomSelecionado);

            dbContext.SaveChanges();

            return true;

        }

        public Garçom SelecionarPorId(int id)
        {
            return dbContext.Garçons.Find(id);
        }

        public List<Garçom> SelecionarTodos()
        {
            return dbContext.Garçons.ToList();
        }
    }
}
