// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cat

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetProbeData(ctx *pulumi.Context, args *GetProbeDataArgs, opts ...pulumi.InvokeOption) (*GetProbeDataResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetProbeDataResult
	err := ctx.Invoke("tencentcloud:Cat/getProbeData:getProbeData", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getProbeData.
type GetProbeDataArgs struct {
	Ascending        bool     `pulumi:"ascending"`
	BeginTime        int      `pulumi:"beginTime"`
	Cities           []string `pulumi:"cities"`
	Codes            []string `pulumi:"codes"`
	Districts        []string `pulumi:"districts"`
	EndTime          int      `pulumi:"endTime"`
	ErrorTypes       []string `pulumi:"errorTypes"`
	Limit            int      `pulumi:"limit"`
	Offset           int      `pulumi:"offset"`
	Operators        []string `pulumi:"operators"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
	SelectedFields   []string `pulumi:"selectedFields"`
	SortField        string   `pulumi:"sortField"`
	TaskIds          []string `pulumi:"taskIds"`
	TaskType         string   `pulumi:"taskType"`
}

// A collection of values returned by getProbeData.
type GetProbeDataResult struct {
	Ascending                 bool                                   `pulumi:"ascending"`
	BeginTime                 int                                    `pulumi:"beginTime"`
	Cities                    []string                               `pulumi:"cities"`
	Codes                     []string                               `pulumi:"codes"`
	DetailedSingleDataDefines []GetProbeDataDetailedSingleDataDefine `pulumi:"detailedSingleDataDefines"`
	Districts                 []string                               `pulumi:"districts"`
	EndTime                   int                                    `pulumi:"endTime"`
	ErrorTypes                []string                               `pulumi:"errorTypes"`
	// The provider-assigned unique ID for this managed resource.
	Id               string   `pulumi:"id"`
	Limit            int      `pulumi:"limit"`
	Offset           int      `pulumi:"offset"`
	Operators        []string `pulumi:"operators"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
	SelectedFields   []string `pulumi:"selectedFields"`
	SortField        string   `pulumi:"sortField"`
	TaskIds          []string `pulumi:"taskIds"`
	TaskType         string   `pulumi:"taskType"`
}

func GetProbeDataOutput(ctx *pulumi.Context, args GetProbeDataOutputArgs, opts ...pulumi.InvokeOption) GetProbeDataResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetProbeDataResult, error) {
			args := v.(GetProbeDataArgs)
			r, err := GetProbeData(ctx, &args, opts...)
			var s GetProbeDataResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetProbeDataResultOutput)
}

// A collection of arguments for invoking getProbeData.
type GetProbeDataOutputArgs struct {
	Ascending        pulumi.BoolInput        `pulumi:"ascending"`
	BeginTime        pulumi.IntInput         `pulumi:"beginTime"`
	Cities           pulumi.StringArrayInput `pulumi:"cities"`
	Codes            pulumi.StringArrayInput `pulumi:"codes"`
	Districts        pulumi.StringArrayInput `pulumi:"districts"`
	EndTime          pulumi.IntInput         `pulumi:"endTime"`
	ErrorTypes       pulumi.StringArrayInput `pulumi:"errorTypes"`
	Limit            pulumi.IntInput         `pulumi:"limit"`
	Offset           pulumi.IntInput         `pulumi:"offset"`
	Operators        pulumi.StringArrayInput `pulumi:"operators"`
	ResultOutputFile pulumi.StringPtrInput   `pulumi:"resultOutputFile"`
	SelectedFields   pulumi.StringArrayInput `pulumi:"selectedFields"`
	SortField        pulumi.StringInput      `pulumi:"sortField"`
	TaskIds          pulumi.StringArrayInput `pulumi:"taskIds"`
	TaskType         pulumi.StringInput      `pulumi:"taskType"`
}

func (GetProbeDataOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetProbeDataArgs)(nil)).Elem()
}

// A collection of values returned by getProbeData.
type GetProbeDataResultOutput struct{ *pulumi.OutputState }

func (GetProbeDataResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetProbeDataResult)(nil)).Elem()
}

func (o GetProbeDataResultOutput) ToGetProbeDataResultOutput() GetProbeDataResultOutput {
	return o
}

func (o GetProbeDataResultOutput) ToGetProbeDataResultOutputWithContext(ctx context.Context) GetProbeDataResultOutput {
	return o
}

func (o GetProbeDataResultOutput) Ascending() pulumi.BoolOutput {
	return o.ApplyT(func(v GetProbeDataResult) bool { return v.Ascending }).(pulumi.BoolOutput)
}

func (o GetProbeDataResultOutput) BeginTime() pulumi.IntOutput {
	return o.ApplyT(func(v GetProbeDataResult) int { return v.BeginTime }).(pulumi.IntOutput)
}

func (o GetProbeDataResultOutput) Cities() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetProbeDataResult) []string { return v.Cities }).(pulumi.StringArrayOutput)
}

func (o GetProbeDataResultOutput) Codes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetProbeDataResult) []string { return v.Codes }).(pulumi.StringArrayOutput)
}

func (o GetProbeDataResultOutput) DetailedSingleDataDefines() GetProbeDataDetailedSingleDataDefineArrayOutput {
	return o.ApplyT(func(v GetProbeDataResult) []GetProbeDataDetailedSingleDataDefine { return v.DetailedSingleDataDefines }).(GetProbeDataDetailedSingleDataDefineArrayOutput)
}

func (o GetProbeDataResultOutput) Districts() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetProbeDataResult) []string { return v.Districts }).(pulumi.StringArrayOutput)
}

func (o GetProbeDataResultOutput) EndTime() pulumi.IntOutput {
	return o.ApplyT(func(v GetProbeDataResult) int { return v.EndTime }).(pulumi.IntOutput)
}

func (o GetProbeDataResultOutput) ErrorTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetProbeDataResult) []string { return v.ErrorTypes }).(pulumi.StringArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetProbeDataResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetProbeDataResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetProbeDataResultOutput) Limit() pulumi.IntOutput {
	return o.ApplyT(func(v GetProbeDataResult) int { return v.Limit }).(pulumi.IntOutput)
}

func (o GetProbeDataResultOutput) Offset() pulumi.IntOutput {
	return o.ApplyT(func(v GetProbeDataResult) int { return v.Offset }).(pulumi.IntOutput)
}

func (o GetProbeDataResultOutput) Operators() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetProbeDataResult) []string { return v.Operators }).(pulumi.StringArrayOutput)
}

func (o GetProbeDataResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetProbeDataResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetProbeDataResultOutput) SelectedFields() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetProbeDataResult) []string { return v.SelectedFields }).(pulumi.StringArrayOutput)
}

func (o GetProbeDataResultOutput) SortField() pulumi.StringOutput {
	return o.ApplyT(func(v GetProbeDataResult) string { return v.SortField }).(pulumi.StringOutput)
}

func (o GetProbeDataResultOutput) TaskIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetProbeDataResult) []string { return v.TaskIds }).(pulumi.StringArrayOutput)
}

func (o GetProbeDataResultOutput) TaskType() pulumi.StringOutput {
	return o.ApplyT(func(v GetProbeDataResult) string { return v.TaskType }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetProbeDataResultOutput{})
}
