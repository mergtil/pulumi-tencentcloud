// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dcdb

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetLogFiles(ctx *pulumi.Context, args *GetLogFilesArgs, opts ...pulumi.InvokeOption) (*GetLogFilesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetLogFilesResult
	err := ctx.Invoke("tencentcloud:Dcdb/getLogFiles:getLogFiles", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getLogFiles.
type GetLogFilesArgs struct {
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	ShardId          string  `pulumi:"shardId"`
	Type             int     `pulumi:"type"`
}

// A collection of values returned by getLogFiles.
type GetLogFilesResult struct {
	Files []GetLogFilesFile `pulumi:"files"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	NormalPrefix     string  `pulumi:"normalPrefix"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	ShardId          string  `pulumi:"shardId"`
	Type             int     `pulumi:"type"`
	VpcPrefix        string  `pulumi:"vpcPrefix"`
}

func GetLogFilesOutput(ctx *pulumi.Context, args GetLogFilesOutputArgs, opts ...pulumi.InvokeOption) GetLogFilesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetLogFilesResult, error) {
			args := v.(GetLogFilesArgs)
			r, err := GetLogFiles(ctx, &args, opts...)
			var s GetLogFilesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetLogFilesResultOutput)
}

// A collection of arguments for invoking getLogFiles.
type GetLogFilesOutputArgs struct {
	InstanceId       pulumi.StringInput    `pulumi:"instanceId"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	ShardId          pulumi.StringInput    `pulumi:"shardId"`
	Type             pulumi.IntInput       `pulumi:"type"`
}

func (GetLogFilesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetLogFilesArgs)(nil)).Elem()
}

// A collection of values returned by getLogFiles.
type GetLogFilesResultOutput struct{ *pulumi.OutputState }

func (GetLogFilesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetLogFilesResult)(nil)).Elem()
}

func (o GetLogFilesResultOutput) ToGetLogFilesResultOutput() GetLogFilesResultOutput {
	return o
}

func (o GetLogFilesResultOutput) ToGetLogFilesResultOutputWithContext(ctx context.Context) GetLogFilesResultOutput {
	return o
}

func (o GetLogFilesResultOutput) Files() GetLogFilesFileArrayOutput {
	return o.ApplyT(func(v GetLogFilesResult) []GetLogFilesFile { return v.Files }).(GetLogFilesFileArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetLogFilesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetLogFilesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetLogFilesResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetLogFilesResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetLogFilesResultOutput) NormalPrefix() pulumi.StringOutput {
	return o.ApplyT(func(v GetLogFilesResult) string { return v.NormalPrefix }).(pulumi.StringOutput)
}

func (o GetLogFilesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetLogFilesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetLogFilesResultOutput) ShardId() pulumi.StringOutput {
	return o.ApplyT(func(v GetLogFilesResult) string { return v.ShardId }).(pulumi.StringOutput)
}

func (o GetLogFilesResultOutput) Type() pulumi.IntOutput {
	return o.ApplyT(func(v GetLogFilesResult) int { return v.Type }).(pulumi.IntOutput)
}

func (o GetLogFilesResultOutput) VpcPrefix() pulumi.StringOutput {
	return o.ApplyT(func(v GetLogFilesResult) string { return v.VpcPrefix }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetLogFilesResultOutput{})
}
