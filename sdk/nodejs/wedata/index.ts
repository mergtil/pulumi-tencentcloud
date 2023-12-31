// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export { GetRuleTemplatesArgs, GetRuleTemplatesResult, GetRuleTemplatesOutputArgs } from "./getRuleTemplates";
export const getRuleTemplates: typeof import("./getRuleTemplates").getRuleTemplates = null as any;
export const getRuleTemplatesOutput: typeof import("./getRuleTemplates").getRuleTemplatesOutput = null as any;
utilities.lazyLoad(exports, ["getRuleTemplates","getRuleTemplatesOutput"], () => require("./getRuleTemplates"));

export { RuleTemplateArgs, RuleTemplateState } from "./ruleTemplate";
export type RuleTemplate = import("./ruleTemplate").RuleTemplate;
export const RuleTemplate: typeof import("./ruleTemplate").RuleTemplate = null as any;
utilities.lazyLoad(exports, ["RuleTemplate"], () => require("./ruleTemplate"));


const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Wedata/ruleTemplate:RuleTemplate":
                return new RuleTemplate(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Wedata/ruleTemplate", _module)
