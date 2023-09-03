// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sqlserver

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetInsAttribute(ctx *pulumi.Context, args *GetInsAttributeArgs, opts ...pulumi.InvokeOption) (*GetInsAttributeResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetInsAttributeResult
	err := ctx.Invoke("tencentcloud:Sqlserver/getInsAttribute:getInsAttribute", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getInsAttribute.
type GetInsAttributeArgs struct {
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getInsAttribute.
type GetInsAttributeResult struct {
	BlockedThreshold int `pulumi:"blockedThreshold"`
	EventSaveDays    int `pulumi:"eventSaveDays"`
	// The provider-assigned unique ID for this managed resource.
	Id                     string                     `pulumi:"id"`
	InstanceId             string                     `pulumi:"instanceId"`
	RegularBackupCounts    int                        `pulumi:"regularBackupCounts"`
	RegularBackupEnable    string                     `pulumi:"regularBackupEnable"`
	RegularBackupSaveDays  int                        `pulumi:"regularBackupSaveDays"`
	RegularBackupStartTime string                     `pulumi:"regularBackupStartTime"`
	RegularBackupStrategy  string                     `pulumi:"regularBackupStrategy"`
	ResultOutputFile       *string                    `pulumi:"resultOutputFile"`
	TdeConfigs             []GetInsAttributeTdeConfig `pulumi:"tdeConfigs"`
}

func GetInsAttributeOutput(ctx *pulumi.Context, args GetInsAttributeOutputArgs, opts ...pulumi.InvokeOption) GetInsAttributeResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetInsAttributeResult, error) {
			args := v.(GetInsAttributeArgs)
			r, err := GetInsAttribute(ctx, &args, opts...)
			var s GetInsAttributeResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetInsAttributeResultOutput)
}

// A collection of arguments for invoking getInsAttribute.
type GetInsAttributeOutputArgs struct {
	InstanceId       pulumi.StringInput    `pulumi:"instanceId"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetInsAttributeOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInsAttributeArgs)(nil)).Elem()
}

// A collection of values returned by getInsAttribute.
type GetInsAttributeResultOutput struct{ *pulumi.OutputState }

func (GetInsAttributeResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInsAttributeResult)(nil)).Elem()
}

func (o GetInsAttributeResultOutput) ToGetInsAttributeResultOutput() GetInsAttributeResultOutput {
	return o
}

func (o GetInsAttributeResultOutput) ToGetInsAttributeResultOutputWithContext(ctx context.Context) GetInsAttributeResultOutput {
	return o
}

func (o GetInsAttributeResultOutput) BlockedThreshold() pulumi.IntOutput {
	return o.ApplyT(func(v GetInsAttributeResult) int { return v.BlockedThreshold }).(pulumi.IntOutput)
}

func (o GetInsAttributeResultOutput) EventSaveDays() pulumi.IntOutput {
	return o.ApplyT(func(v GetInsAttributeResult) int { return v.EventSaveDays }).(pulumi.IntOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetInsAttributeResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetInsAttributeResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetInsAttributeResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetInsAttributeResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetInsAttributeResultOutput) RegularBackupCounts() pulumi.IntOutput {
	return o.ApplyT(func(v GetInsAttributeResult) int { return v.RegularBackupCounts }).(pulumi.IntOutput)
}

func (o GetInsAttributeResultOutput) RegularBackupEnable() pulumi.StringOutput {
	return o.ApplyT(func(v GetInsAttributeResult) string { return v.RegularBackupEnable }).(pulumi.StringOutput)
}

func (o GetInsAttributeResultOutput) RegularBackupSaveDays() pulumi.IntOutput {
	return o.ApplyT(func(v GetInsAttributeResult) int { return v.RegularBackupSaveDays }).(pulumi.IntOutput)
}

func (o GetInsAttributeResultOutput) RegularBackupStartTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetInsAttributeResult) string { return v.RegularBackupStartTime }).(pulumi.StringOutput)
}

func (o GetInsAttributeResultOutput) RegularBackupStrategy() pulumi.StringOutput {
	return o.ApplyT(func(v GetInsAttributeResult) string { return v.RegularBackupStrategy }).(pulumi.StringOutput)
}

func (o GetInsAttributeResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInsAttributeResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetInsAttributeResultOutput) TdeConfigs() GetInsAttributeTdeConfigArrayOutput {
	return o.ApplyT(func(v GetInsAttributeResult) []GetInsAttributeTdeConfig { return v.TdeConfigs }).(GetInsAttributeTdeConfigArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetInsAttributeResultOutput{})
}