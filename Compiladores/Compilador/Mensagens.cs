using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Compilador
{
    public partial class Mensagens : ScrollableControl
    {
        private TextBox MensagensTexto;
        public static int TAM_LINHA = 15;
        public override string Text
        {
            get
            {
                return MensagensTexto.Text;
            }
            set
            {
                MensagensTexto.Text = value;
            }
        }

        public Mensagens()
        {
            InitializeComponent();
            StartComponents();
        }

        public Mensagens(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            StartComponents();
        }

        private void StartComponents()
        {
            Width = 400;
            Height = 200;
            MensagensTexto = new TextBox();
            MensagensTexto.Parent = this;
            MensagensTexto.ReadOnly = true;
            MensagensTexto.BorderStyle = BorderStyle.Fixed3D;
            MensagensTexto.Multiline = true;
            AutoScroll = true;
            HScroll = true;
            VScroll = true;
            MensagensTexto.BackColor = Color.White;
            ResizeAllComponentes();
            Resize += ResizeAllComponentsEvent;
        }

        public void ResizeAllComponentes()
        {
            this.PerformLayout();
            MensagensTexto.Top = -1;
            MensagensTexto.Left = -1;
            MensagensTexto.Width = Width + 100;
            MensagensTexto.Height = Height + 100;
        }

        public void ResizeAllComponentsEvent(Object obj, EventArgs e)
        {
            ResizeAllComponentes();
        }

        public void LimparTudo()
        {
            MensagensTexto.Text = "";
            AjustaAlturaFonte();
            AutoScrollPosition = new Point(0, 0);
        }

        public void AddMensagem(string Mensagem)
        {
            MensagensTexto.Text = MensagensTexto.Text + Mensagem + Environment.NewLine;
            AjustaAlturaFonte();
            if (MensagensTexto.Lines.Length > 7)
                AutoScrollPosition = new Point(0, (((MensagensTexto.Lines.Length - 7) * TAM_LINHA)));
        }

        private void AjustaAlturaFonte()
        {
            var TamanhoAux = (Height - (MensagensTexto.Lines.Length * TAM_LINHA));
            if (TamanhoAux < 0)
            {
                TamanhoAux = 0;
            }

            MensagensTexto.Height = TamanhoAux + (MensagensTexto.Lines.Length * TAM_LINHA) + TAM_LINHA * 2;
        }
    }
}
