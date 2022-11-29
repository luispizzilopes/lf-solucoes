namespace LFSOLUCOES
{
    partial class Sugestoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sugestoes));
            this.painel_superior = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txtBox_mensagem = new System.Windows.Forms.TextBox();
            this.lbl_informacao = new System.Windows.Forms.Label();
            this.painel_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_superior
            // 
            this.painel_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.painel_superior.Controls.Add(this.btn_fechar);
            this.painel_superior.Controls.Add(this.label1);
            this.painel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_superior.Location = new System.Drawing.Point(0, 0);
            this.painel_superior.Name = "painel_superior";
            this.painel_superior.Size = new System.Drawing.Size(450, 34);
            this.painel_superior.TabIndex = 3;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(416, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(34, 34);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "L.F SOLUÇÕES";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_enviar.FlatAppearance.BorderSize = 0;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.Location = new System.Drawing.Point(318, 241);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(122, 29);
            this.btn_enviar.TabIndex = 23;
            this.btn_enviar.Text = "Enviar ";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txtBox_mensagem
            // 
            this.txtBox_mensagem.BackColor = System.Drawing.Color.White;
            this.txtBox_mensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_mensagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBox_mensagem.Location = new System.Drawing.Point(10, 68);
            this.txtBox_mensagem.Multiline = true;
            this.txtBox_mensagem.Name = "txtBox_mensagem";
            this.txtBox_mensagem.Size = new System.Drawing.Size(430, 167);
            this.txtBox_mensagem.TabIndex = 22;
            // 
            // lbl_informacao
            // 
            this.lbl_informacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_informacao.AutoSize = true;
            this.lbl_informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacao.ForeColor = System.Drawing.Color.White;
            this.lbl_informacao.Location = new System.Drawing.Point(6, 42);
            this.lbl_informacao.Name = "lbl_informacao";
            this.lbl_informacao.Size = new System.Drawing.Size(314, 20);
            this.lbl_informacao.TabIndex = 21;
            this.lbl_informacao.Text = "Escreva sua sugestão / observação abaixo:";
            // 
            // Sugestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(450, 279);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txtBox_mensagem);
            this.Controls.Add(this.lbl_informacao);
            this.Controls.Add(this.painel_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sugestoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sugestoes";
            this.painel_superior.ResumeLayout(false);
            this.painel_superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painel_superior;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txtBox_mensagem;
        private System.Windows.Forms.Label lbl_informacao;
    }
}