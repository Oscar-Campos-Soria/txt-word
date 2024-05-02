using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.Packaging;



namespace txt_word
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtTexto.AccessibleDescription = "Todo este texto se va amostar en Word.";

            txtTexto filePath = Path.Combine(Path.GetTempPath(), "DocumentoWord.docx");
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = new Body();
                mainPart.Document.Append(body);

                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text(texto));
            }

           
            System.Diagnostics.Process.Start(filePath);
        }
    }
}
