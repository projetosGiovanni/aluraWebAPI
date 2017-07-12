using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Loja.DAO;
using Loja.Models;

namespace LojaAPI.Controllers
{
    public class CarrinhoController : ApiController
    {
        public string Get(int id)
        {
            CarrinhoDAO dao = new CarrinhoDAO();
            Carrinho carro = dao.Busca(id);
            return carro.ToXML();
        }

        public string Post(Carrinho carro)
        {
            CarrinhoDAO dao = new CarrinhoDAO();
            dao.Adiciona(carro);
            return "sucesso";
        }
    }
}
