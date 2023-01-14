using PDFBattleBoard.Model;
using PDFBattleBoard.Utils;
using PDFBattleBoard.View;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System.Diagnostics;

namespace PDFBattleBoard
{
    internal class PDFWriter
    {

        static public void WritePdf()
        {
            //Create PDF Document
            PdfDocument document = new PdfDocument();
            //You will have to add Page in PDF Document
            PdfPage page = document.AddPage();

            page.Orientation = PdfSharpCore.PageOrientation.Landscape;

            //For drawing in PDF Page you will nedd XGraphics Object
            XGraphics gfx = XGraphics.FromPdfPage(page);

            var defaultCharacter = CharacterBuilder.BuildCharacter();

            CharacterDrawer.DrawCharacter(defaultCharacter, gfx, new XRect() { Height = page.Height, Width = page.Width });

            //Specify file name of the PDF file
            string filename = $"{defaultCharacter.Details.Name}.pdf";
            //Save PDF File
            document.Save(filename);

            using (Process p = new Process())
            {
                p.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = filename
                };

                p.Start();
            }
        }
    }
}
