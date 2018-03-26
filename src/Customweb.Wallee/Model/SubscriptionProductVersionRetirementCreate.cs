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
    /// Product Version Retirement
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductVersionRetirementCreate :  IEquatable<SubscriptionProductVersionRetirementCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionRetirementCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductVersionRetirementCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionRetirementCreate" /> class.
        /// </summary>
        /// <param name="ProductVersion">ProductVersion (required)</param>
        /// <param name="RespectTerminiationPeriodsEnabled">RespectTerminiationPeriodsEnabled</param>
        /// <param name="TargetProduct">TargetProduct</param>
        public SubscriptionProductVersionRetirementCreate(long? TargetProduct = default(long?), long? ProductVersion = default(long?), bool? RespectTerminiationPeriodsEnabled = default(bool?))
        {
            // to ensure "ProductVersion" is required (not null)
            if (ProductVersion == null)
            {
                throw new ArgumentNullException("ProductVersion is a required property for SubscriptionProductVersionRetirementCreate and cannot be null");
            }
            else
            {
                this.ProductVersion = ProductVersion;
            }
            this.RespectTerminiationPeriodsEnabled = RespectTerminiationPeriodsEnabled;
            this.TargetProduct = TargetProduct;
        }

        /// <summary>
        /// ProductVersion
        /// </summary>
        /// <value>ProductVersion</value>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public long? ProductVersion { get; set; }

        /// <summary>
        /// RespectTerminiationPeriodsEnabled
        /// </summary>
        /// <value>RespectTerminiationPeriodsEnabled</value>
        [DataMember(Name="respectTerminiationPeriodsEnabled", EmitDefaultValue=false)]
        public bool? RespectTerminiationPeriodsEnabled { get; set; }

        /// <summary>
        /// TargetProduct
        /// </summary>
        /// <value>TargetProduct</value>
        [DataMember(Name="targetProduct", EmitDefaultValue=false)]
        public long? TargetProduct { get; set; }

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
            return this.Equals(obj as SubscriptionProductVersionRetirementCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionProductVersionRetirementCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProductVersionRetirementCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductVersionRetirementCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ProductVersion == other.ProductVersion ||
                    this.ProductVersion != null &&
                    this.ProductVersion.Equals(other.ProductVersion)
                ) && 
                (
                    this.RespectTerminiationPeriodsEnabled == other.RespectTerminiationPeriodsEnabled ||
                    this.RespectTerminiationPeriodsEnabled != null &&
                    this.RespectTerminiationPeriodsEnabled.Equals(other.RespectTerminiationPeriodsEnabled)
                ) && 
                (
                    this.TargetProduct == other.TargetProduct ||
                    this.TargetProduct != null &&
                    this.TargetProduct.Equals(other.TargetProduct)
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
                if (this.ProductVersion != null)
                {
                    hash = hash * 59 + this.ProductVersion.GetHashCode();
                }
                if (this.RespectTerminiationPeriodsEnabled != null)
                {
                    hash = hash * 59 + this.RespectTerminiationPeriodsEnabled.GetHashCode();
                }
                if (this.TargetProduct != null)
                {
                    hash = hash * 59 + this.TargetProduct.GetHashCode();
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
