// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package eni

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

var _ = internal.GetEnvOrDefault

type InstanceIpv4 struct {
	Description *string `pulumi:"description"`
	Ip          string  `pulumi:"ip"`
	Primary     bool    `pulumi:"primary"`
}

// InstanceIpv4Input is an input type that accepts InstanceIpv4Args and InstanceIpv4Output values.
// You can construct a concrete instance of `InstanceIpv4Input` via:
//
//	InstanceIpv4Args{...}
type InstanceIpv4Input interface {
	pulumi.Input

	ToInstanceIpv4Output() InstanceIpv4Output
	ToInstanceIpv4OutputWithContext(context.Context) InstanceIpv4Output
}

type InstanceIpv4Args struct {
	Description pulumi.StringPtrInput `pulumi:"description"`
	Ip          pulumi.StringInput    `pulumi:"ip"`
	Primary     pulumi.BoolInput      `pulumi:"primary"`
}

func (InstanceIpv4Args) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceIpv4)(nil)).Elem()
}

func (i InstanceIpv4Args) ToInstanceIpv4Output() InstanceIpv4Output {
	return i.ToInstanceIpv4OutputWithContext(context.Background())
}

func (i InstanceIpv4Args) ToInstanceIpv4OutputWithContext(ctx context.Context) InstanceIpv4Output {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceIpv4Output)
}

// InstanceIpv4ArrayInput is an input type that accepts InstanceIpv4Array and InstanceIpv4ArrayOutput values.
// You can construct a concrete instance of `InstanceIpv4ArrayInput` via:
//
//	InstanceIpv4Array{ InstanceIpv4Args{...} }
type InstanceIpv4ArrayInput interface {
	pulumi.Input

	ToInstanceIpv4ArrayOutput() InstanceIpv4ArrayOutput
	ToInstanceIpv4ArrayOutputWithContext(context.Context) InstanceIpv4ArrayOutput
}

type InstanceIpv4Array []InstanceIpv4Input

func (InstanceIpv4Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]InstanceIpv4)(nil)).Elem()
}

func (i InstanceIpv4Array) ToInstanceIpv4ArrayOutput() InstanceIpv4ArrayOutput {
	return i.ToInstanceIpv4ArrayOutputWithContext(context.Background())
}

func (i InstanceIpv4Array) ToInstanceIpv4ArrayOutputWithContext(ctx context.Context) InstanceIpv4ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceIpv4ArrayOutput)
}

type InstanceIpv4Output struct{ *pulumi.OutputState }

func (InstanceIpv4Output) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceIpv4)(nil)).Elem()
}

func (o InstanceIpv4Output) ToInstanceIpv4Output() InstanceIpv4Output {
	return o
}

func (o InstanceIpv4Output) ToInstanceIpv4OutputWithContext(ctx context.Context) InstanceIpv4Output {
	return o
}

func (o InstanceIpv4Output) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v InstanceIpv4) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o InstanceIpv4Output) Ip() pulumi.StringOutput {
	return o.ApplyT(func(v InstanceIpv4) string { return v.Ip }).(pulumi.StringOutput)
}

func (o InstanceIpv4Output) Primary() pulumi.BoolOutput {
	return o.ApplyT(func(v InstanceIpv4) bool { return v.Primary }).(pulumi.BoolOutput)
}

type InstanceIpv4ArrayOutput struct{ *pulumi.OutputState }

func (InstanceIpv4ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]InstanceIpv4)(nil)).Elem()
}

func (o InstanceIpv4ArrayOutput) ToInstanceIpv4ArrayOutput() InstanceIpv4ArrayOutput {
	return o
}

func (o InstanceIpv4ArrayOutput) ToInstanceIpv4ArrayOutputWithContext(ctx context.Context) InstanceIpv4ArrayOutput {
	return o
}

func (o InstanceIpv4ArrayOutput) Index(i pulumi.IntInput) InstanceIpv4Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) InstanceIpv4 {
		return vs[0].([]InstanceIpv4)[vs[1].(int)]
	}).(InstanceIpv4Output)
}

type InstanceIpv4Info struct {
	Description *string `pulumi:"description"`
	Ip          *string `pulumi:"ip"`
	Primary     *bool   `pulumi:"primary"`
}

// InstanceIpv4InfoInput is an input type that accepts InstanceIpv4InfoArgs and InstanceIpv4InfoOutput values.
// You can construct a concrete instance of `InstanceIpv4InfoInput` via:
//
//	InstanceIpv4InfoArgs{...}
type InstanceIpv4InfoInput interface {
	pulumi.Input

	ToInstanceIpv4InfoOutput() InstanceIpv4InfoOutput
	ToInstanceIpv4InfoOutputWithContext(context.Context) InstanceIpv4InfoOutput
}

type InstanceIpv4InfoArgs struct {
	Description pulumi.StringPtrInput `pulumi:"description"`
	Ip          pulumi.StringPtrInput `pulumi:"ip"`
	Primary     pulumi.BoolPtrInput   `pulumi:"primary"`
}

func (InstanceIpv4InfoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceIpv4Info)(nil)).Elem()
}

func (i InstanceIpv4InfoArgs) ToInstanceIpv4InfoOutput() InstanceIpv4InfoOutput {
	return i.ToInstanceIpv4InfoOutputWithContext(context.Background())
}

func (i InstanceIpv4InfoArgs) ToInstanceIpv4InfoOutputWithContext(ctx context.Context) InstanceIpv4InfoOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceIpv4InfoOutput)
}

// InstanceIpv4InfoArrayInput is an input type that accepts InstanceIpv4InfoArray and InstanceIpv4InfoArrayOutput values.
// You can construct a concrete instance of `InstanceIpv4InfoArrayInput` via:
//
//	InstanceIpv4InfoArray{ InstanceIpv4InfoArgs{...} }
type InstanceIpv4InfoArrayInput interface {
	pulumi.Input

	ToInstanceIpv4InfoArrayOutput() InstanceIpv4InfoArrayOutput
	ToInstanceIpv4InfoArrayOutputWithContext(context.Context) InstanceIpv4InfoArrayOutput
}

type InstanceIpv4InfoArray []InstanceIpv4InfoInput

func (InstanceIpv4InfoArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]InstanceIpv4Info)(nil)).Elem()
}

func (i InstanceIpv4InfoArray) ToInstanceIpv4InfoArrayOutput() InstanceIpv4InfoArrayOutput {
	return i.ToInstanceIpv4InfoArrayOutputWithContext(context.Background())
}

func (i InstanceIpv4InfoArray) ToInstanceIpv4InfoArrayOutputWithContext(ctx context.Context) InstanceIpv4InfoArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceIpv4InfoArrayOutput)
}

type InstanceIpv4InfoOutput struct{ *pulumi.OutputState }

func (InstanceIpv4InfoOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceIpv4Info)(nil)).Elem()
}

func (o InstanceIpv4InfoOutput) ToInstanceIpv4InfoOutput() InstanceIpv4InfoOutput {
	return o
}

func (o InstanceIpv4InfoOutput) ToInstanceIpv4InfoOutputWithContext(ctx context.Context) InstanceIpv4InfoOutput {
	return o
}

func (o InstanceIpv4InfoOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v InstanceIpv4Info) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o InstanceIpv4InfoOutput) Ip() pulumi.StringPtrOutput {
	return o.ApplyT(func(v InstanceIpv4Info) *string { return v.Ip }).(pulumi.StringPtrOutput)
}

func (o InstanceIpv4InfoOutput) Primary() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v InstanceIpv4Info) *bool { return v.Primary }).(pulumi.BoolPtrOutput)
}

type InstanceIpv4InfoArrayOutput struct{ *pulumi.OutputState }

func (InstanceIpv4InfoArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]InstanceIpv4Info)(nil)).Elem()
}

func (o InstanceIpv4InfoArrayOutput) ToInstanceIpv4InfoArrayOutput() InstanceIpv4InfoArrayOutput {
	return o
}

func (o InstanceIpv4InfoArrayOutput) ToInstanceIpv4InfoArrayOutputWithContext(ctx context.Context) InstanceIpv4InfoArrayOutput {
	return o
}

func (o InstanceIpv4InfoArrayOutput) Index(i pulumi.IntInput) InstanceIpv4InfoOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) InstanceIpv4Info {
		return vs[0].([]InstanceIpv4Info)[vs[1].(int)]
	}).(InstanceIpv4InfoOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceIpv4Input)(nil)).Elem(), InstanceIpv4Args{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceIpv4ArrayInput)(nil)).Elem(), InstanceIpv4Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceIpv4InfoInput)(nil)).Elem(), InstanceIpv4InfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstanceIpv4InfoArrayInput)(nil)).Elem(), InstanceIpv4InfoArray{})
	pulumi.RegisterOutputType(InstanceIpv4Output{})
	pulumi.RegisterOutputType(InstanceIpv4ArrayOutput{})
	pulumi.RegisterOutputType(InstanceIpv4InfoOutput{})
	pulumi.RegisterOutputType(InstanceIpv4InfoArrayOutput{})
}
