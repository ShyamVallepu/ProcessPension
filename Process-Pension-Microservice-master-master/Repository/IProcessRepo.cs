namespace ProcessPension.Repository
{
    public interface IProcessRepo
    {

        public PensionDetail GetClientInfo(string aadhar);

        public ValueforCalCulation GetCalculationValues(string aadhar);

        public double CalcPensionAmount(int salary, int allowances, int bankType, PensionType pensionType);
        
    }
}
