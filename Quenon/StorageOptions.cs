namespace Quenon;

public class StorageOptions
{
    public required string ConnectionString { get; set; }
    public required string TableName { get; set; } = nameof(Quenon);
}
