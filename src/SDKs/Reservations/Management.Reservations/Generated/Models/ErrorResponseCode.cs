// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{

    /// <summary>
    /// Defines values for ErrorResponseCode.
    /// </summary>
    public static class ErrorResponseCode
    {
        public const string NotSpecified = "NotSpecified";
        public const string InternalServerError = "InternalServerError";
        public const string ServerTimeout = "ServerTimeout";
        public const string AuthorizationFailed = "AuthorizationFailed";
        public const string BadRequest = "BadRequest";
        public const string ClientCertificateThumbprintNotSet = "ClientCertificateThumbprintNotSet";
        public const string InvalidRequestContent = "InvalidRequestContent";
        public const string OperationFailed = "OperationFailed";
        public const string HttpMethodNotSupported = "HttpMethodNotSupported";
        public const string InvalidRequestUri = "InvalidRequestUri";
        public const string MissingTenantId = "MissingTenantId";
        public const string InvalidTenantId = "InvalidTenantId";
        public const string InvalidReservationOrderId = "InvalidReservationOrderId";
        public const string InvalidReservationId = "InvalidReservationId";
        public const string ReservationIdNotInReservationOrder = "ReservationIdNotInReservationOrder";
        public const string ReservationOrderNotFound = "ReservationOrderNotFound";
        public const string InvalidSubscriptionId = "InvalidSubscriptionId";
        public const string InvalidAccessToken = "InvalidAccessToken";
        public const string InvalidLocationId = "InvalidLocationId";
        public const string UnauthenticatedRequestsThrottled = "UnauthenticatedRequestsThrottled";
        public const string InvalidHealthCheckType = "InvalidHealthCheckType";
        public const string Forbidden = "Forbidden";
        public const string BillingScopeIdCannotBeChanged = "BillingScopeIdCannotBeChanged";
        public const string AppliedScopesNotAssociatedWithCommerceAccount = "AppliedScopesNotAssociatedWithCommerceAccount";
        public const string PatchValuesSameAsExisting = "PatchValuesSameAsExisting";
        public const string RoleAssignmentCreationFailed = "RoleAssignmentCreationFailed";
        public const string ReservationOrderCreationFailed = "ReservationOrderCreationFailed";
        public const string ReservationOrderNotEnabled = "ReservationOrderNotEnabled";
        public const string CapacityUpdateScopesFailed = "CapacityUpdateScopesFailed";
        public const string UnsupportedReservationTerm = "UnsupportedReservationTerm";
        public const string ReservationOrderIdAlreadyExists = "ReservationOrderIdAlreadyExists";
        public const string RiskCheckFailed = "RiskCheckFailed";
        public const string CreateQuoteFailed = "CreateQuoteFailed";
        public const string ActivateQuoteFailed = "ActivateQuoteFailed";
        public const string NonsupportedAccountId = "NonsupportedAccountId";
        public const string PaymentInstrumentNotFound = "PaymentInstrumentNotFound";
        public const string MissingAppliedScopesForSingle = "MissingAppliedScopesForSingle";
        public const string NoValidReservationsToReRate = "NoValidReservationsToReRate";
        public const string ReRateOnlyAllowedForEA = "ReRateOnlyAllowedForEA";
        public const string OperationCannotBePerformedInCurrentState = "OperationCannotBePerformedInCurrentState";
        public const string InvalidSingleAppliedScopesCount = "InvalidSingleAppliedScopesCount";
        public const string InvalidFulfillmentRequestParameters = "InvalidFulfillmentRequestParameters";
        public const string NotSupportedCountry = "NotSupportedCountry";
        public const string InvalidRefundQuantity = "InvalidRefundQuantity";
        public const string PurchaseError = "PurchaseError";
        public const string BillingCustomerInputError = "BillingCustomerInputError";
        public const string BillingPaymentInstrumentSoftError = "BillingPaymentInstrumentSoftError";
        public const string BillingPaymentInstrumentHardError = "BillingPaymentInstrumentHardError";
        public const string BillingTransientError = "BillingTransientError";
        public const string BillingError = "BillingError";
        public const string FulfillmentConfigurationError = "FulfillmentConfigurationError";
        public const string FulfillmentOutOfStockError = "FulfillmentOutOfStockError";
        public const string FulfillmentTransientError = "FulfillmentTransientError";
        public const string FulfillmentError = "FulfillmentError";
        public const string CalculatePriceFailed = "CalculatePriceFailed";
    }
}
