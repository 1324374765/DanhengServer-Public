// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TravelBrochureSelectMessageCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TravelBrochureSelectMessageCsReq.proto</summary>
  public static partial class TravelBrochureSelectMessageCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TravelBrochureSelectMessageCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TravelBrochureSelectMessageCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZUcmF2ZWxCcm9jaHVyZVNlbGVjdE1lc3NhZ2VDc1JlcS5wcm90byJMCiBU",
            "cmF2ZWxCcm9jaHVyZVNlbGVjdE1lc3NhZ2VDc1JlcRITCgtPR0hGS0RBTkJO",
            "ShgPIAEoDRITCgtFQkpLSERBSUtDSxgBIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TravelBrochureSelectMessageCsReq), global::EggLink.DanhengServer.Proto.TravelBrochureSelectMessageCsReq.Parser, new[]{ "OGHFKDANBNJ", "EBJKHDAIKCK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TravelBrochureSelectMessageCsReq : pb::IMessage<TravelBrochureSelectMessageCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TravelBrochureSelectMessageCsReq> _parser = new pb::MessageParser<TravelBrochureSelectMessageCsReq>(() => new TravelBrochureSelectMessageCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TravelBrochureSelectMessageCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TravelBrochureSelectMessageCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureSelectMessageCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureSelectMessageCsReq(TravelBrochureSelectMessageCsReq other) : this() {
      oGHFKDANBNJ_ = other.oGHFKDANBNJ_;
      eBJKHDAIKCK_ = other.eBJKHDAIKCK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureSelectMessageCsReq Clone() {
      return new TravelBrochureSelectMessageCsReq(this);
    }

    /// <summary>Field number for the "OGHFKDANBNJ" field.</summary>
    public const int OGHFKDANBNJFieldNumber = 15;
    private uint oGHFKDANBNJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OGHFKDANBNJ {
      get { return oGHFKDANBNJ_; }
      set {
        oGHFKDANBNJ_ = value;
      }
    }

    /// <summary>Field number for the "EBJKHDAIKCK" field.</summary>
    public const int EBJKHDAIKCKFieldNumber = 1;
    private uint eBJKHDAIKCK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EBJKHDAIKCK {
      get { return eBJKHDAIKCK_; }
      set {
        eBJKHDAIKCK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TravelBrochureSelectMessageCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TravelBrochureSelectMessageCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OGHFKDANBNJ != other.OGHFKDANBNJ) return false;
      if (EBJKHDAIKCK != other.EBJKHDAIKCK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OGHFKDANBNJ != 0) hash ^= OGHFKDANBNJ.GetHashCode();
      if (EBJKHDAIKCK != 0) hash ^= EBJKHDAIKCK.GetHashCode();
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
      if (EBJKHDAIKCK != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EBJKHDAIKCK);
      }
      if (OGHFKDANBNJ != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OGHFKDANBNJ);
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
      if (EBJKHDAIKCK != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EBJKHDAIKCK);
      }
      if (OGHFKDANBNJ != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OGHFKDANBNJ);
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
      if (OGHFKDANBNJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OGHFKDANBNJ);
      }
      if (EBJKHDAIKCK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EBJKHDAIKCK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TravelBrochureSelectMessageCsReq other) {
      if (other == null) {
        return;
      }
      if (other.OGHFKDANBNJ != 0) {
        OGHFKDANBNJ = other.OGHFKDANBNJ;
      }
      if (other.EBJKHDAIKCK != 0) {
        EBJKHDAIKCK = other.EBJKHDAIKCK;
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
            EBJKHDAIKCK = input.ReadUInt32();
            break;
          }
          case 120: {
            OGHFKDANBNJ = input.ReadUInt32();
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
            EBJKHDAIKCK = input.ReadUInt32();
            break;
          }
          case 120: {
            OGHFKDANBNJ = input.ReadUInt32();
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