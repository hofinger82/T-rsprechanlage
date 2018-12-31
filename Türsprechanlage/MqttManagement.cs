using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Türsprechanlage
{
    public class MqttManagement
    {
        static MqttClient client = new MqttClient("192.168.178.69");
        static byte MqttConStatusCode;
        static string MqttStatusText;
        static string[] subTopics;

        public static void setSubTopics(string[] topics)
        {
            subTopics = topics;
        }

        public static void ReconnectMQTT()
        {
            

            try
            {
                MqttConStatusCode = client.Connect(Guid.NewGuid().ToString(), "mqtt", "DroelfGeheimnisse");
            }
            catch (uPLibrary.Networking.M2Mqtt.Exceptions.MqttConnectionException e)
            {
                MqttStatusText = e.Message;
                //labelMqttStatus.ForeColor = Color.Red;
            }


            if (client.IsConnected)
            {
                MqttStatusText = "connected";
                //labelMqttStatus.ForeColor = Color.Green;
                ushort msgId = client.Subscribe(
                    subTopics,
                    new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            }
            else
            {
                MqttStatusText = MqttConStatusCode.ToString();
                //labelMqttStatus.ForeColor = Color.Red;
            }
            //labelMqttStatus.Text = "MQTT Status: " + MqttStatusText;
        }

        public string getStatus()
        {
            return MqttStatusText;
        }

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //Debug.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
            string strStatus;
            strStatus = e.Topic;
            strStatus = strStatus.Replace("/stat/", "");
            Dictionary<string, string> status = new Dictionary<string, string>();
            status[strStatus] = e.Message.ToString();
            Form1.UpdateMqttStatus(status);
        }

        static public int PublishMqttMessage(string topic, string payload)
        {
            int errCode;
            errCode = client.Publish(topic, Encoding.UTF8.GetBytes(payload));
            return errCode;
        }
    }
}
