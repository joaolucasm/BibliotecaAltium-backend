using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class CapacitoresComponentes : Objetos
    {
        public string polarizacao {  get; set; }
        public string tensao { get; set; }
        public string package { get; set; }
        public string tolerance { get; set; }
        public string montagem { get; set; }
        public string subTipo { get; set; }
        public string f18 { get; set; }
        public string f19 { get; set; }
        public string f20 { get; set; }

        public CapacitoresComponentes() { }
    }
}
