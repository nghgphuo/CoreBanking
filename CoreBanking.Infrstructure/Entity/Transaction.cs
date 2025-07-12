using System.Text.Json.Serialization;

namespace CoreBanking.Infrstructure.Entity
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateUtc { get; set; }
        public TransactionTypes Type { get; set; }
        [JsonIgnore]
        public Account Account { get; set; }
    }
    public enum TransactionTypes
    {
        Deposit,
        Withdraw
    }
}