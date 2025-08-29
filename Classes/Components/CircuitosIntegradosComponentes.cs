using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class CircuitosIntegradosComponentes : ComponenteBase
    {
        public string montagem {  get; set; }
        public string package { get; set; }
        public string subTipo { get; set; }

        public CircuitosIntegradosComponentes() { }
    }
}
