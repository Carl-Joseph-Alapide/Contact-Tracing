using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using MessagingToolkit.Barcode;
using BasselTech_CamCapture;
using Timer = System.Threading.Timer;

namespace Contact_Tracing_App
{
    public partial class FormQRcode : Form
    {
        Camera camera;
        //Timer timer;
        BackgroundWorker bkgworker;
        Bitmap CapImg;

        public FormQRcode()
        {
            InitializeComponent();
            //timer = new Timer();
            camera = new Camera(pcbxScan);
            bkgworker = new BackgroundWorker();

            bkgworker.DoWork += Bkgworker_DoWork;
            tmrScan.Tick += TmrScan_Tick;
            tmrScan.Interval = 1;
            btnStop.Enabled = false;
        }

        private void TmrScan_Tick(object? sender, EventArgs e)
        {
            CapImg = camera.GetBitmap();
            if (CapImg != null && !bkgworker.IsBusy)
                bkgworker.RunWorkerAsync();

        }

        private void Bkgworker_DoWork(object? sender, DoWorkEventArgs e)
        {
            BarcodeDecoder decoder = new BarcodeDecoder();
            try
            {
                string Decoded = decoder.Decode(CapImg).Text;
                MessageBox.Show(Decoded);

            }
            catch (Exception)
            {

            }
        }

        //FilterInfoCollection filterInfoCollection;
        //VideoCaptureDevice Device;
        private void FormQRcode_Load(object sender, EventArgs e)
        {
            //filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach(FilterInfo filterInfo in filterInfoCollection)
            //cmboxCamera.Items.Add(filterInfo.Name);
            //cmboxCamera.SelectedIndex = 0;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            //Device = new VideoCaptureDevice(filterInfoCollection[cmboxCamera.SelectedIndex].MonikerString);
            //Device.NewFrame += Device_NewFrame;
            //Device.Start();
            //tmrScan.Start();
            try
            {
                camera.Start();
                tmrScan.Start();
                btnScan.Enabled = false;
                btnStop.Enabled = true;

            }
            catch (Exception retry)
            {

                camera.Stop();
                MessageBox.Show(retry.Message);
            }
        }

        //private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        //{
        //    pcbxScan.Image = (Bitmap)eventArgs.Frame.Clone();
        //}

        //private void FormQRcode_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (Device.IsRunning)
        //    {
        //        Device.Stop(); 
        //    }    
        //}

        //private void tmrScan_Tick(object sender, EventArgs e)
        //{
            //if (pcbxScan.Image != null)
            //{
            //    BarcodeResult QRcode = IronBarCode.BarcodeReader.ReadASingleBarcode(pcbxScan.Image);
            //    if (QRcode != null)
            //    {
            //        txtbxDecoded.Text = QRcode.ToString();
            //        tmrScan.Stop();
            //        if (Device.IsRunning)
            //        {
            //            Device.Stop();
            //        }
            //    }
            //}
            //BarcodeReader reader = null;
            //Bitmap bitmap= Writer
           
            //if (pcbxScan.Image !=null)
            //{
            //    BarcodeReader reader = new BarcodeReader();
            //    Result result = reader.decode(pcbxScan.Image);
            //}
            //var barcodeReader = new BarcodeReaderExtensions();
            //var barcodeBitmap = ((Bitmap)pcbxScan.Image);
            //var barcodeResult = barcodeReader.(barcodeBitmap);
        //}

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrScan.Stop();
            camera.Stop();
            btnScan.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
