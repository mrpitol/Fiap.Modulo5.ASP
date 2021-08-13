using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Fiap.Web.AspNet2.Models;

namespace Fiap.Web.AspNet2.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("validando o acesso ao controller Home e ação Index");
            return View();
        }//Index

        public IActionResult Novo()
        {
            return View();
        }

        public IActionResult Cadastrar(ClientModel clientModel)
        {
            TempData["mensagemSucesso"]=$"Cliente { clientModel.Nome} cadastrado com sucesso";

            return RedirectToAction ("Index");
        }


        //public IActionResult Cadastrar(ClientModel clientModel)
        //{

        //    //Capturar os dados digitados
        //    Console.WriteLine(clientModel);
        //    //Validar os dados
        //    //Gravar os dados no banco de dados
        //    Console.WriteLine("Gravando no banco de dados e recuperando o id");

        //    clientModel.Clienteid = 199;

        //    ViewData["Clienteid"] = clientModel.Clienteid;
        //    ViewBag.NomeCliente = clientModel.Nome;
        //    ViewBag.Mensagem = "Mensagem de Teste da ViewBag";

        //    ViewData["ClienteModel"] = clientModel;
        //    ViewBag.ClientModel = clientModel;

        //    //return RedirecttoAction
        //    TempData["ClienteModel"] = clientModel;

        //    //Exibir a tela de sucesso
        //    return View();
        //}

    }//class

}//namespace
