using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.RealClasses
{
    public class MOSFETsComponentes : ComponenteBase
    {
        public string package { get; set; }
        public string montagem { get; set; }
        public string subTipo {  get; set; }
        public string canal {  get; set; }
        
        public MOSFETsComponentes() { }
    }
}
