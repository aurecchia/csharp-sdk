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
    /// Abstract Human User
    /// </summary>
    [DataContract]
    public partial class AbstractHumanUserUpdate :  IEquatable<AbstractHumanUserUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractHumanUserUpdate" /> class.
        /// </summary>
        /// <param name="EmailAddress">The email address of the user.</param>
        /// <param name="Firstname">The first name of the user.</param>
        /// <param name="Language">The preferred language of the user.</param>
        /// <param name="Lastname">The last name of the user.</param>
        /// <param name="MobilePhoneNumber">MobilePhoneNumber</param>
        /// <param name="State">State</param>
        /// <param name="TimeZone">The time zone which is applied for the user. If no timezone is specified the browser is used to determine an appropriate time zone.</param>
        /// <param name="TwoFactorEnabled">Defines whether two-factor authentication is enabled for this user.</param>
        public AbstractHumanUserUpdate(string Language = default(string), string MobilePhoneNumber = default(string), bool? TwoFactorEnabled = default(bool?), CreationEntityState? State = default(CreationEntityState?), string EmailAddress = default(string), string Lastname = default(string), string TimeZone = default(string), string Firstname = default(string))
        {
            this.EmailAddress = EmailAddress;
            this.Firstname = Firstname;
            this.Language = Language;
            this.Lastname = Lastname;
            this.MobilePhoneNumber = MobilePhoneNumber;
            this.State = State;
            this.TimeZone = TimeZone;
            this.TwoFactorEnabled = TwoFactorEnabled;
        }

        /// <summary>
        /// The email address of the user.
        /// </summary>
        /// <value>The email address of the user.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        /// <value>The first name of the user.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The preferred language of the user.
        /// </summary>
        /// <value>The preferred language of the user.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        /// <value>The last name of the user.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// MobilePhoneNumber
        /// </summary>
        /// <value>MobilePhoneNumber</value>
        [DataMember(Name="mobilePhoneNumber", EmitDefaultValue=false)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }

        /// <summary>
        /// The time zone which is applied for the user. If no timezone is specified the browser is used to determine an appropriate time zone.
        /// </summary>
        /// <value>The time zone which is applied for the user. If no timezone is specified the browser is used to determine an appropriate time zone.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Defines whether two-factor authentication is enabled for this user.
        /// </summary>
        /// <value>Defines whether two-factor authentication is enabled for this user.</value>
        [DataMember(Name="twoFactorEnabled", EmitDefaultValue=false)]
        public bool? TwoFactorEnabled { get; set; }

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
            return this.Equals(obj as AbstractHumanUserUpdate);
        }

        /// <summary>
        /// Returns true if AbstractHumanUserUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractHumanUserUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractHumanUserUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.Firstname == other.Firstname ||
                    this.Firstname != null &&
                    this.Firstname.Equals(other.Firstname)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Lastname == other.Lastname ||
                    this.Lastname != null &&
                    this.Lastname.Equals(other.Lastname)
                ) && 
                (
                    this.MobilePhoneNumber == other.MobilePhoneNumber ||
                    this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(other.MobilePhoneNumber)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.TwoFactorEnabled == other.TwoFactorEnabled ||
                    this.TwoFactorEnabled != null &&
                    this.TwoFactorEnabled.Equals(other.TwoFactorEnabled)
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
                if (this.EmailAddress != null)
                {
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                }
                if (this.Firstname != null)
                {
                    hash = hash * 59 + this.Firstname.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.Lastname != null)
                {
                    hash = hash * 59 + this.Lastname.GetHashCode();
                }
                if (this.MobilePhoneNumber != null)
                {
                    hash = hash * 59 + this.MobilePhoneNumber.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                }
                if (this.TwoFactorEnabled != null)
                {
                    hash = hash * 59 + this.TwoFactorEnabled.GetHashCode();
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
