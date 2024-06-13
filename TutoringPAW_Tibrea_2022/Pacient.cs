using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringPAW_Tibrea_2022
{
    public class Pacient:ICloneable, IComparable
    {
        string nume;
        int varsta;
        float tarif_consultatie;

        public Pacient(string nume, int varsta, float tarif_consultatie)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.tarif_consultatie = tarif_consultatie;
        }

        public string Nume { get => nume; set => nume = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public float Tarif_consultatie { get => tarif_consultatie; set => tarif_consultatie = value; }

        public object Clone()
        {
            Pacient p = (Pacient)this.MemberwiseClone();
            return p;
        }

        public int CompareTo(object obj)
        {
           Pacient p = (Pacient)(obj);
            if(this.tarif_consultatie > p.tarif_consultatie)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return "Pacientul pe nume" + nume + " in varsta de " + varsta + " ani, plateste " + tarif_consultatie + " lei";
        }
    }
}
