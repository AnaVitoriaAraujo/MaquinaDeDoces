using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MaquinaDeDoces
{
    class Produto
    {
        //Definição de variaveis
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        //Metodo construtor = ele nao tem tipo de dado sem parameetro porque eu dei valor a eles
        public Produto()
        {
            ModificarCodigo = 0;
            ModificarNome = "";
            ModificarDescricao = "";
            Modificarpreco = 0;
            ModificarQuantidade = 0;
            ModificarDataValidade = new DateTime();// valor padão do date time é 000/00/00 00:00:00 e new você chama
            ModificarSituacao = false;

        }// fim do metodo contrutor

        public Produto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {

        ModificarCodigo = codigo;// this é usado para  fazer referencias a variavel e indentificar qual é o parametro
        ModificarNome    =nome;// modificar para não usar a variavel diretamente emcapsular ela
        ModificarDescricao = descricao;
        Modificarpreco = preco;
        ModificarQuantidade = quantidade;
        ModificarDataValidade = dtValidade;
        ModificarSituacao = situacao;
        }//fim do metodo contrutor com parametros

        // Metodos Get e Set 
        //metodos de acesso e modificacao
        public int ModificarCodigo //toda vez que uma outra classe quiser modificar codigo ele usara esse metodo eel serve para consultar e modificar
        {
            get{ // o metodo get e set não tem parametro()
                return this .codigo;
           
            }//fim do get - retornar o codigo

            set{
                this.codigo = value;
            
            }// fim do modificacao
        }//fim do modificarcodigo

        public string ModificarNome
        {
            get {
                return this.nome; 
            }
            set 
            { 
                this.nome = value; 
            }

        }//fim da modificacao

        public string ModificarDescricao
        {
            get{
                return this.descricao;
            }

            set
            {
                this.descricao = value;
            }
        }//fim do modificar descricao

        public double Modificarpreco
        {
            get
            {
                return this.preco;
            }
            set
            {
                this.preco = value;
            }
        }// Fim do modificar preco

        public int ModificarQuantidade
        {
            get
            {
                return this.quantidade;
            }
            set
            {
                this.quantidade = value;
            }
        }//fim do modificarquantidade

        public DateTime ModificarDataValidade

        {
            get
            {
                return this.dtValidade; 
            }
            set
            {
                this .dtValidade = value;
            }
        }

        public Boolean ModificarSituacao
        {
            get { return this.situacao; }
            set { this.situacao = value; }
        }


        //metodo cadastrarproduto

        public void CadastrarProduto(
            int codigo,
            string nome,
            double preco,
            int quantidade,
            DateTime dtValidade,
            Boolean situacao
            )
        {
            ModificarCodigo = codigo;// um igual é atribuir
            ModificarNome= nome;
            ModificarDescricao = descricao;
            Modificarpreco = preco;
            ModificarQuantidade= quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;

        }//fim do metodo cadastrar produto

        // consultar produto

        public string ConsultarProduto(int codigo)
        {
            string msg = "";//criando uma variavel local não presia do public pq ja tem

            if (ModificarCodigo == codigo)// esse dois é comparando
            {
                msg = "\nCodigo: " + ModificarCodigo +
                       "\nNome: " + ModificarNome +
                       "\nDescricao: " + ModificarDescricao +
                       "n\Preço:" + Modificarpreco +
                       "n\Quantidade" + ModificarQuantidade +
                       "\nData de Validae: " + ModificarDataValidade +
                       "\nSituação: " + ModificarSituacao;
                                
            }
            else
            {
                msg = "O codigo digitado não existe!";
            }

            return msg;

        }//fim do metodo

        //Metodo de atualizar

        public Boolean AtualizarProduto(int codigo, int campo, string novoDado)
        {
            Boolean flag = false;
            if (ModificarCodigo == codigo)
            {
                switch (campo)
                {
                    case 1:
                        ModificarNome = novoDado;
                        flag = true;
                        break;
                    case 2:
                        ModificarDescricao = novoDado;
                        flag = true;
                        break;
                    case 3:
                        Modificarpreco = Convert.ToDouble(novoDado);//convertendo para real e ultizando ele
                        flag = true;
                        break;
                    case 4:
                        ModificarQuantidade = Convert.ToInt32(novoDado);
                        flag = true;
                        break;
                    case 5:
                        ModificarDataValidade = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;
                    case 6:
                        ModificarSituacao = Convert.ToBoolean(novoDado);
                        flag = true
                        break;
                    default:
                        break;


                }//fim do escolha
                return flag;
            }//fim do if
            return flag;
        }//fim do atulaizar produto

        public void AlterarSituacao(int codigo)
        {
            Boolean flag = false;
            if (ModificarCodigo == codigo)
            {
                if (ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                }
                else {
                    ModificarSituacao situacao = true;
                }//fim do modificar situacao
                flag = true;
            }//fim do moficar codigo
            return flag;

        }//fim do alterar situacao

        public Boolean SolicitarProduto(int codigo)
        {
            if(ModificarCodigo == codigo)
            {
                if(ModificarQuantidade <=3)

                {
                   return true;
                }                   
            }//fim do if
            return false;
           
        }// fim do solicitar produto

    }// fim da classe
}// fim do projeto
