// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/errors/conversion_upload_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/errors/conversion_upload_error.proto</summary>
  public static partial class ConversionUploadErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/errors/conversion_upload_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionUploadErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lcnJvcnMvY29udmVyc2lvbl91",
            "cGxvYWRfZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVy",
            "cm9ycxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLUBgoZQ29udmVy",
            "c2lvblVwbG9hZEVycm9yRW51bSK2BgoVQ29udmVyc2lvblVwbG9hZEVycm9y",
            "Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEiMKH1RPT19NQU5ZX0NP",
            "TlZFUlNJT05TX0lOX1JFUVVFU1QQAhIVChFVTlBBUlNFQUJMRV9HQ0xJRBAD",
            "Eh0KGUNPTlZFUlNJT05fUFJFQ0VERVNfR0NMSUQQBBIRCg1FWFBJUkVEX0dD",
            "TElEEAUSFAoQVE9PX1JFQ0VOVF9HQ0xJRBAGEhMKD0dDTElEX05PVF9GT1VO",
            "RBAHEhkKFVVOQVVUSE9SSVpFRF9DVVNUT01FUhAIEh0KGUlOVkFMSURfQ09O",
            "VkVSU0lPTl9BQ1RJT04QCRIgChxUT09fUkVDRU5UX0NPTlZFUlNJT05fQUNU",
            "SU9OEAoSNgoyQ09OVkVSU0lPTl9UUkFDS0lOR19OT1RfRU5BQkxFRF9BVF9J",
            "TVBSRVNTSU9OX1RJTUUQCxJRCk1FWFRFUk5BTF9BVFRSSUJVVElPTl9EQVRB",
            "X1NFVF9GT1JfTk9OX0VYVEVSTkFMTFlfQVRUUklCVVRFRF9DT05WRVJTSU9O",
            "X0FDVElPThAMElEKTUVYVEVSTkFMX0FUVFJJQlVUSU9OX0RBVEFfTk9UX1NF",
            "VF9GT1JfRVhURVJOQUxMWV9BVFRSSUJVVEVEX0NPTlZFUlNJT05fQUNUSU9O",
            "EA0SRgpCT1JERVJfSURfTk9UX1BFUk1JVFRFRF9GT1JfRVhURVJOQUxMWV9B",
            "VFRSSUJVVEVEX0NPTlZFUlNJT05fQUNUSU9OEA4SGwoXT1JERVJfSURfQUxS",
            "RUFEWV9JTl9VU0UQDxIWChJEVVBMSUNBVEVfT1JERVJfSUQQEBITCg9UT09f",
            "UkVDRU5UX0NBTEwQERIQCgxFWFBJUkVEX0NBTEwQEhISCg5DQUxMX05PVF9G",
            "T1VORBATEhwKGENPTlZFUlNJT05fUFJFQ0VERVNfQ0FMTBAUEjAKLENPTlZF",
            "UlNJT05fVFJBQ0tJTkdfTk9UX0VOQUJMRURfQVRfQ0FMTF9USU1FEBUSJAog",
            "VU5QQVJTRUFCTEVfQ0FMTEVSU19QSE9ORV9OVU1CRVIQFkL1AQoiY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVycm9yc0IaQ29udmVyc2lvblVwbG9h",
            "ZEVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL2Vycm9ycztlcnJvcnOiAgNHQUGq",
            "Ah5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5FcnJvcnPKAh5Hb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWMlxFcnJvcnPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRz",
            "OjpWMjo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Errors.ConversionUploadErrorEnum), global::Google.Ads.GoogleAds.V2.Errors.ConversionUploadErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Errors.ConversionUploadErrorEnum.Types.ConversionUploadError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible conversion upload errors.
  /// </summary>
  public sealed partial class ConversionUploadErrorEnum : pb::IMessage<ConversionUploadErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionUploadErrorEnum> _parser = new pb::MessageParser<ConversionUploadErrorEnum>(() => new ConversionUploadErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConversionUploadErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Errors.ConversionUploadErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionUploadErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionUploadErrorEnum(ConversionUploadErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionUploadErrorEnum Clone() {
      return new ConversionUploadErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConversionUploadErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConversionUploadErrorEnum other) {
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
    public void MergeFrom(ConversionUploadErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionUploadErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible conversion upload errors.
      /// </summary>
      public enum ConversionUploadError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The request contained more than 2000 conversions.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_CONVERSIONS_IN_REQUEST")] TooManyConversionsInRequest = 2,
        /// <summary>
        /// The specified gclid could not be decoded.
        /// </summary>
        [pbr::OriginalName("UNPARSEABLE_GCLID")] UnparseableGclid = 3,
        /// <summary>
        /// The specified conversion_date_time is before the event time
        /// associated with the given gclid.
        /// </summary>
        [pbr::OriginalName("CONVERSION_PRECEDES_GCLID")] ConversionPrecedesGclid = 4,
        /// <summary>
        /// The click associated with the given gclid is either too old to be
        /// imported or occurred outside of the click through lookback window for the
        /// specified conversion action.
        /// </summary>
        [pbr::OriginalName("EXPIRED_GCLID")] ExpiredGclid = 5,
        /// <summary>
        /// The click associated with the given gclid occurred too recently. Please
        /// try uploading again after 6 hours have passed since the click occurred.
        /// </summary>
        [pbr::OriginalName("TOO_RECENT_GCLID")] TooRecentGclid = 6,
        /// <summary>
        /// The click associated with the given gclid could not be found in the
        /// system. This can happen if Google Click IDs are collected for non Google
        /// Ads clicks.
        /// </summary>
        [pbr::OriginalName("GCLID_NOT_FOUND")] GclidNotFound = 7,
        /// <summary>
        /// The click associated with the given gclid is owned by a customer
        /// account that the uploading customer does not manage.
        /// </summary>
        [pbr::OriginalName("UNAUTHORIZED_CUSTOMER")] UnauthorizedCustomer = 8,
        /// <summary>
        /// No upload eligible conversion action that matches the provided
        /// information can be found for the customer.
        /// </summary>
        [pbr::OriginalName("INVALID_CONVERSION_ACTION")] InvalidConversionAction = 9,
        /// <summary>
        /// The specified conversion action was created too recently.
        /// Please try the upload again after 4-6 hours have passed since the
        /// conversion action was created.
        /// </summary>
        [pbr::OriginalName("TOO_RECENT_CONVERSION_ACTION")] TooRecentConversionAction = 10,
        /// <summary>
        /// The click associated with the given gclid does not contain conversion
        /// tracking information.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TRACKING_NOT_ENABLED_AT_IMPRESSION_TIME")] ConversionTrackingNotEnabledAtImpressionTime = 11,
        /// <summary>
        /// The specified conversion action does not use an external attribution
        /// model, but external_attribution_data was set.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_ATTRIBUTION_DATA_SET_FOR_NON_EXTERNALLY_ATTRIBUTED_CONVERSION_ACTION")] ExternalAttributionDataSetForNonExternallyAttributedConversionAction = 12,
        /// <summary>
        /// The specified conversion action uses an external attribution model, but
        /// external_attribution_data or one of its contained fields was not set.
        /// Both external_attribution_credit and external_attribution_model must be
        /// set for externally attributed conversion actions.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_ATTRIBUTION_DATA_NOT_SET_FOR_EXTERNALLY_ATTRIBUTED_CONVERSION_ACTION")] ExternalAttributionDataNotSetForExternallyAttributedConversionAction = 13,
        /// <summary>
        /// Order IDs are not supported for conversion actions which use an external
        /// attribution model.
        /// </summary>
        [pbr::OriginalName("ORDER_ID_NOT_PERMITTED_FOR_EXTERNALLY_ATTRIBUTED_CONVERSION_ACTION")] OrderIdNotPermittedForExternallyAttributedConversionAction = 14,
        /// <summary>
        /// A conversion with the same order id and conversion action combination
        /// already exists in our system.
        /// </summary>
        [pbr::OriginalName("ORDER_ID_ALREADY_IN_USE")] OrderIdAlreadyInUse = 15,
        /// <summary>
        /// The request contained two or more conversions with the same order id and
        /// conversion action combination.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ORDER_ID")] DuplicateOrderId = 16,
        /// <summary>
        /// The call occurred too recently. Please try uploading again after 6 hours
        /// have passed since the call occurred.
        /// </summary>
        [pbr::OriginalName("TOO_RECENT_CALL")] TooRecentCall = 17,
        /// <summary>
        /// The click that initiated the call is too old for this conversion to be
        /// imported.
        /// </summary>
        [pbr::OriginalName("EXPIRED_CALL")] ExpiredCall = 18,
        /// <summary>
        /// The call or the click leading to the call was not found.
        /// </summary>
        [pbr::OriginalName("CALL_NOT_FOUND")] CallNotFound = 19,
        /// <summary>
        /// The specified conversion_date_time is before the call_start_date_time.
        /// </summary>
        [pbr::OriginalName("CONVERSION_PRECEDES_CALL")] ConversionPrecedesCall = 20,
        /// <summary>
        /// The click associated with the call does not contain conversion tracking
        /// information.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TRACKING_NOT_ENABLED_AT_CALL_TIME")] ConversionTrackingNotEnabledAtCallTime = 21,
        /// <summary>
        /// The caller’s phone number cannot be parsed. It should be formatted either
        /// as E.164 "+16502531234", International "+64 3-331 6005" or US national
        /// number "6502531234".
        /// </summary>
        [pbr::OriginalName("UNPARSEABLE_CALLERS_PHONE_NUMBER")] UnparseableCallersPhoneNumber = 22,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
