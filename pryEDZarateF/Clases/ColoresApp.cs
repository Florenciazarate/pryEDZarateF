using System.Drawing;

namespace pryEDZarateF
{
    /// <summary>
    /// Paleta de colores centralizada de la aplicación.
    /// Cambiá un color acá y se actualiza en todos los formularios.
    /// </summary>
    public static class ColoresApp
    {
        // ============================================================
        //  Neutros (compartidos por todos los formularios)
        // ============================================================

        // Textos
        public static readonly Color TextoTitulo = Color.FromArgb(15, 23, 42);
        public static readonly Color TextoGrilla = Color.FromArgb(30, 41, 59);
        public static readonly Color TextoEtiqueta = Color.FromArgb(71, 85, 105);
        public static readonly Color TextoSubtitulo = Color.FromArgb(100, 116, 139);
        public static readonly Color TextoFooter = Color.FromArgb(148, 163, 184);
        public static readonly Color TextoCombo = Color.FromArgb(68, 88, 112);

        // Fondos
        public static readonly Color FondoForm = Color.FromArgb(244, 246, 250);
        public static readonly Color FondoFormPrincipal = Color.FromArgb(226, 232, 240);
        public static readonly Color FondoListBox = Color.FromArgb(248, 250, 252);
        public static readonly Color MenuFondo = Color.FromArgb(30, 41, 59);

        // Bordes y sombras
        public static readonly Color BordeSuave = Color.FromArgb(229, 231, 235);
        public static readonly Color SombraPanel = Color.FromArgb(220, 225, 235);
        public static readonly Color BordeRadio = Color.FromArgb(180, 180, 180);

        // Estados deshabilitados
        public static readonly Color BordeDisabled = Color.FromArgb(208, 208, 208);
        public static readonly Color FondoTextDisabled = Color.FromArgb(226, 226, 226);
        public static readonly Color TextoDisabled = Color.FromArgb(138, 138, 138);
        public static readonly Color TextoBotonDisabled = Color.FromArgb(156, 163, 175);
        public static readonly Color FondoBotonDisabled = Color.FromArgb(229, 231, 235);

        // Botón Eliminar (rojo, igual en todos los formularios)
        public static readonly Color RojoEliminar = Color.FromArgb(239, 68, 68);
        public static readonly Color RojoEliminarHover = Color.FromArgb(220, 38, 38);

        // ============================================================
        //  Colores del menú lateral hover (frmInicial)
        // ============================================================
        public static readonly Color MenuHoverFondo = Color.FromArgb(71, 85, 105);
        public static readonly Color MenuHoverBorde = Color.FromArgb(203, 213, 225);
        public static readonly Color MenuDropdownHover = Color.FromArgb(241, 245, 249);

        // ============================================================
        //  Acentos por formulario
        // ============================================================

        // frmListaSimple - Indigo
        public static readonly Color Indigo = Color.FromArgb(99, 102, 241);
        public static readonly Color IndigoHover = Color.FromArgb(79, 82, 221);
        public static readonly Color IndigoBordeHover = Color.FromArgb(180, 184, 220);
        public static readonly Color IndigoFondoSuave = Color.FromArgb(243, 244, 254);
        public static readonly Color IndigoFondoSeleccion = Color.FromArgb(238, 242, 255);

        // frmListaDoble - Violeta
        public static readonly Color Violeta = Color.FromArgb(139, 92, 246);
        public static readonly Color VioletaHover = Color.FromArgb(124, 58, 237);
        public static readonly Color VioletaBordeHover = Color.FromArgb(196, 181, 253);
        public static readonly Color VioletaFondoSuave = Color.FromArgb(245, 243, 255);

        // frmPila - Azul
        public static readonly Color Azul = Color.FromArgb(59, 130, 246);
        public static readonly Color AzulHover = Color.FromArgb(37, 99, 235);
        public static readonly Color AzulBordeHover = Color.FromArgb(147, 197, 253);
        public static readonly Color AzulFondoSuave = Color.FromArgb(239, 246, 255);

        // frmCola - Cian
        public static readonly Color Cian = Color.FromArgb(6, 182, 212);
        public static readonly Color CianHover = Color.FromArgb(8, 145, 178);
        public static readonly Color CianBordeHover = Color.FromArgb(165, 243, 252);
        public static readonly Color CianFondoSuave = Color.FromArgb(236, 254, 255);

        // frmAlumnos - Rosa
        public static readonly Color Rosa = Color.FromArgb(244, 63, 94);
        public static readonly Color RosaHover = Color.FromArgb(225, 29, 72);
        public static readonly Color RosaBordeHover = Color.FromArgb(254, 205, 211);
        public static readonly Color RosaFondoSuave = Color.FromArgb(255, 241, 242);

        // frmCarreras - Verde
        public static readonly Color Verde = Color.FromArgb(16, 185, 129);
        public static readonly Color VerdeHover = Color.FromArgb(5, 150, 105);
        public static readonly Color VerdeBordeHover = Color.FromArgb(167, 243, 208);

        // frmClientes - Naranja
        public static readonly Color Naranja = Color.FromArgb(249, 115, 22);
        public static readonly Color NaranjaHover = Color.FromArgb(234, 88, 12);
        public static readonly Color NaranjaBordeHover = Color.FromArgb(254, 215, 170);
        public static readonly Color NaranjaFondoSuave = Color.FromArgb(255, 247, 237);

        // frmColores - Magenta
        public static readonly Color Magenta = Color.FromArgb(236, 72, 153);
        public static readonly Color MagentaHover = Color.FromArgb(219, 39, 119);
        public static readonly Color MagentaBordeHover = Color.FromArgb(251, 207, 232);
        public static readonly Color MagentaFondoSuave = Color.FromArgb(252, 231, 243);

        // frmMeses - Ámbar
        public static readonly Color Ambar = Color.FromArgb(245, 158, 11);
        public static readonly Color AmbarHover = Color.FromArgb(217, 119, 6);
        public static readonly Color AmbarBordeHover = Color.FromArgb(253, 230, 138);
        public static readonly Color AmbarFondoSuave = Color.FromArgb(254, 243, 199);
    }
}
