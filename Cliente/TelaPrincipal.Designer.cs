namespace Cliente
{
    partial class TelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prestadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convenioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.atendimentoToolStripMenuItem,
            this.pacienteToolStripMenuItem1,
            this.prestadorToolStripMenuItem,
            this.convenioToolStripMenuItem,
            this.tipoConsultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.pacienteToolStripMenuItem.Text = "Agendamento";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            // 
            // pacienteToolStripMenuItem1
            // 
            this.pacienteToolStripMenuItem1.Name = "pacienteToolStripMenuItem1";
            this.pacienteToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.pacienteToolStripMenuItem1.Text = "Paciente";
            // 
            // prestadorToolStripMenuItem
            // 
            this.prestadorToolStripMenuItem.Name = "prestadorToolStripMenuItem";
            this.prestadorToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.prestadorToolStripMenuItem.Text = "Prestador";
            this.prestadorToolStripMenuItem.Click += new System.EventHandler(this.prestadorToolStripMenuItem_Click);
            // 
            // convenioToolStripMenuItem
            // 
            this.convenioToolStripMenuItem.Name = "convenioToolStripMenuItem";
            this.convenioToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.convenioToolStripMenuItem.Text = "Convenio";
            // 
            // tipoConsultaToolStripMenuItem
            // 
            this.tipoConsultaToolStripMenuItem.Name = "tipoConsultaToolStripMenuItem";
            this.tipoConsultaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.tipoConsultaToolStripMenuItem.Text = "Tipo Consulta";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prestadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convenioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoConsultaToolStripMenuItem;
    }
}