using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GeradorSenhasMVC.Models;
using GeradorSenhasMVC.Services;

namespace GeradorSenhasMVC.Controllers;

public class HomeController : Controller
{
    private readonly ISenhaService _senhaService;

    public HomeController(ISenhaService senhaService)
    {
        _senhaService = senhaService;
    }

    public IActionResult Index(SenhaModel regrasSenha)
    {
        return View(regrasSenha);
    }

    public IActionResult Gerar(SenhaModel regrasSenha)
    {
        try
        {
            var senha = _senhaService.GerarSenha(regrasSenha);
            regrasSenha.SenhaGerada = senha;
            return RedirectToAction("Index", regrasSenha);
        }
        catch (Exception ex)
        {
            return View("Error", ex.Message);
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
