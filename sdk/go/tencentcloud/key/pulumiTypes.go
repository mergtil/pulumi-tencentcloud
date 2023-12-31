// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package key

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

var _ = internal.GetEnvOrDefault

type GetPairsKeyPairList struct {
	CreateTime string `pulumi:"createTime"`
	KeyId      string `pulumi:"keyId"`
	KeyName    string `pulumi:"keyName"`
	ProjectId  int    `pulumi:"projectId"`
	PublicKey  string `pulumi:"publicKey"`
}

// GetPairsKeyPairListInput is an input type that accepts GetPairsKeyPairListArgs and GetPairsKeyPairListOutput values.
// You can construct a concrete instance of `GetPairsKeyPairListInput` via:
//
//	GetPairsKeyPairListArgs{...}
type GetPairsKeyPairListInput interface {
	pulumi.Input

	ToGetPairsKeyPairListOutput() GetPairsKeyPairListOutput
	ToGetPairsKeyPairListOutputWithContext(context.Context) GetPairsKeyPairListOutput
}

type GetPairsKeyPairListArgs struct {
	CreateTime pulumi.StringInput `pulumi:"createTime"`
	KeyId      pulumi.StringInput `pulumi:"keyId"`
	KeyName    pulumi.StringInput `pulumi:"keyName"`
	ProjectId  pulumi.IntInput    `pulumi:"projectId"`
	PublicKey  pulumi.StringInput `pulumi:"publicKey"`
}

func (GetPairsKeyPairListArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetPairsKeyPairList)(nil)).Elem()
}

func (i GetPairsKeyPairListArgs) ToGetPairsKeyPairListOutput() GetPairsKeyPairListOutput {
	return i.ToGetPairsKeyPairListOutputWithContext(context.Background())
}

func (i GetPairsKeyPairListArgs) ToGetPairsKeyPairListOutputWithContext(ctx context.Context) GetPairsKeyPairListOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetPairsKeyPairListOutput)
}

// GetPairsKeyPairListArrayInput is an input type that accepts GetPairsKeyPairListArray and GetPairsKeyPairListArrayOutput values.
// You can construct a concrete instance of `GetPairsKeyPairListArrayInput` via:
//
//	GetPairsKeyPairListArray{ GetPairsKeyPairListArgs{...} }
type GetPairsKeyPairListArrayInput interface {
	pulumi.Input

	ToGetPairsKeyPairListArrayOutput() GetPairsKeyPairListArrayOutput
	ToGetPairsKeyPairListArrayOutputWithContext(context.Context) GetPairsKeyPairListArrayOutput
}

type GetPairsKeyPairListArray []GetPairsKeyPairListInput

func (GetPairsKeyPairListArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetPairsKeyPairList)(nil)).Elem()
}

func (i GetPairsKeyPairListArray) ToGetPairsKeyPairListArrayOutput() GetPairsKeyPairListArrayOutput {
	return i.ToGetPairsKeyPairListArrayOutputWithContext(context.Background())
}

func (i GetPairsKeyPairListArray) ToGetPairsKeyPairListArrayOutputWithContext(ctx context.Context) GetPairsKeyPairListArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetPairsKeyPairListArrayOutput)
}

type GetPairsKeyPairListOutput struct{ *pulumi.OutputState }

func (GetPairsKeyPairListOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetPairsKeyPairList)(nil)).Elem()
}

func (o GetPairsKeyPairListOutput) ToGetPairsKeyPairListOutput() GetPairsKeyPairListOutput {
	return o
}

func (o GetPairsKeyPairListOutput) ToGetPairsKeyPairListOutputWithContext(ctx context.Context) GetPairsKeyPairListOutput {
	return o
}

func (o GetPairsKeyPairListOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetPairsKeyPairList) string { return v.CreateTime }).(pulumi.StringOutput)
}

func (o GetPairsKeyPairListOutput) KeyId() pulumi.StringOutput {
	return o.ApplyT(func(v GetPairsKeyPairList) string { return v.KeyId }).(pulumi.StringOutput)
}

func (o GetPairsKeyPairListOutput) KeyName() pulumi.StringOutput {
	return o.ApplyT(func(v GetPairsKeyPairList) string { return v.KeyName }).(pulumi.StringOutput)
}

func (o GetPairsKeyPairListOutput) ProjectId() pulumi.IntOutput {
	return o.ApplyT(func(v GetPairsKeyPairList) int { return v.ProjectId }).(pulumi.IntOutput)
}

func (o GetPairsKeyPairListOutput) PublicKey() pulumi.StringOutput {
	return o.ApplyT(func(v GetPairsKeyPairList) string { return v.PublicKey }).(pulumi.StringOutput)
}

type GetPairsKeyPairListArrayOutput struct{ *pulumi.OutputState }

func (GetPairsKeyPairListArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetPairsKeyPairList)(nil)).Elem()
}

func (o GetPairsKeyPairListArrayOutput) ToGetPairsKeyPairListArrayOutput() GetPairsKeyPairListArrayOutput {
	return o
}

func (o GetPairsKeyPairListArrayOutput) ToGetPairsKeyPairListArrayOutputWithContext(ctx context.Context) GetPairsKeyPairListArrayOutput {
	return o
}

func (o GetPairsKeyPairListArrayOutput) Index(i pulumi.IntInput) GetPairsKeyPairListOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetPairsKeyPairList {
		return vs[0].([]GetPairsKeyPairList)[vs[1].(int)]
	}).(GetPairsKeyPairListOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GetPairsKeyPairListInput)(nil)).Elem(), GetPairsKeyPairListArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetPairsKeyPairListArrayInput)(nil)).Elem(), GetPairsKeyPairListArray{})
	pulumi.RegisterOutputType(GetPairsKeyPairListOutput{})
	pulumi.RegisterOutputType(GetPairsKeyPairListArrayOutput{})
}
