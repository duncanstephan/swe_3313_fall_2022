using System.Diagnostics;
using System.Globalization;
using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.CsvExtract;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CsvHelper;

namespace CoffeePointOfSale.Forms;

public partial class FormManagement : FormNoCloseBase
{
    private readonly ICustomerService _customerService;
    private IAppSettings _appSettings;
    private readonly ICsvExtract _csvExtract;

    public FormManagement(IAppSettings appSettings, ICustomerService customerService, ICsvExtract csvExtract) : base(appSettings)
    {
        _customerService = customerService;
        _appSettings = appSettings;
        _csvExtract = csvExtract;
        InitializeComponent();
    }

    private void OnClickBtnClose(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

    private void OnLoadFormManagement(object sender, EventArgs e)
    {
        SetTitle(_csvExtract.Extract());
    }

    private void BtnGenCsv_Click(object sender, EventArgs e)
    {
        var csvExtractLines = new List<CsvExtract>(); //contains CSV extract data

        //loop through each customer and each order - output will have N customers * M orders lines
        //for example, 5 customers each with 5 orders will produce 25 lines of output
        foreach (var customer in _customerService.Customers.List)
        {
            foreach (var order in customer.Orders)
            {
                var csvExtractLine = new CsvExtract
                {
                    CustomerId = customer.CustomerId,
                    CustomerName = customer.Name,
                    OrderDate = order.TransactionDate,
                    OrderId = order.OrderId,
                    OrderTotalPrice = order.TotalPrice,
                    OrderDetails = order.ToString()
                };

                csvExtractLines.Add(csvExtractLine);
            }
        }
        //set path and filename
        var outputDirectory = Path.GetTempPath(); //find OS temp directory
        var csvFilename = $"output_{DateTime.Now.Ticks}.csv";
        var csvPathAndFilename = Path.Join(outputDirectory, csvFilename);

        //write csvExtractLines via CSVHelper
        using (var writer = new StreamWriter(csvPathAndFilename))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(csvExtractLines);
        }

        //attempt to open in Excel (or whatever is registered to open .csv files on the machine)
        try
        {
            var processStartInfo = new ProcessStartInfo(csvPathAndFilename)
            {
                WorkingDirectory = outputDirectory,
                UseShellExecute = true
            };
            Process.Start(processStartInfo);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open [{csvPathAndFilename}]: {ex.Message}");
        }
    }
}
