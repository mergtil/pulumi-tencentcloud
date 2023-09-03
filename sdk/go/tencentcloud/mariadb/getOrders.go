// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mariadb

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetOrders(ctx *pulumi.Context, args *GetOrdersArgs, opts ...pulumi.InvokeOption) (*GetOrdersResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetOrdersResult
	err := ctx.Invoke("tencentcloud:Mariadb/getOrders:getOrders", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getOrders.
type GetOrdersArgs struct {
	DealName         string  `pulumi:"dealName"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getOrders.
type GetOrdersResult struct {
	DealName string          `pulumi:"dealName"`
	Deals    []GetOrdersDeal `pulumi:"deals"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetOrdersOutput(ctx *pulumi.Context, args GetOrdersOutputArgs, opts ...pulumi.InvokeOption) GetOrdersResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetOrdersResult, error) {
			args := v.(GetOrdersArgs)
			r, err := GetOrders(ctx, &args, opts...)
			var s GetOrdersResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetOrdersResultOutput)
}

// A collection of arguments for invoking getOrders.
type GetOrdersOutputArgs struct {
	DealName         pulumi.StringInput    `pulumi:"dealName"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetOrdersOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetOrdersArgs)(nil)).Elem()
}

// A collection of values returned by getOrders.
type GetOrdersResultOutput struct{ *pulumi.OutputState }

func (GetOrdersResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetOrdersResult)(nil)).Elem()
}

func (o GetOrdersResultOutput) ToGetOrdersResultOutput() GetOrdersResultOutput {
	return o
}

func (o GetOrdersResultOutput) ToGetOrdersResultOutputWithContext(ctx context.Context) GetOrdersResultOutput {
	return o
}

func (o GetOrdersResultOutput) DealName() pulumi.StringOutput {
	return o.ApplyT(func(v GetOrdersResult) string { return v.DealName }).(pulumi.StringOutput)
}

func (o GetOrdersResultOutput) Deals() GetOrdersDealArrayOutput {
	return o.ApplyT(func(v GetOrdersResult) []GetOrdersDeal { return v.Deals }).(GetOrdersDealArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetOrdersResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetOrdersResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetOrdersResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetOrdersResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetOrdersResultOutput{})
}