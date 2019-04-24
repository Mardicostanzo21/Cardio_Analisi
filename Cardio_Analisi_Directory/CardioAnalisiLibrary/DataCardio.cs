using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        public DataCardio ()    //Costruttore che mi permette di creare l'istanza di una classe
        {

        }

        //Eseguo un metodo per calcolare il massimo dei battiti al minuto

        public double CalcoloMaxBattitiCardiaci(int eta)
        {
            double maxbattiti = 0;
            maxbattiti = 220 - eta;
            return maxbattiti;
        }

        //Eseguo un metodo per calcolare il massimo dei battiti al minuto durante un esercizio fisico

        public double CalcoloMaxBattitiPalestra(int eta)
        {
            double maxbattiti = 0;
            double maxbattitipalestra = 0;
            maxbattiti = 220 - eta;
            maxbattitipalestra = (90 * maxbattiti) / 100;
            return maxbattitipalestra;
        }

        //Eseguo un metodo per calcolare il minimo dei battiti al minuto

        public double CalcoloMinBattitiPalestra(int eta)
        {
            double maxbattiti = 0;
            double minbattitipalestra = 0;
            maxbattiti = 220 - eta;
            minbattitipalestra = (70 * maxbattiti) / 100;
            return minbattitipalestra;
        }

           //Questo metodo prende i battiti di una persona in input e ti dice se sei bradicardiaco,tachicardiaco o con un numero di battiti nella norma 

        public string BattitARiposo(double battiti)
        {
            string risposta = "";
            if(battiti < 60)
            {
                risposta = "Bradicardia";
            }
            if(battiti >= 60 && battiti <= 100)
            {
                risposta = "Battiti nella norma";
            }
            if(battiti > 100)
            {
                risposta = "Tachicardia";
            }

            return risposta;
        }

        public double CalorieBruciateUomini (int duratasessione, double peso, double freqcardmedia, int eta)
        {
            double c = 0;
            c = ((eta * 0.2017) + (peso * 0.199) + (freqcardmedia + 0.6309) - 55.0969) * duratasessione / 4.184;
            c = Math.Round(c, 2);
            return c;
        }

        public double CalorieBruciateDonne (int duratasessione, double peso, double freqcardmedia, int eta)
        {
            double c = 0;
            c = ((eta * 0.074) + (peso * 0.126) + (freqcardmedia + 0.4472) - 20.4022) * duratasessione / 4.184;
            c = Math.Round(c, 2);
            return c;
        }

        public double SpesaEnergeticaCorsa (int kmpercorsi, int kgpesocorporeo)
        {
            double spesa = 0.9 * kmpercorsi + kgpesocorporeo;
            spesa = Math.Round(spesa, 2);
            return spesa;
        }

        public double SpesaEnergeticaCamminata(int kmpercorsi, int kgpesocorporeo)
        {
            double spesa = 0.5 * kmpercorsi + kgpesocorporeo;
            spesa = Math.Round(spesa, 2);
            return spesa;
        }

        public double CalcoloMediaBattitiGiornaliera(int[] battitiogniora)
        {
            double media = 0;
            for (int i = 0; i < battitiogniora.Length; i++)
            {
                media = media + battitiogniora[i];
            }
            media = media / battitiogniora.Length;
            return media;
        }

        //Per calcolare il battito cardiiaco a riposo bisogna prendere il bpm dopo essersi svegliati prendere minimo 4 valori
        //e poi fare la media
        public double CalcoloBattitiRiposo(int[]battitigiornalieri)
        {
            double media = CalcoloMediaBattitiGiornaliera(battitigiornalieri);
            return media;
        }

        public int[] OrdineCrescente(int[] battitigiornata)
        {
            int temp = 0;
            for (int j = 0; j < (battitigiornata.Length - 1); j++)
            {
                for (int i = 0; i < (battitigiornata.Length - 1); i++)
                {
                    if (battitigiornata[i] > battitigiornata[i + 1])
                    {
                        temp = battitigiornata[i];
                        battitigiornata[i] = battitigiornata[i + 1];
                        battitigiornata[i + 1] = temp;
                    }
                }
            }
            return battitigiornata;
        }

        public double HRV (double[]tempotraduebatti)
        {
            double frequenza = 0;
            double moltiplicazione;
            moltiplicazione = tempotraduebatti[0];
            for(int i = 1; i < tempotraduebatti.Length; i++)
            {
                moltiplicazione = moltiplicazione * tempotraduebatti[i];
            }
            frequenza = 1 / moltiplicazione;
            frequenza = Math.Round(frequenza, 2);
            return frequenza;
        }
    }
}
