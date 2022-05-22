using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ControleEstoque1
{
    public class Model
    {
        public void SetSaida(DtoSaida e)
        {
            Context db = new Context();
            db.saida.Add(e);
            db.SaveChanges();
        }
        public void SetEntrada(DtoEntrada e)
        {
            Context db = new Context();
            db.entrada.Add(e);
            db.SaveChanges();
        }
        public void SetUsuario(DtoUsuario u)
        {
            Context db = new Context();

            db.usuario.Add(u);
            db.SaveChanges();
        }

        public void EditUsuario(DtoUsuario u)
        {
            Context db = new Context();
            DtoUsuario e = db.usuario.FirstOrDefault(p => p.id == u.id);
            e.nome = u.nome;
            e.login = u.login;
            e.senha = u.senha;
            
            db.SaveChanges();
        }

        public List<DtoUsuario2> ListUsuarios()
        {
            Context db = new Context();
            List<DtoUsuario2> result = (from a in db.usuario
                                  select new DtoUsuario2
                                  {
                                      id = a.id,
                                      nome = a.nome
                                  }).ToList();

            return new List<DtoUsuario2>(result);


        }

        public DtoUsuario2 GetUsuarioId(int id)
        {
            Context db = new Context();
            var result = (from a in db.usuario
                             where a.id == id
                                   select new DtoUsuario2
                                   {
                                       id = a.id,
                                       nome = a.nome
                                   }).FirstOrDefault();

            var result1 = db.usuario.Where(p => p.id == id).FirstOrDefault();

            return result;
        }

        public void DeletarUsuario(int id)
        {
            Context db = new Context();
            DtoUsuario u = db.usuario.FirstOrDefault(p => p.id == id);
            db.usuario.Remove(u);
            db.SaveChanges();
        }

        public void SetProduto(DtoProduto p)
        {
            Context db = new Context();
            db.produto.Add(p);
            db.SaveChanges();
        }

        public void AlteraSaida(DtoSaida sa)
        {
            Context db = new Context();
            DtoSaida saida = db.saida.FirstOrDefault(s => s.id == sa.id);
            saida.id = sa.id;
            saida.idproduro = sa.idproduro;
            saida.vlrpedido = sa.vlrpedido;
            saida.qntpedido = sa.qntpedido;
            saida.dtpedido = sa.dtpedido;
            db.SaveChanges();
        }
        public void AlteraProduto(DtoProduto pd)
        {
            Context db = new Context();
            DtoProduto produto = db.produto.FirstOrDefault(p => p.idproduto == pd.idproduto);
            produto.idproduto = pd.idproduto;
            produto.unidade = pd.unidade;
            produto.nomeproduto = pd.nomeproduto;
            produto.valorcusto = pd.valorcusto;
            produto.valorvenda= pd.valorvenda;
            produto.quantidade = pd.quantidade;
            db.SaveChanges();
        }
        public void AlteraProduto2(DtoProduto pd)
        {
            Context db = new Context();
            DtoProduto produto = db.produto.FirstOrDefault(p => p.idproduto == pd.idproduto);
            produto.quantidade = pd.quantidade;
            db.SaveChanges();
        }

        public void DeletarProduto(int id)
        {
            Context db = new Context();
            DtoProduto pd = db.produto.FirstOrDefault(p => p.idproduto == id);
            db.produto.Remove(pd);
            db.SaveChanges();
        }


        public List<DtoSaida2> ListSaidas()
        {
            Context db = new Context();
            List<DtoSaida2> result = (from sa in db.saida
                                        select new DtoSaida2
                                        {
                                            id = sa.id,
                                            idproduro = sa.idproduro,
                                            vlrpedido = sa.vlrpedido,
                                            qntpedido = sa.qntpedido,
                                            
                                        }).ToList();

            return new List<DtoSaida2>(result);


        }
        public List<DtoProduto2> ListProdutos()
        {
            Context db = new Context();
            List<DtoProduto2> result = (from pd in db.produto
                                        select new DtoProduto2
                                        {
                                            idproduto = pd.idproduto,
                                            nomeproduto = pd.nomeproduto,
                                            quantidade = pd.quantidade,
                                            valorcusto=pd.valorcusto,
                                            valorvenda = pd.valorvenda, 
                                        }).ToList();

            return new List<DtoProduto2>(result);


        }

        public List<DtoProduto2> ListProdutosNome(string text)
        {
            Context db = new Context();
            List<DtoProduto2> result = (from a in db.produto
                                        where a.nomeproduto.Contains(text)
                                        select new DtoProduto2
                                        {
                                            idproduto = a.idproduto,
                                            nomeproduto = a.nomeproduto                                        
                                        }).ToList();

            return result;
        }

       

        public DtoSaida2 GetSaidaId(int id)
        {
            Context db = new Context();
            var result = (from sa in db.saida
                          where sa.id == id
                          select new DtoSaida2
                          {
                              id = sa.id,
                              idproduro = sa.idproduro,
                              vlrpedido = sa.vlrpedido,
                              qntpedido = sa.qntpedido
                          }).FirstOrDefault();

            var result1 = db.saida.Where(p => p.id == id).FirstOrDefault();

            return result;
        }

        public DtoProduto2 GetProdutoId(int id)
        {
            Context db = new Context();
            var result = (from pd in db.produto
                          where pd.idproduto == id
                          select new DtoProduto2
                          {
                              idproduto = pd.idproduto,
                              nomeproduto = pd.nomeproduto
                          }).FirstOrDefault();

            var result1 = db.produto.Where(p => p.idproduto == id).FirstOrDefault();

            return result;
        }

        public DtoProduto GetIdProduto(int id)
        {
            Context db = new Context();
            DtoProduto e = db.produto.FirstOrDefault(p => p.idproduto == id);
            return e;
        }
    }
}
