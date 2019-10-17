using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cloud_DLL.Connection;

namespace WindowsFormsInterface
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            try
            {
                Connect("127.0.0.1", 907);
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Application.Exit();
            }
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            SendFile(fd.FileName);
        }
    }
}
