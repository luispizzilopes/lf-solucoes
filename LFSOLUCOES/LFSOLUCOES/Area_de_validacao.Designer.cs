namespace LFSOLUCOES
{
    partial class Area_de_validacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_de_validacao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label_senhadeacesso = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txtBox_senha = new System.Windows.Forms.TextBox();
            this.btn_confirmarsenha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.label_senhadeacesso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 34);
            this.panel1.TabIndex = 5;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(331, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(34, 34);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label_senhadeacesso
            // 
            this.label_senhadeacesso.AutoSize = true;
            this.label_senhadeacesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senhadeacesso.ForeColor = System.Drawing.Color.White;
            this.label_senhadeacesso.Location = new System.Drawing.Point(7, 8);
            this.label_senhadeacesso.Name = "label_senhadeacesso";
            this.label_senhadeacesso.Size = new System.Drawing.Size(169, 18);
            this.label_senhadeacesso.TabIndex = 0;
            this.label_senhadeacesso.Text = "SENHA DE VALIDAÇÃO";
            // 
            // lbl_senha
            // 
            this.lbl_senha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.White;
            this.lbl_senha.Location = new System.Drawing.Point(12, 40);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(54, 18);
            this.lbl_senha.TabIndex = 24;
            this.lbl_senha.Text = "Senha:";
            // 
            // txtBox_senha
            // 
            this.txtBox_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtBox_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_senha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBox_senha.Location = new System.Drawing.Point(15, 61);
            this.txtBox_senha.Name = "txtBox_senha";
            this.txtBox_senha.PasswordChar = '•';
            this.txtBox_senha.Size = new System.Drawing.Size(338, 17);
            this.txtBox_senha.TabIndex = 23;
            // 
            // btn_confirmarsenha
            // 
            this.btn_confirmarsenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_confirmarsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_confirmarsenha.FlatAppearance.BorderSize = 0;
            this.btn_confirmarsenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmarsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmarsenha.ForeColor = System.Drawing.Color.White;
            this.btn_confirmarsenha.Location = new System.Drawing.Point(264, 84);
            this.btn_confirmarsenha.Name = "btn_confirmarsenha";
            this.btn_confirmarsenha.Size = new System.Drawing.Size(89, 27);
            this.btn_confirmarsenha.TabIndex = 25;
            this.btn_confirmarsenha.Text = "Confirmar";
            this.btn_confirmarsenha.UseVisualStyleBackColor = false;
            this.btn_confirmarsenha.Click += new System.EventHandler(this.btn_confirmarinfo_Click);
            // 
            // Area_de_validacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(365, 114);
            this.Controls.Add(this.btn_confirmarsenha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txtBox_senha);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Area_de_validacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area_de_validacao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label_senhadeacesso;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txtBox_senha;
        private System.Windows.Forms.Button btn_confirmarsenha;
    }
}