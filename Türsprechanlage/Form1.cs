using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Türsprechanlage
{
public partial class Form1 : Form
    {
        static string homePath = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        public static string MenuFilePath = homePath + "/SweetHomeCP/Menu.conf";
        

        public string[,] MenuModes = new string[10,10];

        static public string MenuMode = "Main";
        public string[] subTopics;

        static public Dictionary<string,string> MQTTstatus = new Dictionary<string,string>();

        public Form1()
        {
            InitializeComponent();
            getSettings();
            MqttManagement.readConfig();

            UpdateMenuItems();
            
        }

        public void UpdateMenuItems()
        {
            
            labelPage.Text = MenuMode;



            for (int i = 0; i < MenuModes.GetLength(0); i++)
            {
                if (MenuModes[i, 1] == MenuMode)
                {
                    labelPage.Text = MenuModes[i, 1];
                    button1.Text = MenuModes[i, 1];
                    //labelStatus1.Text = MQTTstatus[labelPage.Text + "/" + button1.Text];
                    button2.Text = MenuModes[i, 2];
                    //labelStatus2.Text = MQTTstatus[labelPage.Text + "/"  + button2.Text];
                    button3.Text = MenuModes[i, 3];
                    //labelStatus3.Text = MQTTstatus[labelPage.Text + "/"  + button3.Text];
                    button4.Text = MenuModes[i, 4];
                    //labelStatus4.Text = MQTTstatus[labelPage.Text + "/"  + button4.Text];
                    button5.Text = MenuModes[i, 5];
                    //labelStatus5.Text = MQTTstatus[labelPage.Text + "/"  + button5.Text];

                }
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button1.Text);
        }

        

        private void HandleButtonClick(string buttonText)
        {
            if (buttonText == "Tür")
            {
                Form DoorCam = new DoorCam();
                DoorCam.ShowDialog();
                return;
            }
            

            for (int i = 0; i < MenuModes.GetLength(0); i++)
            {
                if (MenuModes[i, 0] == "menu")
                {
                    if (MenuModes[i, 1] == buttonText) // wenn vorhanden, rufe ein untermenü auf
                    {
                        MenuMode = buttonText;
                        UpdateMenuItems();
                        return;
                    }
                }
                else if(MenuModes[i,0] == "switch")
                {
                    string mqttTopic = MqttManagement.getPubTopic(buttonText);
                    if(mqttTopic != "FAIL")
                        MqttManagement.PublishMqttMessage(mqttTopic, "TOGGLE"); //ansonsten mqtt publish
                }
                else if (MenuModes[i, 0] == "sensor")
                {

                }
            }
            
            
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button5.Text);
        }

        public static void UpdateMqttStatus(Dictionary<string,string> status)
        {
            MQTTstatus = status;
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            Form1.
        }


        private void buttonLeft_Click(object sender, EventArgs e)
        {
            MenuMode = "Main";
            UpdateMenuItems();
        }

        private void getSettings()
        {
            //MenuModes
            int x = 0;
            foreach (string line in File.ReadLines(MenuFilePath))
            {
                int y = 0;
                foreach (string item in line.Split(','))
                {
                    MenuModes[x, y] = item;
                    y++;
                }
                x++;
            }

        }

        
    }
}
