// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package eips

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetInstance(ctx *pulumi.Context, args *GetInstanceArgs, opts ...pulumi.InvokeOption) (*GetInstanceResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetInstanceResult
	err := ctx.Invoke("tencentcloud:Eips/getInstance:getInstance", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getInstance.
type GetInstanceArgs struct {
	EipId            *string                `pulumi:"eipId"`
	EipName          *string                `pulumi:"eipName"`
	PublicIp         *string                `pulumi:"publicIp"`
	ResultOutputFile *string                `pulumi:"resultOutputFile"`
	Tags             map[string]interface{} `pulumi:"tags"`
}

// A collection of values returned by getInstance.
type GetInstanceResult struct {
	EipId    *string              `pulumi:"eipId"`
	EipLists []GetInstanceEipList `pulumi:"eipLists"`
	EipName  *string              `pulumi:"eipName"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                 `pulumi:"id"`
	PublicIp         *string                `pulumi:"publicIp"`
	ResultOutputFile *string                `pulumi:"resultOutputFile"`
	Tags             map[string]interface{} `pulumi:"tags"`
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
	EipId            pulumi.StringPtrInput `pulumi:"eipId"`
	EipName          pulumi.StringPtrInput `pulumi:"eipName"`
	PublicIp         pulumi.StringPtrInput `pulumi:"publicIp"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	Tags             pulumi.MapInput       `pulumi:"tags"`
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

func (o GetInstanceResultOutput) EipId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInstanceResult) *string { return v.EipId }).(pulumi.StringPtrOutput)
}

func (o GetInstanceResultOutput) EipLists() GetInstanceEipListArrayOutput {
	return o.ApplyT(func(v GetInstanceResult) []GetInstanceEipList { return v.EipLists }).(GetInstanceEipListArrayOutput)
}

func (o GetInstanceResultOutput) EipName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInstanceResult) *string { return v.EipName }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetInstanceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetInstanceResultOutput) PublicIp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInstanceResult) *string { return v.PublicIp }).(pulumi.StringPtrOutput)
}

func (o GetInstanceResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInstanceResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetInstanceResultOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v GetInstanceResult) map[string]interface{} { return v.Tags }).(pulumi.MapOutput)
}

func init() {
	pulumi.RegisterOutputType(GetInstanceResultOutput{})
}
