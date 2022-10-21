using LaPizza.Controllers;
using LaPizza.Models;
using LaPizza.Views.Pesquisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Views
{   
    public partial class FormEntMercadoria : LaPizza.Views.FormBaseCadastros
    {
        public class ProdutosGrid
        {
            public int id { get; set; }
            public string descricao { get; set; }
            public double quantidade { get; set; }
            public double vlrUnitario { get; set; }
            public double desconto { get; set; }
            public double vlrTotal { get; set; }
            public double vlrVenda { get; set; }
        }
        private EntradaMercadoriaController _entradaController;
        private EntradaMercadoriaDB _entradaMercadoria;
        private EntradaMercadoriaItemDB _entradaMercadoriaItem;
        private FornecedorDTO _Fornecedor;
        private List<ProdutosGrid> _produtosGrid = new List<ProdutosGrid>();             
        private ProdutoDTO _produto;
        private int _produtoSelecionado = 0;
        private double _totalBruto, _totalDesconto, _totalLiquido, _totalProduto;
       
        public FormEntMercadoria()
        {
            InitializeComponent();
            HabilitarComponentesPnlPrincipal(false);            
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            if (_produto == null)
            {
                MessageBox.Show("Selecione um produto.");
                txtProduto.Focus();
            }
            else
            {
                if ((txtQtde.Text == string.Empty) || (txtQtde.Text == "0,00") || (txtQtde.Text == "0"))
                {
                    txtQtde.Text = "1,00";
                }
                //Recalcula();
                RecalculaTotal();
                txtVlrUnit.Focus();
            }
        }

        private  void HabilitarComponentesPnlPrincipal(bool ativa)
        {
            if (ativa)
            {
                txtFornecedor.Enabled = true;
                PesquisaFornecedor.Enabled = true;
                dtAbertura.Enabled = true;
                dtConclusao.Enabled = true;
                txtInfAdicionais.Enabled = true;
                txtFrete.Enabled = true;
                txtOutrosCustos.Enabled = true;
                gbStatus.Enabled = true;
                txtProduto.Enabled = true;
                pesquisaProduto.Enabled = true;
                txtQtde.Enabled = true;
                txtVlrUnit.Enabled = true;
                txtVlrDesc.Enabled = true;
                txtVlrTotal.Enabled = true;
                txtVlrVenda.Enabled = true;
                txtNumeroNota.Enabled = true;
                txtChaveNota.Enabled = true;
            }
            else
            {
                txtFornecedor.Enabled = false;
                PesquisaFornecedor.Enabled = false;
                dtAbertura.Enabled = false;
                dtConclusao.Enabled = false;
                txtInfAdicionais.Enabled = false;
                txtFrete.Enabled = false;
                txtOutrosCustos.Enabled = false;
                gbStatus.Enabled = false;
                txtProduto.Enabled = false;
                pesquisaProduto.Enabled = false;
                txtQtde.Enabled = false;
                txtVlrUnit.Enabled = false;
                txtVlrDesc.Enabled = false;
                txtVlrTotal.Enabled = false;
                txtVlrVenda.Enabled = false;
                txtNumeroNota.Enabled = false;
                txtChaveNota.Enabled = false;
            }
        }

        private void LimparComponentesEntraMerc()
        {
            _totalBruto = 0.00;
            _totalDesconto = 0.00;
            _totalLiquido = 0.00;
            _totalProduto = 0.00;
            _produtoSelecionado = 0;
            txtFornecedor.Text = "";
            PesquisaFornecedor.Text = "";
            dtAbertura.Text = "";
            dtConclusao.Text = "";
            txtInfAdicionais.Text = "";
            txtFrete.Text = "";
            txtOutrosCustos.Text = "";
            gbStatus.Text = "";
            txtProduto.Text = "";
            pesquisaProduto.Text = "";
            txtQtde.Text = "";
            txtVlrUnit.Text = "";
            txtVlrDesc.Text = "";
            txtVlrTotal.Text = "";
            txtVlrVenda.Text = "";
            txtNumeroNota.Text = "";
            txtChaveNota.Text = "";
            DGVProdutos.DataSource = null;
            _Fornecedor = null;
            _produto = null;
            _entradaController = null;
            _entradaMercadoria = null;
            _entradaMercadoriaItem = null;
            _produtosGrid.Clear();
        }

        private void pesquisaProduto_Click(object sender, EventArgs e)
        {
            FormEstProdutoPesquisa prodPesquisa = new FormEstProdutoPesquisa();
            var Result = prodPesquisa.ShowDialog();
            if (Result == DialogResult.OK)
            {
                _produto = prodPesquisa.PProduto;
                txtProduto.Text = prodPesquisa.PProduto.descricao;
                txtVlrUnit.Text = prodPesquisa.PProduto.precoatual.ToString();
                txtVlrTotal.Text = prodPesquisa.PProduto.precoatual.ToString();
                txtQtde.Focus();
            }
        }

        private void PesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FormRecFornecedorPesquisa fornPesquisa = new FormRecFornecedorPesquisa();
            var Result = fornPesquisa.ShowDialog();
            if (Result == DialogResult.OK)
            {
                _Fornecedor = fornPesquisa.PesqFornecedor;
                txtFornecedor.Text = _Fornecedor.nomerazao;
            }
        }

        private void btnAcaoAdicionar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);
            try
            {
                txtFrete.Text = "0,00";
                txtOutrosCustos.Text = "0,00";
                txtQtde.Text = "0,00";
                txtVlrUnit.Text = "0,00";
                txtVlrDesc.Text = "0,00";
                txtVlrTotal.Text = "0,00";
                txtVlrVenda.Text = "0,00";

                rbCancelar.Enabled = false;
                _entradaController = new EntradaMercadoriaController();
                _entradaMercadoria = new EntradaMercadoriaDB();
                _entradaMercadoria.identradamerc = _entradaController.GetProxIdEntradaMercadoria();
                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao dar entrada de mercadoria " + ex.Message);
            }
        }

        public void RecalculaTotal()
        {
            double Qte = 0, Desconto = 0, VlrUnit = 0;

            if (txtVlrDesc.Text != "")
                Desconto = Convert.ToDouble(txtVlrDesc.Text);

            if (txtQtde.Text != "")
                Qte = Convert.ToDouble(txtQtde.Text);

            if (txtVlrUnit.Text != "")
                VlrUnit = Convert.ToDouble(txtVlrUnit.Text);

            txtVlrTotal.Text = (Qte * VlrUnit - Desconto).ToString("N2");
        }

        //Acima ultimo metodo ajustado xD





        private void btnConfirmar_Click(object sender, EventArgs e)
        {           
            try
            {                                 
                if (MenuStatus == MStatus.Adicionando)
                {
                    if (ValidaCampos())
                    {
                        _entradaMercadoria.idfornecedor = _Fornecedor.idfornecedor;
                        _entradaMercadoria.dataabertura = dtAbertura.Value;
                        _entradaMercadoria.dataconclusao = dtConclusao.Value;
                        _entradaMercadoria.infadicionais = txtInfAdicionais.Text;
                        if (txtFrete.Text != string.Empty)
                            _entradaMercadoria.vlrfrete = Convert.ToDouble(txtFrete.Text);
                        if (txtOutrosCustos.Text != string.Empty)
                            _entradaMercadoria.outroscustos = Convert.ToDouble(txtOutrosCustos.Text);
                        if (rbEfetivar.Checked)
                            _entradaMercadoria.status = "EFE";
                        if (rbPendente.Checked)
                            _entradaMercadoria.status = "PEN";

                        //Adicionando a entrada de mercadoria
                        _entradaController.AdicionarEntMercadoria(_entradaMercadoria);
                        foreach (ProdutosGrid p in _produtosGrid)
                        {
                            //Adicionando itens da entrada
                            _entradaMercadoriaItem = new EntradaMercadoriaItemDB
                            {
                                identradamerc = _entradaMercadoria.identradamerc,
                                idproduto = p.id,
                                qtde = Convert.ToInt32(p.quantidade),
                                vlrunitario = p.vlrUnitario,
                                vlrdesconto = p.desconto,
                                vlrliquidototal = p.vlrTotal,
                                precovenda = p.vlrVenda
                            };
                            _entradaController.AddItensEntMercadoria(_entradaMercadoriaItem);
                        }
                        _entradaMercadoria.vlrunitariototal = _totalBruto;
                        _entradaMercadoria.descontototal = _totalDesconto;
                        _entradaMercadoria.vlrliquidototal = _totalLiquido;

                        //Atualiza totais
                        _entradaController.AtualizaTotais(_entradaMercadoria);
                        if (rbEfetivar.Checked)
                        {
                            //Atualiza estoque
                            _entradaController.AtualizaEstoque(_produtosGrid);
                            //Rateia Frete
                            _entradaController.RatearOutrosEFrete(_entradaMercadoria.identradamerc, _produtosGrid);
                        }
                        LimparComponentesEntraMerc();
                        HabilitarComponentesPnlPrincipal(false);
                        HabilitarAcoesIniciais();

                        txtFornecedor.Focus();
                    }
                    else
                        HabilitaAcao(TipoAcao.Confirmar, true);
                }                                
                else if (MenuStatus == MStatus.Editando)
                {
                    if (ValidaCampos())
                    {
                        _entradaMercadoria.idfornecedor = _Fornecedor.idfornecedor;
                        _entradaMercadoria.dataabertura = dtAbertura.Value;
                        _entradaMercadoria.dataconclusao = dtConclusao.Value;
                        _entradaMercadoria.infadicionais = txtInfAdicionais.Text;
                        if (txtFrete.Text != string.Empty)
                            _entradaMercadoria.vlrfrete = Convert.ToDouble(txtFrete.Text);
                        if (txtOutrosCustos.Text != string.Empty)
                            _entradaMercadoria.outroscustos = Convert.ToDouble(txtOutrosCustos.Text);
                        if (rbEfetivar.Checked)
                            _entradaMercadoria.status = "EFE";
                        if (rbPendente.Checked)
                            _entradaMercadoria.status = "PEN";

                        //Remove os produtos antigos
                        _entradaController.RemoveItensEntrada(_entradaMercadoria.identradamerc);
                        foreach (ProdutosGrid p in _produtosGrid)
                        {
                            //Adicionando itens da entrada
                            _entradaMercadoriaItem = new EntradaMercadoriaItemDB
                            {
                                identradamerc = _entradaMercadoria.identradamerc,
                                idproduto = p.id,
                                qtde = Convert.ToInt32(p.quantidade),
                                vlrunitario = p.vlrUnitario,
                                vlrdesconto = p.desconto,
                                vlrliquidototal = p.vlrTotal,
                                precovenda = p.vlrVenda
                            };
                            _entradaController.AddItensEntMercadoria(_entradaMercadoriaItem);
                        }
                        _entradaMercadoria.vlrunitariototal = _totalBruto;
                        _entradaMercadoria.descontototal = _totalDesconto;
                        _entradaMercadoria.vlrliquidototal = _totalLiquido;

                        //Atualiza totais
                        _entradaController.AtualizaTotais(_entradaMercadoria);
                        if (rbEfetivar.Checked)
                        {
                            //Atualiza estoque
                            _entradaController.AtualizaEstoque(_produtosGrid);
                            //Rateia Frete
                            _entradaController.RatearOutrosEFrete(_entradaMercadoria.identradamerc, _produtosGrid);
                        }
                        LimparComponentesEntraMerc();
                        HabilitarComponentesPnlPrincipal(false);
                        HabilitarAcoesIniciais();

                        txtFornecedor.Focus();
                    }
                    else
                        HabilitaAcao(TipoAcao.Confirmar, true);
                }                                

                else if (MenuStatus == MStatus.Excluindo)
                {
                    DialogResult Dr = MessageBox.Show("Deseja realmente cancelar a entrada?\n O estoque irá ser removido dos produtos.", 
                                                     "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(Dr == DialogResult.Yes)
                    {
                        _entradaMercadoria.dataconclusao = DateTime.Now;
                        _entradaMercadoria.status = "CAN";
                        //Remove o estoque...
                        _entradaController.VoltaEstoque(_produtosGrid);
                        //Volta Estoque
                        _entradaController.VoltaProdVlrAnterior(_produtosGrid);

                        _entradaController.CancelaEntrada(_entradaMercadoria);                        
                        LimparComponentesEntraMerc();
                        HabilitarComponentesPnlPrincipal(false);
                        HabilitarAcoesIniciais();
                    }                    
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpaCamposProd()
        {
            _totalProduto = 0.00;
            _produto = null;
            txtProduto.Text = "";
            txtQtde.Text = "";
            txtVlrUnit.Text = "";
            txtVlrDesc.Text = "";
            txtVlrTotal.Text = "";
            txtVlrVenda.Text = "";
        }
        
        private bool ValidaCampos()
        {
            if(_Fornecedor == null)
            {                
                MessageBox.Show("Preencha o campo fornecedor!");
                txtFornecedor.Focus();
                return false;
            }                                                  
            if (_produtosGrid.Count < 1)
            {
                MessageBox.Show("Não há produtos na entrada de mercadoria!");
                txtProduto.Focus();
                return false;
            }
            return true;
        }

        private void Recalcula()
        {
            double total, qtde, unit;
            if(txtProduto.Text != string.Empty)
            {
                if (txtVlrDesc.Text == string.Empty)
                    txtVlrDesc.Text = "0";
                if (txtVlrVenda.Text == string.Empty)
                    txtVlrVenda.Text = "0";
                if (txtQtde.Text == string.Empty)
                    txtQtde.Text = "0";
                if (txtVlrDesc.Focused)
                {
                    total = Convert.ToDouble(txtVlrTotal.Text);
                    total = Convert.ToDouble(txtVlrUnit.Text) * Convert.ToDouble(txtQtde.Text) - Convert.ToDouble(txtVlrDesc.Text);
                    total -= Convert.ToDouble(txtVlrDesc.Text);
                    txtVlrTotal.Text = total.ToString("N2");
                }
                else if (txtVlrVenda.Focused)
                {                    
                    _totalBruto += _totalProduto;
                    _totalDesconto += Convert.ToDouble(txtVlrDesc.Text);
                    _totalLiquido += Convert.ToDouble(txtVlrTotal.Text);
                }
                else
                {
                    qtde = Convert.ToDouble(txtQtde.Text);
                    unit = Convert.ToDouble(txtVlrUnit.Text);
                    _totalProduto = qtde * unit;
                    Math.Truncate(_totalProduto);
                    txtVlrTotal.Text = _totalProduto.ToString("N2");
                    txtQtde.Text = qtde.ToString("N2");
                    txtVlrUnit.Text = unit.ToString("N2");
                }
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {       
            if (Convert.ToInt32(e.KeyChar) == 13)
            {     
                if(_produto == null)
                {
                    MessageBox.Show("Selecione um produto.");
                    txtProduto.Focus();
                }
                else
                {
                    if((txtQtde.Text == string.Empty) || (txtQtde.Text == "0,00") || (txtQtde.Text == "0"))
                    {
                        txtQtde.Text = "1,00";                       
                    }                                     
                    Recalcula();
                    txtVlrUnit.Focus();                                      
                }                                                          
            }
        }

        private void txtVlrVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            double vlrVenda, vlrUnit;
            if(Convert.ToInt32(e.KeyChar) == 13)
            {               
                if((txtVlrVenda.Text != string.Empty) && (txtVlrUnit.Text != string.Empty) && (txtVlrUnit.Text != "0,00") && (txtVlrUnit.Text != "0"))
                {
                    vlrUnit = Convert.ToDouble(txtVlrUnit.Text);
                    vlrVenda = Convert.ToDouble(txtVlrVenda.Text);                   
                    if(vlrVenda <= vlrUnit)
                    {
                        MessageBox.Show("Valor de venda não pode ser menor que o valor unitário.\n" +
                        "Valor unitário R$ " + vlrUnit.ToString("N2"));                       
                        txtVlrVenda.Focus();
                        return;
                    }                    
                }
                if ((_produto != null) && (txtVlrTotal.Text != string.Empty) && (txtVlrTotal.Text != "0,00")
                  && (txtVlrVenda.Text != string.Empty) && (txtVlrVenda.Text != "0") && (txtVlrVenda.Text != "0,00"))
                {
                    Recalcula();
                    lblTotalBruto.Text = _totalBruto.ToString("N2");
                    lblDescontos.Text = _totalDesconto.ToString("N2");
                    lblTotalLiquido.Text = _totalLiquido.ToString("N2");
                    AddProdutoGrid();
                    AjeitaCamposGrid();
                    LimpaCamposProd();
                    txtProduto.Focus();
                }
                else
                {
                    MessageBox.Show("Selecione o produto.");
                    txtProduto.Focus();
                }
            }            
        }
        private void AjeitaCamposGrid()
        {
            DGVProdutos.Columns["id"].HeaderText = "Cód. Produto";           
            DGVProdutos.Columns["descricao"].HeaderText = "Descrição";
            DGVProdutos.Columns["quantidade"].HeaderText = "Quantidade";

            DGVProdutos.Columns["vlrUnitario"].HeaderText = "Vlr Unitário R$";
            DGVProdutos.Columns["vlrUnitario"].DefaultCellStyle.Format = "N2";

            DGVProdutos.Columns["desconto"].HeaderText = "Desconto R$";
            DGVProdutos.Columns["desconto"].DefaultCellStyle.Format = "N2";

            DGVProdutos.Columns["vlrTotal"].HeaderText = "Vlr Total R$";
            DGVProdutos.Columns["vlrTotal"].DefaultCellStyle.Format = "N2";

            DGVProdutos.Columns["vlrVenda"].HeaderText = "Vlr Venda R$";
            DGVProdutos.Columns["vlrVenda"].DefaultCellStyle.Format = "N2";
        }
        private void AddProdutoGrid()
        {
            try
            {
                ProdutosGrid prodGrid = new ProdutosGrid
                {
                    id = _produto.idproduto,
                    descricao = _produto.descricao,
                    quantidade = Convert.ToDouble(txtQtde.Text),
                    vlrUnitario = Convert.ToDouble(txtVlrUnit.Text),
                    desconto = Convert.ToDouble(txtVlrDesc.Text),
                    vlrTotal = Convert.ToDouble(txtVlrTotal.Text),
                    vlrVenda = Convert.ToDouble(txtVlrVenda.Text)
                };

                Math.Truncate(prodGrid.vlrUnitario);
                Math.Truncate(prodGrid.desconto);
                Math.Truncate(prodGrid.vlrTotal);
                Math.Truncate(prodGrid.vlrVenda);

                DGVProdutos.DataSource = null;
                _produtosGrid.Add(prodGrid);
                DGVProdutos.DataSource = _produtosGrid;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inserir produto! "+ex.Message);
            }                   
        }

        private void DGVProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                              
        }

        private void DGVProdutos_KeyUp(object sender, KeyEventArgs e)
        {
            if((MenuStatus != MStatus.Consultando) && (MenuStatus != MStatus.Excluindo))
            {
                _produtoSelecionado = (int)DGVProdutos.CurrentRow.Cells["id"].Value;
                if (e.KeyCode == Keys.Delete)
                {
                    DialogResult dialogResult;
                    if (_produtoSelecionado > 0)
                    {
                        dialogResult = MessageBox.Show("Deseja excluir o produto selecionado?", "Atenção!!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            for (int i = 0; i < _produtosGrid.Count; i++)
                            {
                                if (_produtosGrid[i].id == _produtoSelecionado)
                                    _produtosGrid.Remove(_produtosGrid[i]);
                            }
                        }
                        CalculaTotais();
                        _produtoSelecionado = 0;
                        DGVProdutos.DataSource = null;
                        DGVProdutos.DataSource = _produtosGrid;
                        AjeitaCamposGrid();
                    }
                }
            }
            
        }       
        private void txtVlrUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (_produto == null)
                {
                    MessageBox.Show("Selecione um produto.");
                    txtProduto.Focus();
                }
                else if((txtVlrUnit.Text == string.Empty) || txtVlrUnit.Text == "0,00" || txtVlrUnit.Text == "0")
                {
                    MessageBox.Show("Campo valor unitário não pode ser igual a 0 \n selecione o produto novamente");                   
                    txtProduto.Focus();
                }
                else
                {
                    Recalcula();
                    txtVlrDesc.Focus();
                }                
            }
        }       
        
        private void txtFrete_TextChanged(object sender, EventArgs e)
        {
            CalculaTotais();
        }

        private void txtOutrosCustos_TextChanged(object sender, EventArgs e)
        {
            CalculaTotais();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparComponentesEntraMerc();
            HabilitarComponentesPnlPrincipal(false);
        }
        private void cancelaOperacao()
        {
            LimparComponentesEntraMerc();
            HabilitarComponentesPnlPrincipal(false);
            HabilitarAcoesIniciais();
        }
        private void btnAcaoEditar_Click(object sender, EventArgs e)
        {
            HabilitarComponentesPnlPrincipal(true);
            rbCancelar.Enabled = false;
            FormEstEntradaMercPesquisa formEstEntradaMercPesquisa = new FormEstEntradaMercPesquisa();          
            _entradaController = new EntradaMercadoriaController();
            formEstEntradaMercPesquisa.VerificaStatus("Editando");
            var Dr = formEstEntradaMercPesquisa.ShowDialog();
            if (Dr == DialogResult.OK)
            {
                _Fornecedor = formEstEntradaMercPesquisa.FFornecedor;
                txtFornecedor.Text = formEstEntradaMercPesquisa.FFornecedor.nomerazao;
                _entradaMercadoria = formEstEntradaMercPesquisa.FEntradaDB;
                dtAbertura.Value = formEstEntradaMercPesquisa.FEntradaDTO.dataabertura;
                dtConclusao.Value = formEstEntradaMercPesquisa.FEntradaDTO.dataconclusao;
                txtFrete.Text = formEstEntradaMercPesquisa.FEntradaDTO.vlrfrete.ToString();
                txtOutrosCustos.Text = formEstEntradaMercPesquisa.FEntradaDTO.outroscustos.ToString();
                if (formEstEntradaMercPesquisa.FEntradaDTO.status == "EFE")
                    rbEfetivar.Checked = true;
                if (formEstEntradaMercPesquisa.FEntradaDTO.status == "PEN")
                    rbPendente.Checked = true;
                if (formEstEntradaMercPesquisa.FEntradaDTO.status == "CAN")
                    rbCancelar.Checked = true;
                txtInfAdicionais.Text = formEstEntradaMercPesquisa.FEntradaDTO.infadicionais;
                //Carregar produtos
                _produtosGrid = _entradaController.ListaItens(formEstEntradaMercPesquisa.FEntradaDTO.identradamerc);
                DGVProdutos.DataSource = null;
                DGVProdutos.DataSource = _produtosGrid;
                CalculaTotais();
                AjeitaCamposGrid();
                HabilitaAcao(TipoAcao.Confirmar, true);
            }
            else
                cancelaOperacao();
        }

        private void btnAcaoConsultar_Click(object sender, EventArgs e)
        {            
            FormEstEntradaMercPesquisa formEstEntradaMercPesquisa = new FormEstEntradaMercPesquisa();
            EntradaMercadoriaController controle = new EntradaMercadoriaController();            
            var Dr =  formEstEntradaMercPesquisa.ShowDialog();
            if(Dr == DialogResult.OK)
            {
                txtFornecedor.Text = formEstEntradaMercPesquisa.FFornecedor.nomerazao;
                dtAbertura.Value = formEstEntradaMercPesquisa.FEntradaDTO.dataabertura;
                dtConclusao.Value = formEstEntradaMercPesquisa.FEntradaDTO.dataconclusao;
                txtFrete.Text = formEstEntradaMercPesquisa.FEntradaDTO.vlrfrete.ToString("N2");
                txtOutrosCustos.Text = formEstEntradaMercPesquisa.FEntradaDTO.outroscustos.ToString("N2");
                if (formEstEntradaMercPesquisa.FEntradaDTO.status == "EFE")
                    rbEfetivar.Checked = true;
                if (formEstEntradaMercPesquisa.FEntradaDTO.status == "PEN")
                    rbPendente.Checked = true;
                if (formEstEntradaMercPesquisa.FEntradaDTO.status == "CAN")
                    rbCancelar.Checked = true;
                txtInfAdicionais.Text = formEstEntradaMercPesquisa.FEntradaDTO.infadicionais;
                //Carregar produtos
                _produtosGrid = controle.ListaItens(formEstEntradaMercPesquisa.FEntradaDTO.identradamerc);
                DGVProdutos.DataSource = null;
                DGVProdutos.DataSource = _produtosGrid;
                CalculaTotais();
                AjeitaCamposGrid();                   
            }
            else
                cancelaOperacao();
        }

        private void btnAcaoExcluir_Click(object sender, EventArgs e)
        {
            FormEstEntradaMercPesquisa formEstEntradaMercPesquisa = new FormEstEntradaMercPesquisa();
            _entradaController = new EntradaMercadoriaController();          
            formEstEntradaMercPesquisa.VerificaStatus("Excluindo");
            var Dr = formEstEntradaMercPesquisa.ShowDialog();
            if (Dr == DialogResult.OK)
            {
                txtFornecedor.Text = formEstEntradaMercPesquisa.FFornecedor.nomerazao;
                _entradaMercadoria = formEstEntradaMercPesquisa.FEntradaDB;
                dtAbertura.Value = formEstEntradaMercPesquisa.FEntradaDTO.dataabertura;
                dtConclusao.Value = formEstEntradaMercPesquisa.FEntradaDTO.dataconclusao;
                txtFrete.Text = formEstEntradaMercPesquisa.FEntradaDTO.vlrfrete.ToString("N2");
                txtOutrosCustos.Text = formEstEntradaMercPesquisa.FEntradaDTO.outroscustos.ToString("N2");
                if (formEstEntradaMercPesquisa.FEntradaDTO.status == "EFE")
                    rbEfetivar.Checked = true;
                if (formEstEntradaMercPesquisa.FEntradaDTO.status == "PEN")
                    rbPendente.Checked = true;
                if (formEstEntradaMercPesquisa.FEntradaDTO.status == "CAN")
                    rbCancelar.Checked = true;
                txtInfAdicionais.Text = formEstEntradaMercPesquisa.FEntradaDTO.infadicionais;
                //Carregar produtos
                _produtosGrid = _entradaController.ListaItens(formEstEntradaMercPesquisa.FEntradaDTO.identradamerc);
                DGVProdutos.DataSource = null;
                DGVProdutos.DataSource = _produtosGrid;
                HabilitaAcao(TipoAcao.Confirmar, true);
                CalculaTotais();
                AjeitaCamposGrid();
            }
            else 
                cancelaOperacao();
        }

        private void txtVlrUnit_Leave(object sender, EventArgs e)
        {
            if (_produto == null)
            {
                MessageBox.Show("Selecione um produto.");
                txtProduto.Focus();
            }
            else if ((txtVlrUnit.Text == string.Empty) || txtVlrUnit.Text == "0,00" || txtVlrUnit.Text == "0")
            {
                MessageBox.Show("Campo valor unitário não pode ser igual a 0 \n selecione o produto novamente");
                txtProduto.Focus();
            }
            else
            {
                //Recalcula();
                RecalculaTotal();
                txtVlrDesc.Focus();
            }
        }

        private void txtVlrDesc_Leave(object sender, EventArgs e)
        {
            if (_produto == null)
            {
                MessageBox.Show("Selecione o produto.");
                txtProduto.Focus();
                return;
            }

            if (txtVlrTotal.Text == string.Empty || (txtVlrTotal.Text == "0,00") || (txtVlrTotal.Text == "0"))
            {
                MessageBox.Show("Selecione o produto.");
                txtProduto.Focus();
                return;
            }

            //Recalcula();
            RecalculaTotal();
        }


        private void txtVlrDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {   
                if(_produto == null)
                {
                    MessageBox.Show("Selecione o produto.");
                    txtProduto.Focus();
                }
                else if (txtVlrTotal.Text == string.Empty || (txtVlrTotal.Text == "0,00") || (txtVlrTotal.Text == "0"))
                {
                    MessageBox.Show("Selecione o produto.");
                    txtProduto.Focus();
                }
                else
                {
                    Recalcula();
                    txtVlrTotal.Focus();
                }                
            }
        }

        private void txtVlrTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {   
                if(_produto == null)
                {
                    MessageBox.Show("Selecione o produto.");
                    txtProduto.Focus();
                }
                else if(txtVlrUnit.Text == string.Empty || (txtVlrUnit.Text == "0,00") || (txtVlrUnit.Text == "0"))
                {
                    MessageBox.Show("Selecione o produto.");
                    txtProduto.Focus();
                }
                else                               
                    txtVlrVenda.Focus();
            }
        }
        private void CalculaTotais()
        {           
            _totalBruto = 0.00;
            _totalDesconto = 0.00;
            _totalLiquido = 0.00;
            foreach (ProdutosGrid prod in _produtosGrid)
            {
                _totalBruto = _totalBruto + (prod.vlrUnitario * prod.quantidade);
                Math.Truncate(_totalBruto);
                _totalDesconto += prod.desconto;
                _totalProduto += prod.vlrUnitario;
            }
            if(txtOutrosCustos.Text != string.Empty) 
                _totalBruto += Convert.ToDouble(txtOutrosCustos.Text);
            if(txtFrete.Text != string.Empty)
                _totalBruto += Convert.ToDouble(txtFrete.Text);
           
            _totalLiquido = _totalBruto - _totalDesconto;

            lblTotalBruto.Text = _totalBruto.ToString("N2");            
            lblDescontos.Text = _totalDesconto.ToString("N2");           
            lblTotalLiquido.Text = _totalLiquido.ToString("N2");
        }
       
    }
}
