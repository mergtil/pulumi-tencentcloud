// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type TimeWindow struct {
	pulumi.CustomResourceState

	// Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the
	// TencentDB Console page.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Data delay threshold. It takes effect only for source instance and disaster recovery instance. Default value: 10.
	MaxDelayTime pulumi.IntPtrOutput `pulumi:"maxDelayTime"`
	// Time period available for maintenance after modification in the format of 10:00-12:00. Each period lasts from half an
	// hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. Start and
	// end time range: [00:00, 24:00].
	TimeRanges pulumi.StringArrayOutput `pulumi:"timeRanges"`
	// Specifies for which day to modify the time period. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
	// Sunday. If it is not specified or is left blank, the time period will be modified for every day by default.
	Weekdays pulumi.StringArrayOutput `pulumi:"weekdays"`
}

// NewTimeWindow registers a new resource with the given unique name, arguments, and options.
func NewTimeWindow(ctx *pulumi.Context,
	name string, args *TimeWindowArgs, opts ...pulumi.ResourceOption) (*TimeWindow, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.TimeRanges == nil {
		return nil, errors.New("invalid value for required argument 'TimeRanges'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource TimeWindow
	err := ctx.RegisterResource("tencentcloud:Mysql/timeWindow:TimeWindow", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTimeWindow gets an existing TimeWindow resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTimeWindow(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TimeWindowState, opts ...pulumi.ResourceOption) (*TimeWindow, error) {
	var resource TimeWindow
	err := ctx.ReadResource("tencentcloud:Mysql/timeWindow:TimeWindow", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TimeWindow resources.
type timeWindowState struct {
	// Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the
	// TencentDB Console page.
	InstanceId *string `pulumi:"instanceId"`
	// Data delay threshold. It takes effect only for source instance and disaster recovery instance. Default value: 10.
	MaxDelayTime *int `pulumi:"maxDelayTime"`
	// Time period available for maintenance after modification in the format of 10:00-12:00. Each period lasts from half an
	// hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. Start and
	// end time range: [00:00, 24:00].
	TimeRanges []string `pulumi:"timeRanges"`
	// Specifies for which day to modify the time period. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
	// Sunday. If it is not specified or is left blank, the time period will be modified for every day by default.
	Weekdays []string `pulumi:"weekdays"`
}

type TimeWindowState struct {
	// Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the
	// TencentDB Console page.
	InstanceId pulumi.StringPtrInput
	// Data delay threshold. It takes effect only for source instance and disaster recovery instance. Default value: 10.
	MaxDelayTime pulumi.IntPtrInput
	// Time period available for maintenance after modification in the format of 10:00-12:00. Each period lasts from half an
	// hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. Start and
	// end time range: [00:00, 24:00].
	TimeRanges pulumi.StringArrayInput
	// Specifies for which day to modify the time period. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
	// Sunday. If it is not specified or is left blank, the time period will be modified for every day by default.
	Weekdays pulumi.StringArrayInput
}

func (TimeWindowState) ElementType() reflect.Type {
	return reflect.TypeOf((*timeWindowState)(nil)).Elem()
}

type timeWindowArgs struct {
	// Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the
	// TencentDB Console page.
	InstanceId string `pulumi:"instanceId"`
	// Data delay threshold. It takes effect only for source instance and disaster recovery instance. Default value: 10.
	MaxDelayTime *int `pulumi:"maxDelayTime"`
	// Time period available for maintenance after modification in the format of 10:00-12:00. Each period lasts from half an
	// hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. Start and
	// end time range: [00:00, 24:00].
	TimeRanges []string `pulumi:"timeRanges"`
	// Specifies for which day to modify the time period. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
	// Sunday. If it is not specified or is left blank, the time period will be modified for every day by default.
	Weekdays []string `pulumi:"weekdays"`
}

// The set of arguments for constructing a TimeWindow resource.
type TimeWindowArgs struct {
	// Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the
	// TencentDB Console page.
	InstanceId pulumi.StringInput
	// Data delay threshold. It takes effect only for source instance and disaster recovery instance. Default value: 10.
	MaxDelayTime pulumi.IntPtrInput
	// Time period available for maintenance after modification in the format of 10:00-12:00. Each period lasts from half an
	// hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. Start and
	// end time range: [00:00, 24:00].
	TimeRanges pulumi.StringArrayInput
	// Specifies for which day to modify the time period. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
	// Sunday. If it is not specified or is left blank, the time period will be modified for every day by default.
	Weekdays pulumi.StringArrayInput
}

func (TimeWindowArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*timeWindowArgs)(nil)).Elem()
}

type TimeWindowInput interface {
	pulumi.Input

	ToTimeWindowOutput() TimeWindowOutput
	ToTimeWindowOutputWithContext(ctx context.Context) TimeWindowOutput
}

func (*TimeWindow) ElementType() reflect.Type {
	return reflect.TypeOf((**TimeWindow)(nil)).Elem()
}

func (i *TimeWindow) ToTimeWindowOutput() TimeWindowOutput {
	return i.ToTimeWindowOutputWithContext(context.Background())
}

func (i *TimeWindow) ToTimeWindowOutputWithContext(ctx context.Context) TimeWindowOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TimeWindowOutput)
}

// TimeWindowArrayInput is an input type that accepts TimeWindowArray and TimeWindowArrayOutput values.
// You can construct a concrete instance of `TimeWindowArrayInput` via:
//
//	TimeWindowArray{ TimeWindowArgs{...} }
type TimeWindowArrayInput interface {
	pulumi.Input

	ToTimeWindowArrayOutput() TimeWindowArrayOutput
	ToTimeWindowArrayOutputWithContext(context.Context) TimeWindowArrayOutput
}

type TimeWindowArray []TimeWindowInput

func (TimeWindowArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TimeWindow)(nil)).Elem()
}

func (i TimeWindowArray) ToTimeWindowArrayOutput() TimeWindowArrayOutput {
	return i.ToTimeWindowArrayOutputWithContext(context.Background())
}

func (i TimeWindowArray) ToTimeWindowArrayOutputWithContext(ctx context.Context) TimeWindowArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TimeWindowArrayOutput)
}

// TimeWindowMapInput is an input type that accepts TimeWindowMap and TimeWindowMapOutput values.
// You can construct a concrete instance of `TimeWindowMapInput` via:
//
//	TimeWindowMap{ "key": TimeWindowArgs{...} }
type TimeWindowMapInput interface {
	pulumi.Input

	ToTimeWindowMapOutput() TimeWindowMapOutput
	ToTimeWindowMapOutputWithContext(context.Context) TimeWindowMapOutput
}

type TimeWindowMap map[string]TimeWindowInput

func (TimeWindowMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TimeWindow)(nil)).Elem()
}

func (i TimeWindowMap) ToTimeWindowMapOutput() TimeWindowMapOutput {
	return i.ToTimeWindowMapOutputWithContext(context.Background())
}

func (i TimeWindowMap) ToTimeWindowMapOutputWithContext(ctx context.Context) TimeWindowMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TimeWindowMapOutput)
}

type TimeWindowOutput struct{ *pulumi.OutputState }

func (TimeWindowOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TimeWindow)(nil)).Elem()
}

func (o TimeWindowOutput) ToTimeWindowOutput() TimeWindowOutput {
	return o
}

func (o TimeWindowOutput) ToTimeWindowOutputWithContext(ctx context.Context) TimeWindowOutput {
	return o
}

// Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the
// TencentDB Console page.
func (o TimeWindowOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *TimeWindow) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Data delay threshold. It takes effect only for source instance and disaster recovery instance. Default value: 10.
func (o TimeWindowOutput) MaxDelayTime() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *TimeWindow) pulumi.IntPtrOutput { return v.MaxDelayTime }).(pulumi.IntPtrOutput)
}

// Time period available for maintenance after modification in the format of 10:00-12:00. Each period lasts from half an
// hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. Start and
// end time range: [00:00, 24:00].
func (o TimeWindowOutput) TimeRanges() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *TimeWindow) pulumi.StringArrayOutput { return v.TimeRanges }).(pulumi.StringArrayOutput)
}

// Specifies for which day to modify the time period. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
// Sunday. If it is not specified or is left blank, the time period will be modified for every day by default.
func (o TimeWindowOutput) Weekdays() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *TimeWindow) pulumi.StringArrayOutput { return v.Weekdays }).(pulumi.StringArrayOutput)
}

type TimeWindowArrayOutput struct{ *pulumi.OutputState }

func (TimeWindowArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TimeWindow)(nil)).Elem()
}

func (o TimeWindowArrayOutput) ToTimeWindowArrayOutput() TimeWindowArrayOutput {
	return o
}

func (o TimeWindowArrayOutput) ToTimeWindowArrayOutputWithContext(ctx context.Context) TimeWindowArrayOutput {
	return o
}

func (o TimeWindowArrayOutput) Index(i pulumi.IntInput) TimeWindowOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *TimeWindow {
		return vs[0].([]*TimeWindow)[vs[1].(int)]
	}).(TimeWindowOutput)
}

type TimeWindowMapOutput struct{ *pulumi.OutputState }

func (TimeWindowMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TimeWindow)(nil)).Elem()
}

func (o TimeWindowMapOutput) ToTimeWindowMapOutput() TimeWindowMapOutput {
	return o
}

func (o TimeWindowMapOutput) ToTimeWindowMapOutputWithContext(ctx context.Context) TimeWindowMapOutput {
	return o
}

func (o TimeWindowMapOutput) MapIndex(k pulumi.StringInput) TimeWindowOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *TimeWindow {
		return vs[0].(map[string]*TimeWindow)[vs[1].(string)]
	}).(TimeWindowOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TimeWindowInput)(nil)).Elem(), &TimeWindow{})
	pulumi.RegisterInputType(reflect.TypeOf((*TimeWindowArrayInput)(nil)).Elem(), TimeWindowArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TimeWindowMapInput)(nil)).Elem(), TimeWindowMap{})
	pulumi.RegisterOutputType(TimeWindowOutput{})
	pulumi.RegisterOutputType(TimeWindowArrayOutput{})
	pulumi.RegisterOutputType(TimeWindowMapOutput{})
}