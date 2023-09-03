// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dcx

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

var _ = internal.GetEnvOrDefault

type ExtraConfigBfdInfo struct {
	Interval         *int `pulumi:"interval"`
	ProbeFailedTimes *int `pulumi:"probeFailedTimes"`
}

// ExtraConfigBfdInfoInput is an input type that accepts ExtraConfigBfdInfoArgs and ExtraConfigBfdInfoOutput values.
// You can construct a concrete instance of `ExtraConfigBfdInfoInput` via:
//
//	ExtraConfigBfdInfoArgs{...}
type ExtraConfigBfdInfoInput interface {
	pulumi.Input

	ToExtraConfigBfdInfoOutput() ExtraConfigBfdInfoOutput
	ToExtraConfigBfdInfoOutputWithContext(context.Context) ExtraConfigBfdInfoOutput
}

type ExtraConfigBfdInfoArgs struct {
	Interval         pulumi.IntPtrInput `pulumi:"interval"`
	ProbeFailedTimes pulumi.IntPtrInput `pulumi:"probeFailedTimes"`
}

func (ExtraConfigBfdInfoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtraConfigBfdInfo)(nil)).Elem()
}

func (i ExtraConfigBfdInfoArgs) ToExtraConfigBfdInfoOutput() ExtraConfigBfdInfoOutput {
	return i.ToExtraConfigBfdInfoOutputWithContext(context.Background())
}

func (i ExtraConfigBfdInfoArgs) ToExtraConfigBfdInfoOutputWithContext(ctx context.Context) ExtraConfigBfdInfoOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigBfdInfoOutput)
}

func (i ExtraConfigBfdInfoArgs) ToExtraConfigBfdInfoPtrOutput() ExtraConfigBfdInfoPtrOutput {
	return i.ToExtraConfigBfdInfoPtrOutputWithContext(context.Background())
}

func (i ExtraConfigBfdInfoArgs) ToExtraConfigBfdInfoPtrOutputWithContext(ctx context.Context) ExtraConfigBfdInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigBfdInfoOutput).ToExtraConfigBfdInfoPtrOutputWithContext(ctx)
}

// ExtraConfigBfdInfoPtrInput is an input type that accepts ExtraConfigBfdInfoArgs, ExtraConfigBfdInfoPtr and ExtraConfigBfdInfoPtrOutput values.
// You can construct a concrete instance of `ExtraConfigBfdInfoPtrInput` via:
//
//	        ExtraConfigBfdInfoArgs{...}
//
//	or:
//
//	        nil
type ExtraConfigBfdInfoPtrInput interface {
	pulumi.Input

	ToExtraConfigBfdInfoPtrOutput() ExtraConfigBfdInfoPtrOutput
	ToExtraConfigBfdInfoPtrOutputWithContext(context.Context) ExtraConfigBfdInfoPtrOutput
}

type extraConfigBfdInfoPtrType ExtraConfigBfdInfoArgs

func ExtraConfigBfdInfoPtr(v *ExtraConfigBfdInfoArgs) ExtraConfigBfdInfoPtrInput {
	return (*extraConfigBfdInfoPtrType)(v)
}

func (*extraConfigBfdInfoPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ExtraConfigBfdInfo)(nil)).Elem()
}

func (i *extraConfigBfdInfoPtrType) ToExtraConfigBfdInfoPtrOutput() ExtraConfigBfdInfoPtrOutput {
	return i.ToExtraConfigBfdInfoPtrOutputWithContext(context.Background())
}

func (i *extraConfigBfdInfoPtrType) ToExtraConfigBfdInfoPtrOutputWithContext(ctx context.Context) ExtraConfigBfdInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigBfdInfoPtrOutput)
}

type ExtraConfigBfdInfoOutput struct{ *pulumi.OutputState }

func (ExtraConfigBfdInfoOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtraConfigBfdInfo)(nil)).Elem()
}

func (o ExtraConfigBfdInfoOutput) ToExtraConfigBfdInfoOutput() ExtraConfigBfdInfoOutput {
	return o
}

func (o ExtraConfigBfdInfoOutput) ToExtraConfigBfdInfoOutputWithContext(ctx context.Context) ExtraConfigBfdInfoOutput {
	return o
}

func (o ExtraConfigBfdInfoOutput) ToExtraConfigBfdInfoPtrOutput() ExtraConfigBfdInfoPtrOutput {
	return o.ToExtraConfigBfdInfoPtrOutputWithContext(context.Background())
}

func (o ExtraConfigBfdInfoOutput) ToExtraConfigBfdInfoPtrOutputWithContext(ctx context.Context) ExtraConfigBfdInfoPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ExtraConfigBfdInfo) *ExtraConfigBfdInfo {
		return &v
	}).(ExtraConfigBfdInfoPtrOutput)
}

func (o ExtraConfigBfdInfoOutput) Interval() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ExtraConfigBfdInfo) *int { return v.Interval }).(pulumi.IntPtrOutput)
}

func (o ExtraConfigBfdInfoOutput) ProbeFailedTimes() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ExtraConfigBfdInfo) *int { return v.ProbeFailedTimes }).(pulumi.IntPtrOutput)
}

type ExtraConfigBfdInfoPtrOutput struct{ *pulumi.OutputState }

func (ExtraConfigBfdInfoPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ExtraConfigBfdInfo)(nil)).Elem()
}

func (o ExtraConfigBfdInfoPtrOutput) ToExtraConfigBfdInfoPtrOutput() ExtraConfigBfdInfoPtrOutput {
	return o
}

func (o ExtraConfigBfdInfoPtrOutput) ToExtraConfigBfdInfoPtrOutputWithContext(ctx context.Context) ExtraConfigBfdInfoPtrOutput {
	return o
}

func (o ExtraConfigBfdInfoPtrOutput) Elem() ExtraConfigBfdInfoOutput {
	return o.ApplyT(func(v *ExtraConfigBfdInfo) ExtraConfigBfdInfo {
		if v != nil {
			return *v
		}
		var ret ExtraConfigBfdInfo
		return ret
	}).(ExtraConfigBfdInfoOutput)
}

func (o ExtraConfigBfdInfoPtrOutput) Interval() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ExtraConfigBfdInfo) *int {
		if v == nil {
			return nil
		}
		return v.Interval
	}).(pulumi.IntPtrOutput)
}

func (o ExtraConfigBfdInfoPtrOutput) ProbeFailedTimes() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ExtraConfigBfdInfo) *int {
		if v == nil {
			return nil
		}
		return v.ProbeFailedTimes
	}).(pulumi.IntPtrOutput)
}

type ExtraConfigBgpPeer struct {
	Asn     *int    `pulumi:"asn"`
	AuthKey *string `pulumi:"authKey"`
}

// ExtraConfigBgpPeerInput is an input type that accepts ExtraConfigBgpPeerArgs and ExtraConfigBgpPeerOutput values.
// You can construct a concrete instance of `ExtraConfigBgpPeerInput` via:
//
//	ExtraConfigBgpPeerArgs{...}
type ExtraConfigBgpPeerInput interface {
	pulumi.Input

	ToExtraConfigBgpPeerOutput() ExtraConfigBgpPeerOutput
	ToExtraConfigBgpPeerOutputWithContext(context.Context) ExtraConfigBgpPeerOutput
}

type ExtraConfigBgpPeerArgs struct {
	Asn     pulumi.IntPtrInput    `pulumi:"asn"`
	AuthKey pulumi.StringPtrInput `pulumi:"authKey"`
}

func (ExtraConfigBgpPeerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtraConfigBgpPeer)(nil)).Elem()
}

func (i ExtraConfigBgpPeerArgs) ToExtraConfigBgpPeerOutput() ExtraConfigBgpPeerOutput {
	return i.ToExtraConfigBgpPeerOutputWithContext(context.Background())
}

func (i ExtraConfigBgpPeerArgs) ToExtraConfigBgpPeerOutputWithContext(ctx context.Context) ExtraConfigBgpPeerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigBgpPeerOutput)
}

func (i ExtraConfigBgpPeerArgs) ToExtraConfigBgpPeerPtrOutput() ExtraConfigBgpPeerPtrOutput {
	return i.ToExtraConfigBgpPeerPtrOutputWithContext(context.Background())
}

func (i ExtraConfigBgpPeerArgs) ToExtraConfigBgpPeerPtrOutputWithContext(ctx context.Context) ExtraConfigBgpPeerPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigBgpPeerOutput).ToExtraConfigBgpPeerPtrOutputWithContext(ctx)
}

// ExtraConfigBgpPeerPtrInput is an input type that accepts ExtraConfigBgpPeerArgs, ExtraConfigBgpPeerPtr and ExtraConfigBgpPeerPtrOutput values.
// You can construct a concrete instance of `ExtraConfigBgpPeerPtrInput` via:
//
//	        ExtraConfigBgpPeerArgs{...}
//
//	or:
//
//	        nil
type ExtraConfigBgpPeerPtrInput interface {
	pulumi.Input

	ToExtraConfigBgpPeerPtrOutput() ExtraConfigBgpPeerPtrOutput
	ToExtraConfigBgpPeerPtrOutputWithContext(context.Context) ExtraConfigBgpPeerPtrOutput
}

type extraConfigBgpPeerPtrType ExtraConfigBgpPeerArgs

func ExtraConfigBgpPeerPtr(v *ExtraConfigBgpPeerArgs) ExtraConfigBgpPeerPtrInput {
	return (*extraConfigBgpPeerPtrType)(v)
}

func (*extraConfigBgpPeerPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ExtraConfigBgpPeer)(nil)).Elem()
}

func (i *extraConfigBgpPeerPtrType) ToExtraConfigBgpPeerPtrOutput() ExtraConfigBgpPeerPtrOutput {
	return i.ToExtraConfigBgpPeerPtrOutputWithContext(context.Background())
}

func (i *extraConfigBgpPeerPtrType) ToExtraConfigBgpPeerPtrOutputWithContext(ctx context.Context) ExtraConfigBgpPeerPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigBgpPeerPtrOutput)
}

type ExtraConfigBgpPeerOutput struct{ *pulumi.OutputState }

func (ExtraConfigBgpPeerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtraConfigBgpPeer)(nil)).Elem()
}

func (o ExtraConfigBgpPeerOutput) ToExtraConfigBgpPeerOutput() ExtraConfigBgpPeerOutput {
	return o
}

func (o ExtraConfigBgpPeerOutput) ToExtraConfigBgpPeerOutputWithContext(ctx context.Context) ExtraConfigBgpPeerOutput {
	return o
}

func (o ExtraConfigBgpPeerOutput) ToExtraConfigBgpPeerPtrOutput() ExtraConfigBgpPeerPtrOutput {
	return o.ToExtraConfigBgpPeerPtrOutputWithContext(context.Background())
}

func (o ExtraConfigBgpPeerOutput) ToExtraConfigBgpPeerPtrOutputWithContext(ctx context.Context) ExtraConfigBgpPeerPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ExtraConfigBgpPeer) *ExtraConfigBgpPeer {
		return &v
	}).(ExtraConfigBgpPeerPtrOutput)
}

func (o ExtraConfigBgpPeerOutput) Asn() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ExtraConfigBgpPeer) *int { return v.Asn }).(pulumi.IntPtrOutput)
}

func (o ExtraConfigBgpPeerOutput) AuthKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ExtraConfigBgpPeer) *string { return v.AuthKey }).(pulumi.StringPtrOutput)
}

type ExtraConfigBgpPeerPtrOutput struct{ *pulumi.OutputState }

func (ExtraConfigBgpPeerPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ExtraConfigBgpPeer)(nil)).Elem()
}

func (o ExtraConfigBgpPeerPtrOutput) ToExtraConfigBgpPeerPtrOutput() ExtraConfigBgpPeerPtrOutput {
	return o
}

func (o ExtraConfigBgpPeerPtrOutput) ToExtraConfigBgpPeerPtrOutputWithContext(ctx context.Context) ExtraConfigBgpPeerPtrOutput {
	return o
}

func (o ExtraConfigBgpPeerPtrOutput) Elem() ExtraConfigBgpPeerOutput {
	return o.ApplyT(func(v *ExtraConfigBgpPeer) ExtraConfigBgpPeer {
		if v != nil {
			return *v
		}
		var ret ExtraConfigBgpPeer
		return ret
	}).(ExtraConfigBgpPeerOutput)
}

func (o ExtraConfigBgpPeerPtrOutput) Asn() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ExtraConfigBgpPeer) *int {
		if v == nil {
			return nil
		}
		return v.Asn
	}).(pulumi.IntPtrOutput)
}

func (o ExtraConfigBgpPeerPtrOutput) AuthKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ExtraConfigBgpPeer) *string {
		if v == nil {
			return nil
		}
		return v.AuthKey
	}).(pulumi.StringPtrOutput)
}

type ExtraConfigNqaInfo struct {
	DestinationIp    *string `pulumi:"destinationIp"`
	Interval         *int    `pulumi:"interval"`
	ProbeFailedTimes *int    `pulumi:"probeFailedTimes"`
}

// ExtraConfigNqaInfoInput is an input type that accepts ExtraConfigNqaInfoArgs and ExtraConfigNqaInfoOutput values.
// You can construct a concrete instance of `ExtraConfigNqaInfoInput` via:
//
//	ExtraConfigNqaInfoArgs{...}
type ExtraConfigNqaInfoInput interface {
	pulumi.Input

	ToExtraConfigNqaInfoOutput() ExtraConfigNqaInfoOutput
	ToExtraConfigNqaInfoOutputWithContext(context.Context) ExtraConfigNqaInfoOutput
}

type ExtraConfigNqaInfoArgs struct {
	DestinationIp    pulumi.StringPtrInput `pulumi:"destinationIp"`
	Interval         pulumi.IntPtrInput    `pulumi:"interval"`
	ProbeFailedTimes pulumi.IntPtrInput    `pulumi:"probeFailedTimes"`
}

func (ExtraConfigNqaInfoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtraConfigNqaInfo)(nil)).Elem()
}

func (i ExtraConfigNqaInfoArgs) ToExtraConfigNqaInfoOutput() ExtraConfigNqaInfoOutput {
	return i.ToExtraConfigNqaInfoOutputWithContext(context.Background())
}

func (i ExtraConfigNqaInfoArgs) ToExtraConfigNqaInfoOutputWithContext(ctx context.Context) ExtraConfigNqaInfoOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigNqaInfoOutput)
}

func (i ExtraConfigNqaInfoArgs) ToExtraConfigNqaInfoPtrOutput() ExtraConfigNqaInfoPtrOutput {
	return i.ToExtraConfigNqaInfoPtrOutputWithContext(context.Background())
}

func (i ExtraConfigNqaInfoArgs) ToExtraConfigNqaInfoPtrOutputWithContext(ctx context.Context) ExtraConfigNqaInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigNqaInfoOutput).ToExtraConfigNqaInfoPtrOutputWithContext(ctx)
}

// ExtraConfigNqaInfoPtrInput is an input type that accepts ExtraConfigNqaInfoArgs, ExtraConfigNqaInfoPtr and ExtraConfigNqaInfoPtrOutput values.
// You can construct a concrete instance of `ExtraConfigNqaInfoPtrInput` via:
//
//	        ExtraConfigNqaInfoArgs{...}
//
//	or:
//
//	        nil
type ExtraConfigNqaInfoPtrInput interface {
	pulumi.Input

	ToExtraConfigNqaInfoPtrOutput() ExtraConfigNqaInfoPtrOutput
	ToExtraConfigNqaInfoPtrOutputWithContext(context.Context) ExtraConfigNqaInfoPtrOutput
}

type extraConfigNqaInfoPtrType ExtraConfigNqaInfoArgs

func ExtraConfigNqaInfoPtr(v *ExtraConfigNqaInfoArgs) ExtraConfigNqaInfoPtrInput {
	return (*extraConfigNqaInfoPtrType)(v)
}

func (*extraConfigNqaInfoPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ExtraConfigNqaInfo)(nil)).Elem()
}

func (i *extraConfigNqaInfoPtrType) ToExtraConfigNqaInfoPtrOutput() ExtraConfigNqaInfoPtrOutput {
	return i.ToExtraConfigNqaInfoPtrOutputWithContext(context.Background())
}

func (i *extraConfigNqaInfoPtrType) ToExtraConfigNqaInfoPtrOutputWithContext(ctx context.Context) ExtraConfigNqaInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigNqaInfoPtrOutput)
}

type ExtraConfigNqaInfoOutput struct{ *pulumi.OutputState }

func (ExtraConfigNqaInfoOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtraConfigNqaInfo)(nil)).Elem()
}

func (o ExtraConfigNqaInfoOutput) ToExtraConfigNqaInfoOutput() ExtraConfigNqaInfoOutput {
	return o
}

func (o ExtraConfigNqaInfoOutput) ToExtraConfigNqaInfoOutputWithContext(ctx context.Context) ExtraConfigNqaInfoOutput {
	return o
}

func (o ExtraConfigNqaInfoOutput) ToExtraConfigNqaInfoPtrOutput() ExtraConfigNqaInfoPtrOutput {
	return o.ToExtraConfigNqaInfoPtrOutputWithContext(context.Background())
}

func (o ExtraConfigNqaInfoOutput) ToExtraConfigNqaInfoPtrOutputWithContext(ctx context.Context) ExtraConfigNqaInfoPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ExtraConfigNqaInfo) *ExtraConfigNqaInfo {
		return &v
	}).(ExtraConfigNqaInfoPtrOutput)
}

func (o ExtraConfigNqaInfoOutput) DestinationIp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ExtraConfigNqaInfo) *string { return v.DestinationIp }).(pulumi.StringPtrOutput)
}

func (o ExtraConfigNqaInfoOutput) Interval() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ExtraConfigNqaInfo) *int { return v.Interval }).(pulumi.IntPtrOutput)
}

func (o ExtraConfigNqaInfoOutput) ProbeFailedTimes() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ExtraConfigNqaInfo) *int { return v.ProbeFailedTimes }).(pulumi.IntPtrOutput)
}

type ExtraConfigNqaInfoPtrOutput struct{ *pulumi.OutputState }

func (ExtraConfigNqaInfoPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ExtraConfigNqaInfo)(nil)).Elem()
}

func (o ExtraConfigNqaInfoPtrOutput) ToExtraConfigNqaInfoPtrOutput() ExtraConfigNqaInfoPtrOutput {
	return o
}

func (o ExtraConfigNqaInfoPtrOutput) ToExtraConfigNqaInfoPtrOutputWithContext(ctx context.Context) ExtraConfigNqaInfoPtrOutput {
	return o
}

func (o ExtraConfigNqaInfoPtrOutput) Elem() ExtraConfigNqaInfoOutput {
	return o.ApplyT(func(v *ExtraConfigNqaInfo) ExtraConfigNqaInfo {
		if v != nil {
			return *v
		}
		var ret ExtraConfigNqaInfo
		return ret
	}).(ExtraConfigNqaInfoOutput)
}

func (o ExtraConfigNqaInfoPtrOutput) DestinationIp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ExtraConfigNqaInfo) *string {
		if v == nil {
			return nil
		}
		return v.DestinationIp
	}).(pulumi.StringPtrOutput)
}

func (o ExtraConfigNqaInfoPtrOutput) Interval() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ExtraConfigNqaInfo) *int {
		if v == nil {
			return nil
		}
		return v.Interval
	}).(pulumi.IntPtrOutput)
}

func (o ExtraConfigNqaInfoPtrOutput) ProbeFailedTimes() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ExtraConfigNqaInfo) *int {
		if v == nil {
			return nil
		}
		return v.ProbeFailedTimes
	}).(pulumi.IntPtrOutput)
}

type ExtraConfigRouteFilterPrefixes struct {
	Cidr *string `pulumi:"cidr"`
}

// ExtraConfigRouteFilterPrefixesInput is an input type that accepts ExtraConfigRouteFilterPrefixesArgs and ExtraConfigRouteFilterPrefixesOutput values.
// You can construct a concrete instance of `ExtraConfigRouteFilterPrefixesInput` via:
//
//	ExtraConfigRouteFilterPrefixesArgs{...}
type ExtraConfigRouteFilterPrefixesInput interface {
	pulumi.Input

	ToExtraConfigRouteFilterPrefixesOutput() ExtraConfigRouteFilterPrefixesOutput
	ToExtraConfigRouteFilterPrefixesOutputWithContext(context.Context) ExtraConfigRouteFilterPrefixesOutput
}

type ExtraConfigRouteFilterPrefixesArgs struct {
	Cidr pulumi.StringPtrInput `pulumi:"cidr"`
}

func (ExtraConfigRouteFilterPrefixesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtraConfigRouteFilterPrefixes)(nil)).Elem()
}

func (i ExtraConfigRouteFilterPrefixesArgs) ToExtraConfigRouteFilterPrefixesOutput() ExtraConfigRouteFilterPrefixesOutput {
	return i.ToExtraConfigRouteFilterPrefixesOutputWithContext(context.Background())
}

func (i ExtraConfigRouteFilterPrefixesArgs) ToExtraConfigRouteFilterPrefixesOutputWithContext(ctx context.Context) ExtraConfigRouteFilterPrefixesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigRouteFilterPrefixesOutput)
}

func (i ExtraConfigRouteFilterPrefixesArgs) ToExtraConfigRouteFilterPrefixesPtrOutput() ExtraConfigRouteFilterPrefixesPtrOutput {
	return i.ToExtraConfigRouteFilterPrefixesPtrOutputWithContext(context.Background())
}

func (i ExtraConfigRouteFilterPrefixesArgs) ToExtraConfigRouteFilterPrefixesPtrOutputWithContext(ctx context.Context) ExtraConfigRouteFilterPrefixesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigRouteFilterPrefixesOutput).ToExtraConfigRouteFilterPrefixesPtrOutputWithContext(ctx)
}

// ExtraConfigRouteFilterPrefixesPtrInput is an input type that accepts ExtraConfigRouteFilterPrefixesArgs, ExtraConfigRouteFilterPrefixesPtr and ExtraConfigRouteFilterPrefixesPtrOutput values.
// You can construct a concrete instance of `ExtraConfigRouteFilterPrefixesPtrInput` via:
//
//	        ExtraConfigRouteFilterPrefixesArgs{...}
//
//	or:
//
//	        nil
type ExtraConfigRouteFilterPrefixesPtrInput interface {
	pulumi.Input

	ToExtraConfigRouteFilterPrefixesPtrOutput() ExtraConfigRouteFilterPrefixesPtrOutput
	ToExtraConfigRouteFilterPrefixesPtrOutputWithContext(context.Context) ExtraConfigRouteFilterPrefixesPtrOutput
}

type extraConfigRouteFilterPrefixesPtrType ExtraConfigRouteFilterPrefixesArgs

func ExtraConfigRouteFilterPrefixesPtr(v *ExtraConfigRouteFilterPrefixesArgs) ExtraConfigRouteFilterPrefixesPtrInput {
	return (*extraConfigRouteFilterPrefixesPtrType)(v)
}

func (*extraConfigRouteFilterPrefixesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ExtraConfigRouteFilterPrefixes)(nil)).Elem()
}

func (i *extraConfigRouteFilterPrefixesPtrType) ToExtraConfigRouteFilterPrefixesPtrOutput() ExtraConfigRouteFilterPrefixesPtrOutput {
	return i.ToExtraConfigRouteFilterPrefixesPtrOutputWithContext(context.Background())
}

func (i *extraConfigRouteFilterPrefixesPtrType) ToExtraConfigRouteFilterPrefixesPtrOutputWithContext(ctx context.Context) ExtraConfigRouteFilterPrefixesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtraConfigRouteFilterPrefixesPtrOutput)
}

type ExtraConfigRouteFilterPrefixesOutput struct{ *pulumi.OutputState }

func (ExtraConfigRouteFilterPrefixesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtraConfigRouteFilterPrefixes)(nil)).Elem()
}

func (o ExtraConfigRouteFilterPrefixesOutput) ToExtraConfigRouteFilterPrefixesOutput() ExtraConfigRouteFilterPrefixesOutput {
	return o
}

func (o ExtraConfigRouteFilterPrefixesOutput) ToExtraConfigRouteFilterPrefixesOutputWithContext(ctx context.Context) ExtraConfigRouteFilterPrefixesOutput {
	return o
}

func (o ExtraConfigRouteFilterPrefixesOutput) ToExtraConfigRouteFilterPrefixesPtrOutput() ExtraConfigRouteFilterPrefixesPtrOutput {
	return o.ToExtraConfigRouteFilterPrefixesPtrOutputWithContext(context.Background())
}

func (o ExtraConfigRouteFilterPrefixesOutput) ToExtraConfigRouteFilterPrefixesPtrOutputWithContext(ctx context.Context) ExtraConfigRouteFilterPrefixesPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ExtraConfigRouteFilterPrefixes) *ExtraConfigRouteFilterPrefixes {
		return &v
	}).(ExtraConfigRouteFilterPrefixesPtrOutput)
}

func (o ExtraConfigRouteFilterPrefixesOutput) Cidr() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ExtraConfigRouteFilterPrefixes) *string { return v.Cidr }).(pulumi.StringPtrOutput)
}

type ExtraConfigRouteFilterPrefixesPtrOutput struct{ *pulumi.OutputState }

func (ExtraConfigRouteFilterPrefixesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ExtraConfigRouteFilterPrefixes)(nil)).Elem()
}

func (o ExtraConfigRouteFilterPrefixesPtrOutput) ToExtraConfigRouteFilterPrefixesPtrOutput() ExtraConfigRouteFilterPrefixesPtrOutput {
	return o
}

func (o ExtraConfigRouteFilterPrefixesPtrOutput) ToExtraConfigRouteFilterPrefixesPtrOutputWithContext(ctx context.Context) ExtraConfigRouteFilterPrefixesPtrOutput {
	return o
}

func (o ExtraConfigRouteFilterPrefixesPtrOutput) Elem() ExtraConfigRouteFilterPrefixesOutput {
	return o.ApplyT(func(v *ExtraConfigRouteFilterPrefixes) ExtraConfigRouteFilterPrefixes {
		if v != nil {
			return *v
		}
		var ret ExtraConfigRouteFilterPrefixes
		return ret
	}).(ExtraConfigRouteFilterPrefixesOutput)
}

func (o ExtraConfigRouteFilterPrefixesPtrOutput) Cidr() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ExtraConfigRouteFilterPrefixes) *string {
		if v == nil {
			return nil
		}
		return v.Cidr
	}).(pulumi.StringPtrOutput)
}

type GetInstancesInstanceList struct {
	Bandwidth           int      `pulumi:"bandwidth"`
	BgpAsn              int      `pulumi:"bgpAsn"`
	BgpAuthKey          string   `pulumi:"bgpAuthKey"`
	CreateTime          string   `pulumi:"createTime"`
	CustomerAddress     string   `pulumi:"customerAddress"`
	DcId                string   `pulumi:"dcId"`
	DcgId               string   `pulumi:"dcgId"`
	DcxId               string   `pulumi:"dcxId"`
	Name                string   `pulumi:"name"`
	NetworkRegion       string   `pulumi:"networkRegion"`
	NetworkType         string   `pulumi:"networkType"`
	RouteFilterPrefixes []string `pulumi:"routeFilterPrefixes"`
	RouteType           string   `pulumi:"routeType"`
	State               string   `pulumi:"state"`
	TencentAddress      string   `pulumi:"tencentAddress"`
	Vlan                int      `pulumi:"vlan"`
	VpcId               string   `pulumi:"vpcId"`
}

// GetInstancesInstanceListInput is an input type that accepts GetInstancesInstanceListArgs and GetInstancesInstanceListOutput values.
// You can construct a concrete instance of `GetInstancesInstanceListInput` via:
//
//	GetInstancesInstanceListArgs{...}
type GetInstancesInstanceListInput interface {
	pulumi.Input

	ToGetInstancesInstanceListOutput() GetInstancesInstanceListOutput
	ToGetInstancesInstanceListOutputWithContext(context.Context) GetInstancesInstanceListOutput
}

type GetInstancesInstanceListArgs struct {
	Bandwidth           pulumi.IntInput         `pulumi:"bandwidth"`
	BgpAsn              pulumi.IntInput         `pulumi:"bgpAsn"`
	BgpAuthKey          pulumi.StringInput      `pulumi:"bgpAuthKey"`
	CreateTime          pulumi.StringInput      `pulumi:"createTime"`
	CustomerAddress     pulumi.StringInput      `pulumi:"customerAddress"`
	DcId                pulumi.StringInput      `pulumi:"dcId"`
	DcgId               pulumi.StringInput      `pulumi:"dcgId"`
	DcxId               pulumi.StringInput      `pulumi:"dcxId"`
	Name                pulumi.StringInput      `pulumi:"name"`
	NetworkRegion       pulumi.StringInput      `pulumi:"networkRegion"`
	NetworkType         pulumi.StringInput      `pulumi:"networkType"`
	RouteFilterPrefixes pulumi.StringArrayInput `pulumi:"routeFilterPrefixes"`
	RouteType           pulumi.StringInput      `pulumi:"routeType"`
	State               pulumi.StringInput      `pulumi:"state"`
	TencentAddress      pulumi.StringInput      `pulumi:"tencentAddress"`
	Vlan                pulumi.IntInput         `pulumi:"vlan"`
	VpcId               pulumi.StringInput      `pulumi:"vpcId"`
}

func (GetInstancesInstanceListArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstancesInstanceList)(nil)).Elem()
}

func (i GetInstancesInstanceListArgs) ToGetInstancesInstanceListOutput() GetInstancesInstanceListOutput {
	return i.ToGetInstancesInstanceListOutputWithContext(context.Background())
}

func (i GetInstancesInstanceListArgs) ToGetInstancesInstanceListOutputWithContext(ctx context.Context) GetInstancesInstanceListOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstancesInstanceListOutput)
}

// GetInstancesInstanceListArrayInput is an input type that accepts GetInstancesInstanceListArray and GetInstancesInstanceListArrayOutput values.
// You can construct a concrete instance of `GetInstancesInstanceListArrayInput` via:
//
//	GetInstancesInstanceListArray{ GetInstancesInstanceListArgs{...} }
type GetInstancesInstanceListArrayInput interface {
	pulumi.Input

	ToGetInstancesInstanceListArrayOutput() GetInstancesInstanceListArrayOutput
	ToGetInstancesInstanceListArrayOutputWithContext(context.Context) GetInstancesInstanceListArrayOutput
}

type GetInstancesInstanceListArray []GetInstancesInstanceListInput

func (GetInstancesInstanceListArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstancesInstanceList)(nil)).Elem()
}

func (i GetInstancesInstanceListArray) ToGetInstancesInstanceListArrayOutput() GetInstancesInstanceListArrayOutput {
	return i.ToGetInstancesInstanceListArrayOutputWithContext(context.Background())
}

func (i GetInstancesInstanceListArray) ToGetInstancesInstanceListArrayOutputWithContext(ctx context.Context) GetInstancesInstanceListArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstancesInstanceListArrayOutput)
}

type GetInstancesInstanceListOutput struct{ *pulumi.OutputState }

func (GetInstancesInstanceListOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstancesInstanceList)(nil)).Elem()
}

func (o GetInstancesInstanceListOutput) ToGetInstancesInstanceListOutput() GetInstancesInstanceListOutput {
	return o
}

func (o GetInstancesInstanceListOutput) ToGetInstancesInstanceListOutputWithContext(ctx context.Context) GetInstancesInstanceListOutput {
	return o
}

func (o GetInstancesInstanceListOutput) Bandwidth() pulumi.IntOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) int { return v.Bandwidth }).(pulumi.IntOutput)
}

func (o GetInstancesInstanceListOutput) BgpAsn() pulumi.IntOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) int { return v.BgpAsn }).(pulumi.IntOutput)
}

func (o GetInstancesInstanceListOutput) BgpAuthKey() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.BgpAuthKey }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.CreateTime }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) CustomerAddress() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.CustomerAddress }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) DcId() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.DcId }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) DcgId() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.DcgId }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) DcxId() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.DcxId }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.Name }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) NetworkRegion() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.NetworkRegion }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) NetworkType() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.NetworkType }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) RouteFilterPrefixes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) []string { return v.RouteFilterPrefixes }).(pulumi.StringArrayOutput)
}

func (o GetInstancesInstanceListOutput) RouteType() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.RouteType }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.State }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) TencentAddress() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.TencentAddress }).(pulumi.StringOutput)
}

func (o GetInstancesInstanceListOutput) Vlan() pulumi.IntOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) int { return v.Vlan }).(pulumi.IntOutput)
}

func (o GetInstancesInstanceListOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstancesInstanceList) string { return v.VpcId }).(pulumi.StringOutput)
}

type GetInstancesInstanceListArrayOutput struct{ *pulumi.OutputState }

func (GetInstancesInstanceListArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstancesInstanceList)(nil)).Elem()
}

func (o GetInstancesInstanceListArrayOutput) ToGetInstancesInstanceListArrayOutput() GetInstancesInstanceListArrayOutput {
	return o
}

func (o GetInstancesInstanceListArrayOutput) ToGetInstancesInstanceListArrayOutputWithContext(ctx context.Context) GetInstancesInstanceListArrayOutput {
	return o
}

func (o GetInstancesInstanceListArrayOutput) Index(i pulumi.IntInput) GetInstancesInstanceListOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetInstancesInstanceList {
		return vs[0].([]GetInstancesInstanceList)[vs[1].(int)]
	}).(GetInstancesInstanceListOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ExtraConfigBfdInfoInput)(nil)).Elem(), ExtraConfigBfdInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ExtraConfigBfdInfoPtrInput)(nil)).Elem(), ExtraConfigBfdInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ExtraConfigBgpPeerInput)(nil)).Elem(), ExtraConfigBgpPeerArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ExtraConfigBgpPeerPtrInput)(nil)).Elem(), ExtraConfigBgpPeerArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ExtraConfigNqaInfoInput)(nil)).Elem(), ExtraConfigNqaInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ExtraConfigNqaInfoPtrInput)(nil)).Elem(), ExtraConfigNqaInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ExtraConfigRouteFilterPrefixesInput)(nil)).Elem(), ExtraConfigRouteFilterPrefixesArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ExtraConfigRouteFilterPrefixesPtrInput)(nil)).Elem(), ExtraConfigRouteFilterPrefixesArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetInstancesInstanceListInput)(nil)).Elem(), GetInstancesInstanceListArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetInstancesInstanceListArrayInput)(nil)).Elem(), GetInstancesInstanceListArray{})
	pulumi.RegisterOutputType(ExtraConfigBfdInfoOutput{})
	pulumi.RegisterOutputType(ExtraConfigBfdInfoPtrOutput{})
	pulumi.RegisterOutputType(ExtraConfigBgpPeerOutput{})
	pulumi.RegisterOutputType(ExtraConfigBgpPeerPtrOutput{})
	pulumi.RegisterOutputType(ExtraConfigNqaInfoOutput{})
	pulumi.RegisterOutputType(ExtraConfigNqaInfoPtrOutput{})
	pulumi.RegisterOutputType(ExtraConfigRouteFilterPrefixesOutput{})
	pulumi.RegisterOutputType(ExtraConfigRouteFilterPrefixesPtrOutput{})
	pulumi.RegisterOutputType(GetInstancesInstanceListOutput{})
	pulumi.RegisterOutputType(GetInstancesInstanceListArrayOutput{})
}