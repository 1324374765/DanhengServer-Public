// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueSelectBpScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueSelectBpScRsp.proto</summary>
  public static partial class ChessRogueSelectBpScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueSelectBpScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueSelectBpScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1DaGVzc1JvZ3VlU2VsZWN0QnBTY1JzcC5wcm90bxoRSElPRkpPRU5KRE4u",
            "cHJvdG8iYgoXQ2hlc3NSb2d1ZVNlbGVjdEJwU2NSc3ASEwoLQUxLTk1QTVBG",
            "R0gYBiABKA0SDwoHcmV0Y29kZRgDIAEoDRIhCgtLSEVETUhDR05CQhgBIAEo",
            "CzIMLkhJT0ZKT0VOSkROQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HIOFJOENJDNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueSelectBpScRsp), global::EggLink.DanhengServer.Proto.ChessRogueSelectBpScRsp.Parser, new[]{ "ALKNMPMPFGH", "Retcode", "KHEDMHCGNBB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueSelectBpScRsp : pb::IMessage<ChessRogueSelectBpScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueSelectBpScRsp> _parser = new pb::MessageParser<ChessRogueSelectBpScRsp>(() => new ChessRogueSelectBpScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueSelectBpScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueSelectBpScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueSelectBpScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueSelectBpScRsp(ChessRogueSelectBpScRsp other) : this() {
      aLKNMPMPFGH_ = other.aLKNMPMPFGH_;
      retcode_ = other.retcode_;
      kHEDMHCGNBB_ = other.kHEDMHCGNBB_ != null ? other.kHEDMHCGNBB_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueSelectBpScRsp Clone() {
      return new ChessRogueSelectBpScRsp(this);
    }

    /// <summary>Field number for the "ALKNMPMPFGH" field.</summary>
    public const int ALKNMPMPFGHFieldNumber = 6;
    private uint aLKNMPMPFGH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ALKNMPMPFGH {
      get { return aLKNMPMPFGH_; }
      set {
        aLKNMPMPFGH_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "KHEDMHCGNBB" field.</summary>
    public const int KHEDMHCGNBBFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.HIOFJOENJDN kHEDMHCGNBB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HIOFJOENJDN KHEDMHCGNBB {
      get { return kHEDMHCGNBB_; }
      set {
        kHEDMHCGNBB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueSelectBpScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueSelectBpScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ALKNMPMPFGH != other.ALKNMPMPFGH) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(KHEDMHCGNBB, other.KHEDMHCGNBB)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ALKNMPMPFGH != 0) hash ^= ALKNMPMPFGH.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (kHEDMHCGNBB_ != null) hash ^= KHEDMHCGNBB.GetHashCode();
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
      if (kHEDMHCGNBB_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(KHEDMHCGNBB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (ALKNMPMPFGH != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ALKNMPMPFGH);
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
      if (kHEDMHCGNBB_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(KHEDMHCGNBB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (ALKNMPMPFGH != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ALKNMPMPFGH);
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
      if (ALKNMPMPFGH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ALKNMPMPFGH);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (kHEDMHCGNBB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KHEDMHCGNBB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueSelectBpScRsp other) {
      if (other == null) {
        return;
      }
      if (other.ALKNMPMPFGH != 0) {
        ALKNMPMPFGH = other.ALKNMPMPFGH;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.kHEDMHCGNBB_ != null) {
        if (kHEDMHCGNBB_ == null) {
          KHEDMHCGNBB = new global::EggLink.DanhengServer.Proto.HIOFJOENJDN();
        }
        KHEDMHCGNBB.MergeFrom(other.KHEDMHCGNBB);
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
            if (kHEDMHCGNBB_ == null) {
              KHEDMHCGNBB = new global::EggLink.DanhengServer.Proto.HIOFJOENJDN();
            }
            input.ReadMessage(KHEDMHCGNBB);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            ALKNMPMPFGH = input.ReadUInt32();
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
            if (kHEDMHCGNBB_ == null) {
              KHEDMHCGNBB = new global::EggLink.DanhengServer.Proto.HIOFJOENJDN();
            }
            input.ReadMessage(KHEDMHCGNBB);
            break;
          }
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            ALKNMPMPFGH = input.ReadUInt32();
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