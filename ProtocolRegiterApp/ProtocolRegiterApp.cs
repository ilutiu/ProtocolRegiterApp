using System.Windows.Forms;

namespace ProtocolRegiterApp
{
    public partial class ProtocolRegiterApp : Form
    {
        public ProtocolRegiterApp()
        {
            InitializeComponent();
            lblParamValues.Text = string.Join(", ", Program.appParams);
        }
    }
}
