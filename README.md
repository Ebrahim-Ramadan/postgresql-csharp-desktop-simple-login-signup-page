##### pg configuration starts by `Install-Package Npgsql` command to be able to `using Npgsql;` then 
```
string connectionString = "Host=yourserver;Port=yourport;Username=yourusername;Password=yourpassword;Database=yourdatabase;";
NpgsqlConnection conn = new NpgsqlConnection(connectionString);

try
{
    conn.Open();
    // Connection is established, proceed with your operations.
}
catch (NpgsqlException ex)
{
    // Handle connection errors
    Console.WriteLine(ex.Message);
}
finally
{
    conn.Close();
}
```
<br/>

note: if any error found while installing the `npgsql` package or the `NuGet` had any issue, you can do the following:
- in the solution explorer, right-click then choose 'manage NuGet packages'
* search for `Npgsql` and install it
