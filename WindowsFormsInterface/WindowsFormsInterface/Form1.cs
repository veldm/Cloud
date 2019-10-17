using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Cloud_DLL;
using static Cloud_DLL.Connection;

namespace WindowsFormsInterface
{
    public partial class Form1 : MaterialForm
    {
        private static Config config;
        XmlSerializer Serialiser = new XmlSerializer(typeof(Config));

        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;            
            try
            {
                FileStream FS = new FileStream("Config.json", FileMode.Open);
                config = (Config)Serialiser.Deserialize(FS);
            }
            catch
            {
                ConnectionStateLabel.Text = "Подключение к серверу отсутствует";
            }
            if (config != null)
            {
                try
                {
                    Connect(config.IP_Adress, config.Port_Number);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConnectionStateLabel.Text = "Подключение к серверу отсутствует";
                }                
                IP_TB.Text = config.IP_Adress;
                Port_TB.Text = config.Port_Number.ToString();
                SynchronizeCB.Checked = config.Synchronize;
                FolderPathTB.Text = config.LocalFolderPath;
                switch (config.SycnhronizeTime)
                {
                    case (60):
                        TimeKB.SelectedIndex = 0;
                        break;
                    case (180):
                        TimeKB.SelectedIndex = 1;
                        break;
                    case (300):
                        TimeKB.SelectedIndex = 2;
                        break;
                    case (900):
                        TimeKB.SelectedIndex = 3;
                        break;
                    case (1800):
                        TimeKB.SelectedIndex = 4;
                        break;
                    case (3600):
                        TimeKB.SelectedIndex = 5;
                        break;
                    case (10800):
                        TimeKB.SelectedIndex = 6;
                        break;
                    case (18000):
                        TimeKB.SelectedIndex = 7;
                        break;
                    case (25200):
                        TimeKB.SelectedIndex = 8;
                        break;
                    case (86400):
                        TimeKB.SelectedIndex = 9;
                        break;
                }
                if (Connection.socket.Connected)
                ConnectionStateLabel.Text = $"Сервер {config.IP_Adress}:{config.Port_Number} успешно подключен";
            }
            else config = new Config();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connect(config.IP_Adress, config.Port_Number);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectionStateLabel.Text = "Подключение к серверу отсутствует";
            }
            if (Connection.socket.Connected)
                ConnectionStateLabel.Text = $"Сервер {config.IP_Adress}:{config.Port_Number} успешно подключен";
        }

        private void SynchronizeCB_CheckedChanged(object sender, EventArgs e)
        {
            config.Synchronize = groupBox1.Enabled = SynchronizeCB.Checked;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Serialiser.Serialize(new FileStream("Config.json", FileMode.Create), config);
        }

        private void TimeKB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TimeKB.SelectedIndex)
            {
                case (0):
                    config.SycnhronizeTime = 60;
                    break;
                case (180):
                    config.SycnhronizeTime = 180;
                    break;
                case (300):
                    config.SycnhronizeTime = 300;
                    break;
                case (900):
                    config.SycnhronizeTime = 900;
                    break;
                case (1800):
                    config.SycnhronizeTime = 1800;
                    break;
                case (3600):
                    config.SycnhronizeTime = 3600;
                    break;
                case (10800):
                    config.SycnhronizeTime = 10800;
                    break;
                case (18000):
                    config.SycnhronizeTime = 18000;
                    break;
                case (25200):
                    config.SycnhronizeTime = 25200;
                    break;
                case (86400):
                    config.SycnhronizeTime = 86400;
                    break;
            }
        }

        private void IP_TB_TextChanged(object sender, EventArgs e)
        {
            config.IP_Adress = IP_TB.Text;
        }

        private void Port_TB_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Port_TB.Text, out int h))
                Port_TB.Text = config.Port_Number.ToString();
            else config.Port_Number = h;
        }

        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            SendFile(fd.FileName);
        }
    }
}
