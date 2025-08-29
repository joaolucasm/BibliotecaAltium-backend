using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.RealClasses
{
    public class VaristoresComponentes: ComponenteBase
    {
        public string package { get; set; }
        public string simbolo { get; set; }
        public string tensaoAC { get; set; }
        public string tensaoDC { get; set; }
        public string tensaoClamp { get; set; }
        public string correnteDePicoMaxima { get; set; }
        public string montagem {  get; set; }
    }
}
