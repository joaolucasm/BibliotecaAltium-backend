using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class TransistoresComponentes : ComponenteBase
    {
        public string package { get; set; }
        public string npm_pnp {  get; set; }
        public string correnteColetor {  get; set; }

        public TransistoresComponentes() { }
    }
}
