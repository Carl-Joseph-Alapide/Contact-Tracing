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
using ZXing;

namespace Contact_Tracing_App
{
    public partial class FormQRcode : Form
    {
        public FormQRcode()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice Device;
        private void FormQRcode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInfoCollection)
            cmboxCamera.Items.Add(filterInfo.Name);
            cmboxCamera.SelectedIndex = 0;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Device = new VideoCaptureDevice(filterInfoCollection[cmboxCamera.SelectedIndex].MonikerString);
            Device.NewFrame += Device_NewFrame;
            Device.Start();
            tmrScan.Start();
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pcbxScan.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormQRcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Device.IsRunning)
            {
                Device.Stop(); 
            }    
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            if (pcbxScan.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();  
                Result Result = barcode.decode((Bitmap)pcbxScan.Image);
                if (Result != null)
                {
                   txtbxDecoded.Text = Result.ToString();
                    tmrScan.Stop();
                    if(Device.IsRunning)
                    {
                        Device.Stop();
                    }
                }

            }
           
        }
    }
}
