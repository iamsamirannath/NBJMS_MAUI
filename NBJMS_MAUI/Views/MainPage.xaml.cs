using NBJMS_MAUI.Models;

namespace NBJMS_MAUI.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MemberOverviewViewModel();
    }
}

public class MemberOverviewViewModel
{
    public IReadOnlyList<MemberTransaction> Transactions { get; } = new List<MemberTransaction>
    {
        new()
        {
            Title = "Monthly Contribution",
            Description = "Savings deposit",
            Amount = 500,
            Date = DateTime.Today.AddDays(-2),
            IsCredit = true
        },
        new()
        {
            Title = "Loan Repayment",
            Description = "Flexible loan plan",
            Amount = -150,
            Date = DateTime.Today.AddDays(-5),
            IsCredit = false
        },
        new()
        {
            Title = "Emergency Withdrawal",
            Description = "Approved request",
            Amount = -200,
            Date = DateTime.Today.AddDays(-12),
            IsCredit = false
        }
    };
}
