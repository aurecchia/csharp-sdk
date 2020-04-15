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
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// ShopifySubscriptionEditModelItem
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionEditModelItem :  IEquatable<ShopifySubscriptionEditModelItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionEditModelItem" /> class.
        /// </summary>
        public ShopifySubscriptionEditModelItem()
        {
        }

        /// <summary>
        /// Gets or Sets PriceIncludingTax
        /// </summary>
        [DataMember(Name="priceIncludingTax", EmitDefaultValue=true)]
        public decimal? PriceIncludingTax { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="productId", EmitDefaultValue=true)]
        public long? ProductId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets RecalculatePrice
        /// </summary>
        [DataMember(Name="recalculatePrice", EmitDefaultValue=true)]
        public bool? RecalculatePrice { get; set; }

        /// <summary>
        /// Gets or Sets TaxLines
        /// </summary>
        [DataMember(Name="taxLines", EmitDefaultValue=true)]
        public List<ShopifySubscriptionEditModelTaxLine> TaxLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriptionEditModelItem {\n");
            sb.Append("  PriceIncludingTax: ").Append(PriceIncludingTax).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RecalculatePrice: ").Append(RecalculatePrice).Append("\n");
            sb.Append("  TaxLines: ").Append(TaxLines).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShopifySubscriptionEditModelItem);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionEditModelItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionEditModelItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionEditModelItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PriceIncludingTax == input.PriceIncludingTax ||
                    (this.PriceIncludingTax != null &&
                    this.PriceIncludingTax.Equals(input.PriceIncludingTax))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.RecalculatePrice == input.RecalculatePrice ||
                    (this.RecalculatePrice != null &&
                    this.RecalculatePrice.Equals(input.RecalculatePrice))
                ) && 
                (
                    this.TaxLines == input.TaxLines ||
                    this.TaxLines != null &&
                    this.TaxLines.SequenceEqual(input.TaxLines)
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
                int hashCode = 41;
                if (this.PriceIncludingTax != null)
                    hashCode = hashCode * 59 + this.PriceIncludingTax.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.RecalculatePrice != null)
                    hashCode = hashCode * 59 + this.RecalculatePrice.GetHashCode();
                if (this.TaxLines != null)
                    hashCode = hashCode * 59 + this.TaxLines.GetHashCode();
                return hashCode;
            }
        }

    }

}