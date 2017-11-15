// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Reservations;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ExtendedErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedErrorInfo class.
        /// </summary>
        public ExtendedErrorInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedErrorInfo class.
        /// </summary>
        /// <param name="code">Possible values include: 'NotSpecified',
        /// 'InternalServerError', 'ServerTimeout', 'AuthorizationFailed',
        /// 'BadRequest', 'ClientCertificateThumbprintNotSet',
        /// 'InvalidRequestContent', 'OperationFailed',
        /// 'HttpMethodNotSupported', 'InvalidRequestUri', 'MissingTenantId',
        /// 'InvalidTenantId', 'InvalidReservationOrderId',
        /// 'InvalidReservationId', 'ReservationIdNotInReservationOrder',
        /// 'ReservationOrderNotFound', 'InvalidSubscriptionId',
        /// 'InvalidAccessToken', 'InvalidLocationId',
        /// 'UnauthenticatedRequestsThrottled', 'InvalidHealthCheckType',
        /// 'Forbidden', 'BillingScopeIdCannotBeChanged',
        /// 'AppliedScopesNotAssociatedWithCommerceAccount',
        /// 'AppliedScopesSameAsExisting', 'RoleAssignmentCreationFailed',
        /// 'ReservationOrderCreationFailed', 'ReservationOrderNotEnabled',
        /// 'CapacityUpdateScopesFailed', 'UnsupportedReservationTerm',
        /// 'ReservationOrderIdAlreadyExists', 'RiskCheckFailed',
        /// 'CreateQuoteFailed', 'ActivateQuoteFailed',
        /// 'NonsupportedAccountId', 'PaymentInstrumentNotFound',
        /// 'MissingAppliedScopesForSingle', 'NoValidReservationsToReRate',
        /// 'ReRateOnlyAllowedForEA',
        /// 'OperationCannotBePerformedInCurrentState',
        /// 'InvalidSingleAppliedScopesCount',
        /// 'InvalidFulfillmentRequestParameters', 'NotSupportedCountry',
        /// 'InvalidRefundQuantity', 'PurchaseError',
        /// 'BillingCustomerInputError', 'BillingPaymentInstrumentSoftError',
        /// 'BillingPaymentInstrumentHardError', 'BillingTransientError',
        /// 'BillingError', 'FulfillmentConfigurationError',
        /// 'FulfillmentOutOfStockError', 'FulfillmentTransientError',
        /// 'FulfillmentError', 'CalculatePriceFailed'</param>
        public ExtendedErrorInfo(string code = default(string), string message = default(string))
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'NotSpecified',
        /// 'InternalServerError', 'ServerTimeout', 'AuthorizationFailed',
        /// 'BadRequest', 'ClientCertificateThumbprintNotSet',
        /// 'InvalidRequestContent', 'OperationFailed',
        /// 'HttpMethodNotSupported', 'InvalidRequestUri', 'MissingTenantId',
        /// 'InvalidTenantId', 'InvalidReservationOrderId',
        /// 'InvalidReservationId', 'ReservationIdNotInReservationOrder',
        /// 'ReservationOrderNotFound', 'InvalidSubscriptionId',
        /// 'InvalidAccessToken', 'InvalidLocationId',
        /// 'UnauthenticatedRequestsThrottled', 'InvalidHealthCheckType',
        /// 'Forbidden', 'BillingScopeIdCannotBeChanged',
        /// 'AppliedScopesNotAssociatedWithCommerceAccount',
        /// 'AppliedScopesSameAsExisting', 'RoleAssignmentCreationFailed',
        /// 'ReservationOrderCreationFailed', 'ReservationOrderNotEnabled',
        /// 'CapacityUpdateScopesFailed', 'UnsupportedReservationTerm',
        /// 'ReservationOrderIdAlreadyExists', 'RiskCheckFailed',
        /// 'CreateQuoteFailed', 'ActivateQuoteFailed',
        /// 'NonsupportedAccountId', 'PaymentInstrumentNotFound',
        /// 'MissingAppliedScopesForSingle', 'NoValidReservationsToReRate',
        /// 'ReRateOnlyAllowedForEA',
        /// 'OperationCannotBePerformedInCurrentState',
        /// 'InvalidSingleAppliedScopesCount',
        /// 'InvalidFulfillmentRequestParameters', 'NotSupportedCountry',
        /// 'InvalidRefundQuantity', 'PurchaseError',
        /// 'BillingCustomerInputError', 'BillingPaymentInstrumentSoftError',
        /// 'BillingPaymentInstrumentHardError', 'BillingTransientError',
        /// 'BillingError', 'FulfillmentConfigurationError',
        /// 'FulfillmentOutOfStockError', 'FulfillmentTransientError',
        /// 'FulfillmentError', 'CalculatePriceFailed'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}