using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Rubinho_s_Bar___Tchelos.Dominio.MóduloPessoas;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloCompartilhado;
using Rubinho_s_Bar___Tchelos.Infra.Orm.MóduloPessoas;

namespace RubinhosBarETchelo.WebApp.Controllers;

public class GarcomController : Controller
{
    public ViewResult listar()
    {
        BotecoDbContext db = new BotecoDbContext();
        IRepositorioPessoas repositorioPessoas = new RepositorioPessoasEmOrm(db);

        var pessoas = repositorioPessoas.SelecionarTodos();

        ViewBag.Pessoas = pessoas;
        
        return View();
    }

    public ViewResult inserir()
    {
        return View();
    }

    [HttpPost]
    public ViewResult inserir(Garçom garcom)
    {
        var db = new BotecoDbContext();
        var repositorioPessoas = new RepositorioPessoasEmOrm(db);

        repositorioPessoas.Cadastrar(garcom);
        
        ViewBag.Mensagem = $"O registro com o ID [{garcom.Id}] foi cadastrado com sucesso!";
        ViewBag.Link = "/garcom/listar";

        HttpContext.Response.StatusCode = 201;
        
        return View("notificacao");
    }

    public ViewResult editar(int id)
    {
        var db = new BotecoDbContext();
        var repositorioPessoas = new RepositorioPessoasEmOrm(db);

        Garçom idSelecionado = repositorioPessoas.SelecionarPorId(id);

        ViewBag.Garcom = idSelecionado;
        
        return View();
    }

    [HttpPost]
    public ViewResult editar(int id, Garçom garcomSelecionado)
    {
        var db = new BotecoDbContext();
        var repositorioPessoas = new RepositorioPessoasEmOrm(db);

        var garcomEditado = repositorioPessoas.SelecionarPorId(id);

        repositorioPessoas.Editar(garcomEditado.Id, garcomSelecionado);
        
        ViewBag.Mensagem = $"O registro com o ID [{garcomEditado.Id}] foi editado com sucesso!";
        ViewBag.Link = "/garcom/listar";

        return View("notificacao");
    }

    public ViewResult excluir(int id)
    {
        var db =new BotecoDbContext();
        var repositorioPessoas = new RepositorioPessoasEmOrm(db);

        var idSelecionado = repositorioPessoas.SelecionarPorId(id);

        repositorioPessoas.Excluir(idSelecionado.Id);

        return View();
    }
    
[HttpPost, ActionName("excluir")]
    public ViewResult confirmarExclusao(int id)
    {
        var db = new BotecoDbContext();
        var repositorioPessoas = new RepositorioPessoasEmOrm(db);

        var idSelecionado = repositorioPessoas.SelecionarPorId(id);

        repositorioPessoas.Excluir(idSelecionado.Id);
        
        
        ViewBag.Mensagem = $"O registro com o ID [{idSelecionado.Id}] foi excluído com sucesso!";
        ViewBag.Link = "/garcom/listar";

        return View("notificacao");
    }

    public ViewResult detalhar(int id)
    {
        var db = new BotecoDbContext();
        var repositorioPessoas = new RepositorioPessoasEmOrm(db);

        var idSelecionado = repositorioPessoas.SelecionarPorId(id);
        
        ViewBag.Garcom = idSelecionado;

        return View();
    }
}