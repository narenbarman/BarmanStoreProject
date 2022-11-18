using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace BarmanStoreProject.ScannerDemo
{
    public partial class Form2 : Form
    {
        #region 1 Declaration of Controls
        private System.Windows.Forms.GroupBox groupBox1;
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        
        private System.Windows.Forms.ListBox listBox1;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textColorMode;
        private System.Windows.Forms.TextBox textResolution;
        private System.Windows.Forms.TextBox textContrast;
        private System.Windows.Forms.TextBox textBrightness;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWidth;

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.PictureBox pictureBox1;
           
        private System.Windows.Forms.ComboBox comboBox1;
                
        #endregion
        public Form2()
        {
            InitializeComponent();
            #region 2 Assignment of Controls
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.textColorMode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textResolution = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textContrast = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBrightness = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            #endregion
            #region 3 Initialization of Controls
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.scanButton);
            this.groupBox1.Controls.Add(this.textColorMode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textResolution);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textContrast);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBrightness);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textHeight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.selectFolderButton);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 698);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 621);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Color mode";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(89, 663);
            this.scanButton.Name = "button1";
            this.scanButton.Size = new System.Drawing.Size(86, 35);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Start scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // textColorMode
            // 
            this.textColorMode.Location = new System.Drawing.Point(52, 637);
            this.textColorMode.Name = "textColorMode";
            this.textColorMode.Size = new System.Drawing.Size(194, 20);
            this.textColorMode.TabIndex = 20;
            this.textColorMode.Text = "1";
            this.textColorMode.Validating += new System.ComponentModel.CancelEventHandler(this.textColorMode_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Resolution";
            // 
            // textResolution
            // 
            this.textResolution.Location = new System.Drawing.Point(52, 433);
            this.textResolution.Name = "textResolution";
            this.textResolution.Size = new System.Drawing.Size(194, 20);
            this.textResolution.TabIndex = 18;
            this.textResolution.Text = "300";
            this.textResolution.Validating += new System.ComponentModel.CancelEventHandler(this.textResolution_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Contrast (%)";
            // 
            // textContrast
            // 
            this.textContrast.Location = new System.Drawing.Point(52, 596);
            this.textContrast.Name = "textContrast";
            this.textContrast.Size = new System.Drawing.Size(194, 20);
            this.textContrast.TabIndex = 16;
            this.textContrast.Text = "80";
            this.textContrast.Validating += new System.ComponentModel.CancelEventHandler(this.textContrast_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Brightness (%)";
            // 
            // textBrightness
            // 
            this.textBrightness.Location = new System.Drawing.Point(52, 555);
            this.textBrightness.Name = "textBrightness";
            this.textBrightness.Size = new System.Drawing.Size(194, 20);
            this.textBrightness.TabIndex = 14;
            this.textBrightness.Text = "0";
            this.textBrightness.Validating += new System.ComponentModel.CancelEventHandler(this.textBrightness_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Height (pixel)";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(52, 514);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(194, 20);
            this.textHeight.TabIndex = 12;
            this.textHeight.Text = "3500";
            this.textHeight.Validating += new System.ComponentModel.CancelEventHandler(this.textHeight_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Width (pixel)";
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(52, 473);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(194, 20);
            this.textWidth.TabIndex = 10;
            this.textWidth.Text = "2408";
            this.textWidth.Validating += new System.ComponentModel.CancelEventHandler(this.textWidth_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select a scanner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Image format";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "TIF",
            "BMP",
            "GIF"});
            this.comboBox1.Location = new System.Drawing.Point(56, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filename";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "myscan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output scanned images";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(56, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 2;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(56, 368);
            this.selectFolderButton.Name = "button2";
            this.selectFolderButton.Size = new System.Drawing.Size(84, 38);
            this.selectFolderButton.TabIndex = 1;
            this.selectFolderButton.Text = "Change output folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(56, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 173);
            this.listBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1017F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 704);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(356, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1011, 698);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1005, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(171, 368);
            this.saveButton.Name = "button3";
            this.saveButton.Size = new System.Drawing.Size(75, 38);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 704);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "WIA Scanner Example";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

            #endregion
        }
        
            
        private string imageExtension = "";
        private ImageFile image = new ImageFile();
       

        private void Form2_Load(object sender, EventArgs e)
        {
            ListScanners();

            // Set start output folder TMP
            textBox1.Text = Path.GetTempPath();
            // Set JPEG as default
            comboBox1.SelectedIndex = 1;

        }

        private void ListScanners()
        {
            // Clear the ListBox.
            listBox1.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                listBox1.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
        }
        #region Scan Function
        private void scanButton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());

        }

        private void TriggerScan()
        {
            Console.WriteLine("Image succesfully scanned");
        }

        public void StartScanning()
        {
            int scanResolutionDPI = int.Parse(textResolution.Text);
            int scanStartLeftPixel = 0;
            int scanStartTopPixel = 0;
            int scanWidthPixel = int.Parse(textWidth.Text);
            int scanHeightPixels = int.Parse(textHeight.Text);
            int brightnessPercents = int.Parse(textBrightness.Text);
            int contrastPercents = int.Parse(textContrast.Text);
            int colorMode = int.Parse(textColorMode.Text);
            Scanner device = null;
            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listBox1.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("You need to select first an scanner device from the list",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Provide a filename",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ImageFile image = new ImageFile();


            this.Invoke(new MethodInvoker(delegate ()
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        image = device.Scan(WIA.FormatID.wiaFormatPNG, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".png";
                        break;
                    case 1:
                        image = device.Scan(WIA.FormatID.wiaFormatJPEG, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".jpeg";
                        break;
                    case 2:
                        image = device.Scan(WIA.FormatID.wiaFormatTIFF, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".tiff";
                        break;
                    case 3:
                        image = device.Scan(WIA.FormatID.wiaFormatBMP, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".bmp";
                        break;
                    case 4:
                        image = device.Scan(WIA.FormatID.wiaFormatGIF, scanResolutionDPI, scanStartLeftPixel, scanStartTopPixel, scanWidthPixel, scanHeightPixels, brightnessPercents, contrastPercents, colorMode);
                        imageExtension = ".gif";
                        break;
                }

            }));


            var imageBytes = (byte[])image.FileData.get_BinaryData();
            var ms = new MemoryStream(imageBytes);
            var img = System.Drawing.Image.FromStream(ms);
            pictureBox1.Image = img;
        }
        #endregion
        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
            }
        }
        #region Save Button Function
        private void saveButton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(StartSaving).ContinueWith(result => TriggerSave());



        }

        private void StartSaving()
        {
            var path = textBox1.Text + textBox2.Text + imageExtension;

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            image.SaveFile(path);
        }

        private void TriggerSave()
        {
            MessageBox.Show("File Saved");
        }
        #endregion
        private void textResolution_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textResolution.Text) || int.TryParse(textResolution.Text, out v) == false) { textResolution.Text = 300 + ""; }

            int value = int.Parse(textResolution.Text);


            if (value < 50 || value > 600)
            {
                value = 300;
                textResolution.Text = value + "";
            }
            textWidth.Text = "" + (value * 8);
            textHeight.Text = "" + (value * 11);
        }

        private void textWidth_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textWidth.Text) || int.TryParse(textWidth.Text, out v) == false) { textWidth.Text = 0 + ""; }

            int value = int.Parse(textWidth.Text);
            int resolution = int.Parse(textResolution.Text);
            if (value <= 0 || value > resolution * 8)
            {
                value = resolution * 8;
                textWidth.Text = value + "";
            }
        }

        private void textHeight_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textHeight.Text) || int.TryParse(textHeight.Text, out v) == false) { textHeight.Text = 0 + ""; }

            int value = int.Parse(textHeight.Text);
            int resolution = int.Parse(textResolution.Text);
            if (value <= 0 || value > (int)resolution * 11)
            {
                value = (int)(resolution * 11);
                textHeight.Text = value + "";
            }
        }

        private void textBrightness_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textBrightness.Text) || int.TryParse(textBrightness.Text, out v) == false) { textBrightness.Text = 0 + ""; }

            int value = int.Parse(textBrightness.Text);
            if (value < 0 || value > 100)
            {
                value = 0;
                textBrightness.Text = value + "";
            }
        }

        private void textContrast_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textContrast.Text) || int.TryParse(textContrast.Text, out v) == false) { textContrast.Text = 0 + ""; }

            int value = int.Parse(textContrast.Text);
            if (value < 0 || value > 100)
            {
                value = 0;
                textContrast.Text = value + "";
            }
        }

        private void textColorMode_Validating(object sender, CancelEventArgs e)
        {
            int v = 300;
            if (string.IsNullOrEmpty(textColorMode.Text) || int.TryParse(textColorMode.Text, out v) == false) { textColorMode.Text = 0 + ""; }

            int value = int.Parse(textColorMode.Text);
            if (value < 0 || value > 100)
            {
                value = 0;
                textColorMode.Text = value + "";
            }
        }

        

        

        
    }
    
}
