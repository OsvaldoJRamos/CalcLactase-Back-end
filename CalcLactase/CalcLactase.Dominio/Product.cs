﻿using System;
using System.Collections.Generic;

namespace CalcLactase.Dominio
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayUnit { get; set; }
        public double DisplayUnitValue { get; set; }
        public double Grams { get; set; }
        public float PercentageOfLactose { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<Reference> References { get; set; }

        public Product(
            Guid id,
            string name,
            string displayUnit,
            double displayUnitValue,
            double grams,
            float percentageOfLactose,
            string imageUrl,
            IEnumerable<Reference> references)
        {
            Id = id;
            Name = name;
            DisplayUnit = displayUnit;
            DisplayUnitValue = displayUnitValue;
            Grams = grams;
            PercentageOfLactose = percentageOfLactose;
            ImageUrl = imageUrl;
            References = references;
        }

        protected Product() { }
    }
}
