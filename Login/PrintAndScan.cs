using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WIA;

namespace BarmanStoreProject.PrintAndScan
{
    public class Printer
    {
        private Bitmap bitmap;
        public void PrintImage(Form form, Control control)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);

            Graphics graphics = control.CreateGraphics();
            Size size = control.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = form.PointToScreen(control.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }



    public class Scanner
    {
            public WIA.ImageFile ScanImage()
            {

                // Create a DeviceManager instance
                var deviceManager = new DeviceManager();
                WIA.ImageFile imageFile;

                // Loop through the list of devices
                int i;
                for (i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    // Skip the device if it's not a scanner
                    if (deviceManager.DeviceInfos[i].Type == WiaDeviceType.ScannerDeviceType)
                    {
                        var device = deviceManager.DeviceInfos[i].Connect();
                        var scannerItem = device.Items[1];
                        imageFile = (ImageFile)scannerItem.Transfer(FormatID.wiaFormatJPEG);
                        return imageFile;
                        // break;
                    }
                }

                if (i > deviceManager.DeviceInfos.Count) MessageBox.Show("Scanner device not found");
                return null;

            }
        
    }
}
