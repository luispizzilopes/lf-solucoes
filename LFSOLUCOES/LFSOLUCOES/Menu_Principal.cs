using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Diagnostics;

namespace LFSOLUCOES
{
    public partial class Menu_Principal : Form
    {
        //Função de número aleátorio
        string gerar_chamado()
        {
            //Declaração das variáveis e atribuições
            Random random = new Random();
            int soma, resto; 
            string div; 
            int n1 = random.Next(0, 10);
            int n2 = random.Next(0, 10);
            int n3 = random.Next(0, 10);
            int n4 = random.Next(0, 10);
            int n5 = random.Next(0, 10);
            //Processamento
            soma = (n1 * 2) + (n2 * 2) + (n3 * 2) + (n4 * 2) + (n5 * 2);
            resto = soma % 11;
            if (resto == 0)
            {
                div = "0";
            }
            else if (resto == 1)
            {
                div = "1";
            }
            else
            {
               div = (11 - resto).ToString();
            }
            //Retorno do valor da string
            return n1.ToString() + n2 + n3 + n4 + n5 + div; 
        }

        //Função acesso ao email da LF
        public void servidor_lf()
        {
            MailMessage Mymail = new MailMessage();
            SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
            //email
            Mymail.From = new MailAddress("lfsolucoesdescalvado@gmail.com");
            //receber 
            Mymail.To.Add("lfsolucoesdescalvado@gmail.com");
            //Nome do email recebido 
            Mymail.Subject = ("L.F Soluções Empresas - Acesso");
            //Conteudo 
            Mymail.Body = ("Acesso ao sistema");
            smtpserver.Port = (587);
            smtpserver.Credentials = new System.Net.NetworkCredential("", "");
            smtpserver.EnableSsl = true;
            smtpserver.Send(Mymail);
        }
     
        //Função de solicitar serviço e string do serviço
        public string servico;
        public void selecao_servico()
        {
            string codigo = gerar_chamado(); 
            lbl_numchamado.Text = "Chamado número: " + codigo;

            //para pessoa
            MailMessage Mymail1 = new MailMessage();
            SmtpClient smtpserver1 = new SmtpClient("smtp.gmail.com");
            //email
            Mymail1.From = new MailAddress("lfsolucoesdescalvado@gmail.com");
            //receber 
            Mymail1.To.Add(txtBox_email.Text);
            //Nome do email recebido 
            Mymail1.Subject = ("L.F SOLUÇÕES - CHAMADO ABERTO");
            //Conteudo 
            Mymail1.Body = ("Olá " + txtBox_nomecliente.Text + ", o código do seu chamado é: " + codigo + " Solicitou: " + servico);
            smtpserver1.Port = (587);
            smtpserver1.Credentials = new System.Net.NetworkCredential("", "");
            smtpserver1.EnableSsl = true;
            smtpserver1.Send(Mymail1);

            //para mim
            MailMessage Mymail = new MailMessage();
            SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
            //email
            Mymail.From = new MailAddress("lfsolucoesdescalvado@gmail.com");
            //receber 
            Mymail.To.Add("lfsolucoesdescalvado@gmail.com");
            //Nome do email recebido 
            Mymail.Subject = ("L.F SOLUÇÕES - Entrar em contato");
            //Conteudo 
            Mymail.Body = ("Cliente: " + txtBox_nomecliente.Text + " Código do chamado: " + codigo + " Solicitou: " + servico);
            smtpserver.Port = (587);
            smtpserver.Credentials = new System.Net.NetworkCredential("", "");
            smtpserver.EnableSsl = true;
            smtpserver.Send(Mymail);

            //Inoformativo de chamado aberto
            Chamado_aberto chamadoaberto = new Chamado_aberto();
            chamadoaberto.Show();
        }
        
        //Função de cancelar um serviço
        public void cancelar_servico()
        {
            //para pessoa
            MailMessage Mymail1 = new MailMessage();
            SmtpClient smtpserver1 = new SmtpClient("smtp.gmail.com");
            //email
            Mymail1.From = new MailAddress("lfsolucoesdescalvado@gmail.com");
            //receber 
            Mymail1.To.Add(txtBox_email.Text);
            //Nome do email recebido 
            Mymail1.Subject = ("L.F SOLUÇÕES - CHAMADO CANCELADO");
            //Conteudo 
            Mymail1.Body = ("Olá " + txtBox_nomecliente.Text + "! " + lbl_numchamado.Text + " foi cancelado.");
            smtpserver1.Port = (587);
            smtpserver1.Credentials = new System.Net.NetworkCredential("", "");
            smtpserver1.EnableSsl = true;
            smtpserver1.Send(Mymail1);

            //para mim
            MailMessage Mymail = new MailMessage();
            SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
            //email
            Mymail.From = new MailAddress("lfsolucoesdescalvado@gmail.com");
            //receber 
            Mymail.To.Add("lfsolucoesdescalvado@gmail.com");
            //Nome do email recebido 
            Mymail.Subject = ("L.F SOLUÇÕES - CHAMADO CANCELADO");
            //Conteudo 
            Mymail.Body = ("Cliente: " + txtBox_nomecliente.Text + " cancelou o " + lbl_numchamado.Text);
            smtpserver.Port = (587);
            smtpserver.Credentials = new System.Net.NetworkCredential("", "");
            smtpserver.EnableSsl = true;
            smtpserver.Send(Mymail);
        }

        //Função de chamar/inicializar o Menu Principal 
        public Menu_Principal()
        {
            InitializeComponent();
        }


        //Conjunto de instruções Painel superior do sistema
        //Botão de fechar a aplicação
        private void btn_botaodefechar_Click(object sender, EventArgs e)
        {
            if (lbl_numchamado.Text == "Nenhum chamado aberto!")
            {
                Application.Exit();
            }
            else
            {
               if ((MessageBox.Show("Você tem um chamado aberto, caso encerre a aplicação o chamado será encerrado, deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
               {
                   //chamar a função para cancelar o chamado
                   cancelar_servico();
                   //encerrar o sistema
                   Application.Exit();
               }
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Conjunto de instruções GroupBox informações do usuário
        //String de controle de acesso
        public string acesso;
        //Função do botão de confirmar as informações
        private void btn_confirmarinfo_Click(object sender, EventArgs e)
        {
            if (txtBox_nomecliente.Text != "" && txtBox_whatsapp.Text != "" && txtBox_email.Text != "" && txtBox_cemail.Text != "" && txtBox_email.Text == txtBox_cemail.Text && this.txtBox_email.Text.Contains("@") && this.txtBox_cemail.Text.Contains("@"))
            {
                //Acessar a solicitação de chamados
                servidor_lf();
                //Mostrar que foi realizado o acesso
                lbl_acesso.Text = "Acesso realizado com sucesso";
                acesso = "1"; 
                //Travar os objetos do GroupBox de informações
                txtBox_cemail.Enabled = false;
                txtBox_email.Enabled = false;
                txtBox_nomecliente.Enabled = false;
                txtBox_whatsapp.Enabled = false;
                btn_confirmarinfo.Enabled = false;

                //Salvar informações digitadas pelo o usuário
                Properties.Settings.Default.Email = txtBox_email.Text;
                Properties.Settings.Default.Nome = txtBox_nomecliente.Text;
                Properties.Settings.Default.NumeroWhatsapp = txtBox_whatsapp.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                lbl_acesso.Text = "Tente novamente";
            }
        }

        //Ação quando o formulário principal abrir
        private void Menu_Principal_Shown(object sender, EventArgs e)
        {
            txtBox_email.Text = Properties.Settings.Default.Email;
            txtBox_cemail.Text = Properties.Settings.Default.Email;
            txtBox_nomecliente.Text = Properties.Settings.Default.Nome;
            txtBox_whatsapp.Text = Properties.Settings.Default.NumeroWhatsapp;
        }

        //Ação para o TextBox permitir apenas numeros e limitar a quantidade de caracteres
        private void txtBox_whatsapp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento KeyPress
            txtBox_whatsapp.MaxLength = 11; 
            // Números [0,9], Backspace, e decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }


        //Conjunto de instruções GroupBox serviços
        //RadioButton outro serviço selecionado
        private void rB_outro_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_outro.Checked)
            {
                txtBox_outroservico.Enabled = true;
                txtBox_outroservico.Text = "Digite aqui o serviço!";
            }
            else
            {
                txtBox_outroservico.Enabled = false;
                txtBox_outroservico.Text = "";
            }
        }
        //Botão de abrir chamado
        private void btn_abrirchamado_Click(object sender, EventArgs e)
        {
            //Condição verificar se os dados foram informados
            //Caso, não tenham sido informados
            if (acesso != "1")
            {
                Informe_os_dados informeosdados = new Informe_os_dados();
                informeosdados.Show(); 
            }
            //Caso, tenham sido informados
            if (acesso == "1" && lbl_numchamado.Text == "Nenhum chamado aberto!")
            {
                if (rB_formatacao.Checked)
                {
                    servico = "Formatação";
                    selecao_servico();
                }
                else if (rB_formatacaoebackup.Checked)
                {
                    servico = "Formatação e backup";
                    selecao_servico();
                }
                else if (rB_rdesoftware.Checked)
                {
                    servico = "Reparo de software";
                    selecao_servico();
                }
                else if (rB_instalacao_de_so.Checked)
                {
                    servico = "Instalação de SO";
                    selecao_servico();
                }
                else if (rB_backup.Checked)
                {
                    servico = "Backup";
                    selecao_servico();
                }
                else if (rB_remocaodevirus.Checked)
                {
                    servico = "Remoção de Vírus";
                    selecao_servico();
                }
                else if (rB_completo.Checked)
                {
                    servico = "Diagnóstico completo";
                    selecao_servico();
                }
                else if (rB_outro.Checked)
                {
                    servico = txtBox_outroservico.Text;
                    selecao_servico();
                }
            }
        }
        
        //Instrução Label do número do chamado para ser marcados como concluido
        private void lbl_numchamado_Click(object sender, EventArgs e)
        {
            if (lbl_numchamado.Text != "Nenhum chamado aberto!" && VariaveisGlobais.senha_de_valicao == "0")
            {
                Area_de_validacao areavalidacao = new Area_de_validacao();
                areavalidacao.Show();
            }
        }

        //Botão finalizar chamado
        public void btn_finalizarchamado_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.senha_de_valicao == "1")
            {
                MessageBox.Show("Chamado finalizado com sucesso", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lbl_numchamado.Text = "Nenhum chamado aberto!";
                VariaveisGlobais.senha_de_valicao = "0"; 
            } 
        }

        //Mudar a cor do label do número de chamado quando o mouse passar por cima
        private void lbl_numchamado_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_numchamado.ForeColor = Color.DodgerBlue;
        }
        private void lbl_numchamado_MouseLeave(object sender, EventArgs e)
        {
            lbl_numchamado.ForeColor = Color.White;
        }

        //Botão de receber atualizações via email informado
        private void btn_cliqueparareceber_Click(object sender, EventArgs e)
        {
            //Condição de verificar se os dados foram informados
            if (acesso == "1")
            {
                //Mensagem na tela do usuário
                MessageBox.Show("Você vai receber um email na sua caixa de mensagens dentro de alguns instantes, confirmando a solicitação!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Enviar um e-mail
                //para pessoa
                MailMessage Mymail1 = new MailMessage();
                SmtpClient smtpserver1 = new SmtpClient("smtp.gmail.com");
                //email
                Mymail1.From = new MailAddress("lfsolucoesdescalvado@gmail.com");
                //receber 
                Mymail1.To.Add(txtBox_email.Text);
                //Nome do email recebido 
                Mymail1.Subject = ("L.F SOLUÇÕES - ATUALIZAÇÕES E INFORMAÇÕES VIA EMAIL");
                //Conteudo 
                Mymail1.Body = ("Olá " + txtBox_nomecliente.Text + ", você vai receber informações e atualizações do nosso sistema por via desse Email!");
                smtpserver1.Port = (587);
                smtpserver1.Credentials = new System.Net.NetworkCredential("lfsolucoesdescalvado@gmail.com", "elffqwvlsdmozgtr");
                smtpserver1.EnableSsl = true;
                smtpserver1.Send(Mymail1);
            }
            else
            {
                Informe_os_dados informeosdados = new Informe_os_dados();
                informeosdados.Show();
            }
        }

        //Conjunto de instruções GroupBox Sobre LF
        //Comando do Label de localização
        private void lbl_localizacao_Click(object sender, EventArgs e)
        {
            //Abrir o navegador com o link do Maps
            System.Diagnostics.Process.Start("https://www.google.com/search?authuser=1&sxsrf=ALeKk02fS0wFGZ-czA-bKSSW3XfcmoC9lg%3A1615997943667&source=hp&ei=9ytSYKubJubY5OUPmNyrEA&iflsig=AINFCbYAAAAAYFI6B3nTi9fs5j1ZniRWFoG9O57OPeiZ&q=L.F%20SOLU%C3%87%C3%95ES&oq=me&gs_lcp=Cgdnd3Mtd2l6EAMYADIECCMQJzIECCMQJzIECCMQJzIICAAQsQMQgwEyCAgAELEDEIMBMggIABCxAxCDATIICAAQsQMQgwEyBQgAELEDMgUIABCxAzICCAA6DggAELEDEIMBEMcBEKMCOggILhCxAxCDAToCCC46CwgAELEDEMcBEK8BOgUILhCxA1CBNli5O2D5Q2gBcAB4AIABeIgBtgKSAQMyLjGYAQCgAQGqAQdnd3Mtd2l6&sclient=gws-wiz&ludocid=7283169912938478580&lsig=AB86z5X5qRs73HS-IWpeOPB0v9Yx&ved=2ahUKEwjfobG_3bfvAhUAHLkGHYkyD0QQrMcEegQIBhAE"); 
        }
        //Alterar cor do label quando o mouse passar por cima
        private void lbl_localizacao_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_localizacao.ForeColor = Color.DodgerBlue;
        }

        private void lbl_localizacao_MouseLeave(object sender, EventArgs e)
        {
            lbl_localizacao.ForeColor = Color.White;
        }

        //Comando do Label com o número do Whatsapp
        private void lbl_whatscontato_Click(object sender, EventArgs e)
        {
            //Abrir navegador com o link do Whatsapp
            System.Diagnostics.Process.Start("http://api.whatsapp.com/send?1=pt_BR&phone=5519991305972"); 
        }
        //Alterar com do label quando o mouse passar por cima
        private void lbl_whatscontato_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_whatscontato.ForeColor = Color.DodgerBlue;
        }

        private void lbl_whatscontato_MouseLeave(object sender, EventArgs e)
        {
            lbl_whatscontato.ForeColor = Color.White;
        } 

        //Comando do Label com o email da LF
        private void lbl_emaillf_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:lfsolucoesdescalvado@gmail.com");
        }
        //Mudar com do Label quando o mouse passar por cima
        private void lbl_emaillf_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_emaillf.ForeColor = Color.DodgerBlue;
        }
        private void lbl_emaillf_MouseLeave(object sender, EventArgs e)
        {
            lbl_emaillf.ForeColor = Color.White;
        }

        //Comando do Label de sugestões
        private void lbl_sugestao_Click(object sender, EventArgs e)
        {
            //Condição para verificar se foi informado os dados
            if (acesso == "1")
            {
                Sugestoes sugestoes = new Sugestoes();
                sugestoes.Show();
            }
            else
            {
                Informe_os_dados informeosdados = new Informe_os_dados();
                informeosdados.Show(); 
            }
        }
        //Mudar com do Label quando o mouse passar por cima
        private void lbl_sugestao_MouseLeave(object sender, EventArgs e)
        {
            lbl_sugestao.ForeColor = Color.White;
        }
        private void lbl_sugestao_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_sugestao.ForeColor = Color.DodgerBlue;
        }

        //Botão de abrir a página no Facebook 
        private void btn_facebook_Click(object sender, EventArgs e)
        {
            //Abrir a página do facebook pelo navegador padrão do sistema
            System.Diagnostics.Process.Start("https://www.facebook.com/lfsolucoestecnicas");
        }

        //Conjunto de instruções painel lateral
        //Botão de mais informações
        private void btn_infolf_Click(object sender, EventArgs e)
        {
            //Abrir o Form LF Info
            LFInfo FormLF = new LFInfo();
            FormLF.Show(); 
        }
    }
}
