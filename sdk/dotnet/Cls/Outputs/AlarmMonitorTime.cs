// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cls.Outputs
{

    [OutputType]
    public sealed class AlarmMonitorTime
    {
        public readonly int Time;
        public readonly string Type;

        [OutputConstructor]
        private AlarmMonitorTime(
            int time,

            string type)
        {
            Time = time;
            Type = type;
        }
    }
}
