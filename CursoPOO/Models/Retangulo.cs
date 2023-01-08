namespace CursoPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool positivos;
    
        public void DefinirMedidas(double comprimento, double largura)
        {
            if( comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                positivos = true;
            }        
            else
            {
                System.Console.WriteLine("Informe valores positivos para as medidas");
            }   
        }
        public double Area()
        {
            if(positivos)
            {
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Defina valores positivos");
                return 0;
            }
        }
    }    
}