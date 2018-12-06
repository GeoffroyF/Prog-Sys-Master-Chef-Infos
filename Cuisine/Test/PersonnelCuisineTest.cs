using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PersonnelCuisineTest
    {
        private readonly Plongeur PlongeurUn;
        private readonly Plongeur PlongeurDeux;

        private readonly ChefSucre ChefSucreUn;
        private readonly ChefSucre chefSucreDeux;

        private readonly ChefSale ChefSaleUn;
        private readonly ChefSale chefSaleDeux;

        private readonly ChefCuisine ChefCuisineUn;
        private readonly ChefCuisine chefCuisineDeux;

        public PersonnelCuisineTest() {
            PlongeurUn = new Plongeur();
            PlongeurDeux = new Plongeur();

            ChefSucreUn = new ChefSucre();
            chefSucreDeux = new ChefSucre();

            ChefSaleUn = new ChefSale();
            chefSaleDeux = new ChefSale();

            ChefCuisineUn = new ChefCuisine();
            chefCuisineDeux = new ChefCuisine();
        }

        [TestMethod]
        public void TestSingletonPlongeur()
        {
            Assert.AreEqual(PlongeurUn.GetInstance(), PlongeurDeux.GetInstance(), "Le Plongeur n'est pas un singleton");
        }

        [TestMethod]
        public void TestSingletonChefSucre()
        {
            Assert.AreEqual(ChefSucreUn.GetInstance(), chefSucreDeux.GetInstance(), "Le ChefSucre n'est pas un singleton");
        }

        [TestMethod]
        public void TestSingletonChefSale()
        {
            Assert.AreEqual(ChefSaleUn.GetInstance(), chefSaleDeux.GetInstance(), "Le ChefSale n'est pas un singleton");
        }

        [TestMethod]
        public void TestSingletonChefCuisine()
        {
            Assert.AreEqual(ChefCuisineUn.GetInstance(), chefCuisineDeux.GetInstance(), "Le ChefCuisine n'est pas un singleton");
        }
    }
}
