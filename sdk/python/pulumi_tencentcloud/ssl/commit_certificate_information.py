# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['CommitCertificateInformationArgs', 'CommitCertificateInformation']

@pulumi.input_type
class CommitCertificateInformationArgs:
    def __init__(__self__, *,
                 certificate_id: pulumi.Input[str],
                 product_id: pulumi.Input[int],
                 confirm_letter: Optional[pulumi.Input[str]] = None,
                 verify_type: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a CommitCertificateInformation resource.
        :param pulumi.Input[str] certificate_id: Certificate Id.
        :param pulumi.Input[int] product_id: Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
               means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
               Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
               Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
               SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
               certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
               multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
               Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
               GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
               TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
               Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
               means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
               Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
               enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
               wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
               means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
               (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
               Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
               State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
               WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
               (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
               wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
               enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
               Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
               DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
               certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
               Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
               means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
               Domain Name Type (DV) multi-domain SSL certificate.
        :param pulumi.Input[str] confirm_letter: The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
               and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
        :param pulumi.Input[str] verify_type: Domain name verification method.
        """
        pulumi.set(__self__, "certificate_id", certificate_id)
        pulumi.set(__self__, "product_id", product_id)
        if confirm_letter is not None:
            pulumi.set(__self__, "confirm_letter", confirm_letter)
        if verify_type is not None:
            pulumi.set(__self__, "verify_type", verify_type)

    @property
    @pulumi.getter(name="certificateId")
    def certificate_id(self) -> pulumi.Input[str]:
        """
        Certificate Id.
        """
        return pulumi.get(self, "certificate_id")

    @certificate_id.setter
    def certificate_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "certificate_id", value)

    @property
    @pulumi.getter(name="productId")
    def product_id(self) -> pulumi.Input[int]:
        """
        Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
        means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
        Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
        Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
        SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
        certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
        multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
        Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
        GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
        TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
        Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
        means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
        Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
        enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
        wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
        means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
        (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
        Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
        State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
        WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
        (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
        wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
        enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
        Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
        DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
        certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
        Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
        means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
        Domain Name Type (DV) multi-domain SSL certificate.
        """
        return pulumi.get(self, "product_id")

    @product_id.setter
    def product_id(self, value: pulumi.Input[int]):
        pulumi.set(self, "product_id", value)

    @property
    @pulumi.getter(name="confirmLetter")
    def confirm_letter(self) -> Optional[pulumi.Input[str]]:
        """
        The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
        and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
        """
        return pulumi.get(self, "confirm_letter")

    @confirm_letter.setter
    def confirm_letter(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "confirm_letter", value)

    @property
    @pulumi.getter(name="verifyType")
    def verify_type(self) -> Optional[pulumi.Input[str]]:
        """
        Domain name verification method.
        """
        return pulumi.get(self, "verify_type")

    @verify_type.setter
    def verify_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "verify_type", value)


@pulumi.input_type
class _CommitCertificateInformationState:
    def __init__(__self__, *,
                 certificate_id: Optional[pulumi.Input[str]] = None,
                 confirm_letter: Optional[pulumi.Input[str]] = None,
                 product_id: Optional[pulumi.Input[int]] = None,
                 verify_type: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering CommitCertificateInformation resources.
        :param pulumi.Input[str] certificate_id: Certificate Id.
        :param pulumi.Input[str] confirm_letter: The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
               and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
        :param pulumi.Input[int] product_id: Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
               means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
               Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
               Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
               SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
               certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
               multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
               Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
               GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
               TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
               Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
               means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
               Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
               enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
               wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
               means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
               (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
               Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
               State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
               WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
               (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
               wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
               enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
               Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
               DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
               certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
               Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
               means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
               Domain Name Type (DV) multi-domain SSL certificate.
        :param pulumi.Input[str] verify_type: Domain name verification method.
        """
        if certificate_id is not None:
            pulumi.set(__self__, "certificate_id", certificate_id)
        if confirm_letter is not None:
            pulumi.set(__self__, "confirm_letter", confirm_letter)
        if product_id is not None:
            pulumi.set(__self__, "product_id", product_id)
        if verify_type is not None:
            pulumi.set(__self__, "verify_type", verify_type)

    @property
    @pulumi.getter(name="certificateId")
    def certificate_id(self) -> Optional[pulumi.Input[str]]:
        """
        Certificate Id.
        """
        return pulumi.get(self, "certificate_id")

    @certificate_id.setter
    def certificate_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "certificate_id", value)

    @property
    @pulumi.getter(name="confirmLetter")
    def confirm_letter(self) -> Optional[pulumi.Input[str]]:
        """
        The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
        and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
        """
        return pulumi.get(self, "confirm_letter")

    @confirm_letter.setter
    def confirm_letter(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "confirm_letter", value)

    @property
    @pulumi.getter(name="productId")
    def product_id(self) -> Optional[pulumi.Input[int]]:
        """
        Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
        means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
        Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
        Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
        SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
        certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
        multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
        Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
        GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
        TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
        Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
        means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
        Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
        enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
        wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
        means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
        (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
        Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
        State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
        WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
        (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
        wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
        enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
        Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
        DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
        certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
        Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
        means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
        Domain Name Type (DV) multi-domain SSL certificate.
        """
        return pulumi.get(self, "product_id")

    @product_id.setter
    def product_id(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "product_id", value)

    @property
    @pulumi.getter(name="verifyType")
    def verify_type(self) -> Optional[pulumi.Input[str]]:
        """
        Domain name verification method.
        """
        return pulumi.get(self, "verify_type")

    @verify_type.setter
    def verify_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "verify_type", value)


class CommitCertificateInformation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 certificate_id: Optional[pulumi.Input[str]] = None,
                 confirm_letter: Optional[pulumi.Input[str]] = None,
                 product_id: Optional[pulumi.Input[int]] = None,
                 verify_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a CommitCertificateInformation resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] certificate_id: Certificate Id.
        :param pulumi.Input[str] confirm_letter: The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
               and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
        :param pulumi.Input[int] product_id: Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
               means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
               Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
               Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
               SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
               certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
               multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
               Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
               GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
               TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
               Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
               means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
               Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
               enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
               wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
               means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
               (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
               Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
               State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
               WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
               (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
               wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
               enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
               Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
               DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
               certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
               Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
               means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
               Domain Name Type (DV) multi-domain SSL certificate.
        :param pulumi.Input[str] verify_type: Domain name verification method.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CommitCertificateInformationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a CommitCertificateInformation resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param CommitCertificateInformationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CommitCertificateInformationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 certificate_id: Optional[pulumi.Input[str]] = None,
                 confirm_letter: Optional[pulumi.Input[str]] = None,
                 product_id: Optional[pulumi.Input[int]] = None,
                 verify_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CommitCertificateInformationArgs.__new__(CommitCertificateInformationArgs)

            if certificate_id is None and not opts.urn:
                raise TypeError("Missing required property 'certificate_id'")
            __props__.__dict__["certificate_id"] = certificate_id
            __props__.__dict__["confirm_letter"] = confirm_letter
            if product_id is None and not opts.urn:
                raise TypeError("Missing required property 'product_id'")
            __props__.__dict__["product_id"] = product_id
            __props__.__dict__["verify_type"] = verify_type
        super(CommitCertificateInformation, __self__).__init__(
            'tencentcloud:Ssl/commitCertificateInformation:CommitCertificateInformation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            certificate_id: Optional[pulumi.Input[str]] = None,
            confirm_letter: Optional[pulumi.Input[str]] = None,
            product_id: Optional[pulumi.Input[int]] = None,
            verify_type: Optional[pulumi.Input[str]] = None) -> 'CommitCertificateInformation':
        """
        Get an existing CommitCertificateInformation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] certificate_id: Certificate Id.
        :param pulumi.Input[str] confirm_letter: The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
               and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
        :param pulumi.Input[int] product_id: Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
               means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
               Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
               Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
               SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
               certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
               multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
               Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
               GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
               TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
               Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
               means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
               Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
               enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
               wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
               means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
               (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
               Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
               State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
               WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
               (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
               wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
               enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
               Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
               DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
               certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
               Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
               means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
               Domain Name Type (DV) multi-domain SSL certificate.
        :param pulumi.Input[str] verify_type: Domain name verification method.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _CommitCertificateInformationState.__new__(_CommitCertificateInformationState)

        __props__.__dict__["certificate_id"] = certificate_id
        __props__.__dict__["confirm_letter"] = confirm_letter
        __props__.__dict__["product_id"] = product_id
        __props__.__dict__["verify_type"] = verify_type
        return CommitCertificateInformation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="certificateId")
    def certificate_id(self) -> pulumi.Output[str]:
        """
        Certificate Id.
        """
        return pulumi.get(self, "certificate_id")

    @property
    @pulumi.getter(name="confirmLetter")
    def confirm_letter(self) -> pulumi.Output[Optional[str]]:
        """
        The base64-encoded certificate confirmation file should be in jpg, jpeg, png, pdf, and the size should be between 1kb
        and 1.4M. Note: it only works when product_id is set to 8, 9 or 10.
        """
        return pulumi.get(self, "confirm_letter")

    @property
    @pulumi.getter(name="productId")
    def product_id(self) -> pulumi.Output[int]:
        """
        Certificate commodity ID. Valid value ranges: (3~42). `3` means SecureSite enhanced Enterprise Edition (EV Pro), `4`
        means SecureSite enhanced (EV), `5` means SecureSite Enterprise Professional Edition (OV Pro), `6` means SecureSite
        Enterprise (OV), `7` means SecureSite Enterprise Type (OV) wildcard, `8` means Geotrust enhanced (EV), `9` means
        Geotrust enterprise (OV), `10` means Geotrust enterprise (OV) wildcard, `11` means TrustAsia domain type multi-domain
        SSL certificate, `12` means TrustAsia domain type ( DV) wildcard, `13` means TrustAsia enterprise wildcard (OV) SSL
        certificate (D3), `14` means TrustAsia enterprise (OV) SSL certificate (D3), `15` means TrustAsia enterprise
        multi-domain (OV) SSL certificate (D3), `16` means TrustAsia Enhanced (EV) SSL Certificate (D3), `17` means TrustAsia
        Enhanced Multiple Domain (EV) SSL Certificate (D3), `18` means GlobalSign Enterprise (OV) SSL Certificate, `19` means
        GlobalSign Enterprise Wildcard (OV) SSL Certificate, `20` means GlobalSign Enhanced (EV) SSL Certificate, `21` means
        TrustAsia Enterprise Wildcard Multiple Domain (OV) SSL Certificate (D3), `22` means GlobalSign Enterprise Multiple
        Domain (OV) SSL Certificate, `23` means GlobalSign Enterprise Multiple Wildcard Domain name (OV) SSL certificate, `24`
        means GlobalSign enhanced multi-domain (EV) SSL certificate, `25` means Wotrus domain type certificate, `26` means
        Wotrus domain type multi-domain certificate, `27` means Wotrus domain type wildcard certificate, `28` means Wotrus
        enterprise type certificate, `29` means Wotrus enterprise multi-domain certificate, `30` means Wotrus enterprise
        wildcard certificate, `31` means Wotrus enhanced certificate, `32` means Wotrus enhanced multi-domain certificate, `33`
        means WoTrus National Secret Domain name Certificate, `34` means WoTrus National Secret Domain name Certificate
        (multiple domain names), `35` WoTrus National Secret Domain name Certificate (wildcard), `37` means WoTrus State Secret
        Enterprise Certificate, `38` means WoTrus State Secret Enterprise Certificate (multiple domain names), `39` means WoTrus
        State Secret Enterprise Certificate (wildcard), `40` means WoTrus National secret enhanced certificate, `41` means
        WoTrus National Secret enhanced Certificate (multiple domain names), `42` means TrustAsia- Domain name Certificate
        (wildcard multiple domain names), `43` means DNSPod Enterprise (OV) SSL Certificate, `44` means DNSPod- Enterprise (OV)
        wildcard SSL certificate, `45` means DNSPod Enterprise (OV) Multi-domain name SSL Certificate, `46` means DNSPod
        enhanced (EV) SSL certificate, `47` means DNSPod enhanced (EV) multi-domain name SSL certificate, `48` means DNSPod
        Domain name Type (DV) SSL Certificate, `49` means DNSPod Domain name Type (DV) wildcard SSL certificate, `50` means
        DNSPod domain name type (DV) multi-domain name SSL certificate, `51` means DNSPod (State Secret) Enterprise (OV) SSL
        certificate, `52` DNSPod (National Secret) Enterprise (OV) wildcard SSL certificate, `53` means DNSPod (National Secret)
        Enterprise (OV) multi-domain SSL certificate, `54` means DNSPod (National Secret) Domain Name (DV) SSL certificate, `55`
        means DNSPod (National Secret) Domain Name Type (DV) wildcard SSL certificate, `56` means DNSPod (National Secret)
        Domain Name Type (DV) multi-domain SSL certificate.
        """
        return pulumi.get(self, "product_id")

    @property
    @pulumi.getter(name="verifyType")
    def verify_type(self) -> pulumi.Output[Optional[str]]:
        """
        Domain name verification method.
        """
        return pulumi.get(self, "verify_type")

