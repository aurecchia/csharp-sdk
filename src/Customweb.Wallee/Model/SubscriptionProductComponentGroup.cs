/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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
    /// Product Component Group
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductComponentGroup :  IEquatable<SubscriptionProductComponentGroup>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionProductComponentGroup()
        {
        }

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
        /// The component group name will be shown when the components are selected. This can be visible to the subscriber.
        /// </summary>
        /// <value>The component group name will be shown when the components are selected. This can be visible to the subscriber.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public DatabaseTranslatedString Name { get; private set; }

        /// <summary>
        /// The component group can be optional. This means no component has to be selected by the subscriber.
        /// </summary>
        /// <value>The component group can be optional. This means no component has to be selected by the subscriber.</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool? Optional { get; private set; }

        /// <summary>
        /// ProductVersion
        /// </summary>
        /// <value>ProductVersion</value>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public SubscriptionProductVersion ProductVersion { get; private set; }

        /// <summary>
        /// The sort order controls in which order the component group is listed. The sort order is used to order the component groups in ascending order.
        /// </summary>
        /// <value>The sort order controls in which order the component group is listed. The sort order is used to order the component groups in ascending order.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; private set; }

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
            return this.Equals(obj as SubscriptionProductComponentGroup);
        }

        /// <summary>
        /// Returns true if SubscriptionProductComponentGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProductComponentGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductComponentGroup other)
        {
            if (other == null)
            {
                return false;
            }

            return 
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
                    this.Optional == other.Optional ||
                    this.Optional != null &&
                    this.Optional.Equals(other.Optional)
                ) && 
                (
                    this.ProductVersion == other.ProductVersion ||
                    this.ProductVersion != null &&
                    this.ProductVersion.Equals(other.ProductVersion)
                ) && 
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
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
                if (this.Optional != null)
                {
                    hash = hash * 59 + this.Optional.GetHashCode();
                }
                if (this.ProductVersion != null)
                {
                    hash = hash * 59 + this.ProductVersion.GetHashCode();
                }
                if (this.SortOrder != null)
                {
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

    }

}