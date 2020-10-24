using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class Employe
    {
        private string firstName;
        private string lastName;
        private int socialSecurityNumber;
        private int heureTravail;
        private int sales;
        private bool commission;
        private bool commissionSalariedEmployees;

        public Employe(string FN,string LN,int SSN)
        {
            this.firstName = FN;
            this.lastName = LN;
            this.socialSecurityNumber = SSN;
            sales = 500;
        }

        public int Sales
        {
            get { return this.sales; }
            set { this.sales = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int SocialSecurityName
        {
            get { return this.socialSecurityNumber; }
            set { this.socialSecurityNumber = value; }
        }
        public int HeureTravail
        {
            get { return this.heureTravail; }
            set { this.heureTravail = value; }
        }
        public bool Commission
        {
            get { return this.commission; }
            set { this.commission = value; }
        }
        public bool CommissionSalariedEmployees
        {
            get { return this.commissionSalariedEmployees; }
            set { this.commissionSalariedEmployees = value; }
        }

    }
}
