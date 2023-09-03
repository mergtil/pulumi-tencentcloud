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
    'GetSlowLogTimeSeriesStatsResult',
    'AwaitableGetSlowLogTimeSeriesStatsResult',
    'get_slow_log_time_series_stats',
    'get_slow_log_time_series_stats_output',
]

@pulumi.output_type
class GetSlowLogTimeSeriesStatsResult:
    """
    A collection of values returned by getSlowLogTimeSeriesStats.
    """
    def __init__(__self__, end_time=None, id=None, instance_id=None, period=None, product=None, result_output_file=None, series_datas=None, start_time=None, time_series=None):
        if end_time and not isinstance(end_time, str):
            raise TypeError("Expected argument 'end_time' to be a str")
        pulumi.set(__self__, "end_time", end_time)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if period and not isinstance(period, int):
            raise TypeError("Expected argument 'period' to be a int")
        pulumi.set(__self__, "period", period)
        if product and not isinstance(product, str):
            raise TypeError("Expected argument 'product' to be a str")
        pulumi.set(__self__, "product", product)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if series_datas and not isinstance(series_datas, list):
            raise TypeError("Expected argument 'series_datas' to be a list")
        pulumi.set(__self__, "series_datas", series_datas)
        if start_time and not isinstance(start_time, str):
            raise TypeError("Expected argument 'start_time' to be a str")
        pulumi.set(__self__, "start_time", start_time)
        if time_series and not isinstance(time_series, list):
            raise TypeError("Expected argument 'time_series' to be a list")
        pulumi.set(__self__, "time_series", time_series)

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> str:
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def period(self) -> int:
        return pulumi.get(self, "period")

    @property
    @pulumi.getter
    def product(self) -> Optional[str]:
        return pulumi.get(self, "product")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="seriesDatas")
    def series_datas(self) -> Sequence['outputs.GetSlowLogTimeSeriesStatsSeriesDataResult']:
        return pulumi.get(self, "series_datas")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter(name="timeSeries")
    def time_series(self) -> Sequence['outputs.GetSlowLogTimeSeriesStatsTimeSeriesResult']:
        return pulumi.get(self, "time_series")


class AwaitableGetSlowLogTimeSeriesStatsResult(GetSlowLogTimeSeriesStatsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSlowLogTimeSeriesStatsResult(
            end_time=self.end_time,
            id=self.id,
            instance_id=self.instance_id,
            period=self.period,
            product=self.product,
            result_output_file=self.result_output_file,
            series_datas=self.series_datas,
            start_time=self.start_time,
            time_series=self.time_series)


def get_slow_log_time_series_stats(end_time: Optional[str] = None,
                                   instance_id: Optional[str] = None,
                                   product: Optional[str] = None,
                                   result_output_file: Optional[str] = None,
                                   start_time: Optional[str] = None,
                                   opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSlowLogTimeSeriesStatsResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['endTime'] = end_time
    __args__['instanceId'] = instance_id
    __args__['product'] = product
    __args__['resultOutputFile'] = result_output_file
    __args__['startTime'] = start_time
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Dbbrain/getSlowLogTimeSeriesStats:getSlowLogTimeSeriesStats', __args__, opts=opts, typ=GetSlowLogTimeSeriesStatsResult).value

    return AwaitableGetSlowLogTimeSeriesStatsResult(
        end_time=pulumi.get(__ret__, 'end_time'),
        id=pulumi.get(__ret__, 'id'),
        instance_id=pulumi.get(__ret__, 'instance_id'),
        period=pulumi.get(__ret__, 'period'),
        product=pulumi.get(__ret__, 'product'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        series_datas=pulumi.get(__ret__, 'series_datas'),
        start_time=pulumi.get(__ret__, 'start_time'),
        time_series=pulumi.get(__ret__, 'time_series'))


@_utilities.lift_output_func(get_slow_log_time_series_stats)
def get_slow_log_time_series_stats_output(end_time: Optional[pulumi.Input[str]] = None,
                                          instance_id: Optional[pulumi.Input[str]] = None,
                                          product: Optional[pulumi.Input[Optional[str]]] = None,
                                          result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                          start_time: Optional[pulumi.Input[str]] = None,
                                          opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSlowLogTimeSeriesStatsResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...