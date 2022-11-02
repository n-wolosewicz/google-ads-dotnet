// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/enums/account_budget_proposal_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/enums/account_budget_proposal_status.proto</summary>
  public static partial class AccountBudgetProposalStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/enums/account_budget_proposal_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccountBudgetProposalStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvYWNjb3VudF9idWRn",
            "ZXRfcHJvcG9zYWxfc3RhdHVzLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTIuZW51bXMiqgEKH0FjY291bnRCdWRnZXRQcm9wb3NhbFN0YXR1c0Vu",
            "dW0ihgEKG0FjY291bnRCdWRnZXRQcm9wb3NhbFN0YXR1cxIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARILCgdQRU5ESU5HEAISEQoNQVBQUk9WRURf",
            "SEVMRBADEgwKCEFQUFJPVkVEEAQSDQoJQ0FOQ0VMTEVEEAUSDAoIUkVKRUNU",
            "RUQQBkL6AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5lbnVtc0Ig",
            "QWNjb3VudEJ1ZGdldFByb3Bvc2FsU3RhdHVzUHJvdG9QAVpDZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "Mi9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "Mi5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMlxFbnVtc+oCIkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMjo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Enums.AccountBudgetProposalStatusEnum), global::Google.Ads.GoogleAds.V12.Enums.AccountBudgetProposalStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Enums.AccountBudgetProposalStatusEnum.Types.AccountBudgetProposalStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing AccountBudgetProposal statuses.
  /// </summary>
  public sealed partial class AccountBudgetProposalStatusEnum : pb::IMessage<AccountBudgetProposalStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccountBudgetProposalStatusEnum> _parser = new pb::MessageParser<AccountBudgetProposalStatusEnum>(() => new AccountBudgetProposalStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccountBudgetProposalStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Enums.AccountBudgetProposalStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountBudgetProposalStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountBudgetProposalStatusEnum(AccountBudgetProposalStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountBudgetProposalStatusEnum Clone() {
      return new AccountBudgetProposalStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccountBudgetProposalStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccountBudgetProposalStatusEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AccountBudgetProposalStatusEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AccountBudgetProposalStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible statuses of an AccountBudgetProposal.
      /// </summary>
      public enum AccountBudgetProposalStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The proposal is pending approval.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 2,
        /// <summary>
        /// The proposal has been approved but the corresponding billing setup
        /// has not.  This can occur for proposals that set up the first budget
        /// when signing up for billing or when performing a change of bill-to
        /// operation.
        /// </summary>
        [pbr::OriginalName("APPROVED_HELD")] ApprovedHeld = 3,
        /// <summary>
        /// The proposal has been approved.
        /// </summary>
        [pbr::OriginalName("APPROVED")] Approved = 4,
        /// <summary>
        /// The proposal has been cancelled by the user.
        /// </summary>
        [pbr::OriginalName("CANCELLED")] Cancelled = 5,
        /// <summary>
        /// The proposal has been rejected by the user, for example, by rejecting an
        /// acceptance email.
        /// </summary>
        [pbr::OriginalName("REJECTED")] Rejected = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
