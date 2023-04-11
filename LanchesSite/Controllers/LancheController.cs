using LanchesSite.Repositories.Interfaces;
using LanchesSite.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesSite.Controllers;

public class LancheController : Controller
{
    private readonly ILancheRepository _repository;
    public LancheController(ILancheRepository repository)
    {
        _repository = repository;
    }

    public IActionResult List()
    {
        //var result = _repository.Lanches;
        //return View(result);

        LancheListViewModel lanchelistviewModel = new();
        lanchelistviewModel.Lanches = _repository.Lanches;
        lanchelistviewModel.CategoriaAtual = "Categoria Atual";

        return View(lanchelistviewModel);
    }
}
