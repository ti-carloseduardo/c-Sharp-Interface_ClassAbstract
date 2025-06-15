using System;


namespace Interface_ClassAbstract.Model.Entities
{
    class Circulo : FiguraGeometrica
    {
        public double Raio { get; set; }

        public override double Area(){
            return Math.PI * Raio * Raio;
        }
        public override string ToString(){
            return "Circulo cor: "
                + Cor
                + ", raio: "
                + Raio.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                + ", area: "
                + Area().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
