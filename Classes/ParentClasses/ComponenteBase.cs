namespace BibliotecaAltium_backend.Classes.ParentClasses
{
    public class ComponenteBase
    {
        public string partNumber { get; set; }
        public string nome { get; set; }
        public string description { get; set; }
        public string manufacturer { get; set; }  
        public double value { get; set; }
        public string supplier1 { get; set; }
        public string supplier2 { get; set; }
        public string supplier3 { get; set; }
        public string supplierPartNumber1 { get; set; }
        public string supplierPartNumber2 { get; set; }
        public string supplierPartNumber3 { get; set; }
        public string tipo { get; set; } //Atributo para definição de componente

        public ComponenteBase() { }


    }
}
