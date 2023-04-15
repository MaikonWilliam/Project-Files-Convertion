using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.LinkLabel;
using Aspose.Words;

namespace Project_Word_PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //Recebendo o caminho:
            string originPath = tbOriginPath.Text;
            string destinyPath = tbDestinyPath.Text;
            try
            {

                var doc = new Document(originPath);
                doc.Save(destinyPath + "\\index.pdf");

                string Text = "O Arquivo foi modificado com sucesso! ";
                MessageBox.Show(Text);
            }
            catch (Exception ex)
            {
                string Text = "O arquivo não foi encontrado!";
                MessageBox.Show(Text);
            }



        }
    }
}