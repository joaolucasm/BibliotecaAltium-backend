using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class BateriasComponentes : ComponenteBase
    {
        public string tensao {  get; set; }
        public string package { get; set; }
        public string currentDiscarge {  get; set; }

        public BateriasComponentes() { }
    }
}
