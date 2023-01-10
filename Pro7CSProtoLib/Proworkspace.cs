// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proworkspace.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Rv.Data {

  /// <summary>Holder for reflection information generated from proworkspace.proto</summary>
  public static partial class ProworkspaceReflection {

    #region Descriptor
    /// <summary>File descriptor for proworkspace.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProworkspaceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJwcm93b3Jrc3BhY2UucHJvdG8SB3J2LmRhdGEaD3Byb3NjcmVlbi5wcm90",
            "bxoVcHJvQXVkaWVuY2VMb29rLnByb3RvGg1wcm9NYXNrLnByb3RvGgtpbnB1",
            "dC5wcm90bxoLYXVkaW8ucHJvdG8aEmRpZ2l0YWxBdWRpby5wcm90bxoLc3Rh",
            "Z2UucHJvdG8aD3JlY29yZGluZy5wcm90byLcBAoVUHJvUHJlc2VudGVyV29y",
            "a3NwYWNlEjAKC3Byb19zY3JlZW5zGAEgAygLMhsucnYuZGF0YS5Qcm9QcmVz",
            "ZW50ZXJTY3JlZW4SMAoOYXVkaWVuY2VfbG9va3MYAiADKAsyGC5ydi5kYXRh",
            "LlByb0F1ZGllbmNlTG9vaxI0ChJsaXZlX2F1ZGllbmNlX2xvb2sYAyABKAsy",
            "GC5ydi5kYXRhLlByb0F1ZGllbmNlTG9vaxIfCgVtYXNrcxgEIAMoCzIQLnJ2",
            "LmRhdGEuUHJvTWFzaxIoCgt2aWRlb0lucHV0cxgFIAMoCzITLnJ2LmRhdGEu",
            "VmlkZW9JbnB1dBI+ChVzdGFnZV9sYXlvdXRfbWFwcGluZ3MYBiADKAsyHy5y",
            "di5kYXRhLlN0YWdlLlNjcmVlbkFzc2lnbm1lbnQSNwoOYXVkaW9fc2V0dGlu",
            "Z3MYByABKAsyHy5ydi5kYXRhLkF1ZGlvLlNldHRpbmdzRG9jdW1lbnQSHQoV",
            "c2VsZWN0ZWRfbGlicmFyeV9uYW1lGAggASgJEjwKD3JlY29yZF9zZXR0aW5n",
            "cxgJIAEoCzIjLnJ2LmRhdGEuUmVjb3JkaW5nLlNldHRpbmdzRG9jdW1lbnQS",
            "OAoTZGlnaXRhbF9hdWRpb19zZXR1cBgKIAEoCzIbLnJ2LmRhdGEuRGlnaXRh",
            "bEF1ZGlvLlNldHVwEikKDGF1ZGlvX2lucHV0cxgLIAMoCzITLnJ2LmRhdGEu",
            "QXVkaW9JbnB1dBIjChthdWRpb19pbnB1dF90cmFuc2l0aW9uX3RpbWUYDCAB",
            "KAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Rv.Data.ProscreenReflection.Descriptor, global::Rv.Data.ProAudienceLookReflection.Descriptor, global::Rv.Data.ProMaskReflection.Descriptor, global::Rv.Data.InputReflection.Descriptor, global::Rv.Data.AudioReflection.Descriptor, global::Rv.Data.DigitalAudioReflection.Descriptor, global::Rv.Data.StageReflection.Descriptor, global::Rv.Data.RecordingReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.ProPresenterWorkspace), global::Rv.Data.ProPresenterWorkspace.Parser, new[]{ "ProScreens", "AudienceLooks", "LiveAudienceLook", "Masks", "VideoInputs", "StageLayoutMappings", "AudioSettings", "SelectedLibraryName", "RecordSettings", "DigitalAudioSetup", "AudioInputs", "AudioInputTransitionTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProPresenterWorkspace : pb::IMessage<ProPresenterWorkspace>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProPresenterWorkspace> _parser = new pb::MessageParser<ProPresenterWorkspace>(() => new ProPresenterWorkspace());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProPresenterWorkspace> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rv.Data.ProworkspaceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProPresenterWorkspace() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProPresenterWorkspace(ProPresenterWorkspace other) : this() {
      proScreens_ = other.proScreens_.Clone();
      audienceLooks_ = other.audienceLooks_.Clone();
      liveAudienceLook_ = other.liveAudienceLook_ != null ? other.liveAudienceLook_.Clone() : null;
      masks_ = other.masks_.Clone();
      videoInputs_ = other.videoInputs_.Clone();
      stageLayoutMappings_ = other.stageLayoutMappings_.Clone();
      audioSettings_ = other.audioSettings_ != null ? other.audioSettings_.Clone() : null;
      selectedLibraryName_ = other.selectedLibraryName_;
      recordSettings_ = other.recordSettings_ != null ? other.recordSettings_.Clone() : null;
      digitalAudioSetup_ = other.digitalAudioSetup_ != null ? other.digitalAudioSetup_.Clone() : null;
      audioInputs_ = other.audioInputs_.Clone();
      audioInputTransitionTime_ = other.audioInputTransitionTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProPresenterWorkspace Clone() {
      return new ProPresenterWorkspace(this);
    }

    /// <summary>Field number for the "pro_screens" field.</summary>
    public const int ProScreensFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Rv.Data.ProPresenterScreen> _repeated_proScreens_codec
        = pb::FieldCodec.ForMessage(10, global::Rv.Data.ProPresenterScreen.Parser);
    private readonly pbc::RepeatedField<global::Rv.Data.ProPresenterScreen> proScreens_ = new pbc::RepeatedField<global::Rv.Data.ProPresenterScreen>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Rv.Data.ProPresenterScreen> ProScreens {
      get { return proScreens_; }
    }

    /// <summary>Field number for the "audience_looks" field.</summary>
    public const int AudienceLooksFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Rv.Data.ProAudienceLook> _repeated_audienceLooks_codec
        = pb::FieldCodec.ForMessage(18, global::Rv.Data.ProAudienceLook.Parser);
    private readonly pbc::RepeatedField<global::Rv.Data.ProAudienceLook> audienceLooks_ = new pbc::RepeatedField<global::Rv.Data.ProAudienceLook>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Rv.Data.ProAudienceLook> AudienceLooks {
      get { return audienceLooks_; }
    }

    /// <summary>Field number for the "live_audience_look" field.</summary>
    public const int LiveAudienceLookFieldNumber = 3;
    private global::Rv.Data.ProAudienceLook liveAudienceLook_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Rv.Data.ProAudienceLook LiveAudienceLook {
      get { return liveAudienceLook_; }
      set {
        liveAudienceLook_ = value;
      }
    }

    /// <summary>Field number for the "masks" field.</summary>
    public const int MasksFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Rv.Data.ProMask> _repeated_masks_codec
        = pb::FieldCodec.ForMessage(34, global::Rv.Data.ProMask.Parser);
    private readonly pbc::RepeatedField<global::Rv.Data.ProMask> masks_ = new pbc::RepeatedField<global::Rv.Data.ProMask>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Rv.Data.ProMask> Masks {
      get { return masks_; }
    }

    /// <summary>Field number for the "videoInputs" field.</summary>
    public const int VideoInputsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Rv.Data.VideoInput> _repeated_videoInputs_codec
        = pb::FieldCodec.ForMessage(42, global::Rv.Data.VideoInput.Parser);
    private readonly pbc::RepeatedField<global::Rv.Data.VideoInput> videoInputs_ = new pbc::RepeatedField<global::Rv.Data.VideoInput>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Rv.Data.VideoInput> VideoInputs {
      get { return videoInputs_; }
    }

    /// <summary>Field number for the "stage_layout_mappings" field.</summary>
    public const int StageLayoutMappingsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Rv.Data.Stage.Types.ScreenAssignment> _repeated_stageLayoutMappings_codec
        = pb::FieldCodec.ForMessage(50, global::Rv.Data.Stage.Types.ScreenAssignment.Parser);
    private readonly pbc::RepeatedField<global::Rv.Data.Stage.Types.ScreenAssignment> stageLayoutMappings_ = new pbc::RepeatedField<global::Rv.Data.Stage.Types.ScreenAssignment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Rv.Data.Stage.Types.ScreenAssignment> StageLayoutMappings {
      get { return stageLayoutMappings_; }
    }

    /// <summary>Field number for the "audio_settings" field.</summary>
    public const int AudioSettingsFieldNumber = 7;
    private global::Rv.Data.Audio.Types.SettingsDocument audioSettings_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Rv.Data.Audio.Types.SettingsDocument AudioSettings {
      get { return audioSettings_; }
      set {
        audioSettings_ = value;
      }
    }

    /// <summary>Field number for the "selected_library_name" field.</summary>
    public const int SelectedLibraryNameFieldNumber = 8;
    private string selectedLibraryName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SelectedLibraryName {
      get { return selectedLibraryName_; }
      set {
        selectedLibraryName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "record_settings" field.</summary>
    public const int RecordSettingsFieldNumber = 9;
    private global::Rv.Data.Recording.Types.SettingsDocument recordSettings_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Rv.Data.Recording.Types.SettingsDocument RecordSettings {
      get { return recordSettings_; }
      set {
        recordSettings_ = value;
      }
    }

    /// <summary>Field number for the "digital_audio_setup" field.</summary>
    public const int DigitalAudioSetupFieldNumber = 10;
    private global::Rv.Data.DigitalAudio.Types.Setup digitalAudioSetup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Rv.Data.DigitalAudio.Types.Setup DigitalAudioSetup {
      get { return digitalAudioSetup_; }
      set {
        digitalAudioSetup_ = value;
      }
    }

    /// <summary>Field number for the "audio_inputs" field.</summary>
    public const int AudioInputsFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Rv.Data.AudioInput> _repeated_audioInputs_codec
        = pb::FieldCodec.ForMessage(90, global::Rv.Data.AudioInput.Parser);
    private readonly pbc::RepeatedField<global::Rv.Data.AudioInput> audioInputs_ = new pbc::RepeatedField<global::Rv.Data.AudioInput>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Rv.Data.AudioInput> AudioInputs {
      get { return audioInputs_; }
    }

    /// <summary>Field number for the "audio_input_transition_time" field.</summary>
    public const int AudioInputTransitionTimeFieldNumber = 12;
    private double audioInputTransitionTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double AudioInputTransitionTime {
      get { return audioInputTransitionTime_; }
      set {
        audioInputTransitionTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProPresenterWorkspace);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProPresenterWorkspace other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!proScreens_.Equals(other.proScreens_)) return false;
      if(!audienceLooks_.Equals(other.audienceLooks_)) return false;
      if (!object.Equals(LiveAudienceLook, other.LiveAudienceLook)) return false;
      if(!masks_.Equals(other.masks_)) return false;
      if(!videoInputs_.Equals(other.videoInputs_)) return false;
      if(!stageLayoutMappings_.Equals(other.stageLayoutMappings_)) return false;
      if (!object.Equals(AudioSettings, other.AudioSettings)) return false;
      if (SelectedLibraryName != other.SelectedLibraryName) return false;
      if (!object.Equals(RecordSettings, other.RecordSettings)) return false;
      if (!object.Equals(DigitalAudioSetup, other.DigitalAudioSetup)) return false;
      if(!audioInputs_.Equals(other.audioInputs_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AudioInputTransitionTime, other.AudioInputTransitionTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= proScreens_.GetHashCode();
      hash ^= audienceLooks_.GetHashCode();
      if (liveAudienceLook_ != null) hash ^= LiveAudienceLook.GetHashCode();
      hash ^= masks_.GetHashCode();
      hash ^= videoInputs_.GetHashCode();
      hash ^= stageLayoutMappings_.GetHashCode();
      if (audioSettings_ != null) hash ^= AudioSettings.GetHashCode();
      if (SelectedLibraryName.Length != 0) hash ^= SelectedLibraryName.GetHashCode();
      if (recordSettings_ != null) hash ^= RecordSettings.GetHashCode();
      if (digitalAudioSetup_ != null) hash ^= DigitalAudioSetup.GetHashCode();
      hash ^= audioInputs_.GetHashCode();
      if (AudioInputTransitionTime != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AudioInputTransitionTime);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      proScreens_.WriteTo(output, _repeated_proScreens_codec);
      audienceLooks_.WriteTo(output, _repeated_audienceLooks_codec);
      if (liveAudienceLook_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(LiveAudienceLook);
      }
      masks_.WriteTo(output, _repeated_masks_codec);
      videoInputs_.WriteTo(output, _repeated_videoInputs_codec);
      stageLayoutMappings_.WriteTo(output, _repeated_stageLayoutMappings_codec);
      if (audioSettings_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AudioSettings);
      }
      if (SelectedLibraryName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(SelectedLibraryName);
      }
      if (recordSettings_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RecordSettings);
      }
      if (digitalAudioSetup_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(DigitalAudioSetup);
      }
      audioInputs_.WriteTo(output, _repeated_audioInputs_codec);
      if (AudioInputTransitionTime != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(AudioInputTransitionTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      proScreens_.WriteTo(ref output, _repeated_proScreens_codec);
      audienceLooks_.WriteTo(ref output, _repeated_audienceLooks_codec);
      if (liveAudienceLook_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(LiveAudienceLook);
      }
      masks_.WriteTo(ref output, _repeated_masks_codec);
      videoInputs_.WriteTo(ref output, _repeated_videoInputs_codec);
      stageLayoutMappings_.WriteTo(ref output, _repeated_stageLayoutMappings_codec);
      if (audioSettings_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AudioSettings);
      }
      if (SelectedLibraryName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(SelectedLibraryName);
      }
      if (recordSettings_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RecordSettings);
      }
      if (digitalAudioSetup_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(DigitalAudioSetup);
      }
      audioInputs_.WriteTo(ref output, _repeated_audioInputs_codec);
      if (AudioInputTransitionTime != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(AudioInputTransitionTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += proScreens_.CalculateSize(_repeated_proScreens_codec);
      size += audienceLooks_.CalculateSize(_repeated_audienceLooks_codec);
      if (liveAudienceLook_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LiveAudienceLook);
      }
      size += masks_.CalculateSize(_repeated_masks_codec);
      size += videoInputs_.CalculateSize(_repeated_videoInputs_codec);
      size += stageLayoutMappings_.CalculateSize(_repeated_stageLayoutMappings_codec);
      if (audioSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AudioSettings);
      }
      if (SelectedLibraryName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SelectedLibraryName);
      }
      if (recordSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RecordSettings);
      }
      if (digitalAudioSetup_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DigitalAudioSetup);
      }
      size += audioInputs_.CalculateSize(_repeated_audioInputs_codec);
      if (AudioInputTransitionTime != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProPresenterWorkspace other) {
      if (other == null) {
        return;
      }
      proScreens_.Add(other.proScreens_);
      audienceLooks_.Add(other.audienceLooks_);
      if (other.liveAudienceLook_ != null) {
        if (liveAudienceLook_ == null) {
          LiveAudienceLook = new global::Rv.Data.ProAudienceLook();
        }
        LiveAudienceLook.MergeFrom(other.LiveAudienceLook);
      }
      masks_.Add(other.masks_);
      videoInputs_.Add(other.videoInputs_);
      stageLayoutMappings_.Add(other.stageLayoutMappings_);
      if (other.audioSettings_ != null) {
        if (audioSettings_ == null) {
          AudioSettings = new global::Rv.Data.Audio.Types.SettingsDocument();
        }
        AudioSettings.MergeFrom(other.AudioSettings);
      }
      if (other.SelectedLibraryName.Length != 0) {
        SelectedLibraryName = other.SelectedLibraryName;
      }
      if (other.recordSettings_ != null) {
        if (recordSettings_ == null) {
          RecordSettings = new global::Rv.Data.Recording.Types.SettingsDocument();
        }
        RecordSettings.MergeFrom(other.RecordSettings);
      }
      if (other.digitalAudioSetup_ != null) {
        if (digitalAudioSetup_ == null) {
          DigitalAudioSetup = new global::Rv.Data.DigitalAudio.Types.Setup();
        }
        DigitalAudioSetup.MergeFrom(other.DigitalAudioSetup);
      }
      audioInputs_.Add(other.audioInputs_);
      if (other.AudioInputTransitionTime != 0D) {
        AudioInputTransitionTime = other.AudioInputTransitionTime;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            proScreens_.AddEntriesFrom(input, _repeated_proScreens_codec);
            break;
          }
          case 18: {
            audienceLooks_.AddEntriesFrom(input, _repeated_audienceLooks_codec);
            break;
          }
          case 26: {
            if (liveAudienceLook_ == null) {
              LiveAudienceLook = new global::Rv.Data.ProAudienceLook();
            }
            input.ReadMessage(LiveAudienceLook);
            break;
          }
          case 34: {
            masks_.AddEntriesFrom(input, _repeated_masks_codec);
            break;
          }
          case 42: {
            videoInputs_.AddEntriesFrom(input, _repeated_videoInputs_codec);
            break;
          }
          case 50: {
            stageLayoutMappings_.AddEntriesFrom(input, _repeated_stageLayoutMappings_codec);
            break;
          }
          case 58: {
            if (audioSettings_ == null) {
              AudioSettings = new global::Rv.Data.Audio.Types.SettingsDocument();
            }
            input.ReadMessage(AudioSettings);
            break;
          }
          case 66: {
            SelectedLibraryName = input.ReadString();
            break;
          }
          case 74: {
            if (recordSettings_ == null) {
              RecordSettings = new global::Rv.Data.Recording.Types.SettingsDocument();
            }
            input.ReadMessage(RecordSettings);
            break;
          }
          case 82: {
            if (digitalAudioSetup_ == null) {
              DigitalAudioSetup = new global::Rv.Data.DigitalAudio.Types.Setup();
            }
            input.ReadMessage(DigitalAudioSetup);
            break;
          }
          case 90: {
            audioInputs_.AddEntriesFrom(input, _repeated_audioInputs_codec);
            break;
          }
          case 97: {
            AudioInputTransitionTime = input.ReadDouble();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            proScreens_.AddEntriesFrom(ref input, _repeated_proScreens_codec);
            break;
          }
          case 18: {
            audienceLooks_.AddEntriesFrom(ref input, _repeated_audienceLooks_codec);
            break;
          }
          case 26: {
            if (liveAudienceLook_ == null) {
              LiveAudienceLook = new global::Rv.Data.ProAudienceLook();
            }
            input.ReadMessage(LiveAudienceLook);
            break;
          }
          case 34: {
            masks_.AddEntriesFrom(ref input, _repeated_masks_codec);
            break;
          }
          case 42: {
            videoInputs_.AddEntriesFrom(ref input, _repeated_videoInputs_codec);
            break;
          }
          case 50: {
            stageLayoutMappings_.AddEntriesFrom(ref input, _repeated_stageLayoutMappings_codec);
            break;
          }
          case 58: {
            if (audioSettings_ == null) {
              AudioSettings = new global::Rv.Data.Audio.Types.SettingsDocument();
            }
            input.ReadMessage(AudioSettings);
            break;
          }
          case 66: {
            SelectedLibraryName = input.ReadString();
            break;
          }
          case 74: {
            if (recordSettings_ == null) {
              RecordSettings = new global::Rv.Data.Recording.Types.SettingsDocument();
            }
            input.ReadMessage(RecordSettings);
            break;
          }
          case 82: {
            if (digitalAudioSetup_ == null) {
              DigitalAudioSetup = new global::Rv.Data.DigitalAudio.Types.Setup();
            }
            input.ReadMessage(DigitalAudioSetup);
            break;
          }
          case 90: {
            audioInputs_.AddEntriesFrom(ref input, _repeated_audioInputs_codec);
            break;
          }
          case 97: {
            AudioInputTransitionTime = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
