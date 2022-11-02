// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/errors/recommendation_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/errors/recommendation_error.proto</summary>
  public static partial class RecommendationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/errors/recommendation_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecommendationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZXJyb3JzL3JlY29tbWVuZGF0",
            "aW9uX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIuZXJy",
            "b3JzItoDChdSZWNvbW1lbmRhdGlvbkVycm9yRW51bSK+AwoTUmVjb21tZW5k",
            "YXRpb25FcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIbChdC",
            "VURHRVRfQU1PVU5UX1RPT19TTUFMTBACEhsKF0JVREdFVF9BTU9VTlRfVE9P",
            "X0xBUkdFEAMSGQoVSU5WQUxJRF9CVURHRVRfQU1PVU5UEAQSEAoMUE9MSUNZ",
            "X0VSUk9SEAUSFgoSSU5WQUxJRF9CSURfQU1PVU5UEAYSGQoVQURHUk9VUF9L",
            "RVlXT1JEX0xJTUlUEAcSIgoeUkVDT01NRU5EQVRJT05fQUxSRUFEWV9BUFBM",
            "SUVEEAgSHgoaUkVDT01NRU5EQVRJT05fSU5WQUxJREFURUQQCRIXChNUT09f",
            "TUFOWV9PUEVSQVRJT05TEAoSEQoNTk9fT1BFUkFUSU9OUxALEiEKHURJRkZF",
            "UkVOVF9UWVBFU19OT1RfU1VQUE9SVEVEEAwSGwoXRFVQTElDQVRFX1JFU09V",
            "UkNFX05BTUUQDRIkCiBSRUNPTU1FTkRBVElPTl9BTFJFQURZX0RJU01JU1NF",
            "RBAOEhkKFUlOVkFMSURfQVBQTFlfUkVRVUVTVBAPQvgBCiNjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjEyLmVycm9yc0IYUmVjb21tZW5kYXRpb25FcnJv",
            "clByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92MTIvZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYxMi5FcnJvcnPKAh9Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMTJcRXJyb3Jz6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "VjEyOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Errors.RecommendationErrorEnum), global::Google.Ads.GoogleAds.V12.Errors.RecommendationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Errors.RecommendationErrorEnum.Types.RecommendationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible errors from applying a recommendation.
  /// </summary>
  public sealed partial class RecommendationErrorEnum : pb::IMessage<RecommendationErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RecommendationErrorEnum> _parser = new pb::MessageParser<RecommendationErrorEnum>(() => new RecommendationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RecommendationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Errors.RecommendationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommendationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommendationErrorEnum(RecommendationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecommendationErrorEnum Clone() {
      return new RecommendationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RecommendationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RecommendationErrorEnum other) {
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
    public void MergeFrom(RecommendationErrorEnum other) {
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
    /// <summary>Container for nested types declared in the RecommendationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible errors from applying a recommendation.
      /// </summary>
      public enum RecommendationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The specified budget amount is too low for example, lower than minimum
        /// currency unit or lower than ad group minimum cost-per-click.
        /// </summary>
        [pbr::OriginalName("BUDGET_AMOUNT_TOO_SMALL")] BudgetAmountTooSmall = 2,
        /// <summary>
        /// The specified budget amount is too large.
        /// </summary>
        [pbr::OriginalName("BUDGET_AMOUNT_TOO_LARGE")] BudgetAmountTooLarge = 3,
        /// <summary>
        /// The specified budget amount is not a valid amount, for example, not a
        /// multiple of minimum currency unit.
        /// </summary>
        [pbr::OriginalName("INVALID_BUDGET_AMOUNT")] InvalidBudgetAmount = 4,
        /// <summary>
        /// The specified keyword or ad violates ad policy.
        /// </summary>
        [pbr::OriginalName("POLICY_ERROR")] PolicyError = 5,
        /// <summary>
        /// The specified bid amount is not valid, for example, too many fractional
        /// digits, or negative amount.
        /// </summary>
        [pbr::OriginalName("INVALID_BID_AMOUNT")] InvalidBidAmount = 6,
        /// <summary>
        /// The number of keywords in ad group have reached the maximum allowed.
        /// </summary>
        [pbr::OriginalName("ADGROUP_KEYWORD_LIMIT")] AdgroupKeywordLimit = 7,
        /// <summary>
        /// The recommendation requested to apply has already been applied.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_ALREADY_APPLIED")] RecommendationAlreadyApplied = 8,
        /// <summary>
        /// The recommendation requested to apply has been invalidated.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_INVALIDATED")] RecommendationInvalidated = 9,
        /// <summary>
        /// The number of operations in a single request exceeds the maximum allowed.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_OPERATIONS")] TooManyOperations = 10,
        /// <summary>
        /// There are no operations in the request.
        /// </summary>
        [pbr::OriginalName("NO_OPERATIONS")] NoOperations = 11,
        /// <summary>
        /// Operations with multiple recommendation types are not supported when
        /// partial failure mode is not enabled.
        /// </summary>
        [pbr::OriginalName("DIFFERENT_TYPES_NOT_SUPPORTED")] DifferentTypesNotSupported = 12,
        /// <summary>
        /// Request contains multiple operations with the same resource_name.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_RESOURCE_NAME")] DuplicateResourceName = 13,
        /// <summary>
        /// The recommendation requested to dismiss has already been dismissed.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_ALREADY_DISMISSED")] RecommendationAlreadyDismissed = 14,
        /// <summary>
        /// The recommendation apply request was malformed and invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_APPLY_REQUEST")] InvalidApplyRequest = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
