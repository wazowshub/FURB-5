using System.Windows.Forms;

namespace Compilador
{
    partial class CompiladorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompiladorView));
            this.PainelPrincipal = new System.Windows.Forms.Panel();
            this.PainelMensagens = new System.Windows.Forms.Panel();
            this.Mensagens = new Compilador.Mensagens(this.components);
            this.PainelEditor = new System.Windows.Forms.Panel();
            this.Editor = new Compilador.Editor(this.components);
            this.BarraStatus = new System.Windows.Forms.Panel();
            this.DiretorioStatus = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.BarraFerramentas = new System.Windows.Forms.Panel();
            this.BtnEquipe = new System.Windows.Forms.Button();
            this.Icones = new System.Windows.Forms.ImageList(this.components);
            this.BtnGerarCodigo = new System.Windows.Forms.Button();
            this.BtnCompilar = new System.Windows.Forms.Button();
            this.BtnRecortar = new System.Windows.Forms.Button();
            this.BtnColar = new System.Windows.Forms.Button();
            this.BtCopiar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.PainelPrincipal.SuspendLayout();
            this.PainelMensagens.SuspendLayout();
            this.PainelEditor.SuspendLayout();
            this.BarraStatus.SuspendLayout();
            this.BarraFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelPrincipal
            // 
            this.PainelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelPrincipal.Controls.Add(this.PainelMensagens);
            this.PainelPrincipal.Controls.Add(this.PainelEditor);
            this.PainelPrincipal.Controls.Add(this.BarraStatus);
            this.PainelPrincipal.Controls.Add(this.BarraFerramentas);
            this.PainelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PainelPrincipal.Name = "PainelPrincipal";
            this.PainelPrincipal.Size = new System.Drawing.Size(884, 582);
            this.PainelPrincipal.TabIndex = 0;
            // 
            // PainelMensagens
            // 
            this.PainelMensagens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelMensagens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelMensagens.Controls.Add(this.Mensagens);
            this.PainelMensagens.Location = new System.Drawing.Point(165, 440);
            this.PainelMensagens.Name = "PainelMensagens";
            this.PainelMensagens.Size = new System.Drawing.Size(719, 110);
            this.PainelMensagens.TabIndex = 9;
            // 
            // Mensagens
            // 
            this.Mensagens.AutoScroll = true;
            this.Mensagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mensagens.Location = new System.Drawing.Point(0, 0);
            this.Mensagens.Name = "Mensagens";
            this.Mensagens.Size = new System.Drawing.Size(717, 108);
            this.Mensagens.TabIndex = 0;
            // 
            // PainelEditor
            // 
            this.PainelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelEditor.Controls.Add(this.Editor);
            this.PainelEditor.Location = new System.Drawing.Point(165, -1);
            this.PainelEditor.Name = "PainelEditor";
            this.PainelEditor.Size = new System.Drawing.Size(719, 431);
            this.PainelEditor.TabIndex = 8;
            // 
            // Editor
            // 
            this.Editor.AutoScroll = true;
            this.Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editor.Location = new System.Drawing.Point(0, 0);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(717, 429);
            this.Editor.TabIndex = 0;
            // 
            // BarraStatus
            // 
            this.BarraStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraStatus.Controls.Add(this.DiretorioStatus);
            this.BarraStatus.Controls.Add(this.Status);
            this.BarraStatus.Location = new System.Drawing.Point(0, 550);
            this.BarraStatus.Name = "BarraStatus";
            this.BarraStatus.Size = new System.Drawing.Size(882, 33);
            this.BarraStatus.TabIndex = 6;
            // 
            // DiretorioStatus
            // 
            this.DiretorioStatus.AutoSize = true;
            this.DiretorioStatus.Location = new System.Drawing.Point(408, 7);
            this.DiretorioStatus.Name = "DiretorioStatus";
            this.DiretorioStatus.Size = new System.Drawing.Size(0, 15);
            this.DiretorioStatus.TabIndex = 1;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(11, 7);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 15);
            this.Status.TabIndex = 0;
            // 
            // BarraFerramentas
            // 
            this.BarraFerramentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.BarraFerramentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarraFerramentas.Controls.Add(this.BtnEquipe);
            this.BarraFerramentas.Controls.Add(this.BtnGerarCodigo);
            this.BarraFerramentas.Controls.Add(this.BtnCompilar);
            this.BarraFerramentas.Controls.Add(this.BtnRecortar);
            this.BarraFerramentas.Controls.Add(this.BtnColar);
            this.BarraFerramentas.Controls.Add(this.BtCopiar);
            this.BarraFerramentas.Controls.Add(this.BtnSalvar);
            this.BarraFerramentas.Controls.Add(this.BtnAbrir);
            this.BarraFerramentas.Controls.Add(this.BtnNovo);
            this.BarraFerramentas.Location = new System.Drawing.Point(-1, -1);
            this.BarraFerramentas.Margin = new System.Windows.Forms.Padding(0);
            this.BarraFerramentas.Name = "BarraFerramentas";
            this.BarraFerramentas.Size = new System.Drawing.Size(150, 551);
            this.BarraFerramentas.TabIndex = 5;
            // 
            // BtnEquipe
            // 
            this.BtnEquipe.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEquipe.ImageIndex = 8;
            this.BtnEquipe.ImageList = this.Icones;
            this.BtnEquipe.Location = new System.Drawing.Point(1, 489);
            this.BtnEquipe.Name = "BtnEquipe";
            this.BtnEquipe.Size = new System.Drawing.Size(147, 60);
            this.BtnEquipe.TabIndex = 8;
            this.BtnEquipe.Text = "equipe [F1]";
            this.BtnEquipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEquipe.UseVisualStyleBackColor = true;
            this.BtnEquipe.Click += new System.EventHandler(this.BtnEquipe_Click);
            // 
            // Icones
            // 
            this.Icones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icones.ImageStream")));
            this.Icones.TransparentColor = System.Drawing.Color.Transparent;
            this.Icones.Images.SetKeyName(0, "003-paper-2.png");
            this.Icones.Images.SetKeyName(1, "008-folder.png");
            this.Icones.Images.SetKeyName(2, "002-interface.png");
            this.Icones.Images.SetKeyName(3, "006-paper.png");
            this.Icones.Images.SetKeyName(4, "005-paper-1.png");
            this.Icones.Images.SetKeyName(5, "002-cut.png");
            this.Icones.Images.SetKeyName(6, "007-arrows.png");
            this.Icones.Images.SetKeyName(7, "001-play.png");
            this.Icones.Images.SetKeyName(8, "001-social.png");
            // 
            // BtnGerarCodigo
            // 
            this.BtnGerarCodigo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGerarCodigo.ImageIndex = 7;
            this.BtnGerarCodigo.ImageList = this.Icones;
            this.BtnGerarCodigo.Location = new System.Drawing.Point(1, 428);
            this.BtnGerarCodigo.Name = "BtnGerarCodigo";
            this.BtnGerarCodigo.Size = new System.Drawing.Size(147, 60);
            this.BtnGerarCodigo.TabIndex = 7;
            this.BtnGerarCodigo.Text = "gerar código [F9]";
            this.BtnGerarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGerarCodigo.UseVisualStyleBackColor = true;
            this.BtnGerarCodigo.Click += new System.EventHandler(this.BtnGerarCodigo_Click);
            // 
            // BtnCompilar
            // 
            this.BtnCompilar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCompilar.ImageIndex = 6;
            this.BtnCompilar.ImageList = this.Icones;
            this.BtnCompilar.Location = new System.Drawing.Point(1, 367);
            this.BtnCompilar.Name = "BtnCompilar";
            this.BtnCompilar.Size = new System.Drawing.Size(147, 60);
            this.BtnCompilar.TabIndex = 7;
            this.BtnCompilar.Text = "compilar [F8]";
            this.BtnCompilar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCompilar.UseVisualStyleBackColor = true;
            this.BtnCompilar.Click += new System.EventHandler(this.BtnCompilar_Click);
            // 
            // BtnRecortar
            // 
            this.BtnRecortar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRecortar.ImageIndex = 5;
            this.BtnRecortar.ImageList = this.Icones;
            this.BtnRecortar.Location = new System.Drawing.Point(1, 306);
            this.BtnRecortar.Name = "BtnRecortar";
            this.BtnRecortar.Size = new System.Drawing.Size(147, 60);
            this.BtnRecortar.TabIndex = 6;
            this.BtnRecortar.Text = "recortar [ctrl-x]";
            this.BtnRecortar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRecortar.UseVisualStyleBackColor = true;
            this.BtnRecortar.Click += new System.EventHandler(this.BtnRecortar_Click);
            // 
            // BtnColar
            // 
            this.BtnColar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnColar.ImageIndex = 4;
            this.BtnColar.ImageList = this.Icones;
            this.BtnColar.Location = new System.Drawing.Point(1, 245);
            this.BtnColar.Name = "BtnColar";
            this.BtnColar.Size = new System.Drawing.Size(147, 60);
            this.BtnColar.TabIndex = 5;
            this.BtnColar.Text = "colar [ctrl-v]";
            this.BtnColar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnColar.UseVisualStyleBackColor = true;
            this.BtnColar.Click += new System.EventHandler(this.BtnColar_Click);
            // 
            // BtCopiar
            // 
            this.BtCopiar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtCopiar.ImageIndex = 3;
            this.BtCopiar.ImageList = this.Icones;
            this.BtCopiar.Location = new System.Drawing.Point(1, 184);
            this.BtCopiar.Name = "BtCopiar";
            this.BtCopiar.Size = new System.Drawing.Size(147, 60);
            this.BtCopiar.TabIndex = 3;
            this.BtCopiar.Text = "copiar [ctrl-c]";
            this.BtCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtCopiar.UseVisualStyleBackColor = true;
            this.BtCopiar.Click += new System.EventHandler(this.BtCopiar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalvar.ImageIndex = 2;
            this.BtnSalvar.ImageList = this.Icones;
            this.BtnSalvar.Location = new System.Drawing.Point(1, 123);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(147, 60);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Text = "salvar [ctrl-s]";
            this.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAbrir.ImageIndex = 1;
            this.BtnAbrir.ImageList = this.Icones;
            this.BtnAbrir.Location = new System.Drawing.Point(1, 62);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(147, 60);
            this.BtnAbrir.TabIndex = 1;
            this.BtnAbrir.Text = "abrir [ctrl-o]";
            this.BtnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNovo.ImageIndex = 0;
            this.BtnNovo.ImageList = this.Icones;
            this.BtnNovo.Location = new System.Drawing.Point(1, 1);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(147, 60);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "novo [ctrl-n]";
            this.BtnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // CompiladorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 582);
            this.Controls.Add(this.PainelPrincipal);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "CompiladorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompiladorView";
            this.Load += new System.EventHandler(this.CompiladorView_Load);
            this.Shown += new System.EventHandler(this.CompiladorView_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompiladorView_KeyDown);
            this.PainelPrincipal.ResumeLayout(false);
            this.PainelMensagens.ResumeLayout(false);
            this.PainelEditor.ResumeLayout(false);
            this.BarraStatus.ResumeLayout(false);
            this.BarraStatus.PerformLayout();
            this.BarraFerramentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PainelPrincipal;
        private Panel PainelEditor;
        private Panel BarraStatus;
        private Panel BarraFerramentas;
        private Button BtnEquipe;
        private ImageList Icones;
        private Button BtnGerarCodigo;
        private Button BtnCompilar;
        private Button BtnRecortar;
        private Button BtnColar;
        private Button BtCopiar;
        private Button BtnSalvar;
        private Button BtnAbrir;
        private Button BtnNovo;
        private Panel PainelMensagens;
        private Editor Editor;
        private Mensagens Mensagens;
        private Label Status;
        private Label DiretorioStatus;

    }
}