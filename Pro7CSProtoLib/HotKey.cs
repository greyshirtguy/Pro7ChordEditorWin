// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: hotKey.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Rv.Data {

  /// <summary>Holder for reflection information generated from hotKey.proto</summary>
  public static partial class HotKeyReflection {

    #region Descriptor
    /// <summary>File descriptor for hotKey.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HotKeyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgxob3RLZXkucHJvdG8SB3J2LmRhdGEi5xUKBkhvdEtleRIlCgRjb2RlGAEg",
            "ASgOMhcucnYuZGF0YS5Ib3RLZXkuS2V5Q29kZRIaChJjb250cm9sX2lkZW50",
            "aWZpZXIYAiABKAkimRUKB0tleUNvZGUSFAoQS0VZX0NPREVfVU5LTk9XThAA",
            "EhMKD0tFWV9DT0RFX0FOU0lfQRABEhMKD0tFWV9DT0RFX0FOU0lfQhACEhMK",
            "D0tFWV9DT0RFX0FOU0lfQxADEhMKD0tFWV9DT0RFX0FOU0lfRBAEEhMKD0tF",
            "WV9DT0RFX0FOU0lfRRAFEhMKD0tFWV9DT0RFX0FOU0lfRhAGEhMKD0tFWV9D",
            "T0RFX0FOU0lfRxAHEhMKD0tFWV9DT0RFX0FOU0lfSBAIEhMKD0tFWV9DT0RF",
            "X0FOU0lfSRAJEhMKD0tFWV9DT0RFX0FOU0lfShAKEhMKD0tFWV9DT0RFX0FO",
            "U0lfSxALEhMKD0tFWV9DT0RFX0FOU0lfTBAMEhMKD0tFWV9DT0RFX0FOU0lf",
            "TRANEhMKD0tFWV9DT0RFX0FOU0lfThAOEhMKD0tFWV9DT0RFX0FOU0lfTxAP",
            "EhMKD0tFWV9DT0RFX0FOU0lfUBAQEhMKD0tFWV9DT0RFX0FOU0lfURAREhMK",
            "D0tFWV9DT0RFX0FOU0lfUhASEhMKD0tFWV9DT0RFX0FOU0lfUxATEhMKD0tF",
            "WV9DT0RFX0FOU0lfVBAUEhMKD0tFWV9DT0RFX0FOU0lfVRAVEhMKD0tFWV9D",
            "T0RFX0FOU0lfVhAWEhMKD0tFWV9DT0RFX0FOU0lfVxAXEhMKD0tFWV9DT0RF",
            "X0FOU0lfWBAYEhMKD0tFWV9DT0RFX0FOU0lfWRAZEhMKD0tFWV9DT0RFX0FO",
            "U0lfWhAaEhMKD0tFWV9DT0RFX0FOU0lfMBAbEhMKD0tFWV9DT0RFX0FOU0lf",
            "MRAcEhMKD0tFWV9DT0RFX0FOU0lfMhAdEhMKD0tFWV9DT0RFX0FOU0lfMxAe",
            "EhMKD0tFWV9DT0RFX0FOU0lfNBAfEhMKD0tFWV9DT0RFX0FOU0lfNRAgEhMK",
            "D0tFWV9DT0RFX0FOU0lfNhAhEhMKD0tFWV9DT0RFX0FOU0lfNxAiEhMKD0tF",
            "WV9DT0RFX0FOU0lfOBAjEhMKD0tFWV9DT0RFX0FOU0lfORAkEhcKE0tFWV9D",
            "T0RFX0FOU0lfRVFVQUwQJRIXChNLRVlfQ09ERV9BTlNJX01JTlVTECYSHwob",
            "S0VZX0NPREVfQU5TSV9SSUdIVF9CUkFDS0VUECcSHgoaS0VZX0NPREVfQU5T",
            "SV9MRUZUX0JSQUNLRVQQKBIXChNLRVlfQ09ERV9BTlNJX1FVT1RFECkSGwoX",
            "S0VZX0NPREVfQU5TSV9TRU1JQ09MT04QKhIbChdLRVlfQ09ERV9BTlNJX0JB",
            "Q0tTTEFTSBArEhcKE0tFWV9DT0RFX0FOU0lfQ09NTUEQLBIXChNLRVlfQ09E",
            "RV9BTlNJX1NMQVNIEC0SGAoUS0VZX0NPREVfQU5TSV9QRVJJT0QQLhIXChNL",
            "RVlfQ09ERV9BTlNJX0dSQVZFEC8SIAocS0VZX0NPREVfQU5TSV9LRVlQQURf",
            "REVDSU1BTBAwEh0KGUtFWV9DT0RFX0FOU0lfS0VZUEFEX1BMVVMQMRIeChpL",
            "RVlfQ09ERV9BTlNJX0tFWVBBRF9DTEVBUhAyEh8KG0tFWV9DT0RFX0FOU0lf",
            "S0VZUEFEX0RJVklERRAzEh4KGktFWV9DT0RFX0FOU0lfS0VZUEFEX0VOVEVS",
            "EDQSHgoaS0VZX0NPREVfQU5TSV9LRVlQQURfTUlOVVMQNRIfChtLRVlfQ09E",
            "RV9BTlNJX0tFWVBBRF9FUVVBTFMQNhIaChZLRVlfQ09ERV9BTlNJX0tFWVBB",
            "RF8wEDcSGgoWS0VZX0NPREVfQU5TSV9LRVlQQURfMRA4EhoKFktFWV9DT0RF",
            "X0FOU0lfS0VZUEFEXzIQORIaChZLRVlfQ09ERV9BTlNJX0tFWVBBRF8zEDoS",
            "GgoWS0VZX0NPREVfQU5TSV9LRVlQQURfNBA7EhoKFktFWV9DT0RFX0FOU0lf",
            "S0VZUEFEXzUQPBIaChZLRVlfQ09ERV9BTlNJX0tFWVBBRF82ED0SGgoWS0VZ",
            "X0NPREVfQU5TSV9LRVlQQURfNxA+EhoKFktFWV9DT0RFX0FOU0lfS0VZUEFE",
            "XzgQPxIaChZLRVlfQ09ERV9BTlNJX0tFWVBBRF85EEASDwoLS0VZX0NPREVf",
            "RjEQQRIPCgtLRVlfQ09ERV9GMhBCEg8KC0tFWV9DT0RFX0YzEEMSDwoLS0VZ",
            "X0NPREVfRjQQRBIPCgtLRVlfQ09ERV9GNRBFEg8KC0tFWV9DT0RFX0Y2EEYS",
            "DwoLS0VZX0NPREVfRjcQRxIPCgtLRVlfQ09ERV9GOBBIEg8KC0tFWV9DT0RF",
            "X0Y5EEkSEAoMS0VZX0NPREVfRjEwEEoSEAoMS0VZX0NPREVfRjExEEsSEAoM",
            "S0VZX0NPREVfRjEyEEwSEAoMS0VZX0NPREVfRjEzEE0SEAoMS0VZX0NPREVf",
            "RjE0EE4SEAoMS0VZX0NPREVfRjE1EE8SEAoMS0VZX0NPREVfRjE2EFASEAoM",
            "S0VZX0NPREVfRjE3EFESEAoMS0VZX0NPREVfRjE4EFISEAoMS0VZX0NPREVf",
            "RjE5EFMSEAoMS0VZX0NPREVfRjIwEFQSFQoRS0VZX0NPREVfRlVOQ1RJT04Q",
            "VRITCg9LRVlfQ09ERV9SRVRVUk4QVhIQCgxLRVlfQ09ERV9UQUIQVxISCg5L",
            "RVlfQ09ERV9TUEFDRRBYEhMKD0tFWV9DT0RFX0RFTEVURRBZEhMKD0tFWV9D",
            "T0RFX0VTQ0FQRRBaEhQKEEtFWV9DT0RFX0NPTU1BTkQQWxISCg5LRVlfQ09E",
            "RV9TSElGVBBcEhYKEktFWV9DT0RFX0NBUFNfTE9DSxBdEhMKD0tFWV9DT0RF",
            "X09QVElPThBeEhQKEEtFWV9DT0RFX0NPTlRST0wQXxIYChRLRVlfQ09ERV9S",
            "SUdIVF9TSElGVBBgEhkKFUtFWV9DT0RFX1JJR0hUX09QVElPThBhEhoKFktF",
            "WV9DT0RFX1JJR0hUX0NPTlRST0wQYhIWChJLRVlfQ09ERV9WT0xVTUVfVVAQ",
            "YxIYChRLRVlfQ09ERV9WT0xVTUVfRE9XThBkEhEKDUtFWV9DT0RFX01VVEUQ",
            "ZRIRCg1LRVlfQ09ERV9IRUxQEGYSEQoNS0VZX0NPREVfSE9NRRBnEhQKEEtF",
            "WV9DT0RFX1BBR0VfVVAQaBIbChdLRVlfQ09ERV9GT1JXQVJEX0RFTEVURRBp",
            "EhAKDEtFWV9DT0RFX0VORBBqEhYKEktFWV9DT0RFX1BBR0VfRE9XThBrEhcK",
            "E0tFWV9DT0RFX0xFRlRfQVJST1cQbBIYChRLRVlfQ09ERV9SSUdIVF9BUlJP",
            "VxBtEhcKE0tFWV9DT0RFX0RPV05fQVJST1cQbhIVChFLRVlfQ09ERV9VUF9B",
            "UlJPVxBvEhoKFktFWV9DT0RFX0lTT19TRUxFQ1RJT04QcBIUChBLRVlfQ09E",
            "RV9KSVNfWUVOEHESGwoXS0VZX0NPREVfSklTX1VOREVSU0NPUkUQchIdChlL",
            "RVlfQ09ERV9KSVNfS0VZUEFEX0NPTU1BEHMSFQoRS0VZX0NPREVfSklTX0VJ",
            "U1UQdBIVChFLRVlfQ09ERV9KSVNfS0FOQRB1YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Rv.Data.HotKey), global::Rv.Data.HotKey.Parser, new[]{ "Code", "ControlIdentifier" }, null, new[]{ typeof(global::Rv.Data.HotKey.Types.KeyCode) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HotKey : pb::IMessage<HotKey>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HotKey> _parser = new pb::MessageParser<HotKey>(() => new HotKey());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HotKey> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rv.Data.HotKeyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotKey() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotKey(HotKey other) : this() {
      code_ = other.code_;
      controlIdentifier_ = other.controlIdentifier_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotKey Clone() {
      return new HotKey(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::Rv.Data.HotKey.Types.KeyCode code_ = global::Rv.Data.HotKey.Types.KeyCode.Unknown;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Rv.Data.HotKey.Types.KeyCode Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "control_identifier" field.</summary>
    public const int ControlIdentifierFieldNumber = 2;
    private string controlIdentifier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ControlIdentifier {
      get { return controlIdentifier_; }
      set {
        controlIdentifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HotKey);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HotKey other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (ControlIdentifier != other.ControlIdentifier) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != global::Rv.Data.HotKey.Types.KeyCode.Unknown) hash ^= Code.GetHashCode();
      if (ControlIdentifier.Length != 0) hash ^= ControlIdentifier.GetHashCode();
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
      if (Code != global::Rv.Data.HotKey.Types.KeyCode.Unknown) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (ControlIdentifier.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ControlIdentifier);
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
      if (Code != global::Rv.Data.HotKey.Types.KeyCode.Unknown) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (ControlIdentifier.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ControlIdentifier);
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
      if (Code != global::Rv.Data.HotKey.Types.KeyCode.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      if (ControlIdentifier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ControlIdentifier);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HotKey other) {
      if (other == null) {
        return;
      }
      if (other.Code != global::Rv.Data.HotKey.Types.KeyCode.Unknown) {
        Code = other.Code;
      }
      if (other.ControlIdentifier.Length != 0) {
        ControlIdentifier = other.ControlIdentifier;
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
          case 8: {
            Code = (global::Rv.Data.HotKey.Types.KeyCode) input.ReadEnum();
            break;
          }
          case 18: {
            ControlIdentifier = input.ReadString();
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
          case 8: {
            Code = (global::Rv.Data.HotKey.Types.KeyCode) input.ReadEnum();
            break;
          }
          case 18: {
            ControlIdentifier = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the HotKey message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum KeyCode {
        [pbr::OriginalName("KEY_CODE_UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("KEY_CODE_ANSI_A")] AnsiA = 1,
        [pbr::OriginalName("KEY_CODE_ANSI_B")] AnsiB = 2,
        [pbr::OriginalName("KEY_CODE_ANSI_C")] AnsiC = 3,
        [pbr::OriginalName("KEY_CODE_ANSI_D")] AnsiD = 4,
        [pbr::OriginalName("KEY_CODE_ANSI_E")] AnsiE = 5,
        [pbr::OriginalName("KEY_CODE_ANSI_F")] AnsiF = 6,
        [pbr::OriginalName("KEY_CODE_ANSI_G")] AnsiG = 7,
        [pbr::OriginalName("KEY_CODE_ANSI_H")] AnsiH = 8,
        [pbr::OriginalName("KEY_CODE_ANSI_I")] AnsiI = 9,
        [pbr::OriginalName("KEY_CODE_ANSI_J")] AnsiJ = 10,
        [pbr::OriginalName("KEY_CODE_ANSI_K")] AnsiK = 11,
        [pbr::OriginalName("KEY_CODE_ANSI_L")] AnsiL = 12,
        [pbr::OriginalName("KEY_CODE_ANSI_M")] AnsiM = 13,
        [pbr::OriginalName("KEY_CODE_ANSI_N")] AnsiN = 14,
        [pbr::OriginalName("KEY_CODE_ANSI_O")] AnsiO = 15,
        [pbr::OriginalName("KEY_CODE_ANSI_P")] AnsiP = 16,
        [pbr::OriginalName("KEY_CODE_ANSI_Q")] AnsiQ = 17,
        [pbr::OriginalName("KEY_CODE_ANSI_R")] AnsiR = 18,
        [pbr::OriginalName("KEY_CODE_ANSI_S")] AnsiS = 19,
        [pbr::OriginalName("KEY_CODE_ANSI_T")] AnsiT = 20,
        [pbr::OriginalName("KEY_CODE_ANSI_U")] AnsiU = 21,
        [pbr::OriginalName("KEY_CODE_ANSI_V")] AnsiV = 22,
        [pbr::OriginalName("KEY_CODE_ANSI_W")] AnsiW = 23,
        [pbr::OriginalName("KEY_CODE_ANSI_X")] AnsiX = 24,
        [pbr::OriginalName("KEY_CODE_ANSI_Y")] AnsiY = 25,
        [pbr::OriginalName("KEY_CODE_ANSI_Z")] AnsiZ = 26,
        [pbr::OriginalName("KEY_CODE_ANSI_0")] Ansi0 = 27,
        [pbr::OriginalName("KEY_CODE_ANSI_1")] Ansi1 = 28,
        [pbr::OriginalName("KEY_CODE_ANSI_2")] Ansi2 = 29,
        [pbr::OriginalName("KEY_CODE_ANSI_3")] Ansi3 = 30,
        [pbr::OriginalName("KEY_CODE_ANSI_4")] Ansi4 = 31,
        [pbr::OriginalName("KEY_CODE_ANSI_5")] Ansi5 = 32,
        [pbr::OriginalName("KEY_CODE_ANSI_6")] Ansi6 = 33,
        [pbr::OriginalName("KEY_CODE_ANSI_7")] Ansi7 = 34,
        [pbr::OriginalName("KEY_CODE_ANSI_8")] Ansi8 = 35,
        [pbr::OriginalName("KEY_CODE_ANSI_9")] Ansi9 = 36,
        [pbr::OriginalName("KEY_CODE_ANSI_EQUAL")] AnsiEqual = 37,
        [pbr::OriginalName("KEY_CODE_ANSI_MINUS")] AnsiMinus = 38,
        [pbr::OriginalName("KEY_CODE_ANSI_RIGHT_BRACKET")] AnsiRightBracket = 39,
        [pbr::OriginalName("KEY_CODE_ANSI_LEFT_BRACKET")] AnsiLeftBracket = 40,
        [pbr::OriginalName("KEY_CODE_ANSI_QUOTE")] AnsiQuote = 41,
        [pbr::OriginalName("KEY_CODE_ANSI_SEMICOLON")] AnsiSemicolon = 42,
        [pbr::OriginalName("KEY_CODE_ANSI_BACKSLASH")] AnsiBackslash = 43,
        [pbr::OriginalName("KEY_CODE_ANSI_COMMA")] AnsiComma = 44,
        [pbr::OriginalName("KEY_CODE_ANSI_SLASH")] AnsiSlash = 45,
        [pbr::OriginalName("KEY_CODE_ANSI_PERIOD")] AnsiPeriod = 46,
        [pbr::OriginalName("KEY_CODE_ANSI_GRAVE")] AnsiGrave = 47,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_DECIMAL")] AnsiKeypadDecimal = 48,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_PLUS")] AnsiKeypadPlus = 49,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_CLEAR")] AnsiKeypadClear = 50,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_DIVIDE")] AnsiKeypadDivide = 51,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_ENTER")] AnsiKeypadEnter = 52,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_MINUS")] AnsiKeypadMinus = 53,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_EQUALS")] AnsiKeypadEquals = 54,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_0")] AnsiKeypad0 = 55,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_1")] AnsiKeypad1 = 56,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_2")] AnsiKeypad2 = 57,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_3")] AnsiKeypad3 = 58,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_4")] AnsiKeypad4 = 59,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_5")] AnsiKeypad5 = 60,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_6")] AnsiKeypad6 = 61,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_7")] AnsiKeypad7 = 62,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_8")] AnsiKeypad8 = 63,
        [pbr::OriginalName("KEY_CODE_ANSI_KEYPAD_9")] AnsiKeypad9 = 64,
        [pbr::OriginalName("KEY_CODE_F1")] F1 = 65,
        [pbr::OriginalName("KEY_CODE_F2")] F2 = 66,
        [pbr::OriginalName("KEY_CODE_F3")] F3 = 67,
        [pbr::OriginalName("KEY_CODE_F4")] F4 = 68,
        [pbr::OriginalName("KEY_CODE_F5")] F5 = 69,
        [pbr::OriginalName("KEY_CODE_F6")] F6 = 70,
        [pbr::OriginalName("KEY_CODE_F7")] F7 = 71,
        [pbr::OriginalName("KEY_CODE_F8")] F8 = 72,
        [pbr::OriginalName("KEY_CODE_F9")] F9 = 73,
        [pbr::OriginalName("KEY_CODE_F10")] F10 = 74,
        [pbr::OriginalName("KEY_CODE_F11")] F11 = 75,
        [pbr::OriginalName("KEY_CODE_F12")] F12 = 76,
        [pbr::OriginalName("KEY_CODE_F13")] F13 = 77,
        [pbr::OriginalName("KEY_CODE_F14")] F14 = 78,
        [pbr::OriginalName("KEY_CODE_F15")] F15 = 79,
        [pbr::OriginalName("KEY_CODE_F16")] F16 = 80,
        [pbr::OriginalName("KEY_CODE_F17")] F17 = 81,
        [pbr::OriginalName("KEY_CODE_F18")] F18 = 82,
        [pbr::OriginalName("KEY_CODE_F19")] F19 = 83,
        [pbr::OriginalName("KEY_CODE_F20")] F20 = 84,
        [pbr::OriginalName("KEY_CODE_FUNCTION")] Function = 85,
        [pbr::OriginalName("KEY_CODE_RETURN")] Return = 86,
        [pbr::OriginalName("KEY_CODE_TAB")] Tab = 87,
        [pbr::OriginalName("KEY_CODE_SPACE")] Space = 88,
        [pbr::OriginalName("KEY_CODE_DELETE")] Delete = 89,
        [pbr::OriginalName("KEY_CODE_ESCAPE")] Escape = 90,
        [pbr::OriginalName("KEY_CODE_COMMAND")] Command = 91,
        [pbr::OriginalName("KEY_CODE_SHIFT")] Shift = 92,
        [pbr::OriginalName("KEY_CODE_CAPS_LOCK")] CapsLock = 93,
        [pbr::OriginalName("KEY_CODE_OPTION")] Option = 94,
        [pbr::OriginalName("KEY_CODE_CONTROL")] Control = 95,
        [pbr::OriginalName("KEY_CODE_RIGHT_SHIFT")] RightShift = 96,
        [pbr::OriginalName("KEY_CODE_RIGHT_OPTION")] RightOption = 97,
        [pbr::OriginalName("KEY_CODE_RIGHT_CONTROL")] RightControl = 98,
        [pbr::OriginalName("KEY_CODE_VOLUME_UP")] VolumeUp = 99,
        [pbr::OriginalName("KEY_CODE_VOLUME_DOWN")] VolumeDown = 100,
        [pbr::OriginalName("KEY_CODE_MUTE")] Mute = 101,
        [pbr::OriginalName("KEY_CODE_HELP")] Help = 102,
        [pbr::OriginalName("KEY_CODE_HOME")] Home = 103,
        [pbr::OriginalName("KEY_CODE_PAGE_UP")] PageUp = 104,
        [pbr::OriginalName("KEY_CODE_FORWARD_DELETE")] ForwardDelete = 105,
        [pbr::OriginalName("KEY_CODE_END")] End = 106,
        [pbr::OriginalName("KEY_CODE_PAGE_DOWN")] PageDown = 107,
        [pbr::OriginalName("KEY_CODE_LEFT_ARROW")] LeftArrow = 108,
        [pbr::OriginalName("KEY_CODE_RIGHT_ARROW")] RightArrow = 109,
        [pbr::OriginalName("KEY_CODE_DOWN_ARROW")] DownArrow = 110,
        [pbr::OriginalName("KEY_CODE_UP_ARROW")] UpArrow = 111,
        [pbr::OriginalName("KEY_CODE_ISO_SELECTION")] IsoSelection = 112,
        [pbr::OriginalName("KEY_CODE_JIS_YEN")] JisYen = 113,
        [pbr::OriginalName("KEY_CODE_JIS_UNDERSCORE")] JisUnderscore = 114,
        [pbr::OriginalName("KEY_CODE_JIS_KEYPAD_COMMA")] JisKeypadComma = 115,
        [pbr::OriginalName("KEY_CODE_JIS_EISU")] JisEisu = 116,
        [pbr::OriginalName("KEY_CODE_JIS_KANA")] JisKana = 117,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
