namespace WebAppEmptyCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", async context =>
            {
                await context.Response.WriteAsync(HelloW(context));
            });

            app.Run();
        }

        private static string HelloW(HttpContext context)
        {
            string UserAgent = context.Request.Headers["Sec-Ch-Ua"];
            Console.WriteLine("Get Request Serviced on Server ({0})", UserAgent);  // Return to Service Console on Server 
            return String.Format(" Req from : {0}", UserAgent);
        }
    }
}