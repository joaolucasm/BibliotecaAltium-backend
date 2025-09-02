using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class DiodosSchottkyComponentes : ComponenteBase
    {
        public string package { get; set; }
        public string simbolo { get; set; }
        public string correnteDireta {  get; set; }
        public string tensaoQueda { get; set; }
        
        public DiodosSchottkyComponentes() { }
    }
}
