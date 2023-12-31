// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ses

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

var _ = internal.GetEnvOrDefault

type TemplateTemplateContent struct {
	Html *string `pulumi:"html"`
	Text *string `pulumi:"text"`
}

// TemplateTemplateContentInput is an input type that accepts TemplateTemplateContentArgs and TemplateTemplateContentOutput values.
// You can construct a concrete instance of `TemplateTemplateContentInput` via:
//
//	TemplateTemplateContentArgs{...}
type TemplateTemplateContentInput interface {
	pulumi.Input

	ToTemplateTemplateContentOutput() TemplateTemplateContentOutput
	ToTemplateTemplateContentOutputWithContext(context.Context) TemplateTemplateContentOutput
}

type TemplateTemplateContentArgs struct {
	Html pulumi.StringPtrInput `pulumi:"html"`
	Text pulumi.StringPtrInput `pulumi:"text"`
}

func (TemplateTemplateContentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*TemplateTemplateContent)(nil)).Elem()
}

func (i TemplateTemplateContentArgs) ToTemplateTemplateContentOutput() TemplateTemplateContentOutput {
	return i.ToTemplateTemplateContentOutputWithContext(context.Background())
}

func (i TemplateTemplateContentArgs) ToTemplateTemplateContentOutputWithContext(ctx context.Context) TemplateTemplateContentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateTemplateContentOutput)
}

func (i TemplateTemplateContentArgs) ToTemplateTemplateContentPtrOutput() TemplateTemplateContentPtrOutput {
	return i.ToTemplateTemplateContentPtrOutputWithContext(context.Background())
}

func (i TemplateTemplateContentArgs) ToTemplateTemplateContentPtrOutputWithContext(ctx context.Context) TemplateTemplateContentPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateTemplateContentOutput).ToTemplateTemplateContentPtrOutputWithContext(ctx)
}

// TemplateTemplateContentPtrInput is an input type that accepts TemplateTemplateContentArgs, TemplateTemplateContentPtr and TemplateTemplateContentPtrOutput values.
// You can construct a concrete instance of `TemplateTemplateContentPtrInput` via:
//
//	        TemplateTemplateContentArgs{...}
//
//	or:
//
//	        nil
type TemplateTemplateContentPtrInput interface {
	pulumi.Input

	ToTemplateTemplateContentPtrOutput() TemplateTemplateContentPtrOutput
	ToTemplateTemplateContentPtrOutputWithContext(context.Context) TemplateTemplateContentPtrOutput
}

type templateTemplateContentPtrType TemplateTemplateContentArgs

func TemplateTemplateContentPtr(v *TemplateTemplateContentArgs) TemplateTemplateContentPtrInput {
	return (*templateTemplateContentPtrType)(v)
}

func (*templateTemplateContentPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**TemplateTemplateContent)(nil)).Elem()
}

func (i *templateTemplateContentPtrType) ToTemplateTemplateContentPtrOutput() TemplateTemplateContentPtrOutput {
	return i.ToTemplateTemplateContentPtrOutputWithContext(context.Background())
}

func (i *templateTemplateContentPtrType) ToTemplateTemplateContentPtrOutputWithContext(ctx context.Context) TemplateTemplateContentPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateTemplateContentPtrOutput)
}

type TemplateTemplateContentOutput struct{ *pulumi.OutputState }

func (TemplateTemplateContentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TemplateTemplateContent)(nil)).Elem()
}

func (o TemplateTemplateContentOutput) ToTemplateTemplateContentOutput() TemplateTemplateContentOutput {
	return o
}

func (o TemplateTemplateContentOutput) ToTemplateTemplateContentOutputWithContext(ctx context.Context) TemplateTemplateContentOutput {
	return o
}

func (o TemplateTemplateContentOutput) ToTemplateTemplateContentPtrOutput() TemplateTemplateContentPtrOutput {
	return o.ToTemplateTemplateContentPtrOutputWithContext(context.Background())
}

func (o TemplateTemplateContentOutput) ToTemplateTemplateContentPtrOutputWithContext(ctx context.Context) TemplateTemplateContentPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v TemplateTemplateContent) *TemplateTemplateContent {
		return &v
	}).(TemplateTemplateContentPtrOutput)
}

func (o TemplateTemplateContentOutput) Html() pulumi.StringPtrOutput {
	return o.ApplyT(func(v TemplateTemplateContent) *string { return v.Html }).(pulumi.StringPtrOutput)
}

func (o TemplateTemplateContentOutput) Text() pulumi.StringPtrOutput {
	return o.ApplyT(func(v TemplateTemplateContent) *string { return v.Text }).(pulumi.StringPtrOutput)
}

type TemplateTemplateContentPtrOutput struct{ *pulumi.OutputState }

func (TemplateTemplateContentPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TemplateTemplateContent)(nil)).Elem()
}

func (o TemplateTemplateContentPtrOutput) ToTemplateTemplateContentPtrOutput() TemplateTemplateContentPtrOutput {
	return o
}

func (o TemplateTemplateContentPtrOutput) ToTemplateTemplateContentPtrOutputWithContext(ctx context.Context) TemplateTemplateContentPtrOutput {
	return o
}

func (o TemplateTemplateContentPtrOutput) Elem() TemplateTemplateContentOutput {
	return o.ApplyT(func(v *TemplateTemplateContent) TemplateTemplateContent {
		if v != nil {
			return *v
		}
		var ret TemplateTemplateContent
		return ret
	}).(TemplateTemplateContentOutput)
}

func (o TemplateTemplateContentPtrOutput) Html() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TemplateTemplateContent) *string {
		if v == nil {
			return nil
		}
		return v.Html
	}).(pulumi.StringPtrOutput)
}

func (o TemplateTemplateContentPtrOutput) Text() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TemplateTemplateContent) *string {
		if v == nil {
			return nil
		}
		return v.Text
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TemplateTemplateContentInput)(nil)).Elem(), TemplateTemplateContentArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*TemplateTemplateContentPtrInput)(nil)).Elem(), TemplateTemplateContentArgs{})
	pulumi.RegisterOutputType(TemplateTemplateContentOutput{})
	pulumi.RegisterOutputType(TemplateTemplateContentPtrOutput{})
}
