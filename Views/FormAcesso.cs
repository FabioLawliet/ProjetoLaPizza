using System.Windows.Forms;

namespace LaPizza.Views
{
    public partial class FormAcesso : Form
    {
        public FormAcesso()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
