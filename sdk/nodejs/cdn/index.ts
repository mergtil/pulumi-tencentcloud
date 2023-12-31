// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export { DomainArgs, DomainState } from "./domain";
export type Domain = import("./domain").Domain;
export const Domain: typeof import("./domain").Domain = null as any;
utilities.lazyLoad(exports, ["Domain"], () => require("./domain"));

export { GetDomainVerifierArgs, GetDomainVerifierResult, GetDomainVerifierOutputArgs } from "./getDomainVerifier";
export const getDomainVerifier: typeof import("./getDomainVerifier").getDomainVerifier = null as any;
export const getDomainVerifierOutput: typeof import("./getDomainVerifier").getDomainVerifierOutput = null as any;
utilities.lazyLoad(exports, ["getDomainVerifier","getDomainVerifierOutput"], () => require("./getDomainVerifier"));

export { GetDomainsArgs, GetDomainsResult, GetDomainsOutputArgs } from "./getDomains";
export const getDomains: typeof import("./getDomains").getDomains = null as any;
export const getDomainsOutput: typeof import("./getDomains").getDomainsOutput = null as any;
utilities.lazyLoad(exports, ["getDomains","getDomainsOutput"], () => require("./getDomains"));

export { UrlPurgeArgs, UrlPurgeState } from "./urlPurge";
export type UrlPurge = import("./urlPurge").UrlPurge;
export const UrlPurge: typeof import("./urlPurge").UrlPurge = null as any;
utilities.lazyLoad(exports, ["UrlPurge"], () => require("./urlPurge"));

export { UrlPushArgs, UrlPushState } from "./urlPush";
export type UrlPush = import("./urlPush").UrlPush;
export const UrlPush: typeof import("./urlPush").UrlPush = null as any;
utilities.lazyLoad(exports, ["UrlPush"], () => require("./urlPush"));


const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Cdn/domain:Domain":
                return new Domain(name, <any>undefined, { urn })
            case "tencentcloud:Cdn/urlPurge:UrlPurge":
                return new UrlPurge(name, <any>undefined, { urn })
            case "tencentcloud:Cdn/urlPush:UrlPush":
                return new UrlPush(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Cdn/domain", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cdn/urlPurge", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Cdn/urlPush", _module)
