namespace LFSOLUCOES
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.Painel_superior = new System.Windows.Forms.Panel();
            this.lbl_botaodefechar = new System.Windows.Forms.Label();
            this.lbl_lf = new System.Windows.Forms.Label();
            this.BarraDeCarregamento_Splash = new System.Windows.Forms.ProgressBar();
            this.timer_splash = new System.Windows.Forms.Timer(this.components);
            this.lbl_informativo = new System.Windows.Forms.Label();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.lbl_conectando = new System.Windows.Forms.Label();
            this.Painel_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_superior
            // 
            this.Painel_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Painel_superior.Controls.Add(this.lbl_botaodefechar);
            this.Painel_superior.Controls.Add(this.lbl_lf);
            this.Painel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Painel_superior.Location = new System.Drawing.Point(0, 0);
            this.Painel_superior.Name = "Painel_superior";
            this.Painel_superior.Size = new System.Drawing.Size(510, 35);
            this.Painel_superior.TabIndex = 2;
            // 
            // lbl_botaodefechar
            // 
            this.lbl_botaodefechar.AutoSize = true;
            this.lbl_botaodefechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_botaodefechar.ForeColor = System.Drawing.Color.White;
            this.lbl_botaodefechar.Location = new System.Drawing.Point(483, 6);
            this.lbl_botaodefechar.Name = "lbl_botaodefechar";
            this.lbl_botaodefechar.Size = new System.Drawing.Size(24, 24);
            this.lbl_botaodefechar.TabIndex = 10;
            this.lbl_botaodefechar.Text = "X";
            this.lbl_botaodefechar.Click += new System.EventHandler(this.lbl_botaodefechar_Click);
            // 
            // lbl_lf
            // 
            this.lbl_lf.AutoSize = true;
            this.lbl_lf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lf.ForeColor = System.Drawing.Color.White;
            this.lbl_lf.Location = new System.Drawing.Point(7, 7);
            this.lbl_lf.Name = "lbl_lf";
            this.lbl_lf.Size = new System.Drawing.Size(260, 24);
            this.lbl_lf.TabIndex = 2;
            this.lbl_lf.Text = "L.F SOLUÇÕES COMERCIAL";
            // 
            // BarraDeCarregamento_Splash
            // 
            this.BarraDeCarregamento_Splash.Location = new System.Drawing.Point(44, 85);
            this.BarraDeCarregamento_Splash.Name = "BarraDeCarregamento_Splash";
            this.BarraDeCarregamento_Splash.Size = new System.Drawing.Size(439, 23);
            this.BarraDeCarregamento_Splash.TabIndex = 11;
            this.BarraDeCarregamento_Splash.Visible = false;
            // 
            // timer_splash
            // 
            this.timer_splash.Enabled = true;
            this.timer_splash.Interval = 1;
            this.timer_splash.Tick += new System.EventHandler(this.timer_splash_Tick);
            // 
            // lbl_informativo
            // 
            this.lbl_informativo.AutoSize = true;
            this.lbl_informativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informativo.ForeColor = System.Drawing.Color.White;
            this.lbl_informativo.Location = new System.Drawing.Point(6, 42);
            this.lbl_informativo.Name = "lbl_informativo";
            this.lbl_informativo.Size = new System.Drawing.Size(468, 30);
            this.lbl_informativo.TabIndex = 14;
            this.lbl_informativo.Text = "Notas de atualização: correção de bugs e otimização do sistema.\r\n-Problemas com o" +
    " nosso software? contate o suporte via WhatsApp: (19)99130-5972";
            // 
            // lbl_versao
            // 
            this.lbl_versao.AutoSize = true;
            this.lbl_versao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versao.ForeColor = System.Drawing.Color.White;
            this.lbl_versao.Location = new System.Drawing.Point(12, 109);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(53, 24);
            this.lbl_versao.TabIndex = 15;
            this.lbl_versao.Text = "V 3.0";
            // 
            // lbl_conectando
            // 
            this.lbl_conectando.AutoSize = true;
            this.lbl_conectando.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conectando.ForeColor = System.Drawing.Color.White;
            this.lbl_conectando.Location = new System.Drawing.Point(250, 113);
            this.lbl_conectando.Name = "lbl_conectando";
            this.lbl_conectando.Size = new System.Drawing.Size(242, 24);
            this.lbl_conectando.TabIndex = 16;
            this.lbl_conectando.Text = "Conectando com a internet.";
            this.lbl_conectando.MouseLeave += new System.EventHandler(this.lbl_conectando_MouseLeave);
            this.lbl_conectando.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_conectando_MouseMove);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(510, 142);
            this.Controls.Add(this.BarraDeCarregamento_Splash);
            this.Controls.Add(this.lbl_conectando);
            this.Controls.Add(this.lbl_versao);
            this.Controls.Add(this.lbl_informativo);
            this.Controls.Add(this.Painel_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de carregamento";
            this.Painel_superior.ResumeLayout(false);
            this.Painel_superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Painel_superior;
        private System.Windows.Forms.Label lbl_botaodefechar;
        private System.Windows.Forms.Label lbl_lf;
        private System.Windows.Forms.Timer timer_splash;
        private System.Windows.Forms.ProgressBar BarraDeCarregamento_Splash;
        private System.Windows.Forms.Label lbl_informativo;
        private System.Windows.Forms.Label lbl_versao;
        private System.Windows.Forms.Label lbl_conectando;
    }
}

