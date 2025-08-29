using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class DiodosSchottkyComponentes : Objetos
    {
        public string correnteDireta {  get; set; }
        public string tensaoQueda { get; set; }
        public string package { get; set; }
        public string simbolo { get; set; }

        public DiodosSchottkyComponentes() { }
    }
}
