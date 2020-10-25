# About

Demonstrates how to perform an INSERT with conditional setting a date value for a column or a date value dependent on if a date gets passed to a method.

**Front end project** SqlServerInsertNullDateFrontEnd

In this case SQL-Server is used, will work with any database provided by changing data provider class for both connection and command.

**INSERT statement**

```sql
INSERT INTO dbo.employee (FirstName, LastName, HiredDate) VALUES (@FirstName, @LastName, @HiredDate);
SELECT CAST(scope_identity() AS int);
```

Since the date is nullable the following is used to decide and set the value for HireDate a date column,

```csharp
if (employee.HiredDate.HasValue)
{
    cmd.Parameters.Add("@HiredDate", SqlDbType.DateTime).Value = employee.HiredDate.Value;
}
else
{
    cmd.Parameters.Add("@HiredDate", SqlDbType.DateTime).Value = DBNull.Value;
}

```
**Employee class** which is passed into a method for adding a new row.

```csharp
public class Employee
{
    public int Id { get; set; } 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public DateTime? HiredDate { get; set; }
    public override string ToString() => Id.ToString();
}
```