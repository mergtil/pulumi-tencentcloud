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
    'EventConnectorConnectionDescription',
    'EventConnectorConnectionDescriptionApiGwParams',
    'EventConnectorConnectionDescriptionCkafkaParams',
    'EventTargetTargetDescription',
    'EventTargetTargetDescriptionCkafkaTargetParams',
    'EventTargetTargetDescriptionCkafkaTargetParamsRetryPolicy',
    'EventTargetTargetDescriptionEsTargetParams',
    'EventTargetTargetDescriptionScfParams',
    'EventTransformTransformation',
    'EventTransformTransformationEtlFilter',
    'EventTransformTransformationExtraction',
    'EventTransformTransformationExtractionTextParams',
    'EventTransformTransformationTransform',
    'EventTransformTransformationTransformOutputStruct',
    'PutEventsEventList',
    'GetBusEventBusResult',
    'GetBusEventBusConnectionBriefResult',
    'GetBusEventBusTargetBriefResult',
    'GetBusFilterResult',
    'GetEventRulesRuleResult',
    'GetEventRulesRuleDeadLetterConfigResult',
    'GetEventRulesRuleDeadLetterConfigCkafkaDeliveryParamResult',
    'GetEventRulesRuleTargetResult',
    'GetSearchFilterResult',
    'GetSearchFilterFilterResult',
    'GetSearchResultResult',
]

@pulumi.output_type
class EventConnectorConnectionDescription(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "resourceDescription":
            suggest = "resource_description"
        elif key == "apiGwParams":
            suggest = "api_gw_params"
        elif key == "ckafkaParams":
            suggest = "ckafka_params"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventConnectorConnectionDescription. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventConnectorConnectionDescription.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventConnectorConnectionDescription.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 resource_description: str,
                 api_gw_params: Optional['outputs.EventConnectorConnectionDescriptionApiGwParams'] = None,
                 ckafka_params: Optional['outputs.EventConnectorConnectionDescriptionCkafkaParams'] = None):
        pulumi.set(__self__, "resource_description", resource_description)
        if api_gw_params is not None:
            pulumi.set(__self__, "api_gw_params", api_gw_params)
        if ckafka_params is not None:
            pulumi.set(__self__, "ckafka_params", ckafka_params)

    @property
    @pulumi.getter(name="resourceDescription")
    def resource_description(self) -> str:
        return pulumi.get(self, "resource_description")

    @property
    @pulumi.getter(name="apiGwParams")
    def api_gw_params(self) -> Optional['outputs.EventConnectorConnectionDescriptionApiGwParams']:
        return pulumi.get(self, "api_gw_params")

    @property
    @pulumi.getter(name="ckafkaParams")
    def ckafka_params(self) -> Optional['outputs.EventConnectorConnectionDescriptionCkafkaParams']:
        return pulumi.get(self, "ckafka_params")


@pulumi.output_type
class EventConnectorConnectionDescriptionApiGwParams(dict):
    def __init__(__self__, *,
                 method: str,
                 protocol: str):
        pulumi.set(__self__, "method", method)
        pulumi.set(__self__, "protocol", protocol)

    @property
    @pulumi.getter
    def method(self) -> str:
        return pulumi.get(self, "method")

    @property
    @pulumi.getter
    def protocol(self) -> str:
        return pulumi.get(self, "protocol")


@pulumi.output_type
class EventConnectorConnectionDescriptionCkafkaParams(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "topicName":
            suggest = "topic_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventConnectorConnectionDescriptionCkafkaParams. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventConnectorConnectionDescriptionCkafkaParams.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventConnectorConnectionDescriptionCkafkaParams.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 offset: str,
                 topic_name: str):
        pulumi.set(__self__, "offset", offset)
        pulumi.set(__self__, "topic_name", topic_name)

    @property
    @pulumi.getter
    def offset(self) -> str:
        return pulumi.get(self, "offset")

    @property
    @pulumi.getter(name="topicName")
    def topic_name(self) -> str:
        return pulumi.get(self, "topic_name")


@pulumi.output_type
class EventTargetTargetDescription(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "resourceDescription":
            suggest = "resource_description"
        elif key == "ckafkaTargetParams":
            suggest = "ckafka_target_params"
        elif key == "esTargetParams":
            suggest = "es_target_params"
        elif key == "scfParams":
            suggest = "scf_params"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventTargetTargetDescription. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventTargetTargetDescription.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventTargetTargetDescription.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 resource_description: str,
                 ckafka_target_params: Optional['outputs.EventTargetTargetDescriptionCkafkaTargetParams'] = None,
                 es_target_params: Optional['outputs.EventTargetTargetDescriptionEsTargetParams'] = None,
                 scf_params: Optional['outputs.EventTargetTargetDescriptionScfParams'] = None):
        pulumi.set(__self__, "resource_description", resource_description)
        if ckafka_target_params is not None:
            pulumi.set(__self__, "ckafka_target_params", ckafka_target_params)
        if es_target_params is not None:
            pulumi.set(__self__, "es_target_params", es_target_params)
        if scf_params is not None:
            pulumi.set(__self__, "scf_params", scf_params)

    @property
    @pulumi.getter(name="resourceDescription")
    def resource_description(self) -> str:
        return pulumi.get(self, "resource_description")

    @property
    @pulumi.getter(name="ckafkaTargetParams")
    def ckafka_target_params(self) -> Optional['outputs.EventTargetTargetDescriptionCkafkaTargetParams']:
        return pulumi.get(self, "ckafka_target_params")

    @property
    @pulumi.getter(name="esTargetParams")
    def es_target_params(self) -> Optional['outputs.EventTargetTargetDescriptionEsTargetParams']:
        return pulumi.get(self, "es_target_params")

    @property
    @pulumi.getter(name="scfParams")
    def scf_params(self) -> Optional['outputs.EventTargetTargetDescriptionScfParams']:
        return pulumi.get(self, "scf_params")


@pulumi.output_type
class EventTargetTargetDescriptionCkafkaTargetParams(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "retryPolicy":
            suggest = "retry_policy"
        elif key == "topicName":
            suggest = "topic_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventTargetTargetDescriptionCkafkaTargetParams. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventTargetTargetDescriptionCkafkaTargetParams.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventTargetTargetDescriptionCkafkaTargetParams.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 retry_policy: 'outputs.EventTargetTargetDescriptionCkafkaTargetParamsRetryPolicy',
                 topic_name: str):
        pulumi.set(__self__, "retry_policy", retry_policy)
        pulumi.set(__self__, "topic_name", topic_name)

    @property
    @pulumi.getter(name="retryPolicy")
    def retry_policy(self) -> 'outputs.EventTargetTargetDescriptionCkafkaTargetParamsRetryPolicy':
        return pulumi.get(self, "retry_policy")

    @property
    @pulumi.getter(name="topicName")
    def topic_name(self) -> str:
        return pulumi.get(self, "topic_name")


@pulumi.output_type
class EventTargetTargetDescriptionCkafkaTargetParamsRetryPolicy(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "maxRetryAttempts":
            suggest = "max_retry_attempts"
        elif key == "retryInterval":
            suggest = "retry_interval"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventTargetTargetDescriptionCkafkaTargetParamsRetryPolicy. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventTargetTargetDescriptionCkafkaTargetParamsRetryPolicy.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventTargetTargetDescriptionCkafkaTargetParamsRetryPolicy.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 max_retry_attempts: int,
                 retry_interval: int):
        pulumi.set(__self__, "max_retry_attempts", max_retry_attempts)
        pulumi.set(__self__, "retry_interval", retry_interval)

    @property
    @pulumi.getter(name="maxRetryAttempts")
    def max_retry_attempts(self) -> int:
        return pulumi.get(self, "max_retry_attempts")

    @property
    @pulumi.getter(name="retryInterval")
    def retry_interval(self) -> int:
        return pulumi.get(self, "retry_interval")


@pulumi.output_type
class EventTargetTargetDescriptionEsTargetParams(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "indexPrefix":
            suggest = "index_prefix"
        elif key == "indexSuffixMode":
            suggest = "index_suffix_mode"
        elif key == "netMode":
            suggest = "net_mode"
        elif key == "outputMode":
            suggest = "output_mode"
        elif key == "rotationInterval":
            suggest = "rotation_interval"
        elif key == "indexTemplateType":
            suggest = "index_template_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventTargetTargetDescriptionEsTargetParams. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventTargetTargetDescriptionEsTargetParams.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventTargetTargetDescriptionEsTargetParams.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 index_prefix: str,
                 index_suffix_mode: str,
                 net_mode: str,
                 output_mode: str,
                 rotation_interval: str,
                 index_template_type: Optional[str] = None):
        pulumi.set(__self__, "index_prefix", index_prefix)
        pulumi.set(__self__, "index_suffix_mode", index_suffix_mode)
        pulumi.set(__self__, "net_mode", net_mode)
        pulumi.set(__self__, "output_mode", output_mode)
        pulumi.set(__self__, "rotation_interval", rotation_interval)
        if index_template_type is not None:
            pulumi.set(__self__, "index_template_type", index_template_type)

    @property
    @pulumi.getter(name="indexPrefix")
    def index_prefix(self) -> str:
        return pulumi.get(self, "index_prefix")

    @property
    @pulumi.getter(name="indexSuffixMode")
    def index_suffix_mode(self) -> str:
        return pulumi.get(self, "index_suffix_mode")

    @property
    @pulumi.getter(name="netMode")
    def net_mode(self) -> str:
        return pulumi.get(self, "net_mode")

    @property
    @pulumi.getter(name="outputMode")
    def output_mode(self) -> str:
        return pulumi.get(self, "output_mode")

    @property
    @pulumi.getter(name="rotationInterval")
    def rotation_interval(self) -> str:
        return pulumi.get(self, "rotation_interval")

    @property
    @pulumi.getter(name="indexTemplateType")
    def index_template_type(self) -> Optional[str]:
        return pulumi.get(self, "index_template_type")


@pulumi.output_type
class EventTargetTargetDescriptionScfParams(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "batchEventCount":
            suggest = "batch_event_count"
        elif key == "batchTimeout":
            suggest = "batch_timeout"
        elif key == "enableBatchDelivery":
            suggest = "enable_batch_delivery"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventTargetTargetDescriptionScfParams. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventTargetTargetDescriptionScfParams.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventTargetTargetDescriptionScfParams.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 batch_event_count: Optional[int] = None,
                 batch_timeout: Optional[int] = None,
                 enable_batch_delivery: Optional[bool] = None):
        if batch_event_count is not None:
            pulumi.set(__self__, "batch_event_count", batch_event_count)
        if batch_timeout is not None:
            pulumi.set(__self__, "batch_timeout", batch_timeout)
        if enable_batch_delivery is not None:
            pulumi.set(__self__, "enable_batch_delivery", enable_batch_delivery)

    @property
    @pulumi.getter(name="batchEventCount")
    def batch_event_count(self) -> Optional[int]:
        return pulumi.get(self, "batch_event_count")

    @property
    @pulumi.getter(name="batchTimeout")
    def batch_timeout(self) -> Optional[int]:
        return pulumi.get(self, "batch_timeout")

    @property
    @pulumi.getter(name="enableBatchDelivery")
    def enable_batch_delivery(self) -> Optional[bool]:
        return pulumi.get(self, "enable_batch_delivery")


@pulumi.output_type
class EventTransformTransformation(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "etlFilter":
            suggest = "etl_filter"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventTransformTransformation. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventTransformTransformation.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventTransformTransformation.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 etl_filter: Optional['outputs.EventTransformTransformationEtlFilter'] = None,
                 extraction: Optional['outputs.EventTransformTransformationExtraction'] = None,
                 transform: Optional['outputs.EventTransformTransformationTransform'] = None):
        if etl_filter is not None:
            pulumi.set(__self__, "etl_filter", etl_filter)
        if extraction is not None:
            pulumi.set(__self__, "extraction", extraction)
        if transform is not None:
            pulumi.set(__self__, "transform", transform)

    @property
    @pulumi.getter(name="etlFilter")
    def etl_filter(self) -> Optional['outputs.EventTransformTransformationEtlFilter']:
        return pulumi.get(self, "etl_filter")

    @property
    @pulumi.getter
    def extraction(self) -> Optional['outputs.EventTransformTransformationExtraction']:
        return pulumi.get(self, "extraction")

    @property
    @pulumi.getter
    def transform(self) -> Optional['outputs.EventTransformTransformationTransform']:
        return pulumi.get(self, "transform")


@pulumi.output_type
class EventTransformTransformationEtlFilter(dict):
    def __init__(__self__, *,
                 filter: str):
        pulumi.set(__self__, "filter", filter)

    @property
    @pulumi.getter
    def filter(self) -> str:
        return pulumi.get(self, "filter")


@pulumi.output_type
class EventTransformTransformationExtraction(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "extractionInputPath":
            suggest = "extraction_input_path"
        elif key == "textParams":
            suggest = "text_params"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventTransformTransformationExtraction. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventTransformTransformationExtraction.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventTransformTransformationExtraction.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 extraction_input_path: str,
                 format: str,
                 text_params: Optional['outputs.EventTransformTransformationExtractionTextParams'] = None):
        pulumi.set(__self__, "extraction_input_path", extraction_input_path)
        pulumi.set(__self__, "format", format)
        if text_params is not None:
            pulumi.set(__self__, "text_params", text_params)

    @property
    @pulumi.getter(name="extractionInputPath")
    def extraction_input_path(self) -> str:
        return pulumi.get(self, "extraction_input_path")

    @property
    @pulumi.getter
    def format(self) -> str:
        return pulumi.get(self, "format")

    @property
    @pulumi.getter(name="textParams")
    def text_params(self) -> Optional['outputs.EventTransformTransformationExtractionTextParams']:
        return pulumi.get(self, "text_params")


@pulumi.output_type
class EventTransformTransformationExtractionTextParams(dict):
    def __init__(__self__, *,
                 regex: Optional[str] = None,
                 separator: Optional[str] = None):
        if regex is not None:
            pulumi.set(__self__, "regex", regex)
        if separator is not None:
            pulumi.set(__self__, "separator", separator)

    @property
    @pulumi.getter
    def regex(self) -> Optional[str]:
        return pulumi.get(self, "regex")

    @property
    @pulumi.getter
    def separator(self) -> Optional[str]:
        return pulumi.get(self, "separator")


@pulumi.output_type
class EventTransformTransformationTransform(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "outputStructs":
            suggest = "output_structs"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventTransformTransformationTransform. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventTransformTransformationTransform.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventTransformTransformationTransform.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 output_structs: Sequence['outputs.EventTransformTransformationTransformOutputStruct']):
        pulumi.set(__self__, "output_structs", output_structs)

    @property
    @pulumi.getter(name="outputStructs")
    def output_structs(self) -> Sequence['outputs.EventTransformTransformationTransformOutputStruct']:
        return pulumi.get(self, "output_structs")


@pulumi.output_type
class EventTransformTransformationTransformOutputStruct(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "valueType":
            suggest = "value_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in EventTransformTransformationTransformOutputStruct. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        EventTransformTransformationTransformOutputStruct.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        EventTransformTransformationTransformOutputStruct.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 key: str,
                 value: str,
                 value_type: str):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)
        pulumi.set(__self__, "value_type", value_type)

    @property
    @pulumi.getter
    def key(self) -> str:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        return pulumi.get(self, "value")

    @property
    @pulumi.getter(name="valueType")
    def value_type(self) -> str:
        return pulumi.get(self, "value_type")


@pulumi.output_type
class PutEventsEventList(dict):
    def __init__(__self__, *,
                 data: str,
                 source: str,
                 subject: str,
                 type: str,
                 time: Optional[int] = None):
        pulumi.set(__self__, "data", data)
        pulumi.set(__self__, "source", source)
        pulumi.set(__self__, "subject", subject)
        pulumi.set(__self__, "type", type)
        if time is not None:
            pulumi.set(__self__, "time", time)

    @property
    @pulumi.getter
    def data(self) -> str:
        return pulumi.get(self, "data")

    @property
    @pulumi.getter
    def source(self) -> str:
        return pulumi.get(self, "source")

    @property
    @pulumi.getter
    def subject(self) -> str:
        return pulumi.get(self, "subject")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def time(self) -> Optional[int]:
        return pulumi.get(self, "time")


@pulumi.output_type
class GetBusEventBusResult(dict):
    def __init__(__self__, *,
                 add_time: str,
                 connection_briefs: Sequence['outputs.GetBusEventBusConnectionBriefResult'],
                 description: str,
                 event_bus_id: str,
                 event_bus_name: str,
                 mod_time: str,
                 pay_mode: str,
                 target_briefs: Sequence['outputs.GetBusEventBusTargetBriefResult'],
                 type: str):
        pulumi.set(__self__, "add_time", add_time)
        pulumi.set(__self__, "connection_briefs", connection_briefs)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "event_bus_id", event_bus_id)
        pulumi.set(__self__, "event_bus_name", event_bus_name)
        pulumi.set(__self__, "mod_time", mod_time)
        pulumi.set(__self__, "pay_mode", pay_mode)
        pulumi.set(__self__, "target_briefs", target_briefs)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="addTime")
    def add_time(self) -> str:
        return pulumi.get(self, "add_time")

    @property
    @pulumi.getter(name="connectionBriefs")
    def connection_briefs(self) -> Sequence['outputs.GetBusEventBusConnectionBriefResult']:
        return pulumi.get(self, "connection_briefs")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="eventBusId")
    def event_bus_id(self) -> str:
        return pulumi.get(self, "event_bus_id")

    @property
    @pulumi.getter(name="eventBusName")
    def event_bus_name(self) -> str:
        return pulumi.get(self, "event_bus_name")

    @property
    @pulumi.getter(name="modTime")
    def mod_time(self) -> str:
        return pulumi.get(self, "mod_time")

    @property
    @pulumi.getter(name="payMode")
    def pay_mode(self) -> str:
        return pulumi.get(self, "pay_mode")

    @property
    @pulumi.getter(name="targetBriefs")
    def target_briefs(self) -> Sequence['outputs.GetBusEventBusTargetBriefResult']:
        return pulumi.get(self, "target_briefs")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")


@pulumi.output_type
class GetBusEventBusConnectionBriefResult(dict):
    def __init__(__self__, *,
                 status: str,
                 type: str):
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")


@pulumi.output_type
class GetBusEventBusTargetBriefResult(dict):
    def __init__(__self__, *,
                 target_id: str,
                 type: str):
        pulumi.set(__self__, "target_id", target_id)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="targetId")
    def target_id(self) -> str:
        return pulumi.get(self, "target_id")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")


@pulumi.output_type
class GetBusFilterResult(dict):
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
class GetEventRulesRuleResult(dict):
    def __init__(__self__, *,
                 add_time: str,
                 dead_letter_configs: Sequence['outputs.GetEventRulesRuleDeadLetterConfigResult'],
                 description: str,
                 enable: bool,
                 event_bus_id: str,
                 mod_time: str,
                 rule_id: str,
                 rule_name: str,
                 status: str,
                 targets: Sequence['outputs.GetEventRulesRuleTargetResult']):
        pulumi.set(__self__, "add_time", add_time)
        pulumi.set(__self__, "dead_letter_configs", dead_letter_configs)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "enable", enable)
        pulumi.set(__self__, "event_bus_id", event_bus_id)
        pulumi.set(__self__, "mod_time", mod_time)
        pulumi.set(__self__, "rule_id", rule_id)
        pulumi.set(__self__, "rule_name", rule_name)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "targets", targets)

    @property
    @pulumi.getter(name="addTime")
    def add_time(self) -> str:
        return pulumi.get(self, "add_time")

    @property
    @pulumi.getter(name="deadLetterConfigs")
    def dead_letter_configs(self) -> Sequence['outputs.GetEventRulesRuleDeadLetterConfigResult']:
        return pulumi.get(self, "dead_letter_configs")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enable(self) -> bool:
        return pulumi.get(self, "enable")

    @property
    @pulumi.getter(name="eventBusId")
    def event_bus_id(self) -> str:
        return pulumi.get(self, "event_bus_id")

    @property
    @pulumi.getter(name="modTime")
    def mod_time(self) -> str:
        return pulumi.get(self, "mod_time")

    @property
    @pulumi.getter(name="ruleId")
    def rule_id(self) -> str:
        return pulumi.get(self, "rule_id")

    @property
    @pulumi.getter(name="ruleName")
    def rule_name(self) -> str:
        return pulumi.get(self, "rule_name")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def targets(self) -> Sequence['outputs.GetEventRulesRuleTargetResult']:
        return pulumi.get(self, "targets")


@pulumi.output_type
class GetEventRulesRuleDeadLetterConfigResult(dict):
    def __init__(__self__, *,
                 ckafka_delivery_params: Sequence['outputs.GetEventRulesRuleDeadLetterConfigCkafkaDeliveryParamResult'],
                 dispose_method: str):
        pulumi.set(__self__, "ckafka_delivery_params", ckafka_delivery_params)
        pulumi.set(__self__, "dispose_method", dispose_method)

    @property
    @pulumi.getter(name="ckafkaDeliveryParams")
    def ckafka_delivery_params(self) -> Sequence['outputs.GetEventRulesRuleDeadLetterConfigCkafkaDeliveryParamResult']:
        return pulumi.get(self, "ckafka_delivery_params")

    @property
    @pulumi.getter(name="disposeMethod")
    def dispose_method(self) -> str:
        return pulumi.get(self, "dispose_method")


@pulumi.output_type
class GetEventRulesRuleDeadLetterConfigCkafkaDeliveryParamResult(dict):
    def __init__(__self__, *,
                 resource_description: str,
                 topic_name: str):
        pulumi.set(__self__, "resource_description", resource_description)
        pulumi.set(__self__, "topic_name", topic_name)

    @property
    @pulumi.getter(name="resourceDescription")
    def resource_description(self) -> str:
        return pulumi.get(self, "resource_description")

    @property
    @pulumi.getter(name="topicName")
    def topic_name(self) -> str:
        return pulumi.get(self, "topic_name")


@pulumi.output_type
class GetEventRulesRuleTargetResult(dict):
    def __init__(__self__, *,
                 target_id: str,
                 type: str):
        pulumi.set(__self__, "target_id", target_id)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="targetId")
    def target_id(self) -> str:
        return pulumi.get(self, "target_id")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")


@pulumi.output_type
class GetSearchFilterResult(dict):
    def __init__(__self__, *,
                 filters: Optional[Sequence['outputs.GetSearchFilterFilterResult']] = None,
                 key: Optional[str] = None,
                 operator: Optional[str] = None,
                 type: Optional[str] = None,
                 value: Optional[str] = None):
        if filters is not None:
            pulumi.set(__self__, "filters", filters)
        if key is not None:
            pulumi.set(__self__, "key", key)
        if operator is not None:
            pulumi.set(__self__, "operator", operator)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def filters(self) -> Optional[Sequence['outputs.GetSearchFilterFilterResult']]:
        return pulumi.get(self, "filters")

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def operator(self) -> Optional[str]:
        return pulumi.get(self, "operator")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        return pulumi.get(self, "value")


@pulumi.output_type
class GetSearchFilterFilterResult(dict):
    def __init__(__self__, *,
                 key: str,
                 operator: str,
                 value: str):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "operator", operator)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def operator(self) -> str:
        return pulumi.get(self, "operator")

    @property
    @pulumi.getter
    def value(self) -> str:
        return pulumi.get(self, "value")


@pulumi.output_type
class GetSearchResultResult(dict):
    def __init__(__self__, *,
                 message: str,
                 region: str,
                 rule_ids: str,
                 source: str,
                 status: str,
                 subject: str,
                 timestamp: str,
                 type: str):
        pulumi.set(__self__, "message", message)
        pulumi.set(__self__, "region", region)
        pulumi.set(__self__, "rule_ids", rule_ids)
        pulumi.set(__self__, "source", source)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "subject", subject)
        pulumi.set(__self__, "timestamp", timestamp)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def message(self) -> str:
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def region(self) -> str:
        return pulumi.get(self, "region")

    @property
    @pulumi.getter(name="ruleIds")
    def rule_ids(self) -> str:
        return pulumi.get(self, "rule_ids")

    @property
    @pulumi.getter
    def source(self) -> str:
        return pulumi.get(self, "source")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def subject(self) -> str:
        return pulumi.get(self, "subject")

    @property
    @pulumi.getter
    def timestamp(self) -> str:
        return pulumi.get(self, "timestamp")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")

