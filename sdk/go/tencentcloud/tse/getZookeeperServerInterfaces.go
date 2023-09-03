// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tse

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetZookeeperServerInterfaces(ctx *pulumi.Context, args *GetZookeeperServerInterfacesArgs, opts ...pulumi.InvokeOption) (*GetZookeeperServerInterfacesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetZookeeperServerInterfacesResult
	err := ctx.Invoke("tencentcloud:Tse/getZookeeperServerInterfaces:getZookeeperServerInterfaces", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getZookeeperServerInterfaces.
type GetZookeeperServerInterfacesArgs struct {
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getZookeeperServerInterfaces.
type GetZookeeperServerInterfacesResult struct {
	Contents []GetZookeeperServerInterfacesContent `pulumi:"contents"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetZookeeperServerInterfacesOutput(ctx *pulumi.Context, args GetZookeeperServerInterfacesOutputArgs, opts ...pulumi.InvokeOption) GetZookeeperServerInterfacesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetZookeeperServerInterfacesResult, error) {
			args := v.(GetZookeeperServerInterfacesArgs)
			r, err := GetZookeeperServerInterfaces(ctx, &args, opts...)
			var s GetZookeeperServerInterfacesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetZookeeperServerInterfacesResultOutput)
}

// A collection of arguments for invoking getZookeeperServerInterfaces.
type GetZookeeperServerInterfacesOutputArgs struct {
	InstanceId       pulumi.StringInput    `pulumi:"instanceId"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetZookeeperServerInterfacesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetZookeeperServerInterfacesArgs)(nil)).Elem()
}

// A collection of values returned by getZookeeperServerInterfaces.
type GetZookeeperServerInterfacesResultOutput struct{ *pulumi.OutputState }

func (GetZookeeperServerInterfacesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetZookeeperServerInterfacesResult)(nil)).Elem()
}

func (o GetZookeeperServerInterfacesResultOutput) ToGetZookeeperServerInterfacesResultOutput() GetZookeeperServerInterfacesResultOutput {
	return o
}

func (o GetZookeeperServerInterfacesResultOutput) ToGetZookeeperServerInterfacesResultOutputWithContext(ctx context.Context) GetZookeeperServerInterfacesResultOutput {
	return o
}

func (o GetZookeeperServerInterfacesResultOutput) Contents() GetZookeeperServerInterfacesContentArrayOutput {
	return o.ApplyT(func(v GetZookeeperServerInterfacesResult) []GetZookeeperServerInterfacesContent { return v.Contents }).(GetZookeeperServerInterfacesContentArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetZookeeperServerInterfacesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetZookeeperServerInterfacesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetZookeeperServerInterfacesResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetZookeeperServerInterfacesResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetZookeeperServerInterfacesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetZookeeperServerInterfacesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetZookeeperServerInterfacesResultOutput{})
}