// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package clb

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetResources(ctx *pulumi.Context, args *GetResourcesArgs, opts ...pulumi.InvokeOption) (*GetResourcesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetResourcesResult
	err := ctx.Invoke("tencentcloud:Clb/getResources:getResources", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getResources.
type GetResourcesArgs struct {
	Filters          []GetResourcesFilter `pulumi:"filters"`
	ResultOutputFile *string              `pulumi:"resultOutputFile"`
}

// A collection of values returned by getResources.
type GetResourcesResult struct {
	Filters []GetResourcesFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                        `pulumi:"id"`
	ResultOutputFile *string                       `pulumi:"resultOutputFile"`
	ZoneResourceSets []GetResourcesZoneResourceSet `pulumi:"zoneResourceSets"`
}

func GetResourcesOutput(ctx *pulumi.Context, args GetResourcesOutputArgs, opts ...pulumi.InvokeOption) GetResourcesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetResourcesResult, error) {
			args := v.(GetResourcesArgs)
			r, err := GetResources(ctx, &args, opts...)
			var s GetResourcesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetResourcesResultOutput)
}

// A collection of arguments for invoking getResources.
type GetResourcesOutputArgs struct {
	Filters          GetResourcesFilterArrayInput `pulumi:"filters"`
	ResultOutputFile pulumi.StringPtrInput        `pulumi:"resultOutputFile"`
}

func (GetResourcesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetResourcesArgs)(nil)).Elem()
}

// A collection of values returned by getResources.
type GetResourcesResultOutput struct{ *pulumi.OutputState }

func (GetResourcesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetResourcesResult)(nil)).Elem()
}

func (o GetResourcesResultOutput) ToGetResourcesResultOutput() GetResourcesResultOutput {
	return o
}

func (o GetResourcesResultOutput) ToGetResourcesResultOutputWithContext(ctx context.Context) GetResourcesResultOutput {
	return o
}

func (o GetResourcesResultOutput) Filters() GetResourcesFilterArrayOutput {
	return o.ApplyT(func(v GetResourcesResult) []GetResourcesFilter { return v.Filters }).(GetResourcesFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetResourcesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetResourcesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetResourcesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetResourcesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetResourcesResultOutput) ZoneResourceSets() GetResourcesZoneResourceSetArrayOutput {
	return o.ApplyT(func(v GetResourcesResult) []GetResourcesZoneResourceSet { return v.ZoneResourceSets }).(GetResourcesZoneResourceSetArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetResourcesResultOutput{})
}
