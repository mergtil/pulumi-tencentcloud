// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Inputs
{

    public sealed class DomainAuthenticationTypeCArgs : global::Pulumi.ResourceArgs
    {
        [Input("backupSecretKey")]
        public Input<string>? BackupSecretKey { get; set; }

        [Input("expireTime", required: true)]
        public Input<int> ExpireTime { get; set; } = null!;

        [Input("fileExtensions", required: true)]
        private InputList<string>? _fileExtensions;
        public InputList<string> FileExtensions
        {
            get => _fileExtensions ?? (_fileExtensions = new InputList<string>());
            set => _fileExtensions = value;
        }

        [Input("filterType", required: true)]
        public Input<string> FilterType { get; set; } = null!;

        [Input("secretKey", required: true)]
        public Input<string> SecretKey { get; set; } = null!;

        [Input("timeFormat")]
        public Input<string>? TimeFormat { get; set; }

        public DomainAuthenticationTypeCArgs()
        {
        }
        public static new DomainAuthenticationTypeCArgs Empty => new DomainAuthenticationTypeCArgs();
    }
}
