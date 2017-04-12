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
    public partial class Editor : ScrollableControl
    {
        public delegate void ModificaStatus(bool Modificado);
        public ModificaStatus SetModificaStatus;
        private MyListBox NumerosPanel;
        private RichTextBox Fonte;
        public static int TAM_LINHA = 15;
        public int LastLinha;
        public override string Text
        {
            get
            {
                return Fonte.Text;
            }
            set
            {
                Fonte.Text = value;
            }
        }

        public Editor()
        {
            InitializeComponent();
            StartComponents();
        }

        public Editor(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            StartComponents();
        }    

        public void ResizeAllComponentes()
        {
            this.PerformLayout();
            NumerosPanel.Top = -2;
            NumerosPanel.Left = -1;
            NumerosPanel.Width = 34;
            Fonte.Top = -4;
            Fonte.Left = 32;
            Fonte.Width = Width + 5000;
            Fonte.Height = NumerosPanel.Height;
            AjustaAlturaFonte();
        }

        private void StartComponents()
        {
            Width = 400;
            Height = 400;
            LastLinha = 0;
            NumerosPanel = new MyListBox();
            NumerosPanel.Enabled = false;
            NumerosPanel.Parent = this;
            NumerosPanel.BorderStyle = BorderStyle.FixedSingle;
            NumerosPanel.Font = new Font("courier new", 9);
            NumerosPanel.HorizontalScrollbar = false;
            Fonte = new RichTextBox();
            Fonte.Multiline = true;
            Fonte.Parent = this;
            Fonte.BorderStyle = BorderStyle.Fixed3D;
            AutoScroll = true;
            HScroll = true;
            VScroll = true;
            Fonte.Font = new Font("courier new", 9);
            ResizeAllComponentes();
            Resize += ResizeAllComponentsEvent;
            Fonte.TextChanged += AumentaTamanhoFonte;
            //NumerosPanel.DrawMode = DrawMode.OwnerDrawVariable;
            //NumerosPanel.DrawItem += PintaLinha;
            NumerosPanel.MeasureItem += AjustaTamanhoItem;
            Fonte.KeyDown += OnKeyDown;
            Fonte.KeyUp += OnKeyUp;
        }

        public void FocarFonte()
        {
            Fonte.Focus();
        }

        public void ResizeAllComponentsEvent(Object obj, EventArgs e)
        {
            ResizeAllComponentes();
        }

        protected override Point ScrollToControl(Control activeControl)
        {
            return this.DisplayRectangle.Location;
        }

        public void AumentaTamanhoFonte(Object obj, EventArgs e)
        {
            AjustaAlturaFonte();
            SetModificaStatus(true);
        }

        public string TextoSelecionado(bool recortar) 
        {
            var pos = Fonte.SelectionStart;
            var retorno = Fonte.SelectedText;
            if (recortar)
                Fonte.Text = Fonte.Text.Substring(0, Fonte.SelectionStart) + Fonte.Text.Substring(Fonte.SelectionStart + Fonte.SelectionLength, Fonte.Text.Length - (Fonte.SelectionStart + Fonte.SelectedText.Length));

            Fonte.Focus();
            Fonte.SelectionStart = pos;
            return retorno;
        }

        public void InsertTexto(string texto)
        {
            var pos = Fonte.SelectionStart + texto.Length;
            Fonte.Text = Fonte.Text.Substring(0, Fonte.SelectionStart) + texto + Fonte.Text.Substring(Fonte.SelectionStart + Fonte.SelectionLength, Fonte.Text.Length - (Fonte.SelectionStart + Fonte.SelectedText.Length));
            Fonte.Focus();
            Fonte.SelectionStart = pos;
        }

        public void OnKeyDown(Object obj, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Enter))
            {
                if (Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).Y + this.AutoScrollPosition.Y > 370)
                {
                    this.AutoScrollPosition = new Point((this.AutoScrollPosition.X * -1), Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).Y - Height + 100);
                }
            }

            if ((e.KeyCode == Keys.Up))
            {
                if (Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).Y + this.AutoScrollPosition.Y < 50)
                {
                    this.AutoScrollPosition = new Point((this.AutoScrollPosition.X * -1), Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).Y - Height + 300);
                }
            }

            if (Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).X + this.AutoScrollPosition.X < 50)
                this.AutoScrollPosition = new Point(Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).X - Width + 100, (this.AutoScrollPosition.Y * -1));

            if ((e.KeyCode != Keys.Left) && (Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).X + this.AutoScrollPosition.X > 340))
                this.AutoScrollPosition = new Point(Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).X - Width + 100, (this.AutoScrollPosition.Y * -1));
        }

        public void OnKeyUp(Object obj, KeyEventArgs e)
        {
            if (!((e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Up)))
            { 
                if ((Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).Y + this.AutoScrollPosition.Y > 370) || (e.KeyCode == Keys.Home))
                {
                    this.AutoScrollPosition = new Point(Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).X - Width + 100, Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).Y - Height + 100);
                } else
                if ((Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).Y + this.AutoScrollPosition.Y < 50) || (e.KeyCode == Keys.End))
                {
                    this.AutoScrollPosition = new Point(Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).X - Width + 100, Fonte.GetPositionFromCharIndex(Fonte.SelectionStart).Y - Height + 300);
                }
            }
        }

        private void AjustaAlturaFonte()
        {
            var TamanhoAux = (Height - (Fonte.Lines.Length * TAM_LINHA));
            if (TamanhoAux < 0)
            {
                TamanhoAux = 0;
            }

            NumerosPanel.Height = TamanhoAux + (Fonte.Lines.Length * TAM_LINHA) + 100;
            Fonte.Height = NumerosPanel.Height + 2;
    
            if (NumerosPanel.Items.Count > 0)
            {
                if (Int32.Parse((NumerosPanel.Height/TAM_LINHA).ToString().Trim()) > LastLinha)
                {
                    PreencheLinhas();
                }
            }
            else
            {
                PreencheLinhas();
            }
        }

        private void PreencheLinhas()
        {
            var linhas = (NumerosPanel.Height / TAM_LINHA);
            linhas = linhas - NumerosPanel.Items.Count;
            var Numero = LastLinha;

            for (var i = 0; i < linhas; i++)
            {
                Numero = Numero + 1;
                NumerosPanel.Items.Add((Numero + "").ToString().PadLeft(4, ' '));
            }

            LastLinha = Numero;
        }

        public void PintaLinha(Object obj, DrawItemEventArgs e)
        {
            e.DrawBackground();
            var ForeColor = Color.Black;
            if (((e.Index + 1) % 10 == 0) || (e.Index == 0))
                ForeColor = Color.Red;

            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            g.DrawString(NumerosPanel.Items[e.Index].ToString(), e.Font, new SolidBrush(ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));
            e.DrawFocusRectangle();
        }

        public void AjustaTamanhoItem(Object obj, MeasureItemEventArgs e)
        {
            e.ItemHeight = 15;
        }

        public void LimparTudo()
        {
            Fonte.SelectionStart = 0;
            Fonte.Text = "";
            Fonte.Focus();
            OnKeyUp(null, new KeyEventArgs(Keys.Home));
            SetModificaStatus(false);
        }
    }
}
