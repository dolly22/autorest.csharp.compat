// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using TypeSchemaMapping;
using TypeSchemaMapping.Models;

namespace CustomNamespace
{
    /// <summary> The Main service client. </summary>
    internal partial class MainClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal MainRestClient RestClient { get; }

        /// <summary> Initializes a new instance of MainClient for mocking. </summary>
        protected MainClient()
        {
        }

        /// <summary> Initializes a new instance of MainClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal MainClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new MainRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <param name="body"> The ModelStruct to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RenamedModelStruct>> OperationStructAsync(RenamedModelStruct? body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationStruct");
            scope.Start();
            try
            {
                return await RestClient.OperationStructAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The ModelStruct to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RenamedModelStruct> OperationStruct(RenamedModelStruct? body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationStruct");
            scope.Start();
            try
            {
                return RestClient.OperationStruct(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The SecondModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecondModel>> OperationSecondModelAsync(SecondModel body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationSecondModel");
            scope.Start();
            try
            {
                return await RestClient.OperationSecondModelAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The SecondModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecondModel> OperationSecondModel(SecondModel body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationSecondModel");
            scope.Start();
            try
            {
                return RestClient.OperationSecondModel(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The ThirdModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RenamedThirdModel>> OperationThirdModelAsync(RenamedThirdModel body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationThirdModel");
            scope.Start();
            try
            {
                return await RestClient.OperationThirdModelAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The ThirdModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RenamedThirdModel> OperationThirdModel(RenamedThirdModel body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationThirdModel");
            scope.Start();
            try
            {
                return RestClient.OperationThirdModel(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The ModelWithArrayOfEnum to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ModelWithArrayOfEnum>> OperationModelWithArrayOfEnumAsync(ModelWithArrayOfEnum body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationModelWithArrayOfEnum");
            scope.Start();
            try
            {
                return await RestClient.OperationModelWithArrayOfEnumAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The ModelWithArrayOfEnum to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ModelWithArrayOfEnum> OperationModelWithArrayOfEnum(ModelWithArrayOfEnum body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationModelWithArrayOfEnum");
            scope.Start();
            try
            {
                return RestClient.OperationModelWithArrayOfEnum(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ModelWithInternalModel>> OperationWithInternalModelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationWithInternalModel");
            scope.Start();
            try
            {
                return await RestClient.OperationWithInternalModelAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ModelWithInternalModel> OperationWithInternalModel(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationWithInternalModel");
            scope.Start();
            try
            {
                return RestClient.OperationWithInternalModel(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ModelWithAbstractModel>> OperationWithAbstractModelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationWithAbstractModel");
            scope.Start();
            try
            {
                return await RestClient.OperationWithAbstractModelAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ModelWithAbstractModel> OperationWithAbstractModel(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationWithAbstractModel");
            scope.Start();
            try
            {
                return RestClient.OperationWithAbstractModel(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ModelWithListOfInternalModel>> OperationWithListOfInternalModelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationWithListOfInternalModel");
            scope.Start();
            try
            {
                return await RestClient.OperationWithListOfInternalModelAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ModelWithListOfInternalModel> OperationWithListOfInternalModel(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationWithListOfInternalModel");
            scope.Start();
            try
            {
                return RestClient.OperationWithListOfInternalModel(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PublicModelWithInternalProperty>> OperationWithPublicModelWithInternalPropertyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationWithPublicModelWithInternalProperty");
            scope.Start();
            try
            {
                return await RestClient.OperationWithPublicModelWithInternalPropertyAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PublicModelWithInternalProperty> OperationWithPublicModelWithInternalProperty(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.OperationWithPublicModelWithInternalProperty");
            scope.Start();
            try
            {
                return RestClient.OperationWithPublicModelWithInternalProperty(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The Model to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<MainOperation> StartOperationAsync(CustomizedModel body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.StartOperation");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.OperationAsync(body, cancellationToken).ConfigureAwait(false);
                return new MainOperation(_clientDiagnostics, _pipeline, RestClient.CreateOperationRequest(body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The Model to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual MainOperation StartOperation(CustomizedModel body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MainClient.StartOperation");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Operation(body, cancellationToken);
                return new MainOperation(_clientDiagnostics, _pipeline, RestClient.CreateOperationRequest(body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
