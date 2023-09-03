// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cos

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type BucketDomainCertificateAttachment struct {
	pulumi.CustomResourceState

	// Bucket name.
	Bucket pulumi.StringOutput `pulumi:"bucket"`
	// The certificate of specified doamin.
	DomainCertificate BucketDomainCertificateAttachmentDomainCertificateOutput `pulumi:"domainCertificate"`
}

// NewBucketDomainCertificateAttachment registers a new resource with the given unique name, arguments, and options.
func NewBucketDomainCertificateAttachment(ctx *pulumi.Context,
	name string, args *BucketDomainCertificateAttachmentArgs, opts ...pulumi.ResourceOption) (*BucketDomainCertificateAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Bucket == nil {
		return nil, errors.New("invalid value for required argument 'Bucket'")
	}
	if args.DomainCertificate == nil {
		return nil, errors.New("invalid value for required argument 'DomainCertificate'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource BucketDomainCertificateAttachment
	err := ctx.RegisterResource("tencentcloud:Cos/bucketDomainCertificateAttachment:BucketDomainCertificateAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBucketDomainCertificateAttachment gets an existing BucketDomainCertificateAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBucketDomainCertificateAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BucketDomainCertificateAttachmentState, opts ...pulumi.ResourceOption) (*BucketDomainCertificateAttachment, error) {
	var resource BucketDomainCertificateAttachment
	err := ctx.ReadResource("tencentcloud:Cos/bucketDomainCertificateAttachment:BucketDomainCertificateAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BucketDomainCertificateAttachment resources.
type bucketDomainCertificateAttachmentState struct {
	// Bucket name.
	Bucket *string `pulumi:"bucket"`
	// The certificate of specified doamin.
	DomainCertificate *BucketDomainCertificateAttachmentDomainCertificate `pulumi:"domainCertificate"`
}

type BucketDomainCertificateAttachmentState struct {
	// Bucket name.
	Bucket pulumi.StringPtrInput
	// The certificate of specified doamin.
	DomainCertificate BucketDomainCertificateAttachmentDomainCertificatePtrInput
}

func (BucketDomainCertificateAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*bucketDomainCertificateAttachmentState)(nil)).Elem()
}

type bucketDomainCertificateAttachmentArgs struct {
	// Bucket name.
	Bucket string `pulumi:"bucket"`
	// The certificate of specified doamin.
	DomainCertificate BucketDomainCertificateAttachmentDomainCertificate `pulumi:"domainCertificate"`
}

// The set of arguments for constructing a BucketDomainCertificateAttachment resource.
type BucketDomainCertificateAttachmentArgs struct {
	// Bucket name.
	Bucket pulumi.StringInput
	// The certificate of specified doamin.
	DomainCertificate BucketDomainCertificateAttachmentDomainCertificateInput
}

func (BucketDomainCertificateAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bucketDomainCertificateAttachmentArgs)(nil)).Elem()
}

type BucketDomainCertificateAttachmentInput interface {
	pulumi.Input

	ToBucketDomainCertificateAttachmentOutput() BucketDomainCertificateAttachmentOutput
	ToBucketDomainCertificateAttachmentOutputWithContext(ctx context.Context) BucketDomainCertificateAttachmentOutput
}

func (*BucketDomainCertificateAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((**BucketDomainCertificateAttachment)(nil)).Elem()
}

func (i *BucketDomainCertificateAttachment) ToBucketDomainCertificateAttachmentOutput() BucketDomainCertificateAttachmentOutput {
	return i.ToBucketDomainCertificateAttachmentOutputWithContext(context.Background())
}

func (i *BucketDomainCertificateAttachment) ToBucketDomainCertificateAttachmentOutputWithContext(ctx context.Context) BucketDomainCertificateAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BucketDomainCertificateAttachmentOutput)
}

// BucketDomainCertificateAttachmentArrayInput is an input type that accepts BucketDomainCertificateAttachmentArray and BucketDomainCertificateAttachmentArrayOutput values.
// You can construct a concrete instance of `BucketDomainCertificateAttachmentArrayInput` via:
//
//	BucketDomainCertificateAttachmentArray{ BucketDomainCertificateAttachmentArgs{...} }
type BucketDomainCertificateAttachmentArrayInput interface {
	pulumi.Input

	ToBucketDomainCertificateAttachmentArrayOutput() BucketDomainCertificateAttachmentArrayOutput
	ToBucketDomainCertificateAttachmentArrayOutputWithContext(context.Context) BucketDomainCertificateAttachmentArrayOutput
}

type BucketDomainCertificateAttachmentArray []BucketDomainCertificateAttachmentInput

func (BucketDomainCertificateAttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BucketDomainCertificateAttachment)(nil)).Elem()
}

func (i BucketDomainCertificateAttachmentArray) ToBucketDomainCertificateAttachmentArrayOutput() BucketDomainCertificateAttachmentArrayOutput {
	return i.ToBucketDomainCertificateAttachmentArrayOutputWithContext(context.Background())
}

func (i BucketDomainCertificateAttachmentArray) ToBucketDomainCertificateAttachmentArrayOutputWithContext(ctx context.Context) BucketDomainCertificateAttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BucketDomainCertificateAttachmentArrayOutput)
}

// BucketDomainCertificateAttachmentMapInput is an input type that accepts BucketDomainCertificateAttachmentMap and BucketDomainCertificateAttachmentMapOutput values.
// You can construct a concrete instance of `BucketDomainCertificateAttachmentMapInput` via:
//
//	BucketDomainCertificateAttachmentMap{ "key": BucketDomainCertificateAttachmentArgs{...} }
type BucketDomainCertificateAttachmentMapInput interface {
	pulumi.Input

	ToBucketDomainCertificateAttachmentMapOutput() BucketDomainCertificateAttachmentMapOutput
	ToBucketDomainCertificateAttachmentMapOutputWithContext(context.Context) BucketDomainCertificateAttachmentMapOutput
}

type BucketDomainCertificateAttachmentMap map[string]BucketDomainCertificateAttachmentInput

func (BucketDomainCertificateAttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BucketDomainCertificateAttachment)(nil)).Elem()
}

func (i BucketDomainCertificateAttachmentMap) ToBucketDomainCertificateAttachmentMapOutput() BucketDomainCertificateAttachmentMapOutput {
	return i.ToBucketDomainCertificateAttachmentMapOutputWithContext(context.Background())
}

func (i BucketDomainCertificateAttachmentMap) ToBucketDomainCertificateAttachmentMapOutputWithContext(ctx context.Context) BucketDomainCertificateAttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BucketDomainCertificateAttachmentMapOutput)
}

type BucketDomainCertificateAttachmentOutput struct{ *pulumi.OutputState }

func (BucketDomainCertificateAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BucketDomainCertificateAttachment)(nil)).Elem()
}

func (o BucketDomainCertificateAttachmentOutput) ToBucketDomainCertificateAttachmentOutput() BucketDomainCertificateAttachmentOutput {
	return o
}

func (o BucketDomainCertificateAttachmentOutput) ToBucketDomainCertificateAttachmentOutputWithContext(ctx context.Context) BucketDomainCertificateAttachmentOutput {
	return o
}

// Bucket name.
func (o BucketDomainCertificateAttachmentOutput) Bucket() pulumi.StringOutput {
	return o.ApplyT(func(v *BucketDomainCertificateAttachment) pulumi.StringOutput { return v.Bucket }).(pulumi.StringOutput)
}

// The certificate of specified doamin.
func (o BucketDomainCertificateAttachmentOutput) DomainCertificate() BucketDomainCertificateAttachmentDomainCertificateOutput {
	return o.ApplyT(func(v *BucketDomainCertificateAttachment) BucketDomainCertificateAttachmentDomainCertificateOutput {
		return v.DomainCertificate
	}).(BucketDomainCertificateAttachmentDomainCertificateOutput)
}

type BucketDomainCertificateAttachmentArrayOutput struct{ *pulumi.OutputState }

func (BucketDomainCertificateAttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BucketDomainCertificateAttachment)(nil)).Elem()
}

func (o BucketDomainCertificateAttachmentArrayOutput) ToBucketDomainCertificateAttachmentArrayOutput() BucketDomainCertificateAttachmentArrayOutput {
	return o
}

func (o BucketDomainCertificateAttachmentArrayOutput) ToBucketDomainCertificateAttachmentArrayOutputWithContext(ctx context.Context) BucketDomainCertificateAttachmentArrayOutput {
	return o
}

func (o BucketDomainCertificateAttachmentArrayOutput) Index(i pulumi.IntInput) BucketDomainCertificateAttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *BucketDomainCertificateAttachment {
		return vs[0].([]*BucketDomainCertificateAttachment)[vs[1].(int)]
	}).(BucketDomainCertificateAttachmentOutput)
}

type BucketDomainCertificateAttachmentMapOutput struct{ *pulumi.OutputState }

func (BucketDomainCertificateAttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BucketDomainCertificateAttachment)(nil)).Elem()
}

func (o BucketDomainCertificateAttachmentMapOutput) ToBucketDomainCertificateAttachmentMapOutput() BucketDomainCertificateAttachmentMapOutput {
	return o
}

func (o BucketDomainCertificateAttachmentMapOutput) ToBucketDomainCertificateAttachmentMapOutputWithContext(ctx context.Context) BucketDomainCertificateAttachmentMapOutput {
	return o
}

func (o BucketDomainCertificateAttachmentMapOutput) MapIndex(k pulumi.StringInput) BucketDomainCertificateAttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *BucketDomainCertificateAttachment {
		return vs[0].(map[string]*BucketDomainCertificateAttachment)[vs[1].(string)]
	}).(BucketDomainCertificateAttachmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BucketDomainCertificateAttachmentInput)(nil)).Elem(), &BucketDomainCertificateAttachment{})
	pulumi.RegisterInputType(reflect.TypeOf((*BucketDomainCertificateAttachmentArrayInput)(nil)).Elem(), BucketDomainCertificateAttachmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*BucketDomainCertificateAttachmentMapInput)(nil)).Elem(), BucketDomainCertificateAttachmentMap{})
	pulumi.RegisterOutputType(BucketDomainCertificateAttachmentOutput{})
	pulumi.RegisterOutputType(BucketDomainCertificateAttachmentArrayOutput{})
	pulumi.RegisterOutputType(BucketDomainCertificateAttachmentMapOutput{})
}