using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AnalisadorLexico;

namespace Compilador
{
    public partial class CompiladorView : Form
    {
        public Lexico Analisador;
        public static string EXTENSAO = ".txt";
        private string FNomeArquivo;
        private string FDiretorio;
        public string Titulo;
        public string UltimoDiretorio;
        public string Diretorio
        {
            get
            {
                return FDiretorio;
            }
            set
            {
                if (value != "")
                {
                    DiretorioStatus.Text = value + NomeArquivo + EXTENSAO;
                }
                else
                {
                    DiretorioStatus.Text = "";
                }
                FDiretorio = value;
                UltimoDiretorio = value;
            }
        }
        public string NomeArquivo
        {
            get 
            {
                return FNomeArquivo;
            }
            set 
            {
                FNomeArquivo = value;
                Titulo = "Compilador BCC 5º Semestre (v2.0) - " + FNomeArquivo + EXTENSAO;
                Text = Titulo;
            }
        }

        public CompiladorView()
        {
            InitializeComponent();
            Analisador = new Lexico();
        }

        private void PainelFonte_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void Fonte_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            InicializaTudo();
        }

        private void InicializaTudo()
        {
            NomeArquivo = "Font1";
            Diretorio = "";
            Editor.LimparTudo();
            Mensagens.LimparTudo();
        }

        public void SetModificado(bool modificado)
        {
            BtnSalvar.Enabled = modificado;

            if (modificado)
            {
                Status.Text = "Modificado";
                Text = Titulo + "*";
            }
            else
            {
                Status.Text = "Não modificado";
                Text = Titulo;
            }
        }

        private void CompiladorView_Load(object sender, EventArgs e)
        {
            Editor.SetModificaStatus = SetModificado;
            InicializaTudo();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();      
        }

        private void Abrir()
        {
            Stream stream;
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.Filter = "Código-fonte BCC|*" + EXTENSAO;
            arquivo.InitialDirectory = @UltimoDiretorio;
            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                if ((stream = arquivo.OpenFile()) != null)
                {
                    byte[] buffer = new byte[16 * 1024];
                    using (MemoryStream ms = new MemoryStream())
                    {
                        int read;
                        while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            ms.Write(buffer, 0, read);
                        }

                        Editor.Text = Encoding.ASCII.GetString(buffer);
                        NomeArquivo = Path.GetFileNameWithoutExtension(arquivo.FileName);
                        Diretorio = Path.GetDirectoryName(arquivo.FileName) + "\\";
                        stream.Close();
                        SetModificado(false);
                    }
                }
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            if ((NomeArquivo != "") && (Diretorio != ""))
            {
                SaveFileDialog DirSave = new SaveFileDialog();
                DirSave.FileName = Diretorio + NomeArquivo + EXTENSAO;

                FileStream fs = (System.IO.FileStream)DirSave.OpenFile();
                var save = Encoding.ASCII.GetBytes(Editor.Text);
                fs.Write(save, 0, save.Length);
                fs.Close();
                SetModificado(false);
                BtnSalvar.Enabled = false;
            }
            else
            {
                SaveFileDialog DirSave = new SaveFileDialog();
                DirSave.Filter = "Código-fonte BCC|*" + EXTENSAO + "|Todos os arquivos|*.*";
                if (DirSave.ShowDialog() == DialogResult.OK)
                {
                    NomeArquivo = Path.GetFileNameWithoutExtension(DirSave.FileName);
                    Diretorio = Path.GetDirectoryName(DirSave.FileName) + "\\";

                    FileStream fs = (System.IO.FileStream)DirSave.OpenFile();
                    var save = Encoding.ASCII.GetBytes(Editor.Text);
                    fs.Write(save, 0, save.Length);
                    fs.Close();
                    SetModificado(false);
                    BtnSalvar.Enabled = false;
                }
            }
        }

        private void CompiladorView_Shown(object sender, EventArgs e)
        {
            Editor.FocarFonte();
        }

        private void BtCopiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void Copiar()
        {
            if (Editor.TextoSelecionado(false) != "")
            {
                Clipboard.SetText(Editor.TextoSelecionado(false));
            }
        }

        private void BtnColar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void Colar()
        {
            var colar = Clipboard.GetText();
            if (colar != "")
            {
                Editor.InsertTexto(colar);
            }
        }

        private void BtnRecortar_Click(object sender, EventArgs e)
        {
            Recortar();
        }

        private void Recortar()
        {
            if (Editor.TextoSelecionado(false) != "")
            {
                Clipboard.SetText(Editor.TextoSelecionado(true));
            }
        }

        private void BtnCompilar_Click(object sender, EventArgs e)
        {
            Analisador.setInput(Editor.Text);
            if (Analisador.Start())
            {
                foreach (var t in Analisador.Tokens)
                {
                    Mensagens.AddMensagem(t.ToString());
                }

				Mensagens.AddMensagem("Compilação concluída com sucesso!");
            }
            else
            {
                Mensagens.AddMensagem(Analisador.MensagemErro);
            }

            Mensagens.AddMensagem("----------------------//-----------------------\r\n");
        }

        private void BtnGerarCodigo_Click(object sender, EventArgs e)
        {
            Mensagens.AddMensagem("compilação de programas ainda não foi implementada\r\n" +
                                  "----------------------//-----------------------\r\n");
        }

        private void BtnEquipe_Click(object sender, EventArgs e)
        {
            Mensagens.AddMensagem("Turma de BCC - 5º Semestre\r\n" + 
                                  "Gabriel Domingos\r\n" +
                                  "Maicon Santos da Silva\r\n" +
                                  "Mateus Clemer Quintino\r\n" +
                                  "----------------------//-----------------------\r\n");
        }

        private void CompiladorView_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                switch ((e.KeyCode))
                {
                    case Keys.N: InicializaTudo();
                        break;
                    case Keys.O: Abrir();
                        break;
                    case Keys.S: Salvar();
                        break;
                    //case Keys.C: Copiar();
                    //    break;
                    //case Keys.V: Colar();
                    //    break;
                    //case Keys.X: Recortar();
                    //    break;
                    default:
                        break;
                }
            }
        }
    }
}
