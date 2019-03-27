// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AzureAccounts operations.
    /// </summary>
    public partial interface IAzureAccounts
    {
        /// <summary>
        /// apps - Assign a LUIS Azure account to an application
        /// </summary>
        /// <remarks>
        /// Assigns an Azure account to the application.
        /// </remarks>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='azureAccountInfoObject'>
        /// The Azure account information object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<OperationStatus>> AssignToAppWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, AzureAccountInfoObject azureAccountInfoObject = default(AzureAccountInfoObject), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// apps - Get LUIS Azure accounts assigned to the application
        /// </summary>
        /// <remarks>
        /// Gets the LUIS Azure accounts assigned to the application for the
        /// user using his ARM token.
        /// </remarks>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<IList<AzureAccountInfoObject>>> GetAssignedWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// apps - Removes an assigned LUIS Azure account from an application
        /// </summary>
        /// <remarks>
        /// Removes assigned Azure account from the application.
        /// </remarks>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='azureAccountInfoObject'>
        /// The Azure account information object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<OperationStatus>> RemoveFromAppWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, System.Guid appId, AzureAccountInfoObject azureAccountInfoObject = default(AzureAccountInfoObject), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// user - Get LUIS Azure accounts
        /// </summary>
        /// <remarks>
        /// Gets the LUIS Azure accounts for the user using his ARM token.
        /// </remarks>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'virginia'
        /// </param>
        /// <param name='azureCloud'>
        /// Supported Azure Clouds for Cognitive Services endpoints. Possible
        /// values include: 'com', 'us'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<IList<AzureAccountInfoObject>>> ListUserLUISAccountsWithHttpMessagesAsync(AzureRegions azureRegion, AzureClouds azureCloud, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}