using Microsoft.IdentityModel.Protocols;

namespace Employee_Management.Models
{


    public class PayPalModel
    {
        public string cmd { get; set; }
        public string business { get; set; }
        public string no_shipping { get; set; }
        public string @return { get; set; }
        public string cancel_return { get; set; }
        public string notify_url { get; set; }
        public string currency_code { get; set; }
        public string item_name { get; set; }
        public string amount { get; set; }
        public string actionURL { get; set; }

        public PayPalModel(bool useSandbox)
        {
            this.cmd = "_xclick";
            //this.business =  ConfigurationManager.AppSettings["business"];
            //this.cancel_return = ConfigurationManager.AppSettings["cancel_return"];
            //this.@return = ConfigurationManager.AppSettings["return"];
            //if (useSandbox)
            //{
            //    this.actionURL = ConfigurationManager.AppSettings["test_url"];
            //}
            //else
            //{
            //    this.actionURL = ConfigurationManager.AppSettings["Prod_url"];
            //}
            //// We can add parameters here, for example OrderId, CustomerId, etc....
            //this.notify_url = ConfigurationManager.AppSettings["notify_url"];
            //// We can add parameters here, for example OrderId, CustomerId, etc....
            //this.currency_code = ConfigurationManager.AppSettings["currency_code"];

            this.business = "sb-kpmax15511933@personal.example.com";
            this.cancel_return = "https://localhost:44324/PayPal/CancelFromPaypal";
            this.@return = "https://localhost:44324/Pay/CheckOut";
            if (useSandbox)
            {
                this.actionURL = "https://www.sandbox.paypal.com/cgi-bin/webscr";
            }
            else
            {
                this.actionURL = "https://www.sandbox.paypal.com/cgi-bin/webscr";
            }
            // We can add parameters here, for example OrderId, CustomerId, etc....
            this.notify_url = "https://localhost:44324/PayPal/NotifyFromPaypal";
            // We can add parameters here, for example OrderId, CustomerId, etc....
            this.currency_code = "CAD";

        }
    }
}
