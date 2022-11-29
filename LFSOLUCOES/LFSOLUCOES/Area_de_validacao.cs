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
    public partial class Area_de_validacao : Form
    {
        public Area_de_validacao()
        {
            InitializeComponent();
        }

        //Botão verificar
        private void btn_confirmarinfo_Click(object sender, EventArgs e)
        {
            //Condicional para verificar a senha de acesso
            if (txtBox_senha.Text == "conexao120315")
            {
                //Definir o resultado da senha
                VariaveisGlobais.senha_de_valicao = "1"; 
                //Tirar do formulário
                Visible = false;
            }
            else
            {
                MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        //Botão de fechar a aplicação
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //Tirar do formulário
            Visible = false;
        }
    }
}
