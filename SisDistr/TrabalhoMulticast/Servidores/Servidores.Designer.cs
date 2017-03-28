namespace Servidores
{
	partial class Servidores
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
			this.ListaServers = new System.Windows.Forms.DataGridView();
			this.ServerNameLB = new System.Windows.Forms.Label();
			this.ServerName = new System.Windows.Forms.TextBox();
			this.Porta = new System.Windows.Forms.TextBox();
			this.PortaLB = new System.Windows.Forms.Label();
			this.OrigemBackUp = new System.Windows.Forms.TextBox();
			this.OrigemLB = new System.Windows.Forms.Label();
			this.ProcurarBT = new System.Windows.Forms.Button();
			this.SalvarLB = new System.Windows.Forms.Label();
			this.SalvarBT = new System.Windows.Forms.Button();
			this.SalvarEm = new System.Windows.Forms.TextBox();
			this.AdicionarBT = new System.Windows.Forms.Button();
			this.ServerNameDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PortaDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PastaOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PastaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Remover = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ListaServers)).BeginInit();
			this.SuspendLayout();
			// 
			// ListaServers
			// 
			this.ListaServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListaServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServerNameDesc,
            this.PortaDesc,
            this.PastaOrigem,
            this.PastaDestino});
			this.ListaServers.Location = new System.Drawing.Point(12, 12);
			this.ListaServers.Name = "ListaServers";
			this.ListaServers.RowHeadersVisible = false;
			this.ListaServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ListaServers.Size = new System.Drawing.Size(714, 411);
			this.ListaServers.TabIndex = 0;
			// 
			// ServerNameLB
			// 
			this.ServerNameLB.AutoSize = true;
			this.ServerNameLB.Location = new System.Drawing.Point(9, 433);
			this.ServerNameLB.Name = "ServerNameLB";
			this.ServerNameLB.Size = new System.Drawing.Size(93, 13);
			this.ServerNameLB.TabIndex = 1;
			this.ServerNameLB.Text = "Nome do servidor:";
			// 
			// ServerName
			// 
			this.ServerName.Location = new System.Drawing.Point(108, 429);
			this.ServerName.Name = "ServerName";
			this.ServerName.Size = new System.Drawing.Size(419, 20);
			this.ServerName.TabIndex = 2;
			// 
			// Porta
			// 
			this.Porta.Location = new System.Drawing.Point(598, 429);
			this.Porta.Name = "Porta";
			this.Porta.Size = new System.Drawing.Size(128, 20);
			this.Porta.TabIndex = 3;
			this.Porta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Porta_KeyPress);
			// 
			// PortaLB
			// 
			this.PortaLB.AutoSize = true;
			this.PortaLB.Location = new System.Drawing.Point(533, 433);
			this.PortaLB.Name = "PortaLB";
			this.PortaLB.Size = new System.Drawing.Size(59, 13);
			this.PortaLB.TabIndex = 4;
			this.PortaLB.Text = "Porta TCP:";
			// 
			// OrigemBackUp
			// 
			this.OrigemBackUp.Location = new System.Drawing.Point(88, 456);
			this.OrigemBackUp.Name = "OrigemBackUp";
			this.OrigemBackUp.ReadOnly = true;
			this.OrigemBackUp.Size = new System.Drawing.Size(202, 20);
			this.OrigemBackUp.TabIndex = 5;
			// 
			// OrigemLB
			// 
			this.OrigemLB.AutoSize = true;
			this.OrigemLB.Location = new System.Drawing.Point(10, 460);
			this.OrigemLB.Name = "OrigemLB";
			this.OrigemLB.Size = new System.Drawing.Size(76, 13);
			this.OrigemLB.TabIndex = 6;
			this.OrigemLB.Text = "Pasta backup:";
			// 
			// ProcurarBT
			// 
			this.ProcurarBT.Location = new System.Drawing.Point(299, 455);
			this.ProcurarBT.Name = "ProcurarBT";
			this.ProcurarBT.Size = new System.Drawing.Size(75, 23);
			this.ProcurarBT.TabIndex = 7;
			this.ProcurarBT.Text = "Procurar";
			this.ProcurarBT.UseVisualStyleBackColor = true;
			this.ProcurarBT.Click += new System.EventHandler(this.ProcurarBT_Click);
			// 
			// SalvarLB
			// 
			this.SalvarLB.AutoSize = true;
			this.SalvarLB.Location = new System.Drawing.Point(380, 460);
			this.SalvarLB.Name = "SalvarLB";
			this.SalvarLB.Size = new System.Drawing.Size(57, 13);
			this.SalvarLB.TabIndex = 9;
			this.SalvarLB.Text = "Salvar em:";
			// 
			// SalvarBT
			// 
			this.SalvarBT.Location = new System.Drawing.Point(652, 455);
			this.SalvarBT.Name = "SalvarBT";
			this.SalvarBT.Size = new System.Drawing.Size(75, 23);
			this.SalvarBT.TabIndex = 11;
			this.SalvarBT.Text = "Procurar";
			this.SalvarBT.UseVisualStyleBackColor = true;
			this.SalvarBT.Click += new System.EventHandler(this.SalvarBT_Click);
			// 
			// SalvarEm
			// 
			this.SalvarEm.Location = new System.Drawing.Point(443, 456);
			this.SalvarEm.Name = "SalvarEm";
			this.SalvarEm.ReadOnly = true;
			this.SalvarEm.Size = new System.Drawing.Size(202, 20);
			this.SalvarEm.TabIndex = 10;
			// 
			// AdicionarBT
			// 
			this.AdicionarBT.Location = new System.Drawing.Point(598, 484);
			this.AdicionarBT.Name = "AdicionarBT";
			this.AdicionarBT.Size = new System.Drawing.Size(128, 23);
			this.AdicionarBT.TabIndex = 12;
			this.AdicionarBT.Text = "Adicionar";
			this.AdicionarBT.UseVisualStyleBackColor = true;
			this.AdicionarBT.Click += new System.EventHandler(this.AdicionarBT_Click);
			// 
			// ServerNameDesc
			// 
			this.ServerNameDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ServerNameDesc.HeaderText = "Nome do servidor";
			this.ServerNameDesc.MinimumWidth = 200;
			this.ServerNameDesc.Name = "ServerNameDesc";
			this.ServerNameDesc.ReadOnly = true;
			// 
			// PortaDesc
			// 
			this.PortaDesc.HeaderText = "Porta";
			this.PortaDesc.MinimumWidth = 100;
			this.PortaDesc.Name = "PortaDesc";
			this.PortaDesc.ReadOnly = true;
			// 
			// PastaOrigem
			// 
			this.PastaOrigem.HeaderText = "Pasta de origem";
			this.PastaOrigem.MinimumWidth = 200;
			this.PastaOrigem.Name = "PastaOrigem";
			this.PastaOrigem.ReadOnly = true;
			this.PastaOrigem.Width = 200;
			// 
			// PastaDestino
			// 
			this.PastaDestino.HeaderText = "Pasta de destino";
			this.PastaDestino.MinimumWidth = 200;
			this.PastaDestino.Name = "PastaDestino";
			this.PastaDestino.ReadOnly = true;
			this.PastaDestino.Width = 200;
			// 
			// Remover
			// 
			this.Remover.Location = new System.Drawing.Point(13, 484);
			this.Remover.Name = "Remover";
			this.Remover.Size = new System.Drawing.Size(201, 23);
			this.Remover.TabIndex = 13;
			this.Remover.Text = "Remover servidor selecionado";
			this.Remover.UseVisualStyleBackColor = true;
			this.Remover.Click += new System.EventHandler(this.Remover_Click);
			// 
			// Servidores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 515);
			this.Controls.Add(this.Remover);
			this.Controls.Add(this.AdicionarBT);
			this.Controls.Add(this.SalvarBT);
			this.Controls.Add(this.SalvarEm);
			this.Controls.Add(this.SalvarLB);
			this.Controls.Add(this.ProcurarBT);
			this.Controls.Add(this.OrigemLB);
			this.Controls.Add(this.OrigemBackUp);
			this.Controls.Add(this.PortaLB);
			this.Controls.Add(this.Porta);
			this.Controls.Add(this.ServerName);
			this.Controls.Add(this.ServerNameLB);
			this.Controls.Add(this.ListaServers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Servidores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerenciador de servidores";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Servidores_FormClosed);
			this.Load += new System.EventHandler(this.Servidores_Load);
			this.Leave += new System.EventHandler(this.Servidores_Leave);
			((System.ComponentModel.ISupportInitialize)(this.ListaServers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView ListaServers;
		private System.Windows.Forms.Label ServerNameLB;
		private System.Windows.Forms.TextBox ServerName;
		private System.Windows.Forms.TextBox Porta;
		private System.Windows.Forms.Label PortaLB;
		private System.Windows.Forms.TextBox OrigemBackUp;
		private System.Windows.Forms.Label OrigemLB;
		private System.Windows.Forms.Button ProcurarBT;
		private System.Windows.Forms.Label SalvarLB;
		private System.Windows.Forms.Button SalvarBT;
		private System.Windows.Forms.TextBox SalvarEm;
		private System.Windows.Forms.Button AdicionarBT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServerNameDesc;
		private System.Windows.Forms.DataGridViewTextBoxColumn PortaDesc;
		private System.Windows.Forms.DataGridViewTextBoxColumn PastaOrigem;
		private System.Windows.Forms.DataGridViewTextBoxColumn PastaDestino;
		private System.Windows.Forms.Button Remover;
	}
}

