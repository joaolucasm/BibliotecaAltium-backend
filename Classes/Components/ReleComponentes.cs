using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.RealClasses
{
    public class ReleComponentes : ComponenteBase
    {
        public string correnteMax {  get; set; }
        public string tensaoMax { get; set; }
        public string tensaoBobina { get; set; }
        
        public ReleComponentes() { }
    }
}
