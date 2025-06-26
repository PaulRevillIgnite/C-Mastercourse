namespace MethodOverriding
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            decimal basePay =  base.GetPaycheckAmount(hoursWorked);

            return basePay + CommissionAmount;
        }
    }
}
