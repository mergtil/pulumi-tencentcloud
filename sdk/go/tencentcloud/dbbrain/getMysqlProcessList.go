// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dbbrain

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetMysqlProcessList(ctx *pulumi.Context, args *GetMysqlProcessListArgs, opts ...pulumi.InvokeOption) (*GetMysqlProcessListResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetMysqlProcessListResult
	err := ctx.Invoke("tencentcloud:Dbbrain/getMysqlProcessList:getMysqlProcessList", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMysqlProcessList.
type GetMysqlProcessListArgs struct {
	Command          *string `pulumi:"command"`
	Db               *string `pulumi:"db"`
	Host             *string `pulumi:"host"`
	Id               *int    `pulumi:"id"`
	Info             *string `pulumi:"info"`
	InstanceId       string  `pulumi:"instanceId"`
	Product          *string `pulumi:"product"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	State            *string `pulumi:"state"`
	Time             *int    `pulumi:"time"`
	User             *string `pulumi:"user"`
}

// A collection of values returned by getMysqlProcessList.
type GetMysqlProcessListResult struct {
	Command          *string                          `pulumi:"command"`
	Db               *string                          `pulumi:"db"`
	Host             *string                          `pulumi:"host"`
	Id               *int                             `pulumi:"id"`
	Info             *string                          `pulumi:"info"`
	InstanceId       string                           `pulumi:"instanceId"`
	ProcessLists     []GetMysqlProcessListProcessList `pulumi:"processLists"`
	Product          *string                          `pulumi:"product"`
	ResultOutputFile *string                          `pulumi:"resultOutputFile"`
	State            *string                          `pulumi:"state"`
	Time             *int                             `pulumi:"time"`
	User             *string                          `pulumi:"user"`
}

func GetMysqlProcessListOutput(ctx *pulumi.Context, args GetMysqlProcessListOutputArgs, opts ...pulumi.InvokeOption) GetMysqlProcessListResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetMysqlProcessListResult, error) {
			args := v.(GetMysqlProcessListArgs)
			r, err := GetMysqlProcessList(ctx, &args, opts...)
			var s GetMysqlProcessListResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetMysqlProcessListResultOutput)
}

// A collection of arguments for invoking getMysqlProcessList.
type GetMysqlProcessListOutputArgs struct {
	Command          pulumi.StringPtrInput `pulumi:"command"`
	Db               pulumi.StringPtrInput `pulumi:"db"`
	Host             pulumi.StringPtrInput `pulumi:"host"`
	Id               pulumi.IntPtrInput    `pulumi:"id"`
	Info             pulumi.StringPtrInput `pulumi:"info"`
	InstanceId       pulumi.StringInput    `pulumi:"instanceId"`
	Product          pulumi.StringPtrInput `pulumi:"product"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	State            pulumi.StringPtrInput `pulumi:"state"`
	Time             pulumi.IntPtrInput    `pulumi:"time"`
	User             pulumi.StringPtrInput `pulumi:"user"`
}

func (GetMysqlProcessListOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMysqlProcessListArgs)(nil)).Elem()
}

// A collection of values returned by getMysqlProcessList.
type GetMysqlProcessListResultOutput struct{ *pulumi.OutputState }

func (GetMysqlProcessListResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMysqlProcessListResult)(nil)).Elem()
}

func (o GetMysqlProcessListResultOutput) ToGetMysqlProcessListResultOutput() GetMysqlProcessListResultOutput {
	return o
}

func (o GetMysqlProcessListResultOutput) ToGetMysqlProcessListResultOutputWithContext(ctx context.Context) GetMysqlProcessListResultOutput {
	return o
}

func (o GetMysqlProcessListResultOutput) Command() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *string { return v.Command }).(pulumi.StringPtrOutput)
}

func (o GetMysqlProcessListResultOutput) Db() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *string { return v.Db }).(pulumi.StringPtrOutput)
}

func (o GetMysqlProcessListResultOutput) Host() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *string { return v.Host }).(pulumi.StringPtrOutput)
}

func (o GetMysqlProcessListResultOutput) Id() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *int { return v.Id }).(pulumi.IntPtrOutput)
}

func (o GetMysqlProcessListResultOutput) Info() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *string { return v.Info }).(pulumi.StringPtrOutput)
}

func (o GetMysqlProcessListResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetMysqlProcessListResultOutput) ProcessLists() GetMysqlProcessListProcessListArrayOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) []GetMysqlProcessListProcessList { return v.ProcessLists }).(GetMysqlProcessListProcessListArrayOutput)
}

func (o GetMysqlProcessListResultOutput) Product() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *string { return v.Product }).(pulumi.StringPtrOutput)
}

func (o GetMysqlProcessListResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetMysqlProcessListResultOutput) State() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *string { return v.State }).(pulumi.StringPtrOutput)
}

func (o GetMysqlProcessListResultOutput) Time() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *int { return v.Time }).(pulumi.IntPtrOutput)
}

func (o GetMysqlProcessListResultOutput) User() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMysqlProcessListResult) *string { return v.User }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetMysqlProcessListResultOutput{})
}
