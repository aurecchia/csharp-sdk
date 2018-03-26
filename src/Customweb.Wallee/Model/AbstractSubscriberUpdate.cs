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
    /// Abstract Subscriber
    /// </summary>
    [DataContract]
    public partial class AbstractSubscriberUpdate :  IEquatable<AbstractSubscriberUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractSubscriberUpdate" /> class.
        /// </summary>
        /// <param name="AdditionalAllowedPaymentMethodConfigurations">Those payment methods which are allowed additionally will be available even when the product does not allow those methods.</param>
        /// <param name="BillingAddress">BillingAddress</param>
        /// <param name="Description">The subscriber description can be used to add a description to the subscriber. This is used in the back office to identify the subscriber.</param>
        /// <param name="DisallowedPaymentMethodConfigurations">Those payment methods which are disallowed will not be available to the subscriber even if the product allows those methods.</param>
        /// <param name="EmailAddress">The email address is used to communicate with the subscriber. There can be only one subscriber per space with the same email address.</param>
        /// <param name="Language">The subscriber language determines the language which is used to communicate with the subscriber in emails and documents (e.g. invoices).</param>
        /// <param name="MetaData">Meta data allow to store additional data along the object.</param>
        /// <param name="Reference">The subscriber reference identifies the subscriber in administrative interfaces (e.g. customer id).</param>
        /// <param name="ShippingAddress">ShippingAddress</param>
        public AbstractSubscriberUpdate(List<long?> AdditionalAllowedPaymentMethodConfigurations = default(List<long?>), string Description = default(string), Dictionary<string, string> MetaData = default(Dictionary<string, string>), string Reference = default(string), AddressCreate BillingAddress = default(AddressCreate), List<long?> DisallowedPaymentMethodConfigurations = default(List<long?>), AddressCreate ShippingAddress = default(AddressCreate), string Language = default(string), string EmailAddress = default(string))
        {
            this.AdditionalAllowedPaymentMethodConfigurations = AdditionalAllowedPaymentMethodConfigurations;
            this.BillingAddress = BillingAddress;
            this.Description = Description;
            this.DisallowedPaymentMethodConfigurations = DisallowedPaymentMethodConfigurations;
            this.EmailAddress = EmailAddress;
            this.Language = Language;
            this.MetaData = MetaData;
            this.Reference = Reference;
            this.ShippingAddress = ShippingAddress;
        }

        /// <summary>
        /// Those payment methods which are allowed additionally will be available even when the product does not allow those methods.
        /// </summary>
        /// <value>Those payment methods which are allowed additionally will be available even when the product does not allow those methods.</value>
        [DataMember(Name="additionalAllowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AdditionalAllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// BillingAddress
        /// </summary>
        /// <value>BillingAddress</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// The subscriber description can be used to add a description to the subscriber. This is used in the back office to identify the subscriber.
        /// </summary>
        /// <value>The subscriber description can be used to add a description to the subscriber. This is used in the back office to identify the subscriber.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Those payment methods which are disallowed will not be available to the subscriber even if the product allows those methods.
        /// </summary>
        /// <value>Those payment methods which are disallowed will not be available to the subscriber even if the product allows those methods.</value>
        [DataMember(Name="disallowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> DisallowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// The email address is used to communicate with the subscriber. There can be only one subscriber per space with the same email address.
        /// </summary>
        /// <value>The email address is used to communicate with the subscriber. There can be only one subscriber per space with the same email address.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The subscriber language determines the language which is used to communicate with the subscriber in emails and documents (e.g. invoices).
        /// </summary>
        /// <value>The subscriber language determines the language which is used to communicate with the subscriber in emails and documents (e.g. invoices).</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Meta data allow to store additional data along the object.
        /// </summary>
        /// <value>Meta data allow to store additional data along the object.</value>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// The subscriber reference identifies the subscriber in administrative interfaces (e.g. customer id).
        /// </summary>
        /// <value>The subscriber reference identifies the subscriber in administrative interfaces (e.g. customer id).</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// ShippingAddress
        /// </summary>
        /// <value>ShippingAddress</value>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public AddressCreate ShippingAddress { get; set; }

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
            return this.Equals(obj as AbstractSubscriberUpdate);
        }

        /// <summary>
        /// Returns true if AbstractSubscriberUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractSubscriberUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractSubscriberUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AdditionalAllowedPaymentMethodConfigurations == other.AdditionalAllowedPaymentMethodConfigurations ||
                    this.AdditionalAllowedPaymentMethodConfigurations != null &&
                    this.AdditionalAllowedPaymentMethodConfigurations.SequenceEqual(other.AdditionalAllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DisallowedPaymentMethodConfigurations == other.DisallowedPaymentMethodConfigurations ||
                    this.DisallowedPaymentMethodConfigurations != null &&
                    this.DisallowedPaymentMethodConfigurations.SequenceEqual(other.DisallowedPaymentMethodConfigurations)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.MetaData == other.MetaData ||
                    this.MetaData != null &&
                    this.MetaData.SequenceEqual(other.MetaData)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
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
                if (this.AdditionalAllowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.AdditionalAllowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.DisallowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.DisallowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.MetaData != null)
                {
                    hash = hash * 59 + this.MetaData.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hash = hash * 59 + this.Reference.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
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
