// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HBPLKCPLECE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HBPLKCPLECE.proto</summary>
  public static partial class HBPLKCPLECEReflection {

    #region Descriptor
    /// <summary>File descriptor for HBPLKCPLECE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HBPLKCPLECEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIQlBMS0NQTEVDRS5wcm90bxoRSERFREJQTkVGSUQucHJvdG8iVQoLSEJQ",
            "TEtDUExFQ0USGgoEdHlwZRgBIAEoDjIMLkhERURCUE5FRklEEhMKC01JREtI",
            "UFBLR0NKGAIgASgNEhUKDWRpc3BsYXlfdmFsdWUYAyABKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HDEDBPNEFIDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HBPLKCPLECE), global::EggLink.DanhengServer.Proto.HBPLKCPLECE.Parser, new[]{ "Type", "MIDKHPPKGCJ", "DisplayValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HBPLKCPLECE : pb::IMessage<HBPLKCPLECE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HBPLKCPLECE> _parser = new pb::MessageParser<HBPLKCPLECE>(() => new HBPLKCPLECE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HBPLKCPLECE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HBPLKCPLECEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HBPLKCPLECE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HBPLKCPLECE(HBPLKCPLECE other) : this() {
      type_ = other.type_;
      mIDKHPPKGCJ_ = other.mIDKHPPKGCJ_;
      displayValue_ = other.displayValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HBPLKCPLECE Clone() {
      return new HBPLKCPLECE(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.HDEDBPNEFID type_ = global::EggLink.DanhengServer.Proto.HDEDBPNEFID.BattleStaticticEventNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HDEDBPNEFID Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "MIDKHPPKGCJ" field.</summary>
    public const int MIDKHPPKGCJFieldNumber = 2;
    private uint mIDKHPPKGCJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MIDKHPPKGCJ {
      get { return mIDKHPPKGCJ_; }
      set {
        mIDKHPPKGCJ_ = value;
      }
    }

    /// <summary>Field number for the "display_value" field.</summary>
    public const int DisplayValueFieldNumber = 3;
    private uint displayValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DisplayValue {
      get { return displayValue_; }
      set {
        displayValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HBPLKCPLECE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HBPLKCPLECE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (MIDKHPPKGCJ != other.MIDKHPPKGCJ) return false;
      if (DisplayValue != other.DisplayValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::EggLink.DanhengServer.Proto.HDEDBPNEFID.BattleStaticticEventNone) hash ^= Type.GetHashCode();
      if (MIDKHPPKGCJ != 0) hash ^= MIDKHPPKGCJ.GetHashCode();
      if (DisplayValue != 0) hash ^= DisplayValue.GetHashCode();
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
      if (Type != global::EggLink.DanhengServer.Proto.HDEDBPNEFID.BattleStaticticEventNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (MIDKHPPKGCJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MIDKHPPKGCJ);
      }
      if (DisplayValue != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DisplayValue);
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
      if (Type != global::EggLink.DanhengServer.Proto.HDEDBPNEFID.BattleStaticticEventNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (MIDKHPPKGCJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MIDKHPPKGCJ);
      }
      if (DisplayValue != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DisplayValue);
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
      if (Type != global::EggLink.DanhengServer.Proto.HDEDBPNEFID.BattleStaticticEventNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (MIDKHPPKGCJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MIDKHPPKGCJ);
      }
      if (DisplayValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DisplayValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HBPLKCPLECE other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.HDEDBPNEFID.BattleStaticticEventNone) {
        Type = other.Type;
      }
      if (other.MIDKHPPKGCJ != 0) {
        MIDKHPPKGCJ = other.MIDKHPPKGCJ;
      }
      if (other.DisplayValue != 0) {
        DisplayValue = other.DisplayValue;
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
            Type = (global::EggLink.DanhengServer.Proto.HDEDBPNEFID) input.ReadEnum();
            break;
          }
          case 16: {
            MIDKHPPKGCJ = input.ReadUInt32();
            break;
          }
          case 24: {
            DisplayValue = input.ReadUInt32();
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
            Type = (global::EggLink.DanhengServer.Proto.HDEDBPNEFID) input.ReadEnum();
            break;
          }
          case 16: {
            MIDKHPPKGCJ = input.ReadUInt32();
            break;
          }
          case 24: {
            DisplayValue = input.ReadUInt32();
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