// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dts

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetMigrateJobs(ctx *pulumi.Context, args *GetMigrateJobsArgs, opts ...pulumi.InvokeOption) (*GetMigrateJobsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetMigrateJobsResult
	err := ctx.Invoke("tencentcloud:Dts/getMigrateJobs:getMigrateJobs", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMigrateJobs.
type GetMigrateJobsArgs struct {
	DstAccessTypes   []string                  `pulumi:"dstAccessTypes"`
	DstDatabaseTypes []string                  `pulumi:"dstDatabaseTypes"`
	DstInstanceId    *string                   `pulumi:"dstInstanceId"`
	DstRegion        *string                   `pulumi:"dstRegion"`
	JobId            *string                   `pulumi:"jobId"`
	JobName          *string                   `pulumi:"jobName"`
	OrderSeq         *string                   `pulumi:"orderSeq"`
	ResultOutputFile *string                   `pulumi:"resultOutputFile"`
	RunMode          *string                   `pulumi:"runMode"`
	SrcAccessTypes   []string                  `pulumi:"srcAccessTypes"`
	SrcDatabaseTypes []string                  `pulumi:"srcDatabaseTypes"`
	SrcInstanceId    *string                   `pulumi:"srcInstanceId"`
	SrcRegion        *string                   `pulumi:"srcRegion"`
	Statuses         []string                  `pulumi:"statuses"`
	TagFilters       []GetMigrateJobsTagFilter `pulumi:"tagFilters"`
}

// A collection of values returned by getMigrateJobs.
type GetMigrateJobsResult struct {
	DstAccessTypes   []string `pulumi:"dstAccessTypes"`
	DstDatabaseTypes []string `pulumi:"dstDatabaseTypes"`
	DstInstanceId    *string  `pulumi:"dstInstanceId"`
	DstRegion        *string  `pulumi:"dstRegion"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                    `pulumi:"id"`
	JobId            *string                   `pulumi:"jobId"`
	JobName          *string                   `pulumi:"jobName"`
	Lists            []GetMigrateJobsList      `pulumi:"lists"`
	OrderSeq         *string                   `pulumi:"orderSeq"`
	ResultOutputFile *string                   `pulumi:"resultOutputFile"`
	RunMode          *string                   `pulumi:"runMode"`
	SrcAccessTypes   []string                  `pulumi:"srcAccessTypes"`
	SrcDatabaseTypes []string                  `pulumi:"srcDatabaseTypes"`
	SrcInstanceId    *string                   `pulumi:"srcInstanceId"`
	SrcRegion        *string                   `pulumi:"srcRegion"`
	Statuses         []string                  `pulumi:"statuses"`
	TagFilters       []GetMigrateJobsTagFilter `pulumi:"tagFilters"`
}

func GetMigrateJobsOutput(ctx *pulumi.Context, args GetMigrateJobsOutputArgs, opts ...pulumi.InvokeOption) GetMigrateJobsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetMigrateJobsResult, error) {
			args := v.(GetMigrateJobsArgs)
			r, err := GetMigrateJobs(ctx, &args, opts...)
			var s GetMigrateJobsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetMigrateJobsResultOutput)
}

// A collection of arguments for invoking getMigrateJobs.
type GetMigrateJobsOutputArgs struct {
	DstAccessTypes   pulumi.StringArrayInput           `pulumi:"dstAccessTypes"`
	DstDatabaseTypes pulumi.StringArrayInput           `pulumi:"dstDatabaseTypes"`
	DstInstanceId    pulumi.StringPtrInput             `pulumi:"dstInstanceId"`
	DstRegion        pulumi.StringPtrInput             `pulumi:"dstRegion"`
	JobId            pulumi.StringPtrInput             `pulumi:"jobId"`
	JobName          pulumi.StringPtrInput             `pulumi:"jobName"`
	OrderSeq         pulumi.StringPtrInput             `pulumi:"orderSeq"`
	ResultOutputFile pulumi.StringPtrInput             `pulumi:"resultOutputFile"`
	RunMode          pulumi.StringPtrInput             `pulumi:"runMode"`
	SrcAccessTypes   pulumi.StringArrayInput           `pulumi:"srcAccessTypes"`
	SrcDatabaseTypes pulumi.StringArrayInput           `pulumi:"srcDatabaseTypes"`
	SrcInstanceId    pulumi.StringPtrInput             `pulumi:"srcInstanceId"`
	SrcRegion        pulumi.StringPtrInput             `pulumi:"srcRegion"`
	Statuses         pulumi.StringArrayInput           `pulumi:"statuses"`
	TagFilters       GetMigrateJobsTagFilterArrayInput `pulumi:"tagFilters"`
}

func (GetMigrateJobsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMigrateJobsArgs)(nil)).Elem()
}

// A collection of values returned by getMigrateJobs.
type GetMigrateJobsResultOutput struct{ *pulumi.OutputState }

func (GetMigrateJobsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMigrateJobsResult)(nil)).Elem()
}

func (o GetMigrateJobsResultOutput) ToGetMigrateJobsResultOutput() GetMigrateJobsResultOutput {
	return o
}

func (o GetMigrateJobsResultOutput) ToGetMigrateJobsResultOutputWithContext(ctx context.Context) GetMigrateJobsResultOutput {
	return o
}

func (o GetMigrateJobsResultOutput) DstAccessTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) []string { return v.DstAccessTypes }).(pulumi.StringArrayOutput)
}

func (o GetMigrateJobsResultOutput) DstDatabaseTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) []string { return v.DstDatabaseTypes }).(pulumi.StringArrayOutput)
}

func (o GetMigrateJobsResultOutput) DstInstanceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) *string { return v.DstInstanceId }).(pulumi.StringPtrOutput)
}

func (o GetMigrateJobsResultOutput) DstRegion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) *string { return v.DstRegion }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetMigrateJobsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetMigrateJobsResultOutput) JobId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) *string { return v.JobId }).(pulumi.StringPtrOutput)
}

func (o GetMigrateJobsResultOutput) JobName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) *string { return v.JobName }).(pulumi.StringPtrOutput)
}

func (o GetMigrateJobsResultOutput) Lists() GetMigrateJobsListArrayOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) []GetMigrateJobsList { return v.Lists }).(GetMigrateJobsListArrayOutput)
}

func (o GetMigrateJobsResultOutput) OrderSeq() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) *string { return v.OrderSeq }).(pulumi.StringPtrOutput)
}

func (o GetMigrateJobsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetMigrateJobsResultOutput) RunMode() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) *string { return v.RunMode }).(pulumi.StringPtrOutput)
}

func (o GetMigrateJobsResultOutput) SrcAccessTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) []string { return v.SrcAccessTypes }).(pulumi.StringArrayOutput)
}

func (o GetMigrateJobsResultOutput) SrcDatabaseTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) []string { return v.SrcDatabaseTypes }).(pulumi.StringArrayOutput)
}

func (o GetMigrateJobsResultOutput) SrcInstanceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) *string { return v.SrcInstanceId }).(pulumi.StringPtrOutput)
}

func (o GetMigrateJobsResultOutput) SrcRegion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) *string { return v.SrcRegion }).(pulumi.StringPtrOutput)
}

func (o GetMigrateJobsResultOutput) Statuses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) []string { return v.Statuses }).(pulumi.StringArrayOutput)
}

func (o GetMigrateJobsResultOutput) TagFilters() GetMigrateJobsTagFilterArrayOutput {
	return o.ApplyT(func(v GetMigrateJobsResult) []GetMigrateJobsTagFilter { return v.TagFilters }).(GetMigrateJobsTagFilterArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetMigrateJobsResultOutput{})
}
