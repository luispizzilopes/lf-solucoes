using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFSOLUCOES
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        
        //Declaração de variáveis que serão utilizadas para carregar o nome do computador e nome de usuário do sistema
        string nome_pc = System.Windows.Forms.SystemInformation.ComputerName;
        string nome_usuario_sistema = System.Windows.Forms.SystemInformation.UserName.ToString(); 
        
        //Declaração de variável para resultado de conexão de internet
        string resultado_internet = "";
 
        //Função de teste de internet
        public void Teste_Internet()
        {
            System.Uri Url = new System.Uri("http://www.google.com/");
            System.Net.WebRequest WebRequest;
            WebRequest = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse objResp;
            //Tente
            try
            {
                objResp = WebRequest.GetResponse();
                resultado_internet = "Seu dispositvo está conectado corretamente a internet";
                objResp.Close();
                WebRequest = null;
            }
            //Caso não seja possível
            catch (Exception ex)
            {
                resultado_internet = "Erro ao tentar se conectar a internet" + ex.Message;
                WebRequest = null;
            }
        }

        //Função de alterar o texto na tela de carregamento (label conectando)
        public void AlterarLabelConectando()
        {
            if (BarraDeCarregamento_Splash.Value > 25 && BarraDeCarregamento_Splash.Value < 50)
            {
                lbl_conectando.Text = "Conectando com a internet..";
            }
            if (BarraDeCarregamento_Splash.Value > 50 && BarraDeCarregamento_Splash.Value < 75)
            {
                lbl_conectando.Text = "Conectando com a internet...";
            }
            if (BarraDeCarregamento_Splash.Value > 75 && BarraDeCarregamento_Splash.Value < 100)
            {
                lbl_conectando.Text = "Conectando com a internet....";
            }
        }

        //Função de fechar o aplicativo na tela de carregamento
        private void lbl_botaodefechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        //Função para carregar a ProgressBar e acessar a tela principal
        private void timer_splash_Tick(object sender, EventArgs e)
        {
            //Acionar a função de Teste de internet
            Teste_Internet(); 
            //Adicionar valor para barra de carregamento da tela de splash
            if (BarraDeCarregamento_Splash.Value < 100) //Enquanto a progressBar for menor que 100, o Timer vai adicionar +5 no valor
            {
                //Adicionar +5 no valor da barra de carregamento
                BarraDeCarregamento_Splash.Value = BarraDeCarregamento_Splash.Value + 10;
                //Alterar o texto do label de conectando
                AlterarLabelConectando(); 
            }
            else
            {
                if (resultado_internet == "Seu dispositvo está conectado corretamente a internet")
                {
                    //Declaração de variável do menu principal
                    Menu_Principal MenuPrincipal = new Menu_Principal(); 
                    //Chamar função de exibir Windows Form na tela
                    MenuPrincipal.Show(); 
                    this.Dispose(false);
                    //Parar o timer
                    timer_splash.Stop(); 
                }
                else   
                {
                    timer_splash.Stop(); //Timer para
                    //Mensagem de texto na tela do usuário
                    MessageBox.Show("Verefique sua conexão com a internet e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Aplicação fecha
                    Application.Exit(); 
                }
            }
        }

            //Mudar a cor para cor original quando o mouse sair de cima do Label
            private void lbl_conectando_MouseLeave(object sender, EventArgs e)
            {
                lbl_conectando.ForeColor = Color.White;
            }
            //Mudar a cor do botão quando passar o mouse por cima
            private void lbl_conectando_MouseMove(object sender, MouseEventArgs e)
            {
                lbl_conectando.ForeColor = Color.DodgerBlue;
            }
    }
}
