// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sqlserver

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetBackupByFlowId(ctx *pulumi.Context, args *GetBackupByFlowIdArgs, opts ...pulumi.InvokeOption) (*GetBackupByFlowIdResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetBackupByFlowIdResult
	err := ctx.Invoke("tencentcloud:Sqlserver/getBackupByFlowId:getBackupByFlowId", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBackupByFlowId.
type GetBackupByFlowIdArgs struct {
	FlowId           string  `pulumi:"flowId"`
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getBackupByFlowId.
type GetBackupByFlowIdResult struct {
	BackupName   string   `pulumi:"backupName"`
	BackupWay    int      `pulumi:"backupWay"`
	Dbs          []string `pulumi:"dbs"`
	EndTime      string   `pulumi:"endTime"`
	ExternalAddr string   `pulumi:"externalAddr"`
	FileName     string   `pulumi:"fileName"`
	FlowId       string   `pulumi:"flowId"`
	GroupId      string   `pulumi:"groupId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	InternalAddr     string  `pulumi:"internalAddr"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	StartTime        string  `pulumi:"startTime"`
	Status           int     `pulumi:"status"`
	Strategy         int     `pulumi:"strategy"`
}

func GetBackupByFlowIdOutput(ctx *pulumi.Context, args GetBackupByFlowIdOutputArgs, opts ...pulumi.InvokeOption) GetBackupByFlowIdResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBackupByFlowIdResult, error) {
			args := v.(GetBackupByFlowIdArgs)
			r, err := GetBackupByFlowId(ctx, &args, opts...)
			var s GetBackupByFlowIdResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetBackupByFlowIdResultOutput)
}

// A collection of arguments for invoking getBackupByFlowId.
type GetBackupByFlowIdOutputArgs struct {
	FlowId           pulumi.StringInput    `pulumi:"flowId"`
	InstanceId       pulumi.StringInput    `pulumi:"instanceId"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetBackupByFlowIdOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupByFlowIdArgs)(nil)).Elem()
}

// A collection of values returned by getBackupByFlowId.
type GetBackupByFlowIdResultOutput struct{ *pulumi.OutputState }

func (GetBackupByFlowIdResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupByFlowIdResult)(nil)).Elem()
}

func (o GetBackupByFlowIdResultOutput) ToGetBackupByFlowIdResultOutput() GetBackupByFlowIdResultOutput {
	return o
}

func (o GetBackupByFlowIdResultOutput) ToGetBackupByFlowIdResultOutputWithContext(ctx context.Context) GetBackupByFlowIdResultOutput {
	return o
}

func (o GetBackupByFlowIdResultOutput) BackupName() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.BackupName }).(pulumi.StringOutput)
}

func (o GetBackupByFlowIdResultOutput) BackupWay() pulumi.IntOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) int { return v.BackupWay }).(pulumi.IntOutput)
}

func (o GetBackupByFlowIdResultOutput) Dbs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) []string { return v.Dbs }).(pulumi.StringArrayOutput)
}

func (o GetBackupByFlowIdResultOutput) EndTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.EndTime }).(pulumi.StringOutput)
}

func (o GetBackupByFlowIdResultOutput) ExternalAddr() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.ExternalAddr }).(pulumi.StringOutput)
}

func (o GetBackupByFlowIdResultOutput) FileName() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.FileName }).(pulumi.StringOutput)
}

func (o GetBackupByFlowIdResultOutput) FlowId() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.FlowId }).(pulumi.StringOutput)
}

func (o GetBackupByFlowIdResultOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.GroupId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetBackupByFlowIdResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetBackupByFlowIdResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetBackupByFlowIdResultOutput) InternalAddr() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.InternalAddr }).(pulumi.StringOutput)
}

func (o GetBackupByFlowIdResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetBackupByFlowIdResultOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) string { return v.StartTime }).(pulumi.StringOutput)
}

func (o GetBackupByFlowIdResultOutput) Status() pulumi.IntOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) int { return v.Status }).(pulumi.IntOutput)
}

func (o GetBackupByFlowIdResultOutput) Strategy() pulumi.IntOutput {
	return o.ApplyT(func(v GetBackupByFlowIdResult) int { return v.Strategy }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBackupByFlowIdResultOutput{})
}
