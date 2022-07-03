using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace Contact_Tracing_App
{

    public partial class formQRcode : Form
    {
        BackgroundWorker bkgworker;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice Device;
        public formQRcode()
        {
            InitializeComponent();
            bkgworker = new BackgroundWorker();
            bkgworker.DoWork += Bkgworker_DoWork;
        }

        private void formQRcode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cmboxCamera.Items.Add(filterInfo.Name);
            cmboxCamera.SelectedIndex = 0;
            btnStop.Enabled = false;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Device = new VideoCaptureDevice(filterInfoCollection[cmboxCamera.SelectedIndex].MonikerString);
            Device.NewFrame += Device_NewFrame;
            try
            {
                Device.Start();
                tmrScan.Start();
                btnScan.Enabled = false;
                btnStop.Enabled = true;
            }
            catch (Exception)
            {
                Device.Stop();
                MessageBox.Show("may error dito sa start");
            } 
        }

        private void Device_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pcbxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                    tmrScan.Stop();
                    Device.Stop();
                    btnScan.Enabled = true;
                    btnStop.Enabled = false;
            }
            catch (Exception)
            {
                Device.Stop();
                MessageBox.Show("may error sa stop");
            }
            
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            if (pcbxCamera != null && !bkgworker.IsBusy)
                bkgworker.RunWorkerAsync();
        }
        private void Bkgworker_DoWork(object? sender, DoWorkEventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            try
            {
                MessageBox.Show(decoder.decode(new QRCodeBitmapImage((Bitmap)pcbxCamera.Image)));
            }
            catch (Exception)
            {

                MessageBox.Show("mali");
            }
        }

        private void formQRcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Device.IsRunning)
            {
                Device.Stop();
            }
        }
    }
}
