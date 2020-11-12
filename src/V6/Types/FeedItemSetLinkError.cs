// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/errors/feed_item_set_link_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/errors/feed_item_set_link_error.proto</summary>
  public static partial class FeedItemSetLinkErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/errors/feed_item_set_link_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemSetLinkErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9lcnJvcnMvZmVlZF9pdGVtX3Nl",
            "dF9saW5rX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ni5l",
            "cnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ijQEKGEZlZWRJ",
            "dGVtU2V0TGlua0Vycm9yRW51bSJxChRGZWVkSXRlbVNldExpbmtFcnJvchIP",
            "CgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIUChBGRUVEX0lEX01JU01B",
            "VENIEAISJQohTk9fTVVUQVRFX0FMTE9XRURfRk9SX0RZTkFNSUNfU0VUEANC",
            "9AEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ni5lcnJvcnNCGUZlZWRJ",
            "dGVtU2V0TGlua0Vycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y2L2Vycm9ycztlcnJv",
            "cnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WNi5FcnJvcnPKAh5H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWNlxFcnJvcnPqAiJHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWNjo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Errors.FeedItemSetLinkErrorEnum), global::Google.Ads.GoogleAds.V6.Errors.FeedItemSetLinkErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V6.Errors.FeedItemSetLinkErrorEnum.Types.FeedItemSetLinkError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible feed item set link errors.
  /// </summary>
  public sealed partial class FeedItemSetLinkErrorEnum : pb::IMessage<FeedItemSetLinkErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedItemSetLinkErrorEnum> _parser = new pb::MessageParser<FeedItemSetLinkErrorEnum>(() => new FeedItemSetLinkErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedItemSetLinkErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Errors.FeedItemSetLinkErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemSetLinkErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemSetLinkErrorEnum(FeedItemSetLinkErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemSetLinkErrorEnum Clone() {
      return new FeedItemSetLinkErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedItemSetLinkErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedItemSetLinkErrorEnum other) {
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
    public void MergeFrom(FeedItemSetLinkErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FeedItemSetLinkErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible feed item set link errors.
      /// </summary>
      public enum FeedItemSetLinkError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The feed IDs of the FeedItemSet and FeedItem do not match. Only FeedItems
        /// in a given Feed can be linked to a FeedItemSet in that Feed.
        /// </summary>
        [pbr::OriginalName("FEED_ID_MISMATCH")] FeedIdMismatch = 2,
        /// <summary>
        /// Cannot add or remove links to a dynamic set.
        /// </summary>
        [pbr::OriginalName("NO_MUTATE_ALLOWED_FOR_DYNAMIC_SET")] NoMutateAllowedForDynamicSet = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
