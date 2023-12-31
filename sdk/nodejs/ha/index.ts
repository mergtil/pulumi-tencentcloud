// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export { GetVipEipAttachmentsArgs, GetVipEipAttachmentsResult, GetVipEipAttachmentsOutputArgs } from "./getVipEipAttachments";
export const getVipEipAttachments: typeof import("./getVipEipAttachments").getVipEipAttachments = null as any;
export const getVipEipAttachmentsOutput: typeof import("./getVipEipAttachments").getVipEipAttachmentsOutput = null as any;
utilities.lazyLoad(exports, ["getVipEipAttachments","getVipEipAttachmentsOutput"], () => require("./getVipEipAttachments"));

export { GetVipsArgs, GetVipsResult, GetVipsOutputArgs } from "./getVips";
export const getVips: typeof import("./getVips").getVips = null as any;
export const getVipsOutput: typeof import("./getVips").getVipsOutput = null as any;
utilities.lazyLoad(exports, ["getVips","getVipsOutput"], () => require("./getVips"));

export { VipArgs, VipState } from "./vip";
export type Vip = import("./vip").Vip;
export const Vip: typeof import("./vip").Vip = null as any;
utilities.lazyLoad(exports, ["Vip"], () => require("./vip"));

export { VipEipAttachmentArgs, VipEipAttachmentState } from "./vipEipAttachment";
export type VipEipAttachment = import("./vipEipAttachment").VipEipAttachment;
export const VipEipAttachment: typeof import("./vipEipAttachment").VipEipAttachment = null as any;
utilities.lazyLoad(exports, ["VipEipAttachment"], () => require("./vipEipAttachment"));


const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "tencentcloud:Ha/vip:Vip":
                return new Vip(name, <any>undefined, { urn })
            case "tencentcloud:Ha/vipEipAttachment:VipEipAttachment":
                return new VipEipAttachment(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("tencentcloud", "Ha/vip", _module)
pulumi.runtime.registerResourceModule("tencentcloud", "Ha/vipEipAttachment", _module)
