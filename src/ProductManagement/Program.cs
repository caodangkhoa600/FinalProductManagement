using Database;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositories;
using Services;
using UnitOfWork;

namespace ProductManagement;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>

    public static IHost host = Host.CreateDefaultBuilder()
        .ConfigureServices(services =>
        {
            services.AddSql("Server=localhost;Database=supplement_facts;Trusted_Connection=True;Encrypt=False", "ProductManagement");
            services.AddRepositories();
            services.AddServices();
            services.AddUnitOfWork();

            services.AddTransient<LoginForm>();
            services.AddTransient<BestSellingForm>();
            services.AddTransient<CreateProductForm>();
            services.AddTransient<FindOrderForm>();
            services.AddTransient<ImportProductForm>();
            services.AddTransient<InOutProductForm>();
            services.AddTransient<ViewProductListForm>();
            services.AddTransient<ViewCustomerOrderListForm>();
            services.AddTransient<ViewAgentOrderListForm>();
            services.AddTransient<UpdateStatusForm>();
            services.AddTransient<UpdateProductForm>();
            services.AddTransient<PrintDeliverySlipForm>();
            services.AddTransient<MonthlyIncomeForm>();
        }).Build();
    
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        host.Start();
        ApplicationConfiguration.Initialize();
        Application.Run(host.Services.GetRequiredService<LoginForm>());
    }
}