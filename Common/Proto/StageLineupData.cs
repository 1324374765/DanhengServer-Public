// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StageLineupData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StageLineupData.proto</summary>
  public static partial class StageLineupDataReflection {

    #region Descriptor
    /// <summary>File descriptor for StageLineupData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StageLineupDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTdGFnZUxpbmV1cERhdGEucHJvdG8iOwoPU3RhZ2VMaW5ldXBEYXRhEhMK",
            "C01BT0lFRU1ES0FPGA8gASgNEhMKC0FIS0lPR01JTExOGAEgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StageLineupData), global::EggLink.DanhengServer.Proto.StageLineupData.Parser, new[]{ "MAOIEEMDKAO", "AHKIOGMILLN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StageLineupData : pb::IMessage<StageLineupData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StageLineupData> _parser = new pb::MessageParser<StageLineupData>(() => new StageLineupData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StageLineupData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StageLineupDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StageLineupData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StageLineupData(StageLineupData other) : this() {
      mAOIEEMDKAO_ = other.mAOIEEMDKAO_;
      aHKIOGMILLN_ = other.aHKIOGMILLN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StageLineupData Clone() {
      return new StageLineupData(this);
    }

    /// <summary>Field number for the "MAOIEEMDKAO" field.</summary>
    public const int MAOIEEMDKAOFieldNumber = 15;
    private uint mAOIEEMDKAO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MAOIEEMDKAO {
      get { return mAOIEEMDKAO_; }
      set {
        mAOIEEMDKAO_ = value;
      }
    }

    /// <summary>Field number for the "AHKIOGMILLN" field.</summary>
    public const int AHKIOGMILLNFieldNumber = 1;
    private uint aHKIOGMILLN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AHKIOGMILLN {
      get { return aHKIOGMILLN_; }
      set {
        aHKIOGMILLN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StageLineupData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StageLineupData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MAOIEEMDKAO != other.MAOIEEMDKAO) return false;
      if (AHKIOGMILLN != other.AHKIOGMILLN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MAOIEEMDKAO != 0) hash ^= MAOIEEMDKAO.GetHashCode();
      if (AHKIOGMILLN != 0) hash ^= AHKIOGMILLN.GetHashCode();
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
      if (AHKIOGMILLN != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AHKIOGMILLN);
      }
      if (MAOIEEMDKAO != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MAOIEEMDKAO);
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
      if (AHKIOGMILLN != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AHKIOGMILLN);
      }
      if (MAOIEEMDKAO != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MAOIEEMDKAO);
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
      if (MAOIEEMDKAO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MAOIEEMDKAO);
      }
      if (AHKIOGMILLN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AHKIOGMILLN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StageLineupData other) {
      if (other == null) {
        return;
      }
      if (other.MAOIEEMDKAO != 0) {
        MAOIEEMDKAO = other.MAOIEEMDKAO;
      }
      if (other.AHKIOGMILLN != 0) {
        AHKIOGMILLN = other.AHKIOGMILLN;
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
            AHKIOGMILLN = input.ReadUInt32();
            break;
          }
          case 120: {
            MAOIEEMDKAO = input.ReadUInt32();
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
            AHKIOGMILLN = input.ReadUInt32();
            break;
          }
          case 120: {
            MAOIEEMDKAO = input.ReadUInt32();
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