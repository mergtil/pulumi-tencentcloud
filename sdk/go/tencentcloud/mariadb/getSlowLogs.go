// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mariadb

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetSlowLogs(ctx *pulumi.Context, args *GetSlowLogsArgs, opts ...pulumi.InvokeOption) (*GetSlowLogsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSlowLogsResult
	err := ctx.Invoke("tencentcloud:Mariadb/getSlowLogs:getSlowLogs", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSlowLogs.
type GetSlowLogsArgs struct {
	Db               *string `pulumi:"db"`
	EndTime          *string `pulumi:"endTime"`
	InstanceId       string  `pulumi:"instanceId"`
	OrderBy          *string `pulumi:"orderBy"`
	OrderByType      *string `pulumi:"orderByType"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	Slave            *int    `pulumi:"slave"`
	StartTime        string  `pulumi:"startTime"`
}

// A collection of values returned by getSlowLogs.
type GetSlowLogsResult struct {
	Datas   []GetSlowLogsData `pulumi:"datas"`
	Db      *string           `pulumi:"db"`
	EndTime *string           `pulumi:"endTime"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	LockTimeSum      float64 `pulumi:"lockTimeSum"`
	OrderBy          *string `pulumi:"orderBy"`
	OrderByType      *string `pulumi:"orderByType"`
	QueryCount       int     `pulumi:"queryCount"`
	QueryTimeSum     float64 `pulumi:"queryTimeSum"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	Slave            *int    `pulumi:"slave"`
	StartTime        string  `pulumi:"startTime"`
}

func GetSlowLogsOutput(ctx *pulumi.Context, args GetSlowLogsOutputArgs, opts ...pulumi.InvokeOption) GetSlowLogsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetSlowLogsResult, error) {
			args := v.(GetSlowLogsArgs)
			r, err := GetSlowLogs(ctx, &args, opts...)
			var s GetSlowLogsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetSlowLogsResultOutput)
}

// A collection of arguments for invoking getSlowLogs.
type GetSlowLogsOutputArgs struct {
	Db               pulumi.StringPtrInput `pulumi:"db"`
	EndTime          pulumi.StringPtrInput `pulumi:"endTime"`
	InstanceId       pulumi.StringInput    `pulumi:"instanceId"`
	OrderBy          pulumi.StringPtrInput `pulumi:"orderBy"`
	OrderByType      pulumi.StringPtrInput `pulumi:"orderByType"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	Slave            pulumi.IntPtrInput    `pulumi:"slave"`
	StartTime        pulumi.StringInput    `pulumi:"startTime"`
}

func (GetSlowLogsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSlowLogsArgs)(nil)).Elem()
}

// A collection of values returned by getSlowLogs.
type GetSlowLogsResultOutput struct{ *pulumi.OutputState }

func (GetSlowLogsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSlowLogsResult)(nil)).Elem()
}

func (o GetSlowLogsResultOutput) ToGetSlowLogsResultOutput() GetSlowLogsResultOutput {
	return o
}

func (o GetSlowLogsResultOutput) ToGetSlowLogsResultOutputWithContext(ctx context.Context) GetSlowLogsResultOutput {
	return o
}

func (o GetSlowLogsResultOutput) Datas() GetSlowLogsDataArrayOutput {
	return o.ApplyT(func(v GetSlowLogsResult) []GetSlowLogsData { return v.Datas }).(GetSlowLogsDataArrayOutput)
}

func (o GetSlowLogsResultOutput) Db() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSlowLogsResult) *string { return v.Db }).(pulumi.StringPtrOutput)
}

func (o GetSlowLogsResultOutput) EndTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSlowLogsResult) *string { return v.EndTime }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetSlowLogsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetSlowLogsResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogsResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetSlowLogsResultOutput) LockTimeSum() pulumi.Float64Output {
	return o.ApplyT(func(v GetSlowLogsResult) float64 { return v.LockTimeSum }).(pulumi.Float64Output)
}

func (o GetSlowLogsResultOutput) OrderBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSlowLogsResult) *string { return v.OrderBy }).(pulumi.StringPtrOutput)
}

func (o GetSlowLogsResultOutput) OrderByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSlowLogsResult) *string { return v.OrderByType }).(pulumi.StringPtrOutput)
}

func (o GetSlowLogsResultOutput) QueryCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetSlowLogsResult) int { return v.QueryCount }).(pulumi.IntOutput)
}

func (o GetSlowLogsResultOutput) QueryTimeSum() pulumi.Float64Output {
	return o.ApplyT(func(v GetSlowLogsResult) float64 { return v.QueryTimeSum }).(pulumi.Float64Output)
}

func (o GetSlowLogsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSlowLogsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetSlowLogsResultOutput) Slave() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetSlowLogsResult) *int { return v.Slave }).(pulumi.IntPtrOutput)
}

func (o GetSlowLogsResultOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogsResult) string { return v.StartTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSlowLogsResultOutput{})
}
