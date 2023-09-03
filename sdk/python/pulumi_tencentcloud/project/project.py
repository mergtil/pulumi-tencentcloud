# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['ProjectArgs', 'Project']

@pulumi.input_type
class ProjectArgs:
    def __init__(__self__, *,
                 project_name: pulumi.Input[str],
                 disable: Optional[pulumi.Input[int]] = None,
                 info: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Project resource.
        :param pulumi.Input[str] project_name: Name of project.
        :param pulumi.Input[int] disable: If disable project. 1 means disable, 0 means enable. Default 0.
        :param pulumi.Input[str] info: Description of project.
        """
        pulumi.set(__self__, "project_name", project_name)
        if disable is not None:
            pulumi.set(__self__, "disable", disable)
        if info is not None:
            pulumi.set(__self__, "info", info)

    @property
    @pulumi.getter(name="projectName")
    def project_name(self) -> pulumi.Input[str]:
        """
        Name of project.
        """
        return pulumi.get(self, "project_name")

    @project_name.setter
    def project_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "project_name", value)

    @property
    @pulumi.getter
    def disable(self) -> Optional[pulumi.Input[int]]:
        """
        If disable project. 1 means disable, 0 means enable. Default 0.
        """
        return pulumi.get(self, "disable")

    @disable.setter
    def disable(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "disable", value)

    @property
    @pulumi.getter
    def info(self) -> Optional[pulumi.Input[str]]:
        """
        Description of project.
        """
        return pulumi.get(self, "info")

    @info.setter
    def info(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "info", value)


@pulumi.input_type
class _ProjectState:
    def __init__(__self__, *,
                 create_time: Optional[pulumi.Input[str]] = None,
                 creator_uin: Optional[pulumi.Input[int]] = None,
                 disable: Optional[pulumi.Input[int]] = None,
                 info: Optional[pulumi.Input[str]] = None,
                 project_name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Project resources.
        :param pulumi.Input[str] create_time: Create time.
        :param pulumi.Input[int] creator_uin: Uin of creator.
        :param pulumi.Input[int] disable: If disable project. 1 means disable, 0 means enable. Default 0.
        :param pulumi.Input[str] info: Description of project.
        :param pulumi.Input[str] project_name: Name of project.
        """
        if create_time is not None:
            pulumi.set(__self__, "create_time", create_time)
        if creator_uin is not None:
            pulumi.set(__self__, "creator_uin", creator_uin)
        if disable is not None:
            pulumi.set(__self__, "disable", disable)
        if info is not None:
            pulumi.set(__self__, "info", info)
        if project_name is not None:
            pulumi.set(__self__, "project_name", project_name)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> Optional[pulumi.Input[str]]:
        """
        Create time.
        """
        return pulumi.get(self, "create_time")

    @create_time.setter
    def create_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "create_time", value)

    @property
    @pulumi.getter(name="creatorUin")
    def creator_uin(self) -> Optional[pulumi.Input[int]]:
        """
        Uin of creator.
        """
        return pulumi.get(self, "creator_uin")

    @creator_uin.setter
    def creator_uin(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "creator_uin", value)

    @property
    @pulumi.getter
    def disable(self) -> Optional[pulumi.Input[int]]:
        """
        If disable project. 1 means disable, 0 means enable. Default 0.
        """
        return pulumi.get(self, "disable")

    @disable.setter
    def disable(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "disable", value)

    @property
    @pulumi.getter
    def info(self) -> Optional[pulumi.Input[str]]:
        """
        Description of project.
        """
        return pulumi.get(self, "info")

    @info.setter
    def info(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "info", value)

    @property
    @pulumi.getter(name="projectName")
    def project_name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of project.
        """
        return pulumi.get(self, "project_name")

    @project_name.setter
    def project_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project_name", value)


class Project(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disable: Optional[pulumi.Input[int]] = None,
                 info: Optional[pulumi.Input[str]] = None,
                 project_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a Project resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] disable: If disable project. 1 means disable, 0 means enable. Default 0.
        :param pulumi.Input[str] info: Description of project.
        :param pulumi.Input[str] project_name: Name of project.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ProjectArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a Project resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ProjectArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProjectArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disable: Optional[pulumi.Input[int]] = None,
                 info: Optional[pulumi.Input[str]] = None,
                 project_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProjectArgs.__new__(ProjectArgs)

            __props__.__dict__["disable"] = disable
            __props__.__dict__["info"] = info
            if project_name is None and not opts.urn:
                raise TypeError("Missing required property 'project_name'")
            __props__.__dict__["project_name"] = project_name
            __props__.__dict__["create_time"] = None
            __props__.__dict__["creator_uin"] = None
        super(Project, __self__).__init__(
            'tencentcloud:Project/project:Project',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            create_time: Optional[pulumi.Input[str]] = None,
            creator_uin: Optional[pulumi.Input[int]] = None,
            disable: Optional[pulumi.Input[int]] = None,
            info: Optional[pulumi.Input[str]] = None,
            project_name: Optional[pulumi.Input[str]] = None) -> 'Project':
        """
        Get an existing Project resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] create_time: Create time.
        :param pulumi.Input[int] creator_uin: Uin of creator.
        :param pulumi.Input[int] disable: If disable project. 1 means disable, 0 means enable. Default 0.
        :param pulumi.Input[str] info: Description of project.
        :param pulumi.Input[str] project_name: Name of project.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ProjectState.__new__(_ProjectState)

        __props__.__dict__["create_time"] = create_time
        __props__.__dict__["creator_uin"] = creator_uin
        __props__.__dict__["disable"] = disable
        __props__.__dict__["info"] = info
        __props__.__dict__["project_name"] = project_name
        return Project(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        Create time.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="creatorUin")
    def creator_uin(self) -> pulumi.Output[int]:
        """
        Uin of creator.
        """
        return pulumi.get(self, "creator_uin")

    @property
    @pulumi.getter
    def disable(self) -> pulumi.Output[Optional[int]]:
        """
        If disable project. 1 means disable, 0 means enable. Default 0.
        """
        return pulumi.get(self, "disable")

    @property
    @pulumi.getter
    def info(self) -> pulumi.Output[Optional[str]]:
        """
        Description of project.
        """
        return pulumi.get(self, "info")

    @property
    @pulumi.getter(name="projectName")
    def project_name(self) -> pulumi.Output[str]:
        """
        Name of project.
        """
        return pulumi.get(self, "project_name")
