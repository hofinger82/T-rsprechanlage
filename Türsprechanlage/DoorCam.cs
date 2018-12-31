using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebEye.Controls.WinForms.StreamPlayerControl;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Türsprechanlage
{
    public partial class DoorCam : Form
    {


        public DoorCam()
        {
            InitializeComponent();
            //streamPlayerControl1.StartPlay(new Uri("rtsp://184.72.239.149/vod/mp4:BigBuckBunny_115k.mov")); //oder
            //streamPlayerControl1.StartPlay(new Uri("rtsp://184.72.239.149/vod/mp4:BigBuckBunny_115k.mov"),
            //    TimeSpan.FromSeconds(15), RtspTransport.UdpMulticast, RtspFlags.None);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if(streamPlayerControl1.IsPlaying)
                streamPlayerControl1.Stop();
            this.Close();
        }

        private void buttonOpenDoor_Click(object sender, EventArgs e)
        {
            MqttManagement.PublishMqttMessage("/tuer", "AUF");
        }
    }
}
