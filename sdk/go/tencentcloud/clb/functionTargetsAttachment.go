// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package clb

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type FunctionTargetsAttachment struct {
	pulumi.CustomResourceState

	// The domain name of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not
	// take effect.
	Domain pulumi.StringOutput `pulumi:"domain"`
	// List of cloud functions to be bound.
	FunctionTargets FunctionTargetsAttachmentFunctionTargetsOutput `pulumi:"functionTargets"`
	// Load Balancer Listener ID.
	ListenerId pulumi.StringOutput `pulumi:"listenerId"`
	// Load Balancer Instance ID.
	LoadBalancerId pulumi.StringOutput `pulumi:"loadBalancerId"`
	// The ID of the target forwarding rule. When binding the cloud function to a layer-7 forwarding rule, this parameter or
	// the Domain+Url parameter must be entered.
	LocationId pulumi.StringOutput `pulumi:"locationId"`
	// The URL of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not take
	// effect.
	Url pulumi.StringOutput `pulumi:"url"`
}

// NewFunctionTargetsAttachment registers a new resource with the given unique name, arguments, and options.
func NewFunctionTargetsAttachment(ctx *pulumi.Context,
	name string, args *FunctionTargetsAttachmentArgs, opts ...pulumi.ResourceOption) (*FunctionTargetsAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FunctionTargets == nil {
		return nil, errors.New("invalid value for required argument 'FunctionTargets'")
	}
	if args.ListenerId == nil {
		return nil, errors.New("invalid value for required argument 'ListenerId'")
	}
	if args.LoadBalancerId == nil {
		return nil, errors.New("invalid value for required argument 'LoadBalancerId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource FunctionTargetsAttachment
	err := ctx.RegisterResource("tencentcloud:Clb/functionTargetsAttachment:FunctionTargetsAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFunctionTargetsAttachment gets an existing FunctionTargetsAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFunctionTargetsAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FunctionTargetsAttachmentState, opts ...pulumi.ResourceOption) (*FunctionTargetsAttachment, error) {
	var resource FunctionTargetsAttachment
	err := ctx.ReadResource("tencentcloud:Clb/functionTargetsAttachment:FunctionTargetsAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FunctionTargetsAttachment resources.
type functionTargetsAttachmentState struct {
	// The domain name of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not
	// take effect.
	Domain *string `pulumi:"domain"`
	// List of cloud functions to be bound.
	FunctionTargets *FunctionTargetsAttachmentFunctionTargets `pulumi:"functionTargets"`
	// Load Balancer Listener ID.
	ListenerId *string `pulumi:"listenerId"`
	// Load Balancer Instance ID.
	LoadBalancerId *string `pulumi:"loadBalancerId"`
	// The ID of the target forwarding rule. When binding the cloud function to a layer-7 forwarding rule, this parameter or
	// the Domain+Url parameter must be entered.
	LocationId *string `pulumi:"locationId"`
	// The URL of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not take
	// effect.
	Url *string `pulumi:"url"`
}

type FunctionTargetsAttachmentState struct {
	// The domain name of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not
	// take effect.
	Domain pulumi.StringPtrInput
	// List of cloud functions to be bound.
	FunctionTargets FunctionTargetsAttachmentFunctionTargetsPtrInput
	// Load Balancer Listener ID.
	ListenerId pulumi.StringPtrInput
	// Load Balancer Instance ID.
	LoadBalancerId pulumi.StringPtrInput
	// The ID of the target forwarding rule. When binding the cloud function to a layer-7 forwarding rule, this parameter or
	// the Domain+Url parameter must be entered.
	LocationId pulumi.StringPtrInput
	// The URL of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not take
	// effect.
	Url pulumi.StringPtrInput
}

func (FunctionTargetsAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*functionTargetsAttachmentState)(nil)).Elem()
}

type functionTargetsAttachmentArgs struct {
	// The domain name of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not
	// take effect.
	Domain *string `pulumi:"domain"`
	// List of cloud functions to be bound.
	FunctionTargets FunctionTargetsAttachmentFunctionTargets `pulumi:"functionTargets"`
	// Load Balancer Listener ID.
	ListenerId string `pulumi:"listenerId"`
	// Load Balancer Instance ID.
	LoadBalancerId string `pulumi:"loadBalancerId"`
	// The ID of the target forwarding rule. When binding the cloud function to a layer-7 forwarding rule, this parameter or
	// the Domain+Url parameter must be entered.
	LocationId *string `pulumi:"locationId"`
	// The URL of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not take
	// effect.
	Url *string `pulumi:"url"`
}

// The set of arguments for constructing a FunctionTargetsAttachment resource.
type FunctionTargetsAttachmentArgs struct {
	// The domain name of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not
	// take effect.
	Domain pulumi.StringPtrInput
	// List of cloud functions to be bound.
	FunctionTargets FunctionTargetsAttachmentFunctionTargetsInput
	// Load Balancer Listener ID.
	ListenerId pulumi.StringInput
	// Load Balancer Instance ID.
	LoadBalancerId pulumi.StringInput
	// The ID of the target forwarding rule. When binding the cloud function to a layer-7 forwarding rule, this parameter or
	// the Domain+Url parameter must be entered.
	LocationId pulumi.StringPtrInput
	// The URL of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not take
	// effect.
	Url pulumi.StringPtrInput
}

func (FunctionTargetsAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*functionTargetsAttachmentArgs)(nil)).Elem()
}

type FunctionTargetsAttachmentInput interface {
	pulumi.Input

	ToFunctionTargetsAttachmentOutput() FunctionTargetsAttachmentOutput
	ToFunctionTargetsAttachmentOutputWithContext(ctx context.Context) FunctionTargetsAttachmentOutput
}

func (*FunctionTargetsAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((**FunctionTargetsAttachment)(nil)).Elem()
}

func (i *FunctionTargetsAttachment) ToFunctionTargetsAttachmentOutput() FunctionTargetsAttachmentOutput {
	return i.ToFunctionTargetsAttachmentOutputWithContext(context.Background())
}

func (i *FunctionTargetsAttachment) ToFunctionTargetsAttachmentOutputWithContext(ctx context.Context) FunctionTargetsAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionTargetsAttachmentOutput)
}

// FunctionTargetsAttachmentArrayInput is an input type that accepts FunctionTargetsAttachmentArray and FunctionTargetsAttachmentArrayOutput values.
// You can construct a concrete instance of `FunctionTargetsAttachmentArrayInput` via:
//
//	FunctionTargetsAttachmentArray{ FunctionTargetsAttachmentArgs{...} }
type FunctionTargetsAttachmentArrayInput interface {
	pulumi.Input

	ToFunctionTargetsAttachmentArrayOutput() FunctionTargetsAttachmentArrayOutput
	ToFunctionTargetsAttachmentArrayOutputWithContext(context.Context) FunctionTargetsAttachmentArrayOutput
}

type FunctionTargetsAttachmentArray []FunctionTargetsAttachmentInput

func (FunctionTargetsAttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FunctionTargetsAttachment)(nil)).Elem()
}

func (i FunctionTargetsAttachmentArray) ToFunctionTargetsAttachmentArrayOutput() FunctionTargetsAttachmentArrayOutput {
	return i.ToFunctionTargetsAttachmentArrayOutputWithContext(context.Background())
}

func (i FunctionTargetsAttachmentArray) ToFunctionTargetsAttachmentArrayOutputWithContext(ctx context.Context) FunctionTargetsAttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionTargetsAttachmentArrayOutput)
}

// FunctionTargetsAttachmentMapInput is an input type that accepts FunctionTargetsAttachmentMap and FunctionTargetsAttachmentMapOutput values.
// You can construct a concrete instance of `FunctionTargetsAttachmentMapInput` via:
//
//	FunctionTargetsAttachmentMap{ "key": FunctionTargetsAttachmentArgs{...} }
type FunctionTargetsAttachmentMapInput interface {
	pulumi.Input

	ToFunctionTargetsAttachmentMapOutput() FunctionTargetsAttachmentMapOutput
	ToFunctionTargetsAttachmentMapOutputWithContext(context.Context) FunctionTargetsAttachmentMapOutput
}

type FunctionTargetsAttachmentMap map[string]FunctionTargetsAttachmentInput

func (FunctionTargetsAttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FunctionTargetsAttachment)(nil)).Elem()
}

func (i FunctionTargetsAttachmentMap) ToFunctionTargetsAttachmentMapOutput() FunctionTargetsAttachmentMapOutput {
	return i.ToFunctionTargetsAttachmentMapOutputWithContext(context.Background())
}

func (i FunctionTargetsAttachmentMap) ToFunctionTargetsAttachmentMapOutputWithContext(ctx context.Context) FunctionTargetsAttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionTargetsAttachmentMapOutput)
}

type FunctionTargetsAttachmentOutput struct{ *pulumi.OutputState }

func (FunctionTargetsAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**FunctionTargetsAttachment)(nil)).Elem()
}

func (o FunctionTargetsAttachmentOutput) ToFunctionTargetsAttachmentOutput() FunctionTargetsAttachmentOutput {
	return o
}

func (o FunctionTargetsAttachmentOutput) ToFunctionTargetsAttachmentOutputWithContext(ctx context.Context) FunctionTargetsAttachmentOutput {
	return o
}

// The domain name of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not
// take effect.
func (o FunctionTargetsAttachmentOutput) Domain() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionTargetsAttachment) pulumi.StringOutput { return v.Domain }).(pulumi.StringOutput)
}

// List of cloud functions to be bound.
func (o FunctionTargetsAttachmentOutput) FunctionTargets() FunctionTargetsAttachmentFunctionTargetsOutput {
	return o.ApplyT(func(v *FunctionTargetsAttachment) FunctionTargetsAttachmentFunctionTargetsOutput {
		return v.FunctionTargets
	}).(FunctionTargetsAttachmentFunctionTargetsOutput)
}

// Load Balancer Listener ID.
func (o FunctionTargetsAttachmentOutput) ListenerId() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionTargetsAttachment) pulumi.StringOutput { return v.ListenerId }).(pulumi.StringOutput)
}

// Load Balancer Instance ID.
func (o FunctionTargetsAttachmentOutput) LoadBalancerId() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionTargetsAttachment) pulumi.StringOutput { return v.LoadBalancerId }).(pulumi.StringOutput)
}

// The ID of the target forwarding rule. When binding the cloud function to a layer-7 forwarding rule, this parameter or
// the Domain+Url parameter must be entered.
func (o FunctionTargetsAttachmentOutput) LocationId() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionTargetsAttachment) pulumi.StringOutput { return v.LocationId }).(pulumi.StringOutput)
}

// The URL of the target forwarding rule. If the LocationId parameter has been entered, this parameter will not take
// effect.
func (o FunctionTargetsAttachmentOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionTargetsAttachment) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

type FunctionTargetsAttachmentArrayOutput struct{ *pulumi.OutputState }

func (FunctionTargetsAttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FunctionTargetsAttachment)(nil)).Elem()
}

func (o FunctionTargetsAttachmentArrayOutput) ToFunctionTargetsAttachmentArrayOutput() FunctionTargetsAttachmentArrayOutput {
	return o
}

func (o FunctionTargetsAttachmentArrayOutput) ToFunctionTargetsAttachmentArrayOutputWithContext(ctx context.Context) FunctionTargetsAttachmentArrayOutput {
	return o
}

func (o FunctionTargetsAttachmentArrayOutput) Index(i pulumi.IntInput) FunctionTargetsAttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *FunctionTargetsAttachment {
		return vs[0].([]*FunctionTargetsAttachment)[vs[1].(int)]
	}).(FunctionTargetsAttachmentOutput)
}

type FunctionTargetsAttachmentMapOutput struct{ *pulumi.OutputState }

func (FunctionTargetsAttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FunctionTargetsAttachment)(nil)).Elem()
}

func (o FunctionTargetsAttachmentMapOutput) ToFunctionTargetsAttachmentMapOutput() FunctionTargetsAttachmentMapOutput {
	return o
}

func (o FunctionTargetsAttachmentMapOutput) ToFunctionTargetsAttachmentMapOutputWithContext(ctx context.Context) FunctionTargetsAttachmentMapOutput {
	return o
}

func (o FunctionTargetsAttachmentMapOutput) MapIndex(k pulumi.StringInput) FunctionTargetsAttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *FunctionTargetsAttachment {
		return vs[0].(map[string]*FunctionTargetsAttachment)[vs[1].(string)]
	}).(FunctionTargetsAttachmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionTargetsAttachmentInput)(nil)).Elem(), &FunctionTargetsAttachment{})
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionTargetsAttachmentArrayInput)(nil)).Elem(), FunctionTargetsAttachmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionTargetsAttachmentMapInput)(nil)).Elem(), FunctionTargetsAttachmentMap{})
	pulumi.RegisterOutputType(FunctionTargetsAttachmentOutput{})
	pulumi.RegisterOutputType(FunctionTargetsAttachmentArrayOutput{})
	pulumi.RegisterOutputType(FunctionTargetsAttachmentMapOutput{})
}