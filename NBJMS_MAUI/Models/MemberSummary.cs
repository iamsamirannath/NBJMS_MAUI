namespace NBJMS_MAUI.Models;

public class MemberSummary
{
    public string MemberName { get; set; } = string.Empty;
    public string MemberId { get; set; } = string.Empty;
    public decimal SavingsBalance { get; set; }
    public decimal LoanBalance { get; set; }
    public DateTime NextContributionDate { get; set; }
}
