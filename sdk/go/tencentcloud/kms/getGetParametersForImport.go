// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package kms

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetGetParametersForImport(ctx *pulumi.Context, args *GetGetParametersForImportArgs, opts ...pulumi.InvokeOption) (*GetGetParametersForImportResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetGetParametersForImportResult
	err := ctx.Invoke("tencentcloud:Kms/getGetParametersForImport:getGetParametersForImport", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getGetParametersForImport.
type GetGetParametersForImportArgs struct {
	KeyId             string  `pulumi:"keyId"`
	ResultOutputFile  *string `pulumi:"resultOutputFile"`
	WrappingAlgorithm string  `pulumi:"wrappingAlgorithm"`
	WrappingKeySpec   string  `pulumi:"wrappingKeySpec"`
}

// A collection of values returned by getGetParametersForImport.
type GetGetParametersForImportResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id                string  `pulumi:"id"`
	ImportToken       string  `pulumi:"importToken"`
	KeyId             string  `pulumi:"keyId"`
	ParametersValidTo int     `pulumi:"parametersValidTo"`
	PublicKey         string  `pulumi:"publicKey"`
	ResultOutputFile  *string `pulumi:"resultOutputFile"`
	WrappingAlgorithm string  `pulumi:"wrappingAlgorithm"`
	WrappingKeySpec   string  `pulumi:"wrappingKeySpec"`
}

func GetGetParametersForImportOutput(ctx *pulumi.Context, args GetGetParametersForImportOutputArgs, opts ...pulumi.InvokeOption) GetGetParametersForImportResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetGetParametersForImportResult, error) {
			args := v.(GetGetParametersForImportArgs)
			r, err := GetGetParametersForImport(ctx, &args, opts...)
			var s GetGetParametersForImportResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetGetParametersForImportResultOutput)
}

// A collection of arguments for invoking getGetParametersForImport.
type GetGetParametersForImportOutputArgs struct {
	KeyId             pulumi.StringInput    `pulumi:"keyId"`
	ResultOutputFile  pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	WrappingAlgorithm pulumi.StringInput    `pulumi:"wrappingAlgorithm"`
	WrappingKeySpec   pulumi.StringInput    `pulumi:"wrappingKeySpec"`
}

func (GetGetParametersForImportOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetGetParametersForImportArgs)(nil)).Elem()
}

// A collection of values returned by getGetParametersForImport.
type GetGetParametersForImportResultOutput struct{ *pulumi.OutputState }

func (GetGetParametersForImportResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetGetParametersForImportResult)(nil)).Elem()
}

func (o GetGetParametersForImportResultOutput) ToGetGetParametersForImportResultOutput() GetGetParametersForImportResultOutput {
	return o
}

func (o GetGetParametersForImportResultOutput) ToGetGetParametersForImportResultOutputWithContext(ctx context.Context) GetGetParametersForImportResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetGetParametersForImportResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetGetParametersForImportResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetGetParametersForImportResultOutput) ImportToken() pulumi.StringOutput {
	return o.ApplyT(func(v GetGetParametersForImportResult) string { return v.ImportToken }).(pulumi.StringOutput)
}

func (o GetGetParametersForImportResultOutput) KeyId() pulumi.StringOutput {
	return o.ApplyT(func(v GetGetParametersForImportResult) string { return v.KeyId }).(pulumi.StringOutput)
}

func (o GetGetParametersForImportResultOutput) ParametersValidTo() pulumi.IntOutput {
	return o.ApplyT(func(v GetGetParametersForImportResult) int { return v.ParametersValidTo }).(pulumi.IntOutput)
}

func (o GetGetParametersForImportResultOutput) PublicKey() pulumi.StringOutput {
	return o.ApplyT(func(v GetGetParametersForImportResult) string { return v.PublicKey }).(pulumi.StringOutput)
}

func (o GetGetParametersForImportResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetGetParametersForImportResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetGetParametersForImportResultOutput) WrappingAlgorithm() pulumi.StringOutput {
	return o.ApplyT(func(v GetGetParametersForImportResult) string { return v.WrappingAlgorithm }).(pulumi.StringOutput)
}

func (o GetGetParametersForImportResultOutput) WrappingKeySpec() pulumi.StringOutput {
	return o.ApplyT(func(v GetGetParametersForImportResult) string { return v.WrappingKeySpec }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetGetParametersForImportResultOutput{})
}
