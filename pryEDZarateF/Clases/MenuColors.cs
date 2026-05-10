using System.Drawing;
using System.Windows.Forms;

namespace pryEDZarateF
{
    /// <summary>
    /// Define los colores de hover y selección del menú principal del frmInicial.
    /// Se aplica con: menu.Renderer = new ToolStripProfessionalRenderer(new MenuColors());
    /// </summary>
    internal class MenuColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected => ColoresApp.MenuDropdownHover;
        public override Color MenuItemSelectedGradientBegin => ColoresApp.MenuHoverFondo;
        public override Color MenuItemSelectedGradientEnd => ColoresApp.MenuHoverFondo;
        public override Color MenuItemBorder => ColoresApp.MenuHoverBorde;
        public override Color MenuItemPressedGradientBegin => ColoresApp.MenuHoverFondo;
        public override Color MenuItemPressedGradientMiddle => ColoresApp.MenuHoverFondo;
        public override Color MenuItemPressedGradientEnd => ColoresApp.MenuHoverFondo;
        public override Color MenuBorder => ColoresApp.MenuFondo;
        public override Color ToolStripDropDownBackground => Color.White;
        public override Color ImageMarginGradientBegin => Color.White;
        public override Color ImageMarginGradientMiddle => Color.White;
        public override Color ImageMarginGradientEnd => Color.White;
    }
}
