// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package apigateway

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type Upstream struct {
	pulumi.CustomResourceState

	// Load balancing algorithm, value range: ROUND-ROBIN.
	Algorithm pulumi.StringOutput `pulumi:"algorithm"`
	// Health check configuration, currently only supports VPC channels.
	HealthChecker UpstreamHealthCheckerPtrOutput `pulumi:"healthChecker"`
	// Configuration of K8S container service.
	K8sServices UpstreamK8sServiceArrayOutput `pulumi:"k8sServices"`
	// Backend nodes.
	Nodes UpstreamNodeArrayOutput `pulumi:"nodes"`
	// Request retry count, default to 3 times.
	Retries pulumi.IntPtrOutput `pulumi:"retries"`
	// Backend protocol, value range: HTTP, HTTPS, gRPC, gRPCs.
	Scheme pulumi.StringOutput `pulumi:"scheme"`
	// Tag description list.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// VPC Unique ID.
	UniqVpcId pulumi.StringOutput `pulumi:"uniqVpcId"`
	// Backend channel description.
	UpstreamDescription pulumi.StringPtrOutput `pulumi:"upstreamDescription"`
	// Host request header forwarded by gateway to backend.
	UpstreamHost pulumi.StringPtrOutput `pulumi:"upstreamHost"`
	// Backend channel name.
	UpstreamName pulumi.StringPtrOutput `pulumi:"upstreamName"`
	// Backend access type, value range: IP_PORT, K8S.
	UpstreamType pulumi.StringPtrOutput `pulumi:"upstreamType"`
}

// NewUpstream registers a new resource with the given unique name, arguments, and options.
func NewUpstream(ctx *pulumi.Context,
	name string, args *UpstreamArgs, opts ...pulumi.ResourceOption) (*Upstream, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Algorithm == nil {
		return nil, errors.New("invalid value for required argument 'Algorithm'")
	}
	if args.Scheme == nil {
		return nil, errors.New("invalid value for required argument 'Scheme'")
	}
	if args.UniqVpcId == nil {
		return nil, errors.New("invalid value for required argument 'UniqVpcId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Upstream
	err := ctx.RegisterResource("tencentcloud:ApiGateway/upstream:Upstream", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUpstream gets an existing Upstream resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUpstream(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *UpstreamState, opts ...pulumi.ResourceOption) (*Upstream, error) {
	var resource Upstream
	err := ctx.ReadResource("tencentcloud:ApiGateway/upstream:Upstream", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Upstream resources.
type upstreamState struct {
	// Load balancing algorithm, value range: ROUND-ROBIN.
	Algorithm *string `pulumi:"algorithm"`
	// Health check configuration, currently only supports VPC channels.
	HealthChecker *UpstreamHealthChecker `pulumi:"healthChecker"`
	// Configuration of K8S container service.
	K8sServices []UpstreamK8sService `pulumi:"k8sServices"`
	// Backend nodes.
	Nodes []UpstreamNode `pulumi:"nodes"`
	// Request retry count, default to 3 times.
	Retries *int `pulumi:"retries"`
	// Backend protocol, value range: HTTP, HTTPS, gRPC, gRPCs.
	Scheme *string `pulumi:"scheme"`
	// Tag description list.
	Tags map[string]interface{} `pulumi:"tags"`
	// VPC Unique ID.
	UniqVpcId *string `pulumi:"uniqVpcId"`
	// Backend channel description.
	UpstreamDescription *string `pulumi:"upstreamDescription"`
	// Host request header forwarded by gateway to backend.
	UpstreamHost *string `pulumi:"upstreamHost"`
	// Backend channel name.
	UpstreamName *string `pulumi:"upstreamName"`
	// Backend access type, value range: IP_PORT, K8S.
	UpstreamType *string `pulumi:"upstreamType"`
}

type UpstreamState struct {
	// Load balancing algorithm, value range: ROUND-ROBIN.
	Algorithm pulumi.StringPtrInput
	// Health check configuration, currently only supports VPC channels.
	HealthChecker UpstreamHealthCheckerPtrInput
	// Configuration of K8S container service.
	K8sServices UpstreamK8sServiceArrayInput
	// Backend nodes.
	Nodes UpstreamNodeArrayInput
	// Request retry count, default to 3 times.
	Retries pulumi.IntPtrInput
	// Backend protocol, value range: HTTP, HTTPS, gRPC, gRPCs.
	Scheme pulumi.StringPtrInput
	// Tag description list.
	Tags pulumi.MapInput
	// VPC Unique ID.
	UniqVpcId pulumi.StringPtrInput
	// Backend channel description.
	UpstreamDescription pulumi.StringPtrInput
	// Host request header forwarded by gateway to backend.
	UpstreamHost pulumi.StringPtrInput
	// Backend channel name.
	UpstreamName pulumi.StringPtrInput
	// Backend access type, value range: IP_PORT, K8S.
	UpstreamType pulumi.StringPtrInput
}

func (UpstreamState) ElementType() reflect.Type {
	return reflect.TypeOf((*upstreamState)(nil)).Elem()
}

type upstreamArgs struct {
	// Load balancing algorithm, value range: ROUND-ROBIN.
	Algorithm string `pulumi:"algorithm"`
	// Health check configuration, currently only supports VPC channels.
	HealthChecker *UpstreamHealthChecker `pulumi:"healthChecker"`
	// Configuration of K8S container service.
	K8sServices []UpstreamK8sService `pulumi:"k8sServices"`
	// Backend nodes.
	Nodes []UpstreamNode `pulumi:"nodes"`
	// Request retry count, default to 3 times.
	Retries *int `pulumi:"retries"`
	// Backend protocol, value range: HTTP, HTTPS, gRPC, gRPCs.
	Scheme string `pulumi:"scheme"`
	// Tag description list.
	Tags map[string]interface{} `pulumi:"tags"`
	// VPC Unique ID.
	UniqVpcId string `pulumi:"uniqVpcId"`
	// Backend channel description.
	UpstreamDescription *string `pulumi:"upstreamDescription"`
	// Host request header forwarded by gateway to backend.
	UpstreamHost *string `pulumi:"upstreamHost"`
	// Backend channel name.
	UpstreamName *string `pulumi:"upstreamName"`
	// Backend access type, value range: IP_PORT, K8S.
	UpstreamType *string `pulumi:"upstreamType"`
}

// The set of arguments for constructing a Upstream resource.
type UpstreamArgs struct {
	// Load balancing algorithm, value range: ROUND-ROBIN.
	Algorithm pulumi.StringInput
	// Health check configuration, currently only supports VPC channels.
	HealthChecker UpstreamHealthCheckerPtrInput
	// Configuration of K8S container service.
	K8sServices UpstreamK8sServiceArrayInput
	// Backend nodes.
	Nodes UpstreamNodeArrayInput
	// Request retry count, default to 3 times.
	Retries pulumi.IntPtrInput
	// Backend protocol, value range: HTTP, HTTPS, gRPC, gRPCs.
	Scheme pulumi.StringInput
	// Tag description list.
	Tags pulumi.MapInput
	// VPC Unique ID.
	UniqVpcId pulumi.StringInput
	// Backend channel description.
	UpstreamDescription pulumi.StringPtrInput
	// Host request header forwarded by gateway to backend.
	UpstreamHost pulumi.StringPtrInput
	// Backend channel name.
	UpstreamName pulumi.StringPtrInput
	// Backend access type, value range: IP_PORT, K8S.
	UpstreamType pulumi.StringPtrInput
}

func (UpstreamArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*upstreamArgs)(nil)).Elem()
}

type UpstreamInput interface {
	pulumi.Input

	ToUpstreamOutput() UpstreamOutput
	ToUpstreamOutputWithContext(ctx context.Context) UpstreamOutput
}

func (*Upstream) ElementType() reflect.Type {
	return reflect.TypeOf((**Upstream)(nil)).Elem()
}

func (i *Upstream) ToUpstreamOutput() UpstreamOutput {
	return i.ToUpstreamOutputWithContext(context.Background())
}

func (i *Upstream) ToUpstreamOutputWithContext(ctx context.Context) UpstreamOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UpstreamOutput)
}

// UpstreamArrayInput is an input type that accepts UpstreamArray and UpstreamArrayOutput values.
// You can construct a concrete instance of `UpstreamArrayInput` via:
//
//	UpstreamArray{ UpstreamArgs{...} }
type UpstreamArrayInput interface {
	pulumi.Input

	ToUpstreamArrayOutput() UpstreamArrayOutput
	ToUpstreamArrayOutputWithContext(context.Context) UpstreamArrayOutput
}

type UpstreamArray []UpstreamInput

func (UpstreamArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Upstream)(nil)).Elem()
}

func (i UpstreamArray) ToUpstreamArrayOutput() UpstreamArrayOutput {
	return i.ToUpstreamArrayOutputWithContext(context.Background())
}

func (i UpstreamArray) ToUpstreamArrayOutputWithContext(ctx context.Context) UpstreamArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UpstreamArrayOutput)
}

// UpstreamMapInput is an input type that accepts UpstreamMap and UpstreamMapOutput values.
// You can construct a concrete instance of `UpstreamMapInput` via:
//
//	UpstreamMap{ "key": UpstreamArgs{...} }
type UpstreamMapInput interface {
	pulumi.Input

	ToUpstreamMapOutput() UpstreamMapOutput
	ToUpstreamMapOutputWithContext(context.Context) UpstreamMapOutput
}

type UpstreamMap map[string]UpstreamInput

func (UpstreamMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Upstream)(nil)).Elem()
}

func (i UpstreamMap) ToUpstreamMapOutput() UpstreamMapOutput {
	return i.ToUpstreamMapOutputWithContext(context.Background())
}

func (i UpstreamMap) ToUpstreamMapOutputWithContext(ctx context.Context) UpstreamMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UpstreamMapOutput)
}

type UpstreamOutput struct{ *pulumi.OutputState }

func (UpstreamOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Upstream)(nil)).Elem()
}

func (o UpstreamOutput) ToUpstreamOutput() UpstreamOutput {
	return o
}

func (o UpstreamOutput) ToUpstreamOutputWithContext(ctx context.Context) UpstreamOutput {
	return o
}

// Load balancing algorithm, value range: ROUND-ROBIN.
func (o UpstreamOutput) Algorithm() pulumi.StringOutput {
	return o.ApplyT(func(v *Upstream) pulumi.StringOutput { return v.Algorithm }).(pulumi.StringOutput)
}

// Health check configuration, currently only supports VPC channels.
func (o UpstreamOutput) HealthChecker() UpstreamHealthCheckerPtrOutput {
	return o.ApplyT(func(v *Upstream) UpstreamHealthCheckerPtrOutput { return v.HealthChecker }).(UpstreamHealthCheckerPtrOutput)
}

// Configuration of K8S container service.
func (o UpstreamOutput) K8sServices() UpstreamK8sServiceArrayOutput {
	return o.ApplyT(func(v *Upstream) UpstreamK8sServiceArrayOutput { return v.K8sServices }).(UpstreamK8sServiceArrayOutput)
}

// Backend nodes.
func (o UpstreamOutput) Nodes() UpstreamNodeArrayOutput {
	return o.ApplyT(func(v *Upstream) UpstreamNodeArrayOutput { return v.Nodes }).(UpstreamNodeArrayOutput)
}

// Request retry count, default to 3 times.
func (o UpstreamOutput) Retries() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Upstream) pulumi.IntPtrOutput { return v.Retries }).(pulumi.IntPtrOutput)
}

// Backend protocol, value range: HTTP, HTTPS, gRPC, gRPCs.
func (o UpstreamOutput) Scheme() pulumi.StringOutput {
	return o.ApplyT(func(v *Upstream) pulumi.StringOutput { return v.Scheme }).(pulumi.StringOutput)
}

// Tag description list.
func (o UpstreamOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v *Upstream) pulumi.MapOutput { return v.Tags }).(pulumi.MapOutput)
}

// VPC Unique ID.
func (o UpstreamOutput) UniqVpcId() pulumi.StringOutput {
	return o.ApplyT(func(v *Upstream) pulumi.StringOutput { return v.UniqVpcId }).(pulumi.StringOutput)
}

// Backend channel description.
func (o UpstreamOutput) UpstreamDescription() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Upstream) pulumi.StringPtrOutput { return v.UpstreamDescription }).(pulumi.StringPtrOutput)
}

// Host request header forwarded by gateway to backend.
func (o UpstreamOutput) UpstreamHost() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Upstream) pulumi.StringPtrOutput { return v.UpstreamHost }).(pulumi.StringPtrOutput)
}

// Backend channel name.
func (o UpstreamOutput) UpstreamName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Upstream) pulumi.StringPtrOutput { return v.UpstreamName }).(pulumi.StringPtrOutput)
}

// Backend access type, value range: IP_PORT, K8S.
func (o UpstreamOutput) UpstreamType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Upstream) pulumi.StringPtrOutput { return v.UpstreamType }).(pulumi.StringPtrOutput)
}

type UpstreamArrayOutput struct{ *pulumi.OutputState }

func (UpstreamArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Upstream)(nil)).Elem()
}

func (o UpstreamArrayOutput) ToUpstreamArrayOutput() UpstreamArrayOutput {
	return o
}

func (o UpstreamArrayOutput) ToUpstreamArrayOutputWithContext(ctx context.Context) UpstreamArrayOutput {
	return o
}

func (o UpstreamArrayOutput) Index(i pulumi.IntInput) UpstreamOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Upstream {
		return vs[0].([]*Upstream)[vs[1].(int)]
	}).(UpstreamOutput)
}

type UpstreamMapOutput struct{ *pulumi.OutputState }

func (UpstreamMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Upstream)(nil)).Elem()
}

func (o UpstreamMapOutput) ToUpstreamMapOutput() UpstreamMapOutput {
	return o
}

func (o UpstreamMapOutput) ToUpstreamMapOutputWithContext(ctx context.Context) UpstreamMapOutput {
	return o
}

func (o UpstreamMapOutput) MapIndex(k pulumi.StringInput) UpstreamOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Upstream {
		return vs[0].(map[string]*Upstream)[vs[1].(string)]
	}).(UpstreamOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*UpstreamInput)(nil)).Elem(), &Upstream{})
	pulumi.RegisterInputType(reflect.TypeOf((*UpstreamArrayInput)(nil)).Elem(), UpstreamArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*UpstreamMapInput)(nil)).Elem(), UpstreamMap{})
	pulumi.RegisterOutputType(UpstreamOutput{})
	pulumi.RegisterOutputType(UpstreamArrayOutput{})
	pulumi.RegisterOutputType(UpstreamMapOutput{})
}