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

namespace LFSOLUCOES
{
    public partial class Sugestoes : Form
    {
        public Sugestoes()
        {
            InitializeComponent();
        }

        //Conjunto de instruções painel superior do Form   
        //Botão de fechar       
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        
        //Conjunto de instruções formulário principal
        //Botão de enviar a seguestão
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (txtBox_mensagem.Text != "")
            {
                //Enviar email para informar a mensagem do usuário
                MailMessage Mymail = new MailMessage();
                SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
                //email
                Mymail.From = new MailAddress("lfsolucoesdescalvado@gmail.com");
                //receber 
                Mymail.To.Add("lfsolucoesdescalvado@gmail.com");
                //Nome do email recebido 
                Mymail.Subject = ("L.F SOLUÇÕES - Sugestões");
                //Conteudo 
                Mymail.Body = ("Sugestão / Observação: " + txtBox_mensagem.Text);
                smtpserver.Port = (587);
                smtpserver.Credentials = new System.Net.NetworkCredential("lfsolucoesdescalvado@gmail.com", "elffqwvlsdmozgtr");
                smtpserver.EnableSsl = true;
                smtpserver.Send(Mymail);
                //Interação com o usuário
                MessageBox.Show("Agradecemos a sua sugestão!", "Agredacimento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Limpar caixa de texto
                txtBox_mensagem.Text = "";
            }
            else
            {
                MessageBox.Show("Escreva uma mensagem para enviar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }  
    }
}
