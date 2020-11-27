using System;
using System.Collections.Generic;

namespace CalcLactase
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayUnit { get; set; }
        public double DisplayUnitValue { get; set; }
        public double Grams { get; set; }
        public double PercentagemOfLactose { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<References> References { get; set; }

        public Produto(
            Guid id, 
            string name, 
            string displayUnit, 
            double displayUnitValue,
            double grams, 
            double percentagemOfLactose, 
            string imageUrl, 
            IEnumerable<References> references)
        {
            Id = id;
            Name = name;
            DisplayUnit = displayUnit;
            DisplayUnitValue = displayUnitValue;
            Grams = grams;
            PercentagemOfLactose = percentagemOfLactose;
            ImageUrl = imageUrl;
            References = references;
        }
    }
}
