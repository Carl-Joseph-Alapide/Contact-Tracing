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
using AForge.Video;
using AForge.Video.DirectShow;
using IronBarCode;

namespace WindowsFormsApp2
{
    public partial class formQR : Form
    {
        public formQR()
        {
            InitializeComponent();
        }
        FilterInfoCollection CamList;
        VideoCaptureDevice VidCam;

        private void formQR_Load(object sender, EventArgs e)
        {
            
              CamList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in CamList)
                cmbxCam.Items.Add(filterInfo.Name);
            cmbxCam.SelectedIndex = 0;
        }

        private void btnOpenCam_Click(object sender, EventArgs e)
        {
            VidCam = new VideoCaptureDevice(CamList[cmbxCam.SelectedIndex].MonikerString);
            VidCam.NewFrame += VidCam_NewFrame;
            VidCam.Start();
            tmrScan.Start();
        }

        private void VidCam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pcbxVidCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {

                BarcodeResult result = BarcodeReader.QuicklyReadOneBarcode(pcbxVidCam.Image, BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);
                if (result != null)
                {
                
                    var Decodedmsg = result.Text.Split(new char[] { ',' });
                    if (Decodedmsg.Length == 12)
                    {
                        //redirecting the info to their repective textboxes
                        formTraceIt.Infos.Lastname.Text = Decodedmsg[0];
                        formTraceIt.Infos.Firstname.Text = Decodedmsg[1];
                        formTraceIt.Infos.Middlename.Text = Decodedmsg[2];
                        formTraceIt.Infos.Age.Text = Decodedmsg[3];
                        formTraceIt.Infos.Mobile.Text = Decodedmsg[4];
                        formTraceIt.Infos.Email.Text = Decodedmsg[5];
                        formTraceIt.Infos.Address.Text = Decodedmsg[6];
                        formTraceIt.Infos.Zip.Text = Decodedmsg[7];
                        formTraceIt.Infos.Time.Text = Decodedmsg[8];
                        formTraceIt.Infos.Month.Text = Decodedmsg[9];
                        formTraceIt.Infos.Day.Text = Decodedmsg[10];
                        formTraceIt.Infos.Year.Text = Decodedmsg[11];

                        //txtbxtrial1.Text = Decodedmsg[0];
                        //txtbxtrial2.Text = Decodedmsg[1];
                        MessageBox.Show("All the details have been filled to your personal info, plese proceed to the health check to update your health status");
                    }
                    else
                    {
                        MessageBox.Show("The details in your QR code are insufficient");
                    }
                }
                else
                {
                MessageBox.Show("sorry we couldn't detect a QR code, please try again", "Try Again");
                }
            }
            catch (Exception)
            {

            }
        }

        private void formQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            try //(VidCam.IsRunning)
            {
                VidCam.Stop();
            }
            catch (Exception)
            {

            }
            //if (VidCam.IsRunning)
            //{
            //    VidCam.Stop();
            //    //MessageBox.Show("Please follow the protocols inside the establishment", "Thank You");
            //}
            //else
            //{
            //    //MessageBox.Show("Please follow the protocols inside the establishment", "Thank You");
            //}
            formTraceIt.Infos.Scanner.Enabled = true;
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            //if (pcbxVidCam.Image != null)
            //{
            //    BarcodeResult result = BarcodeReader.QuicklyReadOneBarcode(pcbxVidCam.Image, BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);
            //    if (result != null)
            //    {
            //        MessageBox.Show(result.ToString());
            //        tmrScan.Stop();
            //        if (VidCam.IsRunning)
            //            VidCam.Stop();
            //    }
            //}
        }
    }
}
