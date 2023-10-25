namespace ConsoleAppEFrelationsWoensdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string connectionString = "Data Source=NB21-6CDPYD3\\SQLEXPRESS;Initial Catalog=EFwoensdag;Integrated Security=True;TrustServerCertificate=True";
            GeoWikiContext ctx=new GeoWikiContext(connectionString);
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
        }
    }
}