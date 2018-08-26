using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace ExtendedTextEditor
{
    class ClassPrinter
    {
        private StringReader reader;
        private uint printPageNumber;
        private string currentLine = String.Empty;
        private RichTextBox activeRichTextBox;

        public ClassPrinter(RichTextBox activeRichTextBox)
        {
            this.activeRichTextBox = activeRichTextBox;
        }

        public void PrintFile(PrintDocument printDocument, PrintDialog printDialog)
        {
            printPageNumber = 1;

            string str = activeRichTextBox.Text;
            reader = new StringReader(str);

            Margins margins = new Margins(100, 100, 50, 50);
            printDocument.DefaultPageSettings.Margins = margins;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

            reader.Close();
        }

        public void PrintPreview(PrintDocument printDocument, PrintPreviewDialog printPreviewDialog)
        {
            printPageNumber = 1;

            string str = activeRichTextBox.Text;
            reader = new StringReader(str);
            Margins margins = new Margins(100, 100, 50, 50);

            printDocument.DefaultPageSettings.Margins = margins;
            printPreviewDialog.ShowDialog();

            reader.Close();
        }

        public void BuildDocument(PrintPageEventArgs e)
        {
            int lineCount = 0;
            float linesPerPage = 0;
            float yLinePosition = 0;

            Font printFont = activeRichTextBox.Font;
            SolidBrush printBrush = new SolidBrush(Color.Black);

            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top + 3 * printFont.GetHeight(e.Graphics);

            linesPerPage = (e.MarginBounds.Height - 6 * printFont.GetHeight(e.Graphics)) / printFont.GetHeight(e.Graphics);

            string baseCurrentLine = null;
            string newStringForNextLine = String.Empty;
            int WIDTH_DOC = e.MarginBounds.Right - e.MarginBounds.Left;

            while (lineCount < linesPerPage)
            {
                if (currentLine == String.Empty || currentLine == null) currentLine = reader.ReadLine();
                if (currentLine == null) break;

                while (e.Graphics.MeasureString(currentLine, printFont).Width > WIDTH_DOC && lineCount < linesPerPage + 1)
                {
                    baseCurrentLine = currentLine;
                    while (e.Graphics.MeasureString(newStringForNextLine, printFont).Width < WIDTH_DOC)
                    {
                        if (currentLine == String.Empty) return;
                        newStringForNextLine += currentLine[0].ToString();
                        currentLine = currentLine.Remove(0, 1);
                    }
                    yLinePosition = topMargin + (lineCount * printFont.GetHeight(e.Graphics));
                    e.Graphics.DrawString(newStringForNextLine, printFont, printBrush, leftMargin, yLinePosition, new StringFormat());
                    newStringForNextLine = String.Empty;
                    if (currentLine != String.Empty) lineCount++;
                }

                if (currentLine != String.Empty && e.Graphics.MeasureString(currentLine, printFont).Width < WIDTH_DOC)
                {
                    yLinePosition = topMargin + (lineCount * printFont.GetHeight(e.Graphics));
                    e.Graphics.DrawString(currentLine, printFont, printBrush, leftMargin, yLinePosition, new StringFormat());
                    lineCount++;
                    currentLine = String.Empty;
                }
            }

            string strPageNumber = "Page " + printPageNumber.ToString();

            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(strPageNumber, printFont, e.MarginBounds.Right - e.MarginBounds.Left);

            // Номер страницы в верхнем колонтитуле
            e.Graphics.DrawString(
                strPageNumber,
                printFont,
                printBrush,
                e.MarginBounds.Right - stringSize.Width,
                e.MarginBounds.Top,
                new StringFormat()
                );

            //e.Graphics.DrawString()

            Pen colontitulPen = new Pen(Color.Black) { Width = 2 };

            // Верхний колонтитул
            e.Graphics.DrawLine(
                colontitulPen,
                leftMargin,
                e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3,
                e.MarginBounds.Right,
                e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3
                );

            // Нижний колонтитул
            e.Graphics.DrawLine(
                colontitulPen,
                leftMargin,
                e.MarginBounds.Bottom - 3,
                e.MarginBounds.Right,
                e.MarginBounds.Bottom - 3
                );

            // Текст в нижнем колонтитуле
            e.Graphics.DrawString("Extended Text Editor, the coursework by Alexey Pestov, NSTU, 2018",
                printFont, printBrush, e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());

            if (currentLine != null)
            {
                e.HasMorePages = true;
                printPageNumber++;
            }
            else
            {
                e.HasMorePages = false;
                printBrush.Dispose();
                colontitulPen.Dispose();
            }
        }
    }
}
