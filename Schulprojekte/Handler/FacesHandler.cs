using System.Drawing.Drawing2D;
using System.Drawing;
using Schulprojekte.Objekte;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System;

namespace Schulprojekte.Handler
{
    internal class FacesHandler
    {
        public static Image rotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        public static DataGridView prepareConclusionTable(QuantitativeOfferComparisonInformation comparisonInformation)
        {
            DataGridView dataGridView = new DataGridView();

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);

            dataGridView.Name = "conclusionTable";
            dataGridView.Location = new Point(0, 0);
            dataGridView.Size = new Size(980, 500);
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.GridColor = Color.Black;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowCount = 0;
            dataGridView.ColumnCount = comparisonInformation.offerInformations.Count + 1;
            /*dataGridView.Columns[0].Name = "Angebot";
            dataGridView.Columns[1].Name = "Menge";
            dataGridView.Columns[2].Name = "Stückpreis";
            dataGridView.Columns[3].Name = "Listeneinkaufspreis";
            dataGridView.Columns[4].Name = "Lieferrabatt";
            dataGridView.Columns[5].Name = "Zieleinkaufspreis";
            dataGridView.Columns[6].Name = "Lieferskonto";
            dataGridView.Columns[7].Name = "Bareinkaufspreis";
            dataGridView.Columns[8].Name = "Bezugskosten";
            dataGridView.Columns[9].Name = "Bezugspreis";*/

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = dataGridView.Width / (dataGridView.Columns.Count);
            }

            dataGridView.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Point);

            List<String> headers = new List<String>();
            headers.Add("Angebot");
            headers.Add("Menge");
            headers.Add("Stückpreis");
            headers.Add("Listeneinkaufspreis");
            headers.Add("Lieferer");
            headers.Add("Lieferrabatt");
            headers.Add("Zieleinkaufspreis");
            headers.Add("Lieferskonto");
            headers.Add("Bareinkaufspreis");
            headers.Add("Bezugskosten");
            headers.Add("Bezugspreis");

            int columnPosition = 0;
            foreach (String header in headers)
            {
                String[] record = new string[dataGridView.ColumnCount];
                record[0] = header;
                int rowPosition = 1;
                foreach (QuantitativeOfferComparisonOfferInformation offerInformation in comparisonInformation.offerInformations)
                {
                    double listeneinkaufspreis = comparisonInformation.amound * offerInformation.unitPrice;
                    double zieleinkaufspreis = listeneinkaufspreis * (1 - (offerInformation.deliveryDiscount / 100));
                    double bareinkaufspreis = zieleinkaufspreis * (1 - (offerInformation.deliverySkonto / 100));
                    double bezugskosten = bareinkaufspreis + offerInformation.purchaseCost;

                    switch(columnPosition)
                    {
                        case 0:
                            record[rowPosition] = offerInformation.offererName;
                            break;
                        case 1:
                            record[rowPosition] = comparisonInformation.amound.ToString();
                            break;
                        case 2:
                            record[rowPosition] = offerInformation.unitPrice.ToString();
                            break;
                        case 3:
                            record[rowPosition] = listeneinkaufspreis.ToString();
                            break;
                        case 4:
                            record[rowPosition] = offerInformation.deliverer;
                            break;
                        case 5:
                            record[rowPosition] = offerInformation.deliveryDiscount.ToString();
                            break;
                        case 6:
                            record[rowPosition] = zieleinkaufspreis.ToString();
                            break;
                        case 7:
                            record[rowPosition] = offerInformation.deliverySkonto.ToString();
                            break;
                        case 8:
                            record[rowPosition] = bareinkaufspreis.ToString();
                            break;
                        case 9:
                            record[rowPosition] = offerInformation.purchaseCost.ToString();
                            break;
                        case 10:
                            record[rowPosition] = bezugskosten.ToString();
                            break;
                    }
                    rowPosition++;
                }
                dataGridView.Rows.Add(record);
                columnPosition++;
            }

            return dataGridView;
        }
    }
}
