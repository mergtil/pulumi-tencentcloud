// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class SshKeyPairSecret extends pulumi.CustomResource {
    /**
     * Get an existing SshKeyPairSecret resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SshKeyPairSecretState, opts?: pulumi.CustomResourceOptions): SshKeyPairSecret {
        return new SshKeyPairSecret(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Ssm/sshKeyPairSecret:SshKeyPairSecret';

    /**
     * Returns true if the given object is an instance of SshKeyPairSecret.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SshKeyPairSecret {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SshKeyPairSecret.__pulumiType;
    }

    /**
     * Specifies whether to delete the SSH key from both the secret and the SSH key list in the CVM console. This field is only
     * take effect when delete SSH key secrets. Valid values: `True`: deletes SSH key from both the secret and SSH key list in
     * the CVM console. Note that the deletion will fail if the SSH key is already bound to a CVM instance.`False`: only
     * deletes the SSH key information in the secret.
     */
    public readonly cleanSshKey!: pulumi.Output<boolean | undefined>;
    /**
     * Credential creation time in UNIX timestamp format.
     */
    public /*out*/ readonly createTime!: pulumi.Output<number>;
    /**
     * Description, such as what it is used for. It contains up to 2,048 bytes.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Specifies a KMS CMK to encrypt the secret.If this parameter is left empty, the CMK created by Secrets Manager by default
     * will be used for encryption.You can also specify a custom KMS CMK created in the same region for encryption.
     */
    public readonly kmsKeyId!: pulumi.Output<string | undefined>;
    /**
     * ID of the project to which the created SSH key belongs.
     */
    public readonly projectId!: pulumi.Output<number>;
    /**
     * Secret name, which must be unique in the same region. It can contain 128 bytes of letters, digits, hyphens and
     * underscores and must begin with a letter or digit.
     */
    public readonly secretName!: pulumi.Output<string>;
    /**
     * `0`: user-defined secret. `1`: Tencent Cloud services secret. `2`: SSH key secret. `3`: Tencent Cloud API key secret.
     * Note: this field may return `null`, indicating that no valid values can be obtained.
     */
    public /*out*/ readonly secretType!: pulumi.Output<number>;
    /**
     * Name of the SSH key pair, which only contains digits, letters and underscores and must start with a digit or letter. The
     * maximum length is 25 characters.
     */
    public readonly sshKeyName!: pulumi.Output<string | undefined>;
    /**
     * Enable or Disable Secret. Valid values is `Enabled` or `Disabled`. Default is `Enabled`.
     */
    public readonly status!: pulumi.Output<string>;
    /**
     * Tags of secret.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a SshKeyPairSecret resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SshKeyPairSecretArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SshKeyPairSecretArgs | SshKeyPairSecretState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SshKeyPairSecretState | undefined;
            resourceInputs["cleanSshKey"] = state ? state.cleanSshKey : undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["kmsKeyId"] = state ? state.kmsKeyId : undefined;
            resourceInputs["projectId"] = state ? state.projectId : undefined;
            resourceInputs["secretName"] = state ? state.secretName : undefined;
            resourceInputs["secretType"] = state ? state.secretType : undefined;
            resourceInputs["sshKeyName"] = state ? state.sshKeyName : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as SshKeyPairSecretArgs | undefined;
            if ((!args || args.projectId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectId'");
            }
            if ((!args || args.secretName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'secretName'");
            }
            resourceInputs["cleanSshKey"] = args ? args.cleanSshKey : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["kmsKeyId"] = args ? args.kmsKeyId : undefined;
            resourceInputs["projectId"] = args ? args.projectId : undefined;
            resourceInputs["secretName"] = args ? args.secretName : undefined;
            resourceInputs["sshKeyName"] = args ? args.sshKeyName : undefined;
            resourceInputs["status"] = args ? args.status : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["secretType"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SshKeyPairSecret.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SshKeyPairSecret resources.
 */
export interface SshKeyPairSecretState {
    /**
     * Specifies whether to delete the SSH key from both the secret and the SSH key list in the CVM console. This field is only
     * take effect when delete SSH key secrets. Valid values: `True`: deletes SSH key from both the secret and SSH key list in
     * the CVM console. Note that the deletion will fail if the SSH key is already bound to a CVM instance.`False`: only
     * deletes the SSH key information in the secret.
     */
    cleanSshKey?: pulumi.Input<boolean>;
    /**
     * Credential creation time in UNIX timestamp format.
     */
    createTime?: pulumi.Input<number>;
    /**
     * Description, such as what it is used for. It contains up to 2,048 bytes.
     */
    description?: pulumi.Input<string>;
    /**
     * Specifies a KMS CMK to encrypt the secret.If this parameter is left empty, the CMK created by Secrets Manager by default
     * will be used for encryption.You can also specify a custom KMS CMK created in the same region for encryption.
     */
    kmsKeyId?: pulumi.Input<string>;
    /**
     * ID of the project to which the created SSH key belongs.
     */
    projectId?: pulumi.Input<number>;
    /**
     * Secret name, which must be unique in the same region. It can contain 128 bytes of letters, digits, hyphens and
     * underscores and must begin with a letter or digit.
     */
    secretName?: pulumi.Input<string>;
    /**
     * `0`: user-defined secret. `1`: Tencent Cloud services secret. `2`: SSH key secret. `3`: Tencent Cloud API key secret.
     * Note: this field may return `null`, indicating that no valid values can be obtained.
     */
    secretType?: pulumi.Input<number>;
    /**
     * Name of the SSH key pair, which only contains digits, letters and underscores and must start with a digit or letter. The
     * maximum length is 25 characters.
     */
    sshKeyName?: pulumi.Input<string>;
    /**
     * Enable or Disable Secret. Valid values is `Enabled` or `Disabled`. Default is `Enabled`.
     */
    status?: pulumi.Input<string>;
    /**
     * Tags of secret.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a SshKeyPairSecret resource.
 */
export interface SshKeyPairSecretArgs {
    /**
     * Specifies whether to delete the SSH key from both the secret and the SSH key list in the CVM console. This field is only
     * take effect when delete SSH key secrets. Valid values: `True`: deletes SSH key from both the secret and SSH key list in
     * the CVM console. Note that the deletion will fail if the SSH key is already bound to a CVM instance.`False`: only
     * deletes the SSH key information in the secret.
     */
    cleanSshKey?: pulumi.Input<boolean>;
    /**
     * Description, such as what it is used for. It contains up to 2,048 bytes.
     */
    description?: pulumi.Input<string>;
    /**
     * Specifies a KMS CMK to encrypt the secret.If this parameter is left empty, the CMK created by Secrets Manager by default
     * will be used for encryption.You can also specify a custom KMS CMK created in the same region for encryption.
     */
    kmsKeyId?: pulumi.Input<string>;
    /**
     * ID of the project to which the created SSH key belongs.
     */
    projectId: pulumi.Input<number>;
    /**
     * Secret name, which must be unique in the same region. It can contain 128 bytes of letters, digits, hyphens and
     * underscores and must begin with a letter or digit.
     */
    secretName: pulumi.Input<string>;
    /**
     * Name of the SSH key pair, which only contains digits, letters and underscores and must start with a digit or letter. The
     * maximum length is 25 characters.
     */
    sshKeyName?: pulumi.Input<string>;
    /**
     * Enable or Disable Secret. Valid values is `Enabled` or `Disabled`. Default is `Enabled`.
     */
    status?: pulumi.Input<string>;
    /**
     * Tags of secret.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}