using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringPAW_Tibrea_2022
{
    public class Medic:ICalculVenitMedic
    {

        private string nume;
        private string specializare;
        private List<Pacient> listaPacienti;

        public Medic(string nume, string specializare)
        {
            this.nume = nume;
            this.specializare = specializare;
            this.listaPacienti = new List<Pacient>();
        }

        public string Nume { get => nume; set => nume = value; }
        public string Specializare { get => specializare; set => specializare = value; }
        public List<Pacient> ListaPacienti { get => listaPacienti; set => listaPacienti = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Medicul " + nume + " are specializarea " + specializare + " si pacientii: ");
            foreach(Pacient p in listaPacienti)
            {
                sb.Append(Environment.NewLine + p.ToString()); //in loc de Enviroment.NewLine se poate folosi "\n"
            }
            return sb.ToString();
        }

        public float calculeazaVenit()
        {
            float suma = 0;
            foreach(Pacient p in listaPacienti)
            {
                suma += p.Tarif_consultatie;
            }
            return suma;
        }

        //Medic m;
        //Pacient p;
        //m+=p
        public static Medic operator+(Medic m, Pacient p)
        {
            m.listaPacienti.Add(p);
            return m;
        }

        //Medic m;
        //m[0] //ca sa imi dea primul element din lista de medici

        public Pacient this[int index]
        {
            get
            {
                if(index >= 0 && index < listaPacienti.Count)
                {
                    return listaPacienti[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < listaPacienti.Count)
                {
                    listaPacienti[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
