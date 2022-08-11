using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_SRP_and_OCP
{
    internal class program
    {
        static void Main(string[] args)
        {
            var civilServants = new List<Tax>() //List of Civil Servants with Ids and Corresponding Salary
            {
                new CivilServantsTax() {Salary=50000, EmployeeId="A0234"},
                new CivilServantsTax() {Salary=58000, EmployeeId="B0234"},
                new CivilServantsTax() {Salary=72000, EmployeeId="A1348"},
                new CivilServantsTax() {Salary=110000, EmployeeId="H0234"},
                new CivilServantsTax() {Salary=105000, EmployeeId="A9234"},
            };

            var smes = new List<Tax>() // List of SMEs with their corresponding Incomes and Business IDs
            {
                new SmallMediumEnterprisesTax() {Income=500000, BusinessId="K234"},
                new SmallMediumEnterprisesTax() {Income=580000, BusinessId="K134"},
                new SmallMediumEnterprisesTax() {Income=720000, BusinessId="K348"},
                new SmallMediumEnterprisesTax() {Income=1100000,BusinessId="K24"},
                new SmallMediumEnterprisesTax() {Income=1050000,BusinessId="K314"},
            };

            var fmcgs = new List<Tax>() // List of FMCG Corporations with their corresponding Incomes and Business IDs
            {
                new FMGCGCorporationsTax() {Income=500000, BusinessId="F234"},
                new FMGCGCorporationsTax() {Income=580000, BusinessId="F134"},
                new FMGCGCorporationsTax() {Income=720000, BusinessId="F348"},
                new FMGCGCorporationsTax() {Income=1100000,BusinessId="F24"},
                new FMGCGCorporationsTax() {Income=1050000,BusinessId="F314"},
            };

            ArrayList sectionsList = new ArrayList { civilServants, smes, fmcgs };
            string[] sections = { "Civil Servants", "SMEs", "FMCGs" };

            var totalRevenues = new TaxRevenue();   //Instantiation of the Tax Revenue Class to calculate the taxes

            //double revenue = totalRevenues.RevenueCalc(civilServants);


            for (int i = 0; i < sectionsList.Count; i++)
            {
               Console.WriteLine($"Total Revenue from Tax from {sections[i]} is {totalRevenues.RevenueCalc((List<Tax>)sectionsList[i])}");
            }

           

        }
    }
}
