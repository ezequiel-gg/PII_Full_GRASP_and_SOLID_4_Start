//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        private static ProductCatalog productCatalog = new ProductCatalog();

        private static EquipmentCatalog equipmentCatalog = new EquipmentCatalog();

        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = productCatalog.GetItemByDescription("Café con leche") as Product;
            recipe.AddStep(productCatalog.GetItemByDescription("Café") as Product, 100, equipmentCatalog.GetItemByDescription("Cafetera") as Equipment, 120);
            recipe.AddStep(productCatalog.GetItemByDescription("Leche") as Product, 200, equipmentCatalog.GetItemByDescription("Hervidor") as Equipment, 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        private static void PopulateCatalogs()
        {
            productCatalog.AddItem("Café", 100);
            productCatalog.AddItem("Leche", 200);
            productCatalog.AddItem("Café con leche", 300);

            equipmentCatalog.AddItem("Cafetera", 1000);
            equipmentCatalog.AddItem("Hervidor", 2000);
        }
    }
}
