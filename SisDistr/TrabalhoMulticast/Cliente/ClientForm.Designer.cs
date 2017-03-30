namespace Cliente
{
	partial class ClientForm
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
			this.ListaServidores = new System.Windows.Forms.DataGridView();
			this.ServidorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServerIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServerPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PastaOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PastaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Start = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ListaServidores)).BeginInit();
			this.SuspendLayout();
			// 
			// ListaServidores
			// 
			this.ListaServidores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ListaServidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListaServidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServidorName,
            this.ServerIP,
            this.ServerPort,
            this.PastaOrigem,
            this.PastaDestino});
			this.ListaServidores.Location = new System.Drawing.Point(12, 12);
			this.ListaServidores.Name = "ListaServidores";
			this.ListaServidores.RowHeadersVisible = false;
			this.ListaServidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ListaServidores.Size = new System.Drawing.Size(760, 504);
			this.ListaServidores.TabIndex = 0;
			// 
			// ServidorName
			// 
			this.ServidorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ServidorName.HeaderText = "Nome do servidor";
			this.ServidorName.MinimumWidth = 300;
			this.ServidorName.Name = "ServidorName";
			this.ServidorName.ReadOnly = true;
			// 
			// ServerIP
			// 
			this.ServerIP.HeaderText = "IP do servidor";
			this.ServerIP.MinimumWidth = 150;
			this.ServerIP.Name = "ServerIP";
			this.ServerIP.ReadOnly = true;
			this.ServerIP.Width = 150;
			// 
			// ServerPort
			// 
			this.ServerPort.HeaderText = "Porta do servidor";
			this.ServerPort.MinimumWidth = 120;
			this.ServerPort.Name = "ServerPort";
			this.ServerPort.ReadOnly = true;
			this.ServerPort.Width = 120;
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
			// Start
			// 
			this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Start.Location = new System.Drawing.Point(12, 527);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(120, 23);
			this.Start.TabIndex = 1;
			this.Start.Text = "Iniciar bakcup";
			this.Start.UseVisualStyleBackColor = true;
			this.Start.Click += new System.EventHandler(this.Start_Click);
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.Start);
			this.Controls.Add(this.ListaServidores);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "ClientForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClientForm";
			this.Load += new System.EventHandler(this.ClientForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ListaServidores)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView ListaServidores;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServidorName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServerIP;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServerPort;
		private System.Windows.Forms.DataGridViewTextBoxColumn PastaOrigem;
		private System.Windows.Forms.DataGridViewTextBoxColumn PastaDestino;
		private System.Windows.Forms.Button Start;
	}
}