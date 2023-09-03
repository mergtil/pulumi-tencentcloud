// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package scf

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupAsyncEventStatus(ctx *pulumi.Context, args *LookupAsyncEventStatusArgs, opts ...pulumi.InvokeOption) (*LookupAsyncEventStatusResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupAsyncEventStatusResult
	err := ctx.Invoke("tencentcloud:Scf/getAsyncEventStatus:getAsyncEventStatus", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAsyncEventStatus.
type LookupAsyncEventStatusArgs struct {
	InvokeRequestId  string  `pulumi:"invokeRequestId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getAsyncEventStatus.
type LookupAsyncEventStatusResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id               string                      `pulumi:"id"`
	InvokeRequestId  string                      `pulumi:"invokeRequestId"`
	ResultOutputFile *string                     `pulumi:"resultOutputFile"`
	Results          []GetAsyncEventStatusResult `pulumi:"results"`
}

func LookupAsyncEventStatusOutput(ctx *pulumi.Context, args LookupAsyncEventStatusOutputArgs, opts ...pulumi.InvokeOption) LookupAsyncEventStatusResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupAsyncEventStatusResult, error) {
			args := v.(LookupAsyncEventStatusArgs)
			r, err := LookupAsyncEventStatus(ctx, &args, opts...)
			var s LookupAsyncEventStatusResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupAsyncEventStatusResultOutput)
}

// A collection of arguments for invoking getAsyncEventStatus.
type LookupAsyncEventStatusOutputArgs struct {
	InvokeRequestId  pulumi.StringInput    `pulumi:"invokeRequestId"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (LookupAsyncEventStatusOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAsyncEventStatusArgs)(nil)).Elem()
}

// A collection of values returned by getAsyncEventStatus.
type LookupAsyncEventStatusResultOutput struct{ *pulumi.OutputState }

func (LookupAsyncEventStatusResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAsyncEventStatusResult)(nil)).Elem()
}

func (o LookupAsyncEventStatusResultOutput) ToLookupAsyncEventStatusResultOutput() LookupAsyncEventStatusResultOutput {
	return o
}

func (o LookupAsyncEventStatusResultOutput) ToLookupAsyncEventStatusResultOutputWithContext(ctx context.Context) LookupAsyncEventStatusResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o LookupAsyncEventStatusResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAsyncEventStatusResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupAsyncEventStatusResultOutput) InvokeRequestId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAsyncEventStatusResult) string { return v.InvokeRequestId }).(pulumi.StringOutput)
}

func (o LookupAsyncEventStatusResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupAsyncEventStatusResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o LookupAsyncEventStatusResultOutput) Results() GetAsyncEventStatusResultArrayOutput {
	return o.ApplyT(func(v LookupAsyncEventStatusResult) []GetAsyncEventStatusResult { return v.Results }).(GetAsyncEventStatusResultArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupAsyncEventStatusResultOutput{})
}