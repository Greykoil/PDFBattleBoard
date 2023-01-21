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

        static public void WritePdf(Character defaultCharacter)
        {
            //Create PDF Document
            PdfDocument document = new PdfDocument();
            //You will have to add Page in PDF Document
            PdfPage page = document.AddPage();

            page.Orientation = PdfSharpCore.PageOrientation.Landscape;

            //For drawing in PDF Page you will nedd XGraphics Object
            XGraphics gfx = XGraphics.FromPdfPage(page);

            CharacterDrawer.DrawCharacter(defaultCharacter, gfx, new XRect() { Height = page.Height, Width = page.Width });

            string outputDir = "OutputPDFs";
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }
            //Specify file name of the PDF file
            string filename = $"{defaultCharacter.Details.Name}.pdf";
            
            string fullOutputPath = Path.Combine(outputDir, filename);
            
            //Save PDF File
            document.Save(fullOutputPath);

            var currentDir = Directory.GetCurrentDirectory();
            using (Process p = new Process())
            {
                p.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    WorkingDirectory = Path.Combine(currentDir, outputDir),
                    FileName = filename
                };

                p.Start();
            }
        }

        internal static void CreateDemoPages()
        {
            foreach (var character in CharacterBuilder.BuildAllCharacters())
            {
                WritePdf(character);
            }
        }

        internal static void CreateSinglePage() 
        {
            WritePdf(CharacterBuilder.BuildCharacter());
        }

    }
}
