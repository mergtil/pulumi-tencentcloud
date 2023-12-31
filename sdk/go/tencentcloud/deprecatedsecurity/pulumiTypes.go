// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package deprecatedsecurity

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

var _ = internal.GetEnvOrDefault

type GroupRuleAddressTemplate struct {
	GroupId    *string `pulumi:"groupId"`
	TemplateId *string `pulumi:"templateId"`
}

// GroupRuleAddressTemplateInput is an input type that accepts GroupRuleAddressTemplateArgs and GroupRuleAddressTemplateOutput values.
// You can construct a concrete instance of `GroupRuleAddressTemplateInput` via:
//
//	GroupRuleAddressTemplateArgs{...}
type GroupRuleAddressTemplateInput interface {
	pulumi.Input

	ToGroupRuleAddressTemplateOutput() GroupRuleAddressTemplateOutput
	ToGroupRuleAddressTemplateOutputWithContext(context.Context) GroupRuleAddressTemplateOutput
}

type GroupRuleAddressTemplateArgs struct {
	GroupId    pulumi.StringPtrInput `pulumi:"groupId"`
	TemplateId pulumi.StringPtrInput `pulumi:"templateId"`
}

func (GroupRuleAddressTemplateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GroupRuleAddressTemplate)(nil)).Elem()
}

func (i GroupRuleAddressTemplateArgs) ToGroupRuleAddressTemplateOutput() GroupRuleAddressTemplateOutput {
	return i.ToGroupRuleAddressTemplateOutputWithContext(context.Background())
}

func (i GroupRuleAddressTemplateArgs) ToGroupRuleAddressTemplateOutputWithContext(ctx context.Context) GroupRuleAddressTemplateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GroupRuleAddressTemplateOutput)
}

func (i GroupRuleAddressTemplateArgs) ToGroupRuleAddressTemplatePtrOutput() GroupRuleAddressTemplatePtrOutput {
	return i.ToGroupRuleAddressTemplatePtrOutputWithContext(context.Background())
}

func (i GroupRuleAddressTemplateArgs) ToGroupRuleAddressTemplatePtrOutputWithContext(ctx context.Context) GroupRuleAddressTemplatePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GroupRuleAddressTemplateOutput).ToGroupRuleAddressTemplatePtrOutputWithContext(ctx)
}

// GroupRuleAddressTemplatePtrInput is an input type that accepts GroupRuleAddressTemplateArgs, GroupRuleAddressTemplatePtr and GroupRuleAddressTemplatePtrOutput values.
// You can construct a concrete instance of `GroupRuleAddressTemplatePtrInput` via:
//
//	        GroupRuleAddressTemplateArgs{...}
//
//	or:
//
//	        nil
type GroupRuleAddressTemplatePtrInput interface {
	pulumi.Input

	ToGroupRuleAddressTemplatePtrOutput() GroupRuleAddressTemplatePtrOutput
	ToGroupRuleAddressTemplatePtrOutputWithContext(context.Context) GroupRuleAddressTemplatePtrOutput
}

type groupRuleAddressTemplatePtrType GroupRuleAddressTemplateArgs

func GroupRuleAddressTemplatePtr(v *GroupRuleAddressTemplateArgs) GroupRuleAddressTemplatePtrInput {
	return (*groupRuleAddressTemplatePtrType)(v)
}

func (*groupRuleAddressTemplatePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**GroupRuleAddressTemplate)(nil)).Elem()
}

func (i *groupRuleAddressTemplatePtrType) ToGroupRuleAddressTemplatePtrOutput() GroupRuleAddressTemplatePtrOutput {
	return i.ToGroupRuleAddressTemplatePtrOutputWithContext(context.Background())
}

func (i *groupRuleAddressTemplatePtrType) ToGroupRuleAddressTemplatePtrOutputWithContext(ctx context.Context) GroupRuleAddressTemplatePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GroupRuleAddressTemplatePtrOutput)
}

type GroupRuleAddressTemplateOutput struct{ *pulumi.OutputState }

func (GroupRuleAddressTemplateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GroupRuleAddressTemplate)(nil)).Elem()
}

func (o GroupRuleAddressTemplateOutput) ToGroupRuleAddressTemplateOutput() GroupRuleAddressTemplateOutput {
	return o
}

func (o GroupRuleAddressTemplateOutput) ToGroupRuleAddressTemplateOutputWithContext(ctx context.Context) GroupRuleAddressTemplateOutput {
	return o
}

func (o GroupRuleAddressTemplateOutput) ToGroupRuleAddressTemplatePtrOutput() GroupRuleAddressTemplatePtrOutput {
	return o.ToGroupRuleAddressTemplatePtrOutputWithContext(context.Background())
}

func (o GroupRuleAddressTemplateOutput) ToGroupRuleAddressTemplatePtrOutputWithContext(ctx context.Context) GroupRuleAddressTemplatePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v GroupRuleAddressTemplate) *GroupRuleAddressTemplate {
		return &v
	}).(GroupRuleAddressTemplatePtrOutput)
}

func (o GroupRuleAddressTemplateOutput) GroupId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GroupRuleAddressTemplate) *string { return v.GroupId }).(pulumi.StringPtrOutput)
}

func (o GroupRuleAddressTemplateOutput) TemplateId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GroupRuleAddressTemplate) *string { return v.TemplateId }).(pulumi.StringPtrOutput)
}

type GroupRuleAddressTemplatePtrOutput struct{ *pulumi.OutputState }

func (GroupRuleAddressTemplatePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**GroupRuleAddressTemplate)(nil)).Elem()
}

func (o GroupRuleAddressTemplatePtrOutput) ToGroupRuleAddressTemplatePtrOutput() GroupRuleAddressTemplatePtrOutput {
	return o
}

func (o GroupRuleAddressTemplatePtrOutput) ToGroupRuleAddressTemplatePtrOutputWithContext(ctx context.Context) GroupRuleAddressTemplatePtrOutput {
	return o
}

func (o GroupRuleAddressTemplatePtrOutput) Elem() GroupRuleAddressTemplateOutput {
	return o.ApplyT(func(v *GroupRuleAddressTemplate) GroupRuleAddressTemplate {
		if v != nil {
			return *v
		}
		var ret GroupRuleAddressTemplate
		return ret
	}).(GroupRuleAddressTemplateOutput)
}

func (o GroupRuleAddressTemplatePtrOutput) GroupId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *GroupRuleAddressTemplate) *string {
		if v == nil {
			return nil
		}
		return v.GroupId
	}).(pulumi.StringPtrOutput)
}

func (o GroupRuleAddressTemplatePtrOutput) TemplateId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *GroupRuleAddressTemplate) *string {
		if v == nil {
			return nil
		}
		return v.TemplateId
	}).(pulumi.StringPtrOutput)
}

type GroupRuleProtocolTemplate struct {
	GroupId    *string `pulumi:"groupId"`
	TemplateId *string `pulumi:"templateId"`
}

// GroupRuleProtocolTemplateInput is an input type that accepts GroupRuleProtocolTemplateArgs and GroupRuleProtocolTemplateOutput values.
// You can construct a concrete instance of `GroupRuleProtocolTemplateInput` via:
//
//	GroupRuleProtocolTemplateArgs{...}
type GroupRuleProtocolTemplateInput interface {
	pulumi.Input

	ToGroupRuleProtocolTemplateOutput() GroupRuleProtocolTemplateOutput
	ToGroupRuleProtocolTemplateOutputWithContext(context.Context) GroupRuleProtocolTemplateOutput
}

type GroupRuleProtocolTemplateArgs struct {
	GroupId    pulumi.StringPtrInput `pulumi:"groupId"`
	TemplateId pulumi.StringPtrInput `pulumi:"templateId"`
}

func (GroupRuleProtocolTemplateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GroupRuleProtocolTemplate)(nil)).Elem()
}

func (i GroupRuleProtocolTemplateArgs) ToGroupRuleProtocolTemplateOutput() GroupRuleProtocolTemplateOutput {
	return i.ToGroupRuleProtocolTemplateOutputWithContext(context.Background())
}

func (i GroupRuleProtocolTemplateArgs) ToGroupRuleProtocolTemplateOutputWithContext(ctx context.Context) GroupRuleProtocolTemplateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GroupRuleProtocolTemplateOutput)
}

func (i GroupRuleProtocolTemplateArgs) ToGroupRuleProtocolTemplatePtrOutput() GroupRuleProtocolTemplatePtrOutput {
	return i.ToGroupRuleProtocolTemplatePtrOutputWithContext(context.Background())
}

func (i GroupRuleProtocolTemplateArgs) ToGroupRuleProtocolTemplatePtrOutputWithContext(ctx context.Context) GroupRuleProtocolTemplatePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GroupRuleProtocolTemplateOutput).ToGroupRuleProtocolTemplatePtrOutputWithContext(ctx)
}

// GroupRuleProtocolTemplatePtrInput is an input type that accepts GroupRuleProtocolTemplateArgs, GroupRuleProtocolTemplatePtr and GroupRuleProtocolTemplatePtrOutput values.
// You can construct a concrete instance of `GroupRuleProtocolTemplatePtrInput` via:
//
//	        GroupRuleProtocolTemplateArgs{...}
//
//	or:
//
//	        nil
type GroupRuleProtocolTemplatePtrInput interface {
	pulumi.Input

	ToGroupRuleProtocolTemplatePtrOutput() GroupRuleProtocolTemplatePtrOutput
	ToGroupRuleProtocolTemplatePtrOutputWithContext(context.Context) GroupRuleProtocolTemplatePtrOutput
}

type groupRuleProtocolTemplatePtrType GroupRuleProtocolTemplateArgs

func GroupRuleProtocolTemplatePtr(v *GroupRuleProtocolTemplateArgs) GroupRuleProtocolTemplatePtrInput {
	return (*groupRuleProtocolTemplatePtrType)(v)
}

func (*groupRuleProtocolTemplatePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**GroupRuleProtocolTemplate)(nil)).Elem()
}

func (i *groupRuleProtocolTemplatePtrType) ToGroupRuleProtocolTemplatePtrOutput() GroupRuleProtocolTemplatePtrOutput {
	return i.ToGroupRuleProtocolTemplatePtrOutputWithContext(context.Background())
}

func (i *groupRuleProtocolTemplatePtrType) ToGroupRuleProtocolTemplatePtrOutputWithContext(ctx context.Context) GroupRuleProtocolTemplatePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GroupRuleProtocolTemplatePtrOutput)
}

type GroupRuleProtocolTemplateOutput struct{ *pulumi.OutputState }

func (GroupRuleProtocolTemplateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GroupRuleProtocolTemplate)(nil)).Elem()
}

func (o GroupRuleProtocolTemplateOutput) ToGroupRuleProtocolTemplateOutput() GroupRuleProtocolTemplateOutput {
	return o
}

func (o GroupRuleProtocolTemplateOutput) ToGroupRuleProtocolTemplateOutputWithContext(ctx context.Context) GroupRuleProtocolTemplateOutput {
	return o
}

func (o GroupRuleProtocolTemplateOutput) ToGroupRuleProtocolTemplatePtrOutput() GroupRuleProtocolTemplatePtrOutput {
	return o.ToGroupRuleProtocolTemplatePtrOutputWithContext(context.Background())
}

func (o GroupRuleProtocolTemplateOutput) ToGroupRuleProtocolTemplatePtrOutputWithContext(ctx context.Context) GroupRuleProtocolTemplatePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v GroupRuleProtocolTemplate) *GroupRuleProtocolTemplate {
		return &v
	}).(GroupRuleProtocolTemplatePtrOutput)
}

func (o GroupRuleProtocolTemplateOutput) GroupId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GroupRuleProtocolTemplate) *string { return v.GroupId }).(pulumi.StringPtrOutput)
}

func (o GroupRuleProtocolTemplateOutput) TemplateId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GroupRuleProtocolTemplate) *string { return v.TemplateId }).(pulumi.StringPtrOutput)
}

type GroupRuleProtocolTemplatePtrOutput struct{ *pulumi.OutputState }

func (GroupRuleProtocolTemplatePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**GroupRuleProtocolTemplate)(nil)).Elem()
}

func (o GroupRuleProtocolTemplatePtrOutput) ToGroupRuleProtocolTemplatePtrOutput() GroupRuleProtocolTemplatePtrOutput {
	return o
}

func (o GroupRuleProtocolTemplatePtrOutput) ToGroupRuleProtocolTemplatePtrOutputWithContext(ctx context.Context) GroupRuleProtocolTemplatePtrOutput {
	return o
}

func (o GroupRuleProtocolTemplatePtrOutput) Elem() GroupRuleProtocolTemplateOutput {
	return o.ApplyT(func(v *GroupRuleProtocolTemplate) GroupRuleProtocolTemplate {
		if v != nil {
			return *v
		}
		var ret GroupRuleProtocolTemplate
		return ret
	}).(GroupRuleProtocolTemplateOutput)
}

func (o GroupRuleProtocolTemplatePtrOutput) GroupId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *GroupRuleProtocolTemplate) *string {
		if v == nil {
			return nil
		}
		return v.GroupId
	}).(pulumi.StringPtrOutput)
}

func (o GroupRuleProtocolTemplatePtrOutput) TemplateId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *GroupRuleProtocolTemplate) *string {
		if v == nil {
			return nil
		}
		return v.TemplateId
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GroupRuleAddressTemplateInput)(nil)).Elem(), GroupRuleAddressTemplateArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GroupRuleAddressTemplatePtrInput)(nil)).Elem(), GroupRuleAddressTemplateArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GroupRuleProtocolTemplateInput)(nil)).Elem(), GroupRuleProtocolTemplateArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GroupRuleProtocolTemplatePtrInput)(nil)).Elem(), GroupRuleProtocolTemplateArgs{})
	pulumi.RegisterOutputType(GroupRuleAddressTemplateOutput{})
	pulumi.RegisterOutputType(GroupRuleAddressTemplatePtrOutput{})
	pulumi.RegisterOutputType(GroupRuleProtocolTemplateOutput{})
	pulumi.RegisterOutputType(GroupRuleProtocolTemplatePtrOutput{})
}
