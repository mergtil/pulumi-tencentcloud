// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package gaap

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetRealservers(ctx *pulumi.Context, args *GetRealserversArgs, opts ...pulumi.InvokeOption) (*GetRealserversResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetRealserversResult
	err := ctx.Invoke("tencentcloud:Gaap/getRealservers:getRealservers", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRealservers.
type GetRealserversArgs struct {
	Domain           *string                `pulumi:"domain"`
	Ip               *string                `pulumi:"ip"`
	Name             *string                `pulumi:"name"`
	ProjectId        *int                   `pulumi:"projectId"`
	ResultOutputFile *string                `pulumi:"resultOutputFile"`
	Tags             map[string]interface{} `pulumi:"tags"`
}

// A collection of values returned by getRealservers.
type GetRealserversResult struct {
	Domain *string `pulumi:"domain"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                     `pulumi:"id"`
	Ip               *string                    `pulumi:"ip"`
	Name             *string                    `pulumi:"name"`
	ProjectId        *int                       `pulumi:"projectId"`
	Realservers      []GetRealserversRealserver `pulumi:"realservers"`
	ResultOutputFile *string                    `pulumi:"resultOutputFile"`
	Tags             map[string]interface{}     `pulumi:"tags"`
}

func GetRealserversOutput(ctx *pulumi.Context, args GetRealserversOutputArgs, opts ...pulumi.InvokeOption) GetRealserversResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetRealserversResult, error) {
			args := v.(GetRealserversArgs)
			r, err := GetRealservers(ctx, &args, opts...)
			var s GetRealserversResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetRealserversResultOutput)
}

// A collection of arguments for invoking getRealservers.
type GetRealserversOutputArgs struct {
	Domain           pulumi.StringPtrInput `pulumi:"domain"`
	Ip               pulumi.StringPtrInput `pulumi:"ip"`
	Name             pulumi.StringPtrInput `pulumi:"name"`
	ProjectId        pulumi.IntPtrInput    `pulumi:"projectId"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	Tags             pulumi.MapInput       `pulumi:"tags"`
}

func (GetRealserversOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRealserversArgs)(nil)).Elem()
}

// A collection of values returned by getRealservers.
type GetRealserversResultOutput struct{ *pulumi.OutputState }

func (GetRealserversResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRealserversResult)(nil)).Elem()
}

func (o GetRealserversResultOutput) ToGetRealserversResultOutput() GetRealserversResultOutput {
	return o
}

func (o GetRealserversResultOutput) ToGetRealserversResultOutputWithContext(ctx context.Context) GetRealserversResultOutput {
	return o
}

func (o GetRealserversResultOutput) Domain() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRealserversResult) *string { return v.Domain }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetRealserversResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetRealserversResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetRealserversResultOutput) Ip() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRealserversResult) *string { return v.Ip }).(pulumi.StringPtrOutput)
}

func (o GetRealserversResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRealserversResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o GetRealserversResultOutput) ProjectId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetRealserversResult) *int { return v.ProjectId }).(pulumi.IntPtrOutput)
}

func (o GetRealserversResultOutput) Realservers() GetRealserversRealserverArrayOutput {
	return o.ApplyT(func(v GetRealserversResult) []GetRealserversRealserver { return v.Realservers }).(GetRealserversRealserverArrayOutput)
}

func (o GetRealserversResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRealserversResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetRealserversResultOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v GetRealserversResult) map[string]interface{} { return v.Tags }).(pulumi.MapOutput)
}

func init() {
	pulumi.RegisterOutputType(GetRealserversResultOutput{})
}