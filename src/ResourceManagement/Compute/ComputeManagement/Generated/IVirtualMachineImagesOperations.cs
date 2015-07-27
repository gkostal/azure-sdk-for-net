namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// VirtualMachineImagesOperations operations.
    /// </summary>
    public partial interface IVirtualMachineImagesOperations
    {
        /// <summary>
        /// Gets a virtual machine image.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='offer'>
        /// </param>
        /// <param name='skus'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineImage>> GetWithHttpMessagesAsync(string location, string publisherName, string offer, string skus, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine image offers.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListOffersWithHttpMessagesAsync(string location, string publisherName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine image publishers.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListPublishersWithHttpMessagesAsync(string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine image skus.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='offer'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListSkusWithHttpMessagesAsync(string location, string publisherName, string offer, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine images.
        /// </summary>
        /// <param name='location'>
        /// </param>
        /// <param name='publisherName'>
        /// </param>
        /// <param name='offer'>
        /// </param>
        /// <param name='skus'>
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// </param>
        /// <param name='orderby'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListWithHttpMessagesAsync(string location, string publisherName, string offer, string skus, Expression<Func<VirtualMachineImageResource, bool>> filter = default(Expression<Func<VirtualMachineImageResource, bool>>), int? top = default(int?), string orderby = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
