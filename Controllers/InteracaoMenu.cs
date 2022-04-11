using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class InteracaoMenu
    {
        public void MostraOuEsconde(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }

        public void EscondeTodos(Control.ControlCollection controls)
        {
            foreach (Control ctr in controls)
                if (ctr is Panel)
                    if (ctr.Name.Contains("pnlSubMenu"))
                        ctr.Visible = false;
        }
    }
}
