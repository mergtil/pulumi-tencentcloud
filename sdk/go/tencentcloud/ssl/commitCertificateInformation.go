// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ssl

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type CommitCertificateInformation struct {
	pulumi.CustomResourceState

	// Certificate Id.
	CertificateId pulumi.StringOutput `pulumi:"certificateId"`
	// The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
	// and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
	ConfirmLetter pulumi.StringPtrOutput `pulumi:"confirmLetter"`
	// Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
	// means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
	// Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
	// Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
	// SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
	// certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
	// multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
	// Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
	// GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
	// TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
	// Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
	// means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
	// Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
	// enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
	// wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
	// means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
	// (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
	// Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
	// State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
	// WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
	// (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
	// wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
	// enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
	// Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
	// DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
	// certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
	// Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
	// means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
	// Domain Name Type (DV) multi-domain SSL certificate.
	ProductId pulumi.IntOutput `pulumi:"productId"`
	// Domain name verification method.
	VerifyType pulumi.StringPtrOutput `pulumi:"verifyType"`
}

// NewCommitCertificateInformation registers a new resource with the given unique name, arguments, and options.
func NewCommitCertificateInformation(ctx *pulumi.Context,
	name string, args *CommitCertificateInformationArgs, opts ...pulumi.ResourceOption) (*CommitCertificateInformation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CertificateId == nil {
		return nil, errors.New("invalid value for required argument 'CertificateId'")
	}
	if args.ProductId == nil {
		return nil, errors.New("invalid value for required argument 'ProductId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CommitCertificateInformation
	err := ctx.RegisterResource("tencentcloud:Ssl/commitCertificateInformation:CommitCertificateInformation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCommitCertificateInformation gets an existing CommitCertificateInformation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCommitCertificateInformation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CommitCertificateInformationState, opts ...pulumi.ResourceOption) (*CommitCertificateInformation, error) {
	var resource CommitCertificateInformation
	err := ctx.ReadResource("tencentcloud:Ssl/commitCertificateInformation:CommitCertificateInformation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CommitCertificateInformation resources.
type commitCertificateInformationState struct {
	// Certificate Id.
	CertificateId *string `pulumi:"certificateId"`
	// The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
	// and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
	ConfirmLetter *string `pulumi:"confirmLetter"`
	// Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
	// means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
	// Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
	// Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
	// SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
	// certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
	// multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
	// Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
	// GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
	// TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
	// Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
	// means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
	// Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
	// enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
	// wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
	// means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
	// (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
	// Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
	// State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
	// WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
	// (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
	// wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
	// enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
	// Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
	// DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
	// certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
	// Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
	// means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
	// Domain Name Type (DV) multi-domain SSL certificate.
	ProductId *int `pulumi:"productId"`
	// Domain name verification method.
	VerifyType *string `pulumi:"verifyType"`
}

type CommitCertificateInformationState struct {
	// Certificate Id.
	CertificateId pulumi.StringPtrInput
	// The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
	// and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
	ConfirmLetter pulumi.StringPtrInput
	// Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
	// means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
	// Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
	// Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
	// SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
	// certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
	// multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
	// Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
	// GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
	// TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
	// Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
	// means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
	// Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
	// enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
	// wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
	// means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
	// (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
	// Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
	// State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
	// WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
	// (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
	// wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
	// enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
	// Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
	// DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
	// certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
	// Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
	// means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
	// Domain Name Type (DV) multi-domain SSL certificate.
	ProductId pulumi.IntPtrInput
	// Domain name verification method.
	VerifyType pulumi.StringPtrInput
}

func (CommitCertificateInformationState) ElementType() reflect.Type {
	return reflect.TypeOf((*commitCertificateInformationState)(nil)).Elem()
}

type commitCertificateInformationArgs struct {
	// Certificate Id.
	CertificateId string `pulumi:"certificateId"`
	// The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
	// and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
	ConfirmLetter *string `pulumi:"confirmLetter"`
	// Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
	// means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
	// Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
	// Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
	// SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
	// certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
	// multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
	// Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
	// GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
	// TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
	// Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
	// means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
	// Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
	// enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
	// wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
	// means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
	// (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
	// Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
	// State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
	// WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
	// (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
	// wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
	// enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
	// Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
	// DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
	// certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
	// Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
	// means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
	// Domain Name Type (DV) multi-domain SSL certificate.
	ProductId int `pulumi:"productId"`
	// Domain name verification method.
	VerifyType *string `pulumi:"verifyType"`
}

// The set of arguments for constructing a CommitCertificateInformation resource.
type CommitCertificateInformationArgs struct {
	// Certificate Id.
	CertificateId pulumi.StringInput
	// The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
	// and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
	ConfirmLetter pulumi.StringPtrInput
	// Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
	// means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
	// Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
	// Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
	// SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
	// certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
	// multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
	// Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
	// GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
	// TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
	// Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
	// means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
	// Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
	// enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
	// wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
	// means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
	// (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
	// Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
	// State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
	// WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
	// (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
	// wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
	// enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
	// Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
	// DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
	// certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
	// Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
	// means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
	// Domain Name Type (DV) multi-domain SSL certificate.
	ProductId pulumi.IntInput
	// Domain name verification method.
	VerifyType pulumi.StringPtrInput
}

func (CommitCertificateInformationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*commitCertificateInformationArgs)(nil)).Elem()
}

type CommitCertificateInformationInput interface {
	pulumi.Input

	ToCommitCertificateInformationOutput() CommitCertificateInformationOutput
	ToCommitCertificateInformationOutputWithContext(ctx context.Context) CommitCertificateInformationOutput
}

func (*CommitCertificateInformation) ElementType() reflect.Type {
	return reflect.TypeOf((**CommitCertificateInformation)(nil)).Elem()
}

func (i *CommitCertificateInformation) ToCommitCertificateInformationOutput() CommitCertificateInformationOutput {
	return i.ToCommitCertificateInformationOutputWithContext(context.Background())
}

func (i *CommitCertificateInformation) ToCommitCertificateInformationOutputWithContext(ctx context.Context) CommitCertificateInformationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CommitCertificateInformationOutput)
}

// CommitCertificateInformationArrayInput is an input type that accepts CommitCertificateInformationArray and CommitCertificateInformationArrayOutput values.
// You can construct a concrete instance of `CommitCertificateInformationArrayInput` via:
//
//	CommitCertificateInformationArray{ CommitCertificateInformationArgs{...} }
type CommitCertificateInformationArrayInput interface {
	pulumi.Input

	ToCommitCertificateInformationArrayOutput() CommitCertificateInformationArrayOutput
	ToCommitCertificateInformationArrayOutputWithContext(context.Context) CommitCertificateInformationArrayOutput
}

type CommitCertificateInformationArray []CommitCertificateInformationInput

func (CommitCertificateInformationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CommitCertificateInformation)(nil)).Elem()
}

func (i CommitCertificateInformationArray) ToCommitCertificateInformationArrayOutput() CommitCertificateInformationArrayOutput {
	return i.ToCommitCertificateInformationArrayOutputWithContext(context.Background())
}

func (i CommitCertificateInformationArray) ToCommitCertificateInformationArrayOutputWithContext(ctx context.Context) CommitCertificateInformationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CommitCertificateInformationArrayOutput)
}

// CommitCertificateInformationMapInput is an input type that accepts CommitCertificateInformationMap and CommitCertificateInformationMapOutput values.
// You can construct a concrete instance of `CommitCertificateInformationMapInput` via:
//
//	CommitCertificateInformationMap{ "key": CommitCertificateInformationArgs{...} }
type CommitCertificateInformationMapInput interface {
	pulumi.Input

	ToCommitCertificateInformationMapOutput() CommitCertificateInformationMapOutput
	ToCommitCertificateInformationMapOutputWithContext(context.Context) CommitCertificateInformationMapOutput
}

type CommitCertificateInformationMap map[string]CommitCertificateInformationInput

func (CommitCertificateInformationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CommitCertificateInformation)(nil)).Elem()
}

func (i CommitCertificateInformationMap) ToCommitCertificateInformationMapOutput() CommitCertificateInformationMapOutput {
	return i.ToCommitCertificateInformationMapOutputWithContext(context.Background())
}

func (i CommitCertificateInformationMap) ToCommitCertificateInformationMapOutputWithContext(ctx context.Context) CommitCertificateInformationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CommitCertificateInformationMapOutput)
}

type CommitCertificateInformationOutput struct{ *pulumi.OutputState }

func (CommitCertificateInformationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CommitCertificateInformation)(nil)).Elem()
}

func (o CommitCertificateInformationOutput) ToCommitCertificateInformationOutput() CommitCertificateInformationOutput {
	return o
}

func (o CommitCertificateInformationOutput) ToCommitCertificateInformationOutputWithContext(ctx context.Context) CommitCertificateInformationOutput {
	return o
}

// Certificate Id.
func (o CommitCertificateInformationOutput) CertificateId() pulumi.StringOutput {
	return o.ApplyT(func(v *CommitCertificateInformation) pulumi.StringOutput { return v.CertificateId }).(pulumi.StringOutput)
}

// The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
// and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
func (o CommitCertificateInformationOutput) ConfirmLetter() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CommitCertificateInformation) pulumi.StringPtrOutput { return v.ConfirmLetter }).(pulumi.StringPtrOutput)
}

// Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
// means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
// Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
// Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
// SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
// certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
// multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
// Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
// GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
// TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
// Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
// means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
// Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
// enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
// wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
// means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
// (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
// Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
// State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
// WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
// (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
// wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
// enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
// Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
// DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
// certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
// Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
// means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
// Domain Name Type (DV) multi-domain SSL certificate.
func (o CommitCertificateInformationOutput) ProductId() pulumi.IntOutput {
	return o.ApplyT(func(v *CommitCertificateInformation) pulumi.IntOutput { return v.ProductId }).(pulumi.IntOutput)
}

// Domain name verification method.
func (o CommitCertificateInformationOutput) VerifyType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CommitCertificateInformation) pulumi.StringPtrOutput { return v.VerifyType }).(pulumi.StringPtrOutput)
}

type CommitCertificateInformationArrayOutput struct{ *pulumi.OutputState }

func (CommitCertificateInformationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CommitCertificateInformation)(nil)).Elem()
}

func (o CommitCertificateInformationArrayOutput) ToCommitCertificateInformationArrayOutput() CommitCertificateInformationArrayOutput {
	return o
}

func (o CommitCertificateInformationArrayOutput) ToCommitCertificateInformationArrayOutputWithContext(ctx context.Context) CommitCertificateInformationArrayOutput {
	return o
}

func (o CommitCertificateInformationArrayOutput) Index(i pulumi.IntInput) CommitCertificateInformationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CommitCertificateInformation {
		return vs[0].([]*CommitCertificateInformation)[vs[1].(int)]
	}).(CommitCertificateInformationOutput)
}

type CommitCertificateInformationMapOutput struct{ *pulumi.OutputState }

func (CommitCertificateInformationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CommitCertificateInformation)(nil)).Elem()
}

func (o CommitCertificateInformationMapOutput) ToCommitCertificateInformationMapOutput() CommitCertificateInformationMapOutput {
	return o
}

func (o CommitCertificateInformationMapOutput) ToCommitCertificateInformationMapOutputWithContext(ctx context.Context) CommitCertificateInformationMapOutput {
	return o
}

func (o CommitCertificateInformationMapOutput) MapIndex(k pulumi.StringInput) CommitCertificateInformationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CommitCertificateInformation {
		return vs[0].(map[string]*CommitCertificateInformation)[vs[1].(string)]
	}).(CommitCertificateInformationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CommitCertificateInformationInput)(nil)).Elem(), &CommitCertificateInformation{})
	pulumi.RegisterInputType(reflect.TypeOf((*CommitCertificateInformationArrayInput)(nil)).Elem(), CommitCertificateInformationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CommitCertificateInformationMapInput)(nil)).Elem(), CommitCertificateInformationMap{})
	pulumi.RegisterOutputType(CommitCertificateInformationOutput{})
	pulumi.RegisterOutputType(CommitCertificateInformationArrayOutput{})
	pulumi.RegisterOutputType(CommitCertificateInformationMapOutput{})
}
