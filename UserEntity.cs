using Azure;
using Azure.Data.Tables;

public class UserEntity : ITableEntity
{
    public string PartitionKey { get; set; } // ListName
    public string RowKey { get; set; } // UserId
    public string Name { get; set; }
    public string Location { get; set; }
    public string Gender { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
}
