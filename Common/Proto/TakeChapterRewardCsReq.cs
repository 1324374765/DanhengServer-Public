// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeChapterRewardCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeChapterRewardCsReq.proto</summary>
  public static partial class TakeChapterRewardCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeChapterRewardCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeChapterRewardCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxUYWtlQ2hhcHRlclJld2FyZENzUmVxLnByb3RvIkIKFlRha2VDaGFwdGVy",
            "UmV3YXJkQ3NSZXESEwoLT05CRE9CT0dBQUEYCyABKA0SEwoLRklOQ0xDTkZH",
            "TUEYDSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeChapterRewardCsReq), global::EggLink.DanhengServer.Proto.TakeChapterRewardCsReq.Parser, new[]{ "ONBDOBOGAAA", "FINCLCNFGMA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeChapterRewardCsReq : pb::IMessage<TakeChapterRewardCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeChapterRewardCsReq> _parser = new pb::MessageParser<TakeChapterRewardCsReq>(() => new TakeChapterRewardCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeChapterRewardCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeChapterRewardCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeChapterRewardCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeChapterRewardCsReq(TakeChapterRewardCsReq other) : this() {
      oNBDOBOGAAA_ = other.oNBDOBOGAAA_;
      fINCLCNFGMA_ = other.fINCLCNFGMA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeChapterRewardCsReq Clone() {
      return new TakeChapterRewardCsReq(this);
    }

    /// <summary>Field number for the "ONBDOBOGAAA" field.</summary>
    public const int ONBDOBOGAAAFieldNumber = 11;
    private uint oNBDOBOGAAA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ONBDOBOGAAA {
      get { return oNBDOBOGAAA_; }
      set {
        oNBDOBOGAAA_ = value;
      }
    }

    /// <summary>Field number for the "FINCLCNFGMA" field.</summary>
    public const int FINCLCNFGMAFieldNumber = 13;
    private uint fINCLCNFGMA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FINCLCNFGMA {
      get { return fINCLCNFGMA_; }
      set {
        fINCLCNFGMA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeChapterRewardCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeChapterRewardCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ONBDOBOGAAA != other.ONBDOBOGAAA) return false;
      if (FINCLCNFGMA != other.FINCLCNFGMA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ONBDOBOGAAA != 0) hash ^= ONBDOBOGAAA.GetHashCode();
      if (FINCLCNFGMA != 0) hash ^= FINCLCNFGMA.GetHashCode();
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
      if (ONBDOBOGAAA != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ONBDOBOGAAA);
      }
      if (FINCLCNFGMA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FINCLCNFGMA);
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
      if (ONBDOBOGAAA != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ONBDOBOGAAA);
      }
      if (FINCLCNFGMA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FINCLCNFGMA);
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
      if (ONBDOBOGAAA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ONBDOBOGAAA);
      }
      if (FINCLCNFGMA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FINCLCNFGMA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeChapterRewardCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ONBDOBOGAAA != 0) {
        ONBDOBOGAAA = other.ONBDOBOGAAA;
      }
      if (other.FINCLCNFGMA != 0) {
        FINCLCNFGMA = other.FINCLCNFGMA;
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
          case 88: {
            ONBDOBOGAAA = input.ReadUInt32();
            break;
          }
          case 104: {
            FINCLCNFGMA = input.ReadUInt32();
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
          case 88: {
            ONBDOBOGAAA = input.ReadUInt32();
            break;
          }
          case 104: {
            FINCLCNFGMA = input.ReadUInt32();
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