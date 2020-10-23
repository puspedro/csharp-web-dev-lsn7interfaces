using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class Case
    {
        public List<Flavor> Flavors { get; set; }
        public List<Cone> Cones { get; set; }

        public Case()
        {
            Cones = new List<Cone>();
            Cone cone1 = new Cone("Waffle", 1.25, new List<string> { "gluten" });
            Cone cone2 = new Cone("Sugar", 0.75, new List<string> { "gluten" });
            Cone cone3 = new Cone("Wafer", 0.50, new List<string> { "gluten" });
            Cone cone4 = new Cone("Bowl", 0.05, new List<string> { "none" });
            Cones.Add(cone1);
            Cones.Add(cone2);
            Cones.Add(cone3);
            Cones.Add(cone4);

            Flavors = new List<Flavor>();
            Flavor flavor1 = new Flavor("Vanilla", 0.75, new List<string> { "dairy" });
            Flavor flavor2 = new Flavor("Chocolate", 0.75, new List<string> { "dairy" });
            Flavor flavor3 = new Flavor("Red Velvet", 0.85, new List<string> { "dairy", "red #5" });
            Flavor flavor4 = new Flavor("Rocky Road", 0.85, new List<string> { "dairy", "nuts", "gelatin" });
            Flavor flavor5 = new Flavor("Strawberry Sorbet", 0.50, new List<string> { "strawberry" });
            Flavors.Add(flavor1);
            Flavors.Add(flavor2);
            Flavors.Add(flavor3);
            Flavors.Add(flavor4);
            Flavors.Add(flavor5);
        }
        public override string ToString()
        {
            StringBuilder stringToBe = new StringBuilder();
            stringToBe.Append("Flavors!!!");
            foreach(Flavor flavor in Flavors)
            {
                stringToBe.Append($"\n{flavor.Name} : {flavor.Cost} : ");
                foreach(string allergen in flavor.Allergens)
                {
                    stringToBe.Append($"{allergen}, ");
                }
            }
            stringToBe.Append("\n\nCones!!!");
            foreach(Cone cone in Cones)
            {
                stringToBe.Append($"\n{cone.Name} : {cone.Cost} : ");
                foreach(string allergen in cone.Allergens)
                {
                    stringToBe.Append($"{allergen}, ");
                }
            }
            return stringToBe.ToString();
        }
    }
}
