// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covi.Client.Services.Platform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LoginResponse
    {
        /// <summary>
        /// Initializes a new instance of the LoginResponse class.
        /// </summary>
        public LoginResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoginResponse class.
        /// </summary>
        public LoginResponse(string userToken = default(string), Token token = default(Token), UserState userProfile = default(UserState), Metadata metadata = default(Metadata))
        {
            UserToken = userToken;
            Token = token;
            UserProfile = userProfile;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userToken")]
        public string UserToken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public Token Token { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userProfile")]
        public UserState UserProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

    }
}