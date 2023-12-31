# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'CommandTag',
    'InvokerScheduleSettings',
    'GetAgentAutomationAgentSetResult',
    'GetAgentFilterResult',
    'GetCommandCommandSetResult',
    'GetCommandCommandSetTagResult',
    'GetInvocationTaskFilterResult',
    'GetInvocationTaskInvocationTaskSetResult',
    'GetInvocationTaskInvocationTaskSetCommandDocumentResult',
    'GetInvocationTaskInvocationTaskSetTaskResultResult',
    'GetInvokerInvokerSetResult',
    'GetInvokerInvokerSetScheduleSettingResult',
    'GetInvokerRecordsInvokerRecordSetResult',
]

@pulumi.output_type
class CommandTag(dict):
    def __init__(__self__, *,
                 key: str,
                 value: str):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        return pulumi.get(self, "value")


@pulumi.output_type
class InvokerScheduleSettings(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "invokeTime":
            suggest = "invoke_time"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in InvokerScheduleSettings. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        InvokerScheduleSettings.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        InvokerScheduleSettings.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 policy: str,
                 invoke_time: Optional[str] = None,
                 recurrence: Optional[str] = None):
        pulumi.set(__self__, "policy", policy)
        if invoke_time is not None:
            pulumi.set(__self__, "invoke_time", invoke_time)
        if recurrence is not None:
            pulumi.set(__self__, "recurrence", recurrence)

    @property
    @pulumi.getter
    def policy(self) -> str:
        return pulumi.get(self, "policy")

    @property
    @pulumi.getter(name="invokeTime")
    def invoke_time(self) -> Optional[str]:
        return pulumi.get(self, "invoke_time")

    @property
    @pulumi.getter
    def recurrence(self) -> Optional[str]:
        return pulumi.get(self, "recurrence")


@pulumi.output_type
class GetAgentAutomationAgentSetResult(dict):
    def __init__(__self__, *,
                 agent_status: str,
                 environment: str,
                 instance_id: str,
                 last_heartbeat_time: str,
                 support_features: Sequence[str],
                 version: str):
        pulumi.set(__self__, "agent_status", agent_status)
        pulumi.set(__self__, "environment", environment)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "last_heartbeat_time", last_heartbeat_time)
        pulumi.set(__self__, "support_features", support_features)
        pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="agentStatus")
    def agent_status(self) -> str:
        return pulumi.get(self, "agent_status")

    @property
    @pulumi.getter
    def environment(self) -> str:
        return pulumi.get(self, "environment")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="lastHeartbeatTime")
    def last_heartbeat_time(self) -> str:
        return pulumi.get(self, "last_heartbeat_time")

    @property
    @pulumi.getter(name="supportFeatures")
    def support_features(self) -> Sequence[str]:
        return pulumi.get(self, "support_features")

    @property
    @pulumi.getter
    def version(self) -> str:
        return pulumi.get(self, "version")


@pulumi.output_type
class GetAgentFilterResult(dict):
    def __init__(__self__, *,
                 name: str,
                 values: Sequence[str]):
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "values", values)

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def values(self) -> Sequence[str]:
        return pulumi.get(self, "values")


@pulumi.output_type
class GetCommandCommandSetResult(dict):
    def __init__(__self__, *,
                 command_id: str,
                 command_name: str,
                 command_type: str,
                 content: str,
                 created_by: str,
                 created_time: str,
                 default_parameters: str,
                 description: str,
                 enable_parameter: bool,
                 formatted_description: str,
                 output_cos_bucket_url: str,
                 output_cos_key_prefix: str,
                 tags: Sequence['outputs.GetCommandCommandSetTagResult'],
                 timeout: int,
                 updated_time: str,
                 username: str,
                 working_directory: str):
        pulumi.set(__self__, "command_id", command_id)
        pulumi.set(__self__, "command_name", command_name)
        pulumi.set(__self__, "command_type", command_type)
        pulumi.set(__self__, "content", content)
        pulumi.set(__self__, "created_by", created_by)
        pulumi.set(__self__, "created_time", created_time)
        pulumi.set(__self__, "default_parameters", default_parameters)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "enable_parameter", enable_parameter)
        pulumi.set(__self__, "formatted_description", formatted_description)
        pulumi.set(__self__, "output_cos_bucket_url", output_cos_bucket_url)
        pulumi.set(__self__, "output_cos_key_prefix", output_cos_key_prefix)
        pulumi.set(__self__, "tags", tags)
        pulumi.set(__self__, "timeout", timeout)
        pulumi.set(__self__, "updated_time", updated_time)
        pulumi.set(__self__, "username", username)
        pulumi.set(__self__, "working_directory", working_directory)

    @property
    @pulumi.getter(name="commandId")
    def command_id(self) -> str:
        return pulumi.get(self, "command_id")

    @property
    @pulumi.getter(name="commandName")
    def command_name(self) -> str:
        return pulumi.get(self, "command_name")

    @property
    @pulumi.getter(name="commandType")
    def command_type(self) -> str:
        return pulumi.get(self, "command_type")

    @property
    @pulumi.getter
    def content(self) -> str:
        return pulumi.get(self, "content")

    @property
    @pulumi.getter(name="createdBy")
    def created_by(self) -> str:
        return pulumi.get(self, "created_by")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> str:
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter(name="defaultParameters")
    def default_parameters(self) -> str:
        return pulumi.get(self, "default_parameters")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="enableParameter")
    def enable_parameter(self) -> bool:
        return pulumi.get(self, "enable_parameter")

    @property
    @pulumi.getter(name="formattedDescription")
    def formatted_description(self) -> str:
        return pulumi.get(self, "formatted_description")

    @property
    @pulumi.getter(name="outputCosBucketUrl")
    def output_cos_bucket_url(self) -> str:
        return pulumi.get(self, "output_cos_bucket_url")

    @property
    @pulumi.getter(name="outputCosKeyPrefix")
    def output_cos_key_prefix(self) -> str:
        return pulumi.get(self, "output_cos_key_prefix")

    @property
    @pulumi.getter
    def tags(self) -> Sequence['outputs.GetCommandCommandSetTagResult']:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def timeout(self) -> int:
        return pulumi.get(self, "timeout")

    @property
    @pulumi.getter(name="updatedTime")
    def updated_time(self) -> str:
        return pulumi.get(self, "updated_time")

    @property
    @pulumi.getter
    def username(self) -> str:
        return pulumi.get(self, "username")

    @property
    @pulumi.getter(name="workingDirectory")
    def working_directory(self) -> str:
        return pulumi.get(self, "working_directory")


@pulumi.output_type
class GetCommandCommandSetTagResult(dict):
    def __init__(__self__, *,
                 key: str,
                 value: str):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        return pulumi.get(self, "value")


@pulumi.output_type
class GetInvocationTaskFilterResult(dict):
    def __init__(__self__, *,
                 name: str,
                 values: Sequence[str]):
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "values", values)

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def values(self) -> Sequence[str]:
        return pulumi.get(self, "values")


@pulumi.output_type
class GetInvocationTaskInvocationTaskSetResult(dict):
    def __init__(__self__, *,
                 command_documents: Sequence['outputs.GetInvocationTaskInvocationTaskSetCommandDocumentResult'],
                 command_id: str,
                 created_time: str,
                 end_time: str,
                 error_info: str,
                 instance_id: str,
                 invocation_id: str,
                 invocation_source: str,
                 invocation_task_id: str,
                 start_time: str,
                 task_results: Sequence['outputs.GetInvocationTaskInvocationTaskSetTaskResultResult'],
                 task_status: str,
                 updated_time: str):
        pulumi.set(__self__, "command_documents", command_documents)
        pulumi.set(__self__, "command_id", command_id)
        pulumi.set(__self__, "created_time", created_time)
        pulumi.set(__self__, "end_time", end_time)
        pulumi.set(__self__, "error_info", error_info)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "invocation_id", invocation_id)
        pulumi.set(__self__, "invocation_source", invocation_source)
        pulumi.set(__self__, "invocation_task_id", invocation_task_id)
        pulumi.set(__self__, "start_time", start_time)
        pulumi.set(__self__, "task_results", task_results)
        pulumi.set(__self__, "task_status", task_status)
        pulumi.set(__self__, "updated_time", updated_time)

    @property
    @pulumi.getter(name="commandDocuments")
    def command_documents(self) -> Sequence['outputs.GetInvocationTaskInvocationTaskSetCommandDocumentResult']:
        return pulumi.get(self, "command_documents")

    @property
    @pulumi.getter(name="commandId")
    def command_id(self) -> str:
        return pulumi.get(self, "command_id")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> str:
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> str:
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter(name="errorInfo")
    def error_info(self) -> str:
        return pulumi.get(self, "error_info")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="invocationId")
    def invocation_id(self) -> str:
        return pulumi.get(self, "invocation_id")

    @property
    @pulumi.getter(name="invocationSource")
    def invocation_source(self) -> str:
        return pulumi.get(self, "invocation_source")

    @property
    @pulumi.getter(name="invocationTaskId")
    def invocation_task_id(self) -> str:
        return pulumi.get(self, "invocation_task_id")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter(name="taskResults")
    def task_results(self) -> Sequence['outputs.GetInvocationTaskInvocationTaskSetTaskResultResult']:
        return pulumi.get(self, "task_results")

    @property
    @pulumi.getter(name="taskStatus")
    def task_status(self) -> str:
        return pulumi.get(self, "task_status")

    @property
    @pulumi.getter(name="updatedTime")
    def updated_time(self) -> str:
        return pulumi.get(self, "updated_time")


@pulumi.output_type
class GetInvocationTaskInvocationTaskSetCommandDocumentResult(dict):
    def __init__(__self__, *,
                 command_type: str,
                 content: str,
                 output_cos_bucket_url: str,
                 output_cos_key_prefix: str,
                 timeout: int,
                 username: str,
                 working_directory: str):
        pulumi.set(__self__, "command_type", command_type)
        pulumi.set(__self__, "content", content)
        pulumi.set(__self__, "output_cos_bucket_url", output_cos_bucket_url)
        pulumi.set(__self__, "output_cos_key_prefix", output_cos_key_prefix)
        pulumi.set(__self__, "timeout", timeout)
        pulumi.set(__self__, "username", username)
        pulumi.set(__self__, "working_directory", working_directory)

    @property
    @pulumi.getter(name="commandType")
    def command_type(self) -> str:
        return pulumi.get(self, "command_type")

    @property
    @pulumi.getter
    def content(self) -> str:
        return pulumi.get(self, "content")

    @property
    @pulumi.getter(name="outputCosBucketUrl")
    def output_cos_bucket_url(self) -> str:
        return pulumi.get(self, "output_cos_bucket_url")

    @property
    @pulumi.getter(name="outputCosKeyPrefix")
    def output_cos_key_prefix(self) -> str:
        return pulumi.get(self, "output_cos_key_prefix")

    @property
    @pulumi.getter
    def timeout(self) -> int:
        return pulumi.get(self, "timeout")

    @property
    @pulumi.getter
    def username(self) -> str:
        return pulumi.get(self, "username")

    @property
    @pulumi.getter(name="workingDirectory")
    def working_directory(self) -> str:
        return pulumi.get(self, "working_directory")


@pulumi.output_type
class GetInvocationTaskInvocationTaskSetTaskResultResult(dict):
    def __init__(__self__, *,
                 dropped: int,
                 exec_end_time: str,
                 exec_start_time: str,
                 exit_code: int,
                 output: str,
                 output_upload_cos_error_info: str,
                 output_url: str):
        pulumi.set(__self__, "dropped", dropped)
        pulumi.set(__self__, "exec_end_time", exec_end_time)
        pulumi.set(__self__, "exec_start_time", exec_start_time)
        pulumi.set(__self__, "exit_code", exit_code)
        pulumi.set(__self__, "output", output)
        pulumi.set(__self__, "output_upload_cos_error_info", output_upload_cos_error_info)
        pulumi.set(__self__, "output_url", output_url)

    @property
    @pulumi.getter
    def dropped(self) -> int:
        return pulumi.get(self, "dropped")

    @property
    @pulumi.getter(name="execEndTime")
    def exec_end_time(self) -> str:
        return pulumi.get(self, "exec_end_time")

    @property
    @pulumi.getter(name="execStartTime")
    def exec_start_time(self) -> str:
        return pulumi.get(self, "exec_start_time")

    @property
    @pulumi.getter(name="exitCode")
    def exit_code(self) -> int:
        return pulumi.get(self, "exit_code")

    @property
    @pulumi.getter
    def output(self) -> str:
        return pulumi.get(self, "output")

    @property
    @pulumi.getter(name="outputUploadCosErrorInfo")
    def output_upload_cos_error_info(self) -> str:
        return pulumi.get(self, "output_upload_cos_error_info")

    @property
    @pulumi.getter(name="outputUrl")
    def output_url(self) -> str:
        return pulumi.get(self, "output_url")


@pulumi.output_type
class GetInvokerInvokerSetResult(dict):
    def __init__(__self__, *,
                 command_id: str,
                 created_time: str,
                 enable: bool,
                 instance_ids: Sequence[str],
                 invoker_id: str,
                 name: str,
                 parameters: str,
                 schedule_settings: Sequence['outputs.GetInvokerInvokerSetScheduleSettingResult'],
                 type: str,
                 updated_time: str,
                 username: str):
        pulumi.set(__self__, "command_id", command_id)
        pulumi.set(__self__, "created_time", created_time)
        pulumi.set(__self__, "enable", enable)
        pulumi.set(__self__, "instance_ids", instance_ids)
        pulumi.set(__self__, "invoker_id", invoker_id)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "parameters", parameters)
        pulumi.set(__self__, "schedule_settings", schedule_settings)
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "updated_time", updated_time)
        pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter(name="commandId")
    def command_id(self) -> str:
        return pulumi.get(self, "command_id")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> str:
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter
    def enable(self) -> bool:
        return pulumi.get(self, "enable")

    @property
    @pulumi.getter(name="instanceIds")
    def instance_ids(self) -> Sequence[str]:
        return pulumi.get(self, "instance_ids")

    @property
    @pulumi.getter(name="invokerId")
    def invoker_id(self) -> str:
        return pulumi.get(self, "invoker_id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parameters(self) -> str:
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="scheduleSettings")
    def schedule_settings(self) -> Sequence['outputs.GetInvokerInvokerSetScheduleSettingResult']:
        return pulumi.get(self, "schedule_settings")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updatedTime")
    def updated_time(self) -> str:
        return pulumi.get(self, "updated_time")

    @property
    @pulumi.getter
    def username(self) -> str:
        return pulumi.get(self, "username")


@pulumi.output_type
class GetInvokerInvokerSetScheduleSettingResult(dict):
    def __init__(__self__, *,
                 invoke_time: str,
                 policy: str,
                 recurrence: str):
        pulumi.set(__self__, "invoke_time", invoke_time)
        pulumi.set(__self__, "policy", policy)
        pulumi.set(__self__, "recurrence", recurrence)

    @property
    @pulumi.getter(name="invokeTime")
    def invoke_time(self) -> str:
        return pulumi.get(self, "invoke_time")

    @property
    @pulumi.getter
    def policy(self) -> str:
        return pulumi.get(self, "policy")

    @property
    @pulumi.getter
    def recurrence(self) -> str:
        return pulumi.get(self, "recurrence")


@pulumi.output_type
class GetInvokerRecordsInvokerRecordSetResult(dict):
    def __init__(__self__, *,
                 invocation_id: str,
                 invoke_time: str,
                 invoker_id: str,
                 reason: str,
                 result: str):
        pulumi.set(__self__, "invocation_id", invocation_id)
        pulumi.set(__self__, "invoke_time", invoke_time)
        pulumi.set(__self__, "invoker_id", invoker_id)
        pulumi.set(__self__, "reason", reason)
        pulumi.set(__self__, "result", result)

    @property
    @pulumi.getter(name="invocationId")
    def invocation_id(self) -> str:
        return pulumi.get(self, "invocation_id")

    @property
    @pulumi.getter(name="invokeTime")
    def invoke_time(self) -> str:
        return pulumi.get(self, "invoke_time")

    @property
    @pulumi.getter(name="invokerId")
    def invoker_id(self) -> str:
        return pulumi.get(self, "invoker_id")

    @property
    @pulumi.getter
    def reason(self) -> str:
        return pulumi.get(self, "reason")

    @property
    @pulumi.getter
    def result(self) -> str:
        return pulumi.get(self, "result")


