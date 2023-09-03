// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tcr

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type Namespace struct {
	pulumi.CustomResourceState

	// Vulnerability Whitelist.
	CveWhitelistItems NamespaceCveWhitelistItemArrayOutput `pulumi:"cveWhitelistItems"`
	// ID of the TCR instance.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Scanning level, `True` is automatic, `False` is manual. Default is `false`.
	IsAutoScan pulumi.BoolPtrOutput `pulumi:"isAutoScan"`
	// Blocking switch, `True` is open, `False` is closed. Default is `false`.
	IsPreventVul pulumi.BoolPtrOutput `pulumi:"isPreventVul"`
	// Indicate that the namespace is public or not. Default is `false`.
	IsPublic pulumi.BoolPtrOutput `pulumi:"isPublic"`
	// Name of the TCR namespace. Valid length is [2~30]. It can only contain lowercase letters, numbers and separators (`.`,
	// `_`, `-`), and cannot start, end or continue with separators.
	Name pulumi.StringOutput `pulumi:"name"`
	// Block vulnerability level, currently only supports `low`, `medium`, `high`.
	Severity pulumi.StringPtrOutput `pulumi:"severity"`
}

// NewNamespace registers a new resource with the given unique name, arguments, and options.
func NewNamespace(ctx *pulumi.Context,
	name string, args *NamespaceArgs, opts ...pulumi.ResourceOption) (*Namespace, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Namespace
	err := ctx.RegisterResource("tencentcloud:Tcr/namespace:Namespace", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNamespace gets an existing Namespace resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNamespace(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NamespaceState, opts ...pulumi.ResourceOption) (*Namespace, error) {
	var resource Namespace
	err := ctx.ReadResource("tencentcloud:Tcr/namespace:Namespace", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Namespace resources.
type namespaceState struct {
	// Vulnerability Whitelist.
	CveWhitelistItems []NamespaceCveWhitelistItem `pulumi:"cveWhitelistItems"`
	// ID of the TCR instance.
	InstanceId *string `pulumi:"instanceId"`
	// Scanning level, `True` is automatic, `False` is manual. Default is `false`.
	IsAutoScan *bool `pulumi:"isAutoScan"`
	// Blocking switch, `True` is open, `False` is closed. Default is `false`.
	IsPreventVul *bool `pulumi:"isPreventVul"`
	// Indicate that the namespace is public or not. Default is `false`.
	IsPublic *bool `pulumi:"isPublic"`
	// Name of the TCR namespace. Valid length is [2~30]. It can only contain lowercase letters, numbers and separators (`.`,
	// `_`, `-`), and cannot start, end or continue with separators.
	Name *string `pulumi:"name"`
	// Block vulnerability level, currently only supports `low`, `medium`, `high`.
	Severity *string `pulumi:"severity"`
}

type NamespaceState struct {
	// Vulnerability Whitelist.
	CveWhitelistItems NamespaceCveWhitelistItemArrayInput
	// ID of the TCR instance.
	InstanceId pulumi.StringPtrInput
	// Scanning level, `True` is automatic, `False` is manual. Default is `false`.
	IsAutoScan pulumi.BoolPtrInput
	// Blocking switch, `True` is open, `False` is closed. Default is `false`.
	IsPreventVul pulumi.BoolPtrInput
	// Indicate that the namespace is public or not. Default is `false`.
	IsPublic pulumi.BoolPtrInput
	// Name of the TCR namespace. Valid length is [2~30]. It can only contain lowercase letters, numbers and separators (`.`,
	// `_`, `-`), and cannot start, end or continue with separators.
	Name pulumi.StringPtrInput
	// Block vulnerability level, currently only supports `low`, `medium`, `high`.
	Severity pulumi.StringPtrInput
}

func (NamespaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*namespaceState)(nil)).Elem()
}

type namespaceArgs struct {
	// Vulnerability Whitelist.
	CveWhitelistItems []NamespaceCveWhitelistItem `pulumi:"cveWhitelistItems"`
	// ID of the TCR instance.
	InstanceId string `pulumi:"instanceId"`
	// Scanning level, `True` is automatic, `False` is manual. Default is `false`.
	IsAutoScan *bool `pulumi:"isAutoScan"`
	// Blocking switch, `True` is open, `False` is closed. Default is `false`.
	IsPreventVul *bool `pulumi:"isPreventVul"`
	// Indicate that the namespace is public or not. Default is `false`.
	IsPublic *bool `pulumi:"isPublic"`
	// Name of the TCR namespace. Valid length is [2~30]. It can only contain lowercase letters, numbers and separators (`.`,
	// `_`, `-`), and cannot start, end or continue with separators.
	Name *string `pulumi:"name"`
	// Block vulnerability level, currently only supports `low`, `medium`, `high`.
	Severity *string `pulumi:"severity"`
}

// The set of arguments for constructing a Namespace resource.
type NamespaceArgs struct {
	// Vulnerability Whitelist.
	CveWhitelistItems NamespaceCveWhitelistItemArrayInput
	// ID of the TCR instance.
	InstanceId pulumi.StringInput
	// Scanning level, `True` is automatic, `False` is manual. Default is `false`.
	IsAutoScan pulumi.BoolPtrInput
	// Blocking switch, `True` is open, `False` is closed. Default is `false`.
	IsPreventVul pulumi.BoolPtrInput
	// Indicate that the namespace is public or not. Default is `false`.
	IsPublic pulumi.BoolPtrInput
	// Name of the TCR namespace. Valid length is [2~30]. It can only contain lowercase letters, numbers and separators (`.`,
	// `_`, `-`), and cannot start, end or continue with separators.
	Name pulumi.StringPtrInput
	// Block vulnerability level, currently only supports `low`, `medium`, `high`.
	Severity pulumi.StringPtrInput
}

func (NamespaceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*namespaceArgs)(nil)).Elem()
}

type NamespaceInput interface {
	pulumi.Input

	ToNamespaceOutput() NamespaceOutput
	ToNamespaceOutputWithContext(ctx context.Context) NamespaceOutput
}

func (*Namespace) ElementType() reflect.Type {
	return reflect.TypeOf((**Namespace)(nil)).Elem()
}

func (i *Namespace) ToNamespaceOutput() NamespaceOutput {
	return i.ToNamespaceOutputWithContext(context.Background())
}

func (i *Namespace) ToNamespaceOutputWithContext(ctx context.Context) NamespaceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NamespaceOutput)
}

// NamespaceArrayInput is an input type that accepts NamespaceArray and NamespaceArrayOutput values.
// You can construct a concrete instance of `NamespaceArrayInput` via:
//
//	NamespaceArray{ NamespaceArgs{...} }
type NamespaceArrayInput interface {
	pulumi.Input

	ToNamespaceArrayOutput() NamespaceArrayOutput
	ToNamespaceArrayOutputWithContext(context.Context) NamespaceArrayOutput
}

type NamespaceArray []NamespaceInput

func (NamespaceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Namespace)(nil)).Elem()
}

func (i NamespaceArray) ToNamespaceArrayOutput() NamespaceArrayOutput {
	return i.ToNamespaceArrayOutputWithContext(context.Background())
}

func (i NamespaceArray) ToNamespaceArrayOutputWithContext(ctx context.Context) NamespaceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NamespaceArrayOutput)
}

// NamespaceMapInput is an input type that accepts NamespaceMap and NamespaceMapOutput values.
// You can construct a concrete instance of `NamespaceMapInput` via:
//
//	NamespaceMap{ "key": NamespaceArgs{...} }
type NamespaceMapInput interface {
	pulumi.Input

	ToNamespaceMapOutput() NamespaceMapOutput
	ToNamespaceMapOutputWithContext(context.Context) NamespaceMapOutput
}

type NamespaceMap map[string]NamespaceInput

func (NamespaceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Namespace)(nil)).Elem()
}

func (i NamespaceMap) ToNamespaceMapOutput() NamespaceMapOutput {
	return i.ToNamespaceMapOutputWithContext(context.Background())
}

func (i NamespaceMap) ToNamespaceMapOutputWithContext(ctx context.Context) NamespaceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NamespaceMapOutput)
}

type NamespaceOutput struct{ *pulumi.OutputState }

func (NamespaceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Namespace)(nil)).Elem()
}

func (o NamespaceOutput) ToNamespaceOutput() NamespaceOutput {
	return o
}

func (o NamespaceOutput) ToNamespaceOutputWithContext(ctx context.Context) NamespaceOutput {
	return o
}

// Vulnerability Whitelist.
func (o NamespaceOutput) CveWhitelistItems() NamespaceCveWhitelistItemArrayOutput {
	return o.ApplyT(func(v *Namespace) NamespaceCveWhitelistItemArrayOutput { return v.CveWhitelistItems }).(NamespaceCveWhitelistItemArrayOutput)
}

// ID of the TCR instance.
func (o NamespaceOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *Namespace) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Scanning level, `True` is automatic, `False` is manual. Default is `false`.
func (o NamespaceOutput) IsAutoScan() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Namespace) pulumi.BoolPtrOutput { return v.IsAutoScan }).(pulumi.BoolPtrOutput)
}

// Blocking switch, `True` is open, `False` is closed. Default is `false`.
func (o NamespaceOutput) IsPreventVul() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Namespace) pulumi.BoolPtrOutput { return v.IsPreventVul }).(pulumi.BoolPtrOutput)
}

// Indicate that the namespace is public or not. Default is `false`.
func (o NamespaceOutput) IsPublic() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Namespace) pulumi.BoolPtrOutput { return v.IsPublic }).(pulumi.BoolPtrOutput)
}

// Name of the TCR namespace. Valid length is [2~30]. It can only contain lowercase letters, numbers and separators (`.`,
// `_`, `-`), and cannot start, end or continue with separators.
func (o NamespaceOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Namespace) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Block vulnerability level, currently only supports `low`, `medium`, `high`.
func (o NamespaceOutput) Severity() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Namespace) pulumi.StringPtrOutput { return v.Severity }).(pulumi.StringPtrOutput)
}

type NamespaceArrayOutput struct{ *pulumi.OutputState }

func (NamespaceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Namespace)(nil)).Elem()
}

func (o NamespaceArrayOutput) ToNamespaceArrayOutput() NamespaceArrayOutput {
	return o
}

func (o NamespaceArrayOutput) ToNamespaceArrayOutputWithContext(ctx context.Context) NamespaceArrayOutput {
	return o
}

func (o NamespaceArrayOutput) Index(i pulumi.IntInput) NamespaceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Namespace {
		return vs[0].([]*Namespace)[vs[1].(int)]
	}).(NamespaceOutput)
}

type NamespaceMapOutput struct{ *pulumi.OutputState }

func (NamespaceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Namespace)(nil)).Elem()
}

func (o NamespaceMapOutput) ToNamespaceMapOutput() NamespaceMapOutput {
	return o
}

func (o NamespaceMapOutput) ToNamespaceMapOutputWithContext(ctx context.Context) NamespaceMapOutput {
	return o
}

func (o NamespaceMapOutput) MapIndex(k pulumi.StringInput) NamespaceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Namespace {
		return vs[0].(map[string]*Namespace)[vs[1].(string)]
	}).(NamespaceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NamespaceInput)(nil)).Elem(), &Namespace{})
	pulumi.RegisterInputType(reflect.TypeOf((*NamespaceArrayInput)(nil)).Elem(), NamespaceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NamespaceMapInput)(nil)).Elem(), NamespaceMap{})
	pulumi.RegisterOutputType(NamespaceOutput{})
	pulumi.RegisterOutputType(NamespaceArrayOutput{})
	pulumi.RegisterOutputType(NamespaceMapOutput{})
}