// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/errors/feed_item_target_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/errors/feed_item_target_error.proto</summary>
  public static partial class FeedItemTargetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/errors/feed_item_target_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemTargetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lcnJvcnMvZmVlZF9pdGVtX3Rh",
            "cmdldF9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuZXJy",
            "b3JzGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIvwCChdGZWVkSXRl",
            "bVRhcmdldEVycm9yRW51bSLgAgoTRmVlZEl0ZW1UYXJnZXRFcnJvchIPCgtV",
            "TlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIjCh9NVVNUX1NFVF9UQVJHRVRf",
            "T05FT0ZfT05fQ1JFQVRFEAISIwofRkVFRF9JVEVNX1RBUkdFVF9BTFJFQURZ",
            "X0VYSVNUUxADEiYKIkZFRURfSVRFTV9TQ0hFRFVMRVNfQ0FOTk9UX09WRVJM",
            "QVAQBBIoCiRUQVJHRVRfTElNSVRfRVhDRUVERURfRk9SX0dJVkVOX1RZUEUQ",
            "BRIeChpUT09fTUFOWV9TQ0hFRFVMRVNfUEVSX0RBWRAGEj0KOUNBTk5PVF9I",
            "QVZFX0VOQUJMRURfQ0FNUEFJR05fQU5EX0VOQUJMRURfQURfR1JPVVBfVEFS",
            "R0VUUxAHEhkKFURVUExJQ0FURV9BRF9TQ0hFRFVMRRAIEhUKEURVUExJQ0FU",
            "RV9LRVlXT1JEEAlC8wEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5l",
            "cnJvcnNCGEZlZWRJdGVtVGFyZ2V0RXJyb3JQcm90b1ABWkRnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjQv",
            "ZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlY0",
            "LkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY0XEVycm9yc+oCIkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlY0OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Errors.FeedItemTargetErrorEnum), global::Google.Ads.GoogleAds.V4.Errors.FeedItemTargetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Errors.FeedItemTargetErrorEnum.Types.FeedItemTargetError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible feed item target errors.
  /// </summary>
  public sealed partial class FeedItemTargetErrorEnum : pb::IMessage<FeedItemTargetErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedItemTargetErrorEnum> _parser = new pb::MessageParser<FeedItemTargetErrorEnum>(() => new FeedItemTargetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedItemTargetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Errors.FeedItemTargetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemTargetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemTargetErrorEnum(FeedItemTargetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemTargetErrorEnum Clone() {
      return new FeedItemTargetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedItemTargetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedItemTargetErrorEnum other) {
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
    public void MergeFrom(FeedItemTargetErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FeedItemTargetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible feed item target errors.
      /// </summary>
      public enum FeedItemTargetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// On CREATE, the FeedItemTarget must have a populated field in the oneof
        /// target.
        /// </summary>
        [pbr::OriginalName("MUST_SET_TARGET_ONEOF_ON_CREATE")] MustSetTargetOneofOnCreate = 2,
        /// <summary>
        /// The specified feed item target already exists, so it cannot be added.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM_TARGET_ALREADY_EXISTS")] FeedItemTargetAlreadyExists = 3,
        /// <summary>
        /// The schedules for a given feed item cannot overlap.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM_SCHEDULES_CANNOT_OVERLAP")] FeedItemSchedulesCannotOverlap = 4,
        /// <summary>
        /// Too many targets of a given type were added for a single feed item.
        /// </summary>
        [pbr::OriginalName("TARGET_LIMIT_EXCEEDED_FOR_GIVEN_TYPE")] TargetLimitExceededForGivenType = 5,
        /// <summary>
        /// Too many AdSchedules are enabled for the feed item for the given day.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_SCHEDULES_PER_DAY")] TooManySchedulesPerDay = 6,
        /// <summary>
        /// A feed item may either have an enabled campaign target or an enabled ad
        /// group target.
        /// </summary>
        [pbr::OriginalName("CANNOT_HAVE_ENABLED_CAMPAIGN_AND_ENABLED_AD_GROUP_TARGETS")] CannotHaveEnabledCampaignAndEnabledAdGroupTargets = 7,
        /// <summary>
        /// Duplicate ad schedules aren't allowed.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_AD_SCHEDULE")] DuplicateAdSchedule = 8,
        /// <summary>
        /// Duplicate keywords aren't allowed.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_KEYWORD")] DuplicateKeyword = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
