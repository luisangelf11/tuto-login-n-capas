using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentation
{
    public partial class ApplicationWF : Form
    {
        public ApplicationWF()
        {
            InitializeComponent();
        }

        private void ApplicationWF_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"Welcome: {AttributesUser.Name} {AttributesUser.Lastname}";
        }
    }
}
