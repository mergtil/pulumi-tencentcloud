// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package emr

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetInstance(ctx *pulumi.Context, args *GetInstanceArgs, opts ...pulumi.InvokeOption) (*GetInstanceResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetInstanceResult
	err := ctx.Invoke("tencentcloud:Emr/getInstance:getInstance", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getInstance.
type GetInstanceArgs struct {
	DisplayStrategy  string   `pulumi:"displayStrategy"`
	InstanceIds      []string `pulumi:"instanceIds"`
	ProjectId        *int     `pulumi:"projectId"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
}

// A collection of values returned by getInstance.
type GetInstanceResult struct {
	Clusters        []GetInstanceCluster `pulumi:"clusters"`
	DisplayStrategy string               `pulumi:"displayStrategy"`
	// The provider-assigned unique ID for this managed resource.
	Id               string   `pulumi:"id"`
	InstanceIds      []string `pulumi:"instanceIds"`
	ProjectId        *int     `pulumi:"projectId"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
}

func GetInstanceOutput(ctx *pulumi.Context, args GetInstanceOutputArgs, opts ...pulumi.InvokeOption) GetInstanceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetInstanceResult, error) {
			args := v.(GetInstanceArgs)
			r, err := GetInstance(ctx, &args, opts...)
			var s GetInstanceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetInstanceResultOutput)
}

// A collection of arguments for invoking getInstance.
type GetInstanceOutputArgs struct {
	DisplayStrategy  pulumi.StringInput      `pulumi:"displayStrategy"`
	InstanceIds      pulumi.StringArrayInput `pulumi:"instanceIds"`
	ProjectId        pulumi.IntPtrInput      `pulumi:"projectId"`
	ResultOutputFile pulumi.StringPtrInput   `pulumi:"resultOutputFile"`
}

func (GetInstanceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceArgs)(nil)).Elem()
}

// A collection of values returned by getInstance.
type GetInstanceResultOutput struct{ *pulumi.OutputState }

func (GetInstanceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceResult)(nil)).Elem()
}

func (o GetInstanceResultOutput) ToGetInstanceResultOutput() GetInstanceResultOutput {
	return o
}

func (o GetInstanceResultOutput) ToGetInstanceResultOutputWithContext(ctx context.Context) GetInstanceResultOutput {
	return o
}

func (o GetInstanceResultOutput) Clusters() GetInstanceClusterArrayOutput {
	return o.ApplyT(func(v GetInstanceResult) []GetInstanceCluster { return v.Clusters }).(GetInstanceClusterArrayOutput)
}

func (o GetInstanceResultOutput) DisplayStrategy() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceResult) string { return v.DisplayStrategy }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetInstanceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetInstanceResultOutput) InstanceIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetInstanceResult) []string { return v.InstanceIds }).(pulumi.StringArrayOutput)
}

func (o GetInstanceResultOutput) ProjectId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetInstanceResult) *int { return v.ProjectId }).(pulumi.IntPtrOutput)
}

func (o GetInstanceResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInstanceResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetInstanceResultOutput{})
}
