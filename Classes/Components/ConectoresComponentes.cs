using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class ConectoresComponentes : ComponenteBase
    {
        public string subTipo { get; set; }
        public string montagem { get; set; }
        public string colunas { get; set; }
        public string totalPinos { get; set; }
        public string pinosPorColuna { get; set; }

        public ConectoresComponentes() { }
    }
}
