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

    }
}
