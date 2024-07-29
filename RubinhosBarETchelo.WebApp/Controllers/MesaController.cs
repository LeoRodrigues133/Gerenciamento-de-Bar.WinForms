using Microsoft.AspNetCore.Mvc;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloMesa;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloMesa;

namespace RubinhosBarETchelo.WebApp.Controllers;

public class MesaController : Controller
{
    public ViewResult Listar()
    {
        BotecoDbContext db = new BotecoDbContext();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        List<Mesa> mesas = repositorioMesa.SelecionarTodos();

        ViewBag.Mesas = mesas;

        ViewBag.Mensagem = TempData["Mensagem"];

        return View();
    }

    public IActionResult Inserir(Mesa novaMesa)
    {
        BotecoDbContext db = new BotecoDbContext();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        int EnumeradorDeMesas = repositorioMesa.SelecionarTodos().Count() * 10;

        List<Mesa> listaDeMesas = repositorioMesa.SelecionarTodos();

        Mesa buscador = listaDeMesas.Find(x => x.NumeroDaMesa == EnumeradorDeMesas)!;

        while (buscador != null)
        {
            EnumeradorDeMesas++;
            buscador = listaDeMesas.Find(x => x.NumeroDaMesa == EnumeradorDeMesas)!;
        }

        novaMesa = new(EnumeradorDeMesas);

        repositorioMesa.Cadastrar(novaMesa);

        HttpContext.Response.StatusCode = 201;

        TempData["Mensagem"] = "Mesa adicionada com sucesso!";

        return RedirectToAction("Listar");
    }

    public ViewResult Excluir(int id)
    {
        BotecoDbContext db = new BotecoDbContext();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        Mesa mesaSelecionada = repositorioMesa.SelecionarPorId(id);

        ViewBag.Mesa = mesaSelecionada;

        return View();
    }

    [HttpPost, ActionName("Excluir")]
    public ViewResult confirmarExclusao(int id)
    {
        BotecoDbContext db = new BotecoDbContext();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        Mesa mesaSelecionada = repositorioMesa.SelecionarPorId(id);
        repositorioMesa.Excluir(mesaSelecionada.Id);

        ViewBag.Mensagem = $"O registro com ID {mesaSelecionada.Id} foi excluído com sucesso!";
        ViewBag.Link = "/mesa/listar";

        return View("notificacao");
    }

    public ViewResult Detalhar(int id)
    {
        BotecoDbContext db = new();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        Mesa mesaSelecionada = repositorioMesa.SelecionarPorId(id);

        ViewBag.mesa = mesaSelecionada;
        ViewBag.Link = "/mesa/listar";

        return View();
    }
}