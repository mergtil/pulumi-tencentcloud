// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getFirewallRulesTemplate(args?: GetFirewallRulesTemplateArgs, opts?: pulumi.InvokeOptions): Promise<GetFirewallRulesTemplateResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Lighthouse/getFirewallRulesTemplate:getFirewallRulesTemplate", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getFirewallRulesTemplate.
 */
export interface GetFirewallRulesTemplateArgs {
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getFirewallRulesTemplate.
 */
export interface GetFirewallRulesTemplateResult {
    readonly firewallRuleSets: outputs.Lighthouse.GetFirewallRulesTemplateFirewallRuleSet[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
export function getFirewallRulesTemplateOutput(args?: GetFirewallRulesTemplateOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFirewallRulesTemplateResult> {
    return pulumi.output(args).apply((a: any) => getFirewallRulesTemplate(a, opts))
}

/**
 * A collection of arguments for invoking getFirewallRulesTemplate.
 */
export interface GetFirewallRulesTemplateOutputArgs {
    resultOutputFile?: pulumi.Input<string>;
}