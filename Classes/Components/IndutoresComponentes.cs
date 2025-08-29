using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class IndutoresComponentes : ComponenteBase
    {
        public string simbolo {  get; set; }
        public string subTipo {  get; set; }
        public string correnteMax {  get; set; }
        public string tolerancia { get; set; }
        public string package {  get; set; }

        public IndutoresComponentes() { }
    }
}
