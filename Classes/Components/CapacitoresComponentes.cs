using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class CapacitoresComponentes : ComponenteBase
    {
        public string tensao { get; set; }
        public string package { get; set; }
        public string subTipo { get; set; }
        public string polarizacao {  get; set; }
        public string tolerance { get; set; }
        public string montagem { get; set; }
        

        public CapacitoresComponentes() { }
    }
}
