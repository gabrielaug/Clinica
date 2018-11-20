namespace Cliente
{
    partial class TelaPrestador
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Codigo"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Nome");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("CPF");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Telefone");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Nr_Conselho");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Ativo");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CdPrestador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNmPrestador = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.Label();
            this.cpfprestador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NrConselho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonePrestador = new System.Windows.Forms.TextBox();
            this.CADASTRAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Prestadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CÓDIGO";
            // 
            // CdPrestador
            // 
            this.CdPrestador.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CdPrestador.Location = new System.Drawing.Point(72, 74);
            this.CdPrestador.Margin = new System.Windows.Forms.Padding(2);
            this.CdPrestador.Name = "CdPrestador";
            this.CdPrestador.Size = new System.Drawing.Size(76, 26);
            this.CdPrestador.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOME";
            // 
            // txtNmPrestador
            // 
            this.txtNmPrestador.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmPrestador.Location = new System.Drawing.Point(72, 110);
            this.txtNmPrestador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNmPrestador.Name = "txtNmPrestador";
            this.txtNmPrestador.Size = new System.Drawing.Size(553, 26);
            this.txtNmPrestador.TabIndex = 4;
            this.txtNmPrestador.TextChanged += new System.EventHandler(this.NmPrestador_TextChanged);
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(9, 145);
            this.CPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(35, 20);
            this.CPF.TabIndex = 5;
            this.CPF.Text = "CPF";
            // 
            // cpfprestador
            // 
            this.cpfprestador.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfprestador.Location = new System.Drawing.Point(72, 142);
            this.cpfprestador.Margin = new System.Windows.Forms.Padding(2);
            this.cpfprestador.Name = "cpfprestador";
            this.cpfprestador.Size = new System.Drawing.Size(150, 26);
            this.cpfprestador.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "NR CONSELHO";
            // 
            // NrConselho
            // 
            this.NrConselho.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrConselho.Location = new System.Drawing.Point(329, 145);
            this.NrConselho.Margin = new System.Windows.Forms.Padding(2);
            this.NrConselho.Name = "NrConselho";
            this.NrConselho.Size = new System.Drawing.Size(84, 26);
            this.NrConselho.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TelefonePrestador
            // 
            this.TelefonePrestador.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonePrestador.Location = new System.Drawing.Point(498, 147);
            this.TelefonePrestador.Margin = new System.Windows.Forms.Padding(2);
            this.TelefonePrestador.Name = "TelefonePrestador";
            this.TelefonePrestador.Size = new System.Drawing.Size(128, 26);
            this.TelefonePrestador.TabIndex = 10;
            // 
            // CADASTRAR
            // 
            this.CADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CADASTRAR.Location = new System.Drawing.Point(665, 73);
            this.CADASTRAR.Margin = new System.Windows.Forms.Padding(2);
            this.CADASTRAR.Name = "CADASTRAR";
            this.CADASTRAR.Size = new System.Drawing.Size(113, 25);
            this.CADASTRAR.TabIndex = 11;
            this.CADASTRAR.Text = "CADASTRAR";
            this.CADASTRAR.UseVisualStyleBackColor = true;
            this.CADASTRAR.Click += new System.EventHandler(this.CADASTRAR_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(665, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "ATUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(665, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "INATIVAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(665, 195);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 55);
            this.button3.TabIndex = 14;
            this.button3.Text = "CONSULTAR / LISTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(12, 176);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(613, 210);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TelaPrestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 392);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CADASTRAR);
            this.Controls.Add(this.TelefonePrestador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NrConselho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cpfprestador);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.txtNmPrestador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CdPrestador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaPrestador";
            this.Text = "TelaPrestador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CdPrestador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNmPrestador;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.TextBox cpfprestador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NrConselho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelefonePrestador;
        private System.Windows.Forms.Button CADASTRAR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
    }
}