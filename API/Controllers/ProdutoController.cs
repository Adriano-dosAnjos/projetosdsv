using System;
using System.Collections.Generic;
using System.Linq;
using API.Models;
using API.Data;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers{

    [ApiController]
    [Route("api/produto")]

    public class ProdutoController : ControllerBase{

        private readonly DataContext _context;

        //Construtor
        private DataContext _context;

        public ProdutoController(DataContext context) => _context = context;

        //POST: api/produto/create
        [HttpPost]
        [Route("create")]
        public Produto Create(Produto produto){
            
            _context.Produto.Add(produto);
            _context.SaveChanges();
            return produto;
        }

        //GET: api/produto/list
        [HttpGet]
        [Route("list")]
        public List<Produto> List() => _context.Produtos.ToList();

    }
}