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
    /// This model holds the card data in plain.
    /// </summary>
    [DataContract]
    public partial class UnencryptedCardDataCreate :  IEquatable<UnencryptedCardDataCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnencryptedCardDataCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnencryptedCardDataCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnencryptedCardDataCreate" /> class.
        /// </summary>
        /// <param name="CardHolderName">The card holder name is the name printed onto the card. It identifies the person who owns the card.</param>
        /// <param name="CardVerificationCode">The card verification code (CVC) is a 3 to 4 digit code typically printed on the back of the card. It helps to ensure that the card holder is authorizing the transaction. For card not-present transactions this field is optional.</param>
        /// <param name="ExpiryDate">The card expiry date indicates when the card expires. The format is the format yyyy-mm where yyyy is the year (e.g. 2019) and the mm is the month (e.g. 09). (required)</param>
        /// <param name="PrimaryAccountNumber">The primary account number (PAN) identifies the card. The number is numeric and typically printed on the front of the card. (required)</param>
        public UnencryptedCardDataCreate(string CardVerificationCode = default(string), string ExpiryDate = default(string), string CardHolderName = default(string), string PrimaryAccountNumber = default(string))
        {
            // to ensure "ExpiryDate" is required (not null)
            if (ExpiryDate == null)
            {
                throw new ArgumentNullException("ExpiryDate is a required property for UnencryptedCardDataCreate and cannot be null");
            }
            else
            {
                this.ExpiryDate = ExpiryDate;
            }
            // to ensure "PrimaryAccountNumber" is required (not null)
            if (PrimaryAccountNumber == null)
            {
                throw new ArgumentNullException("PrimaryAccountNumber is a required property for UnencryptedCardDataCreate and cannot be null");
            }
            else
            {
                this.PrimaryAccountNumber = PrimaryAccountNumber;
            }
            this.CardHolderName = CardHolderName;
            this.CardVerificationCode = CardVerificationCode;
        }

        /// <summary>
        /// The card holder name is the name printed onto the card. It identifies the person who owns the card.
        /// </summary>
        /// <value>The card holder name is the name printed onto the card. It identifies the person who owns the card.</value>
        [DataMember(Name="cardHolderName", EmitDefaultValue=false)]
        public string CardHolderName { get; set; }

        /// <summary>
        /// The card verification code (CVC) is a 3 to 4 digit code typically printed on the back of the card. It helps to ensure that the card holder is authorizing the transaction. For card not-present transactions this field is optional.
        /// </summary>
        /// <value>The card verification code (CVC) is a 3 to 4 digit code typically printed on the back of the card. It helps to ensure that the card holder is authorizing the transaction. For card not-present transactions this field is optional.</value>
        [DataMember(Name="cardVerificationCode", EmitDefaultValue=false)]
        public string CardVerificationCode { get; set; }

        /// <summary>
        /// The card expiry date indicates when the card expires. The format is the format yyyy-mm where yyyy is the year (e.g. 2019) and the mm is the month (e.g. 09).
        /// </summary>
        /// <value>The card expiry date indicates when the card expires. The format is the format yyyy-mm where yyyy is the year (e.g. 2019) and the mm is the month (e.g. 09).</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// The primary account number (PAN) identifies the card. The number is numeric and typically printed on the front of the card.
        /// </summary>
        /// <value>The primary account number (PAN) identifies the card. The number is numeric and typically printed on the front of the card.</value>
        [DataMember(Name="primaryAccountNumber", EmitDefaultValue=false)]
        public string PrimaryAccountNumber { get; set; }

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
            return this.Equals(obj as UnencryptedCardDataCreate);
        }

        /// <summary>
        /// Returns true if UnencryptedCardDataCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of UnencryptedCardDataCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnencryptedCardDataCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CardHolderName == other.CardHolderName ||
                    this.CardHolderName != null &&
                    this.CardHolderName.Equals(other.CardHolderName)
                ) && 
                (
                    this.CardVerificationCode == other.CardVerificationCode ||
                    this.CardVerificationCode != null &&
                    this.CardVerificationCode.Equals(other.CardVerificationCode)
                ) && 
                (
                    this.ExpiryDate == other.ExpiryDate ||
                    this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(other.ExpiryDate)
                ) && 
                (
                    this.PrimaryAccountNumber == other.PrimaryAccountNumber ||
                    this.PrimaryAccountNumber != null &&
                    this.PrimaryAccountNumber.Equals(other.PrimaryAccountNumber)
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
                if (this.CardHolderName != null)
                {
                    hash = hash * 59 + this.CardHolderName.GetHashCode();
                }
                if (this.CardVerificationCode != null)
                {
                    hash = hash * 59 + this.CardVerificationCode.GetHashCode();
                }
                if (this.ExpiryDate != null)
                {
                    hash = hash * 59 + this.ExpiryDate.GetHashCode();
                }
                if (this.PrimaryAccountNumber != null)
                {
                    hash = hash * 59 + this.PrimaryAccountNumber.GetHashCode();
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
