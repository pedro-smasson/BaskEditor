using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;

namespace BaskEditor
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        //MÉTODOS
        private void SalvarArquivo() 
        {
            try 
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                    FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate,
                    FileAccess.Write);

                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    streamWriter.Flush();
                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    streamWriter.Write(this.richTextBox1.Text);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro! " + ex.Message);
            }
        }

        private void VerificarSalvarArquivo() 
        {
            if (string.IsNullOrEmpty(richTextBox1.Text)) 
            {
                MessageBox.Show("Impossível salvar um arquivo vazio!", "Arquivo Vazio");
            }
            else 
            {
                if((MessageBox.Show("Deseja salvar o arquivo?", "Salvar Arquivo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)) 
                {
                    SalvarArquivo();
                }
            }
        }

        private void AbrirArquivo() 
        {
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Selecionar Arquivo";
            openFileDialog1.InitialDirectory = @"C:\BaskEditor\Arquivos";
            openFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.FilterIndex = 1;

            DialogResult dialogResult = this.openFileDialog1.ShowDialog();

            if(dialogResult == System.Windows.Forms.DialogResult.OK) 
            {
                try 
                {
                    FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open,
                FileAccess.Read);

                    StreamReader streamReader = new StreamReader(fileStream);
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

                    this.richTextBox1.Text = "";
                    string linha = streamReader.ReadLine();

                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = streamReader.ReadLine();
                    }
                    streamReader.Close();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Erro! " + ex.Message);
                }
            }
        }

        private void AtivarNegrito() 
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;
            bool negrito = false;

            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;
            negrito = richTextBox1.Font.Bold;

            if(negrito == false) 
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);
            }
            else 
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            }
        }

        private void AtivarItalico() 
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;
            bool italico = false;

            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;
            italico = richTextBox1.Font.Italic;

            if (italico == false)
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            }
        }

        private void AtivarSublinhado() 
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;
            bool sublinhado = false;

            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;
            sublinhado = richTextBox1.Font.Underline;

            if (sublinhado == false)
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            }
        }


        //EVENTOS
        private void abrirDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void tsAbrir_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificarSalvarArquivo();
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void tsNovo_Click(object sender, EventArgs e)
        {
            VerificarSalvarArquivo();
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void salvarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificarSalvarArquivo();
        }

        private void tsSalvar_Click(object sender, EventArgs e)
        {
            VerificarSalvarArquivo();
        }

        private void tsNegrito_Click(object sender, EventArgs e)
        {
            AtivarNegrito();
        }

        private void tsItalico_Click(object sender, EventArgs e)
        {
            AtivarItalico();
        }

        private void tsSublinhado_Click(object sender, EventArgs e)
        {
            AtivarSublinhado();
        }
    }
}
