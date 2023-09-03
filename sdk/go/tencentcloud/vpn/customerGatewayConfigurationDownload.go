// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vpn

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type CustomerGatewayConfigurationDownload struct {
	pulumi.CustomResourceState

	// xml configuration.
	CustomerGatewayConfiguration pulumi.StringOutput `pulumi:"customerGatewayConfiguration"`
	// Customer Gateway Vendor Info.
	CustomerGatewayVendor CustomerGatewayConfigurationDownloadCustomerGatewayVendorOutput `pulumi:"customerGatewayVendor"`
	// VPN connection access device physical interface name.
	InterfaceName pulumi.StringOutput `pulumi:"interfaceName"`
	// VPN Connection Instance id.
	VpnConnectionId pulumi.StringOutput `pulumi:"vpnConnectionId"`
	// VPN Gateway Instance ID.
	VpnGatewayId pulumi.StringOutput `pulumi:"vpnGatewayId"`
}

// NewCustomerGatewayConfigurationDownload registers a new resource with the given unique name, arguments, and options.
func NewCustomerGatewayConfigurationDownload(ctx *pulumi.Context,
	name string, args *CustomerGatewayConfigurationDownloadArgs, opts ...pulumi.ResourceOption) (*CustomerGatewayConfigurationDownload, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CustomerGatewayVendor == nil {
		return nil, errors.New("invalid value for required argument 'CustomerGatewayVendor'")
	}
	if args.InterfaceName == nil {
		return nil, errors.New("invalid value for required argument 'InterfaceName'")
	}
	if args.VpnConnectionId == nil {
		return nil, errors.New("invalid value for required argument 'VpnConnectionId'")
	}
	if args.VpnGatewayId == nil {
		return nil, errors.New("invalid value for required argument 'VpnGatewayId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CustomerGatewayConfigurationDownload
	err := ctx.RegisterResource("tencentcloud:Vpn/customerGatewayConfigurationDownload:CustomerGatewayConfigurationDownload", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCustomerGatewayConfigurationDownload gets an existing CustomerGatewayConfigurationDownload resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCustomerGatewayConfigurationDownload(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CustomerGatewayConfigurationDownloadState, opts ...pulumi.ResourceOption) (*CustomerGatewayConfigurationDownload, error) {
	var resource CustomerGatewayConfigurationDownload
	err := ctx.ReadResource("tencentcloud:Vpn/customerGatewayConfigurationDownload:CustomerGatewayConfigurationDownload", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CustomerGatewayConfigurationDownload resources.
type customerGatewayConfigurationDownloadState struct {
	// xml configuration.
	CustomerGatewayConfiguration *string `pulumi:"customerGatewayConfiguration"`
	// Customer Gateway Vendor Info.
	CustomerGatewayVendor *CustomerGatewayConfigurationDownloadCustomerGatewayVendor `pulumi:"customerGatewayVendor"`
	// VPN connection access device physical interface name.
	InterfaceName *string `pulumi:"interfaceName"`
	// VPN Connection Instance id.
	VpnConnectionId *string `pulumi:"vpnConnectionId"`
	// VPN Gateway Instance ID.
	VpnGatewayId *string `pulumi:"vpnGatewayId"`
}

type CustomerGatewayConfigurationDownloadState struct {
	// xml configuration.
	CustomerGatewayConfiguration pulumi.StringPtrInput
	// Customer Gateway Vendor Info.
	CustomerGatewayVendor CustomerGatewayConfigurationDownloadCustomerGatewayVendorPtrInput
	// VPN connection access device physical interface name.
	InterfaceName pulumi.StringPtrInput
	// VPN Connection Instance id.
	VpnConnectionId pulumi.StringPtrInput
	// VPN Gateway Instance ID.
	VpnGatewayId pulumi.StringPtrInput
}

func (CustomerGatewayConfigurationDownloadState) ElementType() reflect.Type {
	return reflect.TypeOf((*customerGatewayConfigurationDownloadState)(nil)).Elem()
}

type customerGatewayConfigurationDownloadArgs struct {
	// Customer Gateway Vendor Info.
	CustomerGatewayVendor CustomerGatewayConfigurationDownloadCustomerGatewayVendor `pulumi:"customerGatewayVendor"`
	// VPN connection access device physical interface name.
	InterfaceName string `pulumi:"interfaceName"`
	// VPN Connection Instance id.
	VpnConnectionId string `pulumi:"vpnConnectionId"`
	// VPN Gateway Instance ID.
	VpnGatewayId string `pulumi:"vpnGatewayId"`
}

// The set of arguments for constructing a CustomerGatewayConfigurationDownload resource.
type CustomerGatewayConfigurationDownloadArgs struct {
	// Customer Gateway Vendor Info.
	CustomerGatewayVendor CustomerGatewayConfigurationDownloadCustomerGatewayVendorInput
	// VPN connection access device physical interface name.
	InterfaceName pulumi.StringInput
	// VPN Connection Instance id.
	VpnConnectionId pulumi.StringInput
	// VPN Gateway Instance ID.
	VpnGatewayId pulumi.StringInput
}

func (CustomerGatewayConfigurationDownloadArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*customerGatewayConfigurationDownloadArgs)(nil)).Elem()
}

type CustomerGatewayConfigurationDownloadInput interface {
	pulumi.Input

	ToCustomerGatewayConfigurationDownloadOutput() CustomerGatewayConfigurationDownloadOutput
	ToCustomerGatewayConfigurationDownloadOutputWithContext(ctx context.Context) CustomerGatewayConfigurationDownloadOutput
}

func (*CustomerGatewayConfigurationDownload) ElementType() reflect.Type {
	return reflect.TypeOf((**CustomerGatewayConfigurationDownload)(nil)).Elem()
}

func (i *CustomerGatewayConfigurationDownload) ToCustomerGatewayConfigurationDownloadOutput() CustomerGatewayConfigurationDownloadOutput {
	return i.ToCustomerGatewayConfigurationDownloadOutputWithContext(context.Background())
}

func (i *CustomerGatewayConfigurationDownload) ToCustomerGatewayConfigurationDownloadOutputWithContext(ctx context.Context) CustomerGatewayConfigurationDownloadOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CustomerGatewayConfigurationDownloadOutput)
}

// CustomerGatewayConfigurationDownloadArrayInput is an input type that accepts CustomerGatewayConfigurationDownloadArray and CustomerGatewayConfigurationDownloadArrayOutput values.
// You can construct a concrete instance of `CustomerGatewayConfigurationDownloadArrayInput` via:
//
//	CustomerGatewayConfigurationDownloadArray{ CustomerGatewayConfigurationDownloadArgs{...} }
type CustomerGatewayConfigurationDownloadArrayInput interface {
	pulumi.Input

	ToCustomerGatewayConfigurationDownloadArrayOutput() CustomerGatewayConfigurationDownloadArrayOutput
	ToCustomerGatewayConfigurationDownloadArrayOutputWithContext(context.Context) CustomerGatewayConfigurationDownloadArrayOutput
}

type CustomerGatewayConfigurationDownloadArray []CustomerGatewayConfigurationDownloadInput

func (CustomerGatewayConfigurationDownloadArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CustomerGatewayConfigurationDownload)(nil)).Elem()
}

func (i CustomerGatewayConfigurationDownloadArray) ToCustomerGatewayConfigurationDownloadArrayOutput() CustomerGatewayConfigurationDownloadArrayOutput {
	return i.ToCustomerGatewayConfigurationDownloadArrayOutputWithContext(context.Background())
}

func (i CustomerGatewayConfigurationDownloadArray) ToCustomerGatewayConfigurationDownloadArrayOutputWithContext(ctx context.Context) CustomerGatewayConfigurationDownloadArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CustomerGatewayConfigurationDownloadArrayOutput)
}

// CustomerGatewayConfigurationDownloadMapInput is an input type that accepts CustomerGatewayConfigurationDownloadMap and CustomerGatewayConfigurationDownloadMapOutput values.
// You can construct a concrete instance of `CustomerGatewayConfigurationDownloadMapInput` via:
//
//	CustomerGatewayConfigurationDownloadMap{ "key": CustomerGatewayConfigurationDownloadArgs{...} }
type CustomerGatewayConfigurationDownloadMapInput interface {
	pulumi.Input

	ToCustomerGatewayConfigurationDownloadMapOutput() CustomerGatewayConfigurationDownloadMapOutput
	ToCustomerGatewayConfigurationDownloadMapOutputWithContext(context.Context) CustomerGatewayConfigurationDownloadMapOutput
}

type CustomerGatewayConfigurationDownloadMap map[string]CustomerGatewayConfigurationDownloadInput

func (CustomerGatewayConfigurationDownloadMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CustomerGatewayConfigurationDownload)(nil)).Elem()
}

func (i CustomerGatewayConfigurationDownloadMap) ToCustomerGatewayConfigurationDownloadMapOutput() CustomerGatewayConfigurationDownloadMapOutput {
	return i.ToCustomerGatewayConfigurationDownloadMapOutputWithContext(context.Background())
}

func (i CustomerGatewayConfigurationDownloadMap) ToCustomerGatewayConfigurationDownloadMapOutputWithContext(ctx context.Context) CustomerGatewayConfigurationDownloadMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CustomerGatewayConfigurationDownloadMapOutput)
}

type CustomerGatewayConfigurationDownloadOutput struct{ *pulumi.OutputState }

func (CustomerGatewayConfigurationDownloadOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CustomerGatewayConfigurationDownload)(nil)).Elem()
}

func (o CustomerGatewayConfigurationDownloadOutput) ToCustomerGatewayConfigurationDownloadOutput() CustomerGatewayConfigurationDownloadOutput {
	return o
}

func (o CustomerGatewayConfigurationDownloadOutput) ToCustomerGatewayConfigurationDownloadOutputWithContext(ctx context.Context) CustomerGatewayConfigurationDownloadOutput {
	return o
}

// xml configuration.
func (o CustomerGatewayConfigurationDownloadOutput) CustomerGatewayConfiguration() pulumi.StringOutput {
	return o.ApplyT(func(v *CustomerGatewayConfigurationDownload) pulumi.StringOutput {
		return v.CustomerGatewayConfiguration
	}).(pulumi.StringOutput)
}

// Customer Gateway Vendor Info.
func (o CustomerGatewayConfigurationDownloadOutput) CustomerGatewayVendor() CustomerGatewayConfigurationDownloadCustomerGatewayVendorOutput {
	return o.ApplyT(func(v *CustomerGatewayConfigurationDownload) CustomerGatewayConfigurationDownloadCustomerGatewayVendorOutput {
		return v.CustomerGatewayVendor
	}).(CustomerGatewayConfigurationDownloadCustomerGatewayVendorOutput)
}

// VPN connection access device physical interface name.
func (o CustomerGatewayConfigurationDownloadOutput) InterfaceName() pulumi.StringOutput {
	return o.ApplyT(func(v *CustomerGatewayConfigurationDownload) pulumi.StringOutput { return v.InterfaceName }).(pulumi.StringOutput)
}

// VPN Connection Instance id.
func (o CustomerGatewayConfigurationDownloadOutput) VpnConnectionId() pulumi.StringOutput {
	return o.ApplyT(func(v *CustomerGatewayConfigurationDownload) pulumi.StringOutput { return v.VpnConnectionId }).(pulumi.StringOutput)
}

// VPN Gateway Instance ID.
func (o CustomerGatewayConfigurationDownloadOutput) VpnGatewayId() pulumi.StringOutput {
	return o.ApplyT(func(v *CustomerGatewayConfigurationDownload) pulumi.StringOutput { return v.VpnGatewayId }).(pulumi.StringOutput)
}

type CustomerGatewayConfigurationDownloadArrayOutput struct{ *pulumi.OutputState }

func (CustomerGatewayConfigurationDownloadArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CustomerGatewayConfigurationDownload)(nil)).Elem()
}

func (o CustomerGatewayConfigurationDownloadArrayOutput) ToCustomerGatewayConfigurationDownloadArrayOutput() CustomerGatewayConfigurationDownloadArrayOutput {
	return o
}

func (o CustomerGatewayConfigurationDownloadArrayOutput) ToCustomerGatewayConfigurationDownloadArrayOutputWithContext(ctx context.Context) CustomerGatewayConfigurationDownloadArrayOutput {
	return o
}

func (o CustomerGatewayConfigurationDownloadArrayOutput) Index(i pulumi.IntInput) CustomerGatewayConfigurationDownloadOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CustomerGatewayConfigurationDownload {
		return vs[0].([]*CustomerGatewayConfigurationDownload)[vs[1].(int)]
	}).(CustomerGatewayConfigurationDownloadOutput)
}

type CustomerGatewayConfigurationDownloadMapOutput struct{ *pulumi.OutputState }

func (CustomerGatewayConfigurationDownloadMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CustomerGatewayConfigurationDownload)(nil)).Elem()
}

func (o CustomerGatewayConfigurationDownloadMapOutput) ToCustomerGatewayConfigurationDownloadMapOutput() CustomerGatewayConfigurationDownloadMapOutput {
	return o
}

func (o CustomerGatewayConfigurationDownloadMapOutput) ToCustomerGatewayConfigurationDownloadMapOutputWithContext(ctx context.Context) CustomerGatewayConfigurationDownloadMapOutput {
	return o
}

func (o CustomerGatewayConfigurationDownloadMapOutput) MapIndex(k pulumi.StringInput) CustomerGatewayConfigurationDownloadOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CustomerGatewayConfigurationDownload {
		return vs[0].(map[string]*CustomerGatewayConfigurationDownload)[vs[1].(string)]
	}).(CustomerGatewayConfigurationDownloadOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CustomerGatewayConfigurationDownloadInput)(nil)).Elem(), &CustomerGatewayConfigurationDownload{})
	pulumi.RegisterInputType(reflect.TypeOf((*CustomerGatewayConfigurationDownloadArrayInput)(nil)).Elem(), CustomerGatewayConfigurationDownloadArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CustomerGatewayConfigurationDownloadMapInput)(nil)).Elem(), CustomerGatewayConfigurationDownloadMap{})
	pulumi.RegisterOutputType(CustomerGatewayConfigurationDownloadOutput{})
	pulumi.RegisterOutputType(CustomerGatewayConfigurationDownloadArrayOutput{})
	pulumi.RegisterOutputType(CustomerGatewayConfigurationDownloadMapOutput{})
}