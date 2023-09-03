// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package postgresql

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type ModifySwitchTimePeriodOperation struct {
	pulumi.CustomResourceState

	// The ID of the instance waiting for a switch.
	DbInstanceId pulumi.StringOutput `pulumi:"dbInstanceId"`
	// Valid value: `0` (switch immediately).
	SwitchTag pulumi.IntOutput `pulumi:"switchTag"`
}

// NewModifySwitchTimePeriodOperation registers a new resource with the given unique name, arguments, and options.
func NewModifySwitchTimePeriodOperation(ctx *pulumi.Context,
	name string, args *ModifySwitchTimePeriodOperationArgs, opts ...pulumi.ResourceOption) (*ModifySwitchTimePeriodOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DbInstanceId == nil {
		return nil, errors.New("invalid value for required argument 'DbInstanceId'")
	}
	if args.SwitchTag == nil {
		return nil, errors.New("invalid value for required argument 'SwitchTag'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ModifySwitchTimePeriodOperation
	err := ctx.RegisterResource("tencentcloud:Postgresql/modifySwitchTimePeriodOperation:ModifySwitchTimePeriodOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetModifySwitchTimePeriodOperation gets an existing ModifySwitchTimePeriodOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetModifySwitchTimePeriodOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ModifySwitchTimePeriodOperationState, opts ...pulumi.ResourceOption) (*ModifySwitchTimePeriodOperation, error) {
	var resource ModifySwitchTimePeriodOperation
	err := ctx.ReadResource("tencentcloud:Postgresql/modifySwitchTimePeriodOperation:ModifySwitchTimePeriodOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ModifySwitchTimePeriodOperation resources.
type modifySwitchTimePeriodOperationState struct {
	// The ID of the instance waiting for a switch.
	DbInstanceId *string `pulumi:"dbInstanceId"`
	// Valid value: `0` (switch immediately).
	SwitchTag *int `pulumi:"switchTag"`
}

type ModifySwitchTimePeriodOperationState struct {
	// The ID of the instance waiting for a switch.
	DbInstanceId pulumi.StringPtrInput
	// Valid value: `0` (switch immediately).
	SwitchTag pulumi.IntPtrInput
}

func (ModifySwitchTimePeriodOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*modifySwitchTimePeriodOperationState)(nil)).Elem()
}

type modifySwitchTimePeriodOperationArgs struct {
	// The ID of the instance waiting for a switch.
	DbInstanceId string `pulumi:"dbInstanceId"`
	// Valid value: `0` (switch immediately).
	SwitchTag int `pulumi:"switchTag"`
}

// The set of arguments for constructing a ModifySwitchTimePeriodOperation resource.
type ModifySwitchTimePeriodOperationArgs struct {
	// The ID of the instance waiting for a switch.
	DbInstanceId pulumi.StringInput
	// Valid value: `0` (switch immediately).
	SwitchTag pulumi.IntInput
}

func (ModifySwitchTimePeriodOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*modifySwitchTimePeriodOperationArgs)(nil)).Elem()
}

type ModifySwitchTimePeriodOperationInput interface {
	pulumi.Input

	ToModifySwitchTimePeriodOperationOutput() ModifySwitchTimePeriodOperationOutput
	ToModifySwitchTimePeriodOperationOutputWithContext(ctx context.Context) ModifySwitchTimePeriodOperationOutput
}

func (*ModifySwitchTimePeriodOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**ModifySwitchTimePeriodOperation)(nil)).Elem()
}

func (i *ModifySwitchTimePeriodOperation) ToModifySwitchTimePeriodOperationOutput() ModifySwitchTimePeriodOperationOutput {
	return i.ToModifySwitchTimePeriodOperationOutputWithContext(context.Background())
}

func (i *ModifySwitchTimePeriodOperation) ToModifySwitchTimePeriodOperationOutputWithContext(ctx context.Context) ModifySwitchTimePeriodOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModifySwitchTimePeriodOperationOutput)
}

// ModifySwitchTimePeriodOperationArrayInput is an input type that accepts ModifySwitchTimePeriodOperationArray and ModifySwitchTimePeriodOperationArrayOutput values.
// You can construct a concrete instance of `ModifySwitchTimePeriodOperationArrayInput` via:
//
//	ModifySwitchTimePeriodOperationArray{ ModifySwitchTimePeriodOperationArgs{...} }
type ModifySwitchTimePeriodOperationArrayInput interface {
	pulumi.Input

	ToModifySwitchTimePeriodOperationArrayOutput() ModifySwitchTimePeriodOperationArrayOutput
	ToModifySwitchTimePeriodOperationArrayOutputWithContext(context.Context) ModifySwitchTimePeriodOperationArrayOutput
}

type ModifySwitchTimePeriodOperationArray []ModifySwitchTimePeriodOperationInput

func (ModifySwitchTimePeriodOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ModifySwitchTimePeriodOperation)(nil)).Elem()
}

func (i ModifySwitchTimePeriodOperationArray) ToModifySwitchTimePeriodOperationArrayOutput() ModifySwitchTimePeriodOperationArrayOutput {
	return i.ToModifySwitchTimePeriodOperationArrayOutputWithContext(context.Background())
}

func (i ModifySwitchTimePeriodOperationArray) ToModifySwitchTimePeriodOperationArrayOutputWithContext(ctx context.Context) ModifySwitchTimePeriodOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModifySwitchTimePeriodOperationArrayOutput)
}

// ModifySwitchTimePeriodOperationMapInput is an input type that accepts ModifySwitchTimePeriodOperationMap and ModifySwitchTimePeriodOperationMapOutput values.
// You can construct a concrete instance of `ModifySwitchTimePeriodOperationMapInput` via:
//
//	ModifySwitchTimePeriodOperationMap{ "key": ModifySwitchTimePeriodOperationArgs{...} }
type ModifySwitchTimePeriodOperationMapInput interface {
	pulumi.Input

	ToModifySwitchTimePeriodOperationMapOutput() ModifySwitchTimePeriodOperationMapOutput
	ToModifySwitchTimePeriodOperationMapOutputWithContext(context.Context) ModifySwitchTimePeriodOperationMapOutput
}

type ModifySwitchTimePeriodOperationMap map[string]ModifySwitchTimePeriodOperationInput

func (ModifySwitchTimePeriodOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ModifySwitchTimePeriodOperation)(nil)).Elem()
}

func (i ModifySwitchTimePeriodOperationMap) ToModifySwitchTimePeriodOperationMapOutput() ModifySwitchTimePeriodOperationMapOutput {
	return i.ToModifySwitchTimePeriodOperationMapOutputWithContext(context.Background())
}

func (i ModifySwitchTimePeriodOperationMap) ToModifySwitchTimePeriodOperationMapOutputWithContext(ctx context.Context) ModifySwitchTimePeriodOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModifySwitchTimePeriodOperationMapOutput)
}

type ModifySwitchTimePeriodOperationOutput struct{ *pulumi.OutputState }

func (ModifySwitchTimePeriodOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ModifySwitchTimePeriodOperation)(nil)).Elem()
}

func (o ModifySwitchTimePeriodOperationOutput) ToModifySwitchTimePeriodOperationOutput() ModifySwitchTimePeriodOperationOutput {
	return o
}

func (o ModifySwitchTimePeriodOperationOutput) ToModifySwitchTimePeriodOperationOutputWithContext(ctx context.Context) ModifySwitchTimePeriodOperationOutput {
	return o
}

// The ID of the instance waiting for a switch.
func (o ModifySwitchTimePeriodOperationOutput) DbInstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *ModifySwitchTimePeriodOperation) pulumi.StringOutput { return v.DbInstanceId }).(pulumi.StringOutput)
}

// Valid value: `0` (switch immediately).
func (o ModifySwitchTimePeriodOperationOutput) SwitchTag() pulumi.IntOutput {
	return o.ApplyT(func(v *ModifySwitchTimePeriodOperation) pulumi.IntOutput { return v.SwitchTag }).(pulumi.IntOutput)
}

type ModifySwitchTimePeriodOperationArrayOutput struct{ *pulumi.OutputState }

func (ModifySwitchTimePeriodOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ModifySwitchTimePeriodOperation)(nil)).Elem()
}

func (o ModifySwitchTimePeriodOperationArrayOutput) ToModifySwitchTimePeriodOperationArrayOutput() ModifySwitchTimePeriodOperationArrayOutput {
	return o
}

func (o ModifySwitchTimePeriodOperationArrayOutput) ToModifySwitchTimePeriodOperationArrayOutputWithContext(ctx context.Context) ModifySwitchTimePeriodOperationArrayOutput {
	return o
}

func (o ModifySwitchTimePeriodOperationArrayOutput) Index(i pulumi.IntInput) ModifySwitchTimePeriodOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ModifySwitchTimePeriodOperation {
		return vs[0].([]*ModifySwitchTimePeriodOperation)[vs[1].(int)]
	}).(ModifySwitchTimePeriodOperationOutput)
}

type ModifySwitchTimePeriodOperationMapOutput struct{ *pulumi.OutputState }

func (ModifySwitchTimePeriodOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ModifySwitchTimePeriodOperation)(nil)).Elem()
}

func (o ModifySwitchTimePeriodOperationMapOutput) ToModifySwitchTimePeriodOperationMapOutput() ModifySwitchTimePeriodOperationMapOutput {
	return o
}

func (o ModifySwitchTimePeriodOperationMapOutput) ToModifySwitchTimePeriodOperationMapOutputWithContext(ctx context.Context) ModifySwitchTimePeriodOperationMapOutput {
	return o
}

func (o ModifySwitchTimePeriodOperationMapOutput) MapIndex(k pulumi.StringInput) ModifySwitchTimePeriodOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ModifySwitchTimePeriodOperation {
		return vs[0].(map[string]*ModifySwitchTimePeriodOperation)[vs[1].(string)]
	}).(ModifySwitchTimePeriodOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ModifySwitchTimePeriodOperationInput)(nil)).Elem(), &ModifySwitchTimePeriodOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*ModifySwitchTimePeriodOperationArrayInput)(nil)).Elem(), ModifySwitchTimePeriodOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ModifySwitchTimePeriodOperationMapInput)(nil)).Elem(), ModifySwitchTimePeriodOperationMap{})
	pulumi.RegisterOutputType(ModifySwitchTimePeriodOperationOutput{})
	pulumi.RegisterOutputType(ModifySwitchTimePeriodOperationArrayOutput{})
	pulumi.RegisterOutputType(ModifySwitchTimePeriodOperationMapOutput{})
}