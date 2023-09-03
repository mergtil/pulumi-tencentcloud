// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mps

import (
	"context"
	"reflect"

	"errors"
	"github.com/mergtil/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type TranscodeTemplate struct {
	pulumi.CustomResourceState

	// Audio stream configuration parameters, when RemoveAudio is 0, this field is required.
	AudioTemplate TranscodeTemplateAudioTemplatePtrOutput `pulumi:"audioTemplate"`
	// Template description information, length limit: 256 characters.
	Comment pulumi.StringPtrOutput `pulumi:"comment"`
	// Encapsulation format, optional values: mp4, flv, hls, mp3, flac, ogg, m4a. Among them, mp3, flac, ogg, m4a are pure
	// audio files.
	Container pulumi.StringOutput `pulumi:"container"`
	// Audio and video enhancement configuration.
	EnhanceConfig TranscodeTemplateEnhanceConfigPtrOutput `pulumi:"enhanceConfig"`
	// Transcoding template name, length limit: 64 characters.
	Name pulumi.StringOutput `pulumi:"name"`
	// Whether to remove audio data, value:0: reserved.1: remove.Default: 0.
	RemoveAudio pulumi.IntPtrOutput `pulumi:"removeAudio"`
	// Whether to remove video data, value:0: reserved.1: remove.Default: 0.
	RemoveVideo pulumi.IntPtrOutput `pulumi:"removeVideo"`
	// Ultra-fast HD transcoding parameters.
	TehdConfig TranscodeTemplateTehdConfigPtrOutput `pulumi:"tehdConfig"`
	// Video stream configuration parameters, when RemoveVideo is 0, this field is required.
	VideoTemplate TranscodeTemplateVideoTemplatePtrOutput `pulumi:"videoTemplate"`
}

// NewTranscodeTemplate registers a new resource with the given unique name, arguments, and options.
func NewTranscodeTemplate(ctx *pulumi.Context,
	name string, args *TranscodeTemplateArgs, opts ...pulumi.ResourceOption) (*TranscodeTemplate, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Container == nil {
		return nil, errors.New("invalid value for required argument 'Container'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource TranscodeTemplate
	err := ctx.RegisterResource("tencentcloud:Mps/transcodeTemplate:TranscodeTemplate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTranscodeTemplate gets an existing TranscodeTemplate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTranscodeTemplate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TranscodeTemplateState, opts ...pulumi.ResourceOption) (*TranscodeTemplate, error) {
	var resource TranscodeTemplate
	err := ctx.ReadResource("tencentcloud:Mps/transcodeTemplate:TranscodeTemplate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TranscodeTemplate resources.
type transcodeTemplateState struct {
	// Audio stream configuration parameters, when RemoveAudio is 0, this field is required.
	AudioTemplate *TranscodeTemplateAudioTemplate `pulumi:"audioTemplate"`
	// Template description information, length limit: 256 characters.
	Comment *string `pulumi:"comment"`
	// Encapsulation format, optional values: mp4, flv, hls, mp3, flac, ogg, m4a. Among them, mp3, flac, ogg, m4a are pure
	// audio files.
	Container *string `pulumi:"container"`
	// Audio and video enhancement configuration.
	EnhanceConfig *TranscodeTemplateEnhanceConfig `pulumi:"enhanceConfig"`
	// Transcoding template name, length limit: 64 characters.
	Name *string `pulumi:"name"`
	// Whether to remove audio data, value:0: reserved.1: remove.Default: 0.
	RemoveAudio *int `pulumi:"removeAudio"`
	// Whether to remove video data, value:0: reserved.1: remove.Default: 0.
	RemoveVideo *int `pulumi:"removeVideo"`
	// Ultra-fast HD transcoding parameters.
	TehdConfig *TranscodeTemplateTehdConfig `pulumi:"tehdConfig"`
	// Video stream configuration parameters, when RemoveVideo is 0, this field is required.
	VideoTemplate *TranscodeTemplateVideoTemplate `pulumi:"videoTemplate"`
}

type TranscodeTemplateState struct {
	// Audio stream configuration parameters, when RemoveAudio is 0, this field is required.
	AudioTemplate TranscodeTemplateAudioTemplatePtrInput
	// Template description information, length limit: 256 characters.
	Comment pulumi.StringPtrInput
	// Encapsulation format, optional values: mp4, flv, hls, mp3, flac, ogg, m4a. Among them, mp3, flac, ogg, m4a are pure
	// audio files.
	Container pulumi.StringPtrInput
	// Audio and video enhancement configuration.
	EnhanceConfig TranscodeTemplateEnhanceConfigPtrInput
	// Transcoding template name, length limit: 64 characters.
	Name pulumi.StringPtrInput
	// Whether to remove audio data, value:0: reserved.1: remove.Default: 0.
	RemoveAudio pulumi.IntPtrInput
	// Whether to remove video data, value:0: reserved.1: remove.Default: 0.
	RemoveVideo pulumi.IntPtrInput
	// Ultra-fast HD transcoding parameters.
	TehdConfig TranscodeTemplateTehdConfigPtrInput
	// Video stream configuration parameters, when RemoveVideo is 0, this field is required.
	VideoTemplate TranscodeTemplateVideoTemplatePtrInput
}

func (TranscodeTemplateState) ElementType() reflect.Type {
	return reflect.TypeOf((*transcodeTemplateState)(nil)).Elem()
}

type transcodeTemplateArgs struct {
	// Audio stream configuration parameters, when RemoveAudio is 0, this field is required.
	AudioTemplate *TranscodeTemplateAudioTemplate `pulumi:"audioTemplate"`
	// Template description information, length limit: 256 characters.
	Comment *string `pulumi:"comment"`
	// Encapsulation format, optional values: mp4, flv, hls, mp3, flac, ogg, m4a. Among them, mp3, flac, ogg, m4a are pure
	// audio files.
	Container string `pulumi:"container"`
	// Audio and video enhancement configuration.
	EnhanceConfig *TranscodeTemplateEnhanceConfig `pulumi:"enhanceConfig"`
	// Transcoding template name, length limit: 64 characters.
	Name *string `pulumi:"name"`
	// Whether to remove audio data, value:0: reserved.1: remove.Default: 0.
	RemoveAudio *int `pulumi:"removeAudio"`
	// Whether to remove video data, value:0: reserved.1: remove.Default: 0.
	RemoveVideo *int `pulumi:"removeVideo"`
	// Ultra-fast HD transcoding parameters.
	TehdConfig *TranscodeTemplateTehdConfig `pulumi:"tehdConfig"`
	// Video stream configuration parameters, when RemoveVideo is 0, this field is required.
	VideoTemplate *TranscodeTemplateVideoTemplate `pulumi:"videoTemplate"`
}

// The set of arguments for constructing a TranscodeTemplate resource.
type TranscodeTemplateArgs struct {
	// Audio stream configuration parameters, when RemoveAudio is 0, this field is required.
	AudioTemplate TranscodeTemplateAudioTemplatePtrInput
	// Template description information, length limit: 256 characters.
	Comment pulumi.StringPtrInput
	// Encapsulation format, optional values: mp4, flv, hls, mp3, flac, ogg, m4a. Among them, mp3, flac, ogg, m4a are pure
	// audio files.
	Container pulumi.StringInput
	// Audio and video enhancement configuration.
	EnhanceConfig TranscodeTemplateEnhanceConfigPtrInput
	// Transcoding template name, length limit: 64 characters.
	Name pulumi.StringPtrInput
	// Whether to remove audio data, value:0: reserved.1: remove.Default: 0.
	RemoveAudio pulumi.IntPtrInput
	// Whether to remove video data, value:0: reserved.1: remove.Default: 0.
	RemoveVideo pulumi.IntPtrInput
	// Ultra-fast HD transcoding parameters.
	TehdConfig TranscodeTemplateTehdConfigPtrInput
	// Video stream configuration parameters, when RemoveVideo is 0, this field is required.
	VideoTemplate TranscodeTemplateVideoTemplatePtrInput
}

func (TranscodeTemplateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*transcodeTemplateArgs)(nil)).Elem()
}

type TranscodeTemplateInput interface {
	pulumi.Input

	ToTranscodeTemplateOutput() TranscodeTemplateOutput
	ToTranscodeTemplateOutputWithContext(ctx context.Context) TranscodeTemplateOutput
}

func (*TranscodeTemplate) ElementType() reflect.Type {
	return reflect.TypeOf((**TranscodeTemplate)(nil)).Elem()
}

func (i *TranscodeTemplate) ToTranscodeTemplateOutput() TranscodeTemplateOutput {
	return i.ToTranscodeTemplateOutputWithContext(context.Background())
}

func (i *TranscodeTemplate) ToTranscodeTemplateOutputWithContext(ctx context.Context) TranscodeTemplateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TranscodeTemplateOutput)
}

// TranscodeTemplateArrayInput is an input type that accepts TranscodeTemplateArray and TranscodeTemplateArrayOutput values.
// You can construct a concrete instance of `TranscodeTemplateArrayInput` via:
//
//	TranscodeTemplateArray{ TranscodeTemplateArgs{...} }
type TranscodeTemplateArrayInput interface {
	pulumi.Input

	ToTranscodeTemplateArrayOutput() TranscodeTemplateArrayOutput
	ToTranscodeTemplateArrayOutputWithContext(context.Context) TranscodeTemplateArrayOutput
}

type TranscodeTemplateArray []TranscodeTemplateInput

func (TranscodeTemplateArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TranscodeTemplate)(nil)).Elem()
}

func (i TranscodeTemplateArray) ToTranscodeTemplateArrayOutput() TranscodeTemplateArrayOutput {
	return i.ToTranscodeTemplateArrayOutputWithContext(context.Background())
}

func (i TranscodeTemplateArray) ToTranscodeTemplateArrayOutputWithContext(ctx context.Context) TranscodeTemplateArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TranscodeTemplateArrayOutput)
}

// TranscodeTemplateMapInput is an input type that accepts TranscodeTemplateMap and TranscodeTemplateMapOutput values.
// You can construct a concrete instance of `TranscodeTemplateMapInput` via:
//
//	TranscodeTemplateMap{ "key": TranscodeTemplateArgs{...} }
type TranscodeTemplateMapInput interface {
	pulumi.Input

	ToTranscodeTemplateMapOutput() TranscodeTemplateMapOutput
	ToTranscodeTemplateMapOutputWithContext(context.Context) TranscodeTemplateMapOutput
}

type TranscodeTemplateMap map[string]TranscodeTemplateInput

func (TranscodeTemplateMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TranscodeTemplate)(nil)).Elem()
}

func (i TranscodeTemplateMap) ToTranscodeTemplateMapOutput() TranscodeTemplateMapOutput {
	return i.ToTranscodeTemplateMapOutputWithContext(context.Background())
}

func (i TranscodeTemplateMap) ToTranscodeTemplateMapOutputWithContext(ctx context.Context) TranscodeTemplateMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TranscodeTemplateMapOutput)
}

type TranscodeTemplateOutput struct{ *pulumi.OutputState }

func (TranscodeTemplateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TranscodeTemplate)(nil)).Elem()
}

func (o TranscodeTemplateOutput) ToTranscodeTemplateOutput() TranscodeTemplateOutput {
	return o
}

func (o TranscodeTemplateOutput) ToTranscodeTemplateOutputWithContext(ctx context.Context) TranscodeTemplateOutput {
	return o
}

// Audio stream configuration parameters, when RemoveAudio is 0, this field is required.
func (o TranscodeTemplateOutput) AudioTemplate() TranscodeTemplateAudioTemplatePtrOutput {
	return o.ApplyT(func(v *TranscodeTemplate) TranscodeTemplateAudioTemplatePtrOutput { return v.AudioTemplate }).(TranscodeTemplateAudioTemplatePtrOutput)
}

// Template description information, length limit: 256 characters.
func (o TranscodeTemplateOutput) Comment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TranscodeTemplate) pulumi.StringPtrOutput { return v.Comment }).(pulumi.StringPtrOutput)
}

// Encapsulation format, optional values: mp4, flv, hls, mp3, flac, ogg, m4a. Among them, mp3, flac, ogg, m4a are pure
// audio files.
func (o TranscodeTemplateOutput) Container() pulumi.StringOutput {
	return o.ApplyT(func(v *TranscodeTemplate) pulumi.StringOutput { return v.Container }).(pulumi.StringOutput)
}

// Audio and video enhancement configuration.
func (o TranscodeTemplateOutput) EnhanceConfig() TranscodeTemplateEnhanceConfigPtrOutput {
	return o.ApplyT(func(v *TranscodeTemplate) TranscodeTemplateEnhanceConfigPtrOutput { return v.EnhanceConfig }).(TranscodeTemplateEnhanceConfigPtrOutput)
}

// Transcoding template name, length limit: 64 characters.
func (o TranscodeTemplateOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *TranscodeTemplate) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Whether to remove audio data, value:0: reserved.1: remove.Default: 0.
func (o TranscodeTemplateOutput) RemoveAudio() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *TranscodeTemplate) pulumi.IntPtrOutput { return v.RemoveAudio }).(pulumi.IntPtrOutput)
}

// Whether to remove video data, value:0: reserved.1: remove.Default: 0.
func (o TranscodeTemplateOutput) RemoveVideo() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *TranscodeTemplate) pulumi.IntPtrOutput { return v.RemoveVideo }).(pulumi.IntPtrOutput)
}

// Ultra-fast HD transcoding parameters.
func (o TranscodeTemplateOutput) TehdConfig() TranscodeTemplateTehdConfigPtrOutput {
	return o.ApplyT(func(v *TranscodeTemplate) TranscodeTemplateTehdConfigPtrOutput { return v.TehdConfig }).(TranscodeTemplateTehdConfigPtrOutput)
}

// Video stream configuration parameters, when RemoveVideo is 0, this field is required.
func (o TranscodeTemplateOutput) VideoTemplate() TranscodeTemplateVideoTemplatePtrOutput {
	return o.ApplyT(func(v *TranscodeTemplate) TranscodeTemplateVideoTemplatePtrOutput { return v.VideoTemplate }).(TranscodeTemplateVideoTemplatePtrOutput)
}

type TranscodeTemplateArrayOutput struct{ *pulumi.OutputState }

func (TranscodeTemplateArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TranscodeTemplate)(nil)).Elem()
}

func (o TranscodeTemplateArrayOutput) ToTranscodeTemplateArrayOutput() TranscodeTemplateArrayOutput {
	return o
}

func (o TranscodeTemplateArrayOutput) ToTranscodeTemplateArrayOutputWithContext(ctx context.Context) TranscodeTemplateArrayOutput {
	return o
}

func (o TranscodeTemplateArrayOutput) Index(i pulumi.IntInput) TranscodeTemplateOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *TranscodeTemplate {
		return vs[0].([]*TranscodeTemplate)[vs[1].(int)]
	}).(TranscodeTemplateOutput)
}

type TranscodeTemplateMapOutput struct{ *pulumi.OutputState }

func (TranscodeTemplateMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TranscodeTemplate)(nil)).Elem()
}

func (o TranscodeTemplateMapOutput) ToTranscodeTemplateMapOutput() TranscodeTemplateMapOutput {
	return o
}

func (o TranscodeTemplateMapOutput) ToTranscodeTemplateMapOutputWithContext(ctx context.Context) TranscodeTemplateMapOutput {
	return o
}

func (o TranscodeTemplateMapOutput) MapIndex(k pulumi.StringInput) TranscodeTemplateOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *TranscodeTemplate {
		return vs[0].(map[string]*TranscodeTemplate)[vs[1].(string)]
	}).(TranscodeTemplateOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TranscodeTemplateInput)(nil)).Elem(), &TranscodeTemplate{})
	pulumi.RegisterInputType(reflect.TypeOf((*TranscodeTemplateArrayInput)(nil)).Elem(), TranscodeTemplateArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TranscodeTemplateMapInput)(nil)).Elem(), TranscodeTemplateMap{})
	pulumi.RegisterOutputType(TranscodeTemplateOutput{})
	pulumi.RegisterOutputType(TranscodeTemplateArrayOutput{})
	pulumi.RegisterOutputType(TranscodeTemplateMapOutput{})
}