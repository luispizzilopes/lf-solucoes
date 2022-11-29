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
    public partial class Informe_os_dados : Form
    {
        public Informe_os_dados()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Informe_os_dados informeosdados = new Informe_os_dados();
            Visible = false;
        }
    }
}
