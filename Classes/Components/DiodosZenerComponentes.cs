using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class DiodosZenerComponentes : Objetos
    {
        public string montagem {  get; set; }
        public string simbolo { get; set; }
        public string package { get; set; }
        public string tensaoZener {  get; set; }
        public string toleranciaTensao { get; set; }
        public string correnteReversaMax {  get; set; }
        public string dissipacaoPot {  get; set; }

        public DiodosZenerComponentes() { }
    }
}
