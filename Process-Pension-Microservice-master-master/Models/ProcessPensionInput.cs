namespace ProcessPension
{
    public class ProcessPensionInput
    {
        public double PensionAmount { get; set; }
        public int BankCharge { get; set; }
    }
    public enum PensionType
    {
        Self=1,
        Family=2
    }
 
}
