// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cbs

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type StorageSetAttachment struct {
	pulumi.CustomResourceState

	// ID of the CVM instance.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// ID of the mounted CBS.
	StorageId pulumi.StringOutput `pulumi:"storageId"`
}

// NewStorageSetAttachment registers a new resource with the given unique name, arguments, and options.
func NewStorageSetAttachment(ctx *pulumi.Context,
	name string, args *StorageSetAttachmentArgs, opts ...pulumi.ResourceOption) (*StorageSetAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.StorageId == nil {
		return nil, errors.New("invalid value for required argument 'StorageId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource StorageSetAttachment
	err := ctx.RegisterResource("tencentcloud:Cbs/storageSetAttachment:StorageSetAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStorageSetAttachment gets an existing StorageSetAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStorageSetAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StorageSetAttachmentState, opts ...pulumi.ResourceOption) (*StorageSetAttachment, error) {
	var resource StorageSetAttachment
	err := ctx.ReadResource("tencentcloud:Cbs/storageSetAttachment:StorageSetAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StorageSetAttachment resources.
type storageSetAttachmentState struct {
	// ID of the CVM instance.
	InstanceId *string `pulumi:"instanceId"`
	// ID of the mounted CBS.
	StorageId *string `pulumi:"storageId"`
}

type StorageSetAttachmentState struct {
	// ID of the CVM instance.
	InstanceId pulumi.StringPtrInput
	// ID of the mounted CBS.
	StorageId pulumi.StringPtrInput
}

func (StorageSetAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*storageSetAttachmentState)(nil)).Elem()
}

type storageSetAttachmentArgs struct {
	// ID of the CVM instance.
	InstanceId string `pulumi:"instanceId"`
	// ID of the mounted CBS.
	StorageId string `pulumi:"storageId"`
}

// The set of arguments for constructing a StorageSetAttachment resource.
type StorageSetAttachmentArgs struct {
	// ID of the CVM instance.
	InstanceId pulumi.StringInput
	// ID of the mounted CBS.
	StorageId pulumi.StringInput
}

func (StorageSetAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*storageSetAttachmentArgs)(nil)).Elem()
}

type StorageSetAttachmentInput interface {
	pulumi.Input

	ToStorageSetAttachmentOutput() StorageSetAttachmentOutput
	ToStorageSetAttachmentOutputWithContext(ctx context.Context) StorageSetAttachmentOutput
}

func (*StorageSetAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((**StorageSetAttachment)(nil)).Elem()
}

func (i *StorageSetAttachment) ToStorageSetAttachmentOutput() StorageSetAttachmentOutput {
	return i.ToStorageSetAttachmentOutputWithContext(context.Background())
}

func (i *StorageSetAttachment) ToStorageSetAttachmentOutputWithContext(ctx context.Context) StorageSetAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StorageSetAttachmentOutput)
}

// StorageSetAttachmentArrayInput is an input type that accepts StorageSetAttachmentArray and StorageSetAttachmentArrayOutput values.
// You can construct a concrete instance of `StorageSetAttachmentArrayInput` via:
//
//	StorageSetAttachmentArray{ StorageSetAttachmentArgs{...} }
type StorageSetAttachmentArrayInput interface {
	pulumi.Input

	ToStorageSetAttachmentArrayOutput() StorageSetAttachmentArrayOutput
	ToStorageSetAttachmentArrayOutputWithContext(context.Context) StorageSetAttachmentArrayOutput
}

type StorageSetAttachmentArray []StorageSetAttachmentInput

func (StorageSetAttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*StorageSetAttachment)(nil)).Elem()
}

func (i StorageSetAttachmentArray) ToStorageSetAttachmentArrayOutput() StorageSetAttachmentArrayOutput {
	return i.ToStorageSetAttachmentArrayOutputWithContext(context.Background())
}

func (i StorageSetAttachmentArray) ToStorageSetAttachmentArrayOutputWithContext(ctx context.Context) StorageSetAttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StorageSetAttachmentArrayOutput)
}

// StorageSetAttachmentMapInput is an input type that accepts StorageSetAttachmentMap and StorageSetAttachmentMapOutput values.
// You can construct a concrete instance of `StorageSetAttachmentMapInput` via:
//
//	StorageSetAttachmentMap{ "key": StorageSetAttachmentArgs{...} }
type StorageSetAttachmentMapInput interface {
	pulumi.Input

	ToStorageSetAttachmentMapOutput() StorageSetAttachmentMapOutput
	ToStorageSetAttachmentMapOutputWithContext(context.Context) StorageSetAttachmentMapOutput
}

type StorageSetAttachmentMap map[string]StorageSetAttachmentInput

func (StorageSetAttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*StorageSetAttachment)(nil)).Elem()
}

func (i StorageSetAttachmentMap) ToStorageSetAttachmentMapOutput() StorageSetAttachmentMapOutput {
	return i.ToStorageSetAttachmentMapOutputWithContext(context.Background())
}

func (i StorageSetAttachmentMap) ToStorageSetAttachmentMapOutputWithContext(ctx context.Context) StorageSetAttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StorageSetAttachmentMapOutput)
}

type StorageSetAttachmentOutput struct{ *pulumi.OutputState }

func (StorageSetAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**StorageSetAttachment)(nil)).Elem()
}

func (o StorageSetAttachmentOutput) ToStorageSetAttachmentOutput() StorageSetAttachmentOutput {
	return o
}

func (o StorageSetAttachmentOutput) ToStorageSetAttachmentOutputWithContext(ctx context.Context) StorageSetAttachmentOutput {
	return o
}

// ID of the CVM instance.
func (o StorageSetAttachmentOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *StorageSetAttachment) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// ID of the mounted CBS.
func (o StorageSetAttachmentOutput) StorageId() pulumi.StringOutput {
	return o.ApplyT(func(v *StorageSetAttachment) pulumi.StringOutput { return v.StorageId }).(pulumi.StringOutput)
}

type StorageSetAttachmentArrayOutput struct{ *pulumi.OutputState }

func (StorageSetAttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*StorageSetAttachment)(nil)).Elem()
}

func (o StorageSetAttachmentArrayOutput) ToStorageSetAttachmentArrayOutput() StorageSetAttachmentArrayOutput {
	return o
}

func (o StorageSetAttachmentArrayOutput) ToStorageSetAttachmentArrayOutputWithContext(ctx context.Context) StorageSetAttachmentArrayOutput {
	return o
}

func (o StorageSetAttachmentArrayOutput) Index(i pulumi.IntInput) StorageSetAttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *StorageSetAttachment {
		return vs[0].([]*StorageSetAttachment)[vs[1].(int)]
	}).(StorageSetAttachmentOutput)
}

type StorageSetAttachmentMapOutput struct{ *pulumi.OutputState }

func (StorageSetAttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*StorageSetAttachment)(nil)).Elem()
}

func (o StorageSetAttachmentMapOutput) ToStorageSetAttachmentMapOutput() StorageSetAttachmentMapOutput {
	return o
}

func (o StorageSetAttachmentMapOutput) ToStorageSetAttachmentMapOutputWithContext(ctx context.Context) StorageSetAttachmentMapOutput {
	return o
}

func (o StorageSetAttachmentMapOutput) MapIndex(k pulumi.StringInput) StorageSetAttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *StorageSetAttachment {
		return vs[0].(map[string]*StorageSetAttachment)[vs[1].(string)]
	}).(StorageSetAttachmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*StorageSetAttachmentInput)(nil)).Elem(), &StorageSetAttachment{})
	pulumi.RegisterInputType(reflect.TypeOf((*StorageSetAttachmentArrayInput)(nil)).Elem(), StorageSetAttachmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*StorageSetAttachmentMapInput)(nil)).Elem(), StorageSetAttachmentMap{})
	pulumi.RegisterOutputType(StorageSetAttachmentOutput{})
	pulumi.RegisterOutputType(StorageSetAttachmentArrayOutput{})
	pulumi.RegisterOutputType(StorageSetAttachmentMapOutput{})
}