// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpn.Outputs
{

    [OutputType]
    public sealed class CustomerGatewayConfigurationDownloadCustomerGatewayVendor
    {
        public readonly string Platform;
        public readonly string SoftwareVersion;
        public readonly string VendorName;

        [OutputConstructor]
        private CustomerGatewayConfigurationDownloadCustomerGatewayVendor(
            string platform,

            string softwareVersion,

            string vendorName)
        {
            Platform = platform;
            SoftwareVersion = softwareVersion;
            VendorName = vendorName;
        }
    }
}
