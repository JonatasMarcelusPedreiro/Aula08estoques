using System.Web;

namespace Aula08Estoque
{
    public partial class Form1 : Form
    {
        //Varáveis globais//


        List<string> produtoNome = new List<string>();
        List<int> produtoQuantidade= new List<int>();

        Utilidades utilidades = new Utilidades();

        public Form1()
        {
            InitializeComponent();
        }

        //Minhas funções//

        void adicionaProduto()
        {

            if(utilidades.textBoxEstaVazio(txtnome)== true)
            {

                MessageBox.Show(" O nome está vazio");
                return;



            }


            if (utilidades.txtVazio(txtquantidade) == true)
            {


                MessageBox.Show(" Quantidade está vazia");
                return;
            }



            string nome = txtnome.Text;
            int quantidade = int.Parse ( txtquantidade.Text);
            produtoNome.Add (nome);
            produtoQuantidade.Add (quantidade);
        }
        



        void atualizaInterface()
        {
            //Contsbiliza a quantidade cadastrada//
            int quantidadecadastrada = produtoNome.Count();
            lblcadastros.Text = quantidadecadastrada.ToString();

            // contabiliza todos produtos em estoque//
            //FOR: a váriavel controladora ; condição ; incrementar o contador//
            int estoque = 0;
            for(int i = 0; i < produtoQuantidade.Count; i++)
            {

                int quantidade = produtoQuantidade[i];
                estoque += quantidade;




            }
            lblquantidade.Text = estoque.ToString();

        }
        
        void LimpaCampos()
        {


            //Clear serve para apagar algo//

            txtnome.Clear();
            txtquantidade.Clear();
            txtnome.Focus();



        }

        void verProduto( bool primeiro )
        {

            if ( ListaEstaVazia() == true)
            {

                MessageBox.Show(" Você não pode ver a lista ainda....");
                    return;




            }

            string nome;
            int quantidade;


            if ( primeiro == true ) 
            
            {

                nome = produtoNome[0];
                quantidade = produtoQuantidade[0];
            
            
            
            }
            else
            {

                nome = produtoNome[ produtoNome.Count() - 1];
                quantidade = produtoQuantidade[ produtoQuantidade.Count() - 1];




            }


            MessageBox.Show($" Nome: {nome} , Quantidade: {quantidade}");





        }

        void Remover()
        {
           if( ListaEstaVazia() == true)
            {


                MessageBox.Show("Você não pode remover");



            }
            else
            {

                produtoNome.RemoveAt(0);
                produtoQuantidade.RemoveAt(0);



            }
            
            
           
            atualizaInterface();

            

            
        



        }


        bool ListaEstaVazia()
        {

            if (produtoNome.Count() > 0)
            {

                return false;



            }
            else
            {

                return true;
            }

        }


        //------------------

        private void button1_Click(object sender, EventArgs e)
        {
            adicionaProduto();
            atualizaInterface();


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

            LimpaCampos();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            verProduto(false);







        }

        private void btndeletar_Click(object sender, EventArgs e)
        {


            Remover();  


        }

        private void button3_Click(object sender, EventArgs e)
        {
           verProduto(false);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            utilidades.mostraMensagem();

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

           
               

            




        }
    }
}