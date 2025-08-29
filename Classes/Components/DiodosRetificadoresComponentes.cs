using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class DiodosRetificadoresComponentes : Objetos
    {
        public string montagem {  get; set; }
        public string correnteDireta { get; set; }

        public string tensaoQueda {  get; set; }
        public string tensaoMaximaReversa { get; set; }
        public string package {  get; set; }
        public string simbolo { get; set; }

        public DiodosRetificadoresComponentes() { }
    }
}
