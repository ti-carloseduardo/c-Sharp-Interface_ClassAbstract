using System;
using Interface_ClassAbstract.Model.Enums;

namespace Interface_ClassAbstract.Model.Entities{
    abstract class FiguraGeometrica{
        public Cores Cor { get; set; }
        public abstract double Area(); 
    }
}
