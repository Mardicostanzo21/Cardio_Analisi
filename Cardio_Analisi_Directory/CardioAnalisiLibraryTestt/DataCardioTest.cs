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
        [TestMethod]
        public void TestCalorieBruciateUomini()
        {
            DataCardio cardio = new DataCardio();
            double caloriebruciate = cardio.CalorieBruciateUomini(60, 80.5, 90, 18);
            Assert.AreEqual(791.36, caloriebruciate);
        }
        [TestMethod]
        public void TestCalorieBruciateDonne()
        {
            DataCardio cardio = new DataCardio();
            double caloriebruciate = cardio.CalorieBruciateDonne(60, 80.5, 90, 18);
            Assert.AreEqual(1169.02, caloriebruciate);
        }

        [TestMethod]
        public void TestSpesaEnergeticaCorsa()
        {
            DataCardio cardio = new DataCardio();
            double spesa = cardio.SpesaEnergeticaCorsa(10, 80);
            Assert.AreEqual(89, spesa);
        }

        [TestMethod]
        public void TestSpesaEnergeticaCamminata()
        {
            DataCardio cardio = new DataCardio();
            double spesa = cardio.SpesaEnergeticaCamminata(10, 80);
            Assert.AreEqual(85, spesa);
        }

        [TestMethod]
        public void TestOrdineCrescente()
        {
            DataCardio cardio = new DataCardio();
            int[] bpmgiornata = new int[4] { 40, 38, 48, 35 };
            bpmgiornata = cardio.OrdineCrescente(bpmgiornata);
            Assert.AreEqual(35, bpmgiornata[0]);
        }

        [TestMethod]
        public void TestCalcoloMediaBattitiGiornaliera()
        {
            DataCardio cardio = new DataCardio();
            int[] bpmgiornata = new int[4] { 40, 38, 48, 35 };
            double media;
            media = cardio.CalcoloMediaBattitiGiornaliera(bpmgiornata);
            Assert.AreEqual(40.25, media);
        }

        [TestMethod]
        public void TestCalcoloBattitiRiposo()
        {
            DataCardio cardio = new DataCardio();
            int[] bpmgiornata = new int[4] { 40, 38, 48, 35 };
            double media;
            media = cardio.CalcoloBattitiRiposo(bpmgiornata);
            Assert.AreEqual(40.25, media);
        }

        [TestMethod]
        public void TestHRV()
        {
            DataCardio cardio = new DataCardio();
            double frequenza = 0;
            double[] tempitempotraduebatti = new double[5] { 0.8, 1.2, 1.0, 0.6, 0.9 };
            frequenza = cardio.HRV(tempitempotraduebatti);
            Assert.AreEqual(1.93, frequenza);
        }
    }
}
