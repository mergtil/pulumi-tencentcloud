// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tsf

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupConfigSummary(ctx *pulumi.Context, args *LookupConfigSummaryArgs, opts ...pulumi.InvokeOption) (*LookupConfigSummaryResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupConfigSummaryResult
	err := ctx.Invoke("tencentcloud:Tsf/getConfigSummary:getConfigSummary", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getConfigSummary.
type LookupConfigSummaryArgs struct {
	ApplicationId           *string  `pulumi:"applicationId"`
	ConfigIdLists           []string `pulumi:"configIdLists"`
	ConfigTagLists          []string `pulumi:"configTagLists"`
	DisableProgramAuthCheck *bool    `pulumi:"disableProgramAuthCheck"`
	OrderBy                 *string  `pulumi:"orderBy"`
	OrderType               *int     `pulumi:"orderType"`
	ResultOutputFile        *string  `pulumi:"resultOutputFile"`
	SearchWord              *string  `pulumi:"searchWord"`
}

// A collection of values returned by getConfigSummary.
type LookupConfigSummaryResult struct {
	ApplicationId           *string  `pulumi:"applicationId"`
	ConfigIdLists           []string `pulumi:"configIdLists"`
	ConfigTagLists          []string `pulumi:"configTagLists"`
	DisableProgramAuthCheck *bool    `pulumi:"disableProgramAuthCheck"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                   `pulumi:"id"`
	OrderBy          *string                  `pulumi:"orderBy"`
	OrderType        *int                     `pulumi:"orderType"`
	ResultOutputFile *string                  `pulumi:"resultOutputFile"`
	Results          []GetConfigSummaryResult `pulumi:"results"`
	SearchWord       *string                  `pulumi:"searchWord"`
}

func LookupConfigSummaryOutput(ctx *pulumi.Context, args LookupConfigSummaryOutputArgs, opts ...pulumi.InvokeOption) LookupConfigSummaryResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupConfigSummaryResult, error) {
			args := v.(LookupConfigSummaryArgs)
			r, err := LookupConfigSummary(ctx, &args, opts...)
			var s LookupConfigSummaryResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupConfigSummaryResultOutput)
}

// A collection of arguments for invoking getConfigSummary.
type LookupConfigSummaryOutputArgs struct {
	ApplicationId           pulumi.StringPtrInput   `pulumi:"applicationId"`
	ConfigIdLists           pulumi.StringArrayInput `pulumi:"configIdLists"`
	ConfigTagLists          pulumi.StringArrayInput `pulumi:"configTagLists"`
	DisableProgramAuthCheck pulumi.BoolPtrInput     `pulumi:"disableProgramAuthCheck"`
	OrderBy                 pulumi.StringPtrInput   `pulumi:"orderBy"`
	OrderType               pulumi.IntPtrInput      `pulumi:"orderType"`
	ResultOutputFile        pulumi.StringPtrInput   `pulumi:"resultOutputFile"`
	SearchWord              pulumi.StringPtrInput   `pulumi:"searchWord"`
}

func (LookupConfigSummaryOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupConfigSummaryArgs)(nil)).Elem()
}

// A collection of values returned by getConfigSummary.
type LookupConfigSummaryResultOutput struct{ *pulumi.OutputState }

func (LookupConfigSummaryResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupConfigSummaryResult)(nil)).Elem()
}

func (o LookupConfigSummaryResultOutput) ToLookupConfigSummaryResultOutput() LookupConfigSummaryResultOutput {
	return o
}

func (o LookupConfigSummaryResultOutput) ToLookupConfigSummaryResultOutputWithContext(ctx context.Context) LookupConfigSummaryResultOutput {
	return o
}

func (o LookupConfigSummaryResultOutput) ApplicationId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) *string { return v.ApplicationId }).(pulumi.StringPtrOutput)
}

func (o LookupConfigSummaryResultOutput) ConfigIdLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) []string { return v.ConfigIdLists }).(pulumi.StringArrayOutput)
}

func (o LookupConfigSummaryResultOutput) ConfigTagLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) []string { return v.ConfigTagLists }).(pulumi.StringArrayOutput)
}

func (o LookupConfigSummaryResultOutput) DisableProgramAuthCheck() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) *bool { return v.DisableProgramAuthCheck }).(pulumi.BoolPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupConfigSummaryResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupConfigSummaryResultOutput) OrderBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) *string { return v.OrderBy }).(pulumi.StringPtrOutput)
}

func (o LookupConfigSummaryResultOutput) OrderType() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) *int { return v.OrderType }).(pulumi.IntPtrOutput)
}

func (o LookupConfigSummaryResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o LookupConfigSummaryResultOutput) Results() GetConfigSummaryResultArrayOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) []GetConfigSummaryResult { return v.Results }).(GetConfigSummaryResultArrayOutput)
}

func (o LookupConfigSummaryResultOutput) SearchWord() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConfigSummaryResult) *string { return v.SearchWord }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupConfigSummaryResultOutput{})
}
