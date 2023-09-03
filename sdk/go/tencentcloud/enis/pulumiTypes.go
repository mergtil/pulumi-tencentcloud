// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package enis

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

var _ = internal.GetEnvOrDefault

type GetEnisEni struct {
	CreateTime     string                 `pulumi:"createTime"`
	Description    string                 `pulumi:"description"`
	Id             string                 `pulumi:"id"`
	InstanceId     string                 `pulumi:"instanceId"`
	Ipv4s          []GetEnisEniIpv4       `pulumi:"ipv4s"`
	Mac            string                 `pulumi:"mac"`
	Name           string                 `pulumi:"name"`
	Primary        bool                   `pulumi:"primary"`
	SecurityGroups []string               `pulumi:"securityGroups"`
	State          string                 `pulumi:"state"`
	SubnetId       string                 `pulumi:"subnetId"`
	Tags           map[string]interface{} `pulumi:"tags"`
	VpcId          string                 `pulumi:"vpcId"`
}

// GetEnisEniInput is an input type that accepts GetEnisEniArgs and GetEnisEniOutput values.
// You can construct a concrete instance of `GetEnisEniInput` via:
//
//	GetEnisEniArgs{...}
type GetEnisEniInput interface {
	pulumi.Input

	ToGetEnisEniOutput() GetEnisEniOutput
	ToGetEnisEniOutputWithContext(context.Context) GetEnisEniOutput
}

type GetEnisEniArgs struct {
	CreateTime     pulumi.StringInput       `pulumi:"createTime"`
	Description    pulumi.StringInput       `pulumi:"description"`
	Id             pulumi.StringInput       `pulumi:"id"`
	InstanceId     pulumi.StringInput       `pulumi:"instanceId"`
	Ipv4s          GetEnisEniIpv4ArrayInput `pulumi:"ipv4s"`
	Mac            pulumi.StringInput       `pulumi:"mac"`
	Name           pulumi.StringInput       `pulumi:"name"`
	Primary        pulumi.BoolInput         `pulumi:"primary"`
	SecurityGroups pulumi.StringArrayInput  `pulumi:"securityGroups"`
	State          pulumi.StringInput       `pulumi:"state"`
	SubnetId       pulumi.StringInput       `pulumi:"subnetId"`
	Tags           pulumi.MapInput          `pulumi:"tags"`
	VpcId          pulumi.StringInput       `pulumi:"vpcId"`
}

func (GetEnisEniArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEnisEni)(nil)).Elem()
}

func (i GetEnisEniArgs) ToGetEnisEniOutput() GetEnisEniOutput {
	return i.ToGetEnisEniOutputWithContext(context.Background())
}

func (i GetEnisEniArgs) ToGetEnisEniOutputWithContext(ctx context.Context) GetEnisEniOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetEnisEniOutput)
}

// GetEnisEniArrayInput is an input type that accepts GetEnisEniArray and GetEnisEniArrayOutput values.
// You can construct a concrete instance of `GetEnisEniArrayInput` via:
//
//	GetEnisEniArray{ GetEnisEniArgs{...} }
type GetEnisEniArrayInput interface {
	pulumi.Input

	ToGetEnisEniArrayOutput() GetEnisEniArrayOutput
	ToGetEnisEniArrayOutputWithContext(context.Context) GetEnisEniArrayOutput
}

type GetEnisEniArray []GetEnisEniInput

func (GetEnisEniArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetEnisEni)(nil)).Elem()
}

func (i GetEnisEniArray) ToGetEnisEniArrayOutput() GetEnisEniArrayOutput {
	return i.ToGetEnisEniArrayOutputWithContext(context.Background())
}

func (i GetEnisEniArray) ToGetEnisEniArrayOutputWithContext(ctx context.Context) GetEnisEniArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetEnisEniArrayOutput)
}

type GetEnisEniOutput struct{ *pulumi.OutputState }

func (GetEnisEniOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEnisEni)(nil)).Elem()
}

func (o GetEnisEniOutput) ToGetEnisEniOutput() GetEnisEniOutput {
	return o
}

func (o GetEnisEniOutput) ToGetEnisEniOutputWithContext(ctx context.Context) GetEnisEniOutput {
	return o
}

func (o GetEnisEniOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEni) string { return v.CreateTime }).(pulumi.StringOutput)
}

func (o GetEnisEniOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEni) string { return v.Description }).(pulumi.StringOutput)
}

func (o GetEnisEniOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEni) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetEnisEniOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEni) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetEnisEniOutput) Ipv4s() GetEnisEniIpv4ArrayOutput {
	return o.ApplyT(func(v GetEnisEni) []GetEnisEniIpv4 { return v.Ipv4s }).(GetEnisEniIpv4ArrayOutput)
}

func (o GetEnisEniOutput) Mac() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEni) string { return v.Mac }).(pulumi.StringOutput)
}

func (o GetEnisEniOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEni) string { return v.Name }).(pulumi.StringOutput)
}

func (o GetEnisEniOutput) Primary() pulumi.BoolOutput {
	return o.ApplyT(func(v GetEnisEni) bool { return v.Primary }).(pulumi.BoolOutput)
}

func (o GetEnisEniOutput) SecurityGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetEnisEni) []string { return v.SecurityGroups }).(pulumi.StringArrayOutput)
}

func (o GetEnisEniOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEni) string { return v.State }).(pulumi.StringOutput)
}

func (o GetEnisEniOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEni) string { return v.SubnetId }).(pulumi.StringOutput)
}

func (o GetEnisEniOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v GetEnisEni) map[string]interface{} { return v.Tags }).(pulumi.MapOutput)
}

func (o GetEnisEniOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEni) string { return v.VpcId }).(pulumi.StringOutput)
}

type GetEnisEniArrayOutput struct{ *pulumi.OutputState }

func (GetEnisEniArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetEnisEni)(nil)).Elem()
}

func (o GetEnisEniArrayOutput) ToGetEnisEniArrayOutput() GetEnisEniArrayOutput {
	return o
}

func (o GetEnisEniArrayOutput) ToGetEnisEniArrayOutputWithContext(ctx context.Context) GetEnisEniArrayOutput {
	return o
}

func (o GetEnisEniArrayOutput) Index(i pulumi.IntInput) GetEnisEniOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetEnisEni {
		return vs[0].([]GetEnisEni)[vs[1].(int)]
	}).(GetEnisEniOutput)
}

type GetEnisEniIpv4 struct {
	Description string `pulumi:"description"`
	Ip          string `pulumi:"ip"`
	Primary     bool   `pulumi:"primary"`
}

// GetEnisEniIpv4Input is an input type that accepts GetEnisEniIpv4Args and GetEnisEniIpv4Output values.
// You can construct a concrete instance of `GetEnisEniIpv4Input` via:
//
//	GetEnisEniIpv4Args{...}
type GetEnisEniIpv4Input interface {
	pulumi.Input

	ToGetEnisEniIpv4Output() GetEnisEniIpv4Output
	ToGetEnisEniIpv4OutputWithContext(context.Context) GetEnisEniIpv4Output
}

type GetEnisEniIpv4Args struct {
	Description pulumi.StringInput `pulumi:"description"`
	Ip          pulumi.StringInput `pulumi:"ip"`
	Primary     pulumi.BoolInput   `pulumi:"primary"`
}

func (GetEnisEniIpv4Args) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEnisEniIpv4)(nil)).Elem()
}

func (i GetEnisEniIpv4Args) ToGetEnisEniIpv4Output() GetEnisEniIpv4Output {
	return i.ToGetEnisEniIpv4OutputWithContext(context.Background())
}

func (i GetEnisEniIpv4Args) ToGetEnisEniIpv4OutputWithContext(ctx context.Context) GetEnisEniIpv4Output {
	return pulumi.ToOutputWithContext(ctx, i).(GetEnisEniIpv4Output)
}

// GetEnisEniIpv4ArrayInput is an input type that accepts GetEnisEniIpv4Array and GetEnisEniIpv4ArrayOutput values.
// You can construct a concrete instance of `GetEnisEniIpv4ArrayInput` via:
//
//	GetEnisEniIpv4Array{ GetEnisEniIpv4Args{...} }
type GetEnisEniIpv4ArrayInput interface {
	pulumi.Input

	ToGetEnisEniIpv4ArrayOutput() GetEnisEniIpv4ArrayOutput
	ToGetEnisEniIpv4ArrayOutputWithContext(context.Context) GetEnisEniIpv4ArrayOutput
}

type GetEnisEniIpv4Array []GetEnisEniIpv4Input

func (GetEnisEniIpv4Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetEnisEniIpv4)(nil)).Elem()
}

func (i GetEnisEniIpv4Array) ToGetEnisEniIpv4ArrayOutput() GetEnisEniIpv4ArrayOutput {
	return i.ToGetEnisEniIpv4ArrayOutputWithContext(context.Background())
}

func (i GetEnisEniIpv4Array) ToGetEnisEniIpv4ArrayOutputWithContext(ctx context.Context) GetEnisEniIpv4ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetEnisEniIpv4ArrayOutput)
}

type GetEnisEniIpv4Output struct{ *pulumi.OutputState }

func (GetEnisEniIpv4Output) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEnisEniIpv4)(nil)).Elem()
}

func (o GetEnisEniIpv4Output) ToGetEnisEniIpv4Output() GetEnisEniIpv4Output {
	return o
}

func (o GetEnisEniIpv4Output) ToGetEnisEniIpv4OutputWithContext(ctx context.Context) GetEnisEniIpv4Output {
	return o
}

func (o GetEnisEniIpv4Output) Description() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEniIpv4) string { return v.Description }).(pulumi.StringOutput)
}

func (o GetEnisEniIpv4Output) Ip() pulumi.StringOutput {
	return o.ApplyT(func(v GetEnisEniIpv4) string { return v.Ip }).(pulumi.StringOutput)
}

func (o GetEnisEniIpv4Output) Primary() pulumi.BoolOutput {
	return o.ApplyT(func(v GetEnisEniIpv4) bool { return v.Primary }).(pulumi.BoolOutput)
}

type GetEnisEniIpv4ArrayOutput struct{ *pulumi.OutputState }

func (GetEnisEniIpv4ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetEnisEniIpv4)(nil)).Elem()
}

func (o GetEnisEniIpv4ArrayOutput) ToGetEnisEniIpv4ArrayOutput() GetEnisEniIpv4ArrayOutput {
	return o
}

func (o GetEnisEniIpv4ArrayOutput) ToGetEnisEniIpv4ArrayOutputWithContext(ctx context.Context) GetEnisEniIpv4ArrayOutput {
	return o
}

func (o GetEnisEniIpv4ArrayOutput) Index(i pulumi.IntInput) GetEnisEniIpv4Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetEnisEniIpv4 {
		return vs[0].([]GetEnisEniIpv4)[vs[1].(int)]
	}).(GetEnisEniIpv4Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GetEnisEniInput)(nil)).Elem(), GetEnisEniArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetEnisEniArrayInput)(nil)).Elem(), GetEnisEniArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetEnisEniIpv4Input)(nil)).Elem(), GetEnisEniIpv4Args{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetEnisEniIpv4ArrayInput)(nil)).Elem(), GetEnisEniIpv4Array{})
	pulumi.RegisterOutputType(GetEnisEniOutput{})
	pulumi.RegisterOutputType(GetEnisEniArrayOutput{})
	pulumi.RegisterOutputType(GetEnisEniIpv4Output{})
	pulumi.RegisterOutputType(GetEnisEniIpv4ArrayOutput{})
}