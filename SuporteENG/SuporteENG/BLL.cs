using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace SuporteENG
{

        class ClassOrcamento{

        private int idorcamento;
        private string cliente, data;


        DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "progengenharia");

        public int IDORCAMENTO
        {
            get { return idorcamento; }
            set { idorcamento = value; }
        }

        public string CLIENTE
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string DATA
        {
            get { return data; }
            set { data = value; }
        }

        public void NovoOrcamento()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}'", IDORCAMENTO, CLIENTE, DATA);
                dao.Inserir_dados("orcamento", valores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable NumeroOrcamento()
        {
            try
            {
                return dao.Visualizar_Dados("orcamento", "max(id)");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public DataTable ListaCliente()
        {
            try
            {
                string condicao = string.Format("cliente LIKE '%{0}%'", CLIENTE);
                return dao.Visualizar_Dados("orcamento", "id as Id, cliente as Cliente, date(data) as Data", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Lista()
        {
            try
            {
                return dao.Visualizar_Dados("orcamento", "id as Id, cliente as Cliente, date(data) as Data");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListaData()
        {
            try
            {
                string condicao = string.Format("date(data) = '{0}'", DATA);
                return dao.Visualizar_Dados("orcamento", "id as Id, cliente as Cliente, date(data) as Data", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable RetornaValor()
        {
            try
            {
                string condicao = string.Format("orcamento_id = '{0}'", IDORCAMENTO);
                return dao.Visualizar_Dados("itens_orcamento JOIN produtos ON produtos_id = produtos.id", "sum(quantidade) * produtos.valor", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
    }

        class ClassItensOrcamento
    {
        private int produtosid, orcamentoid, quantidade;
        private string data, cliente;


        DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "progengenharia");

        public int PRODUTOSID
        {
            get { return produtosid; }
            set { produtosid = value; }
        }
        public int ORCAMENTOID
        {
            get { return orcamentoid; }
            set { orcamentoid = value; }
        }
        public int QUANTIDADE
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public string DATA
        {
            get { return data; }
            set { data = value; }
        }
        public string CLIENTE
        {
            get { return cliente; }
            set { cliente = value; }
        }


        public void NovosItens()
        {
            try
            {
                string valores = string.Format("'{0}','{1}','{2}'", PRODUTOSID, QUANTIDADE, ORCAMENTOID);
                dao.Inserir_dados("itens_orcamento", valores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarProduto()
        {
            try
            {
                string valores = string.Format("quantidade = quantidade + '{0}'", QUANTIDADE);
                string condicao = string.Format("orcamento_id = '{0}' and produtos_id = '{1}'", ORCAMENTOID, PRODUTOSID);
                dao.Alterar_dados("itens_orcamento", valores, condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListaItens()
        {
            try
            {
                string condicao = string.Format("orcamento_id = '{0}' group by produtos_id", ORCAMENTOID);
                return dao.Visualizar_Dados("itens_orcamento JOIN produtos ON produtos_id = produtos.id", "orcamento_id as 'Id Orçamento', produtos_id as 'Id Produto', produtos.descricao 'Nome Produto', produtos.codproduto as 'Código Produto', sum(itens_orcamento.quantidade) * produtos.valor as 'Preço', sum(itens_orcamento.quantidade) as 'Quantidade'", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarQuantidade()
        {
            try
            {
                string valores = string.Format("quantidade = '{0}'", QUANTIDADE);
                string condicao = string.Format("orcamento_id = '{0}' and produtos_id = '{1}'", ORCAMENTOID, PRODUTOSID);
                dao.Alterar_dados("itens_orcamento", valores, condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirProdutoItem()
        {
            try
            {
                string condicao = string.Format("orcamento_id = '{0}' and produtos_id = '{1}'", ORCAMENTOID, PRODUTOSID);
                dao.Excluir_dados("itens_orcamento", condicao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

        class ClassItensKit
        {

            private int iditens, produtosid, kitid, quantidade;
            private string descricaoconsulta;

            DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "progengenharia");

            public int IDITENS
            {
                get { return iditens; }
                set { iditens = value; }
            }

            public int PRODUTOSID
            {
                get { return produtosid; }
                set { produtosid = value; }
            }

            public string DESCRICAOCONSULTA
            {
                get { return descricaoconsulta; }
                set { descricaoconsulta = value; }
            }

            public int KITID
            {
                get { return kitid; }
                set { kitid = value; }
            }

            public int QUANTIDADE
            {
                get { return quantidade; }
                set { quantidade = value; }
            }

            public void NovoItensKit()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}','{2}','{3}'", IDITENS, PRODUTOSID, KITID, QUANTIDADE);
                    dao.Inserir_dados("prod_kit", valores);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void AlterarItensKit()
            {
                try
                {
                    string valores = string.Format("produtos_id = '{0}', kit_id = '{1}', quantidade = '{2}'", PRODUTOSID, KITID, QUANTIDADE);
                    string condicao = string.Format("id = '{0}'", IDITENS);
                    dao.Alterar_dados("prod_kit", valores, condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarKit()
            {
                try
                {
                    return dao.Visualizar_Dados("kit");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosItensKit()
            {
                try
                {
                    return dao.Visualizar_Dados("prod_kit JOIN kit ON kit_id = kit.id JOIN produtos ON produtos_id = produtos.id", "prod_kit.id as 'Id Itens', produtos.id as 'ID Produto', produtos.codproduto as 'COD Produto', produtos.descricao as 'Nome Produto',  quantidade as Quandtidade, kit.id as 'ID Kit', kit.descricao as 'Descrição Kit'");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosItensKitProduto()
            {
                try
                {

                    string condicao = string.Format("produtos.descricao LIKE '%{0}%'", DESCRICAOCONSULTA);
                    return dao.Visualizar_Dados("prod_kit JOIN kit ON kit_id = kit.id JOIN produtos ON produtos_id = produtos.id", "prod_kit.id as 'Id Itens', produtos.id as 'ID Produto', produtos.codproduto as 'COD Produto', produtos.descricao as 'Nome Produto',  quantidade as Quandtidade, kit.id as 'ID Kit', kit.descricao as 'Descrição Kit'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosItensKitNome()
            {
                try
                {

                    string condicao = string.Format("kit.descricao LIKE '%{0}%'", DESCRICAOCONSULTA);
                    return dao.Visualizar_Dados("prod_kit JOIN kit ON kit_id = kit.id JOIN produtos ON produtos_id = produtos.id", "prod_kit.id as 'Id Itens', produtos.id as 'ID Produto', produtos.codproduto as 'COD Produto', produtos.descricao as 'Nome Produto',  quantidade as Quandtidade, kit.id as 'ID Kit', kit.descricao as 'Descrição Kit'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosItensKitId()
            {
                try
                {
                    string condicao = string.Format("prod_kit.id = '{0}'", IDITENS);
                    return dao.Visualizar_Dados("prod_kit JOIN kit ON kit_id = kit.id JOIN produtos ON produtos_id = produtos.id", "prod_kit.id as 'Id Itens', produtos.id as 'ID Produto', produtos.codproduto as 'COD Produto', produtos.descricao as 'Nome Produto',  quantidade as Quandtidade, kit.id as 'ID Kit', kit.descricao as 'Descrição Kit'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosItensKitIdKit()
            {
                try
                {
                    string condicao = string.Format("kit.id = '{0}'", KITID);
                    return dao.Visualizar_Dados("prod_kit JOIN kit ON kit_id = kit.id JOIN produtos ON produtos_id = produtos.id", "prod_kit.id as 'Id Itens', produtos.id as 'ID Produto', produtos.codproduto as 'COD Produto', produtos.descricao as 'Nome Produto',  quantidade as Quandtidade, kit.id as 'ID Kit', kit.descricao as 'Descrição Kit'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosItensKitIdProduto()
            {
                try
                {
                    string condicao = string.Format("produtos.id = '{0}'", PRODUTOSID);
                    return dao.Visualizar_Dados("prod_kit JOIN kit ON kit_id = kit.id JOIN produtos ON produtos_id = produtos.id", "prod_kit.id as 'Id Itens', produtos.id as 'ID Produto', produtos.codproduto as 'COD Produto', produtos.descricao as 'Nome Produto',  quantidade as Quandtidade, kit.id as 'ID Kit', kit.descricao as 'Descrição Kit'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable RetornoProdutos()
            {
                try
                {
                    string condicao = string.Format("kit_id = '{0}'", KITID);
                    return dao.Visualizar_Dados("prod_kit join produtos on produtos_id = produtos.id", "produtos.id, quantidade", condicao);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ExcluirItensKit()
            {
                try
                {
                    string condicao = string.Format("id = '{0}'", IDITENS);
                    dao.Excluir_dados("prod_kit", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        class ClassProdutos
        {

            private int idproduto;
            private string descricao, codproduto;
            private double valor;


            public double VALOR
            {
                get { return valor; }
                set { valor = value; }
            }
            public int IDPRODUTO
            {
                get { return idproduto; }
                set { idproduto = value; }
            }
            public string DESCRICAO
            {
                get { return descricao; }
                set { descricao = value; }
            }

            public string CODPRODUTO
            {
                get { return codproduto; }
                set { codproduto = value; }
            }

            DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "progengenharia");

            public void NovoProduto()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}','{2}','{3}'", IDPRODUTO, CODPRODUTO, DESCRICAO, VALOR.ToString().Replace(',', '.'));
                    dao.Inserir_dados("produtos", valores);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void AlterarProduto()
            {
                try
                {
                    string valores = string.Format("codproduto = '{0}', descricao = '{1}',valor = '{2}'", CODPRODUTO, DESCRICAO, VALOR.ToString().Replace(',', '.'));
                    string condicao = string.Format("id = '{0}'", IDPRODUTO);
                    dao.Alterar_dados("produtos", valores, condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ExcluirProduto()
            {
                try
                {
                    string condicao = string.Format("id = '{0}'", IDPRODUTO);
                    dao.Excluir_dados("produtos", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosProdutos()
            {
                try
                {
                    return dao.Visualizar_Dados("produtos");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable PesquisarProdutoID()
            {
                try
                {
                    string condicao = string.Format("id = '{0}'", IDPRODUTO);
                    return dao.Visualizar_Dados("produtos", "*", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable PesquisarProdutoCodigo()
            {
                try
                {
                    string condicao = string.Format("codproduto LIKE '%{0}%'", CODPRODUTO);
                    return dao.Visualizar_Dados("produtos", "*", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public DataTable PesquisarProdutoDescricao()
            {
                try
                {
                    string condicao = string.Format("descricao LIKE '%{0}%'", DESCRICAO);
                    return dao.Visualizar_Dados("produtos", "*", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        class ClassKit
        {
            private int idkit, combinacaoid;
            private string descricao, combinacaonome;

            DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "progengenharia");

            public string DESCRICAO
            {
                get { return descricao; }
                set { descricao = value; }
            }

            public string COMBINACAONOME
            {
                get { return combinacaonome; }
                set { combinacaonome = value; }
            }

            public int IDKIT
            {
                get { return idkit; }
                set { idkit = value; }
            }

            public int COMBINACAOID
            {
                get { return combinacaoid; }
                set { combinacaoid = value; }
            }

            public void NovoKit()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}','{2}'", IDKIT, DESCRICAO, COMBINACAOID);
                    dao.Inserir_dados("kit", valores);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public void AlterarKit()
            {
                try
                {
                    string valores = string.Format("descricao = '{0}', combinacao_id = '{1}'", DESCRICAO, COMBINACAOID);
                    string condicao = string.Format("id = '{0}'", IDKIT);
                    dao.Alterar_dados("kit", valores, condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizar()
            {
                try
                {
                    //return dao.Visualizar_Dados("kit");
                    return dao.Visualizar_Dados("kit", "id as ID, descricao as 'Descrição'");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarId()
            {
                try
                {
                    string condicao = string.Format("id = '{0}'", IDKIT);
                    return dao.Visualizar_Dados("kit", "id as ID, descricao as 'Descrição'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarNome()
            {
                try
                {
                    string condicao = string.Format("descricao LIKE '%{0}%'", DESCRICAO);
                    return dao.Visualizar_Dados("kit", "id as ID, descricao as 'Descrição'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarKitCombinacao()
            {
                try
                {
                    string condicao = string.Format("combinacao_id = '{0}'", COMBINACAOID);
                    return dao.Visualizar_Dados("kit", "id, descricao", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public DataTable visualizarTodosKits()
            {
                try
                {
                    //return dao.Visualizar_Dados("kit");
                    return dao.Visualizar_Dados("kit JOIN combinacao ON combinacao_id = combinacao.id", "kit.id as ID, kit.descricao as 'Descrição', combinacao.id as 'ID Combinação', combinacao.nome as 'Combinação'");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosKitsId()
            {
                try
                {
                    string condicao = string.Format("kit.id = '{0}'", IDKIT);
                    return dao.Visualizar_Dados("kit JOIN combinacao ON combinacao_id = combinacao.id", "kit.id as ID, kit.descricao as 'Descrição', combinacao.id as 'ID Combinação', combinacao.nome as 'Combinação'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosKitsDesc()
            {
                try
                {
                    string condicao = string.Format("descricao LIKE '%{0}%'", DESCRICAO);
                    return dao.Visualizar_Dados("kit JOIN combinacao ON combinacao_id = combinacao.id", "kit.id as ID, kit.descricao as 'Descrição', combinacao.id as 'ID Combinação', combinacao.nome as 'Combinação'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosKitsComb()
            {
                try
                {
                    string condicao = string.Format("combinacao.nome LIKE '%{0}%'", COMBINACAONOME);
                    return dao.Visualizar_Dados("kit JOIN combinacao ON combinacao_id = combinacao.id", "kit.id as ID, kit.descricao as 'Descrição', combinacao.id as 'ID Combinação', combinacao.nome as 'Combinação'", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ExcluirCombinacao()
            {
                try
                {
                    string condicao = string.Format("id = '{0}'", IDKIT);
                    dao.Excluir_dados("kit", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }

        class ClassCombinacao
        {
            private int idcombinacao, subsistemaid;
            private string nome;


            DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "progengenharia");

            public int SUBSISTEMAID
            {
                get { return subsistemaid; }
                set { subsistemaid = value; }
            }

            public int IDCOMBINACAO
            {
                get { return idcombinacao; }
                set { idcombinacao = value; }
            }
            public string NOME
            {
                get { return nome; }
                set { nome = value; }
            }


            public DataTable visualizarCombSubs()
            {
                try
                {
                    string condicao = string.Format("subsistemas.id = '{0}'", SUBSISTEMAID);
                    return dao.Visualizar_Dados("combinacao JOIN subsistemas ON subsistemas.id = subsistemas_id", "combinacao.id, combinacao.nome", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void NovaCombinacao()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}','{2}'", IDCOMBINACAO, NOME, SUBSISTEMAID);
                    dao.Inserir_dados("combinacao", valores);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void AlterarCombinacao()
            {
                try
                {
                    string valores = string.Format("nome = '{0}', subsistemas_id = '{1}'", NOME, SUBSISTEMAID);
                    string condicao = string.Format("id = '{0}'", IDCOMBINACAO);
                    dao.Alterar_dados("combinacao", valores, condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodasCombinacao()
            {
                try
                {
                    return dao.Visualizar_Dados("combinacao");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodasCombinacaoNomeSub()
            {
                try
                {
                    return dao.Visualizar_Dados("combinacao JOIN subsistemas ON subsistemas_id = subsistemas.id", "combinacao.id as 'Id Comb', combinacao.nome as 'Nome Comb', subsistemas_id as 'Id Subs', subsistemas.nome as 'Nome Subs'");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ExcluirCombinacao()
            {
                try
                {
                    string condicao = string.Format("id = '{0}'", IDCOMBINACAO);
                    dao.Excluir_dados("combinacao", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        class ClassSubsistemas
        {
            private int idsubsistema;
            private string nome;

            DAO_Mysql dao = new DAO_Mysql("localhost", "root", "", "progengenharia");

            public int IDSUBSISTEMA
            {
                get { return idsubsistema; }
                set { idsubsistema = value; }
            }
            public string NOME
            {
                get { return nome; }
                set { nome = value; }
            }

            public void NovaSubsistema()
            {
                try
                {
                    string valores = string.Format("'{0}','{1}'", IDSUBSISTEMA, NOME);
                    dao.Inserir_dados("subsistemas", valores);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void AlterarSubsistema()
            {
                try
                {
                    string valores = string.Format("nome = '{0}'", NOME);
                    string condicao = string.Format("id = '{0}'", IDSUBSISTEMA);
                    dao.Alterar_dados("subsistemas", valores, condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable visualizarTodosSubsistemas()
            {
                try
                {
                    return dao.Visualizar_Dados("subsistemas");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void ExcluirSubsistema()
            {
                try
                {
                    string condicao = string.Format("id = '{0}'", IDSUBSISTEMA);
                    dao.Excluir_dados("subsistemas", condicao);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
