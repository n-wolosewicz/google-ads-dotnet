// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/errors/customer_manager_link_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/errors/customer_manager_link_error.proto</summary>
  public static partial class CustomerManagerLinkErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/errors/customer_manager_link_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerManagerLinkErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lcnJvcnMvY3VzdG9tZXJfbWFu",
            "YWdlcl9saW5rX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "My5lcnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i0AMKHEN1",
            "c3RvbWVyTWFuYWdlckxpbmtFcnJvckVudW0irwMKGEN1c3RvbWVyTWFuYWdl",
            "ckxpbmtFcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIVChFO",
            "T19QRU5ESU5HX0lOVklURRACEicKI1NBTUVfQ0xJRU5UX01PUkVfVEhBTl9P",
            "TkNFX1BFUl9DQUxMEAMSLQopTUFOQUdFUl9IQVNfTUFYX05VTUJFUl9PRl9M",
            "SU5LRURfQUNDT1VOVFMQBBItCilDQU5OT1RfVU5MSU5LX0FDQ09VTlRfV0lU",
            "SE9VVF9BQ1RJVkVfVVNFUhAFEisKJ0NBTk5PVF9SRU1PVkVfTEFTVF9DTElF",
            "TlRfQUNDT1VOVF9PV05FUhAGEisKJ0NBTk5PVF9DSEFOR0VfUk9MRV9CWV9O",
            "T05fQUNDT1VOVF9PV05FUhAHEjIKLkNBTk5PVF9DSEFOR0VfUk9MRV9GT1Jf",
            "Tk9OX0FDVElWRV9MSU5LX0FDQ09VTlQQCBIZChVEVVBMSUNBVEVfQ0hJTERf",
            "Rk9VTkQQCRIuCipURVNUX0FDQ09VTlRfTElOS1NfVE9PX01BTllfQ0hJTERf",
            "QUNDT1VOVFMQCkL4AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVy",
            "cm9yc0IdQ3VzdG9tZXJNYW5hZ2VyTGlua0Vycm9yUHJvdG9QAVpEZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRz",
            "L3YzL2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFk",
            "cy5WMy5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWM1xFcnJvcnPq",
            "AiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Errors.CustomerManagerLinkErrorEnum), global::Google.Ads.GoogleAds.V3.Errors.CustomerManagerLinkErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Errors.CustomerManagerLinkErrorEnum.Types.CustomerManagerLinkError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible CustomerManagerLink errors.
  /// </summary>
  public sealed partial class CustomerManagerLinkErrorEnum : pb::IMessage<CustomerManagerLinkErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerManagerLinkErrorEnum> _parser = new pb::MessageParser<CustomerManagerLinkErrorEnum>(() => new CustomerManagerLinkErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerManagerLinkErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Errors.CustomerManagerLinkErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerManagerLinkErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerManagerLinkErrorEnum(CustomerManagerLinkErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerManagerLinkErrorEnum Clone() {
      return new CustomerManagerLinkErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerManagerLinkErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerManagerLinkErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerManagerLinkErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    /// <summary>Container for nested types declared in the CustomerManagerLinkErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible CustomerManagerLink errors.
      /// </summary>
      public enum CustomerManagerLinkError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// No pending invitation.
        /// </summary>
        [pbr::OriginalName("NO_PENDING_INVITE")] NoPendingInvite = 2,
        /// <summary>
        /// Attempt to operate on the same client more than once in the same call.
        /// </summary>
        [pbr::OriginalName("SAME_CLIENT_MORE_THAN_ONCE_PER_CALL")] SameClientMoreThanOncePerCall = 3,
        /// <summary>
        /// Manager account has the maximum number of linked accounts.
        /// </summary>
        [pbr::OriginalName("MANAGER_HAS_MAX_NUMBER_OF_LINKED_ACCOUNTS")] ManagerHasMaxNumberOfLinkedAccounts = 4,
        /// <summary>
        /// If no active user on account it cannot be unlinked from its manager.
        /// </summary>
        [pbr::OriginalName("CANNOT_UNLINK_ACCOUNT_WITHOUT_ACTIVE_USER")] CannotUnlinkAccountWithoutActiveUser = 5,
        /// <summary>
        /// Account should have at least one active owner on it before being
        /// unlinked.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_LAST_CLIENT_ACCOUNT_OWNER")] CannotRemoveLastClientAccountOwner = 6,
        /// <summary>
        /// Only account owners may change their permission role.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_ROLE_BY_NON_ACCOUNT_OWNER")] CannotChangeRoleByNonAccountOwner = 7,
        /// <summary>
        /// When a client's link to its manager is not active, the link role cannot
        /// be changed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_ROLE_FOR_NON_ACTIVE_LINK_ACCOUNT")] CannotChangeRoleForNonActiveLinkAccount = 8,
        /// <summary>
        /// Attempt to link a child to a parent that contains or will contain
        /// duplicate children.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CHILD_FOUND")] DuplicateChildFound = 9,
        /// <summary>
        /// The authorized customer is a test account. It can add no more than the
        /// allowed number of accounts
        /// </summary>
        [pbr::OriginalName("TEST_ACCOUNT_LINKS_TOO_MANY_CHILD_ACCOUNTS")] TestAccountLinksTooManyChildAccounts = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
