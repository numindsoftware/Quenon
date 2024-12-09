using Azure;
using Azure.Data.Tables;

namespace Quenon;

public class SubscriptionEntity : ITableEntity
{
    /// <summary>
    /// Topic
    /// </summary>
    public string PartitionKey { get; set; }
    /// <summary>
    /// Subscription type
    /// </summary>
    public string RowKey { get; set; }
    /// <summary>
    /// Destination Queue to send messages to
    /// </summary>
    public string Target { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
}
