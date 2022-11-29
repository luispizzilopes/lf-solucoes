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
    public partial class Chamado_aberto : Form
    {
        public Chamado_aberto()
        {
            InitializeComponent();
        }

        //Botão de fechar a janela da aplicação
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
