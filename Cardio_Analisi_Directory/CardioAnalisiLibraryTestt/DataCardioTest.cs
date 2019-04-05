using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioAnalisiLibrary;

namespace CardioAnalisiLibraryTestt
{
    //Eseguo dei test per controllare che i metodi funzionino tutti

    [TestClass]
    public class DataCardioTest
    {
        [TestMethod]
        public void TestCalcoloMaxBattitiCardiaci()
        {
            DataCardio cardio = new DataCardio();
            double risultato = cardio.CalcoloMaxBattitiCardiaci(18);
            Assert.AreEqual(202, risultato);
        }
        [TestMethod]
        public void TestCalcoloMaxBattitiPalestra()
        {
            DataCardio cardio = new DataCardio();
            double risultato = cardio.CalcoloMaxBattitiPalestra(18);
            Assert.AreEqual(181.8, risultato);

        }
        [TestMethod]
        public void TestCaloloMinBattitiPalestra()
        {
            DataCardio cardio = new DataCardio();
            double risultato = cardio.CalcoloMinBattitiPalestra(18);
            Assert.AreEqual(141.4, risultato);
        }
        [TestMethod]
        public void TestBattitiARiposo()
        {
            DataCardio cardio = new DataCardio();
            string risultato = cardio.BattitARiposo(59);
            Assert.AreEqual("Bradicardia", risultato);
        }
    }
}
