using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_SRP_and_OCP
{

    /// <summary>
    /// Abstract class with only one method for generating tax
    /// </summary>
    public abstract class Tax
    {
        public abstract double GenerateTax();
    }


    /// <summary>
    /// Inherits from Tax class and generates taxes for civilians  
    /// </summary>
    public class CivilServantsTax: Tax
    {
        public double Salary { get; set; }

        public string Id { get; set; }

        public int Level { get;  }



        /// <summary>
        /// Generates taxes for civil servants
        /// </summary>
        public override double GenerateTax()
        {
            
                return 0.015 * Salary;
            
        }
    }


    /// <summary>
    /// Generates Tax for Small and Medium Scale Enterprises
    /// </summary>
    public class SmallMediumEnterprisesTax: Tax
    {
        public double Income { get; set; }

        public double BusinessId { get; set; }


        /// <summary>
        ///     /// Generates Tax for Small and Medium Scale Enterprises
        /// </summary>
        public override double GenerateTax()
        {
            return 0.02 * Income;
        }
    }


    /// <summary>
    /// Generates taxes for Large Corporations in the Fast Moving Consumer goods sector of the economy
    /// </summary>
    public class FMGCGCorporationsTax : Tax
    {
        public double Income { get; set; }

        public double BusinessId { get; set; }


        /// <summary>
        /// Generates taxes for Large Corporations in the Fast Moving Consumer goods sector of the economy
        /// </summary>
        public override double GenerateTax()
        {
            return 0.035 * Income;
        }
    }
}
