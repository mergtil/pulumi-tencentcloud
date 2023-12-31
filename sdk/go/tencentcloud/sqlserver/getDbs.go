// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sqlserver

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetDbs(ctx *pulumi.Context, args *GetDbsArgs, opts ...pulumi.InvokeOption) (*GetDbsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetDbsResult
	err := ctx.Invoke("tencentcloud:Sqlserver/getDbs:getDbs", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getDbs.
type GetDbsArgs struct {
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getDbs.
type GetDbsResult struct {
	DbLists []GetDbsDbList `pulumi:"dbLists"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetDbsOutput(ctx *pulumi.Context, args GetDbsOutputArgs, opts ...pulumi.InvokeOption) GetDbsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetDbsResult, error) {
			args := v.(GetDbsArgs)
			r, err := GetDbs(ctx, &args, opts...)
			var s GetDbsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetDbsResultOutput)
}

// A collection of arguments for invoking getDbs.
type GetDbsOutputArgs struct {
	InstanceId       pulumi.StringInput    `pulumi:"instanceId"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetDbsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDbsArgs)(nil)).Elem()
}

// A collection of values returned by getDbs.
type GetDbsResultOutput struct{ *pulumi.OutputState }

func (GetDbsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDbsResult)(nil)).Elem()
}

func (o GetDbsResultOutput) ToGetDbsResultOutput() GetDbsResultOutput {
	return o
}

func (o GetDbsResultOutput) ToGetDbsResultOutputWithContext(ctx context.Context) GetDbsResultOutput {
	return o
}

func (o GetDbsResultOutput) DbLists() GetDbsDbListArrayOutput {
	return o.ApplyT(func(v GetDbsResult) []GetDbsDbList { return v.DbLists }).(GetDbsDbListArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetDbsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetDbsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetDbsResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetDbsResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetDbsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetDbsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetDbsResultOutput{})
}
