using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telecomando
{
    internal class Telecomando      
    {
        private string produttore;
        private string modello;
        private string[] modalitaDiFunzionamento;
        private int canale;
        private int volume;
        private bool acceso;

        public Telecomando()
        {
            modalitaDiFunzionamento = new string[3];
            produttore = "Telecomando";
            modello = "X1";
            modalitaDiFunzionamento[0] = "Infrarossi";
            modalitaDiFunzionamento[1] = "Bluethoot";
            modalitaDiFunzionamento[2] = "WiFi";
        }

        public void setCanale(int x)
        {
            canale = x;
        }
        public void aumentaCanale()
        {
            canale++;
        }
        public void diminuisciCanale()
        {
            canale--;
        }
        public void aumentaVolume()
        {
            volume++;
        }
        public void diminuisciVolume()
        {
            volume--;
        }
        public void accendi()
        {
            acceso = true;
        }
        public void spengi()
        {
            acceso = false;
        }
        public string[] getModalita()
        {
            return modalitaDiFunzionamento;
        }
    }
}
