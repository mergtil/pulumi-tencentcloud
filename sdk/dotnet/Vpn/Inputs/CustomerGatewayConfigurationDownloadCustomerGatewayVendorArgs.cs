// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpn.Inputs
{

    public sealed class CustomerGatewayConfigurationDownloadCustomerGatewayVendorArgs : global::Pulumi.ResourceArgs
    {
        [Input("platform", required: true)]
        public Input<string> Platform { get; set; } = null!;

        [Input("softwareVersion", required: true)]
        public Input<string> SoftwareVersion { get; set; } = null!;

        [Input("vendorName", required: true)]
        public Input<string> VendorName { get; set; } = null!;

        public CustomerGatewayConfigurationDownloadCustomerGatewayVendorArgs()
        {
        }
        public static new CustomerGatewayConfigurationDownloadCustomerGatewayVendorArgs Empty => new CustomerGatewayConfigurationDownloadCustomerGatewayVendorArgs();
    }
}
