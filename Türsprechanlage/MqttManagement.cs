using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.IO;

namespace Türsprechanlage
{
    public class MqttManagement
    {
        static MqttClient client = new MqttClient("192.168.178.69");
        static byte MqttConStatusCode;
        static string MqttStatusText;
        static string[] subTopics;

        static string homePath = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        public static string SensorFilePath = homePath + "/SweetHomeCP/sensor.json";
        public static string SwitchFilePath = homePath + "/SweetHomeCP/switch.json";
        public static string[,] Switches = new string[20, 7];

        static Dictionary<string,string> status = new Dictionary<string,string>();

        public static void readConfig()
        {
            //Switches
            int x = 0;
            foreach (string line in File.ReadLines(SwitchFilePath))
            {
                int y = 0;
                foreach (string item in line.Split(','))
                {
                    Switches[x, y] = item;
                    y++;
                }
                x++;
            }
        }
    

        public static void setSubTopics()
        {
            List<string> subTList = new List<string>();
            for(int i = 0; i < Switches.GetLength(0); i++)
            {
                subTList.Add(Switches[i, 3]);
            }
            subTopics = subTList.ToArray();
                
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
                setSubTopics();
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

        static public string getStatus()
        {
            return MqttStatusText;
        }

        static public string getStatus(string buttonText)
        {

        }

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //Debug.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
            for(int i = 0; i < Switches.GetLength(0); i++)
            {
               if(Switches[i,3] == e.Topic)
                {
                    status[Switches[i, 1]] = Encoding.UTF8.GetString(e.Message);
                }
            }
            Form1.UpdateMqttStatus(status);
        }

        static public int PublishMqttMessage(string topic, string payload)
        {
            int errCode;
            errCode = client.Publish(topic, Encoding.UTF8.GetBytes(payload));
            return errCode;
        }

        static public string getPubTopic(string buttonText)
        {
            for(int i = 0; i < Switches.GetLength(0); i++)
            {
                if(Switches[i,1] == buttonText)
                {
                    return Switches[i, 2];
                }
            }
            return "FAIL";
        }
    }
}
