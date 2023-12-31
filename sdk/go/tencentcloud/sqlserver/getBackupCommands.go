// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sqlserver

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetBackupCommands(ctx *pulumi.Context, args *GetBackupCommandsArgs, opts ...pulumi.InvokeOption) (*GetBackupCommandsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetBackupCommandsResult
	err := ctx.Invoke("tencentcloud:Sqlserver/getBackupCommands:getBackupCommands", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBackupCommands.
type GetBackupCommandsArgs struct {
	BackupFileType   string  `pulumi:"backupFileType"`
	DataBaseName     string  `pulumi:"dataBaseName"`
	IsRecovery       string  `pulumi:"isRecovery"`
	LocalPath        *string `pulumi:"localPath"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getBackupCommands.
type GetBackupCommandsResult struct {
	BackupFileType string `pulumi:"backupFileType"`
	DataBaseName   string `pulumi:"dataBaseName"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                  `pulumi:"id"`
	IsRecovery       string                  `pulumi:"isRecovery"`
	Lists            []GetBackupCommandsList `pulumi:"lists"`
	LocalPath        *string                 `pulumi:"localPath"`
	ResultOutputFile *string                 `pulumi:"resultOutputFile"`
}

func GetBackupCommandsOutput(ctx *pulumi.Context, args GetBackupCommandsOutputArgs, opts ...pulumi.InvokeOption) GetBackupCommandsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBackupCommandsResult, error) {
			args := v.(GetBackupCommandsArgs)
			r, err := GetBackupCommands(ctx, &args, opts...)
			var s GetBackupCommandsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetBackupCommandsResultOutput)
}

// A collection of arguments for invoking getBackupCommands.
type GetBackupCommandsOutputArgs struct {
	BackupFileType   pulumi.StringInput    `pulumi:"backupFileType"`
	DataBaseName     pulumi.StringInput    `pulumi:"dataBaseName"`
	IsRecovery       pulumi.StringInput    `pulumi:"isRecovery"`
	LocalPath        pulumi.StringPtrInput `pulumi:"localPath"`
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetBackupCommandsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupCommandsArgs)(nil)).Elem()
}

// A collection of values returned by getBackupCommands.
type GetBackupCommandsResultOutput struct{ *pulumi.OutputState }

func (GetBackupCommandsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupCommandsResult)(nil)).Elem()
}

func (o GetBackupCommandsResultOutput) ToGetBackupCommandsResultOutput() GetBackupCommandsResultOutput {
	return o
}

func (o GetBackupCommandsResultOutput) ToGetBackupCommandsResultOutputWithContext(ctx context.Context) GetBackupCommandsResultOutput {
	return o
}

func (o GetBackupCommandsResultOutput) BackupFileType() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupCommandsResult) string { return v.BackupFileType }).(pulumi.StringOutput)
}

func (o GetBackupCommandsResultOutput) DataBaseName() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupCommandsResult) string { return v.DataBaseName }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetBackupCommandsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupCommandsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetBackupCommandsResultOutput) IsRecovery() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupCommandsResult) string { return v.IsRecovery }).(pulumi.StringOutput)
}

func (o GetBackupCommandsResultOutput) Lists() GetBackupCommandsListArrayOutput {
	return o.ApplyT(func(v GetBackupCommandsResult) []GetBackupCommandsList { return v.Lists }).(GetBackupCommandsListArrayOutput)
}

func (o GetBackupCommandsResultOutput) LocalPath() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupCommandsResult) *string { return v.LocalPath }).(pulumi.StringPtrOutput)
}

func (o GetBackupCommandsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupCommandsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBackupCommandsResultOutput{})
}
