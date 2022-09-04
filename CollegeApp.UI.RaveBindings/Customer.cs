using Newtonsoft.Json;

namespace CollegeApp.UI.RaveBindings
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

    }

}
