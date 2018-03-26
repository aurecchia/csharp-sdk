using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// This error is thrown when something unexpected happens on our side.
    /// </summary>
    [DataContract]
    public partial class ServerError :  IEquatable<ServerError>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ServerError()
        {
        }

        /// <summary>
        /// Date when an error has occurred.
        /// </summary>
        /// <value>Date when an error has occurred.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; private set; }

        /// <summary>
        /// Unique identifier of an error.
        /// </summary>
        /// <value>Unique identifier of an error.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// This message describes an error.
        /// </summary>
        /// <value>This message describes an error.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as ServerError);
        }

        /// <summary>
        /// Returns true if ServerError instances are equal
        /// </summary>
        /// <param name="other">Instance of ServerError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerError other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                if (this.Date != null)
                {
                    hash = hash * 59 + this.Date.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Message != null)
                {
                    hash = hash * 59 + this.Message.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
