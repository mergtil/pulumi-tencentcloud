// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package monitor

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type TmpScrapeJob struct {
	pulumi.CustomResourceState

	// Agent id.
	AgentId pulumi.StringOutput `pulumi:"agentId"`
	// Job content.
	Config pulumi.StringPtrOutput `pulumi:"config"`
	// Instance id.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
}

// NewTmpScrapeJob registers a new resource with the given unique name, arguments, and options.
func NewTmpScrapeJob(ctx *pulumi.Context,
	name string, args *TmpScrapeJobArgs, opts ...pulumi.ResourceOption) (*TmpScrapeJob, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AgentId == nil {
		return nil, errors.New("invalid value for required argument 'AgentId'")
	}
	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource TmpScrapeJob
	err := ctx.RegisterResource("tencentcloud:Monitor/tmpScrapeJob:TmpScrapeJob", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTmpScrapeJob gets an existing TmpScrapeJob resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTmpScrapeJob(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TmpScrapeJobState, opts ...pulumi.ResourceOption) (*TmpScrapeJob, error) {
	var resource TmpScrapeJob
	err := ctx.ReadResource("tencentcloud:Monitor/tmpScrapeJob:TmpScrapeJob", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TmpScrapeJob resources.
type tmpScrapeJobState struct {
	// Agent id.
	AgentId *string `pulumi:"agentId"`
	// Job content.
	Config *string `pulumi:"config"`
	// Instance id.
	InstanceId *string `pulumi:"instanceId"`
}

type TmpScrapeJobState struct {
	// Agent id.
	AgentId pulumi.StringPtrInput
	// Job content.
	Config pulumi.StringPtrInput
	// Instance id.
	InstanceId pulumi.StringPtrInput
}

func (TmpScrapeJobState) ElementType() reflect.Type {
	return reflect.TypeOf((*tmpScrapeJobState)(nil)).Elem()
}

type tmpScrapeJobArgs struct {
	// Agent id.
	AgentId string `pulumi:"agentId"`
	// Job content.
	Config *string `pulumi:"config"`
	// Instance id.
	InstanceId string `pulumi:"instanceId"`
}

// The set of arguments for constructing a TmpScrapeJob resource.
type TmpScrapeJobArgs struct {
	// Agent id.
	AgentId pulumi.StringInput
	// Job content.
	Config pulumi.StringPtrInput
	// Instance id.
	InstanceId pulumi.StringInput
}

func (TmpScrapeJobArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*tmpScrapeJobArgs)(nil)).Elem()
}

type TmpScrapeJobInput interface {
	pulumi.Input

	ToTmpScrapeJobOutput() TmpScrapeJobOutput
	ToTmpScrapeJobOutputWithContext(ctx context.Context) TmpScrapeJobOutput
}

func (*TmpScrapeJob) ElementType() reflect.Type {
	return reflect.TypeOf((**TmpScrapeJob)(nil)).Elem()
}

func (i *TmpScrapeJob) ToTmpScrapeJobOutput() TmpScrapeJobOutput {
	return i.ToTmpScrapeJobOutputWithContext(context.Background())
}

func (i *TmpScrapeJob) ToTmpScrapeJobOutputWithContext(ctx context.Context) TmpScrapeJobOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TmpScrapeJobOutput)
}

// TmpScrapeJobArrayInput is an input type that accepts TmpScrapeJobArray and TmpScrapeJobArrayOutput values.
// You can construct a concrete instance of `TmpScrapeJobArrayInput` via:
//
//	TmpScrapeJobArray{ TmpScrapeJobArgs{...} }
type TmpScrapeJobArrayInput interface {
	pulumi.Input

	ToTmpScrapeJobArrayOutput() TmpScrapeJobArrayOutput
	ToTmpScrapeJobArrayOutputWithContext(context.Context) TmpScrapeJobArrayOutput
}

type TmpScrapeJobArray []TmpScrapeJobInput

func (TmpScrapeJobArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TmpScrapeJob)(nil)).Elem()
}

func (i TmpScrapeJobArray) ToTmpScrapeJobArrayOutput() TmpScrapeJobArrayOutput {
	return i.ToTmpScrapeJobArrayOutputWithContext(context.Background())
}

func (i TmpScrapeJobArray) ToTmpScrapeJobArrayOutputWithContext(ctx context.Context) TmpScrapeJobArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TmpScrapeJobArrayOutput)
}

// TmpScrapeJobMapInput is an input type that accepts TmpScrapeJobMap and TmpScrapeJobMapOutput values.
// You can construct a concrete instance of `TmpScrapeJobMapInput` via:
//
//	TmpScrapeJobMap{ "key": TmpScrapeJobArgs{...} }
type TmpScrapeJobMapInput interface {
	pulumi.Input

	ToTmpScrapeJobMapOutput() TmpScrapeJobMapOutput
	ToTmpScrapeJobMapOutputWithContext(context.Context) TmpScrapeJobMapOutput
}

type TmpScrapeJobMap map[string]TmpScrapeJobInput

func (TmpScrapeJobMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TmpScrapeJob)(nil)).Elem()
}

func (i TmpScrapeJobMap) ToTmpScrapeJobMapOutput() TmpScrapeJobMapOutput {
	return i.ToTmpScrapeJobMapOutputWithContext(context.Background())
}

func (i TmpScrapeJobMap) ToTmpScrapeJobMapOutputWithContext(ctx context.Context) TmpScrapeJobMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TmpScrapeJobMapOutput)
}

type TmpScrapeJobOutput struct{ *pulumi.OutputState }

func (TmpScrapeJobOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TmpScrapeJob)(nil)).Elem()
}

func (o TmpScrapeJobOutput) ToTmpScrapeJobOutput() TmpScrapeJobOutput {
	return o
}

func (o TmpScrapeJobOutput) ToTmpScrapeJobOutputWithContext(ctx context.Context) TmpScrapeJobOutput {
	return o
}

// Agent id.
func (o TmpScrapeJobOutput) AgentId() pulumi.StringOutput {
	return o.ApplyT(func(v *TmpScrapeJob) pulumi.StringOutput { return v.AgentId }).(pulumi.StringOutput)
}

// Job content.
func (o TmpScrapeJobOutput) Config() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TmpScrapeJob) pulumi.StringPtrOutput { return v.Config }).(pulumi.StringPtrOutput)
}

// Instance id.
func (o TmpScrapeJobOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *TmpScrapeJob) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

type TmpScrapeJobArrayOutput struct{ *pulumi.OutputState }

func (TmpScrapeJobArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TmpScrapeJob)(nil)).Elem()
}

func (o TmpScrapeJobArrayOutput) ToTmpScrapeJobArrayOutput() TmpScrapeJobArrayOutput {
	return o
}

func (o TmpScrapeJobArrayOutput) ToTmpScrapeJobArrayOutputWithContext(ctx context.Context) TmpScrapeJobArrayOutput {
	return o
}

func (o TmpScrapeJobArrayOutput) Index(i pulumi.IntInput) TmpScrapeJobOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *TmpScrapeJob {
		return vs[0].([]*TmpScrapeJob)[vs[1].(int)]
	}).(TmpScrapeJobOutput)
}

type TmpScrapeJobMapOutput struct{ *pulumi.OutputState }

func (TmpScrapeJobMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TmpScrapeJob)(nil)).Elem()
}

func (o TmpScrapeJobMapOutput) ToTmpScrapeJobMapOutput() TmpScrapeJobMapOutput {
	return o
}

func (o TmpScrapeJobMapOutput) ToTmpScrapeJobMapOutputWithContext(ctx context.Context) TmpScrapeJobMapOutput {
	return o
}

func (o TmpScrapeJobMapOutput) MapIndex(k pulumi.StringInput) TmpScrapeJobOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *TmpScrapeJob {
		return vs[0].(map[string]*TmpScrapeJob)[vs[1].(string)]
	}).(TmpScrapeJobOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TmpScrapeJobInput)(nil)).Elem(), &TmpScrapeJob{})
	pulumi.RegisterInputType(reflect.TypeOf((*TmpScrapeJobArrayInput)(nil)).Elem(), TmpScrapeJobArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TmpScrapeJobMapInput)(nil)).Elem(), TmpScrapeJobMap{})
	pulumi.RegisterOutputType(TmpScrapeJobOutput{})
	pulumi.RegisterOutputType(TmpScrapeJobArrayOutput{})
	pulumi.RegisterOutputType(TmpScrapeJobMapOutput{})
}