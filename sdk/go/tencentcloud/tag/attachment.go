// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tag

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type Attachment struct {
	pulumi.CustomResourceState

	// [Six-segment description of resources](https://cloud.tencent.com/document/product/598/10606).
	Resource pulumi.StringOutput `pulumi:"resource"`
	// tag key.
	TagKey pulumi.StringOutput `pulumi:"tagKey"`
	// tag value.
	TagValue pulumi.StringOutput `pulumi:"tagValue"`
}

// NewAttachment registers a new resource with the given unique name, arguments, and options.
func NewAttachment(ctx *pulumi.Context,
	name string, args *AttachmentArgs, opts ...pulumi.ResourceOption) (*Attachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Resource == nil {
		return nil, errors.New("invalid value for required argument 'Resource'")
	}
	if args.TagKey == nil {
		return nil, errors.New("invalid value for required argument 'TagKey'")
	}
	if args.TagValue == nil {
		return nil, errors.New("invalid value for required argument 'TagValue'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Attachment
	err := ctx.RegisterResource("tencentcloud:Tag/attachment:Attachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAttachment gets an existing Attachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AttachmentState, opts ...pulumi.ResourceOption) (*Attachment, error) {
	var resource Attachment
	err := ctx.ReadResource("tencentcloud:Tag/attachment:Attachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Attachment resources.
type attachmentState struct {
	// [Six-segment description of resources](https://cloud.tencent.com/document/product/598/10606).
	Resource *string `pulumi:"resource"`
	// tag key.
	TagKey *string `pulumi:"tagKey"`
	// tag value.
	TagValue *string `pulumi:"tagValue"`
}

type AttachmentState struct {
	// [Six-segment description of resources](https://cloud.tencent.com/document/product/598/10606).
	Resource pulumi.StringPtrInput
	// tag key.
	TagKey pulumi.StringPtrInput
	// tag value.
	TagValue pulumi.StringPtrInput
}

func (AttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*attachmentState)(nil)).Elem()
}

type attachmentArgs struct {
	// [Six-segment description of resources](https://cloud.tencent.com/document/product/598/10606).
	Resource string `pulumi:"resource"`
	// tag key.
	TagKey string `pulumi:"tagKey"`
	// tag value.
	TagValue string `pulumi:"tagValue"`
}

// The set of arguments for constructing a Attachment resource.
type AttachmentArgs struct {
	// [Six-segment description of resources](https://cloud.tencent.com/document/product/598/10606).
	Resource pulumi.StringInput
	// tag key.
	TagKey pulumi.StringInput
	// tag value.
	TagValue pulumi.StringInput
}

func (AttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*attachmentArgs)(nil)).Elem()
}

type AttachmentInput interface {
	pulumi.Input

	ToAttachmentOutput() AttachmentOutput
	ToAttachmentOutputWithContext(ctx context.Context) AttachmentOutput
}

func (*Attachment) ElementType() reflect.Type {
	return reflect.TypeOf((**Attachment)(nil)).Elem()
}

func (i *Attachment) ToAttachmentOutput() AttachmentOutput {
	return i.ToAttachmentOutputWithContext(context.Background())
}

func (i *Attachment) ToAttachmentOutputWithContext(ctx context.Context) AttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttachmentOutput)
}

// AttachmentArrayInput is an input type that accepts AttachmentArray and AttachmentArrayOutput values.
// You can construct a concrete instance of `AttachmentArrayInput` via:
//
//	AttachmentArray{ AttachmentArgs{...} }
type AttachmentArrayInput interface {
	pulumi.Input

	ToAttachmentArrayOutput() AttachmentArrayOutput
	ToAttachmentArrayOutputWithContext(context.Context) AttachmentArrayOutput
}

type AttachmentArray []AttachmentInput

func (AttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Attachment)(nil)).Elem()
}

func (i AttachmentArray) ToAttachmentArrayOutput() AttachmentArrayOutput {
	return i.ToAttachmentArrayOutputWithContext(context.Background())
}

func (i AttachmentArray) ToAttachmentArrayOutputWithContext(ctx context.Context) AttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttachmentArrayOutput)
}

// AttachmentMapInput is an input type that accepts AttachmentMap and AttachmentMapOutput values.
// You can construct a concrete instance of `AttachmentMapInput` via:
//
//	AttachmentMap{ "key": AttachmentArgs{...} }
type AttachmentMapInput interface {
	pulumi.Input

	ToAttachmentMapOutput() AttachmentMapOutput
	ToAttachmentMapOutputWithContext(context.Context) AttachmentMapOutput
}

type AttachmentMap map[string]AttachmentInput

func (AttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Attachment)(nil)).Elem()
}

func (i AttachmentMap) ToAttachmentMapOutput() AttachmentMapOutput {
	return i.ToAttachmentMapOutputWithContext(context.Background())
}

func (i AttachmentMap) ToAttachmentMapOutputWithContext(ctx context.Context) AttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttachmentMapOutput)
}

type AttachmentOutput struct{ *pulumi.OutputState }

func (AttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Attachment)(nil)).Elem()
}

func (o AttachmentOutput) ToAttachmentOutput() AttachmentOutput {
	return o
}

func (o AttachmentOutput) ToAttachmentOutputWithContext(ctx context.Context) AttachmentOutput {
	return o
}

// [Six-segment description of resources](https://cloud.tencent.com/document/product/598/10606).
func (o AttachmentOutput) Resource() pulumi.StringOutput {
	return o.ApplyT(func(v *Attachment) pulumi.StringOutput { return v.Resource }).(pulumi.StringOutput)
}

// tag key.
func (o AttachmentOutput) TagKey() pulumi.StringOutput {
	return o.ApplyT(func(v *Attachment) pulumi.StringOutput { return v.TagKey }).(pulumi.StringOutput)
}

// tag value.
func (o AttachmentOutput) TagValue() pulumi.StringOutput {
	return o.ApplyT(func(v *Attachment) pulumi.StringOutput { return v.TagValue }).(pulumi.StringOutput)
}

type AttachmentArrayOutput struct{ *pulumi.OutputState }

func (AttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Attachment)(nil)).Elem()
}

func (o AttachmentArrayOutput) ToAttachmentArrayOutput() AttachmentArrayOutput {
	return o
}

func (o AttachmentArrayOutput) ToAttachmentArrayOutputWithContext(ctx context.Context) AttachmentArrayOutput {
	return o
}

func (o AttachmentArrayOutput) Index(i pulumi.IntInput) AttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Attachment {
		return vs[0].([]*Attachment)[vs[1].(int)]
	}).(AttachmentOutput)
}

type AttachmentMapOutput struct{ *pulumi.OutputState }

func (AttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Attachment)(nil)).Elem()
}

func (o AttachmentMapOutput) ToAttachmentMapOutput() AttachmentMapOutput {
	return o
}

func (o AttachmentMapOutput) ToAttachmentMapOutputWithContext(ctx context.Context) AttachmentMapOutput {
	return o
}

func (o AttachmentMapOutput) MapIndex(k pulumi.StringInput) AttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Attachment {
		return vs[0].(map[string]*Attachment)[vs[1].(string)]
	}).(AttachmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AttachmentInput)(nil)).Elem(), &Attachment{})
	pulumi.RegisterInputType(reflect.TypeOf((*AttachmentArrayInput)(nil)).Elem(), AttachmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AttachmentMapInput)(nil)).Elem(), AttachmentMap{})
	pulumi.RegisterOutputType(AttachmentOutput{})
	pulumi.RegisterOutputType(AttachmentArrayOutput{})
	pulumi.RegisterOutputType(AttachmentMapOutput{})
}