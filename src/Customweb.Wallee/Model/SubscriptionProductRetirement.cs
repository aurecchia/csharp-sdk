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
    /// Product Retirement
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductRetirement :  IEquatable<SubscriptionProductRetirement>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductRetirement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionProductRetirement()
        {
        }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Product
        /// </summary>
        /// <value>Product</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public SubscriptionProduct Product { get; private set; }

        /// <summary>
        /// RespectTerminiationPeriodsEnabled
        /// </summary>
        /// <value>RespectTerminiationPeriodsEnabled</value>
        [DataMember(Name="respectTerminiationPeriodsEnabled", EmitDefaultValue=false)]
        public bool? RespectTerminiationPeriodsEnabled { get; private set; }

        /// <summary>
        /// TargetProduct
        /// </summary>
        /// <value>TargetProduct</value>
        [DataMember(Name="targetProduct", EmitDefaultValue=false)]
        public SubscriptionProduct TargetProduct { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

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
            return this.Equals(obj as SubscriptionProductRetirement);
        }

        /// <summary>
        /// Returns true if SubscriptionProductRetirement instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProductRetirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductRetirement other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
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
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.Product != null)
                {
                    hash = hash * 59 + this.Product.GetHashCode();
                }
                if (this.RespectTerminiationPeriodsEnabled != null)
                {
                    hash = hash * 59 + this.RespectTerminiationPeriodsEnabled.GetHashCode();
                }
                if (this.TargetProduct != null)
                {
                    hash = hash * 59 + this.TargetProduct.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
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
