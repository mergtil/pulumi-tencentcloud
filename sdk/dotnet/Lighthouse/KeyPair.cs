// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Lighthouse
{
    [TencentcloudResourceType("tencentcloud:Lighthouse/keyPair:KeyPair")]
    public partial class KeyPair : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Creation time. Expressed according to the ISO8601 standard, and using UTC time. Format: YYYY-MM-DDThh:mm:ssZ.
        /// </summary>
        [Output("createdTime")]
        public Output<string> CreatedTime { get; private set; } = null!;

        /// <summary>
        /// Key pair name, which can contain up to 25 digits, letters, and underscores.
        /// </summary>
        [Output("keyName")]
        public Output<string> KeyName { get; private set; } = null!;

        /// <summary>
        /// Key to private key.
        /// </summary>
        [Output("privateKey")]
        public Output<string> PrivateKey { get; private set; } = null!;

        /// <summary>
        /// Public key content of the key pair, which is in the OpenSSH RSA format.
        /// </summary>
        [Output("publicKey")]
        public Output<string> PublicKey { get; private set; } = null!;


        /// <summary>
        /// Create a KeyPair resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KeyPair(string name, KeyPairArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Lighthouse/keyPair:KeyPair", name, args ?? new KeyPairArgs(), MakeResourceOptions(options, ""))
        {
        }

        private KeyPair(string name, Input<string> id, KeyPairState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Lighthouse/keyPair:KeyPair", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing KeyPair resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KeyPair Get(string name, Input<string> id, KeyPairState? state = null, CustomResourceOptions? options = null)
        {
            return new KeyPair(name, id, state, options);
        }
    }

    public sealed class KeyPairArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Key pair name, which can contain up to 25 digits, letters, and underscores.
        /// </summary>
        [Input("keyName", required: true)]
        public Input<string> KeyName { get; set; } = null!;

        /// <summary>
        /// Public key content of the key pair, which is in the OpenSSH RSA format.
        /// </summary>
        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        public KeyPairArgs()
        {
        }
        public static new KeyPairArgs Empty => new KeyPairArgs();
    }

    public sealed class KeyPairState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation time. Expressed according to the ISO8601 standard, and using UTC time. Format: YYYY-MM-DDThh:mm:ssZ.
        /// </summary>
        [Input("createdTime")]
        public Input<string>? CreatedTime { get; set; }

        /// <summary>
        /// Key pair name, which can contain up to 25 digits, letters, and underscores.
        /// </summary>
        [Input("keyName")]
        public Input<string>? KeyName { get; set; }

        /// <summary>
        /// Key to private key.
        /// </summary>
        [Input("privateKey")]
        public Input<string>? PrivateKey { get; set; }

        /// <summary>
        /// Public key content of the key pair, which is in the OpenSSH RSA format.
        /// </summary>
        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        public KeyPairState()
        {
        }
        public static new KeyPairState Empty => new KeyPairState();
    }
}