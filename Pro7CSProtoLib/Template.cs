// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: template.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Rv.Data {

  /// <summary>Holder for reflection information generated from template.proto</summary>
  public static partial class TemplateReflection {

    #region Descriptor
    /// <summary>File descriptor for template.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TemplateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg50ZW1wbGF0ZS5wcm90bxIHcnYuZGF0YRoQYmFzaWNUeXBlcy5wcm90bxoL",
            "c2xpZGUucHJvdG8iuAIKCFRlbXBsYXRlGjkKBVNsaWRlEiIKCmJhc2Vfc2xp",
            "ZGUYASABKAsyDi5ydi5kYXRhLlNsaWRlEgwKBG5hbWUYAiABKAkaZwoIRG9j",
            "dW1lbnQSMgoQYXBwbGljYXRpb25faW5mbxgBIAEoCzIYLnJ2LmRhdGEuQXBw",
            "bGljYXRpb25JbmZvEicKBnNsaWRlcxgDIAMoCzIXLnJ2LmRhdGEuVGVtcGxh",
            "dGUuU2xpZGUahwEKDklkZW50aWZpY2F0aW9uEhsKBHV1aWQYASABKAsyDS5y",
            "di5kYXRhLlVVSUQSDAoEbmFtZRgCIAEoCRIhCgpzbGlkZV91dWlkGAMgASgL",
            "Mg0ucnYuZGF0YS5VVUlEEhIKCnNsaWRlX25hbWUYBCABKAkSEwoLc2xpZGVf",
            "aW5kZXgYBSABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Rv.Data.BasicTypesReflection.Descriptor, global::Rv.Data.SlideReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.Template), global::Rv.Data.Template.Parser, null, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.Template.Types.Slide), global::Rv.Data.Template.Types.Slide.Parser, new[]{ "BaseSlide", "Name" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.Template.Types.Document), global::Rv.Data.Template.Types.Document.Parser, new[]{ "ApplicationInfo", "Slides" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.Template.Types.Identification), global::Rv.Data.Template.Types.Identification.Parser, new[]{ "Uuid", "Name", "SlideUuid", "SlideName", "SlideIndex" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Template : pb::IMessage<Template>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Template> _parser = new pb::MessageParser<Template>(() => new Template());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Template> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rv.Data.TemplateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Template() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Template(Template other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Template Clone() {
      return new Template(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Template);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Template other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Template other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Template message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class Slide : pb::IMessage<Slide>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Slide> _parser = new pb::MessageParser<Slide>(() => new Slide());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Slide> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Rv.Data.Template.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Slide() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Slide(Slide other) : this() {
          baseSlide_ = other.baseSlide_ != null ? other.baseSlide_.Clone() : null;
          name_ = other.name_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Slide Clone() {
          return new Slide(this);
        }

        /// <summary>Field number for the "base_slide" field.</summary>
        public const int BaseSlideFieldNumber = 1;
        private global::Rv.Data.Slide baseSlide_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Rv.Data.Slide BaseSlide {
          get { return baseSlide_; }
          set {
            baseSlide_ = value;
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

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Slide);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Slide other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(BaseSlide, other.BaseSlide)) return false;
          if (Name != other.Name) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (baseSlide_ != null) hash ^= BaseSlide.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
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
          if (baseSlide_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(BaseSlide);
          }
          if (Name.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Name);
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
          if (baseSlide_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(BaseSlide);
          }
          if (Name.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Name);
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
          if (baseSlide_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(BaseSlide);
          }
          if (Name.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Slide other) {
          if (other == null) {
            return;
          }
          if (other.baseSlide_ != null) {
            if (baseSlide_ == null) {
              BaseSlide = new global::Rv.Data.Slide();
            }
            BaseSlide.MergeFrom(other.BaseSlide);
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
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
                if (baseSlide_ == null) {
                  BaseSlide = new global::Rv.Data.Slide();
                }
                input.ReadMessage(BaseSlide);
                break;
              }
              case 18: {
                Name = input.ReadString();
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
                if (baseSlide_ == null) {
                  BaseSlide = new global::Rv.Data.Slide();
                }
                input.ReadMessage(BaseSlide);
                break;
              }
              case 18: {
                Name = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

      public sealed partial class Document : pb::IMessage<Document>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Document> _parser = new pb::MessageParser<Document>(() => new Document());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Document> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Rv.Data.Template.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Document() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Document(Document other) : this() {
          applicationInfo_ = other.applicationInfo_ != null ? other.applicationInfo_.Clone() : null;
          slides_ = other.slides_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Document Clone() {
          return new Document(this);
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

        /// <summary>Field number for the "slides" field.</summary>
        public const int SlidesFieldNumber = 3;
        private static readonly pb::FieldCodec<global::Rv.Data.Template.Types.Slide> _repeated_slides_codec
            = pb::FieldCodec.ForMessage(26, global::Rv.Data.Template.Types.Slide.Parser);
        private readonly pbc::RepeatedField<global::Rv.Data.Template.Types.Slide> slides_ = new pbc::RepeatedField<global::Rv.Data.Template.Types.Slide>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Rv.Data.Template.Types.Slide> Slides {
          get { return slides_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Document);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Document other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(ApplicationInfo, other.ApplicationInfo)) return false;
          if(!slides_.Equals(other.slides_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (applicationInfo_ != null) hash ^= ApplicationInfo.GetHashCode();
          hash ^= slides_.GetHashCode();
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
          slides_.WriteTo(output, _repeated_slides_codec);
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
          slides_.WriteTo(ref output, _repeated_slides_codec);
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
          size += slides_.CalculateSize(_repeated_slides_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Document other) {
          if (other == null) {
            return;
          }
          if (other.applicationInfo_ != null) {
            if (applicationInfo_ == null) {
              ApplicationInfo = new global::Rv.Data.ApplicationInfo();
            }
            ApplicationInfo.MergeFrom(other.ApplicationInfo);
          }
          slides_.Add(other.slides_);
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
              case 26: {
                slides_.AddEntriesFrom(input, _repeated_slides_codec);
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
              case 26: {
                slides_.AddEntriesFrom(ref input, _repeated_slides_codec);
                break;
              }
            }
          }
        }
        #endif

      }

      public sealed partial class Identification : pb::IMessage<Identification>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Identification> _parser = new pb::MessageParser<Identification>(() => new Identification());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Identification> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Rv.Data.Template.Descriptor.NestedTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Identification() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Identification(Identification other) : this() {
          uuid_ = other.uuid_ != null ? other.uuid_.Clone() : null;
          name_ = other.name_;
          slideUuid_ = other.slideUuid_ != null ? other.slideUuid_.Clone() : null;
          slideName_ = other.slideName_;
          slideIndex_ = other.slideIndex_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Identification Clone() {
          return new Identification(this);
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

        /// <summary>Field number for the "slide_uuid" field.</summary>
        public const int SlideUuidFieldNumber = 3;
        private global::Rv.Data.UUID slideUuid_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Rv.Data.UUID SlideUuid {
          get { return slideUuid_; }
          set {
            slideUuid_ = value;
          }
        }

        /// <summary>Field number for the "slide_name" field.</summary>
        public const int SlideNameFieldNumber = 4;
        private string slideName_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string SlideName {
          get { return slideName_; }
          set {
            slideName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "slide_index" field.</summary>
        public const int SlideIndexFieldNumber = 5;
        private uint slideIndex_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint SlideIndex {
          get { return slideIndex_; }
          set {
            slideIndex_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Identification);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Identification other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(Uuid, other.Uuid)) return false;
          if (Name != other.Name) return false;
          if (!object.Equals(SlideUuid, other.SlideUuid)) return false;
          if (SlideName != other.SlideName) return false;
          if (SlideIndex != other.SlideIndex) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (uuid_ != null) hash ^= Uuid.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          if (slideUuid_ != null) hash ^= SlideUuid.GetHashCode();
          if (SlideName.Length != 0) hash ^= SlideName.GetHashCode();
          if (SlideIndex != 0) hash ^= SlideIndex.GetHashCode();
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
          if (slideUuid_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(SlideUuid);
          }
          if (SlideName.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(SlideName);
          }
          if (SlideIndex != 0) {
            output.WriteRawTag(40);
            output.WriteUInt32(SlideIndex);
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
          if (slideUuid_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(SlideUuid);
          }
          if (SlideName.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(SlideName);
          }
          if (SlideIndex != 0) {
            output.WriteRawTag(40);
            output.WriteUInt32(SlideIndex);
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
          if (slideUuid_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(SlideUuid);
          }
          if (SlideName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(SlideName);
          }
          if (SlideIndex != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SlideIndex);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Identification other) {
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
          if (other.slideUuid_ != null) {
            if (slideUuid_ == null) {
              SlideUuid = new global::Rv.Data.UUID();
            }
            SlideUuid.MergeFrom(other.SlideUuid);
          }
          if (other.SlideName.Length != 0) {
            SlideName = other.SlideName;
          }
          if (other.SlideIndex != 0) {
            SlideIndex = other.SlideIndex;
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
                if (slideUuid_ == null) {
                  SlideUuid = new global::Rv.Data.UUID();
                }
                input.ReadMessage(SlideUuid);
                break;
              }
              case 34: {
                SlideName = input.ReadString();
                break;
              }
              case 40: {
                SlideIndex = input.ReadUInt32();
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
                if (slideUuid_ == null) {
                  SlideUuid = new global::Rv.Data.UUID();
                }
                input.ReadMessage(SlideUuid);
                break;
              }
              case 34: {
                SlideName = input.ReadString();
                break;
              }
              case 40: {
                SlideIndex = input.ReadUInt32();
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
