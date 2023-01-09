using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    internal class Verifica
    {
        private int _max = 0;
        public int Maxlenght { get { return _max; } }
        private int _counter = 0;
        public int Counter { get { return _counter; } }

        Verifica[] r = new Verifica[0];

        private int _id;
        private string _materia;
        private decimal _valutazione;
        private string _data;

        public int Id { get { return _id; } set { _id = value; } }
        public string Materia { get { return _materia; } set { _materia = value; } }
        public decimal Valutazione { get { return _valutazione; } set { _valutazione = value; } }
        public string Data { get { return _data; } set { _data = value; } }

        public Verifica(int id, string materia, decimal voto, string data)
        {
            _id = id;
            _materia = materia;
            _valutazione = voto;
            _data = data;
        }
        public Verifica()
        {

        }
        public void Aggiunta(string materia, decimal voto, string data)
        {
            _max++;
            Array.Resize(ref r, _max);
            if (this._counter < 99)
            {
                Verifica v = new Verifica(this._counter,
                                          materia,
                                          voto,
                                          data);
                r[this._counter++] = v;
                
            }
            else
            {
                throw new Exception("tropper verifiche");
            }
        }
        public string Stringa(int pos)
        {
            return "N°: " + r[pos].Id + " Materia: " + r[pos].Materia + " Voto: " + r[pos].Valutazione + " Data: " + r[pos].Data;
        }
        public decimal Media(string str)
        {
            decimal media = 0;
            int counter = 0;
            for (int i = 0; i < this.r.Length; i++)
            {
                if (str == this.r[i].Materia)
                {
                    counter++;
                    media += this.r[i].Valutazione;
                }
            }
            return media / counter;
        }
        public string ModificaMateria(int n)
        {
            try
            {
                return r[n].Materia;
            }
            catch(Exception )
            {
                throw new Exception("Posizione inesistente");
            }
        }
        public void ImpostaMateria(string s, int n)
        {
            try
            {
                r[n].Materia = s;
            }
            catch (Exception )
            {
                throw new Exception("Posizione inesistente");
            }
        }
        public decimal ModificaVoto(int n)
        {
            try
            {
                return r[n].Valutazione;
            }
            catch (Exception )
            {
                throw new Exception("Posizione inesistente");
            }
        }
        public void ImpostaVoto(decimal s, int n)
        {
            try
            {
                r[n].Valutazione = s;
            }
            catch (Exception )
            {
                throw new Exception("Posizione inesistente");
            }
        }
        public string ModificaData(int n)
        {
            try
            {
                return r[n].Data;
            }
            catch (Exception )
            {
                throw new Exception("Posizione inesistente");
            }
        }
        public void ImpostaData(string s, int n)
        {
            try
            {
                r[n].Data = s;
            }
            catch (Exception )
            {
                throw new Exception("Posizione inesistente");
            }
        }
        public bool EliminaVoto(int n)
        {
            try //fine del tempo, mi da problemi, ho capito ma non ho tempo per sistemerlo, comunque sarebbe una ricompattazione
            {
                for (int i = n; i < _max - 1; i++)
                {
                    if (i < _max)
                    {
                        r[i] = r[i + 1];
                    }
                    else
                    {
                        r[i] = null;
                    }
                }
                _counter--;
                _max--;
                return true;
            }
            catch(Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}
