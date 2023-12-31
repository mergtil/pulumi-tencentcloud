// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dcdb

import (
	"context"
	"reflect"

	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetUpgradePrice(ctx *pulumi.Context, args *GetUpgradePriceArgs, opts ...pulumi.InvokeOption) (*GetUpgradePriceResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetUpgradePriceResult
	err := ctx.Invoke("tencentcloud:Dcdb/getUpgradePrice:getUpgradePrice", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getUpgradePrice.
type GetUpgradePriceArgs struct {
	AddShardConfig    *GetUpgradePriceAddShardConfig    `pulumi:"addShardConfig"`
	AmountUnit        *string                           `pulumi:"amountUnit"`
	ExpandShardConfig *GetUpgradePriceExpandShardConfig `pulumi:"expandShardConfig"`
	InstanceId        string                            `pulumi:"instanceId"`
	ResultOutputFile  *string                           `pulumi:"resultOutputFile"`
	SplitShardConfig  *GetUpgradePriceSplitShardConfig  `pulumi:"splitShardConfig"`
	UpgradeType       string                            `pulumi:"upgradeType"`
}

// A collection of values returned by getUpgradePrice.
type GetUpgradePriceResult struct {
	AddShardConfig    *GetUpgradePriceAddShardConfig    `pulumi:"addShardConfig"`
	AmountUnit        *string                           `pulumi:"amountUnit"`
	ExpandShardConfig *GetUpgradePriceExpandShardConfig `pulumi:"expandShardConfig"`
	Formula           string                            `pulumi:"formula"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                           `pulumi:"id"`
	InstanceId       string                           `pulumi:"instanceId"`
	OriginalPrice    int                              `pulumi:"originalPrice"`
	Price            int                              `pulumi:"price"`
	ResultOutputFile *string                          `pulumi:"resultOutputFile"`
	SplitShardConfig *GetUpgradePriceSplitShardConfig `pulumi:"splitShardConfig"`
	UpgradeType      string                           `pulumi:"upgradeType"`
}

func GetUpgradePriceOutput(ctx *pulumi.Context, args GetUpgradePriceOutputArgs, opts ...pulumi.InvokeOption) GetUpgradePriceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetUpgradePriceResult, error) {
			args := v.(GetUpgradePriceArgs)
			r, err := GetUpgradePrice(ctx, &args, opts...)
			var s GetUpgradePriceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetUpgradePriceResultOutput)
}

// A collection of arguments for invoking getUpgradePrice.
type GetUpgradePriceOutputArgs struct {
	AddShardConfig    GetUpgradePriceAddShardConfigPtrInput    `pulumi:"addShardConfig"`
	AmountUnit        pulumi.StringPtrInput                    `pulumi:"amountUnit"`
	ExpandShardConfig GetUpgradePriceExpandShardConfigPtrInput `pulumi:"expandShardConfig"`
	InstanceId        pulumi.StringInput                       `pulumi:"instanceId"`
	ResultOutputFile  pulumi.StringPtrInput                    `pulumi:"resultOutputFile"`
	SplitShardConfig  GetUpgradePriceSplitShardConfigPtrInput  `pulumi:"splitShardConfig"`
	UpgradeType       pulumi.StringInput                       `pulumi:"upgradeType"`
}

func (GetUpgradePriceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetUpgradePriceArgs)(nil)).Elem()
}

// A collection of values returned by getUpgradePrice.
type GetUpgradePriceResultOutput struct{ *pulumi.OutputState }

func (GetUpgradePriceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetUpgradePriceResult)(nil)).Elem()
}

func (o GetUpgradePriceResultOutput) ToGetUpgradePriceResultOutput() GetUpgradePriceResultOutput {
	return o
}

func (o GetUpgradePriceResultOutput) ToGetUpgradePriceResultOutputWithContext(ctx context.Context) GetUpgradePriceResultOutput {
	return o
}

func (o GetUpgradePriceResultOutput) AddShardConfig() GetUpgradePriceAddShardConfigPtrOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) *GetUpgradePriceAddShardConfig { return v.AddShardConfig }).(GetUpgradePriceAddShardConfigPtrOutput)
}

func (o GetUpgradePriceResultOutput) AmountUnit() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) *string { return v.AmountUnit }).(pulumi.StringPtrOutput)
}

func (o GetUpgradePriceResultOutput) ExpandShardConfig() GetUpgradePriceExpandShardConfigPtrOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) *GetUpgradePriceExpandShardConfig { return v.ExpandShardConfig }).(GetUpgradePriceExpandShardConfigPtrOutput)
}

func (o GetUpgradePriceResultOutput) Formula() pulumi.StringOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) string { return v.Formula }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetUpgradePriceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetUpgradePriceResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetUpgradePriceResultOutput) OriginalPrice() pulumi.IntOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) int { return v.OriginalPrice }).(pulumi.IntOutput)
}

func (o GetUpgradePriceResultOutput) Price() pulumi.IntOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) int { return v.Price }).(pulumi.IntOutput)
}

func (o GetUpgradePriceResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetUpgradePriceResultOutput) SplitShardConfig() GetUpgradePriceSplitShardConfigPtrOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) *GetUpgradePriceSplitShardConfig { return v.SplitShardConfig }).(GetUpgradePriceSplitShardConfigPtrOutput)
}

func (o GetUpgradePriceResultOutput) UpgradeType() pulumi.StringOutput {
	return o.ApplyT(func(v GetUpgradePriceResult) string { return v.UpgradeType }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetUpgradePriceResultOutput{})
}
