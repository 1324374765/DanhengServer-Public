// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SyncRogueHandbookDataUpdateScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SyncRogueHandbookDataUpdateScNotify.proto</summary>
  public static partial class SyncRogueHandbookDataUpdateScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SyncRogueHandbookDataUpdateScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SyncRogueHandbookDataUpdateScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilTeW5jUm9ndWVIYW5kYm9va0RhdGFVcGRhdGVTY05vdGlmeS5wcm90bxoR",
            "RURQSExJTkFDTkoucHJvdG8aEUlGSlBMTE1ESFBMLnByb3RvGhFFR05DSkpK",
            "T0xKQS5wcm90byKOAQojU3luY1JvZ3VlSGFuZGJvb2tEYXRhVXBkYXRlU2NO",
            "b3RpZnkSIQoLT09JQUVKS0RLQ0YYDiADKAsyDC5FRFBITElOQUNOShIhCgtG",
            "TUZCT0JKRElFQxgIIAMoCzIMLklGSlBMTE1ESFBMEiEKC0tHSkZHTUxHT0NQ",
            "GAQgAygLMgwuRUdOQ0pKSk9MSkFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EDPHLINACNJReflection.Descriptor, global::EggLink.DanhengServer.Proto.IFJPLLMDHPLReflection.Descriptor, global::EggLink.DanhengServer.Proto.EGNCJJJOLJAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SyncRogueHandbookDataUpdateScNotify), global::EggLink.DanhengServer.Proto.SyncRogueHandbookDataUpdateScNotify.Parser, new[]{ "OOIAEJKDKCF", "FMFBOBJDIEC", "KGJFGMLGOCP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SyncRogueHandbookDataUpdateScNotify : pb::IMessage<SyncRogueHandbookDataUpdateScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SyncRogueHandbookDataUpdateScNotify> _parser = new pb::MessageParser<SyncRogueHandbookDataUpdateScNotify>(() => new SyncRogueHandbookDataUpdateScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SyncRogueHandbookDataUpdateScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SyncRogueHandbookDataUpdateScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueHandbookDataUpdateScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueHandbookDataUpdateScNotify(SyncRogueHandbookDataUpdateScNotify other) : this() {
      oOIAEJKDKCF_ = other.oOIAEJKDKCF_.Clone();
      fMFBOBJDIEC_ = other.fMFBOBJDIEC_.Clone();
      kGJFGMLGOCP_ = other.kGJFGMLGOCP_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncRogueHandbookDataUpdateScNotify Clone() {
      return new SyncRogueHandbookDataUpdateScNotify(this);
    }

    /// <summary>Field number for the "OOIAEJKDKCF" field.</summary>
    public const int OOIAEJKDKCFFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EDPHLINACNJ> _repeated_oOIAEJKDKCF_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.EDPHLINACNJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EDPHLINACNJ> oOIAEJKDKCF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EDPHLINACNJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EDPHLINACNJ> OOIAEJKDKCF {
      get { return oOIAEJKDKCF_; }
    }

    /// <summary>Field number for the "FMFBOBJDIEC" field.</summary>
    public const int FMFBOBJDIECFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.IFJPLLMDHPL> _repeated_fMFBOBJDIEC_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.IFJPLLMDHPL.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IFJPLLMDHPL> fMFBOBJDIEC_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IFJPLLMDHPL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IFJPLLMDHPL> FMFBOBJDIEC {
      get { return fMFBOBJDIEC_; }
    }

    /// <summary>Field number for the "KGJFGMLGOCP" field.</summary>
    public const int KGJFGMLGOCPFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EGNCJJJOLJA> _repeated_kGJFGMLGOCP_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.EGNCJJJOLJA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGNCJJJOLJA> kGJFGMLGOCP_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGNCJJJOLJA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGNCJJJOLJA> KGJFGMLGOCP {
      get { return kGJFGMLGOCP_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SyncRogueHandbookDataUpdateScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SyncRogueHandbookDataUpdateScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!oOIAEJKDKCF_.Equals(other.oOIAEJKDKCF_)) return false;
      if(!fMFBOBJDIEC_.Equals(other.fMFBOBJDIEC_)) return false;
      if(!kGJFGMLGOCP_.Equals(other.kGJFGMLGOCP_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= oOIAEJKDKCF_.GetHashCode();
      hash ^= fMFBOBJDIEC_.GetHashCode();
      hash ^= kGJFGMLGOCP_.GetHashCode();
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
      kGJFGMLGOCP_.WriteTo(output, _repeated_kGJFGMLGOCP_codec);
      fMFBOBJDIEC_.WriteTo(output, _repeated_fMFBOBJDIEC_codec);
      oOIAEJKDKCF_.WriteTo(output, _repeated_oOIAEJKDKCF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      kGJFGMLGOCP_.WriteTo(ref output, _repeated_kGJFGMLGOCP_codec);
      fMFBOBJDIEC_.WriteTo(ref output, _repeated_fMFBOBJDIEC_codec);
      oOIAEJKDKCF_.WriteTo(ref output, _repeated_oOIAEJKDKCF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += oOIAEJKDKCF_.CalculateSize(_repeated_oOIAEJKDKCF_codec);
      size += fMFBOBJDIEC_.CalculateSize(_repeated_fMFBOBJDIEC_codec);
      size += kGJFGMLGOCP_.CalculateSize(_repeated_kGJFGMLGOCP_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SyncRogueHandbookDataUpdateScNotify other) {
      if (other == null) {
        return;
      }
      oOIAEJKDKCF_.Add(other.oOIAEJKDKCF_);
      fMFBOBJDIEC_.Add(other.fMFBOBJDIEC_);
      kGJFGMLGOCP_.Add(other.kGJFGMLGOCP_);
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
          case 34: {
            kGJFGMLGOCP_.AddEntriesFrom(input, _repeated_kGJFGMLGOCP_codec);
            break;
          }
          case 66: {
            fMFBOBJDIEC_.AddEntriesFrom(input, _repeated_fMFBOBJDIEC_codec);
            break;
          }
          case 114: {
            oOIAEJKDKCF_.AddEntriesFrom(input, _repeated_oOIAEJKDKCF_codec);
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
          case 34: {
            kGJFGMLGOCP_.AddEntriesFrom(ref input, _repeated_kGJFGMLGOCP_codec);
            break;
          }
          case 66: {
            fMFBOBJDIEC_.AddEntriesFrom(ref input, _repeated_fMFBOBJDIEC_codec);
            break;
          }
          case 114: {
            oOIAEJKDKCF_.AddEntriesFrom(ref input, _repeated_oOIAEJKDKCF_codec);
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