using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UstencilesTest
    {

        public UstencilesTest()
        {
        }

        [TestMethod]
        public void TestSingletonUstenciles()
        {
            Assert.AreEqual(Ustenciles.getInstance(5, 5, 5, 5, 5, 5, 5, 5), Ustenciles.getInstance(), true, "Ustenciles is not a singleton");
        }

        // Test of Casseroles
        [TestMethod]
        public void TestCasserolesAdd()
        {
            var tmp = Ustenciles.getCasseroles();
            Ustenciles.setCasseroles(5);
            Assert.AreEqual(Ustenciles.getCasseroles(), tmp + 5, true, "Casseroles did not increase");
        }
        [TestMethod]
        public void TestCasserolesMin()
        {
            var tmp = Ustenciles.getCasseroles();
            Ustenciles.setCasseroles(-5);
            Assert.AreEqual(Ustenciles.getCasseroles(), tmp - 5, true, "Casseroles did not decrease");
        }

        // Test of Poels
        [TestMethod]
        public void TestPoelsAdd()
        {
            var tmp = Ustenciles.getPoels();
            Ustenciles.setPoels(5);
            Assert.AreEqual(Ustenciles.getPoels(), tmp + 5, true, "Poels did not increase");
        }
        [TestMethod]
        public void TestPoelsMin()
        {
            var tmp = Ustenciles.getPoels();
            Ustenciles.setPoels(-5);
            Assert.AreEqual(Ustenciles.getPoels(), tmp - 5, true, "Poels did not decrease");
        }

        // Test of CuilliereBois
        [TestMethod]
        public void TestCuilliereBoisAdd()
        {
            var tmp = Ustenciles.getCuilliereBois();
            Ustenciles.setCuilliereBois(5);
            Assert.AreEqual(Ustenciles.getCuilliereBois(), tmp + 5, true, "CuilliereBois did not increase");
        }
        [TestMethod]
        public void TestCuilliereBoisMin()
        {
            var tmp = Ustenciles.getCuilliereBois();
            Ustenciles.setCuilliereBois(-5);
            Assert.AreEqual(Ustenciles.getCuilliereBois(), tmp - 5, true, "CuilliereBois did not decrease");
        }

        // Test of BolSalades
        [TestMethod]
        public void TestBolSaladesAdd()
        {
            var tmp = Ustenciles.getBolSalades();
            Ustenciles.setBolSalades(5);
            Assert.AreEqual(Ustenciles.getBolSalades(), tmp + 5, true, "BolSalades did not increase");
        }
        [TestMethod]
        public void TesBolSaladesMin()
        {
            var tmp = Ustenciles.getBolSalades();
            Ustenciles.setBolSalades(-5);
            Assert.AreEqual(Ustenciles.getBolSalades(), tmp - 5, true, "BolSalades did not decrease");
        }

        // Test of PresseAgrumes
        [TestMethod]
        public void TestPresseAgrumesAdd()
        {
            var tmp = Ustenciles.getPresseAgrumes();
            Ustenciles.setPresseAgrumes(5);
            Assert.AreEqual(Ustenciles.getPresseAgrumes(), tmp + 5, true, "PresseAgrumes did not increase");
        }
        [TestMethod]
        public void TesPresseAgrumessMin()
        {
            var tmp = Ustenciles.getPresseAgrumes();
            Ustenciles.setPresseAgrumes(-5);
            Assert.AreEqual(Ustenciles.getPresseAgrumes(), tmp - 5, true, "PresseAgrumes did not decrease");
        }

        // Test of Tamis
        [TestMethod]
        public void TestTamisAdd()
        {
            var tmp = Ustenciles.getTamis();
            Ustenciles.setTamiss(5);
            Assert.AreEqual(Ustenciles.getTamis(), tmp + 5, true, "Tamis did not increase");
        }
        [TestMethod]
        public void TesTamisMin()
        {
            var tmp = Ustenciles.getTamis();
            Ustenciles.setTamis(-5);
            Assert.AreEqual(Ustenciles.getTamis(), tmp - 5, true, "Tamis did not decrease");
        }

        // Test of Entoinnoirs
        [TestMethod]
        public void TestEntoinnoirsAdd()
        {
            var tmp = Ustenciles.getEntoinnoirs();
            Ustenciles.setEntoinnoirs(5);
            Assert.AreEqual(Ustenciles.getEntoinnoirs(), tmp + 5, true, "Entoinnoirs did not increase");
        }
        [TestMethod]
        public void TesEntoinnoirsMin()
        {
            var tmp = Ustenciles.getEntoinnoirs();
            Ustenciles.setEntoinnoirs(-5);
            Assert.AreEqual(Ustenciles.getEntoinnoirs(), tmp - 5, true, "Entoinnoirs did not decrease");
        }

        // Test of Couteaux
        [TestMethod]
        public void TestCouteauxAdd()
        {
            var tmp = Ustenciles.getCouteaux();
            Ustenciles.setCouteaux(5);
            Assert.AreEqual(Ustenciles.getCouteaux(), tmp + 5, true, "Couteaux did not increase");
        }
        [TestMethod]
        public void TesCouteauxMin()
        {
            var tmp = Ustenciles.getCouteaux();
            Ustenciles.setCouteaux(-5);
            Assert.AreEqual(Ustenciles.getCouteaux(), tmp - 5, true, "Couteaux did not decrease");
        }
    }
}
