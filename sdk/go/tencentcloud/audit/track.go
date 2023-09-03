// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package audit

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type Track struct {
	pulumi.CustomResourceState

	// Track interface type, optional:- `Read`: Read interface- `Write`: Write interface- `*`: All interface.
	ActionType pulumi.StringOutput `pulumi:"actionType"`
	// Track create time.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// Track interface name list:- when ResourceType is `*`, EventNames is must `[&amp;quot;*&amp;quot;]`- when ResourceType is
	// a single product, EventNames support all interface:`[&amp;quot;*&amp;quot;]`- when ResourceType is a single product,
	// EventNames support some interface, up to 10.
	EventNames pulumi.StringArrayOutput `pulumi:"eventNames"`
	// Track name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Track product, optional:- `*`: All product- Single product, such as `cos`.
	ResourceType pulumi.StringOutput `pulumi:"resourceType"`
	// Track status, optional:- `0`: Close- `1`: Open.
	Status pulumi.IntOutput `pulumi:"status"`
	// Track Storage, support `cos` and `cls`.
	Storage TrackStorageOutput `pulumi:"storage"`
	// Whether to enable the delivery of group member operation logs to the group management account or trusted service
	// management account, optional:- `0`: Close- `1`: Open.
	TrackForAllMembers pulumi.IntPtrOutput `pulumi:"trackForAllMembers"`
}

// NewTrack registers a new resource with the given unique name, arguments, and options.
func NewTrack(ctx *pulumi.Context,
	name string, args *TrackArgs, opts ...pulumi.ResourceOption) (*Track, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ActionType == nil {
		return nil, errors.New("invalid value for required argument 'ActionType'")
	}
	if args.EventNames == nil {
		return nil, errors.New("invalid value for required argument 'EventNames'")
	}
	if args.ResourceType == nil {
		return nil, errors.New("invalid value for required argument 'ResourceType'")
	}
	if args.Status == nil {
		return nil, errors.New("invalid value for required argument 'Status'")
	}
	if args.Storage == nil {
		return nil, errors.New("invalid value for required argument 'Storage'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Track
	err := ctx.RegisterResource("tencentcloud:Audit/track:Track", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTrack gets an existing Track resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTrack(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TrackState, opts ...pulumi.ResourceOption) (*Track, error) {
	var resource Track
	err := ctx.ReadResource("tencentcloud:Audit/track:Track", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Track resources.
type trackState struct {
	// Track interface type, optional:- `Read`: Read interface- `Write`: Write interface- `*`: All interface.
	ActionType *string `pulumi:"actionType"`
	// Track create time.
	CreateTime *string `pulumi:"createTime"`
	// Track interface name list:- when ResourceType is `*`, EventNames is must `[&amp;quot;*&amp;quot;]`- when ResourceType is
	// a single product, EventNames support all interface:`[&amp;quot;*&amp;quot;]`- when ResourceType is a single product,
	// EventNames support some interface, up to 10.
	EventNames []string `pulumi:"eventNames"`
	// Track name.
	Name *string `pulumi:"name"`
	// Track product, optional:- `*`: All product- Single product, such as `cos`.
	ResourceType *string `pulumi:"resourceType"`
	// Track status, optional:- `0`: Close- `1`: Open.
	Status *int `pulumi:"status"`
	// Track Storage, support `cos` and `cls`.
	Storage *TrackStorage `pulumi:"storage"`
	// Whether to enable the delivery of group member operation logs to the group management account or trusted service
	// management account, optional:- `0`: Close- `1`: Open.
	TrackForAllMembers *int `pulumi:"trackForAllMembers"`
}

type TrackState struct {
	// Track interface type, optional:- `Read`: Read interface- `Write`: Write interface- `*`: All interface.
	ActionType pulumi.StringPtrInput
	// Track create time.
	CreateTime pulumi.StringPtrInput
	// Track interface name list:- when ResourceType is `*`, EventNames is must `[&amp;quot;*&amp;quot;]`- when ResourceType is
	// a single product, EventNames support all interface:`[&amp;quot;*&amp;quot;]`- when ResourceType is a single product,
	// EventNames support some interface, up to 10.
	EventNames pulumi.StringArrayInput
	// Track name.
	Name pulumi.StringPtrInput
	// Track product, optional:- `*`: All product- Single product, such as `cos`.
	ResourceType pulumi.StringPtrInput
	// Track status, optional:- `0`: Close- `1`: Open.
	Status pulumi.IntPtrInput
	// Track Storage, support `cos` and `cls`.
	Storage TrackStoragePtrInput
	// Whether to enable the delivery of group member operation logs to the group management account or trusted service
	// management account, optional:- `0`: Close- `1`: Open.
	TrackForAllMembers pulumi.IntPtrInput
}

func (TrackState) ElementType() reflect.Type {
	return reflect.TypeOf((*trackState)(nil)).Elem()
}

type trackArgs struct {
	// Track interface type, optional:- `Read`: Read interface- `Write`: Write interface- `*`: All interface.
	ActionType string `pulumi:"actionType"`
	// Track interface name list:- when ResourceType is `*`, EventNames is must `[&amp;quot;*&amp;quot;]`- when ResourceType is
	// a single product, EventNames support all interface:`[&amp;quot;*&amp;quot;]`- when ResourceType is a single product,
	// EventNames support some interface, up to 10.
	EventNames []string `pulumi:"eventNames"`
	// Track name.
	Name *string `pulumi:"name"`
	// Track product, optional:- `*`: All product- Single product, such as `cos`.
	ResourceType string `pulumi:"resourceType"`
	// Track status, optional:- `0`: Close- `1`: Open.
	Status int `pulumi:"status"`
	// Track Storage, support `cos` and `cls`.
	Storage TrackStorage `pulumi:"storage"`
	// Whether to enable the delivery of group member operation logs to the group management account or trusted service
	// management account, optional:- `0`: Close- `1`: Open.
	TrackForAllMembers *int `pulumi:"trackForAllMembers"`
}

// The set of arguments for constructing a Track resource.
type TrackArgs struct {
	// Track interface type, optional:- `Read`: Read interface- `Write`: Write interface- `*`: All interface.
	ActionType pulumi.StringInput
	// Track interface name list:- when ResourceType is `*`, EventNames is must `[&amp;quot;*&amp;quot;]`- when ResourceType is
	// a single product, EventNames support all interface:`[&amp;quot;*&amp;quot;]`- when ResourceType is a single product,
	// EventNames support some interface, up to 10.
	EventNames pulumi.StringArrayInput
	// Track name.
	Name pulumi.StringPtrInput
	// Track product, optional:- `*`: All product- Single product, such as `cos`.
	ResourceType pulumi.StringInput
	// Track status, optional:- `0`: Close- `1`: Open.
	Status pulumi.IntInput
	// Track Storage, support `cos` and `cls`.
	Storage TrackStorageInput
	// Whether to enable the delivery of group member operation logs to the group management account or trusted service
	// management account, optional:- `0`: Close- `1`: Open.
	TrackForAllMembers pulumi.IntPtrInput
}

func (TrackArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*trackArgs)(nil)).Elem()
}

type TrackInput interface {
	pulumi.Input

	ToTrackOutput() TrackOutput
	ToTrackOutputWithContext(ctx context.Context) TrackOutput
}

func (*Track) ElementType() reflect.Type {
	return reflect.TypeOf((**Track)(nil)).Elem()
}

func (i *Track) ToTrackOutput() TrackOutput {
	return i.ToTrackOutputWithContext(context.Background())
}

func (i *Track) ToTrackOutputWithContext(ctx context.Context) TrackOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TrackOutput)
}

// TrackArrayInput is an input type that accepts TrackArray and TrackArrayOutput values.
// You can construct a concrete instance of `TrackArrayInput` via:
//
//	TrackArray{ TrackArgs{...} }
type TrackArrayInput interface {
	pulumi.Input

	ToTrackArrayOutput() TrackArrayOutput
	ToTrackArrayOutputWithContext(context.Context) TrackArrayOutput
}

type TrackArray []TrackInput

func (TrackArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Track)(nil)).Elem()
}

func (i TrackArray) ToTrackArrayOutput() TrackArrayOutput {
	return i.ToTrackArrayOutputWithContext(context.Background())
}

func (i TrackArray) ToTrackArrayOutputWithContext(ctx context.Context) TrackArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TrackArrayOutput)
}

// TrackMapInput is an input type that accepts TrackMap and TrackMapOutput values.
// You can construct a concrete instance of `TrackMapInput` via:
//
//	TrackMap{ "key": TrackArgs{...} }
type TrackMapInput interface {
	pulumi.Input

	ToTrackMapOutput() TrackMapOutput
	ToTrackMapOutputWithContext(context.Context) TrackMapOutput
}

type TrackMap map[string]TrackInput

func (TrackMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Track)(nil)).Elem()
}

func (i TrackMap) ToTrackMapOutput() TrackMapOutput {
	return i.ToTrackMapOutputWithContext(context.Background())
}

func (i TrackMap) ToTrackMapOutputWithContext(ctx context.Context) TrackMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TrackMapOutput)
}

type TrackOutput struct{ *pulumi.OutputState }

func (TrackOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Track)(nil)).Elem()
}

func (o TrackOutput) ToTrackOutput() TrackOutput {
	return o
}

func (o TrackOutput) ToTrackOutputWithContext(ctx context.Context) TrackOutput {
	return o
}

// Track interface type, optional:- `Read`: Read interface- `Write`: Write interface- `*`: All interface.
func (o TrackOutput) ActionType() pulumi.StringOutput {
	return o.ApplyT(func(v *Track) pulumi.StringOutput { return v.ActionType }).(pulumi.StringOutput)
}

// Track create time.
func (o TrackOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Track) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// Track interface name list:- when ResourceType is `*`, EventNames is must `[&amp;quot;*&amp;quot;]`- when ResourceType is
// a single product, EventNames support all interface:`[&amp;quot;*&amp;quot;]`- when ResourceType is a single product,
// EventNames support some interface, up to 10.
func (o TrackOutput) EventNames() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Track) pulumi.StringArrayOutput { return v.EventNames }).(pulumi.StringArrayOutput)
}

// Track name.
func (o TrackOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Track) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Track product, optional:- `*`: All product- Single product, such as `cos`.
func (o TrackOutput) ResourceType() pulumi.StringOutput {
	return o.ApplyT(func(v *Track) pulumi.StringOutput { return v.ResourceType }).(pulumi.StringOutput)
}

// Track status, optional:- `0`: Close- `1`: Open.
func (o TrackOutput) Status() pulumi.IntOutput {
	return o.ApplyT(func(v *Track) pulumi.IntOutput { return v.Status }).(pulumi.IntOutput)
}

// Track Storage, support `cos` and `cls`.
func (o TrackOutput) Storage() TrackStorageOutput {
	return o.ApplyT(func(v *Track) TrackStorageOutput { return v.Storage }).(TrackStorageOutput)
}

// Whether to enable the delivery of group member operation logs to the group management account or trusted service
// management account, optional:- `0`: Close- `1`: Open.
func (o TrackOutput) TrackForAllMembers() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Track) pulumi.IntPtrOutput { return v.TrackForAllMembers }).(pulumi.IntPtrOutput)
}

type TrackArrayOutput struct{ *pulumi.OutputState }

func (TrackArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Track)(nil)).Elem()
}

func (o TrackArrayOutput) ToTrackArrayOutput() TrackArrayOutput {
	return o
}

func (o TrackArrayOutput) ToTrackArrayOutputWithContext(ctx context.Context) TrackArrayOutput {
	return o
}

func (o TrackArrayOutput) Index(i pulumi.IntInput) TrackOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Track {
		return vs[0].([]*Track)[vs[1].(int)]
	}).(TrackOutput)
}

type TrackMapOutput struct{ *pulumi.OutputState }

func (TrackMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Track)(nil)).Elem()
}

func (o TrackMapOutput) ToTrackMapOutput() TrackMapOutput {
	return o
}

func (o TrackMapOutput) ToTrackMapOutputWithContext(ctx context.Context) TrackMapOutput {
	return o
}

func (o TrackMapOutput) MapIndex(k pulumi.StringInput) TrackOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Track {
		return vs[0].(map[string]*Track)[vs[1].(string)]
	}).(TrackOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TrackInput)(nil)).Elem(), &Track{})
	pulumi.RegisterInputType(reflect.TypeOf((*TrackArrayInput)(nil)).Elem(), TrackArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TrackMapInput)(nil)).Elem(), TrackMap{})
	pulumi.RegisterOutputType(TrackOutput{})
	pulumi.RegisterOutputType(TrackArrayOutput{})
	pulumi.RegisterOutputType(TrackMapOutput{})
}