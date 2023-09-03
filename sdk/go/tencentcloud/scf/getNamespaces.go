// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package scf

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetNamespaces(ctx *pulumi.Context, args *GetNamespacesArgs, opts ...pulumi.InvokeOption) (*GetNamespacesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetNamespacesResult
	err := ctx.Invoke("tencentcloud:Scf/getNamespaces:getNamespaces", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getNamespaces.
type GetNamespacesArgs struct {
	Description      *string `pulumi:"description"`
	Namespace        *string `pulumi:"namespace"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getNamespaces.
type GetNamespacesResult struct {
	Description *string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                   `pulumi:"id"`
	Namespace        *string                  `pulumi:"namespace"`
	Namespaces       []GetNamespacesNamespace `pulumi:"namespaces"`
	ResultOutputFile *string                  `pulumi:"resultOutputFile"`
}

func GetNamespacesOutput(ctx *pulumi.Context, args GetNamespacesOutputArgs, opts ...pulumi.InvokeOption) GetNamespacesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetNamespacesResult, error) {
			args := v.(GetNamespacesArgs)
			r, err := GetNamespaces(ctx, &args, opts...)
			var s GetNamespacesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetNamespacesResultOutput)
}

// A collection of arguments for invoking getNamespaces.
type GetNamespacesOutputArgs struct {
	Description      pulumi.StringPtrInput `pulumi:"description"`
	Namespace        pulumi.StringPtrInput `pulumi:"namespace"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetNamespacesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetNamespacesArgs)(nil)).Elem()
}

// A collection of values returned by getNamespaces.
type GetNamespacesResultOutput struct{ *pulumi.OutputState }

func (GetNamespacesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetNamespacesResult)(nil)).Elem()
}

func (o GetNamespacesResultOutput) ToGetNamespacesResultOutput() GetNamespacesResultOutput {
	return o
}

func (o GetNamespacesResultOutput) ToGetNamespacesResultOutputWithContext(ctx context.Context) GetNamespacesResultOutput {
	return o
}

func (o GetNamespacesResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetNamespacesResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetNamespacesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetNamespacesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetNamespacesResultOutput) Namespace() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetNamespacesResult) *string { return v.Namespace }).(pulumi.StringPtrOutput)
}

func (o GetNamespacesResultOutput) Namespaces() GetNamespacesNamespaceArrayOutput {
	return o.ApplyT(func(v GetNamespacesResult) []GetNamespacesNamespace { return v.Namespaces }).(GetNamespacesNamespaceArrayOutput)
}

func (o GetNamespacesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetNamespacesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetNamespacesResultOutput{})
}