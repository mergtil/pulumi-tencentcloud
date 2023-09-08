// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Kms
{
    public static class GetGetParametersForImport
    {
        public static Task<GetGetParametersForImportResult> InvokeAsync(GetGetParametersForImportArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetGetParametersForImportResult>("tencentcloud:Kms/getGetParametersForImport:getGetParametersForImport", args ?? new GetGetParametersForImportArgs(), options.WithDefaults());

        public static Output<GetGetParametersForImportResult> Invoke(GetGetParametersForImportInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetGetParametersForImportResult>("tencentcloud:Kms/getGetParametersForImport:getGetParametersForImport", args ?? new GetGetParametersForImportInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetGetParametersForImportArgs : global::Pulumi.InvokeArgs
    {
        [Input("keyId", required: true)]
        public string KeyId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("wrappingAlgorithm", required: true)]
        public string WrappingAlgorithm { get; set; } = null!;

        [Input("wrappingKeySpec", required: true)]
        public string WrappingKeySpec { get; set; } = null!;

        public GetGetParametersForImportArgs()
        {
        }
        public static new GetGetParametersForImportArgs Empty => new GetGetParametersForImportArgs();
    }

    public sealed class GetGetParametersForImportInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("wrappingAlgorithm", required: true)]
        public Input<string> WrappingAlgorithm { get; set; } = null!;

        [Input("wrappingKeySpec", required: true)]
        public Input<string> WrappingKeySpec { get; set; } = null!;

        public GetGetParametersForImportInvokeArgs()
        {
        }
        public static new GetGetParametersForImportInvokeArgs Empty => new GetGetParametersForImportInvokeArgs();
    }


    [OutputType]
    public sealed class GetGetParametersForImportResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string ImportToken;
        public readonly string KeyId;
        public readonly int ParametersValidTo;
        public readonly string PublicKey;
        public readonly string? ResultOutputFile;
        public readonly string WrappingAlgorithm;
        public readonly string WrappingKeySpec;

        [OutputConstructor]
        private GetGetParametersForImportResult(
            string id,

            string importToken,

            string keyId,

            int parametersValidTo,

            string publicKey,

            string? resultOutputFile,

            string wrappingAlgorithm,

            string wrappingKeySpec)
        {
            Id = id;
            ImportToken = importToken;
            KeyId = keyId;
            ParametersValidTo = parametersValidTo;
            PublicKey = publicKey;
            ResultOutputFile = resultOutputFile;
            WrappingAlgorithm = wrappingAlgorithm;
            WrappingKeySpec = wrappingKeySpec;
        }
    }
}
