// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetRogueShopMiracleInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetRogueShopMiracleInfoScRsp.proto</summary>
  public static partial class GetRogueShopMiracleInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetRogueShopMiracleInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetRogueShopMiracleInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJHZXRSb2d1ZVNob3BNaXJhY2xlSW5mb1NjUnNwLnByb3RvGhJJdGVtQ29z",
            "dERhdGEucHJvdG8aEUdDREFPSk5PQ0tKLnByb3RvIpEBChxHZXRSb2d1ZVNo",
            "b3BNaXJhY2xlSW5mb1NjUnNwEicKEWdhbWVfbWlyYWNsZV9pbmZvGAUgASgL",
            "MgwuR0NEQU9KTk9DS0oSDwoHcmV0Y29kZRgHIAEoDRITCgtLTUFHSUpBRU9I",
            "RBgMIAEoCBIiCgtKRE1LQk9GRkxGQRgCIAEoCzINLkl0ZW1Db3N0RGF0YUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.GCDAOJNOCKJReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetRogueShopMiracleInfoScRsp), global::EggLink.DanhengServer.Proto.GetRogueShopMiracleInfoScRsp.Parser, new[]{ "GameMiracleInfo", "Retcode", "KMAGIJAEOHD", "JDMKBOFFLFA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetRogueShopMiracleInfoScRsp : pb::IMessage<GetRogueShopMiracleInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetRogueShopMiracleInfoScRsp> _parser = new pb::MessageParser<GetRogueShopMiracleInfoScRsp>(() => new GetRogueShopMiracleInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetRogueShopMiracleInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetRogueShopMiracleInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRogueShopMiracleInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRogueShopMiracleInfoScRsp(GetRogueShopMiracleInfoScRsp other) : this() {
      gameMiracleInfo_ = other.gameMiracleInfo_ != null ? other.gameMiracleInfo_.Clone() : null;
      retcode_ = other.retcode_;
      kMAGIJAEOHD_ = other.kMAGIJAEOHD_;
      jDMKBOFFLFA_ = other.jDMKBOFFLFA_ != null ? other.jDMKBOFFLFA_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRogueShopMiracleInfoScRsp Clone() {
      return new GetRogueShopMiracleInfoScRsp(this);
    }

    /// <summary>Field number for the "game_miracle_info" field.</summary>
    public const int GameMiracleInfoFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.GCDAOJNOCKJ gameMiracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GCDAOJNOCKJ GameMiracleInfo {
      get { return gameMiracleInfo_; }
      set {
        gameMiracleInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "KMAGIJAEOHD" field.</summary>
    public const int KMAGIJAEOHDFieldNumber = 12;
    private bool kMAGIJAEOHD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KMAGIJAEOHD {
      get { return kMAGIJAEOHD_; }
      set {
        kMAGIJAEOHD_ = value;
      }
    }

    /// <summary>Field number for the "JDMKBOFFLFA" field.</summary>
    public const int JDMKBOFFLFAFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.ItemCostData jDMKBOFFLFA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData JDMKBOFFLFA {
      get { return jDMKBOFFLFA_; }
      set {
        jDMKBOFFLFA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetRogueShopMiracleInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetRogueShopMiracleInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GameMiracleInfo, other.GameMiracleInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (KMAGIJAEOHD != other.KMAGIJAEOHD) return false;
      if (!object.Equals(JDMKBOFFLFA, other.JDMKBOFFLFA)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (gameMiracleInfo_ != null) hash ^= GameMiracleInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (KMAGIJAEOHD != false) hash ^= KMAGIJAEOHD.GetHashCode();
      if (jDMKBOFFLFA_ != null) hash ^= JDMKBOFFLFA.GetHashCode();
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
      if (jDMKBOFFLFA_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(JDMKBOFFLFA);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(GameMiracleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (KMAGIJAEOHD != false) {
        output.WriteRawTag(96);
        output.WriteBool(KMAGIJAEOHD);
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
      if (jDMKBOFFLFA_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(JDMKBOFFLFA);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(GameMiracleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (KMAGIJAEOHD != false) {
        output.WriteRawTag(96);
        output.WriteBool(KMAGIJAEOHD);
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
      if (gameMiracleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameMiracleInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (KMAGIJAEOHD != false) {
        size += 1 + 1;
      }
      if (jDMKBOFFLFA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JDMKBOFFLFA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetRogueShopMiracleInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.gameMiracleInfo_ != null) {
        if (gameMiracleInfo_ == null) {
          GameMiracleInfo = new global::EggLink.DanhengServer.Proto.GCDAOJNOCKJ();
        }
        GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.KMAGIJAEOHD != false) {
        KMAGIJAEOHD = other.KMAGIJAEOHD;
      }
      if (other.jDMKBOFFLFA_ != null) {
        if (jDMKBOFFLFA_ == null) {
          JDMKBOFFLFA = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        JDMKBOFFLFA.MergeFrom(other.JDMKBOFFLFA);
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
          case 18: {
            if (jDMKBOFFLFA_ == null) {
              JDMKBOFFLFA = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(JDMKBOFFLFA);
            break;
          }
          case 42: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.GCDAOJNOCKJ();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 96: {
            KMAGIJAEOHD = input.ReadBool();
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
          case 18: {
            if (jDMKBOFFLFA_ == null) {
              JDMKBOFFLFA = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(JDMKBOFFLFA);
            break;
          }
          case 42: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.GCDAOJNOCKJ();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 96: {
            KMAGIJAEOHD = input.ReadBool();
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