using BibliotecaAltium_backend.Classes.ParentClasses;

namespace BibliotecaAltium_backend.Classes.Components
{
    public class DiodosTVSComponentes : ComponenteBase
    {
        public string package { get; set; }
        public string montagem {  get; set; }
        public string breakdownVoltage { get; set; }
        public string peakPulsePower { get; set; }
        public string direcional {  get; set; }

        public DiodosTVSComponentes() { }
    }
}
