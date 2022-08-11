namespace Assignment6_SRP_and_OCP
{

    /// <summary>
    /// Calculates Total Revenue from all Tax Sources Monthly
    /// 
    /// </summary>
    public class TaxRevenue
    {
        public double RevenueCalc(List<Tax> taxes)
        {
            try
            {
                double totalRevenue = 0;
                foreach (var i in taxes)
                {
                    totalRevenue += i.GenerateTax();
                }
                return totalRevenue;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Cannot Calculate total revenue at this time");
                return 0;
            }
        }
    }
}