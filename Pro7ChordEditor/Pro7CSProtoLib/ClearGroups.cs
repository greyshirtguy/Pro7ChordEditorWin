// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: clearGroups.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Rv.Data {

  /// <summary>Holder for reflection information generated from clearGroups.proto</summary>
  public static partial class ClearGroupsReflection {

    #region Descriptor
    /// <summary>File descriptor for clearGroups.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClearGroupsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFjbGVhckdyb3Vwcy5wcm90bxIHcnYuZGF0YRoQYmFzaWNUeXBlcy5wcm90",
            "bxoMYWN0aW9uLnByb3RvIq4KChNDbGVhckdyb3Vwc0RvY3VtZW50EjIKEGFw",
            "cGxpY2F0aW9uX2luZm8YASABKAsyGC5ydi5kYXRhLkFwcGxpY2F0aW9uSW5m",
            "bxI3CgZncm91cHMYAiADKAsyJy5ydi5kYXRhLkNsZWFyR3JvdXBzRG9jdW1l",
            "bnQuQ2xlYXJHcm91cBqpCQoKQ2xlYXJHcm91cBIbCgR1dWlkGAEgASgLMg0u",
            "cnYuZGF0YS5VVUlEEgwKBG5hbWUYAiABKAkSMAoNbGF5ZXJfdGFyZ2V0cxgD",
            "IAMoCzIZLnJ2LmRhdGEuQWN0aW9uLkNsZWFyVHlwZRIcChRpc19oaWRkZW5f",
            "aW5fcHJldmlldxgEIAEoCBISCgppbWFnZV9kYXRhGAUgASgMEkUKCmltYWdl",
            "X3R5cGUYBiABKA4yMS5ydi5kYXRhLkNsZWFyR3JvdXBzRG9jdW1lbnQuQ2xl",
            "YXJHcm91cC5JbWFnZVR5cGUSFgoOaXNfaWNvbl90aW50ZWQYByABKAgSJwoP",
            "aWNvbl90aW50X2NvbG9yGAggASgLMg4ucnYuZGF0YS5Db2xvchJUChB0aW1l",
            "bGluZV90YXJnZXRzGAkgAygOMjoucnYuZGF0YS5DbGVhckdyb3Vwc0RvY3Vt",
            "ZW50LkNsZWFyR3JvdXAuQ29udGVudERlc3RpbmF0aW9uEiUKHWNsZWFyX3By",
            "ZXNlbnRhdGlvbl9uZXh0X3NsaWRlGAogASgIIqkFCglJbWFnZVR5cGUSEwoP",
            "SW1hZ2VUeXBlQ3VzdG9tEAASEAoMSW1hZ2VUeXBlT25lEAESEAoMSW1hZ2VU",
            "eXBlVHdvEAISEgoOSW1hZ2VUeXBlVGhyZWUQAxIRCg1JbWFnZVR5cGVGb3Vy",
            "EAQSEQoNSW1hZ2VUeXBlRml2ZRAFEhAKDEltYWdlVHlwZVNpeBAGEhIKDklt",
            "YWdlVHlwZVNldmVuEAcSEgoOSW1hZ2VUeXBlRWlnaHQQCBIRCg1JbWFnZVR5",
            "cGVOaW5lEAkSEQoNSW1hZ2VUeXBlWmVybxAKEhAKDEltYWdlVHlwZUFsbBAL",
            "EhUKEUltYWdlVHlwZU1lZ2Fob3JuEAwSEQoNSW1hZ2VUeXBlUGxheRANEhEK",
            "DUltYWdlVHlwZUJ1bGIQDhIXChNJbWFnZVR5cGVTdW5nbGFzc2VzEA8SEgoO",
            "SW1hZ2VUeXBlQXJyb3cQEBITCg9JbWFnZVR5cGVUYXJnZXQQERIRCg1JbWFn",
            "ZVR5cGVTdGFyEBISEAoMSW1hZ2VUeXBlU3VuEBMSEQoNSW1hZ2VUeXBlQmVs",
            "bBAUEhYKEkltYWdlVHlwZVBhcGVyY2xpcBAVEhIKDkltYWdlVHlwZUZsYXNr",
            "EBYSFwoTSW1hZ2VUeXBlRXllZ2xhc3NlcxAXEhQKEEltYWdlVHlwZUN1cGNh",
            "a2UQGBISCg5JbWFnZVR5cGVTbGlkZRAZEhAKDEltYWdlVHlwZUhhdBAaEhMK",
            "D0ltYWdlVHlwZUZsb3dlchAbEhIKDkltYWdlVHlwZUhlYXJ0EBwSFAoQSW1h",
            "Z2VUeXBlTWVzc2FnZRAdEhIKDkltYWdlVHlwZUF1ZGlvEB4SEgoOSW1hZ2VU",
            "eXBlQ2xvdWQQHxIYChRJbWFnZVR5cGVFeGNsYW1hdGlvbhAgIlsKEkNvbnRl",
            "bnREZXN0aW5hdGlvbhIeChpDT05URU5UX0RFU1RJTkFUSU9OX0dMT0JBTBAA",
            "EiUKIUNPTlRFTlRfREVTVElOQVRJT05fQU5OT1VOQ0VNRU5UUxABYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Rv.Data.BasicTypesReflection.Descriptor, global::Rv.Data.ActionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.ClearGroupsDocument), global::Rv.Data.ClearGroupsDocument.Parser, new[]{ "ApplicationInfo", "Groups" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.ClearGroupsDocument.Types.ClearGroup), global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Parser, new[]{ "Uuid", "Name", "LayerTargets", "IsHiddenInPreview", "ImageData", "ImageType", "IsIconTinted", "IconTintColor", "TimelineTargets", "ClearPresentationNextSlide" }, null, new[]{ typeof(global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType), typeof(global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ContentDestination) }, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClearGroupsDocument : pb::IMessage<ClearGroupsDocument>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClearGroupsDocument> _parser = new pb::MessageParser<ClearGroupsDocument>(() => new ClearGroupsDocument());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClearGroupsDocument> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rv.Data.ClearGroupsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClearGroupsDocument() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClearGroupsDocument(ClearGroupsDocument other) : this() {
      applicationInfo_ = other.applicationInfo_ != null ? other.applicationInfo_.Clone() : null;
      groups_ = other.groups_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClearGroupsDocument Clone() {
      return new ClearGroupsDocument(this);
    }

    /// <summary>Field number for the "application_info" field.</summary>
    public const int ApplicationInfoFieldNumber = 1;
    private global::Rv.Data.ApplicationInfo applicationInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Rv.Data.ApplicationInfo ApplicationInfo {
      get { return applicationInfo_; }
      set {
        applicationInfo_ = value;
      }
    }

    /// <summary>Field number for the "groups" field.</summary>
    public const int GroupsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Rv.Data.ClearGroupsDocument.Types.ClearGroup> _repeated_groups_codec
        = pb::FieldCodec.ForMessage(18, global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Parser);
    private readonly pbc::RepeatedField<global::Rv.Data.ClearGroupsDocument.Types.ClearGroup> groups_ = new pbc::RepeatedField<global::Rv.Data.ClearGroupsDocument.Types.ClearGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Rv.Data.ClearGroupsDocument.Types.ClearGroup> Groups {
      get { return groups_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClearGroupsDocument);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClearGroupsDocument other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ApplicationInfo, other.ApplicationInfo)) return false;
      if(!groups_.Equals(other.groups_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (applicationInfo_ != null) hash ^= ApplicationInfo.GetHashCode();
      hash ^= groups_.GetHashCode();
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
      if (applicationInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ApplicationInfo);
      }
      groups_.WriteTo(output, _repeated_groups_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (applicationInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ApplicationInfo);
      }
      groups_.WriteTo(ref output, _repeated_groups_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (applicationInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ApplicationInfo);
      }
      size += groups_.CalculateSize(_repeated_groups_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClearGroupsDocument other) {
      if (other == null) {
        return;
      }
      if (other.applicationInfo_ != null) {
        if (applicationInfo_ == null) {
          ApplicationInfo = new global::Rv.Data.ApplicationInfo();
        }
        ApplicationInfo.MergeFrom(other.ApplicationInfo);
      }
      groups_.Add(other.groups_);
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
            if (applicationInfo_ == null) {
              ApplicationInfo = new global::Rv.Data.ApplicationInfo();
            }
            input.ReadMessage(ApplicationInfo);
            break;
          }
          case 18: {
            groups_.AddEntriesFrom(input, _repeated_groups_codec);
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
            if (applicationInfo_ == null) {
              ApplicationInfo = new global::Rv.Data.ApplicationInfo();
            }
            input.ReadMessage(ApplicationInfo);
            break;
          }
          case 18: {
            groups_.AddEntriesFrom(ref input, _repeated_groups_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ClearGroupsDocument message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class ClearGroup : pb::IMessage<ClearGroup>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<ClearGroup> _parser = new pb::MessageParser<ClearGroup>(() => new ClearGroup());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<ClearGroup> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Rv.Data.ClearGroupsDocument.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ClearGroup() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ClearGroup(ClearGroup other) : this() {
          uuid_ = other.uuid_ != null ? other.uuid_.Clone() : null;
          name_ = other.name_;
          layerTargets_ = other.layerTargets_.Clone();
          isHiddenInPreview_ = other.isHiddenInPreview_;
          imageData_ = other.imageData_;
          imageType_ = other.imageType_;
          isIconTinted_ = other.isIconTinted_;
          iconTintColor_ = other.iconTintColor_ != null ? other.iconTintColor_.Clone() : null;
          timelineTargets_ = other.timelineTargets_.Clone();
          clearPresentationNextSlide_ = other.clearPresentationNextSlide_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ClearGroup Clone() {
          return new ClearGroup(this);
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

        /// <summary>Field number for the "layer_targets" field.</summary>
        public const int LayerTargetsFieldNumber = 3;
        private static readonly pb::FieldCodec<global::Rv.Data.Action.Types.ClearType> _repeated_layerTargets_codec
            = pb::FieldCodec.ForMessage(26, global::Rv.Data.Action.Types.ClearType.Parser);
        private readonly pbc::RepeatedField<global::Rv.Data.Action.Types.ClearType> layerTargets_ = new pbc::RepeatedField<global::Rv.Data.Action.Types.ClearType>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Rv.Data.Action.Types.ClearType> LayerTargets {
          get { return layerTargets_; }
        }

        /// <summary>Field number for the "is_hidden_in_preview" field.</summary>
        public const int IsHiddenInPreviewFieldNumber = 4;
        private bool isHiddenInPreview_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool IsHiddenInPreview {
          get { return isHiddenInPreview_; }
          set {
            isHiddenInPreview_ = value;
          }
        }

        /// <summary>Field number for the "image_data" field.</summary>
        public const int ImageDataFieldNumber = 5;
        private pb::ByteString imageData_ = pb::ByteString.Empty;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pb::ByteString ImageData {
          get { return imageData_; }
          set {
            imageData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "image_type" field.</summary>
        public const int ImageTypeFieldNumber = 6;
        private global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType imageType_ = global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType.Custom;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType ImageType {
          get { return imageType_; }
          set {
            imageType_ = value;
          }
        }

        /// <summary>Field number for the "is_icon_tinted" field.</summary>
        public const int IsIconTintedFieldNumber = 7;
        private bool isIconTinted_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool IsIconTinted {
          get { return isIconTinted_; }
          set {
            isIconTinted_ = value;
          }
        }

        /// <summary>Field number for the "icon_tint_color" field.</summary>
        public const int IconTintColorFieldNumber = 8;
        private global::Rv.Data.Color iconTintColor_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Rv.Data.Color IconTintColor {
          get { return iconTintColor_; }
          set {
            iconTintColor_ = value;
          }
        }

        /// <summary>Field number for the "timeline_targets" field.</summary>
        public const int TimelineTargetsFieldNumber = 9;
        private static readonly pb::FieldCodec<global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ContentDestination> _repeated_timelineTargets_codec
            = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ContentDestination) x);
        private readonly pbc::RepeatedField<global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ContentDestination> timelineTargets_ = new pbc::RepeatedField<global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ContentDestination>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ContentDestination> TimelineTargets {
          get { return timelineTargets_; }
        }

        /// <summary>Field number for the "clear_presentation_next_slide" field.</summary>
        public const int ClearPresentationNextSlideFieldNumber = 10;
        private bool clearPresentationNextSlide_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool ClearPresentationNextSlide {
          get { return clearPresentationNextSlide_; }
          set {
            clearPresentationNextSlide_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as ClearGroup);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(ClearGroup other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(Uuid, other.Uuid)) return false;
          if (Name != other.Name) return false;
          if(!layerTargets_.Equals(other.layerTargets_)) return false;
          if (IsHiddenInPreview != other.IsHiddenInPreview) return false;
          if (ImageData != other.ImageData) return false;
          if (ImageType != other.ImageType) return false;
          if (IsIconTinted != other.IsIconTinted) return false;
          if (!object.Equals(IconTintColor, other.IconTintColor)) return false;
          if(!timelineTargets_.Equals(other.timelineTargets_)) return false;
          if (ClearPresentationNextSlide != other.ClearPresentationNextSlide) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (uuid_ != null) hash ^= Uuid.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          hash ^= layerTargets_.GetHashCode();
          if (IsHiddenInPreview != false) hash ^= IsHiddenInPreview.GetHashCode();
          if (ImageData.Length != 0) hash ^= ImageData.GetHashCode();
          if (ImageType != global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType.Custom) hash ^= ImageType.GetHashCode();
          if (IsIconTinted != false) hash ^= IsIconTinted.GetHashCode();
          if (iconTintColor_ != null) hash ^= IconTintColor.GetHashCode();
          hash ^= timelineTargets_.GetHashCode();
          if (ClearPresentationNextSlide != false) hash ^= ClearPresentationNextSlide.GetHashCode();
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
          layerTargets_.WriteTo(output, _repeated_layerTargets_codec);
          if (IsHiddenInPreview != false) {
            output.WriteRawTag(32);
            output.WriteBool(IsHiddenInPreview);
          }
          if (ImageData.Length != 0) {
            output.WriteRawTag(42);
            output.WriteBytes(ImageData);
          }
          if (ImageType != global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType.Custom) {
            output.WriteRawTag(48);
            output.WriteEnum((int) ImageType);
          }
          if (IsIconTinted != false) {
            output.WriteRawTag(56);
            output.WriteBool(IsIconTinted);
          }
          if (iconTintColor_ != null) {
            output.WriteRawTag(66);
            output.WriteMessage(IconTintColor);
          }
          timelineTargets_.WriteTo(output, _repeated_timelineTargets_codec);
          if (ClearPresentationNextSlide != false) {
            output.WriteRawTag(80);
            output.WriteBool(ClearPresentationNextSlide);
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
          layerTargets_.WriteTo(ref output, _repeated_layerTargets_codec);
          if (IsHiddenInPreview != false) {
            output.WriteRawTag(32);
            output.WriteBool(IsHiddenInPreview);
          }
          if (ImageData.Length != 0) {
            output.WriteRawTag(42);
            output.WriteBytes(ImageData);
          }
          if (ImageType != global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType.Custom) {
            output.WriteRawTag(48);
            output.WriteEnum((int) ImageType);
          }
          if (IsIconTinted != false) {
            output.WriteRawTag(56);
            output.WriteBool(IsIconTinted);
          }
          if (iconTintColor_ != null) {
            output.WriteRawTag(66);
            output.WriteMessage(IconTintColor);
          }
          timelineTargets_.WriteTo(ref output, _repeated_timelineTargets_codec);
          if (ClearPresentationNextSlide != false) {
            output.WriteRawTag(80);
            output.WriteBool(ClearPresentationNextSlide);
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
          size += layerTargets_.CalculateSize(_repeated_layerTargets_codec);
          if (IsHiddenInPreview != false) {
            size += 1 + 1;
          }
          if (ImageData.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(ImageData);
          }
          if (ImageType != global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType.Custom) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ImageType);
          }
          if (IsIconTinted != false) {
            size += 1 + 1;
          }
          if (iconTintColor_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(IconTintColor);
          }
          size += timelineTargets_.CalculateSize(_repeated_timelineTargets_codec);
          if (ClearPresentationNextSlide != false) {
            size += 1 + 1;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(ClearGroup other) {
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
          layerTargets_.Add(other.layerTargets_);
          if (other.IsHiddenInPreview != false) {
            IsHiddenInPreview = other.IsHiddenInPreview;
          }
          if (other.ImageData.Length != 0) {
            ImageData = other.ImageData;
          }
          if (other.ImageType != global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType.Custom) {
            ImageType = other.ImageType;
          }
          if (other.IsIconTinted != false) {
            IsIconTinted = other.IsIconTinted;
          }
          if (other.iconTintColor_ != null) {
            if (iconTintColor_ == null) {
              IconTintColor = new global::Rv.Data.Color();
            }
            IconTintColor.MergeFrom(other.IconTintColor);
          }
          timelineTargets_.Add(other.timelineTargets_);
          if (other.ClearPresentationNextSlide != false) {
            ClearPresentationNextSlide = other.ClearPresentationNextSlide;
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
                layerTargets_.AddEntriesFrom(input, _repeated_layerTargets_codec);
                break;
              }
              case 32: {
                IsHiddenInPreview = input.ReadBool();
                break;
              }
              case 42: {
                ImageData = input.ReadBytes();
                break;
              }
              case 48: {
                ImageType = (global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType) input.ReadEnum();
                break;
              }
              case 56: {
                IsIconTinted = input.ReadBool();
                break;
              }
              case 66: {
                if (iconTintColor_ == null) {
                  IconTintColor = new global::Rv.Data.Color();
                }
                input.ReadMessage(IconTintColor);
                break;
              }
              case 74:
              case 72: {
                timelineTargets_.AddEntriesFrom(input, _repeated_timelineTargets_codec);
                break;
              }
              case 80: {
                ClearPresentationNextSlide = input.ReadBool();
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
                layerTargets_.AddEntriesFrom(ref input, _repeated_layerTargets_codec);
                break;
              }
              case 32: {
                IsHiddenInPreview = input.ReadBool();
                break;
              }
              case 42: {
                ImageData = input.ReadBytes();
                break;
              }
              case 48: {
                ImageType = (global::Rv.Data.ClearGroupsDocument.Types.ClearGroup.Types.ImageType) input.ReadEnum();
                break;
              }
              case 56: {
                IsIconTinted = input.ReadBool();
                break;
              }
              case 66: {
                if (iconTintColor_ == null) {
                  IconTintColor = new global::Rv.Data.Color();
                }
                input.ReadMessage(IconTintColor);
                break;
              }
              case 74:
              case 72: {
                timelineTargets_.AddEntriesFrom(ref input, _repeated_timelineTargets_codec);
                break;
              }
              case 80: {
                ClearPresentationNextSlide = input.ReadBool();
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the ClearGroup message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          public enum ImageType {
            [pbr::OriginalName("ImageTypeCustom")] Custom = 0,
            [pbr::OriginalName("ImageTypeOne")] One = 1,
            [pbr::OriginalName("ImageTypeTwo")] Two = 2,
            [pbr::OriginalName("ImageTypeThree")] Three = 3,
            [pbr::OriginalName("ImageTypeFour")] Four = 4,
            [pbr::OriginalName("ImageTypeFive")] Five = 5,
            [pbr::OriginalName("ImageTypeSix")] Six = 6,
            [pbr::OriginalName("ImageTypeSeven")] Seven = 7,
            [pbr::OriginalName("ImageTypeEight")] Eight = 8,
            [pbr::OriginalName("ImageTypeNine")] Nine = 9,
            [pbr::OriginalName("ImageTypeZero")] Zero = 10,
            [pbr::OriginalName("ImageTypeAll")] All = 11,
            [pbr::OriginalName("ImageTypeMegahorn")] Megahorn = 12,
            [pbr::OriginalName("ImageTypePlay")] Play = 13,
            [pbr::OriginalName("ImageTypeBulb")] Bulb = 14,
            [pbr::OriginalName("ImageTypeSunglasses")] Sunglasses = 15,
            [pbr::OriginalName("ImageTypeArrow")] Arrow = 16,
            [pbr::OriginalName("ImageTypeTarget")] Target = 17,
            [pbr::OriginalName("ImageTypeStar")] Star = 18,
            [pbr::OriginalName("ImageTypeSun")] Sun = 19,
            [pbr::OriginalName("ImageTypeBell")] Bell = 20,
            [pbr::OriginalName("ImageTypePaperclip")] Paperclip = 21,
            [pbr::OriginalName("ImageTypeFlask")] Flask = 22,
            [pbr::OriginalName("ImageTypeEyeglasses")] Eyeglasses = 23,
            [pbr::OriginalName("ImageTypeCupcake")] Cupcake = 24,
            [pbr::OriginalName("ImageTypeSlide")] Slide = 25,
            [pbr::OriginalName("ImageTypeHat")] Hat = 26,
            [pbr::OriginalName("ImageTypeFlower")] Flower = 27,
            [pbr::OriginalName("ImageTypeHeart")] Heart = 28,
            [pbr::OriginalName("ImageTypeMessage")] Message = 29,
            [pbr::OriginalName("ImageTypeAudio")] Audio = 30,
            [pbr::OriginalName("ImageTypeCloud")] Cloud = 31,
            [pbr::OriginalName("ImageTypeExclamation")] Exclamation = 32,
          }

          public enum ContentDestination {
            [pbr::OriginalName("CONTENT_DESTINATION_GLOBAL")] Global = 0,
            [pbr::OriginalName("CONTENT_DESTINATION_ANNOUNCEMENTS")] Announcements = 1,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
