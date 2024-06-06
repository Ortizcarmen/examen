namespace examen
{
    public class Dispositivo
    {
        public int NumeroSerie {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Dispositivo() 
        {
            NumeroSerie = 0;
            Marca = string.Empty;
            Modelo = string.Empty;
        }
    }
}
