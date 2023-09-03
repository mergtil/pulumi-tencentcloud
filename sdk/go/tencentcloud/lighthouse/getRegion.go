// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package lighthouse

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetRegion(ctx *pulumi.Context, args *GetRegionArgs, opts ...pulumi.InvokeOption) (*GetRegionResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetRegionResult
	err := ctx.Invoke("tencentcloud:Lighthouse/getRegion:getRegion", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRegion.
type GetRegionArgs struct {
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getRegion.
type GetRegionResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id               string               `pulumi:"id"`
	RegionSets       []GetRegionRegionSet `pulumi:"regionSets"`
	ResultOutputFile *string              `pulumi:"resultOutputFile"`
}

func GetRegionOutput(ctx *pulumi.Context, args GetRegionOutputArgs, opts ...pulumi.InvokeOption) GetRegionResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetRegionResult, error) {
			args := v.(GetRegionArgs)
			r, err := GetRegion(ctx, &args, opts...)
			var s GetRegionResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetRegionResultOutput)
}

// A collection of arguments for invoking getRegion.
type GetRegionOutputArgs struct {
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetRegionOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRegionArgs)(nil)).Elem()
}

// A collection of values returned by getRegion.
type GetRegionResultOutput struct{ *pulumi.OutputState }

func (GetRegionResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRegionResult)(nil)).Elem()
}

func (o GetRegionResultOutput) ToGetRegionResultOutput() GetRegionResultOutput {
	return o
}

func (o GetRegionResultOutput) ToGetRegionResultOutputWithContext(ctx context.Context) GetRegionResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetRegionResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetRegionResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetRegionResultOutput) RegionSets() GetRegionRegionSetArrayOutput {
	return o.ApplyT(func(v GetRegionResult) []GetRegionRegionSet { return v.RegionSets }).(GetRegionRegionSetArrayOutput)
}

func (o GetRegionResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRegionResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetRegionResultOutput{})
}