// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package emr

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetEmr(ctx *pulumi.Context, args *GetEmrArgs, opts ...pulumi.InvokeOption) (*GetEmrResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetEmrResult
	err := ctx.Invoke("tencentcloud:Emr/getEmr:getEmr", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getEmr.
type GetEmrArgs struct {
	DisplayStrategy  string   `pulumi:"displayStrategy"`
	InstanceIds      []string `pulumi:"instanceIds"`
	ProjectId        *int     `pulumi:"projectId"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
}

// A collection of values returned by getEmr.
type GetEmrResult struct {
	Clusters        []GetEmrCluster `pulumi:"clusters"`
	DisplayStrategy string          `pulumi:"displayStrategy"`
	// The provider-assigned unique ID for this managed resource.
	Id               string   `pulumi:"id"`
	InstanceIds      []string `pulumi:"instanceIds"`
	ProjectId        *int     `pulumi:"projectId"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
}

func GetEmrOutput(ctx *pulumi.Context, args GetEmrOutputArgs, opts ...pulumi.InvokeOption) GetEmrResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetEmrResult, error) {
			args := v.(GetEmrArgs)
			r, err := GetEmr(ctx, &args, opts...)
			var s GetEmrResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetEmrResultOutput)
}

// A collection of arguments for invoking getEmr.
type GetEmrOutputArgs struct {
	DisplayStrategy  pulumi.StringInput      `pulumi:"displayStrategy"`
	InstanceIds      pulumi.StringArrayInput `pulumi:"instanceIds"`
	ProjectId        pulumi.IntPtrInput      `pulumi:"projectId"`
	ResultOutputFile pulumi.StringPtrInput   `pulumi:"resultOutputFile"`
}

func (GetEmrOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEmrArgs)(nil)).Elem()
}

// A collection of values returned by getEmr.
type GetEmrResultOutput struct{ *pulumi.OutputState }

func (GetEmrResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetEmrResult)(nil)).Elem()
}

func (o GetEmrResultOutput) ToGetEmrResultOutput() GetEmrResultOutput {
	return o
}

func (o GetEmrResultOutput) ToGetEmrResultOutputWithContext(ctx context.Context) GetEmrResultOutput {
	return o
}

func (o GetEmrResultOutput) Clusters() GetEmrClusterArrayOutput {
	return o.ApplyT(func(v GetEmrResult) []GetEmrCluster { return v.Clusters }).(GetEmrClusterArrayOutput)
}

func (o GetEmrResultOutput) DisplayStrategy() pulumi.StringOutput {
	return o.ApplyT(func(v GetEmrResult) string { return v.DisplayStrategy }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetEmrResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetEmrResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetEmrResultOutput) InstanceIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetEmrResult) []string { return v.InstanceIds }).(pulumi.StringArrayOutput)
}

func (o GetEmrResultOutput) ProjectId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetEmrResult) *int { return v.ProjectId }).(pulumi.IntPtrOutput)
}

func (o GetEmrResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetEmrResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetEmrResultOutput{})
}