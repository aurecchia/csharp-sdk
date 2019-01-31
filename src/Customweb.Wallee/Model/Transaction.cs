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
    /// Transaction
    /// </summary>
    [DataContract]
    public partial class Transaction :  IEquatable<Transaction>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Transaction()
        {
        }

        /// <summary>
        /// AcceptHeader
        /// </summary>
        /// <value>AcceptHeader</value>
        [DataMember(Name="acceptHeader", EmitDefaultValue=false)]
        public string AcceptHeader { get; private set; }

        /// <summary>
        /// The accept language contains the header which indicates the language preferences of the buyer.
        /// </summary>
        /// <value>The accept language contains the header which indicates the language preferences of the buyer.</value>
        [DataMember(Name="acceptLanguageHeader", EmitDefaultValue=false)]
        public string AcceptLanguageHeader { get; private set; }

        /// <summary>
        /// AllowedPaymentMethodBrands
        /// </summary>
        /// <value>AllowedPaymentMethodBrands</value>
        [DataMember(Name="allowedPaymentMethodBrands", EmitDefaultValue=false)]
        public List<PaymentMethodBrand> AllowedPaymentMethodBrands { get; private set; }

        /// <summary>
        /// AllowedPaymentMethodConfigurations
        /// </summary>
        /// <value>AllowedPaymentMethodConfigurations</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// AuthorizationAmount
        /// </summary>
        /// <value>AuthorizationAmount</value>
        [DataMember(Name="authorizationAmount", EmitDefaultValue=false)]
        public decimal? AuthorizationAmount { get; private set; }

        /// <summary>
        /// The environment in which this transaction was successfully authorized.
        /// </summary>
        /// <value>The environment in which this transaction was successfully authorized.</value>
        [DataMember(Name="authorizationEnvironment", EmitDefaultValue=false)]
        public ChargeAttemptEnvironment? AuthorizationEnvironment { get; private set; }

        /// <summary>
        /// This is the time on which the transaction will be timed out when it is not at least authorized. The timeout time may change over time.
        /// </summary>
        /// <value>This is the time on which the transaction will be timed out when it is not at least authorized. The timeout time may change over time.</value>
        [DataMember(Name="authorizationTimeoutOn", EmitDefaultValue=false)]
        public DateTime? AuthorizationTimeoutOn { get; private set; }

        /// <summary>
        /// AuthorizedOn
        /// </summary>
        /// <value>AuthorizedOn</value>
        [DataMember(Name="authorizedOn", EmitDefaultValue=false)]
        public DateTime? AuthorizedOn { get; private set; }

        /// <summary>
        /// When auto confirmation is enabled the transaction can be confirmed by the user and does not require an explicit confirmation through the web service API.
        /// </summary>
        /// <value>When auto confirmation is enabled the transaction can be confirmed by the user and does not require an explicit confirmation through the web service API.</value>
        [DataMember(Name="autoConfirmationEnabled", EmitDefaultValue=false)]
        public bool? AutoConfirmationEnabled { get; private set; }

        /// <summary>
        /// BillingAddress
        /// </summary>
        /// <value>BillingAddress</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.
        /// </summary>
        /// <value>When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.</value>
        [DataMember(Name="chargeRetryEnabled", EmitDefaultValue=false)]
        public bool? ChargeRetryEnabled { get; private set; }

        /// <summary>
        /// The completed amount is the amount which of the succesful completion.
        /// </summary>
        /// <value>The completed amount is the amount which of the succesful completion.</value>
        [DataMember(Name="completedAmount", EmitDefaultValue=false)]
        public decimal? CompletedAmount { get; private set; }

        /// <summary>
        /// CompletedOn
        /// </summary>
        /// <value>CompletedOn</value>
        [DataMember(Name="completedOn", EmitDefaultValue=false)]
        public DateTime? CompletedOn { get; private set; }

        /// <summary>
        /// CompletionTimeoutOn
        /// </summary>
        /// <value>CompletionTimeoutOn</value>
        [DataMember(Name="completionTimeoutOn", EmitDefaultValue=false)]
        public DateTime? CompletionTimeoutOn { get; private set; }

        /// <summary>
        /// ConfirmedBy
        /// </summary>
        /// <value>ConfirmedBy</value>
        [DataMember(Name="confirmedBy", EmitDefaultValue=false)]
        public long? ConfirmedBy { get; private set; }

        /// <summary>
        /// ConfirmedOn
        /// </summary>
        /// <value>ConfirmedOn</value>
        [DataMember(Name="confirmedOn", EmitDefaultValue=false)]
        public DateTime? ConfirmedOn { get; private set; }

        /// <summary>
        /// CreatedBy
        /// </summary>
        /// <value>CreatedBy</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// The customer email address is the email address of the customer. If no email address is provided on the shipping or billing address this address is used.
        /// </summary>
        /// <value>The customer email address is the email address of the customer. If no email address is provided on the shipping or billing address this address is used.</value>
        [DataMember(Name="customerEmailAddress", EmitDefaultValue=false)]
        public string CustomerEmailAddress { get; private set; }

        /// <summary>
        /// CustomerId
        /// </summary>
        /// <value>CustomerId</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; private set; }

        /// <summary>
        /// The customer's presence indicates what kind of authentication methods can be used during the authorization of the transaction. If no value is provided, 'Virtually Present' is used by default.
        /// </summary>
        /// <value>The customer's presence indicates what kind of authentication methods can be used during the authorization of the transaction. If no value is provided, 'Virtually Present' is used by default.</value>
        [DataMember(Name="customersPresence", EmitDefaultValue=false)]
        public CustomersPresence? CustomersPresence { get; private set; }

        /// <summary>
        /// This date indicates when the decision has been made if a transaction should be delivered or not.
        /// </summary>
        /// <value>This date indicates when the decision has been made if a transaction should be delivered or not.</value>
        [DataMember(Name="deliveryDecisionMadeOn", EmitDefaultValue=false)]
        public DateTime? DeliveryDecisionMadeOn { get; private set; }

        /// <summary>
        /// The device session identifier links the transaction with the session identifier provided in the URL of the device data JavaScript. This allows to link the transaction with the collected device data of the buyer.
        /// </summary>
        /// <value>The device session identifier links the transaction with the session identifier provided in the URL of the device data JavaScript. This allows to link the transaction with the collected device data of the buyer.</value>
        [DataMember(Name="deviceSessionIdentifier", EmitDefaultValue=false)]
        public string DeviceSessionIdentifier { get; private set; }

        /// <summary>
        /// The transaction&#39;s end of life indicates the date from which on no operation can be carried out anymore.
        /// </summary>
        /// <value>The transaction&#39;s end of life indicates the date from which on no operation can be carried out anymore.</value>
        [DataMember(Name="endOfLife", EmitDefaultValue=false)]
        public DateTime? EndOfLife { get; private set; }

        /// <summary>
        /// Environment
        /// </summary>
        /// <value>Environment</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Environment? Environment { get; private set; }

        /// <summary>
        /// The environment selection strategy determines how the environment (test or production) for processing the transaction is selected.
        /// </summary>
        /// <value>The environment selection strategy determines how the environment (test or production) for processing the transaction is selected.</value>
        [DataMember(Name="environmentSelectionStrategy", EmitDefaultValue=false)]
        public TransactionEnvironmentSelectionStrategy? EnvironmentSelectionStrategy { get; private set; }

        /// <summary>
        /// FailedOn
        /// </summary>
        /// <value>FailedOn</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; private set; }

        /// <summary>
        /// The failure reason describes why the transaction failed. This is only provided when the transaction is marked as failed.
        /// </summary>
        /// <value>The failure reason describes why the transaction failed. This is only provided when the transaction is marked as failed.</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// Group
        /// </summary>
        /// <value>Group</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public TransactionGroup Group { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The Internet Protocol (IP) address identifies the device of the buyer.
        /// </summary>
        /// <value>The Internet Protocol (IP) address identifies the device of the buyer.</value>
        [DataMember(Name="internetProtocolAddress", EmitDefaultValue=false)]
        public string InternetProtocolAddress { get; private set; }

        /// <summary>
        /// InternetProtocolAddressCountry
        /// </summary>
        /// <value>InternetProtocolAddressCountry</value>
        [DataMember(Name="internetProtocolAddressCountry", EmitDefaultValue=false)]
        public string InternetProtocolAddressCountry { get; private set; }

        /// <summary>
        /// InvoiceMerchantReference
        /// </summary>
        /// <value>InvoiceMerchantReference</value>
        [DataMember(Name="invoiceMerchantReference", EmitDefaultValue=false)]
        public string InvoiceMerchantReference { get; private set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// LineItems
        /// </summary>
        /// <value>LineItems</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// MerchantReference
        /// </summary>
        /// <value>MerchantReference</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; private set; }

        /// <summary>
        /// Meta data allow to store additional data along the object.
        /// </summary>
        /// <value>Meta data allow to store additional data along the object.</value>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public Dictionary<string, string> MetaData { get; private set; }

        /// <summary>
        /// Parent
        /// </summary>
        /// <value>Parent</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public long? Parent { get; private set; }

        /// <summary>
        /// PaymentConnectorConfiguration
        /// </summary>
        /// <value>PaymentConnectorConfiguration</value>
        [DataMember(Name="paymentConnectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// ProcessingOn
        /// </summary>
        /// <value>ProcessingOn</value>
        [DataMember(Name="processingOn", EmitDefaultValue=false)]
        public DateTime? ProcessingOn { get; private set; }

        /// <summary>
        /// The refunded amount is the total amount which has been refunded so far.
        /// </summary>
        /// <value>The refunded amount is the total amount which has been refunded so far.</value>
        [DataMember(Name="refundedAmount", EmitDefaultValue=false)]
        public decimal? RefundedAmount { get; private set; }

        /// <summary>
        /// ShippingAddress
        /// </summary>
        /// <value>ShippingAddress</value>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public Address ShippingAddress { get; private set; }

        /// <summary>
        /// ShippingMethod
        /// </summary>
        /// <value>ShippingMethod</value>
        [DataMember(Name="shippingMethod", EmitDefaultValue=false)]
        public string ShippingMethod { get; private set; }

        /// <summary>
        /// SpaceViewId
        /// </summary>
        /// <value>SpaceViewId</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public TransactionState? State { get; private set; }

        /// <summary>
        /// The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
        public string SuccessUrl { get; private set; }

        /// <summary>
        /// The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.
        /// </summary>
        /// <value>The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// Token
        /// </summary>
        /// <value>Token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public Token Token { get; private set; }

        /// <summary>
        /// The tokenization mode controls if and how the tokenization of payment information is applied to the transaction.
        /// </summary>
        /// <value>The tokenization mode controls if and how the tokenization of payment information is applied to the transaction.</value>
        [DataMember(Name="tokenizationMode", EmitDefaultValue=false)]
        public TokenizationnMode? TokenizationMode { get; private set; }

        /// <summary>
        /// The user agent header provides the exact string which contains the user agent of the buyer.
        /// </summary>
        /// <value>The user agent header provides the exact string which contains the user agent of the buyer.</value>
        [DataMember(Name="userAgentHeader", EmitDefaultValue=false)]
        public string UserAgentHeader { get; private set; }

        /// <summary>
        /// The failure message describes for an end user why the transaction is failed in the language of the user. This is only provided when the transaction is marked as failed.
        /// </summary>
        /// <value>The failure message describes for an end user why the transaction is failed in the language of the user. This is only provided when the transaction is marked as failed.</value>
        [DataMember(Name="userFailureMessage", EmitDefaultValue=false)]
        public string UserFailureMessage { get; private set; }

        /// <summary>
        /// The user interface type defines through which user interface the transaction has been processed resp. created.
        /// </summary>
        /// <value>The user interface type defines through which user interface the transaction has been processed resp. created.</value>
        [DataMember(Name="userInterfaceType", EmitDefaultValue=false)]
        public TransactionUserInterfaceType? UserInterfaceType { get; private set; }

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
            return this.Equals(obj as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="other">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AcceptHeader == other.AcceptHeader ||
                    this.AcceptHeader != null &&
                    this.AcceptHeader.Equals(other.AcceptHeader)
                ) && 
                (
                    this.AcceptLanguageHeader == other.AcceptLanguageHeader ||
                    this.AcceptLanguageHeader != null &&
                    this.AcceptLanguageHeader.Equals(other.AcceptLanguageHeader)
                ) && 
                (
                    this.AllowedPaymentMethodBrands == other.AllowedPaymentMethodBrands ||
                    this.AllowedPaymentMethodBrands != null &&
                    this.AllowedPaymentMethodBrands.SequenceEqual(other.AllowedPaymentMethodBrands)
                ) && 
                (
                    this.AllowedPaymentMethodConfigurations == other.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(other.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.AuthorizationAmount == other.AuthorizationAmount ||
                    this.AuthorizationAmount != null &&
                    this.AuthorizationAmount.Equals(other.AuthorizationAmount)
                ) && 
                (
                    this.AuthorizationEnvironment == other.AuthorizationEnvironment ||
                    this.AuthorizationEnvironment != null &&
                    this.AuthorizationEnvironment.Equals(other.AuthorizationEnvironment)
                ) && 
                (
                    this.AuthorizationTimeoutOn == other.AuthorizationTimeoutOn ||
                    this.AuthorizationTimeoutOn != null &&
                    this.AuthorizationTimeoutOn.Equals(other.AuthorizationTimeoutOn)
                ) && 
                (
                    this.AuthorizedOn == other.AuthorizedOn ||
                    this.AuthorizedOn != null &&
                    this.AuthorizedOn.Equals(other.AuthorizedOn)
                ) && 
                (
                    this.AutoConfirmationEnabled == other.AutoConfirmationEnabled ||
                    this.AutoConfirmationEnabled != null &&
                    this.AutoConfirmationEnabled.Equals(other.AutoConfirmationEnabled)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.ChargeRetryEnabled == other.ChargeRetryEnabled ||
                    this.ChargeRetryEnabled != null &&
                    this.ChargeRetryEnabled.Equals(other.ChargeRetryEnabled)
                ) && 
                (
                    this.CompletedAmount == other.CompletedAmount ||
                    this.CompletedAmount != null &&
                    this.CompletedAmount.Equals(other.CompletedAmount)
                ) && 
                (
                    this.CompletedOn == other.CompletedOn ||
                    this.CompletedOn != null &&
                    this.CompletedOn.Equals(other.CompletedOn)
                ) && 
                (
                    this.CompletionTimeoutOn == other.CompletionTimeoutOn ||
                    this.CompletionTimeoutOn != null &&
                    this.CompletionTimeoutOn.Equals(other.CompletionTimeoutOn)
                ) && 
                (
                    this.ConfirmedBy == other.ConfirmedBy ||
                    this.ConfirmedBy != null &&
                    this.ConfirmedBy.Equals(other.ConfirmedBy)
                ) && 
                (
                    this.ConfirmedOn == other.ConfirmedOn ||
                    this.ConfirmedOn != null &&
                    this.ConfirmedOn.Equals(other.ConfirmedOn)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.CustomerEmailAddress == other.CustomerEmailAddress ||
                    this.CustomerEmailAddress != null &&
                    this.CustomerEmailAddress.Equals(other.CustomerEmailAddress)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.CustomersPresence == other.CustomersPresence ||
                    this.CustomersPresence != null &&
                    this.CustomersPresence.Equals(other.CustomersPresence)
                ) && 
                (
                    this.DeliveryDecisionMadeOn == other.DeliveryDecisionMadeOn ||
                    this.DeliveryDecisionMadeOn != null &&
                    this.DeliveryDecisionMadeOn.Equals(other.DeliveryDecisionMadeOn)
                ) && 
                (
                    this.DeviceSessionIdentifier == other.DeviceSessionIdentifier ||
                    this.DeviceSessionIdentifier != null &&
                    this.DeviceSessionIdentifier.Equals(other.DeviceSessionIdentifier)
                ) && 
                (
                    this.EndOfLife == other.EndOfLife ||
                    this.EndOfLife != null &&
                    this.EndOfLife.Equals(other.EndOfLife)
                ) && 
                (
                    this.Environment == other.Environment ||
                    this.Environment != null &&
                    this.Environment.Equals(other.Environment)
                ) && 
                (
                    this.EnvironmentSelectionStrategy == other.EnvironmentSelectionStrategy ||
                    this.EnvironmentSelectionStrategy != null &&
                    this.EnvironmentSelectionStrategy.Equals(other.EnvironmentSelectionStrategy)
                ) && 
                (
                    this.FailedOn == other.FailedOn ||
                    this.FailedOn != null &&
                    this.FailedOn.Equals(other.FailedOn)
                ) && 
                (
                    this.FailedUrl == other.FailedUrl ||
                    this.FailedUrl != null &&
                    this.FailedUrl.Equals(other.FailedUrl)
                ) && 
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InternetProtocolAddress == other.InternetProtocolAddress ||
                    this.InternetProtocolAddress != null &&
                    this.InternetProtocolAddress.Equals(other.InternetProtocolAddress)
                ) && 
                (
                    this.InternetProtocolAddressCountry == other.InternetProtocolAddressCountry ||
                    this.InternetProtocolAddressCountry != null &&
                    this.InternetProtocolAddressCountry.Equals(other.InternetProtocolAddressCountry)
                ) && 
                (
                    this.InvoiceMerchantReference == other.InvoiceMerchantReference ||
                    this.InvoiceMerchantReference != null &&
                    this.InvoiceMerchantReference.Equals(other.InvoiceMerchantReference)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.MetaData == other.MetaData ||
                    this.MetaData != null &&
                    this.MetaData.SequenceEqual(other.MetaData)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.PaymentConnectorConfiguration == other.PaymentConnectorConfiguration ||
                    this.PaymentConnectorConfiguration != null &&
                    this.PaymentConnectorConfiguration.Equals(other.PaymentConnectorConfiguration)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.ProcessingOn == other.ProcessingOn ||
                    this.ProcessingOn != null &&
                    this.ProcessingOn.Equals(other.ProcessingOn)
                ) && 
                (
                    this.RefundedAmount == other.RefundedAmount ||
                    this.RefundedAmount != null &&
                    this.RefundedAmount.Equals(other.RefundedAmount)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.ShippingMethod == other.ShippingMethod ||
                    this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(other.ShippingMethod)
                ) && 
                (
                    this.SpaceViewId == other.SpaceViewId ||
                    this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(other.SpaceViewId)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.SuccessUrl == other.SuccessUrl ||
                    this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(other.SuccessUrl)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.TokenizationMode == other.TokenizationMode ||
                    this.TokenizationMode != null &&
                    this.TokenizationMode.Equals(other.TokenizationMode)
                ) && 
                (
                    this.UserAgentHeader == other.UserAgentHeader ||
                    this.UserAgentHeader != null &&
                    this.UserAgentHeader.Equals(other.UserAgentHeader)
                ) && 
                (
                    this.UserFailureMessage == other.UserFailureMessage ||
                    this.UserFailureMessage != null &&
                    this.UserFailureMessage.Equals(other.UserFailureMessage)
                ) && 
                (
                    this.UserInterfaceType == other.UserInterfaceType ||
                    this.UserInterfaceType != null &&
                    this.UserInterfaceType.Equals(other.UserInterfaceType)
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
                if (this.AcceptHeader != null)
                {
                    hash = hash * 59 + this.AcceptHeader.GetHashCode();
                }
                if (this.AcceptLanguageHeader != null)
                {
                    hash = hash * 59 + this.AcceptLanguageHeader.GetHashCode();
                }
                if (this.AllowedPaymentMethodBrands != null)
                {
                    hash = hash * 59 + this.AllowedPaymentMethodBrands.GetHashCode();
                }
                if (this.AllowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.AuthorizationAmount != null)
                {
                    hash = hash * 59 + this.AuthorizationAmount.GetHashCode();
                }
                if (this.AuthorizationEnvironment != null)
                {
                    hash = hash * 59 + this.AuthorizationEnvironment.GetHashCode();
                }
                if (this.AuthorizationTimeoutOn != null)
                {
                    hash = hash * 59 + this.AuthorizationTimeoutOn.GetHashCode();
                }
                if (this.AuthorizedOn != null)
                {
                    hash = hash * 59 + this.AuthorizedOn.GetHashCode();
                }
                if (this.AutoConfirmationEnabled != null)
                {
                    hash = hash * 59 + this.AutoConfirmationEnabled.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                }
                if (this.ChargeRetryEnabled != null)
                {
                    hash = hash * 59 + this.ChargeRetryEnabled.GetHashCode();
                }
                if (this.CompletedAmount != null)
                {
                    hash = hash * 59 + this.CompletedAmount.GetHashCode();
                }
                if (this.CompletedOn != null)
                {
                    hash = hash * 59 + this.CompletedOn.GetHashCode();
                }
                if (this.CompletionTimeoutOn != null)
                {
                    hash = hash * 59 + this.CompletionTimeoutOn.GetHashCode();
                }
                if (this.ConfirmedBy != null)
                {
                    hash = hash * 59 + this.ConfirmedBy.GetHashCode();
                }
                if (this.ConfirmedOn != null)
                {
                    hash = hash * 59 + this.ConfirmedOn.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hash = hash * 59 + this.Currency.GetHashCode();
                }
                if (this.CustomerEmailAddress != null)
                {
                    hash = hash * 59 + this.CustomerEmailAddress.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                }
                if (this.CustomersPresence != null)
                {
                    hash = hash * 59 + this.CustomersPresence.GetHashCode();
                }
                if (this.DeliveryDecisionMadeOn != null)
                {
                    hash = hash * 59 + this.DeliveryDecisionMadeOn.GetHashCode();
                }
                if (this.DeviceSessionIdentifier != null)
                {
                    hash = hash * 59 + this.DeviceSessionIdentifier.GetHashCode();
                }
                if (this.EndOfLife != null)
                {
                    hash = hash * 59 + this.EndOfLife.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hash = hash * 59 + this.Environment.GetHashCode();
                }
                if (this.EnvironmentSelectionStrategy != null)
                {
                    hash = hash * 59 + this.EnvironmentSelectionStrategy.GetHashCode();
                }
                if (this.FailedOn != null)
                {
                    hash = hash * 59 + this.FailedOn.GetHashCode();
                }
                if (this.FailedUrl != null)
                {
                    hash = hash * 59 + this.FailedUrl.GetHashCode();
                }
                if (this.FailureReason != null)
                {
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                }
                if (this.Group != null)
                {
                    hash = hash * 59 + this.Group.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.InternetProtocolAddress != null)
                {
                    hash = hash * 59 + this.InternetProtocolAddress.GetHashCode();
                }
                if (this.InternetProtocolAddressCountry != null)
                {
                    hash = hash * 59 + this.InternetProtocolAddressCountry.GetHashCode();
                }
                if (this.InvoiceMerchantReference != null)
                {
                    hash = hash * 59 + this.InvoiceMerchantReference.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                }
                if (this.MetaData != null)
                {
                    hash = hash * 59 + this.MetaData.GetHashCode();
                }
                if (this.Parent != null)
                {
                    hash = hash * 59 + this.Parent.GetHashCode();
                }
                if (this.PaymentConnectorConfiguration != null)
                {
                    hash = hash * 59 + this.PaymentConnectorConfiguration.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.ProcessingOn != null)
                {
                    hash = hash * 59 + this.ProcessingOn.GetHashCode();
                }
                if (this.RefundedAmount != null)
                {
                    hash = hash * 59 + this.RefundedAmount.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                }
                if (this.ShippingMethod != null)
                {
                    hash = hash * 59 + this.ShippingMethod.GetHashCode();
                }
                if (this.SpaceViewId != null)
                {
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.SuccessUrl != null)
                {
                    hash = hash * 59 + this.SuccessUrl.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                }
                if (this.Token != null)
                {
                    hash = hash * 59 + this.Token.GetHashCode();
                }
                if (this.TokenizationMode != null)
                {
                    hash = hash * 59 + this.TokenizationMode.GetHashCode();
                }
                if (this.UserAgentHeader != null)
                {
                    hash = hash * 59 + this.UserAgentHeader.GetHashCode();
                }
                if (this.UserFailureMessage != null)
                {
                    hash = hash * 59 + this.UserFailureMessage.GetHashCode();
                }
                if (this.UserInterfaceType != null)
                {
                    hash = hash * 59 + this.UserInterfaceType.GetHashCode();
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
