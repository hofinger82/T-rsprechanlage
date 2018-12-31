using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Json;

namespace Türsprechanlage
{
public partial class Form1 : Form
    {
        
        

        public string[,] MenuModes = new string[,] { 
            {"Main", "Licht", "Tür", "Kameras", "Schildis", "Einstellungen", "menu" },
            {"Sensoren", "Aussentemperatur", "Innentemperatur", "Temperatur Schildkrötenhaus", "Luftfeuchtigkeit aussen", "Wind", "mqtt"},
            {"Licht", "Wohnzimmer Stehlampe", "Terasse", "Terasse Bodenleuchten", "", "", "mqtt"},
            {"Schildkröten", "UV-Licht", "Wärmelampe", "Frostwächter", "Heizmatte T&L", "mehr...", "mqtt"},
            {"Schildkröten 2", "Heizmatte Baby", "Tür vorne", "Tür mitte", "Tür hinten", "" , "mqtt"}
           
        };

        static public string MenuMode = "Main";

        
        

        public string[] subTopics;

        public Dictionary<string,string> MQTTstatus = new Dictionary<string,string>();
        

        public Form1()
        {
            InitializeComponent();
            UpdateMenuItems();
            List<string> subTopicList = new List<string>();

            for (int i = 0; i < MenuModes.GetLength(0); i++)
            {
                if (MenuModes[i, MenuModes.GetLength(1) - 1] == "mqtt")
                {
                    for (int j = 1; j < MenuModes.GetLength(1); j++)
                    {
                        subTopicList.Add("/stat/" + MenuModes[i,0] + "/" +  MenuModes[i, j]);
                        MQTTstatus[MenuModes[i,0] + "/" + MenuModes[i, j]] = "";
                    }
                }
            }
            subTopics = subTopicList.ToArray();

            MqttManagement.setSubTopics(subTopics);
            
        }

        public void UpdateMenuItems()
        {
            for(int i = 0; i < MenuModes.GetLength(0); i++)
            {
                if(MenuModes[i,0] == MenuMode)
                {
                    labelPage.Text = MenuModes[i, 0];
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
                if(MenuModes[i,0] == buttonText) // wenn vorhanden, rufe ein untermenü auf
                {
                    MenuMode = buttonText;
                    UpdateMenuItems();
                    return;
                }

            }
            
            string mqttTopic = "/" + MenuMode + "/" + buttonText;
            MqttManagement.PublishMqttMessage(mqttTopic, "TOGGLE"); //ansonsten mqtt publish
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
            string mode;
            try { mode = status[MenuMode];
                    }
            catch (Exception) { MessageBox.Show("menumode not found: " + MenuMode); }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            MenuMode = "Main";
            UpdateMenuItems();
        }
    }
}
