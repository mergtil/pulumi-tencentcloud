// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package apigateway

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetThrottlingApis(ctx *pulumi.Context, args *GetThrottlingApisArgs, opts ...pulumi.InvokeOption) (*GetThrottlingApisResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetThrottlingApisResult
	err := ctx.Invoke("tencentcloud:ApiGateway/getThrottlingApis:getThrottlingApis", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getThrottlingApis.
type GetThrottlingApisArgs struct {
	EnvironmentNames []string `pulumi:"environmentNames"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
	ServiceId        *string  `pulumi:"serviceId"`
}

// A collection of values returned by getThrottlingApis.
type GetThrottlingApisResult struct {
	EnvironmentNames []string `pulumi:"environmentNames"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                  `pulumi:"id"`
	Lists            []GetThrottlingApisList `pulumi:"lists"`
	ResultOutputFile *string                 `pulumi:"resultOutputFile"`
	ServiceId        *string                 `pulumi:"serviceId"`
}

func GetThrottlingApisOutput(ctx *pulumi.Context, args GetThrottlingApisOutputArgs, opts ...pulumi.InvokeOption) GetThrottlingApisResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetThrottlingApisResult, error) {
			args := v.(GetThrottlingApisArgs)
			r, err := GetThrottlingApis(ctx, &args, opts...)
			var s GetThrottlingApisResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetThrottlingApisResultOutput)
}

// A collection of arguments for invoking getThrottlingApis.
type GetThrottlingApisOutputArgs struct {
	EnvironmentNames pulumi.StringArrayInput `pulumi:"environmentNames"`
	ResultOutputFile pulumi.StringPtrInput   `pulumi:"resultOutputFile"`
	ServiceId        pulumi.StringPtrInput   `pulumi:"serviceId"`
}

func (GetThrottlingApisOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetThrottlingApisArgs)(nil)).Elem()
}

// A collection of values returned by getThrottlingApis.
type GetThrottlingApisResultOutput struct{ *pulumi.OutputState }

func (GetThrottlingApisResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetThrottlingApisResult)(nil)).Elem()
}

func (o GetThrottlingApisResultOutput) ToGetThrottlingApisResultOutput() GetThrottlingApisResultOutput {
	return o
}

func (o GetThrottlingApisResultOutput) ToGetThrottlingApisResultOutputWithContext(ctx context.Context) GetThrottlingApisResultOutput {
	return o
}

func (o GetThrottlingApisResultOutput) EnvironmentNames() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetThrottlingApisResult) []string { return v.EnvironmentNames }).(pulumi.StringArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetThrottlingApisResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetThrottlingApisResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetThrottlingApisResultOutput) Lists() GetThrottlingApisListArrayOutput {
	return o.ApplyT(func(v GetThrottlingApisResult) []GetThrottlingApisList { return v.Lists }).(GetThrottlingApisListArrayOutput)
}

func (o GetThrottlingApisResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetThrottlingApisResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetThrottlingApisResultOutput) ServiceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetThrottlingApisResult) *string { return v.ServiceId }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetThrottlingApisResultOutput{})
}
