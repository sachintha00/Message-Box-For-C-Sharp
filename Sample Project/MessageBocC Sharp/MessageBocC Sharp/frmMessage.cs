﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDMessageBox;

namespace MessageBocC_Sharp
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void btnInformation_Click_1(object sender, EventArgs e)
        {
            SMDMessage.show("Title", "Information", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            SMDMessage.show("Title", "Error", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            SMDMessage.show("Title", "Warning", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Warning);
        }

        private void btnQuestion(object sender, EventArgs e)
        {
            SMDMessage.show("Title", "Question", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Question);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
