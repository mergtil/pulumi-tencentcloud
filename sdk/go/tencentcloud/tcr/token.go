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

type Token struct {
	pulumi.CustomResourceState

	// Create time.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// Description of the token. Valid length is [0~255].
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Indicate to enable this token or not.
	Enable pulumi.BoolPtrOutput `pulumi:"enable"`
	// ID of the TCR instance.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// The content of the token.
	Token pulumi.StringOutput `pulumi:"token"`
	// Sub ID of the TCR token. The full ID of token format like `instance_id#token_id`.
	TokenId pulumi.StringOutput `pulumi:"tokenId"`
	// User name of the token.
	UserName pulumi.StringOutput `pulumi:"userName"`
}

// NewToken registers a new resource with the given unique name, arguments, and options.
func NewToken(ctx *pulumi.Context,
	name string, args *TokenArgs, opts ...pulumi.ResourceOption) (*Token, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Token
	err := ctx.RegisterResource("tencentcloud:Tcr/token:Token", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetToken gets an existing Token resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetToken(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TokenState, opts ...pulumi.ResourceOption) (*Token, error) {
	var resource Token
	err := ctx.ReadResource("tencentcloud:Tcr/token:Token", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Token resources.
type tokenState struct {
	// Create time.
	CreateTime *string `pulumi:"createTime"`
	// Description of the token. Valid length is [0~255].
	Description *string `pulumi:"description"`
	// Indicate to enable this token or not.
	Enable *bool `pulumi:"enable"`
	// ID of the TCR instance.
	InstanceId *string `pulumi:"instanceId"`
	// The content of the token.
	Token *string `pulumi:"token"`
	// Sub ID of the TCR token. The full ID of token format like `instance_id#token_id`.
	TokenId *string `pulumi:"tokenId"`
	// User name of the token.
	UserName *string `pulumi:"userName"`
}

type TokenState struct {
	// Create time.
	CreateTime pulumi.StringPtrInput
	// Description of the token. Valid length is [0~255].
	Description pulumi.StringPtrInput
	// Indicate to enable this token or not.
	Enable pulumi.BoolPtrInput
	// ID of the TCR instance.
	InstanceId pulumi.StringPtrInput
	// The content of the token.
	Token pulumi.StringPtrInput
	// Sub ID of the TCR token. The full ID of token format like `instance_id#token_id`.
	TokenId pulumi.StringPtrInput
	// User name of the token.
	UserName pulumi.StringPtrInput
}

func (TokenState) ElementType() reflect.Type {
	return reflect.TypeOf((*tokenState)(nil)).Elem()
}

type tokenArgs struct {
	// Description of the token. Valid length is [0~255].
	Description *string `pulumi:"description"`
	// Indicate to enable this token or not.
	Enable *bool `pulumi:"enable"`
	// ID of the TCR instance.
	InstanceId string `pulumi:"instanceId"`
}

// The set of arguments for constructing a Token resource.
type TokenArgs struct {
	// Description of the token. Valid length is [0~255].
	Description pulumi.StringPtrInput
	// Indicate to enable this token or not.
	Enable pulumi.BoolPtrInput
	// ID of the TCR instance.
	InstanceId pulumi.StringInput
}

func (TokenArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*tokenArgs)(nil)).Elem()
}

type TokenInput interface {
	pulumi.Input

	ToTokenOutput() TokenOutput
	ToTokenOutputWithContext(ctx context.Context) TokenOutput
}

func (*Token) ElementType() reflect.Type {
	return reflect.TypeOf((**Token)(nil)).Elem()
}

func (i *Token) ToTokenOutput() TokenOutput {
	return i.ToTokenOutputWithContext(context.Background())
}

func (i *Token) ToTokenOutputWithContext(ctx context.Context) TokenOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TokenOutput)
}

// TokenArrayInput is an input type that accepts TokenArray and TokenArrayOutput values.
// You can construct a concrete instance of `TokenArrayInput` via:
//
//	TokenArray{ TokenArgs{...} }
type TokenArrayInput interface {
	pulumi.Input

	ToTokenArrayOutput() TokenArrayOutput
	ToTokenArrayOutputWithContext(context.Context) TokenArrayOutput
}

type TokenArray []TokenInput

func (TokenArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Token)(nil)).Elem()
}

func (i TokenArray) ToTokenArrayOutput() TokenArrayOutput {
	return i.ToTokenArrayOutputWithContext(context.Background())
}

func (i TokenArray) ToTokenArrayOutputWithContext(ctx context.Context) TokenArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TokenArrayOutput)
}

// TokenMapInput is an input type that accepts TokenMap and TokenMapOutput values.
// You can construct a concrete instance of `TokenMapInput` via:
//
//	TokenMap{ "key": TokenArgs{...} }
type TokenMapInput interface {
	pulumi.Input

	ToTokenMapOutput() TokenMapOutput
	ToTokenMapOutputWithContext(context.Context) TokenMapOutput
}

type TokenMap map[string]TokenInput

func (TokenMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Token)(nil)).Elem()
}

func (i TokenMap) ToTokenMapOutput() TokenMapOutput {
	return i.ToTokenMapOutputWithContext(context.Background())
}

func (i TokenMap) ToTokenMapOutputWithContext(ctx context.Context) TokenMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TokenMapOutput)
}

type TokenOutput struct{ *pulumi.OutputState }

func (TokenOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Token)(nil)).Elem()
}

func (o TokenOutput) ToTokenOutput() TokenOutput {
	return o
}

func (o TokenOutput) ToTokenOutputWithContext(ctx context.Context) TokenOutput {
	return o
}

// Create time.
func (o TokenOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *Token) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// Description of the token. Valid length is [0~255].
func (o TokenOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Token) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Indicate to enable this token or not.
func (o TokenOutput) Enable() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Token) pulumi.BoolPtrOutput { return v.Enable }).(pulumi.BoolPtrOutput)
}

// ID of the TCR instance.
func (o TokenOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *Token) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// The content of the token.
func (o TokenOutput) Token() pulumi.StringOutput {
	return o.ApplyT(func(v *Token) pulumi.StringOutput { return v.Token }).(pulumi.StringOutput)
}

// Sub ID of the TCR token. The full ID of token format like `instance_id#token_id`.
func (o TokenOutput) TokenId() pulumi.StringOutput {
	return o.ApplyT(func(v *Token) pulumi.StringOutput { return v.TokenId }).(pulumi.StringOutput)
}

// User name of the token.
func (o TokenOutput) UserName() pulumi.StringOutput {
	return o.ApplyT(func(v *Token) pulumi.StringOutput { return v.UserName }).(pulumi.StringOutput)
}

type TokenArrayOutput struct{ *pulumi.OutputState }

func (TokenArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Token)(nil)).Elem()
}

func (o TokenArrayOutput) ToTokenArrayOutput() TokenArrayOutput {
	return o
}

func (o TokenArrayOutput) ToTokenArrayOutputWithContext(ctx context.Context) TokenArrayOutput {
	return o
}

func (o TokenArrayOutput) Index(i pulumi.IntInput) TokenOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Token {
		return vs[0].([]*Token)[vs[1].(int)]
	}).(TokenOutput)
}

type TokenMapOutput struct{ *pulumi.OutputState }

func (TokenMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Token)(nil)).Elem()
}

func (o TokenMapOutput) ToTokenMapOutput() TokenMapOutput {
	return o
}

func (o TokenMapOutput) ToTokenMapOutputWithContext(ctx context.Context) TokenMapOutput {
	return o
}

func (o TokenMapOutput) MapIndex(k pulumi.StringInput) TokenOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Token {
		return vs[0].(map[string]*Token)[vs[1].(string)]
	}).(TokenOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TokenInput)(nil)).Elem(), &Token{})
	pulumi.RegisterInputType(reflect.TypeOf((*TokenArrayInput)(nil)).Elem(), TokenArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TokenMapInput)(nil)).Elem(), TokenMap{})
	pulumi.RegisterOutputType(TokenOutput{})
	pulumi.RegisterOutputType(TokenArrayOutput{})
	pulumi.RegisterOutputType(TokenMapOutput{})
}