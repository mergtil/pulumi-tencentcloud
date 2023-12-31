// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cvm

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetChcHosts(ctx *pulumi.Context, args *GetChcHostsArgs, opts ...pulumi.InvokeOption) (*GetChcHostsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetChcHostsResult
	err := ctx.Invoke("tencentcloud:Cvm/getChcHosts:getChcHosts", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getChcHosts.
type GetChcHostsArgs struct {
	ChcIds           []string            `pulumi:"chcIds"`
	Filters          []GetChcHostsFilter `pulumi:"filters"`
	ResultOutputFile *string             `pulumi:"resultOutputFile"`
}

// A collection of values returned by getChcHosts.
type GetChcHostsResult struct {
	ChcHostSets []GetChcHostsChcHostSet `pulumi:"chcHostSets"`
	ChcIds      []string                `pulumi:"chcIds"`
	Filters     []GetChcHostsFilter     `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetChcHostsOutput(ctx *pulumi.Context, args GetChcHostsOutputArgs, opts ...pulumi.InvokeOption) GetChcHostsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetChcHostsResult, error) {
			args := v.(GetChcHostsArgs)
			r, err := GetChcHosts(ctx, &args, opts...)
			var s GetChcHostsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetChcHostsResultOutput)
}

// A collection of arguments for invoking getChcHosts.
type GetChcHostsOutputArgs struct {
	ChcIds           pulumi.StringArrayInput     `pulumi:"chcIds"`
	Filters          GetChcHostsFilterArrayInput `pulumi:"filters"`
	ResultOutputFile pulumi.StringPtrInput       `pulumi:"resultOutputFile"`
}

func (GetChcHostsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetChcHostsArgs)(nil)).Elem()
}

// A collection of values returned by getChcHosts.
type GetChcHostsResultOutput struct{ *pulumi.OutputState }

func (GetChcHostsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetChcHostsResult)(nil)).Elem()
}

func (o GetChcHostsResultOutput) ToGetChcHostsResultOutput() GetChcHostsResultOutput {
	return o
}

func (o GetChcHostsResultOutput) ToGetChcHostsResultOutputWithContext(ctx context.Context) GetChcHostsResultOutput {
	return o
}

func (o GetChcHostsResultOutput) ChcHostSets() GetChcHostsChcHostSetArrayOutput {
	return o.ApplyT(func(v GetChcHostsResult) []GetChcHostsChcHostSet { return v.ChcHostSets }).(GetChcHostsChcHostSetArrayOutput)
}

func (o GetChcHostsResultOutput) ChcIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetChcHostsResult) []string { return v.ChcIds }).(pulumi.StringArrayOutput)
}

func (o GetChcHostsResultOutput) Filters() GetChcHostsFilterArrayOutput {
	return o.ApplyT(func(v GetChcHostsResult) []GetChcHostsFilter { return v.Filters }).(GetChcHostsFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetChcHostsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetChcHostsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetChcHostsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetChcHostsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetChcHostsResultOutput{})
}
