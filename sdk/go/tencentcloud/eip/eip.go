// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package eip

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type Eip struct {
	pulumi.CustomResourceState

	// ID of anti DDos package, it must set when `type` is `AntiDDoSEIP`.
	AntiDdosPackageId pulumi.StringOutput `pulumi:"antiDdosPackageId"`
	// The zone of anycast. Valid value: `ANYCAST_ZONE_GLOBAL` and `ANYCAST_ZONE_OVERSEAS`.
	AnycastZone pulumi.StringPtrOutput `pulumi:"anycastZone"`
	// Indicates whether the anycast eip can be associated to a CLB.
	//
	// Deprecated: It has been deprecated from version 1.27.0.
	ApplicableForClb pulumi.BoolPtrOutput `pulumi:"applicableForClb"`
	// Auto renew flag. 0 - default state (manual renew); 1 - automatic renew; 2 - explicit no automatic renew. NOTES: Only
	// supported prepaid EIP.
	AutoRenewFlag pulumi.IntPtrOutput `pulumi:"autoRenewFlag"`
	// ID of bandwidth package, it will set when `internet_charge_type` is `BANDWIDTH_PACKAGE`.
	BandwidthPackageId pulumi.StringOutput `pulumi:"bandwidthPackageId"`
	// The charge type of eip. Valid values: `BANDWIDTH_PACKAGE`, `BANDWIDTH_POSTPAID_BY_HOUR`, `BANDWIDTH_PREPAID_BY_MONTH`
	// and `TRAFFIC_POSTPAID_BY_HOUR`.
	InternetChargeType pulumi.StringOutput `pulumi:"internetChargeType"`
	// The bandwidth limit of EIP, unit is Mbps.
	InternetMaxBandwidthOut pulumi.IntOutput `pulumi:"internetMaxBandwidthOut"`
	// Internet service provider of eip. Valid value: `BGP`, `CMCC`, `CTCC` and `CUCC`.
	InternetServiceProvider pulumi.StringPtrOutput `pulumi:"internetServiceProvider"`
	// The name of eip.
	Name pulumi.StringOutput `pulumi:"name"`
	// Period of instance. Default value: `1`. Valid value: `1`, `2`, `3`, `4`, `6`, `7`, `8`, `9`, `12`, `24`, `36`. NOTES:
	// must set when `internet_charge_type` is `BANDWIDTH_PREPAID_BY_MONTH`.
	PrepaidPeriod pulumi.IntPtrOutput `pulumi:"prepaidPeriod"`
	// The elastic IP address.
	PublicIp pulumi.StringOutput `pulumi:"publicIp"`
	// The EIP current status.
	Status pulumi.StringOutput `pulumi:"status"`
	// The tags of eip.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// The type of eip. Valid value: `EIP` and `AnycastEIP` and `HighQualityEIP` and `AntiDDoSEIP`. Default is `EIP`.
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewEip registers a new resource with the given unique name, arguments, and options.
func NewEip(ctx *pulumi.Context,
	name string, args *EipArgs, opts ...pulumi.ResourceOption) (*Eip, error) {
	if args == nil {
		args = &EipArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Eip
	err := ctx.RegisterResource("tencentcloud:Eip/eip:Eip", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEip gets an existing Eip resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEip(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EipState, opts ...pulumi.ResourceOption) (*Eip, error) {
	var resource Eip
	err := ctx.ReadResource("tencentcloud:Eip/eip:Eip", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Eip resources.
type eipState struct {
	// ID of anti DDos package, it must set when `type` is `AntiDDoSEIP`.
	AntiDdosPackageId *string `pulumi:"antiDdosPackageId"`
	// The zone of anycast. Valid value: `ANYCAST_ZONE_GLOBAL` and `ANYCAST_ZONE_OVERSEAS`.
	AnycastZone *string `pulumi:"anycastZone"`
	// Indicates whether the anycast eip can be associated to a CLB.
	//
	// Deprecated: It has been deprecated from version 1.27.0.
	ApplicableForClb *bool `pulumi:"applicableForClb"`
	// Auto renew flag. 0 - default state (manual renew); 1 - automatic renew; 2 - explicit no automatic renew. NOTES: Only
	// supported prepaid EIP.
	AutoRenewFlag *int `pulumi:"autoRenewFlag"`
	// ID of bandwidth package, it will set when `internet_charge_type` is `BANDWIDTH_PACKAGE`.
	BandwidthPackageId *string `pulumi:"bandwidthPackageId"`
	// The charge type of eip. Valid values: `BANDWIDTH_PACKAGE`, `BANDWIDTH_POSTPAID_BY_HOUR`, `BANDWIDTH_PREPAID_BY_MONTH`
	// and `TRAFFIC_POSTPAID_BY_HOUR`.
	InternetChargeType *string `pulumi:"internetChargeType"`
	// The bandwidth limit of EIP, unit is Mbps.
	InternetMaxBandwidthOut *int `pulumi:"internetMaxBandwidthOut"`
	// Internet service provider of eip. Valid value: `BGP`, `CMCC`, `CTCC` and `CUCC`.
	InternetServiceProvider *string `pulumi:"internetServiceProvider"`
	// The name of eip.
	Name *string `pulumi:"name"`
	// Period of instance. Default value: `1`. Valid value: `1`, `2`, `3`, `4`, `6`, `7`, `8`, `9`, `12`, `24`, `36`. NOTES:
	// must set when `internet_charge_type` is `BANDWIDTH_PREPAID_BY_MONTH`.
	PrepaidPeriod *int `pulumi:"prepaidPeriod"`
	// The elastic IP address.
	PublicIp *string `pulumi:"publicIp"`
	// The EIP current status.
	Status *string `pulumi:"status"`
	// The tags of eip.
	Tags map[string]interface{} `pulumi:"tags"`
	// The type of eip. Valid value: `EIP` and `AnycastEIP` and `HighQualityEIP` and `AntiDDoSEIP`. Default is `EIP`.
	Type *string `pulumi:"type"`
}

type EipState struct {
	// ID of anti DDos package, it must set when `type` is `AntiDDoSEIP`.
	AntiDdosPackageId pulumi.StringPtrInput
	// The zone of anycast. Valid value: `ANYCAST_ZONE_GLOBAL` and `ANYCAST_ZONE_OVERSEAS`.
	AnycastZone pulumi.StringPtrInput
	// Indicates whether the anycast eip can be associated to a CLB.
	//
	// Deprecated: It has been deprecated from version 1.27.0.
	ApplicableForClb pulumi.BoolPtrInput
	// Auto renew flag. 0 - default state (manual renew); 1 - automatic renew; 2 - explicit no automatic renew. NOTES: Only
	// supported prepaid EIP.
	AutoRenewFlag pulumi.IntPtrInput
	// ID of bandwidth package, it will set when `internet_charge_type` is `BANDWIDTH_PACKAGE`.
	BandwidthPackageId pulumi.StringPtrInput
	// The charge type of eip. Valid values: `BANDWIDTH_PACKAGE`, `BANDWIDTH_POSTPAID_BY_HOUR`, `BANDWIDTH_PREPAID_BY_MONTH`
	// and `TRAFFIC_POSTPAID_BY_HOUR`.
	InternetChargeType pulumi.StringPtrInput
	// The bandwidth limit of EIP, unit is Mbps.
	InternetMaxBandwidthOut pulumi.IntPtrInput
	// Internet service provider of eip. Valid value: `BGP`, `CMCC`, `CTCC` and `CUCC`.
	InternetServiceProvider pulumi.StringPtrInput
	// The name of eip.
	Name pulumi.StringPtrInput
	// Period of instance. Default value: `1`. Valid value: `1`, `2`, `3`, `4`, `6`, `7`, `8`, `9`, `12`, `24`, `36`. NOTES:
	// must set when `internet_charge_type` is `BANDWIDTH_PREPAID_BY_MONTH`.
	PrepaidPeriod pulumi.IntPtrInput
	// The elastic IP address.
	PublicIp pulumi.StringPtrInput
	// The EIP current status.
	Status pulumi.StringPtrInput
	// The tags of eip.
	Tags pulumi.MapInput
	// The type of eip. Valid value: `EIP` and `AnycastEIP` and `HighQualityEIP` and `AntiDDoSEIP`. Default is `EIP`.
	Type pulumi.StringPtrInput
}

func (EipState) ElementType() reflect.Type {
	return reflect.TypeOf((*eipState)(nil)).Elem()
}

type eipArgs struct {
	// ID of anti DDos package, it must set when `type` is `AntiDDoSEIP`.
	AntiDdosPackageId *string `pulumi:"antiDdosPackageId"`
	// The zone of anycast. Valid value: `ANYCAST_ZONE_GLOBAL` and `ANYCAST_ZONE_OVERSEAS`.
	AnycastZone *string `pulumi:"anycastZone"`
	// Indicates whether the anycast eip can be associated to a CLB.
	//
	// Deprecated: It has been deprecated from version 1.27.0.
	ApplicableForClb *bool `pulumi:"applicableForClb"`
	// Auto renew flag. 0 - default state (manual renew); 1 - automatic renew; 2 - explicit no automatic renew. NOTES: Only
	// supported prepaid EIP.
	AutoRenewFlag *int `pulumi:"autoRenewFlag"`
	// ID of bandwidth package, it will set when `internet_charge_type` is `BANDWIDTH_PACKAGE`.
	BandwidthPackageId *string `pulumi:"bandwidthPackageId"`
	// The charge type of eip. Valid values: `BANDWIDTH_PACKAGE`, `BANDWIDTH_POSTPAID_BY_HOUR`, `BANDWIDTH_PREPAID_BY_MONTH`
	// and `TRAFFIC_POSTPAID_BY_HOUR`.
	InternetChargeType *string `pulumi:"internetChargeType"`
	// The bandwidth limit of EIP, unit is Mbps.
	InternetMaxBandwidthOut *int `pulumi:"internetMaxBandwidthOut"`
	// Internet service provider of eip. Valid value: `BGP`, `CMCC`, `CTCC` and `CUCC`.
	InternetServiceProvider *string `pulumi:"internetServiceProvider"`
	// The name of eip.
	Name *string `pulumi:"name"`
	// Period of instance. Default value: `1`. Valid value: `1`, `2`, `3`, `4`, `6`, `7`, `8`, `9`, `12`, `24`, `36`. NOTES:
	// must set when `internet_charge_type` is `BANDWIDTH_PREPAID_BY_MONTH`.
	PrepaidPeriod *int `pulumi:"prepaidPeriod"`
	// The tags of eip.
	Tags map[string]interface{} `pulumi:"tags"`
	// The type of eip. Valid value: `EIP` and `AnycastEIP` and `HighQualityEIP` and `AntiDDoSEIP`. Default is `EIP`.
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a Eip resource.
type EipArgs struct {
	// ID of anti DDos package, it must set when `type` is `AntiDDoSEIP`.
	AntiDdosPackageId pulumi.StringPtrInput
	// The zone of anycast. Valid value: `ANYCAST_ZONE_GLOBAL` and `ANYCAST_ZONE_OVERSEAS`.
	AnycastZone pulumi.StringPtrInput
	// Indicates whether the anycast eip can be associated to a CLB.
	//
	// Deprecated: It has been deprecated from version 1.27.0.
	ApplicableForClb pulumi.BoolPtrInput
	// Auto renew flag. 0 - default state (manual renew); 1 - automatic renew; 2 - explicit no automatic renew. NOTES: Only
	// supported prepaid EIP.
	AutoRenewFlag pulumi.IntPtrInput
	// ID of bandwidth package, it will set when `internet_charge_type` is `BANDWIDTH_PACKAGE`.
	BandwidthPackageId pulumi.StringPtrInput
	// The charge type of eip. Valid values: `BANDWIDTH_PACKAGE`, `BANDWIDTH_POSTPAID_BY_HOUR`, `BANDWIDTH_PREPAID_BY_MONTH`
	// and `TRAFFIC_POSTPAID_BY_HOUR`.
	InternetChargeType pulumi.StringPtrInput
	// The bandwidth limit of EIP, unit is Mbps.
	InternetMaxBandwidthOut pulumi.IntPtrInput
	// Internet service provider of eip. Valid value: `BGP`, `CMCC`, `CTCC` and `CUCC`.
	InternetServiceProvider pulumi.StringPtrInput
	// The name of eip.
	Name pulumi.StringPtrInput
	// Period of instance. Default value: `1`. Valid value: `1`, `2`, `3`, `4`, `6`, `7`, `8`, `9`, `12`, `24`, `36`. NOTES:
	// must set when `internet_charge_type` is `BANDWIDTH_PREPAID_BY_MONTH`.
	PrepaidPeriod pulumi.IntPtrInput
	// The tags of eip.
	Tags pulumi.MapInput
	// The type of eip. Valid value: `EIP` and `AnycastEIP` and `HighQualityEIP` and `AntiDDoSEIP`. Default is `EIP`.
	Type pulumi.StringPtrInput
}

func (EipArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*eipArgs)(nil)).Elem()
}

type EipInput interface {
	pulumi.Input

	ToEipOutput() EipOutput
	ToEipOutputWithContext(ctx context.Context) EipOutput
}

func (*Eip) ElementType() reflect.Type {
	return reflect.TypeOf((**Eip)(nil)).Elem()
}

func (i *Eip) ToEipOutput() EipOutput {
	return i.ToEipOutputWithContext(context.Background())
}

func (i *Eip) ToEipOutputWithContext(ctx context.Context) EipOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EipOutput)
}

// EipArrayInput is an input type that accepts EipArray and EipArrayOutput values.
// You can construct a concrete instance of `EipArrayInput` via:
//
//	EipArray{ EipArgs{...} }
type EipArrayInput interface {
	pulumi.Input

	ToEipArrayOutput() EipArrayOutput
	ToEipArrayOutputWithContext(context.Context) EipArrayOutput
}

type EipArray []EipInput

func (EipArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Eip)(nil)).Elem()
}

func (i EipArray) ToEipArrayOutput() EipArrayOutput {
	return i.ToEipArrayOutputWithContext(context.Background())
}

func (i EipArray) ToEipArrayOutputWithContext(ctx context.Context) EipArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EipArrayOutput)
}

// EipMapInput is an input type that accepts EipMap and EipMapOutput values.
// You can construct a concrete instance of `EipMapInput` via:
//
//	EipMap{ "key": EipArgs{...} }
type EipMapInput interface {
	pulumi.Input

	ToEipMapOutput() EipMapOutput
	ToEipMapOutputWithContext(context.Context) EipMapOutput
}

type EipMap map[string]EipInput

func (EipMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Eip)(nil)).Elem()
}

func (i EipMap) ToEipMapOutput() EipMapOutput {
	return i.ToEipMapOutputWithContext(context.Background())
}

func (i EipMap) ToEipMapOutputWithContext(ctx context.Context) EipMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EipMapOutput)
}

type EipOutput struct{ *pulumi.OutputState }

func (EipOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Eip)(nil)).Elem()
}

func (o EipOutput) ToEipOutput() EipOutput {
	return o
}

func (o EipOutput) ToEipOutputWithContext(ctx context.Context) EipOutput {
	return o
}

// ID of anti DDos package, it must set when `type` is `AntiDDoSEIP`.
func (o EipOutput) AntiDdosPackageId() pulumi.StringOutput {
	return o.ApplyT(func(v *Eip) pulumi.StringOutput { return v.AntiDdosPackageId }).(pulumi.StringOutput)
}

// The zone of anycast. Valid value: `ANYCAST_ZONE_GLOBAL` and `ANYCAST_ZONE_OVERSEAS`.
func (o EipOutput) AnycastZone() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Eip) pulumi.StringPtrOutput { return v.AnycastZone }).(pulumi.StringPtrOutput)
}

// Indicates whether the anycast eip can be associated to a CLB.
//
// Deprecated: It has been deprecated from version 1.27.0.
func (o EipOutput) ApplicableForClb() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Eip) pulumi.BoolPtrOutput { return v.ApplicableForClb }).(pulumi.BoolPtrOutput)
}

// Auto renew flag. 0 - default state (manual renew); 1 - automatic renew; 2 - explicit no automatic renew. NOTES: Only
// supported prepaid EIP.
func (o EipOutput) AutoRenewFlag() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Eip) pulumi.IntPtrOutput { return v.AutoRenewFlag }).(pulumi.IntPtrOutput)
}

// ID of bandwidth package, it will set when `internet_charge_type` is `BANDWIDTH_PACKAGE`.
func (o EipOutput) BandwidthPackageId() pulumi.StringOutput {
	return o.ApplyT(func(v *Eip) pulumi.StringOutput { return v.BandwidthPackageId }).(pulumi.StringOutput)
}

// The charge type of eip. Valid values: `BANDWIDTH_PACKAGE`, `BANDWIDTH_POSTPAID_BY_HOUR`, `BANDWIDTH_PREPAID_BY_MONTH`
// and `TRAFFIC_POSTPAID_BY_HOUR`.
func (o EipOutput) InternetChargeType() pulumi.StringOutput {
	return o.ApplyT(func(v *Eip) pulumi.StringOutput { return v.InternetChargeType }).(pulumi.StringOutput)
}

// The bandwidth limit of EIP, unit is Mbps.
func (o EipOutput) InternetMaxBandwidthOut() pulumi.IntOutput {
	return o.ApplyT(func(v *Eip) pulumi.IntOutput { return v.InternetMaxBandwidthOut }).(pulumi.IntOutput)
}

// Internet service provider of eip. Valid value: `BGP`, `CMCC`, `CTCC` and `CUCC`.
func (o EipOutput) InternetServiceProvider() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Eip) pulumi.StringPtrOutput { return v.InternetServiceProvider }).(pulumi.StringPtrOutput)
}

// The name of eip.
func (o EipOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Eip) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Period of instance. Default value: `1`. Valid value: `1`, `2`, `3`, `4`, `6`, `7`, `8`, `9`, `12`, `24`, `36`. NOTES:
// must set when `internet_charge_type` is `BANDWIDTH_PREPAID_BY_MONTH`.
func (o EipOutput) PrepaidPeriod() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Eip) pulumi.IntPtrOutput { return v.PrepaidPeriod }).(pulumi.IntPtrOutput)
}

// The elastic IP address.
func (o EipOutput) PublicIp() pulumi.StringOutput {
	return o.ApplyT(func(v *Eip) pulumi.StringOutput { return v.PublicIp }).(pulumi.StringOutput)
}

// The EIP current status.
func (o EipOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *Eip) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// The tags of eip.
func (o EipOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v *Eip) pulumi.MapOutput { return v.Tags }).(pulumi.MapOutput)
}

// The type of eip. Valid value: `EIP` and `AnycastEIP` and `HighQualityEIP` and `AntiDDoSEIP`. Default is `EIP`.
func (o EipOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Eip) pulumi.StringPtrOutput { return v.Type }).(pulumi.StringPtrOutput)
}

type EipArrayOutput struct{ *pulumi.OutputState }

func (EipArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Eip)(nil)).Elem()
}

func (o EipArrayOutput) ToEipArrayOutput() EipArrayOutput {
	return o
}

func (o EipArrayOutput) ToEipArrayOutputWithContext(ctx context.Context) EipArrayOutput {
	return o
}

func (o EipArrayOutput) Index(i pulumi.IntInput) EipOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Eip {
		return vs[0].([]*Eip)[vs[1].(int)]
	}).(EipOutput)
}

type EipMapOutput struct{ *pulumi.OutputState }

func (EipMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Eip)(nil)).Elem()
}

func (o EipMapOutput) ToEipMapOutput() EipMapOutput {
	return o
}

func (o EipMapOutput) ToEipMapOutputWithContext(ctx context.Context) EipMapOutput {
	return o
}

func (o EipMapOutput) MapIndex(k pulumi.StringInput) EipOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Eip {
		return vs[0].(map[string]*Eip)[vs[1].(string)]
	}).(EipOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*EipInput)(nil)).Elem(), &Eip{})
	pulumi.RegisterInputType(reflect.TypeOf((*EipArrayInput)(nil)).Elem(), EipArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*EipMapInput)(nil)).Elem(), EipMap{})
	pulumi.RegisterOutputType(EipOutput{})
	pulumi.RegisterOutputType(EipArrayOutput{})
	pulumi.RegisterOutputType(EipMapOutput{})
}