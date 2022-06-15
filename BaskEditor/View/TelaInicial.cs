using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BaskEditor
{
    public partial class TelaInicial : Form
    {
        private StringReader _imprimir;

        public TelaInicial()
        {
            InitializeComponent();
            rtbPrincipal.SelectionFont = new Font("Tahoma", 12, FontStyle.Regular);
        }

        private void SalvarArquivo()
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter streamWriter = new StreamWriter(fileStream);

                    streamWriter.Flush();
                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    streamWriter.Write(rtbPrincipal.Text);
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
            if (string.IsNullOrEmpty(rtbPrincipal.Text))
                MessageBox.Show("Impossível salvar um arquivo vazio!", "Arquivo Vazio");

            else
            {
                if (MessageBox.Show("Deseja salvar o arquivo?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    SalvarArquivo();
                }
            }
        }

        private void AbrirArquivo()
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Selecionar Arquivo";
            openFileDialog1.InitialDirectory = @"C:\BaskEditor\Arquivos";
            openFileDialog1.Filter = "Text Documents|*.txt";
            openFileDialog1.ValidateNames = true;
            openFileDialog1.Multiselect = false;

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.FilterIndex = 1;

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                    StreamReader streamReader = new StreamReader(fileStream);
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

                    rtbPrincipal.Text = "";
                    string linha = streamReader.ReadLine();

                    while (linha != null)
                    {
                        rtbPrincipal.Text += linha + "\n";
                        linha = streamReader.ReadLine();
                    }
                    streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro! " + ex.Message);
                }
            }
        }

        private void AtivarNegrito()
        {
            float tamanhoDaFonte = rtbPrincipal.Font.Size;
            var verificarSeNegritoEstaAtivo = rtbPrincipal.SelectionFont.Style == FontStyle.Regular;

            if (verificarSeNegritoEstaAtivo)
                rtbPrincipal.SelectionFont = new Font(rtbPrincipal.Font.Name, tamanhoDaFonte, FontStyle.Bold);

            else
                rtbPrincipal.SelectionFont = new Font(rtbPrincipal.Font.Name, tamanhoDaFonte, FontStyle.Regular);
        }

        private void AtivarItalico()
        {
            float tamanhoDaFonte = rtbPrincipal.Font.Size;
            var verificarSeItalicoEstaAtivo = rtbPrincipal.SelectionFont.Style == FontStyle.Regular;

            if (verificarSeItalicoEstaAtivo)
                rtbPrincipal.SelectionFont = new Font(rtbPrincipal.Font.Name, tamanhoDaFonte, FontStyle.Italic);

            else
                rtbPrincipal.SelectionFont = new Font(rtbPrincipal.Font.Name, tamanhoDaFonte, FontStyle.Regular);
        }

        private void AtivarSublinhado()
        {
            float tamanhoDaFonte = rtbPrincipal.Font.Size;
            var verificarSeSublinhadoEstaAtivo = rtbPrincipal.SelectionFont.Style == FontStyle.Regular;

            if (verificarSeSublinhadoEstaAtivo)
                rtbPrincipal.SelectionFont = new Font(rtbPrincipal.Font.Name, tamanhoDaFonte, FontStyle.Underline);

            else
                rtbPrincipal.SelectionFont = new Font(rtbPrincipal.Font.Name, tamanhoDaFonte, FontStyle.Regular);
        }

        private void AlterarFonte()
        {
            if (rtbPrincipal.SelectionFont != null)
                rtbPrincipal.SelectionFont = fontDialog1.Font;
        }

        private void ConfigurarImpressora()
        {
            try
            {
                printDialog1.Document = printDocument1;
                printDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
        }

        public void Imprimir()
        {
            printDialog1.Document = printDocument1;

            string documentoASerImpresso = rtbPrincipal.Text;
            _imprimir = new StringReader(documentoASerImpresso);

            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina;
            float y;
            int contador = 0;

            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemDeCima = e.MarginBounds.Top - 50;

            if (margemEsquerda < 5)
                margemEsquerda = 20;

            if (margemDeCima < 5)
                margemDeCima = 20;

            Font fonteImprimir = rtbPrincipal.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);

            linhasPagina = e.MarginBounds.Height / fonteImprimir.GetHeight(e.Graphics);
            string linha = _imprimir.ReadLine();

            while (contador < linhasPagina)
            {
                y = margemDeCima + (contador * fonteImprimir.GetHeight(e.Graphics));
                e.Graphics.DrawString(linha, fonteImprimir, pincel, margemEsquerda, y, new StringFormat());

                contador += 1;
                linha = _imprimir.ReadLine();
            }
            if (linha != null)
                e.HasMorePages = true;

            else
                e.HasMorePages = false;

            pincel.Dispose();
        }

        private void abrirDocumentoToolStripMenuItem_Click(object sender, EventArgs e) => AbrirArquivo();

        private void tsAbrir_Click(object sender, EventArgs e) => AbrirArquivo();

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificarSalvarArquivo();
            rtbPrincipal.Clear();
            rtbPrincipal.Focus();
        }

        private void tsNovo_Click(object sender, EventArgs e)
        {
            VerificarSalvarArquivo();
            rtbPrincipal.Clear();
            rtbPrincipal.Focus();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
            => rtbPrincipal.SelectionAlignment = HorizontalAlignment.Left;

        private void centralizadoToolStripMenuItem_Click(object sender, EventArgs e)
            => rtbPrincipal.SelectionAlignment = HorizontalAlignment.Center;

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
            => rtbPrincipal.SelectionAlignment = HorizontalAlignment.Right;

        private void salvarDocumentoToolStripMenuItem_Click(object sender, EventArgs e) => VerificarSalvarArquivo();

        private void tsSalvar_Click(object sender, EventArgs e) => VerificarSalvarArquivo();

        private void tsNegrito_Click(object sender, EventArgs e) => AtivarNegrito();

        private void tsItalico_Click(object sender, EventArgs e) => AtivarItalico();

        private void tsSublinhado_Click(object sender, EventArgs e) => AtivarSublinhado();

        private void alterarFonteToolStripMenuItem_Click(object sender, EventArgs e) => AlterarFonte();

        private void configuraçõesImpressãoToolStripMenuItem_Click(object sender, EventArgs e) => ConfigurarImpressora();

        private void tsImprimir_Click(object sender, EventArgs e) => Imprimir();

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e) => Imprimir();

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void tsSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void TelaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                VerificarSalvarArquivo();

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.P)
                Imprimir();

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
                AtivarNegrito();

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.I)
                AtivarItalico();

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
                AtivarSublinhado();
        }
    }
}