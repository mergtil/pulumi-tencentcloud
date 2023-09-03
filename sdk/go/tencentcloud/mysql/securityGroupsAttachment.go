// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type SecurityGroupsAttachment struct {
	pulumi.CustomResourceState

	// The id of instance.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// The ID of security group.
	SecurityGroupId pulumi.StringOutput `pulumi:"securityGroupId"`
}

// NewSecurityGroupsAttachment registers a new resource with the given unique name, arguments, and options.
func NewSecurityGroupsAttachment(ctx *pulumi.Context,
	name string, args *SecurityGroupsAttachmentArgs, opts ...pulumi.ResourceOption) (*SecurityGroupsAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.SecurityGroupId == nil {
		return nil, errors.New("invalid value for required argument 'SecurityGroupId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource SecurityGroupsAttachment
	err := ctx.RegisterResource("tencentcloud:Mysql/securityGroupsAttachment:SecurityGroupsAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityGroupsAttachment gets an existing SecurityGroupsAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityGroupsAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityGroupsAttachmentState, opts ...pulumi.ResourceOption) (*SecurityGroupsAttachment, error) {
	var resource SecurityGroupsAttachment
	err := ctx.ReadResource("tencentcloud:Mysql/securityGroupsAttachment:SecurityGroupsAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityGroupsAttachment resources.
type securityGroupsAttachmentState struct {
	// The id of instance.
	InstanceId *string `pulumi:"instanceId"`
	// The ID of security group.
	SecurityGroupId *string `pulumi:"securityGroupId"`
}

type SecurityGroupsAttachmentState struct {
	// The id of instance.
	InstanceId pulumi.StringPtrInput
	// The ID of security group.
	SecurityGroupId pulumi.StringPtrInput
}

func (SecurityGroupsAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityGroupsAttachmentState)(nil)).Elem()
}

type securityGroupsAttachmentArgs struct {
	// The id of instance.
	InstanceId string `pulumi:"instanceId"`
	// The ID of security group.
	SecurityGroupId string `pulumi:"securityGroupId"`
}

// The set of arguments for constructing a SecurityGroupsAttachment resource.
type SecurityGroupsAttachmentArgs struct {
	// The id of instance.
	InstanceId pulumi.StringInput
	// The ID of security group.
	SecurityGroupId pulumi.StringInput
}

func (SecurityGroupsAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityGroupsAttachmentArgs)(nil)).Elem()
}

type SecurityGroupsAttachmentInput interface {
	pulumi.Input

	ToSecurityGroupsAttachmentOutput() SecurityGroupsAttachmentOutput
	ToSecurityGroupsAttachmentOutputWithContext(ctx context.Context) SecurityGroupsAttachmentOutput
}

func (*SecurityGroupsAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((**SecurityGroupsAttachment)(nil)).Elem()
}

func (i *SecurityGroupsAttachment) ToSecurityGroupsAttachmentOutput() SecurityGroupsAttachmentOutput {
	return i.ToSecurityGroupsAttachmentOutputWithContext(context.Background())
}

func (i *SecurityGroupsAttachment) ToSecurityGroupsAttachmentOutputWithContext(ctx context.Context) SecurityGroupsAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupsAttachmentOutput)
}

// SecurityGroupsAttachmentArrayInput is an input type that accepts SecurityGroupsAttachmentArray and SecurityGroupsAttachmentArrayOutput values.
// You can construct a concrete instance of `SecurityGroupsAttachmentArrayInput` via:
//
//	SecurityGroupsAttachmentArray{ SecurityGroupsAttachmentArgs{...} }
type SecurityGroupsAttachmentArrayInput interface {
	pulumi.Input

	ToSecurityGroupsAttachmentArrayOutput() SecurityGroupsAttachmentArrayOutput
	ToSecurityGroupsAttachmentArrayOutputWithContext(context.Context) SecurityGroupsAttachmentArrayOutput
}

type SecurityGroupsAttachmentArray []SecurityGroupsAttachmentInput

func (SecurityGroupsAttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SecurityGroupsAttachment)(nil)).Elem()
}

func (i SecurityGroupsAttachmentArray) ToSecurityGroupsAttachmentArrayOutput() SecurityGroupsAttachmentArrayOutput {
	return i.ToSecurityGroupsAttachmentArrayOutputWithContext(context.Background())
}

func (i SecurityGroupsAttachmentArray) ToSecurityGroupsAttachmentArrayOutputWithContext(ctx context.Context) SecurityGroupsAttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupsAttachmentArrayOutput)
}

// SecurityGroupsAttachmentMapInput is an input type that accepts SecurityGroupsAttachmentMap and SecurityGroupsAttachmentMapOutput values.
// You can construct a concrete instance of `SecurityGroupsAttachmentMapInput` via:
//
//	SecurityGroupsAttachmentMap{ "key": SecurityGroupsAttachmentArgs{...} }
type SecurityGroupsAttachmentMapInput interface {
	pulumi.Input

	ToSecurityGroupsAttachmentMapOutput() SecurityGroupsAttachmentMapOutput
	ToSecurityGroupsAttachmentMapOutputWithContext(context.Context) SecurityGroupsAttachmentMapOutput
}

type SecurityGroupsAttachmentMap map[string]SecurityGroupsAttachmentInput

func (SecurityGroupsAttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SecurityGroupsAttachment)(nil)).Elem()
}

func (i SecurityGroupsAttachmentMap) ToSecurityGroupsAttachmentMapOutput() SecurityGroupsAttachmentMapOutput {
	return i.ToSecurityGroupsAttachmentMapOutputWithContext(context.Background())
}

func (i SecurityGroupsAttachmentMap) ToSecurityGroupsAttachmentMapOutputWithContext(ctx context.Context) SecurityGroupsAttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupsAttachmentMapOutput)
}

type SecurityGroupsAttachmentOutput struct{ *pulumi.OutputState }

func (SecurityGroupsAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SecurityGroupsAttachment)(nil)).Elem()
}

func (o SecurityGroupsAttachmentOutput) ToSecurityGroupsAttachmentOutput() SecurityGroupsAttachmentOutput {
	return o
}

func (o SecurityGroupsAttachmentOutput) ToSecurityGroupsAttachmentOutputWithContext(ctx context.Context) SecurityGroupsAttachmentOutput {
	return o
}

// The id of instance.
func (o SecurityGroupsAttachmentOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityGroupsAttachment) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// The ID of security group.
func (o SecurityGroupsAttachmentOutput) SecurityGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *SecurityGroupsAttachment) pulumi.StringOutput { return v.SecurityGroupId }).(pulumi.StringOutput)
}

type SecurityGroupsAttachmentArrayOutput struct{ *pulumi.OutputState }

func (SecurityGroupsAttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SecurityGroupsAttachment)(nil)).Elem()
}

func (o SecurityGroupsAttachmentArrayOutput) ToSecurityGroupsAttachmentArrayOutput() SecurityGroupsAttachmentArrayOutput {
	return o
}

func (o SecurityGroupsAttachmentArrayOutput) ToSecurityGroupsAttachmentArrayOutputWithContext(ctx context.Context) SecurityGroupsAttachmentArrayOutput {
	return o
}

func (o SecurityGroupsAttachmentArrayOutput) Index(i pulumi.IntInput) SecurityGroupsAttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SecurityGroupsAttachment {
		return vs[0].([]*SecurityGroupsAttachment)[vs[1].(int)]
	}).(SecurityGroupsAttachmentOutput)
}

type SecurityGroupsAttachmentMapOutput struct{ *pulumi.OutputState }

func (SecurityGroupsAttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SecurityGroupsAttachment)(nil)).Elem()
}

func (o SecurityGroupsAttachmentMapOutput) ToSecurityGroupsAttachmentMapOutput() SecurityGroupsAttachmentMapOutput {
	return o
}

func (o SecurityGroupsAttachmentMapOutput) ToSecurityGroupsAttachmentMapOutputWithContext(ctx context.Context) SecurityGroupsAttachmentMapOutput {
	return o
}

func (o SecurityGroupsAttachmentMapOutput) MapIndex(k pulumi.StringInput) SecurityGroupsAttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SecurityGroupsAttachment {
		return vs[0].(map[string]*SecurityGroupsAttachment)[vs[1].(string)]
	}).(SecurityGroupsAttachmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityGroupsAttachmentInput)(nil)).Elem(), &SecurityGroupsAttachment{})
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityGroupsAttachmentArrayInput)(nil)).Elem(), SecurityGroupsAttachmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityGroupsAttachmentMapInput)(nil)).Elem(), SecurityGroupsAttachmentMap{})
	pulumi.RegisterOutputType(SecurityGroupsAttachmentOutput{})
	pulumi.RegisterOutputType(SecurityGroupsAttachmentArrayOutput{})
	pulumi.RegisterOutputType(SecurityGroupsAttachmentMapOutput{})
}