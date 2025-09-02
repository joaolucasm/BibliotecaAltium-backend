using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class LEDComponentes : ComponenteBase
    {
        public string package { get; set; }
        public string montagem { get; set; }
        public string subTipo {  get; set; }
        public string cor {  get; set; }
        public string corrente { get; set; }
        public string tensao { get; set; }
        public LEDComponentes() { }
    }
}
