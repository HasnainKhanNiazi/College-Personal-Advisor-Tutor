using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SEGP
{
    public partial class Developers : DevExpress.XtraEditors.XtraUserControl
    {
        public Developers()
        {
            InitializeComponent();
        }

        private void Developers_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "E:/Workspace C#/SEGP/DVELEOPERS.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
