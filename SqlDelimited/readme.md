# About

Read company name from database table as a semi-colon string with a like condition.

## Raw SQL

```sql
DECLARE @LikeCondition nvarchar(10) = 'c%'

SELECT STRING_AGG(ISNULL(CompanyName, ''), ';') AS csv 
FROM CustomerDatabase.dbo.Customer 
WHERE dbo.Customer.CompanyName LIKE @LikeCondition;
```

# Base code

```csharp
public class Operations
{
    public delegate void OnException(Exception exception);
    /// <summary>
    /// Callback for subscribers to know about a problem
    /// </summary>
    public static event OnException OnExceptionEvent;
    private static string _connectionString = "Data Source=.\\sqlexpress;Initial " +
                                              "Catalog=CustomerDatabase;Integrated Security=True";

    public static string CompanyNamesDelimited()
    {
        string results = "";

        using (var cn = new SqlConnection {ConnectionString = _connectionString})
        {
            using (var cmd = new SqlCommand {Connection = cn})
            {
                cmd.CommandText =
                    "SELECT STRING_AGG(ISNULL(CompanyName, ''), ';') AS csv " +
                    "FROM CustomerDatabase.dbo.Customer " +
                    "WHERE dbo.Customer.CompanyName LIKE @LikeCondition;";

                cmd.Parameters.AddWithValue("@LikeCondition", "c%");

                try
                {
                    cn.Open();

                    results = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    OnExceptionEvent?.Invoke(ex);
                }

            }
        }

        return results;
    }
}
```