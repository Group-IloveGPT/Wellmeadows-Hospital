using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wellmeadows_Hospital.View
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        public void loadForm(Form form)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            this.pnlMain.Tag = form;
            form.Show();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            loadForm(new Staff());
        }
    }
}
