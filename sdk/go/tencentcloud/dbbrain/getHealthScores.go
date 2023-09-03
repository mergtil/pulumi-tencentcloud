// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dbbrain

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetHealthScores(ctx *pulumi.Context, args *GetHealthScoresArgs, opts ...pulumi.InvokeOption) (*GetHealthScoresResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetHealthScoresResult
	err := ctx.Invoke("tencentcloud:Dbbrain/getHealthScores:getHealthScores", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getHealthScores.
type GetHealthScoresArgs struct {
	InstanceId       string  `pulumi:"instanceId"`
	Product          string  `pulumi:"product"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	Time             string  `pulumi:"time"`
}

// A collection of values returned by getHealthScores.
type GetHealthScoresResult struct {
	Datas []GetHealthScoresData `pulumi:"datas"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	Product          string  `pulumi:"product"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	Time             string  `pulumi:"time"`
}

func GetHealthScoresOutput(ctx *pulumi.Context, args GetHealthScoresOutputArgs, opts ...pulumi.InvokeOption) GetHealthScoresResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetHealthScoresResult, error) {
			args := v.(GetHealthScoresArgs)
			r, err := GetHealthScores(ctx, &args, opts...)
			var s GetHealthScoresResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetHealthScoresResultOutput)
}

// A collection of arguments for invoking getHealthScores.
type GetHealthScoresOutputArgs struct {
	InstanceId       pulumi.StringInput    `pulumi:"instanceId"`
	Product          pulumi.StringInput    `pulumi:"product"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	Time             pulumi.StringInput    `pulumi:"time"`
}

func (GetHealthScoresOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetHealthScoresArgs)(nil)).Elem()
}

// A collection of values returned by getHealthScores.
type GetHealthScoresResultOutput struct{ *pulumi.OutputState }

func (GetHealthScoresResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetHealthScoresResult)(nil)).Elem()
}

func (o GetHealthScoresResultOutput) ToGetHealthScoresResultOutput() GetHealthScoresResultOutput {
	return o
}

func (o GetHealthScoresResultOutput) ToGetHealthScoresResultOutputWithContext(ctx context.Context) GetHealthScoresResultOutput {
	return o
}

func (o GetHealthScoresResultOutput) Datas() GetHealthScoresDataArrayOutput {
	return o.ApplyT(func(v GetHealthScoresResult) []GetHealthScoresData { return v.Datas }).(GetHealthScoresDataArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetHealthScoresResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetHealthScoresResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetHealthScoresResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetHealthScoresResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetHealthScoresResultOutput) Product() pulumi.StringOutput {
	return o.ApplyT(func(v GetHealthScoresResult) string { return v.Product }).(pulumi.StringOutput)
}

func (o GetHealthScoresResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetHealthScoresResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetHealthScoresResultOutput) Time() pulumi.StringOutput {
	return o.ApplyT(func(v GetHealthScoresResult) string { return v.Time }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetHealthScoresResultOutput{})
}