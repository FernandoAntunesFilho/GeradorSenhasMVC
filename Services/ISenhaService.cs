using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorSenhasMVC.Models;

namespace GeradorSenhasMVC.Services
{
    public interface ISenhaService
    {
        string GerarSenha(SenhaModel regrasSenha);
    }
}