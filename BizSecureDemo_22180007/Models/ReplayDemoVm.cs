namespace BizSecureDemo_22180007.ViewModels
{
    public class ReplayDemoVm
    {
        public decimal Balance { get; set; }
        public string? Message { get; set; }
        public int UserId { get; set; }

        public string Nonce { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 100;
        public string Token { get; set; } = "SECRET123";
    }
}
