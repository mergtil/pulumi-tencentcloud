// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package clb

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetCrossTargets(ctx *pulumi.Context, args *GetCrossTargetsArgs, opts ...pulumi.InvokeOption) (*GetCrossTargetsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetCrossTargetsResult
	err := ctx.Invoke("tencentcloud:Clb/getCrossTargets:getCrossTargets", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCrossTargets.
type GetCrossTargetsArgs struct {
	Filters          []GetCrossTargetsFilter `pulumi:"filters"`
	ResultOutputFile *string                 `pulumi:"resultOutputFile"`
}

// A collection of values returned by getCrossTargets.
type GetCrossTargetsResult struct {
	CrossTargetSets []GetCrossTargetsCrossTargetSet `pulumi:"crossTargetSets"`
	Filters         []GetCrossTargetsFilter         `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetCrossTargetsOutput(ctx *pulumi.Context, args GetCrossTargetsOutputArgs, opts ...pulumi.InvokeOption) GetCrossTargetsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetCrossTargetsResult, error) {
			args := v.(GetCrossTargetsArgs)
			r, err := GetCrossTargets(ctx, &args, opts...)
			var s GetCrossTargetsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetCrossTargetsResultOutput)
}

// A collection of arguments for invoking getCrossTargets.
type GetCrossTargetsOutputArgs struct {
	Filters          GetCrossTargetsFilterArrayInput `pulumi:"filters"`
	ResultOutputFile pulumi.StringPtrInput           `pulumi:"resultOutputFile"`
}

func (GetCrossTargetsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetCrossTargetsArgs)(nil)).Elem()
}

// A collection of values returned by getCrossTargets.
type GetCrossTargetsResultOutput struct{ *pulumi.OutputState }

func (GetCrossTargetsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetCrossTargetsResult)(nil)).Elem()
}

func (o GetCrossTargetsResultOutput) ToGetCrossTargetsResultOutput() GetCrossTargetsResultOutput {
	return o
}

func (o GetCrossTargetsResultOutput) ToGetCrossTargetsResultOutputWithContext(ctx context.Context) GetCrossTargetsResultOutput {
	return o
}

func (o GetCrossTargetsResultOutput) CrossTargetSets() GetCrossTargetsCrossTargetSetArrayOutput {
	return o.ApplyT(func(v GetCrossTargetsResult) []GetCrossTargetsCrossTargetSet { return v.CrossTargetSets }).(GetCrossTargetsCrossTargetSetArrayOutput)
}

func (o GetCrossTargetsResultOutput) Filters() GetCrossTargetsFilterArrayOutput {
	return o.ApplyT(func(v GetCrossTargetsResult) []GetCrossTargetsFilter { return v.Filters }).(GetCrossTargetsFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetCrossTargetsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetCrossTargetsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetCrossTargetsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetCrossTargetsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetCrossTargetsResultOutput{})
}