// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FGOIANHPJHH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FGOIANHPJHH.proto</summary>
  public static partial class FGOIANHPJHHReflection {

    #region Descriptor
    /// <summary>File descriptor for FGOIANHPJHH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FGOIANHPJHHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGR09JQU5IUEpISC5wcm90byJhCgtGR09JQU5IUEpISBITCgtGTkFBQUtK",
            "RkdCShgDIAEoCBITCgtNS0tFS0dNTUNOQhgGIAEoDRITCgtOQkhDTU9MRENM",
            "TBgPIAEoDRITCgtITU5GT05FS0tFRRgEIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FGOIANHPJHH), global::EggLink.DanhengServer.Proto.FGOIANHPJHH.Parser, new[]{ "FNAAAKJFGBJ", "MKKEKGMMCNB", "NBHCMOLDCLL", "HMNFONEKKEE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FGOIANHPJHH : pb::IMessage<FGOIANHPJHH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FGOIANHPJHH> _parser = new pb::MessageParser<FGOIANHPJHH>(() => new FGOIANHPJHH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FGOIANHPJHH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FGOIANHPJHHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FGOIANHPJHH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FGOIANHPJHH(FGOIANHPJHH other) : this() {
      fNAAAKJFGBJ_ = other.fNAAAKJFGBJ_;
      mKKEKGMMCNB_ = other.mKKEKGMMCNB_;
      nBHCMOLDCLL_ = other.nBHCMOLDCLL_;
      hMNFONEKKEE_ = other.hMNFONEKKEE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FGOIANHPJHH Clone() {
      return new FGOIANHPJHH(this);
    }

    /// <summary>Field number for the "FNAAAKJFGBJ" field.</summary>
    public const int FNAAAKJFGBJFieldNumber = 3;
    private bool fNAAAKJFGBJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FNAAAKJFGBJ {
      get { return fNAAAKJFGBJ_; }
      set {
        fNAAAKJFGBJ_ = value;
      }
    }

    /// <summary>Field number for the "MKKEKGMMCNB" field.</summary>
    public const int MKKEKGMMCNBFieldNumber = 6;
    private uint mKKEKGMMCNB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MKKEKGMMCNB {
      get { return mKKEKGMMCNB_; }
      set {
        mKKEKGMMCNB_ = value;
      }
    }

    /// <summary>Field number for the "NBHCMOLDCLL" field.</summary>
    public const int NBHCMOLDCLLFieldNumber = 15;
    private uint nBHCMOLDCLL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NBHCMOLDCLL {
      get { return nBHCMOLDCLL_; }
      set {
        nBHCMOLDCLL_ = value;
      }
    }

    /// <summary>Field number for the "HMNFONEKKEE" field.</summary>
    public const int HMNFONEKKEEFieldNumber = 4;
    private uint hMNFONEKKEE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HMNFONEKKEE {
      get { return hMNFONEKKEE_; }
      set {
        hMNFONEKKEE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FGOIANHPJHH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FGOIANHPJHH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FNAAAKJFGBJ != other.FNAAAKJFGBJ) return false;
      if (MKKEKGMMCNB != other.MKKEKGMMCNB) return false;
      if (NBHCMOLDCLL != other.NBHCMOLDCLL) return false;
      if (HMNFONEKKEE != other.HMNFONEKKEE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FNAAAKJFGBJ != false) hash ^= FNAAAKJFGBJ.GetHashCode();
      if (MKKEKGMMCNB != 0) hash ^= MKKEKGMMCNB.GetHashCode();
      if (NBHCMOLDCLL != 0) hash ^= NBHCMOLDCLL.GetHashCode();
      if (HMNFONEKKEE != 0) hash ^= HMNFONEKKEE.GetHashCode();
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
      if (FNAAAKJFGBJ != false) {
        output.WriteRawTag(24);
        output.WriteBool(FNAAAKJFGBJ);
      }
      if (HMNFONEKKEE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(HMNFONEKKEE);
      }
      if (MKKEKGMMCNB != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MKKEKGMMCNB);
      }
      if (NBHCMOLDCLL != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(NBHCMOLDCLL);
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
      if (FNAAAKJFGBJ != false) {
        output.WriteRawTag(24);
        output.WriteBool(FNAAAKJFGBJ);
      }
      if (HMNFONEKKEE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(HMNFONEKKEE);
      }
      if (MKKEKGMMCNB != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MKKEKGMMCNB);
      }
      if (NBHCMOLDCLL != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(NBHCMOLDCLL);
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
      if (FNAAAKJFGBJ != false) {
        size += 1 + 1;
      }
      if (MKKEKGMMCNB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MKKEKGMMCNB);
      }
      if (NBHCMOLDCLL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NBHCMOLDCLL);
      }
      if (HMNFONEKKEE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HMNFONEKKEE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FGOIANHPJHH other) {
      if (other == null) {
        return;
      }
      if (other.FNAAAKJFGBJ != false) {
        FNAAAKJFGBJ = other.FNAAAKJFGBJ;
      }
      if (other.MKKEKGMMCNB != 0) {
        MKKEKGMMCNB = other.MKKEKGMMCNB;
      }
      if (other.NBHCMOLDCLL != 0) {
        NBHCMOLDCLL = other.NBHCMOLDCLL;
      }
      if (other.HMNFONEKKEE != 0) {
        HMNFONEKKEE = other.HMNFONEKKEE;
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
          case 24: {
            FNAAAKJFGBJ = input.ReadBool();
            break;
          }
          case 32: {
            HMNFONEKKEE = input.ReadUInt32();
            break;
          }
          case 48: {
            MKKEKGMMCNB = input.ReadUInt32();
            break;
          }
          case 120: {
            NBHCMOLDCLL = input.ReadUInt32();
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
          case 24: {
            FNAAAKJFGBJ = input.ReadBool();
            break;
          }
          case 32: {
            HMNFONEKKEE = input.ReadUInt32();
            break;
          }
          case 48: {
            MKKEKGMMCNB = input.ReadUInt32();
            break;
          }
          case 120: {
            NBHCMOLDCLL = input.ReadUInt32();
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