// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cynosdb

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetDescribeInstanceSlowQueries(ctx *pulumi.Context, args *GetDescribeInstanceSlowQueriesArgs, opts ...pulumi.InvokeOption) (*GetDescribeInstanceSlowQueriesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetDescribeInstanceSlowQueriesResult
	err := ctx.Invoke("tencentcloud:Cynosdb/getDescribeInstanceSlowQueries:getDescribeInstanceSlowQueries", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getDescribeInstanceSlowQueries.
type GetDescribeInstanceSlowQueriesArgs struct {
	ClusterId        string  `pulumi:"clusterId"`
	EndTime          *string `pulumi:"endTime"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	StartTime        *string `pulumi:"startTime"`
}

// A collection of values returned by getDescribeInstanceSlowQueries.
type GetDescribeInstanceSlowQueriesResult struct {
	Binlogs   []GetDescribeInstanceSlowQueriesBinlog `pulumi:"binlogs"`
	ClusterId string                                 `pulumi:"clusterId"`
	EndTime   *string                                `pulumi:"endTime"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	StartTime        *string `pulumi:"startTime"`
}

func GetDescribeInstanceSlowQueriesOutput(ctx *pulumi.Context, args GetDescribeInstanceSlowQueriesOutputArgs, opts ...pulumi.InvokeOption) GetDescribeInstanceSlowQueriesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetDescribeInstanceSlowQueriesResult, error) {
			args := v.(GetDescribeInstanceSlowQueriesArgs)
			r, err := GetDescribeInstanceSlowQueries(ctx, &args, opts...)
			var s GetDescribeInstanceSlowQueriesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetDescribeInstanceSlowQueriesResultOutput)
}

// A collection of arguments for invoking getDescribeInstanceSlowQueries.
type GetDescribeInstanceSlowQueriesOutputArgs struct {
	ClusterId        pulumi.StringInput    `pulumi:"clusterId"`
	EndTime          pulumi.StringPtrInput `pulumi:"endTime"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	StartTime        pulumi.StringPtrInput `pulumi:"startTime"`
}

func (GetDescribeInstanceSlowQueriesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDescribeInstanceSlowQueriesArgs)(nil)).Elem()
}

// A collection of values returned by getDescribeInstanceSlowQueries.
type GetDescribeInstanceSlowQueriesResultOutput struct{ *pulumi.OutputState }

func (GetDescribeInstanceSlowQueriesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDescribeInstanceSlowQueriesResult)(nil)).Elem()
}

func (o GetDescribeInstanceSlowQueriesResultOutput) ToGetDescribeInstanceSlowQueriesResultOutput() GetDescribeInstanceSlowQueriesResultOutput {
	return o
}

func (o GetDescribeInstanceSlowQueriesResultOutput) ToGetDescribeInstanceSlowQueriesResultOutputWithContext(ctx context.Context) GetDescribeInstanceSlowQueriesResultOutput {
	return o
}

func (o GetDescribeInstanceSlowQueriesResultOutput) Binlogs() GetDescribeInstanceSlowQueriesBinlogArrayOutput {
	return o.ApplyT(func(v GetDescribeInstanceSlowQueriesResult) []GetDescribeInstanceSlowQueriesBinlog { return v.Binlogs }).(GetDescribeInstanceSlowQueriesBinlogArrayOutput)
}

func (o GetDescribeInstanceSlowQueriesResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v GetDescribeInstanceSlowQueriesResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o GetDescribeInstanceSlowQueriesResultOutput) EndTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetDescribeInstanceSlowQueriesResult) *string { return v.EndTime }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetDescribeInstanceSlowQueriesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetDescribeInstanceSlowQueriesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetDescribeInstanceSlowQueriesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetDescribeInstanceSlowQueriesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetDescribeInstanceSlowQueriesResultOutput) StartTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetDescribeInstanceSlowQueriesResult) *string { return v.StartTime }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetDescribeInstanceSlowQueriesResultOutput{})
}