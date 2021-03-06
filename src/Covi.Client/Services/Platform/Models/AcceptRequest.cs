// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covi.Client.Services.Platform.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AcceptRequest
    {
        /// <summary>
        /// Initializes a new instance of the AcceptRequest class.
        /// </summary>
        public AcceptRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AcceptRequest class.
        /// </summary>
        public AcceptRequest(string medicalCode, IList<Meeting> meetings = default(IList<Meeting>))
        {
            Meetings = meetings;
            MedicalCode = medicalCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "meetings")]
        public IList<Meeting> Meetings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "medicalCode")]
        public string MedicalCode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MedicalCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MedicalCode");
            }
            if (Meetings != null)
            {
                foreach (var element in Meetings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
