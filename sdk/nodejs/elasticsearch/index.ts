// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export { GetInstancesArgs, GetInstancesResult, GetInstancesOutputArgs } from "./getInstances";
export const getInstances: typeof import("./getInstances").getInstances = null as any;
export const getInstancesOutput: typeof import("./getInstances").getInstancesOutput = null as any;
utilities.lazyLoad(exports, ["getInstances","getInstancesOutput"], () => require("./getInstances"));

export { InstanceArgs, InstanceState } from "./instance";
export type Instance = import("./instance").Instance;
export const Instance: typeof import("./instance").Instance = null as any;
utilities.lazyLoad(exports, ["Instance"], () => require("./instance"));

export { SecurityGroupArgs, SecurityGroupState } from "./securityGroup";
export type SecurityGroup = import("./securityGroup").SecurityGroup;
export const SecurityGroup: typeof import("./securityGroup").SecurityGroup = null as any;
utilities.lazyLoad(exports, ["SecurityGroup"], () => require("./securityGroup"));


const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Elasticsearch/instance:Instance":
                return new Instance(name, <any>undefined, { urn })
            case "tencentcloud:Elasticsearch/securityGroup:SecurityGroup":
                return new SecurityGroup(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Elasticsearch/instance", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Elasticsearch/securityGroup", _module)
