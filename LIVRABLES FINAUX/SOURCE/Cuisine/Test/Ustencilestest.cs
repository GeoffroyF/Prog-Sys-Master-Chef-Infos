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
            Assert.AreEqual(Ustenciles.GetInstance(5, 5, 5, 5, 5, 5, 5, 5), Ustenciles.GetInstance(), "Ustenciles is not a singleton");
        }

        // Test of Casseroles
        [TestMethod]
        public void TestCasserolesAdd()
        {
            var tmp = Ustenciles.GetInstance().GetCasseroles();
            Ustenciles.GetInstance().SetCasseroles(5);
            Assert.AreEqual(Ustenciles.GetInstance().GetCasseroles(), tmp + 5, "Casseroles did not increase");
        }
        [TestMethod]
        public void TestCasserolesMin()
        {
            var tmp = Ustenciles.GetInstance().GetCasseroles();
            Ustenciles.GetInstance().SetCasseroles(-5);
            Assert.AreEqual(Ustenciles.GetInstance().GetCasseroles(), tmp - 5, "Casseroles did not decrease");
        }

        // Test of Poels
        [TestMethod]
        public void TestPoelsAdd()
        {
            var tmp = Ustenciles.GetInstance().GetPoels();
            Ustenciles.GetInstance().SetPoels(5);
            Assert.AreEqual(Ustenciles.GetInstance().GetPoels(), tmp + 5, "Poels did not increase");
        }
        [TestMethod]
        public void TestPoelsMin()
        {
            var tmp = Ustenciles.GetInstance().GetPoels();
            Ustenciles.GetInstance().SetPoels(-5);
            Assert.AreEqual(Ustenciles.GetInstance().GetPoels(), tmp - 5, "Poels did not decrease");
        }

        // Test of CuilliereBois
        [TestMethod]
        public void TestCuilliereBoisAdd()
        {
            var tmp = Ustenciles.GetInstance().GetCuilliereBois();
            Ustenciles.GetInstance().SetCuilliereBois(5);
            Assert.AreEqual(Ustenciles.GetInstance().GetCuilliereBois(), tmp + 5, "CuilliereBois did not increase");
        }
        [TestMethod]
        public void TestCuilliereBoisMin()
        {
            var tmp = Ustenciles.GetInstance().GetCuilliereBois();
            Ustenciles.GetInstance().SetCuilliereBois(-5);
            Assert.AreEqual(Ustenciles.GetInstance().GetCuilliereBois(), tmp - 5, "CuilliereBois did not decrease");
        }

        // Test of BolSalades
        [TestMethod]
        public void TestBolSaladesAdd()
        {
            var tmp = Ustenciles.GetInstance().GetBolSalades();
            Ustenciles.GetInstance().SetBolSalades(5);
            Assert.AreEqual(Ustenciles.GetInstance().GetBolSalades(), tmp + 5, "BolSalades did not increase");
        }
        [TestMethod]
        public void TesBolSaladesMin()
        {
            var tmp = Ustenciles.GetInstance().GetBolSalades();
            Ustenciles.GetInstance().SetBolSalades(-5);
            Assert.AreEqual(Ustenciles.GetInstance().GetBolSalades(), tmp - 5, "BolSalades did not decrease");
        }

        // Test of PresseAgrumes
        [TestMethod]
        public void TestPresseAgrumesAdd()
        {
            var tmp = Ustenciles.GetInstance().GetPresseAgrumes();
            Ustenciles.GetInstance().SetPresseAgrumes(5);
            Assert.AreEqual(Ustenciles.GetInstance().GetPresseAgrumes(), tmp + 5, "PresseAgrumes did not increase");
        }
        [TestMethod]
        public void TesPresseAgrumessMin()
        {
            var tmp = Ustenciles.GetInstance().GetPresseAgrumes();
            Ustenciles.GetInstance().SetPresseAgrumes(-5);
            Assert.AreEqual(Ustenciles.GetInstance().GetPresseAgrumes(), tmp - 5, "PresseAgrumes did not decrease");
        }

        // Test of Tamis
        [TestMethod]
        public void TestTamisAdd()
        {
            var tmp = Ustenciles.GetInstance().GetTamis();
            Ustenciles.GetInstance().SetTamis(5);
            Assert.AreEqual(Ustenciles.GetInstance().GetTamis(), tmp + 5, "Tamis did not increase");
        }
        [TestMethod]
        public void TesTamisMin()
        {
            var tmp = Ustenciles.GetInstance().GetTamis();
            Ustenciles.GetInstance().SetTamis(-5);
            Assert.AreEqual(Ustenciles.GetInstance().GetTamis(), tmp - 5, "Tamis did not decrease");
        }

        // Test of Entoinnoirs
        [TestMethod]
        public void TestEntoinnoirsAdd()
        {
            var tmp = Ustenciles.GetInstance().GetEntoinnoirs();
            Ustenciles.GetInstance().SetEntoinnoirs(5);
            Assert.AreEqual(Ustenciles.GetInstance().GetEntoinnoirs(), tmp + 5, "Entoinnoirs did not increase");
        }
        [TestMethod]
        public void TesEntoinnoirsMin()
        {
            var tmp = Ustenciles.GetInstance().GetEntoinnoirs();
            Ustenciles.GetInstance().SetEntoinnoirs(-5);
            Assert.AreEqual(Ustenciles.GetInstance().GetEntoinnoirs(), tmp - 5, "Entoinnoirs did not decrease");
        }

        // Test of Couteaux
        [TestMethod]
        public void TestCouteauxAdd()
        {
            var tmp = Ustenciles.GetInstance().GetCouteaux();
            Ustenciles.GetInstance().SetCouteaux(5);
            Assert.AreEqual(Ustenciles.GetInstance().GetCouteaux(), tmp + 5, "Couteaux did not increase");
        }
        [TestMethod]
        public void TesCouteauxMin()
        {
            var tmp = Ustenciles.GetInstance().GetCouteaux();
            Ustenciles.GetInstance().SetCouteaux(-5);
            Assert.AreEqual(Ustenciles.GetInstance().GetCouteaux(), tmp - 5, "Couteaux did not decrease");
        }
    }
}
