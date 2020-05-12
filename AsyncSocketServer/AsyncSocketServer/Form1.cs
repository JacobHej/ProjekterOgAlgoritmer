using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncSocketServerLibrary;

namespace AsyncSocketServer
{
    public partial class Form1 : Form
    {
        SocketServer mServer;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            mServer = new SocketServer();
        }

        private void AcceptListenerBtn_Click(object sender, EventArgs e)
        {
            mServer.StartListeningForIncomingConnection(null,23000 + i);
            i++;
        }

        private void SendToAllBtn_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(textBox1.Text);
        }
    }
}
