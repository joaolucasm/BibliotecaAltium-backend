using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class FerriteBeadComponentes : ComponenteBase
    {
        public string correnteMax {  get; set; }
        public string impedancia { get; set; }
        public string tolerancia { get; set; }
        public string package { get; set; }
        public string tipo { get; set; }

        public FerriteBeadComponentes() { }

    }
}
