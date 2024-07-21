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

        return View();
    }

    public ViewResult Inserir()
    {
        return View();
    }

    [HttpPost]
    public ViewResult Inserir(Mesa novaMesa)
    {
        BotecoDbContext db = new BotecoDbContext();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        repositorioMesa.Cadastrar(novaMesa);

        HttpContext.Response.StatusCode = 201;

        ViewBag.Mensagem = $"O registro com ID {novaMesa.Id} foi cadastrado com sucesso!";

        return View("notificacao");
    }

    public ViewResult Editar(int id)
    {
        BotecoDbContext db = new BotecoDbContext();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        Mesa mesaSelecionada = repositorioMesa.SelecionarPorId(id);

        ViewBag.Mesa = mesaSelecionada;

        return View();
    }

    [HttpPost]
    public ViewResult Editar(int id, Mesa mesaAtualizada)
    {
        BotecoDbContext db = new BotecoDbContext();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        Mesa mesa = repositorioMesa.SelecionarPorId(id);

        mesaAtualizada.Status = HttpContext.Request.Form["ocupada"] == "on";

        repositorioMesa.Editar(mesa.Id, mesaAtualizada);

        ViewBag.Mensagem = $"O registro com ID {mesa.Id} foi editado com sucesso!";

        return View("notificacao");
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
    public ViewResult ExcluirMesa(int id)
    {
        BotecoDbContext db = new BotecoDbContext();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        Mesa mesa = repositorioMesa.SelecionarPorId(id);

        ViewBag.Mensagem = $"O registro com ID {mesa.Id} foi excluído com sucesso!";

        return View("notificacao");
    }

    public ViewResult Detalhar(int id)
    {
        BotecoDbContext db = new();
        IRepositorioMesa repositorioMesa = new RepositorioMesaEmOrm(db);

        Mesa mesaSelecionada = repositorioMesa.SelecionarPorId(id);

        ViewBag.mesa = mesaSelecionada;

        return View();
    }
}
