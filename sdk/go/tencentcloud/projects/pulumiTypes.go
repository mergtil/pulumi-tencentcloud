// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package projects

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

var _ = internal.GetEnvOrDefault

type GetInstanceProject struct {
	CreateTime  string `pulumi:"createTime"`
	CreatorUin  int    `pulumi:"creatorUin"`
	ProjectId   int    `pulumi:"projectId"`
	ProjectInfo string `pulumi:"projectInfo"`
	ProjectName string `pulumi:"projectName"`
}

// GetInstanceProjectInput is an input type that accepts GetInstanceProjectArgs and GetInstanceProjectOutput values.
// You can construct a concrete instance of `GetInstanceProjectInput` via:
//
//	GetInstanceProjectArgs{...}
type GetInstanceProjectInput interface {
	pulumi.Input

	ToGetInstanceProjectOutput() GetInstanceProjectOutput
	ToGetInstanceProjectOutputWithContext(context.Context) GetInstanceProjectOutput
}

type GetInstanceProjectArgs struct {
	CreateTime  pulumi.StringInput `pulumi:"createTime"`
	CreatorUin  pulumi.IntInput    `pulumi:"creatorUin"`
	ProjectId   pulumi.IntInput    `pulumi:"projectId"`
	ProjectInfo pulumi.StringInput `pulumi:"projectInfo"`
	ProjectName pulumi.StringInput `pulumi:"projectName"`
}

func (GetInstanceProjectArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceProject)(nil)).Elem()
}

func (i GetInstanceProjectArgs) ToGetInstanceProjectOutput() GetInstanceProjectOutput {
	return i.ToGetInstanceProjectOutputWithContext(context.Background())
}

func (i GetInstanceProjectArgs) ToGetInstanceProjectOutputWithContext(ctx context.Context) GetInstanceProjectOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceProjectOutput)
}

// GetInstanceProjectArrayInput is an input type that accepts GetInstanceProjectArray and GetInstanceProjectArrayOutput values.
// You can construct a concrete instance of `GetInstanceProjectArrayInput` via:
//
//	GetInstanceProjectArray{ GetInstanceProjectArgs{...} }
type GetInstanceProjectArrayInput interface {
	pulumi.Input

	ToGetInstanceProjectArrayOutput() GetInstanceProjectArrayOutput
	ToGetInstanceProjectArrayOutputWithContext(context.Context) GetInstanceProjectArrayOutput
}

type GetInstanceProjectArray []GetInstanceProjectInput

func (GetInstanceProjectArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceProject)(nil)).Elem()
}

func (i GetInstanceProjectArray) ToGetInstanceProjectArrayOutput() GetInstanceProjectArrayOutput {
	return i.ToGetInstanceProjectArrayOutputWithContext(context.Background())
}

func (i GetInstanceProjectArray) ToGetInstanceProjectArrayOutputWithContext(ctx context.Context) GetInstanceProjectArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetInstanceProjectArrayOutput)
}

type GetInstanceProjectOutput struct{ *pulumi.OutputState }

func (GetInstanceProjectOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceProject)(nil)).Elem()
}

func (o GetInstanceProjectOutput) ToGetInstanceProjectOutput() GetInstanceProjectOutput {
	return o
}

func (o GetInstanceProjectOutput) ToGetInstanceProjectOutputWithContext(ctx context.Context) GetInstanceProjectOutput {
	return o
}

func (o GetInstanceProjectOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceProject) string { return v.CreateTime }).(pulumi.StringOutput)
}

func (o GetInstanceProjectOutput) CreatorUin() pulumi.IntOutput {
	return o.ApplyT(func(v GetInstanceProject) int { return v.CreatorUin }).(pulumi.IntOutput)
}

func (o GetInstanceProjectOutput) ProjectId() pulumi.IntOutput {
	return o.ApplyT(func(v GetInstanceProject) int { return v.ProjectId }).(pulumi.IntOutput)
}

func (o GetInstanceProjectOutput) ProjectInfo() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceProject) string { return v.ProjectInfo }).(pulumi.StringOutput)
}

func (o GetInstanceProjectOutput) ProjectName() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceProject) string { return v.ProjectName }).(pulumi.StringOutput)
}

type GetInstanceProjectArrayOutput struct{ *pulumi.OutputState }

func (GetInstanceProjectArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetInstanceProject)(nil)).Elem()
}

func (o GetInstanceProjectArrayOutput) ToGetInstanceProjectArrayOutput() GetInstanceProjectArrayOutput {
	return o
}

func (o GetInstanceProjectArrayOutput) ToGetInstanceProjectArrayOutputWithContext(ctx context.Context) GetInstanceProjectArrayOutput {
	return o
}

func (o GetInstanceProjectArrayOutput) Index(i pulumi.IntInput) GetInstanceProjectOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetInstanceProject {
		return vs[0].([]GetInstanceProject)[vs[1].(int)]
	}).(GetInstanceProjectOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GetInstanceProjectInput)(nil)).Elem(), GetInstanceProjectArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetInstanceProjectArrayInput)(nil)).Elem(), GetInstanceProjectArray{})
	pulumi.RegisterOutputType(GetInstanceProjectOutput{})
	pulumi.RegisterOutputType(GetInstanceProjectArrayOutput{})
}
