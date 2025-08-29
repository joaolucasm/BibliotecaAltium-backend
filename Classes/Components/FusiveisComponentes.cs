using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class FusiveisComponentes : ComponenteBase
    {
        public string corrente {  get; set; }
        public string tensaoDC { get; set; }
        public string tensaoAC {  get; set; }
        public string montagem {  get; set; }
        public string simbolo { get; set; }
        public string package {  get; set; }

        public FusiveisComponentes() { }
    }
}
