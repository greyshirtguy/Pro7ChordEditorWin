// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proAudienceLook.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Rv.Data {

  /// <summary>Holder for reflection information generated from proAudienceLook.proto</summary>
  public static partial class ProAudienceLookReflection {

    #region Descriptor
    /// <summary>File descriptor for proAudienceLook.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProAudienceLookReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVwcm9BdWRpZW5jZUxvb2sucHJvdG8SB3J2LmRhdGEaEGJhc2ljVHlwZXMu",
            "cHJvdG8iwQQKD1Byb0F1ZGllbmNlTG9vaxIbCgR1dWlkGAEgASgLMg0ucnYu",
            "ZGF0YS5VVUlEEgwKBG5hbWUYAiABKAkSPAoMc2NyZWVuX2xvb2tzGAMgAygL",
            "MiYucnYuZGF0YS5Qcm9BdWRpZW5jZUxvb2suUHJvU2NyZWVuTG9vaxIpChJv",
            "cmlnaW5hbF9sb29rX3V1aWQYBCABKAsyDS5ydi5kYXRhLlVVSUQamQMKDVBy",
            "b1NjcmVlbkxvb2sSJgoPcHJvX3NjcmVlbl91dWlkGAEgASgLMg0ucnYuZGF0",
            "YS5VVUlEEhUKDXByb3BzX2VuYWJsZWQYAiABKAgSGgoSbGl2ZV92aWRlb19l",
            "bmFibGVkGAMgASgIEicKH3ByZXNlbnRhdGlvbl9iYWNrZ3JvdW5kX2VuYWJs",
            "ZWQYBCABKAgSMQobdGVtcGxhdGVfZG9jdW1lbnRfZmlsZV9wYXRoGAUgASgL",
            "MgwucnYuZGF0YS5VUkwSKgoTdGVtcGxhdGVfc2xpZGVfdXVpZBgGIAEoCzIN",
            "LnJ2LmRhdGEuVVVJRBInCh9wcmVzZW50YXRpb25fZm9yZWdyb3VuZF9lbmFi",
            "bGVkGAcgASgIEiAKCW1hc2tfdXVpZBgIIAEoCzINLnJ2LmRhdGEuVVVJRBId",
            "ChVhbm5vdW5jZW1lbnRzX2VuYWJsZWQYCSABKAgSGwoTcHJvcHNfbGF5ZXJf",
            "ZW5hYmxlZBgKIAEoCBIeChZtZXNzYWdlc19sYXllcl9lbmFibGVkGAsgASgI",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Rv.Data.BasicTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.ProAudienceLook), global::Rv.Data.ProAudienceLook.Parser, new[]{ "Uuid", "Name", "ScreenLooks", "OriginalLookUuid" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.ProAudienceLook.Types.ProScreenLook), global::Rv.Data.ProAudienceLook.Types.ProScreenLook.Parser, new[]{ "ProScreenUuid", "PropsEnabled", "LiveVideoEnabled", "PresentationBackgroundEnabled", "TemplateDocumentFilePath", "TemplateSlideUuid", "PresentationForegroundEnabled", "MaskUuid", "AnnouncementsEnabled", "PropsLayerEnabled", "MessagesLayerEnabled" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProAudienceLook : pb::IMessage<ProAudienceLook>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProAudienceLook> _parser = new pb::MessageParser<ProAudienceLook>(() => new ProAudienceLook());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProAudienceLook> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rv.Data.ProAudienceLookReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProAudienceLook() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProAudienceLook(ProAudienceLook other) : this() {
      uuid_ = other.uuid_ != null ? other.uuid_.Clone() : null;
      name_ = other.name_;
      screenLooks_ = other.screenLooks_.Clone();
      originalLookUuid_ = other.originalLookUuid_ != null ? other.originalLookUuid_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProAudienceLook Clone() {
      return new ProAudienceLook(this);
    }

    /// <summary>Field number for the "uuid" field.</summary>
    public const int UuidFieldNumber = 1;
    private global::Rv.Data.UUID uuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Rv.Data.UUID Uuid {
      get { return uuid_; }
      set {
        uuid_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "screen_looks" field.</summary>
    public const int ScreenLooksFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Rv.Data.ProAudienceLook.Types.ProScreenLook> _repeated_screenLooks_codec
        = pb::FieldCodec.ForMessage(26, global::Rv.Data.ProAudienceLook.Types.ProScreenLook.Parser);
    private readonly pbc::RepeatedField<global::Rv.Data.ProAudienceLook.Types.ProScreenLook> screenLooks_ = new pbc::RepeatedField<global::Rv.Data.ProAudienceLook.Types.ProScreenLook>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Rv.Data.ProAudienceLook.Types.ProScreenLook> ScreenLooks {
      get { return screenLooks_; }
    }

    /// <summary>Field number for the "original_look_uuid" field.</summary>
    public const int OriginalLookUuidFieldNumber = 4;
    private global::Rv.Data.UUID originalLookUuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Rv.Data.UUID OriginalLookUuid {
      get { return originalLookUuid_; }
      set {
        originalLookUuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProAudienceLook);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProAudienceLook other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Uuid, other.Uuid)) return false;
      if (Name != other.Name) return false;
      if(!screenLooks_.Equals(other.screenLooks_)) return false;
      if (!object.Equals(OriginalLookUuid, other.OriginalLookUuid)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (uuid_ != null) hash ^= Uuid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= screenLooks_.GetHashCode();
      if (originalLookUuid_ != null) hash ^= OriginalLookUuid.GetHashCode();
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
      if (uuid_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Uuid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      screenLooks_.WriteTo(output, _repeated_screenLooks_codec);
      if (originalLookUuid_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(OriginalLookUuid);
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
      if (uuid_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Uuid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      screenLooks_.WriteTo(ref output, _repeated_screenLooks_codec);
      if (originalLookUuid_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(OriginalLookUuid);
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
      if (uuid_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Uuid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += screenLooks_.CalculateSize(_repeated_screenLooks_codec);
      if (originalLookUuid_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OriginalLookUuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProAudienceLook other) {
      if (other == null) {
        return;
      }
      if (other.uuid_ != null) {
        if (uuid_ == null) {
          Uuid = new global::Rv.Data.UUID();
        }
        Uuid.MergeFrom(other.Uuid);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      screenLooks_.Add(other.screenLooks_);
      if (other.originalLookUuid_ != null) {
        if (originalLookUuid_ == null) {
          OriginalLookUuid = new global::Rv.Data.UUID();
        }
        OriginalLookUuid.MergeFrom(other.OriginalLookUuid);
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
            if (uuid_ == null) {
              Uuid = new global::Rv.Data.UUID();
            }
            input.ReadMessage(Uuid);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            screenLooks_.AddEntriesFrom(input, _repeated_screenLooks_codec);
            break;
          }
          case 34: {
            if (originalLookUuid_ == null) {
              OriginalLookUuid = new global::Rv.Data.UUID();
            }
            input.ReadMessage(OriginalLookUuid);
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
            if (uuid_ == null) {
              Uuid = new global::Rv.Data.UUID();
            }
            input.ReadMessage(Uuid);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            screenLooks_.AddEntriesFrom(ref input, _repeated_screenLooks_codec);
            break;
          }
          case 34: {
            if (originalLookUuid_ == null) {
              OriginalLookUuid = new global::Rv.Data.UUID();
            }
            input.ReadMessage(OriginalLookUuid);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ProAudienceLook message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class ProScreenLook : pb::IMessage<ProScreenLook>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<ProScreenLook> _parser = new pb::MessageParser<ProScreenLook>(() => new ProScreenLook());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<ProScreenLook> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Rv.Data.ProAudienceLook.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ProScreenLook() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ProScreenLook(ProScreenLook other) : this() {
          proScreenUuid_ = other.proScreenUuid_ != null ? other.proScreenUuid_.Clone() : null;
          propsEnabled_ = other.propsEnabled_;
          liveVideoEnabled_ = other.liveVideoEnabled_;
          presentationBackgroundEnabled_ = other.presentationBackgroundEnabled_;
          templateDocumentFilePath_ = other.templateDocumentFilePath_ != null ? other.templateDocumentFilePath_.Clone() : null;
          templateSlideUuid_ = other.templateSlideUuid_ != null ? other.templateSlideUuid_.Clone() : null;
          presentationForegroundEnabled_ = other.presentationForegroundEnabled_;
          maskUuid_ = other.maskUuid_ != null ? other.maskUuid_.Clone() : null;
          announcementsEnabled_ = other.announcementsEnabled_;
          propsLayerEnabled_ = other.propsLayerEnabled_;
          messagesLayerEnabled_ = other.messagesLayerEnabled_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ProScreenLook Clone() {
          return new ProScreenLook(this);
        }

        /// <summary>Field number for the "pro_screen_uuid" field.</summary>
        public const int ProScreenUuidFieldNumber = 1;
        private global::Rv.Data.UUID proScreenUuid_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Rv.Data.UUID ProScreenUuid {
          get { return proScreenUuid_; }
          set {
            proScreenUuid_ = value;
          }
        }

        /// <summary>Field number for the "props_enabled" field.</summary>
        public const int PropsEnabledFieldNumber = 2;
        private bool propsEnabled_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool PropsEnabled {
          get { return propsEnabled_; }
          set {
            propsEnabled_ = value;
          }
        }

        /// <summary>Field number for the "live_video_enabled" field.</summary>
        public const int LiveVideoEnabledFieldNumber = 3;
        private bool liveVideoEnabled_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool LiveVideoEnabled {
          get { return liveVideoEnabled_; }
          set {
            liveVideoEnabled_ = value;
          }
        }

        /// <summary>Field number for the "presentation_background_enabled" field.</summary>
        public const int PresentationBackgroundEnabledFieldNumber = 4;
        private bool presentationBackgroundEnabled_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool PresentationBackgroundEnabled {
          get { return presentationBackgroundEnabled_; }
          set {
            presentationBackgroundEnabled_ = value;
          }
        }

        /// <summary>Field number for the "template_document_file_path" field.</summary>
        public const int TemplateDocumentFilePathFieldNumber = 5;
        private global::Rv.Data.URL templateDocumentFilePath_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Rv.Data.URL TemplateDocumentFilePath {
          get { return templateDocumentFilePath_; }
          set {
            templateDocumentFilePath_ = value;
          }
        }

        /// <summary>Field number for the "template_slide_uuid" field.</summary>
        public const int TemplateSlideUuidFieldNumber = 6;
        private global::Rv.Data.UUID templateSlideUuid_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Rv.Data.UUID TemplateSlideUuid {
          get { return templateSlideUuid_; }
          set {
            templateSlideUuid_ = value;
          }
        }

        /// <summary>Field number for the "presentation_foreground_enabled" field.</summary>
        public const int PresentationForegroundEnabledFieldNumber = 7;
        private bool presentationForegroundEnabled_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool PresentationForegroundEnabled {
          get { return presentationForegroundEnabled_; }
          set {
            presentationForegroundEnabled_ = value;
          }
        }

        /// <summary>Field number for the "mask_uuid" field.</summary>
        public const int MaskUuidFieldNumber = 8;
        private global::Rv.Data.UUID maskUuid_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Rv.Data.UUID MaskUuid {
          get { return maskUuid_; }
          set {
            maskUuid_ = value;
          }
        }

        /// <summary>Field number for the "announcements_enabled" field.</summary>
        public const int AnnouncementsEnabledFieldNumber = 9;
        private bool announcementsEnabled_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool AnnouncementsEnabled {
          get { return announcementsEnabled_; }
          set {
            announcementsEnabled_ = value;
          }
        }

        /// <summary>Field number for the "props_layer_enabled" field.</summary>
        public const int PropsLayerEnabledFieldNumber = 10;
        private bool propsLayerEnabled_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool PropsLayerEnabled {
          get { return propsLayerEnabled_; }
          set {
            propsLayerEnabled_ = value;
          }
        }

        /// <summary>Field number for the "messages_layer_enabled" field.</summary>
        public const int MessagesLayerEnabledFieldNumber = 11;
        private bool messagesLayerEnabled_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool MessagesLayerEnabled {
          get { return messagesLayerEnabled_; }
          set {
            messagesLayerEnabled_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as ProScreenLook);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(ProScreenLook other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(ProScreenUuid, other.ProScreenUuid)) return false;
          if (PropsEnabled != other.PropsEnabled) return false;
          if (LiveVideoEnabled != other.LiveVideoEnabled) return false;
          if (PresentationBackgroundEnabled != other.PresentationBackgroundEnabled) return false;
          if (!object.Equals(TemplateDocumentFilePath, other.TemplateDocumentFilePath)) return false;
          if (!object.Equals(TemplateSlideUuid, other.TemplateSlideUuid)) return false;
          if (PresentationForegroundEnabled != other.PresentationForegroundEnabled) return false;
          if (!object.Equals(MaskUuid, other.MaskUuid)) return false;
          if (AnnouncementsEnabled != other.AnnouncementsEnabled) return false;
          if (PropsLayerEnabled != other.PropsLayerEnabled) return false;
          if (MessagesLayerEnabled != other.MessagesLayerEnabled) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (proScreenUuid_ != null) hash ^= ProScreenUuid.GetHashCode();
          if (PropsEnabled != false) hash ^= PropsEnabled.GetHashCode();
          if (LiveVideoEnabled != false) hash ^= LiveVideoEnabled.GetHashCode();
          if (PresentationBackgroundEnabled != false) hash ^= PresentationBackgroundEnabled.GetHashCode();
          if (templateDocumentFilePath_ != null) hash ^= TemplateDocumentFilePath.GetHashCode();
          if (templateSlideUuid_ != null) hash ^= TemplateSlideUuid.GetHashCode();
          if (PresentationForegroundEnabled != false) hash ^= PresentationForegroundEnabled.GetHashCode();
          if (maskUuid_ != null) hash ^= MaskUuid.GetHashCode();
          if (AnnouncementsEnabled != false) hash ^= AnnouncementsEnabled.GetHashCode();
          if (PropsLayerEnabled != false) hash ^= PropsLayerEnabled.GetHashCode();
          if (MessagesLayerEnabled != false) hash ^= MessagesLayerEnabled.GetHashCode();
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
          if (proScreenUuid_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(ProScreenUuid);
          }
          if (PropsEnabled != false) {
            output.WriteRawTag(16);
            output.WriteBool(PropsEnabled);
          }
          if (LiveVideoEnabled != false) {
            output.WriteRawTag(24);
            output.WriteBool(LiveVideoEnabled);
          }
          if (PresentationBackgroundEnabled != false) {
            output.WriteRawTag(32);
            output.WriteBool(PresentationBackgroundEnabled);
          }
          if (templateDocumentFilePath_ != null) {
            output.WriteRawTag(42);
            output.WriteMessage(TemplateDocumentFilePath);
          }
          if (templateSlideUuid_ != null) {
            output.WriteRawTag(50);
            output.WriteMessage(TemplateSlideUuid);
          }
          if (PresentationForegroundEnabled != false) {
            output.WriteRawTag(56);
            output.WriteBool(PresentationForegroundEnabled);
          }
          if (maskUuid_ != null) {
            output.WriteRawTag(66);
            output.WriteMessage(MaskUuid);
          }
          if (AnnouncementsEnabled != false) {
            output.WriteRawTag(72);
            output.WriteBool(AnnouncementsEnabled);
          }
          if (PropsLayerEnabled != false) {
            output.WriteRawTag(80);
            output.WriteBool(PropsLayerEnabled);
          }
          if (MessagesLayerEnabled != false) {
            output.WriteRawTag(88);
            output.WriteBool(MessagesLayerEnabled);
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
          if (proScreenUuid_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(ProScreenUuid);
          }
          if (PropsEnabled != false) {
            output.WriteRawTag(16);
            output.WriteBool(PropsEnabled);
          }
          if (LiveVideoEnabled != false) {
            output.WriteRawTag(24);
            output.WriteBool(LiveVideoEnabled);
          }
          if (PresentationBackgroundEnabled != false) {
            output.WriteRawTag(32);
            output.WriteBool(PresentationBackgroundEnabled);
          }
          if (templateDocumentFilePath_ != null) {
            output.WriteRawTag(42);
            output.WriteMessage(TemplateDocumentFilePath);
          }
          if (templateSlideUuid_ != null) {
            output.WriteRawTag(50);
            output.WriteMessage(TemplateSlideUuid);
          }
          if (PresentationForegroundEnabled != false) {
            output.WriteRawTag(56);
            output.WriteBool(PresentationForegroundEnabled);
          }
          if (maskUuid_ != null) {
            output.WriteRawTag(66);
            output.WriteMessage(MaskUuid);
          }
          if (AnnouncementsEnabled != false) {
            output.WriteRawTag(72);
            output.WriteBool(AnnouncementsEnabled);
          }
          if (PropsLayerEnabled != false) {
            output.WriteRawTag(80);
            output.WriteBool(PropsLayerEnabled);
          }
          if (MessagesLayerEnabled != false) {
            output.WriteRawTag(88);
            output.WriteBool(MessagesLayerEnabled);
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
          if (proScreenUuid_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProScreenUuid);
          }
          if (PropsEnabled != false) {
            size += 1 + 1;
          }
          if (LiveVideoEnabled != false) {
            size += 1 + 1;
          }
          if (PresentationBackgroundEnabled != false) {
            size += 1 + 1;
          }
          if (templateDocumentFilePath_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(TemplateDocumentFilePath);
          }
          if (templateSlideUuid_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(TemplateSlideUuid);
          }
          if (PresentationForegroundEnabled != false) {
            size += 1 + 1;
          }
          if (maskUuid_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaskUuid);
          }
          if (AnnouncementsEnabled != false) {
            size += 1 + 1;
          }
          if (PropsLayerEnabled != false) {
            size += 1 + 1;
          }
          if (MessagesLayerEnabled != false) {
            size += 1 + 1;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(ProScreenLook other) {
          if (other == null) {
            return;
          }
          if (other.proScreenUuid_ != null) {
            if (proScreenUuid_ == null) {
              ProScreenUuid = new global::Rv.Data.UUID();
            }
            ProScreenUuid.MergeFrom(other.ProScreenUuid);
          }
          if (other.PropsEnabled != false) {
            PropsEnabled = other.PropsEnabled;
          }
          if (other.LiveVideoEnabled != false) {
            LiveVideoEnabled = other.LiveVideoEnabled;
          }
          if (other.PresentationBackgroundEnabled != false) {
            PresentationBackgroundEnabled = other.PresentationBackgroundEnabled;
          }
          if (other.templateDocumentFilePath_ != null) {
            if (templateDocumentFilePath_ == null) {
              TemplateDocumentFilePath = new global::Rv.Data.URL();
            }
            TemplateDocumentFilePath.MergeFrom(other.TemplateDocumentFilePath);
          }
          if (other.templateSlideUuid_ != null) {
            if (templateSlideUuid_ == null) {
              TemplateSlideUuid = new global::Rv.Data.UUID();
            }
            TemplateSlideUuid.MergeFrom(other.TemplateSlideUuid);
          }
          if (other.PresentationForegroundEnabled != false) {
            PresentationForegroundEnabled = other.PresentationForegroundEnabled;
          }
          if (other.maskUuid_ != null) {
            if (maskUuid_ == null) {
              MaskUuid = new global::Rv.Data.UUID();
            }
            MaskUuid.MergeFrom(other.MaskUuid);
          }
          if (other.AnnouncementsEnabled != false) {
            AnnouncementsEnabled = other.AnnouncementsEnabled;
          }
          if (other.PropsLayerEnabled != false) {
            PropsLayerEnabled = other.PropsLayerEnabled;
          }
          if (other.MessagesLayerEnabled != false) {
            MessagesLayerEnabled = other.MessagesLayerEnabled;
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
                if (proScreenUuid_ == null) {
                  ProScreenUuid = new global::Rv.Data.UUID();
                }
                input.ReadMessage(ProScreenUuid);
                break;
              }
              case 16: {
                PropsEnabled = input.ReadBool();
                break;
              }
              case 24: {
                LiveVideoEnabled = input.ReadBool();
                break;
              }
              case 32: {
                PresentationBackgroundEnabled = input.ReadBool();
                break;
              }
              case 42: {
                if (templateDocumentFilePath_ == null) {
                  TemplateDocumentFilePath = new global::Rv.Data.URL();
                }
                input.ReadMessage(TemplateDocumentFilePath);
                break;
              }
              case 50: {
                if (templateSlideUuid_ == null) {
                  TemplateSlideUuid = new global::Rv.Data.UUID();
                }
                input.ReadMessage(TemplateSlideUuid);
                break;
              }
              case 56: {
                PresentationForegroundEnabled = input.ReadBool();
                break;
              }
              case 66: {
                if (maskUuid_ == null) {
                  MaskUuid = new global::Rv.Data.UUID();
                }
                input.ReadMessage(MaskUuid);
                break;
              }
              case 72: {
                AnnouncementsEnabled = input.ReadBool();
                break;
              }
              case 80: {
                PropsLayerEnabled = input.ReadBool();
                break;
              }
              case 88: {
                MessagesLayerEnabled = input.ReadBool();
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
                if (proScreenUuid_ == null) {
                  ProScreenUuid = new global::Rv.Data.UUID();
                }
                input.ReadMessage(ProScreenUuid);
                break;
              }
              case 16: {
                PropsEnabled = input.ReadBool();
                break;
              }
              case 24: {
                LiveVideoEnabled = input.ReadBool();
                break;
              }
              case 32: {
                PresentationBackgroundEnabled = input.ReadBool();
                break;
              }
              case 42: {
                if (templateDocumentFilePath_ == null) {
                  TemplateDocumentFilePath = new global::Rv.Data.URL();
                }
                input.ReadMessage(TemplateDocumentFilePath);
                break;
              }
              case 50: {
                if (templateSlideUuid_ == null) {
                  TemplateSlideUuid = new global::Rv.Data.UUID();
                }
                input.ReadMessage(TemplateSlideUuid);
                break;
              }
              case 56: {
                PresentationForegroundEnabled = input.ReadBool();
                break;
              }
              case 66: {
                if (maskUuid_ == null) {
                  MaskUuid = new global::Rv.Data.UUID();
                }
                input.ReadMessage(MaskUuid);
                break;
              }
              case 72: {
                AnnouncementsEnabled = input.ReadBool();
                break;
              }
              case 80: {
                PropsLayerEnabled = input.ReadBool();
                break;
              }
              case 88: {
                MessagesLayerEnabled = input.ReadBool();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
