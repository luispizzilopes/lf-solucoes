namespace LFSOLUCOES
{
    partial class Informe_os_dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe_os_dados));
            this.painel_superior = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_lf = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.painel_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_superior
            // 
            this.painel_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.painel_superior.Controls.Add(this.btn_fechar);
            this.painel_superior.Controls.Add(this.lbl_lf);
            this.painel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_superior.Location = new System.Drawing.Point(0, 0);
            this.painel_superior.Name = "painel_superior";
            this.painel_superior.Size = new System.Drawing.Size(396, 34);
            this.painel_superior.TabIndex = 2;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(362, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(34, 34);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_lf
            // 
            this.lbl_lf.AutoSize = true;
            this.lbl_lf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lf.ForeColor = System.Drawing.Color.White;
            this.lbl_lf.Location = new System.Drawing.Point(7, 8);
            this.lbl_lf.Name = "lbl_lf";
            this.lbl_lf.Size = new System.Drawing.Size(117, 18);
            this.lbl_lf.TabIndex = 0;
            this.lbl_lf.Text = "L.F SOLUÇÕES";
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.White;
            this.lbl_info.Location = new System.Drawing.Point(60, 71);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(280, 24);
            this.lbl_info.TabIndex = 3;
            this.lbl_info.Text = "Informe os dados para continuar";
            // 
            // Informe_os_dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(396, 142);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.painel_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informe_os_dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe_os_dados";
            this.painel_superior.ResumeLayout(false);
            this.painel_superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painel_superior;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_lf;
        private System.Windows.Forms.Label lbl_info;
    }
}