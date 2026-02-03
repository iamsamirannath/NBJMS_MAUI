namespace NBJMS_MAUI.Models;

public class MemberTransaction
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public bool IsCredit { get; set; }
}
