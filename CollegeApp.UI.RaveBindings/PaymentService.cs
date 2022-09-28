namespace CollegeApp.UI.RaveBindings
{
    public class PaymentService
    {

        public ConfigurationOptions Options { get=>_options;  }   
        private readonly ConfigurationOptions _options;
        public PaymentService(ConfigurationOptions options)
        {
            _options = options;    
        }    
    }
}