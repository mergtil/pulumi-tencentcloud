// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cfs

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetFileSystems(ctx *pulumi.Context, args *GetFileSystemsArgs, opts ...pulumi.InvokeOption) (*GetFileSystemsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetFileSystemsResult
	err := ctx.Invoke("tencentcloud:Cfs/getFileSystems:getFileSystems", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFileSystems.
type GetFileSystemsArgs struct {
	AvailabilityZone *string `pulumi:"availabilityZone"`
	FileSystemId     *string `pulumi:"fileSystemId"`
	Name             *string `pulumi:"name"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	SubnetId         *string `pulumi:"subnetId"`
	VpcId            *string `pulumi:"vpcId"`
}

// A collection of values returned by getFileSystems.
type GetFileSystemsResult struct {
	AvailabilityZone *string                        `pulumi:"availabilityZone"`
	FileSystemId     *string                        `pulumi:"fileSystemId"`
	FileSystemLists  []GetFileSystemsFileSystemList `pulumi:"fileSystemLists"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	Name             *string `pulumi:"name"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	SubnetId         *string `pulumi:"subnetId"`
	VpcId            *string `pulumi:"vpcId"`
}

func GetFileSystemsOutput(ctx *pulumi.Context, args GetFileSystemsOutputArgs, opts ...pulumi.InvokeOption) GetFileSystemsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetFileSystemsResult, error) {
			args := v.(GetFileSystemsArgs)
			r, err := GetFileSystems(ctx, &args, opts...)
			var s GetFileSystemsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetFileSystemsResultOutput)
}

// A collection of arguments for invoking getFileSystems.
type GetFileSystemsOutputArgs struct {
	AvailabilityZone pulumi.StringPtrInput `pulumi:"availabilityZone"`
	FileSystemId     pulumi.StringPtrInput `pulumi:"fileSystemId"`
	Name             pulumi.StringPtrInput `pulumi:"name"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	SubnetId         pulumi.StringPtrInput `pulumi:"subnetId"`
	VpcId            pulumi.StringPtrInput `pulumi:"vpcId"`
}

func (GetFileSystemsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFileSystemsArgs)(nil)).Elem()
}

// A collection of values returned by getFileSystems.
type GetFileSystemsResultOutput struct{ *pulumi.OutputState }

func (GetFileSystemsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFileSystemsResult)(nil)).Elem()
}

func (o GetFileSystemsResultOutput) ToGetFileSystemsResultOutput() GetFileSystemsResultOutput {
	return o
}

func (o GetFileSystemsResultOutput) ToGetFileSystemsResultOutputWithContext(ctx context.Context) GetFileSystemsResultOutput {
	return o
}

func (o GetFileSystemsResultOutput) AvailabilityZone() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFileSystemsResult) *string { return v.AvailabilityZone }).(pulumi.StringPtrOutput)
}

func (o GetFileSystemsResultOutput) FileSystemId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFileSystemsResult) *string { return v.FileSystemId }).(pulumi.StringPtrOutput)
}

func (o GetFileSystemsResultOutput) FileSystemLists() GetFileSystemsFileSystemListArrayOutput {
	return o.ApplyT(func(v GetFileSystemsResult) []GetFileSystemsFileSystemList { return v.FileSystemLists }).(GetFileSystemsFileSystemListArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetFileSystemsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetFileSystemsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetFileSystemsResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFileSystemsResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o GetFileSystemsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFileSystemsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetFileSystemsResultOutput) SubnetId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFileSystemsResult) *string { return v.SubnetId }).(pulumi.StringPtrOutput)
}

func (o GetFileSystemsResultOutput) VpcId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFileSystemsResult) *string { return v.VpcId }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetFileSystemsResultOutput{})
}
