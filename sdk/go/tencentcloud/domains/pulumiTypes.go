// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package domains

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

var _ = internal.GetEnvOrDefault

type GetDomainsList struct {
	AutoRenew      int    `pulumi:"autoRenew"`
	BuyStatus      string `pulumi:"buyStatus"`
	CodeTld        string `pulumi:"codeTld"`
	CreationDate   string `pulumi:"creationDate"`
	DomainId       string `pulumi:"domainId"`
	DomainName     string `pulumi:"domainName"`
	ExpirationDate string `pulumi:"expirationDate"`
	IsPremium      bool   `pulumi:"isPremium"`
	Tld            string `pulumi:"tld"`
}

// GetDomainsListInput is an input type that accepts GetDomainsListArgs and GetDomainsListOutput values.
// You can construct a concrete instance of `GetDomainsListInput` via:
//
//	GetDomainsListArgs{...}
type GetDomainsListInput interface {
	pulumi.Input

	ToGetDomainsListOutput() GetDomainsListOutput
	ToGetDomainsListOutputWithContext(context.Context) GetDomainsListOutput
}

type GetDomainsListArgs struct {
	AutoRenew      pulumi.IntInput    `pulumi:"autoRenew"`
	BuyStatus      pulumi.StringInput `pulumi:"buyStatus"`
	CodeTld        pulumi.StringInput `pulumi:"codeTld"`
	CreationDate   pulumi.StringInput `pulumi:"creationDate"`
	DomainId       pulumi.StringInput `pulumi:"domainId"`
	DomainName     pulumi.StringInput `pulumi:"domainName"`
	ExpirationDate pulumi.StringInput `pulumi:"expirationDate"`
	IsPremium      pulumi.BoolInput   `pulumi:"isPremium"`
	Tld            pulumi.StringInput `pulumi:"tld"`
}

func (GetDomainsListArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDomainsList)(nil)).Elem()
}

func (i GetDomainsListArgs) ToGetDomainsListOutput() GetDomainsListOutput {
	return i.ToGetDomainsListOutputWithContext(context.Background())
}

func (i GetDomainsListArgs) ToGetDomainsListOutputWithContext(ctx context.Context) GetDomainsListOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetDomainsListOutput)
}

// GetDomainsListArrayInput is an input type that accepts GetDomainsListArray and GetDomainsListArrayOutput values.
// You can construct a concrete instance of `GetDomainsListArrayInput` via:
//
//	GetDomainsListArray{ GetDomainsListArgs{...} }
type GetDomainsListArrayInput interface {
	pulumi.Input

	ToGetDomainsListArrayOutput() GetDomainsListArrayOutput
	ToGetDomainsListArrayOutputWithContext(context.Context) GetDomainsListArrayOutput
}

type GetDomainsListArray []GetDomainsListInput

func (GetDomainsListArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetDomainsList)(nil)).Elem()
}

func (i GetDomainsListArray) ToGetDomainsListArrayOutput() GetDomainsListArrayOutput {
	return i.ToGetDomainsListArrayOutputWithContext(context.Background())
}

func (i GetDomainsListArray) ToGetDomainsListArrayOutputWithContext(ctx context.Context) GetDomainsListArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetDomainsListArrayOutput)
}

type GetDomainsListOutput struct{ *pulumi.OutputState }

func (GetDomainsListOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDomainsList)(nil)).Elem()
}

func (o GetDomainsListOutput) ToGetDomainsListOutput() GetDomainsListOutput {
	return o
}

func (o GetDomainsListOutput) ToGetDomainsListOutputWithContext(ctx context.Context) GetDomainsListOutput {
	return o
}

func (o GetDomainsListOutput) AutoRenew() pulumi.IntOutput {
	return o.ApplyT(func(v GetDomainsList) int { return v.AutoRenew }).(pulumi.IntOutput)
}

func (o GetDomainsListOutput) BuyStatus() pulumi.StringOutput {
	return o.ApplyT(func(v GetDomainsList) string { return v.BuyStatus }).(pulumi.StringOutput)
}

func (o GetDomainsListOutput) CodeTld() pulumi.StringOutput {
	return o.ApplyT(func(v GetDomainsList) string { return v.CodeTld }).(pulumi.StringOutput)
}

func (o GetDomainsListOutput) CreationDate() pulumi.StringOutput {
	return o.ApplyT(func(v GetDomainsList) string { return v.CreationDate }).(pulumi.StringOutput)
}

func (o GetDomainsListOutput) DomainId() pulumi.StringOutput {
	return o.ApplyT(func(v GetDomainsList) string { return v.DomainId }).(pulumi.StringOutput)
}

func (o GetDomainsListOutput) DomainName() pulumi.StringOutput {
	return o.ApplyT(func(v GetDomainsList) string { return v.DomainName }).(pulumi.StringOutput)
}

func (o GetDomainsListOutput) ExpirationDate() pulumi.StringOutput {
	return o.ApplyT(func(v GetDomainsList) string { return v.ExpirationDate }).(pulumi.StringOutput)
}

func (o GetDomainsListOutput) IsPremium() pulumi.BoolOutput {
	return o.ApplyT(func(v GetDomainsList) bool { return v.IsPremium }).(pulumi.BoolOutput)
}

func (o GetDomainsListOutput) Tld() pulumi.StringOutput {
	return o.ApplyT(func(v GetDomainsList) string { return v.Tld }).(pulumi.StringOutput)
}

type GetDomainsListArrayOutput struct{ *pulumi.OutputState }

func (GetDomainsListArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetDomainsList)(nil)).Elem()
}

func (o GetDomainsListArrayOutput) ToGetDomainsListArrayOutput() GetDomainsListArrayOutput {
	return o
}

func (o GetDomainsListArrayOutput) ToGetDomainsListArrayOutputWithContext(ctx context.Context) GetDomainsListArrayOutput {
	return o
}

func (o GetDomainsListArrayOutput) Index(i pulumi.IntInput) GetDomainsListOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetDomainsList {
		return vs[0].([]GetDomainsList)[vs[1].(int)]
	}).(GetDomainsListOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GetDomainsListInput)(nil)).Elem(), GetDomainsListArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*GetDomainsListArrayInput)(nil)).Elem(), GetDomainsListArray{})
	pulumi.RegisterOutputType(GetDomainsListOutput{})
	pulumi.RegisterOutputType(GetDomainsListArrayOutput{})
}