using System.Text.Json.Serialization;

namespace CoreBanking.Infrstructure.Entity
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Number { get; set; } = default;
        public decimal Balance { get; set; }
        [JsonIgnore]
        public Guid CustomerId { get; set; }
        [JsonIgnore]
        public ICollection<Transaction> Transactions { get; set; } = [];
    }
}
