using Interface_ClassAbstract.Model.Enums;

namespace Interface_ClassAbstract.Model.Entities{
    abstract class AbstractFiguraGeometrica : IFigurasGeometrica{
        // Propriedade abstrata que deve ser implementada pelas classes derivadas
        // Define a cor da figura geométrica usando o enum Cores
        public Cores Cor { get; set; }
        
        // Método abstrato que deve ser implementado pelas classes derivadas
        public abstract double Area();
        

    }
}
