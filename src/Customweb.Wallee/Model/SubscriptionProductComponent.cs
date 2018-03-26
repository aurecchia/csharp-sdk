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
    /// Product Component
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductComponent :  IEquatable<SubscriptionProductComponent>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionProductComponent()
        {
        }

        /// <summary>
        /// The change weight determines whether if a component change is considered as upgrade or downgrade. If product component with a weight 10 is changed to a product component with a weight 20, the change is considered as upgrade. On the other hand a change from 20 to 10 is considered as a downgrade.
        /// </summary>
        /// <value>The change weight determines whether if a component change is considered as upgrade or downgrade. If product component with a weight 10 is changed to a product component with a weight 20, the change is considered as upgrade. On the other hand a change from 20 to 10 is considered as a downgrade.</value>
        [DataMember(Name="componentChangeWeight", EmitDefaultValue=false)]
        public int? ComponentChangeWeight { get; private set; }

        /// <summary>
        /// ComponentGroup
        /// </summary>
        /// <value>ComponentGroup</value>
        [DataMember(Name="componentGroup", EmitDefaultValue=false)]
        public SubscriptionProductComponentGroup ComponentGroup { get; private set; }

        /// <summary>
        /// When a component is marked as a &#39;default&#39; component it is used when no other component is selected by the user.
        /// </summary>
        /// <value>When a component is marked as a &#39;default&#39; component it is used when no other component is selected by the user.</value>
        [DataMember(Name="defaultComponent", EmitDefaultValue=false)]
        public bool? DefaultComponent { get; private set; }

        /// <summary>
        /// The component description may contain a longer description which gives the subscriber a better understanding of what the component contains.
        /// </summary>
        /// <value>The component description may contain a longer description which gives the subscriber a better understanding of what the component contains.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public DatabaseTranslatedString Description { get; private set; }

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
        /// The component name is shown to the subscriber. It should describe in few words what the component does contain.
        /// </summary>
        /// <value>The component name is shown to the subscriber. It should describe in few words what the component does contain.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public DatabaseTranslatedString Name { get; private set; }

        /// <summary>
        /// The component reference is used to identify the component by external systems and it marks components to represent the same component within different product versions.
        /// </summary>
        /// <value>The component reference is used to identify the component by external systems and it marks components to represent the same component within different product versions.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public SubscriptionProductComponentReference Reference { get; private set; }

        /// <summary>
        /// The sort order controls in which order the component is listed. The sort order is used to order the components in ascending order.
        /// </summary>
        /// <value>The sort order controls in which order the component is listed. The sort order is used to order the components in ascending order.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; private set; }

        /// <summary>
        /// The tax class of the component determines the taxes which are applicable on all fees linked with the component.
        /// </summary>
        /// <value>The tax class of the component determines the taxes which are applicable on all fees linked with the component.</value>
        [DataMember(Name="taxClass", EmitDefaultValue=false)]
        public TaxClass TaxClass { get; private set; }

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
            return this.Equals(obj as SubscriptionProductComponent);
        }

        /// <summary>
        /// Returns true if SubscriptionProductComponent instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProductComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductComponent other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ComponentChangeWeight == other.ComponentChangeWeight ||
                    this.ComponentChangeWeight != null &&
                    this.ComponentChangeWeight.Equals(other.ComponentChangeWeight)
                ) && 
                (
                    this.ComponentGroup == other.ComponentGroup ||
                    this.ComponentGroup != null &&
                    this.ComponentGroup.Equals(other.ComponentGroup)
                ) && 
                (
                    this.DefaultComponent == other.DefaultComponent ||
                    this.DefaultComponent != null &&
                    this.DefaultComponent.Equals(other.DefaultComponent)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) && 
                (
                    this.TaxClass == other.TaxClass ||
                    this.TaxClass != null &&
                    this.TaxClass.Equals(other.TaxClass)
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
                if (this.ComponentChangeWeight != null)
                {
                    hash = hash * 59 + this.ComponentChangeWeight.GetHashCode();
                }
                if (this.ComponentGroup != null)
                {
                    hash = hash * 59 + this.ComponentGroup.GetHashCode();
                }
                if (this.DefaultComponent != null)
                {
                    hash = hash * 59 + this.DefaultComponent.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hash = hash * 59 + this.Reference.GetHashCode();
                }
                if (this.SortOrder != null)
                {
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                }
                if (this.TaxClass != null)
                {
                    hash = hash * 59 + this.TaxClass.GetHashCode();
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
