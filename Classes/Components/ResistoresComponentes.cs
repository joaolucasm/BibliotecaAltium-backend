using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.RealClasses
{
    public class ResistoresComponentes : ComponenteBase
    {
        public string potencia {  get; set; }
        public string tolerancia { get; set; }
        public string montagem { get; set; }
        public string simbolo { get; set; }
    }
}
