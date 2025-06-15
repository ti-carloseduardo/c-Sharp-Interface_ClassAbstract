using System;


namespace Interface_ClassAbstract.Model.Entities
{
    class Retangulo : AbstractFiguraGeometrica
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area(){
            return Largura * Altura;
        }
        public override string ToString(){
            return "Retangulo cor: "
                + Cor
                + ", largura: "
                + Largura.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                + ", altura: "
                + Altura.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                + ", area: "
                + Area().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
