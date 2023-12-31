// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tcmq

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupQueue(ctx *pulumi.Context, args *LookupQueueArgs, opts ...pulumi.InvokeOption) (*LookupQueueResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupQueueResult
	err := ctx.Invoke("tencentcloud:Tcmq/getQueue:getQueue", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getQueue.
type LookupQueueArgs struct {
	Filters          []GetQueueFilter `pulumi:"filters"`
	IsTagFilter      *bool            `pulumi:"isTagFilter"`
	Limit            *int             `pulumi:"limit"`
	Offset           *int             `pulumi:"offset"`
	QueueName        *string          `pulumi:"queueName"`
	QueueNameLists   []string         `pulumi:"queueNameLists"`
	ResultOutputFile *string          `pulumi:"resultOutputFile"`
}

// A collection of values returned by getQueue.
type LookupQueueResult struct {
	Filters []GetQueueFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id               string              `pulumi:"id"`
	IsTagFilter      *bool               `pulumi:"isTagFilter"`
	Limit            *int                `pulumi:"limit"`
	Offset           *int                `pulumi:"offset"`
	QueueLists       []GetQueueQueueList `pulumi:"queueLists"`
	QueueName        *string             `pulumi:"queueName"`
	QueueNameLists   []string            `pulumi:"queueNameLists"`
	ResultOutputFile *string             `pulumi:"resultOutputFile"`
}

func LookupQueueOutput(ctx *pulumi.Context, args LookupQueueOutputArgs, opts ...pulumi.InvokeOption) LookupQueueResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupQueueResult, error) {
			args := v.(LookupQueueArgs)
			r, err := LookupQueue(ctx, &args, opts...)
			var s LookupQueueResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupQueueResultOutput)
}

// A collection of arguments for invoking getQueue.
type LookupQueueOutputArgs struct {
	Filters          GetQueueFilterArrayInput `pulumi:"filters"`
	IsTagFilter      pulumi.BoolPtrInput      `pulumi:"isTagFilter"`
	Limit            pulumi.IntPtrInput       `pulumi:"limit"`
	Offset           pulumi.IntPtrInput       `pulumi:"offset"`
	QueueName        pulumi.StringPtrInput    `pulumi:"queueName"`
	QueueNameLists   pulumi.StringArrayInput  `pulumi:"queueNameLists"`
	ResultOutputFile pulumi.StringPtrInput    `pulumi:"resultOutputFile"`
}

func (LookupQueueOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupQueueArgs)(nil)).Elem()
}

// A collection of values returned by getQueue.
type LookupQueueResultOutput struct{ *pulumi.OutputState }

func (LookupQueueResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupQueueResult)(nil)).Elem()
}

func (o LookupQueueResultOutput) ToLookupQueueResultOutput() LookupQueueResultOutput {
	return o
}

func (o LookupQueueResultOutput) ToLookupQueueResultOutputWithContext(ctx context.Context) LookupQueueResultOutput {
	return o
}

func (o LookupQueueResultOutput) Filters() GetQueueFilterArrayOutput {
	return o.ApplyT(func(v LookupQueueResult) []GetQueueFilter { return v.Filters }).(GetQueueFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupQueueResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupQueueResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupQueueResultOutput) IsTagFilter() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupQueueResult) *bool { return v.IsTagFilter }).(pulumi.BoolPtrOutput)
}

func (o LookupQueueResultOutput) Limit() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupQueueResult) *int { return v.Limit }).(pulumi.IntPtrOutput)
}

func (o LookupQueueResultOutput) Offset() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupQueueResult) *int { return v.Offset }).(pulumi.IntPtrOutput)
}

func (o LookupQueueResultOutput) QueueLists() GetQueueQueueListArrayOutput {
	return o.ApplyT(func(v LookupQueueResult) []GetQueueQueueList { return v.QueueLists }).(GetQueueQueueListArrayOutput)
}

func (o LookupQueueResultOutput) QueueName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupQueueResult) *string { return v.QueueName }).(pulumi.StringPtrOutput)
}

func (o LookupQueueResultOutput) QueueNameLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupQueueResult) []string { return v.QueueNameLists }).(pulumi.StringArrayOutput)
}

func (o LookupQueueResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupQueueResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupQueueResultOutput{})
}
