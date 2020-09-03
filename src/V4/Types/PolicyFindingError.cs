// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/errors/policy_finding_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/errors/policy_finding_error.proto</summary>
  public static partial class PolicyFindingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/errors/policy_finding_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyFindingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lcnJvcnMvcG9saWN5X2ZpbmRp",
            "bmdfZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LmVycm9y",
            "cxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJ8ChZQb2xpY3lGaW5k",
            "aW5nRXJyb3JFbnVtImIKElBvbGljeUZpbmRpbmdFcnJvchIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARISCg5QT0xJQ1lfRklORElORxACEhoKFlBP",
            "TElDWV9UT1BJQ19OT1RfRk9VTkQQA0LyAQoiY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnY0LmVycm9yc0IXUG9saWN5RmluZGluZ0Vycm9yUHJvdG9QAVpE",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3Y0L2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WNC5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWNFxF",
            "cnJvcnPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNDo6RXJyb3JzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Errors.PolicyFindingErrorEnum), global::Google.Ads.GoogleAds.V4.Errors.PolicyFindingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Errors.PolicyFindingErrorEnum.Types.PolicyFindingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy finding errors.
  /// </summary>
  public sealed partial class PolicyFindingErrorEnum : pb::IMessage<PolicyFindingErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PolicyFindingErrorEnum> _parser = new pb::MessageParser<PolicyFindingErrorEnum>(() => new PolicyFindingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PolicyFindingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Errors.PolicyFindingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyFindingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyFindingErrorEnum(PolicyFindingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyFindingErrorEnum Clone() {
      return new PolicyFindingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PolicyFindingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PolicyFindingErrorEnum other) {
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
    public void MergeFrom(PolicyFindingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the PolicyFindingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible policy finding errors.
      /// </summary>
      public enum PolicyFindingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The resource has been disapproved since the policy summary includes
        /// policy topics of type PROHIBITED.
        /// </summary>
        [pbr::OriginalName("POLICY_FINDING")] PolicyFinding = 2,
        /// <summary>
        /// The given policy topic does not exist.
        /// </summary>
        [pbr::OriginalName("POLICY_TOPIC_NOT_FOUND")] PolicyTopicNotFound = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
