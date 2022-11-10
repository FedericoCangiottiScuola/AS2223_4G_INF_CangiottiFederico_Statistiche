using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_CangiottiFederico_Statistiche
{
    public class Statistiche
    {
        int numeroValori = 0;
        int sommaValori = 0;
        double sommaValoriPerPeso = 0;
        double sommaPesi = 0;

        public Statistiche()
        {

        }

        /// <summary>
        /// Aggiungi un valore senza peso per le statistiche (media aritmetica)
        /// </summary>
        /// <param name="valore"></param>
        public void AddValue(int valore)
        {
            sommaValori += valore;
            numeroValori++;
        }

        /// <summary>
        /// Aggiungi un valore con peso per le statistiche (media ponderata)
        /// </summary>
        /// <param name="valore"></param>
        /// <param name="peso"></param>
        public void AddValue(int valore, double peso)
        {
            sommaValoriPerPeso += valore * peso;
            sommaPesi += peso;
            numeroValori++;
        }

        /// <summary>
        /// Ritorna la media aritmetica dei valori :
        ///     mediaAritmetica = sommaValori/numeroValori
        /// </summary>
        /// <returns></returns>
        public double MediaAritmetica()
        {
            return (double)sommaValori / numeroValori;
        }

        /// <summary>
        /// Ritorna la media ponderata dei valori :
        ///     mediaPonderata = sommaValoriPerPeso/sommaPesi
        /// </summary>
        /// <returns></returns>
        public double MediaPonderata()
        {
            return sommaValoriPerPeso / sommaPesi;
        }

        /// <summary>
        /// Azzera i valori inseriti per la statistica
        /// </summary>
        public void ClearValue()
        {
            numeroValori = 0;
            sommaValori = 0;
            sommaValoriPerPeso = 0;
            sommaPesi = 0;
        }

        /// <summary>
        /// Ritorna il numero di elementi inseriti per la statistica
        /// </summary>
        /// <returns></returns>
        public int CountValue()
        {
            return numeroValori;
        }
    }
}
