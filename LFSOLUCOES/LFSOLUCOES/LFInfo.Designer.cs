namespace LFSOLUCOES
{
    partial class LFInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LFInfo));
            this.panel_superior = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_LF = new System.Windows.Forms.Label();
            this.lbl_lfsolucoes = new System.Windows.Forms.Label();
            this.panel_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel_superior.Controls.Add(this.btn_fechar);
            this.panel_superior.Controls.Add(this.lbl_LF);
            this.panel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_superior.Location = new System.Drawing.Point(0, 0);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(396, 34);
            this.panel_superior.TabIndex = 5;
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
            // lbl_LF
            // 
            this.lbl_LF.AutoSize = true;
            this.lbl_LF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LF.ForeColor = System.Drawing.Color.White;
            this.lbl_LF.Location = new System.Drawing.Point(7, 8);
            this.lbl_LF.Name = "lbl_LF";
            this.lbl_LF.Size = new System.Drawing.Size(117, 18);
            this.lbl_LF.TabIndex = 0;
            this.lbl_LF.Text = "L.F SOLUÇÕES";
            // 
            // lbl_lfsolucoes
            // 
            this.lbl_lfsolucoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_lfsolucoes.AutoSize = true;
            this.lbl_lfsolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lfsolucoes.ForeColor = System.Drawing.Color.White;
            this.lbl_lfsolucoes.Location = new System.Drawing.Point(38, 67);
            this.lbl_lfsolucoes.Name = "lbl_lfsolucoes";
            this.lbl_lfsolucoes.Size = new System.Drawing.Size(319, 40);
            this.lbl_lfsolucoes.TabIndex = 6;
            this.lbl_lfsolucoes.Text = "Software desenvolvido por L.F SOLUÇÕES.\r\n               Versão do software: 3.0";
            // 
            // LFInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(396, 142);
            this.Controls.Add(this.lbl_lfsolucoes);
            this.Controls.Add(this.panel_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LFInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LFInfo";
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_LF;
        private System.Windows.Forms.Label lbl_lfsolucoes;
    }
}