namespace CursoPOO.Models
{
    public class Retangulo
    {
        //encapsulated vars only within this class
        private double comprimento;
        private double largura;
        private bool positivos;
        
        //Public method
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

        //print Area
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