

using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa;
using System.Text;

namespace RubinhosBarETchelo.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", OlaMundo);

            app.MapGet("/mesas/listar", ListarMesas);

            app.MapGet("/mesas/inserir/{numeroMesa}", inserirMesa);

            //app.MapGet("/mesas/detalhar/{id}", detalharMesa);

            app.Run();
        }

        //private static Task detalharMesa(HttpContext context)
        //{
        //    BotecoDbContext db = new BotecoDbContext();
        //    IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        //    int id = Convert.ToInt32(context.GetRouteValue("id"));

        //    Mesa mesaSelecionda = repositorioMesa.SelecionarPorId(id);

        //    StringBuilder detalhamento = new StringBuilder();

        //    detalhamento.AppendLine("Numero:" + mesaSelecionda.NumeroDaMesa);
        //    detalhamento.AppendLine("Status:" + (mesaSelecionda.Status ? "Ocupada" : "Desocupada"));

            
        //}

        private static Task inserirMesa(HttpContext context)
        {
            BotecoDbContext db = new BotecoDbContext();
            IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

            string num = context.GetRouteValue("numeroMesa")!.ToString()!;

            Mesa novaMesa = new(Convert.ToInt32(num));

            repositorioMesa.Cadastrar(novaMesa);

            context.Response.ContentType = "text/plain; charset=utf-8";
            return context.Response.WriteAsync($"A mesa {novaMesa.Id} foi adicionada com sucesso!");
        }

        private static Task ListarMesas(HttpContext context)
        {
            BotecoDbContext db = new BotecoDbContext();
            IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

            IEnumerable<string> mesasString = repositorioMesa.SelecionarTodos().Select(mesa => mesa.ToString());

            string response = string.Join("\n", mesasString);


            context.Response.ContentType = "text/plain; charset=utf-8";
            return context.Response.WriteAsync(response);
        }

        private static Task OlaMundo(HttpContext context)
        {
            context.Response.ContentType = "text/plain; charset=utf-8";

            return context.Response.WriteAsync("Olá mundo!");
        }
    }
}
