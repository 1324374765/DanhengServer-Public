// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCommonBuffSelectInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCommonBuffSelectInfo.proto</summary>
  public static partial class RogueCommonBuffSelectInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCommonBuffSelectInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCommonBuffSelectInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Sb2d1ZUNvbW1vbkJ1ZmZTZWxlY3RJbmZvLnByb3RvGhVSb2d1ZUNvbW1v",
            "bkJ1ZmYucHJvdG8aEkl0ZW1Db3N0RGF0YS5wcm90bxolUm9ndWVDb21tb25C",
            "dWZmU2VsZWN0U291cmNlVHlwZS5wcm90byLKAwoZUm9ndWVDb21tb25CdWZm",
            "U2VsZWN0SW5mbxIqChBzZWxlY3RfYnVmZl9saXN0GAUgAygLMhAuUm9ndWVD",
            "b21tb25CdWZmEiQKHGhhbmRib29rX3VubG9ja19idWZmX2lkX2xpc3QYCiAD",
            "KA0SGwoTcm9sbF9idWZmX21heF9jb3VudBgGIAEoDRImCh5DZXJ0YWluU2Vs",
            "ZWN0QnVmZklkRmllbGROdW1iZXIYCSABKA0SFgoOc291cmNlX2hpbnRfaWQY",
            "DyABKA0SKgoTcm9sbF9idWZmX2Nvc3RfZGF0YRgEIAEoCzINLkl0ZW1Db3N0",
            "RGF0YRIYChBzb3VyY2VfY3VyX2NvdW50GAcgASgNEhwKFHJvbGxfYnVmZl9m",
            "cmVlX2NvdW50GAEgASgNEhAKCGNhbl9yb2xsGA4gASgIEhcKD3JvbGxfYnVm",
            "Zl9jb3VudBgDIAEoDRI1Cgtzb3VyY2VfdHlwZRgCIAEoDjIgLlJvZ3VlQ29t",
            "bW9uQnVmZlNlbGVjdFNvdXJjZVR5cGUSHAoUZmlyc3RfYnVmZl90eXBlX2xp",
            "c3QYDSADKA0SGgoSc291cmNlX3RvdGFsX2NvdW50GAwgASgNQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonBuffReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectInfo), global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectInfo.Parser, new[]{ "SelectBuffList", "HandbookUnlockBuffIdList", "RollBuffMaxCount", "CertainSelectBuffIdFieldNumber", "SourceHintId", "RollBuffCostData", "SourceCurCount", "RollBuffFreeCount", "CanRoll", "RollBuffCount", "SourceType", "FirstBuffTypeList", "SourceTotalCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueCommonBuffSelectInfo : pb::IMessage<RogueCommonBuffSelectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueCommonBuffSelectInfo> _parser = new pb::MessageParser<RogueCommonBuffSelectInfo>(() => new RogueCommonBuffSelectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueCommonBuffSelectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonBuffSelectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonBuffSelectInfo(RogueCommonBuffSelectInfo other) : this() {
      selectBuffList_ = other.selectBuffList_.Clone();
      handbookUnlockBuffIdList_ = other.handbookUnlockBuffIdList_.Clone();
      rollBuffMaxCount_ = other.rollBuffMaxCount_;
      certainSelectBuffIdFieldNumber_ = other.certainSelectBuffIdFieldNumber_;
      sourceHintId_ = other.sourceHintId_;
      rollBuffCostData_ = other.rollBuffCostData_ != null ? other.rollBuffCostData_.Clone() : null;
      sourceCurCount_ = other.sourceCurCount_;
      rollBuffFreeCount_ = other.rollBuffFreeCount_;
      canRoll_ = other.canRoll_;
      rollBuffCount_ = other.rollBuffCount_;
      sourceType_ = other.sourceType_;
      firstBuffTypeList_ = other.firstBuffTypeList_.Clone();
      sourceTotalCount_ = other.sourceTotalCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonBuffSelectInfo Clone() {
      return new RogueCommonBuffSelectInfo(this);
    }

    /// <summary>Field number for the "select_buff_list" field.</summary>
    public const int SelectBuffListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueCommonBuff> _repeated_selectBuffList_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.RogueCommonBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> selectBuffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> SelectBuffList {
      get { return selectBuffList_; }
    }

    /// <summary>Field number for the "handbook_unlock_buff_id_list" field.</summary>
    public const int HandbookUnlockBuffIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_handbookUnlockBuffIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> handbookUnlockBuffIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HandbookUnlockBuffIdList {
      get { return handbookUnlockBuffIdList_; }
    }

    /// <summary>Field number for the "roll_buff_max_count" field.</summary>
    public const int RollBuffMaxCountFieldNumber = 6;
    private uint rollBuffMaxCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollBuffMaxCount {
      get { return rollBuffMaxCount_; }
      set {
        rollBuffMaxCount_ = value;
      }
    }

    /// <summary>Field number for the "CertainSelectBuffIdFieldNumber" field.</summary>
    public const int CertainSelectBuffIdFieldNumberFieldNumber = 9;
    private uint certainSelectBuffIdFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CertainSelectBuffIdFieldNumber {
      get { return certainSelectBuffIdFieldNumber_; }
      set {
        certainSelectBuffIdFieldNumber_ = value;
      }
    }

    /// <summary>Field number for the "source_hint_id" field.</summary>
    public const int SourceHintIdFieldNumber = 15;
    private uint sourceHintId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceHintId {
      get { return sourceHintId_; }
      set {
        sourceHintId_ = value;
      }
    }

    /// <summary>Field number for the "roll_buff_cost_data" field.</summary>
    public const int RollBuffCostDataFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ItemCostData rollBuffCostData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData RollBuffCostData {
      get { return rollBuffCostData_; }
      set {
        rollBuffCostData_ = value;
      }
    }

    /// <summary>Field number for the "source_cur_count" field.</summary>
    public const int SourceCurCountFieldNumber = 7;
    private uint sourceCurCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceCurCount {
      get { return sourceCurCount_; }
      set {
        sourceCurCount_ = value;
      }
    }

    /// <summary>Field number for the "roll_buff_free_count" field.</summary>
    public const int RollBuffFreeCountFieldNumber = 1;
    private uint rollBuffFreeCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollBuffFreeCount {
      get { return rollBuffFreeCount_; }
      set {
        rollBuffFreeCount_ = value;
      }
    }

    /// <summary>Field number for the "can_roll" field.</summary>
    public const int CanRollFieldNumber = 14;
    private bool canRoll_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CanRoll {
      get { return canRoll_; }
      set {
        canRoll_ = value;
      }
    }

    /// <summary>Field number for the "roll_buff_count" field.</summary>
    public const int RollBuffCountFieldNumber = 3;
    private uint rollBuffCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollBuffCount {
      get { return rollBuffCount_; }
      set {
        rollBuffCount_ = value;
      }
    }

    /// <summary>Field number for the "source_type" field.</summary>
    public const int SourceTypeFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType sourceType_ = global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType SourceType {
      get { return sourceType_; }
      set {
        sourceType_ = value;
      }
    }

    /// <summary>Field number for the "first_buff_type_list" field.</summary>
    public const int FirstBuffTypeListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_firstBuffTypeList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> firstBuffTypeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FirstBuffTypeList {
      get { return firstBuffTypeList_; }
    }

    /// <summary>Field number for the "source_total_count" field.</summary>
    public const int SourceTotalCountFieldNumber = 12;
    private uint sourceTotalCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceTotalCount {
      get { return sourceTotalCount_; }
      set {
        sourceTotalCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueCommonBuffSelectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueCommonBuffSelectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!selectBuffList_.Equals(other.selectBuffList_)) return false;
      if(!handbookUnlockBuffIdList_.Equals(other.handbookUnlockBuffIdList_)) return false;
      if (RollBuffMaxCount != other.RollBuffMaxCount) return false;
      if (CertainSelectBuffIdFieldNumber != other.CertainSelectBuffIdFieldNumber) return false;
      if (SourceHintId != other.SourceHintId) return false;
      if (!object.Equals(RollBuffCostData, other.RollBuffCostData)) return false;
      if (SourceCurCount != other.SourceCurCount) return false;
      if (RollBuffFreeCount != other.RollBuffFreeCount) return false;
      if (CanRoll != other.CanRoll) return false;
      if (RollBuffCount != other.RollBuffCount) return false;
      if (SourceType != other.SourceType) return false;
      if(!firstBuffTypeList_.Equals(other.firstBuffTypeList_)) return false;
      if (SourceTotalCount != other.SourceTotalCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= selectBuffList_.GetHashCode();
      hash ^= handbookUnlockBuffIdList_.GetHashCode();
      if (RollBuffMaxCount != 0) hash ^= RollBuffMaxCount.GetHashCode();
      if (CertainSelectBuffIdFieldNumber != 0) hash ^= CertainSelectBuffIdFieldNumber.GetHashCode();
      if (SourceHintId != 0) hash ^= SourceHintId.GetHashCode();
      if (rollBuffCostData_ != null) hash ^= RollBuffCostData.GetHashCode();
      if (SourceCurCount != 0) hash ^= SourceCurCount.GetHashCode();
      if (RollBuffFreeCount != 0) hash ^= RollBuffFreeCount.GetHashCode();
      if (CanRoll != false) hash ^= CanRoll.GetHashCode();
      if (RollBuffCount != 0) hash ^= RollBuffCount.GetHashCode();
      if (SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) hash ^= SourceType.GetHashCode();
      hash ^= firstBuffTypeList_.GetHashCode();
      if (SourceTotalCount != 0) hash ^= SourceTotalCount.GetHashCode();
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
      if (RollBuffFreeCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RollBuffFreeCount);
      }
      if (SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) SourceType);
      }
      if (RollBuffCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RollBuffCount);
      }
      if (rollBuffCostData_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RollBuffCostData);
      }
      selectBuffList_.WriteTo(output, _repeated_selectBuffList_codec);
      if (RollBuffMaxCount != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RollBuffMaxCount);
      }
      if (SourceCurCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SourceCurCount);
      }
      if (CertainSelectBuffIdFieldNumber != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CertainSelectBuffIdFieldNumber);
      }
      handbookUnlockBuffIdList_.WriteTo(output, _repeated_handbookUnlockBuffIdList_codec);
      if (SourceTotalCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SourceTotalCount);
      }
      firstBuffTypeList_.WriteTo(output, _repeated_firstBuffTypeList_codec);
      if (CanRoll != false) {
        output.WriteRawTag(112);
        output.WriteBool(CanRoll);
      }
      if (SourceHintId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SourceHintId);
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
      if (RollBuffFreeCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RollBuffFreeCount);
      }
      if (SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) SourceType);
      }
      if (RollBuffCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RollBuffCount);
      }
      if (rollBuffCostData_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RollBuffCostData);
      }
      selectBuffList_.WriteTo(ref output, _repeated_selectBuffList_codec);
      if (RollBuffMaxCount != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RollBuffMaxCount);
      }
      if (SourceCurCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SourceCurCount);
      }
      if (CertainSelectBuffIdFieldNumber != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CertainSelectBuffIdFieldNumber);
      }
      handbookUnlockBuffIdList_.WriteTo(ref output, _repeated_handbookUnlockBuffIdList_codec);
      if (SourceTotalCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SourceTotalCount);
      }
      firstBuffTypeList_.WriteTo(ref output, _repeated_firstBuffTypeList_codec);
      if (CanRoll != false) {
        output.WriteRawTag(112);
        output.WriteBool(CanRoll);
      }
      if (SourceHintId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SourceHintId);
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
      size += selectBuffList_.CalculateSize(_repeated_selectBuffList_codec);
      size += handbookUnlockBuffIdList_.CalculateSize(_repeated_handbookUnlockBuffIdList_codec);
      if (RollBuffMaxCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollBuffMaxCount);
      }
      if (CertainSelectBuffIdFieldNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CertainSelectBuffIdFieldNumber);
      }
      if (SourceHintId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceHintId);
      }
      if (rollBuffCostData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RollBuffCostData);
      }
      if (SourceCurCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceCurCount);
      }
      if (RollBuffFreeCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollBuffFreeCount);
      }
      if (CanRoll != false) {
        size += 1 + 1;
      }
      if (RollBuffCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollBuffCount);
      }
      if (SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SourceType);
      }
      size += firstBuffTypeList_.CalculateSize(_repeated_firstBuffTypeList_codec);
      if (SourceTotalCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceTotalCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueCommonBuffSelectInfo other) {
      if (other == null) {
        return;
      }
      selectBuffList_.Add(other.selectBuffList_);
      handbookUnlockBuffIdList_.Add(other.handbookUnlockBuffIdList_);
      if (other.RollBuffMaxCount != 0) {
        RollBuffMaxCount = other.RollBuffMaxCount;
      }
      if (other.CertainSelectBuffIdFieldNumber != 0) {
        CertainSelectBuffIdFieldNumber = other.CertainSelectBuffIdFieldNumber;
      }
      if (other.SourceHintId != 0) {
        SourceHintId = other.SourceHintId;
      }
      if (other.rollBuffCostData_ != null) {
        if (rollBuffCostData_ == null) {
          RollBuffCostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        RollBuffCostData.MergeFrom(other.RollBuffCostData);
      }
      if (other.SourceCurCount != 0) {
        SourceCurCount = other.SourceCurCount;
      }
      if (other.RollBuffFreeCount != 0) {
        RollBuffFreeCount = other.RollBuffFreeCount;
      }
      if (other.CanRoll != false) {
        CanRoll = other.CanRoll;
      }
      if (other.RollBuffCount != 0) {
        RollBuffCount = other.RollBuffCount;
      }
      if (other.SourceType != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType.None) {
        SourceType = other.SourceType;
      }
      firstBuffTypeList_.Add(other.firstBuffTypeList_);
      if (other.SourceTotalCount != 0) {
        SourceTotalCount = other.SourceTotalCount;
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
            RollBuffFreeCount = input.ReadUInt32();
            break;
          }
          case 16: {
            SourceType = (global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType) input.ReadEnum();
            break;
          }
          case 24: {
            RollBuffCount = input.ReadUInt32();
            break;
          }
          case 34: {
            if (rollBuffCostData_ == null) {
              RollBuffCostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(RollBuffCostData);
            break;
          }
          case 42: {
            selectBuffList_.AddEntriesFrom(input, _repeated_selectBuffList_codec);
            break;
          }
          case 48: {
            RollBuffMaxCount = input.ReadUInt32();
            break;
          }
          case 56: {
            SourceCurCount = input.ReadUInt32();
            break;
          }
          case 72: {
            CertainSelectBuffIdFieldNumber = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            handbookUnlockBuffIdList_.AddEntriesFrom(input, _repeated_handbookUnlockBuffIdList_codec);
            break;
          }
          case 96: {
            SourceTotalCount = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            firstBuffTypeList_.AddEntriesFrom(input, _repeated_firstBuffTypeList_codec);
            break;
          }
          case 112: {
            CanRoll = input.ReadBool();
            break;
          }
          case 120: {
            SourceHintId = input.ReadUInt32();
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
            RollBuffFreeCount = input.ReadUInt32();
            break;
          }
          case 16: {
            SourceType = (global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceType) input.ReadEnum();
            break;
          }
          case 24: {
            RollBuffCount = input.ReadUInt32();
            break;
          }
          case 34: {
            if (rollBuffCostData_ == null) {
              RollBuffCostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(RollBuffCostData);
            break;
          }
          case 42: {
            selectBuffList_.AddEntriesFrom(ref input, _repeated_selectBuffList_codec);
            break;
          }
          case 48: {
            RollBuffMaxCount = input.ReadUInt32();
            break;
          }
          case 56: {
            SourceCurCount = input.ReadUInt32();
            break;
          }
          case 72: {
            CertainSelectBuffIdFieldNumber = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            handbookUnlockBuffIdList_.AddEntriesFrom(ref input, _repeated_handbookUnlockBuffIdList_codec);
            break;
          }
          case 96: {
            SourceTotalCount = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            firstBuffTypeList_.AddEntriesFrom(ref input, _repeated_firstBuffTypeList_codec);
            break;
          }
          case 112: {
            CanRoll = input.ReadBool();
            break;
          }
          case 120: {
            SourceHintId = input.ReadUInt32();
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