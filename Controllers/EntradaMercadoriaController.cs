using LaPizza.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPizza.Models;
using System.Windows.Forms;
using static LaPizza.Views.FormEntMercadoria;

namespace LaPizza.Controllers
{
    public class EntradaMercadoriaController
    {
        public void AdicionarEntMercadoria(EntradaMercadoriaDB entradaMercadoriaDB)
        {
            try
            {
                Context db = new Context();
                db.entradamercadoria.Add(entradaMercadoriaDB);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar a EntradaDeMercadoria, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void AddItensEntMercadoria(EntradaMercadoriaItemDB entradaMercadoriaItem)
        {
            try
            {
                Context db = new Context();                
                db.entradamercadoriaitem.Add(entradaMercadoriaItem);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um problema ao adicionar itens a EntradaDeMercadoria, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public EntradaMercadoriaDTO GetEntradaDTO(int id)
        {
            Context db = new Context();
            EntradaMercadoriaDTO entradaMerc = new EntradaMercadoriaDTO();
            var entrada = db.entradamercadoria.FirstOrDefault(e => e.identradamerc == id);
            if (entrada != null)
            {
                entradaMerc.identradamerc = entrada.identradamerc;
                entradaMerc.idfornecedor = entrada.idfornecedor;
                entradaMerc.dataabertura = entrada.dataabertura;
                entradaMerc.dataconclusao = entrada.dataconclusao;
                entradaMerc.infadicionais = entrada.infadicionais;
                entradaMerc.vlrfrete = entrada.vlrfrete;
                entradaMerc.outroscustos = entrada.outroscustos;
                entradaMerc.status = entrada.status;
                entradaMerc.vlrliquidototal = entrada.vlrliquidototal;
                entradaMerc.vlrunitariototal = entrada.vlrunitariototal;
            }
            return entradaMerc;
        }
        public EntradaMercadoriaDB GetEntradaDB(int id)
        {
            Context db = new Context();
            EntradaMercadoriaDB entradaMerc = new EntradaMercadoriaDB();
            var entrada = db.entradamercadoria.FirstOrDefault(e => e.identradamerc == id);
            if (entrada != null)
            {
                entradaMerc.identradamerc = entrada.identradamerc;
                entradaMerc.idfornecedor = entrada.idfornecedor;
                entradaMerc.dataabertura = entrada.dataabertura;
                entradaMerc.dataconclusao = entrada.dataconclusao;
                entradaMerc.infadicionais = entrada.infadicionais;
                entradaMerc.vlrfrete = entrada.vlrfrete;
                entradaMerc.outroscustos = entrada.outroscustos;
                entradaMerc.status = entrada.status;
                entradaMerc.vlrliquidototal = entrada.vlrliquidototal;
                entradaMerc.vlrunitariototal = entrada.vlrunitariototal;
            }
            return entradaMerc;
        }
        public void AtualizaTotais(EntradaMercadoriaDB entradaMercadoriaDB)
        {
            Context db = new Context();
            EntradaMercadoriaDB entradaMerc = db.entradamercadoria.FirstOrDefault(p => p.identradamerc == entradaMercadoriaDB.identradamerc);          
            if (entradaMerc != null)
            {
                try
                {
                    entradaMerc.identradamerc = entradaMercadoriaDB.identradamerc;
                    entradaMerc.idfornecedor = entradaMercadoriaDB.idfornecedor;
                    entradaMerc.dataabertura = entradaMercadoriaDB.dataabertura;
                    entradaMerc.dataconclusao = entradaMercadoriaDB.dataconclusao;
                    entradaMerc.status = entradaMercadoriaDB.status;
                    entradaMerc.infadicionais = entradaMercadoriaDB.infadicionais;
                    entradaMerc.vlrfrete = entradaMercadoriaDB.vlrfrete;
                    entradaMerc.outroscustos = entradaMercadoriaDB.outroscustos;
                    entradaMerc.vlrunitariototal = entradaMercadoriaDB.vlrunitariototal;
                    entradaMerc.vlrliquidototal = entradaMercadoriaDB.vlrliquidototal;
                    entradaMerc.descontototal = entradaMercadoriaDB.descontototal;

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao editar a EntradaDeMercadoria, feche o cadastro e tente novamente! \n\n" + ex.Message,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        } 
        public int GetProxIdEntradaMercadoria()
        {
            Context db = new Context();
            var entradaMercadoria = db.entradamercadoria.FirstOrDefault();

            if (entradaMercadoria is null)
                return 1;
            else
                return db.entradamercadoria.Max(p => p.identradamerc) + 1;            
        }
        public void AtualizaEstoque(List<ProdutosGrid> produtos)
        {
            Context db = new Context();
            foreach (ProdutosGrid prod in produtos)
            {
                var produto = db.produto.FirstOrDefault(p => p.idproduto == prod.id);
                if (produto != null)
                    produto.saldoestoque += Convert.ToDecimal(prod.quantidade);
            }
            db.SaveChanges();
        }
        public void VoltaEstoque(List<ProdutosGrid>produtos)
        {
            Context db = new Context();
            foreach (ProdutosGrid prod in produtos)
            {
                var produto = db.produto.FirstOrDefault(p => p.idproduto == prod.id);
                if (produto != null)
                    produto.saldoestoque -= Convert.ToDecimal(prod.quantidade);
            }
            db.SaveChanges();
        }
        public void CancelaEntrada(EntradaMercadoriaDB entrada)
        {
            Context db = new Context();
            EntradaMercadoriaController controle = new EntradaMercadoriaController();
            var entradaDB = db.entradamercadoria.FirstOrDefault(p => p.identradamerc == entrada.identradamerc);
            if (entradaDB != null)
            {
                entradaDB.identradamerc = entrada.identradamerc;
                entradaDB.idfornecedor = entrada.idfornecedor;
                entradaDB.dataabertura = entrada.dataabertura;
                entradaDB.dataconclusao = entrada.dataconclusao;
                entradaDB.infadicionais = entrada.infadicionais;
                entradaDB.status = entrada.status;
                entradaDB.vlrfrete = entrada.vlrfrete;
                entradaDB.outroscustos = entrada.outroscustos;
                entradaDB.vlrunitariototal = entrada.vlrunitariototal;
                entradaDB.vlrliquidototal = entrada.vlrliquidototal;
                entradaDB.descontototal = entrada.descontototal;                
                db.SaveChanges();
            }          
        }
        public void RatearOutrosEFrete(int codEntrada, List<ProdutosGrid> produtos)
        {
            Context db = new Context();
            var entrada = db.entradamercadoria.FirstOrDefault(p => p.identradamerc == codEntrada);
            double vlrFreteEoutros, qtdeProdutos = 0;
            if ((entrada != null) && (produtos.Count > 0))
            {
                vlrFreteEoutros = entrada.outroscustos + entrada.vlrfrete;
                foreach (ProdutosGrid prod in produtos)
                {
                    //Calcula qtde de produtos
                    qtdeProdutos += prod.quantidade;
                }
                vlrFreteEoutros = vlrFreteEoutros / qtdeProdutos;
                Math.Truncate(vlrFreteEoutros);
                foreach (ProdutosGrid prod in produtos)
                {
                    //Rateia frete e outros para os produtos
                    var produto = db.produto.FirstOrDefault(p => p.idproduto == prod.id);
                    if (produto != null)
                    {
                        produto.precoanterior = produto.precoatual;
                        produto.precoatual = Convert.ToDecimal(prod.vlrVenda) + Convert.ToDecimal(vlrFreteEoutros);
                    }                        
                }
                db.SaveChanges();
            }

        }
        public void VoltaProdVlrAnterior(List<ProdutosGrid> produtos)
        {
            decimal aux = 0; 
            Context db = new Context();           
            foreach (ProdutosGrid prod in produtos)
            {
                //Rateia frete e outros para os produtos
                var produto = db.produto.FirstOrDefault(p => p.idproduto == prod.id);
                if (produto != null)
                {                   
                    aux = produto.precoanterior;
                    produto.precoanterior = produto.precoatual;
                    produto.precoatual = aux;                    
                }
            }
            db.SaveChanges();
        }
        public void RemoveItensEntrada(int codEntrada)
        {
            Context db = new Context();
            var entradaMercItem = db.entradamercadoriaitem.FirstOrDefault(p => p.identradamerc == codEntrada);            
            while(entradaMercItem != null)
            {
                //Removendo todos itens da entrada  
                entradaMercItem = db.entradamercadoriaitem.FirstOrDefault(p => p.identradamerc == codEntrada);
                if(entradaMercItem != null)
                {
                    db.entradamercadoriaitem.Remove(entradaMercItem);
                    db.SaveChanges();
                }                    
            }            
        }
        public List<ProdutosGrid> ListaItens(int id)
        {
            Context db = new Context();
            var lista = (from entradaitens in db.entradamercadoriaitem
                         join produtos in db.produto on entradaitens.idproduto equals produtos.idproduto
                         orderby entradaitens.identradamerc
                         where entradaitens.identradamerc == id
                         select new ProdutosGrid
                         {
                            id = entradaitens.idproduto,
                            descricao = produtos.descricao,
                            quantidade = entradaitens.qtde,
                            vlrUnitario = entradaitens.vlrunitario,
                            desconto = entradaitens.vlrdesconto,
                            vlrTotal = entradaitens.vlrliquidototal,
                            vlrVenda = entradaitens.precovenda
                         }).ToList();
            return lista;
        }
        public List<EntradaMercadoriaDTO> ListaEntradaMercadoria()
        {
            Context db = new Context();
            List<EntradaMercadoriaDTO> lista = (from entrada in db.entradamercadoria                                        
                                        orderby entrada.identradamerc
                                        select new EntradaMercadoriaDTO
                                        {
                                           identradamerc = entrada.identradamerc,
                                           idfornecedor = entrada.idfornecedor,
                                           status = entrada.status,
                                           dataabertura = entrada.dataabertura,
                                           dataconclusao = entrada.dataconclusao,
                                           vlrunitariototal = entrada.vlrunitariototal,
                                           vlrliquidototal = entrada.vlrliquidototal
                                        }).ToList();

            return lista;

        }
        public List<EntradaMercadoriaDTO> ListaEntradaMercadoriaFiltrada(DateTime dataInicio, DateTime dataFim, string status)
        {
            Context db = new Context();
            List<EntradaMercadoriaDTO> lista = (from entrada in db.entradamercadoria
                                                orderby entrada.identradamerc
                                                where entrada.dataabertura >= dataInicio &&
                                                      entrada.dataabertura <= dataFim &&
                                                      entrada.status == status
                                                select new EntradaMercadoriaDTO
                                                {
                                                    identradamerc = entrada.identradamerc,
                                                    idfornecedor = entrada.idfornecedor,
                                                    status = entrada.status,
                                                    dataabertura = entrada.dataabertura,
                                                    dataconclusao = entrada.dataconclusao,
                                                    vlrunitariototal = entrada.vlrunitariototal,
                                                    vlrliquidototal = entrada.vlrliquidototal
                                                }).ToList();

            return lista;
        }      
    }
}
