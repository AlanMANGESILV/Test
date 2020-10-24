using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class Paye : Employe
    {
        private int payeParHeure;
        public Paye(string FN, string LN, int SSN) : base(FN,LN,SSN)
        {
            payeParHeure = 10;
        }

        public int PayeParHeure
        {
            get { return this.payeParHeure; }
            set { this.payeParHeure = value; }
        }

        public double Salaire1()
        {
            double salaire;
            if (Commission)
            {
                if(CommissionSalariedEmployees)
                {
                    salaire=HeureTravail*PayeParHeure+Sales*0.8;
                }
                else
                {
                    salaire = Sales * 0.8;
                }
                
            }
            else
            {
                if (HeureTravail > 45)
                {
                    salaire = HeureTravail * PayeParHeure + (HeureTravail - 40) * (PayeParHeure / 2);
                }
                else
                {
                    salaire = HeureTravail * PayeParHeure;
                }
            }
            
            return salaire;

            
        }



      
    }
}
