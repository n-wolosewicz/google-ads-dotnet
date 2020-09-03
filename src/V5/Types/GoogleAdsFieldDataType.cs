// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/enums/google_ads_field_data_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/enums/google_ads_field_data_type.proto</summary>
  public static partial class GoogleAdsFieldDataTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/enums/google_ads_field_data_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GoogleAdsFieldDataTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lbnVtcy9nb29nbGVfYWRzX2Zp",
            "ZWxkX2RhdGFfdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUu",
            "ZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i2wEKGkdvb2ds",
            "ZUFkc0ZpZWxkRGF0YVR5cGVFbnVtIrwBChZHb29nbGVBZHNGaWVsZERhdGFU",
            "eXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgsKB0JPT0xFQU4Q",
            "AhIICgREQVRFEAMSCgoGRE9VQkxFEAQSCAoERU5VTRAFEgkKBUZMT0FUEAYS",
            "CQoFSU5UMzIQBxIJCgVJTlQ2NBAIEgsKB01FU1NBR0UQCRIRCg1SRVNPVVJD",
            "RV9OQU1FEAoSCgoGU1RSSU5HEAsSCgoGVUlOVDY0EAxC8AEKIWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52NS5lbnVtc0IbR29vZ2xlQWRzRmllbGREYXRh",
            "VHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92NS9lbnVtcztlbnVtc6ICA0dBQaoCHUdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlY1LkVudW1zygIdR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjVcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNTo6",
            "RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Enums.GoogleAdsFieldDataTypeEnum), global::Google.Ads.GoogleAds.V5.Enums.GoogleAdsFieldDataTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V5.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container holding the various data types.
  /// </summary>
  public sealed partial class GoogleAdsFieldDataTypeEnum : pb::IMessage<GoogleAdsFieldDataTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GoogleAdsFieldDataTypeEnum> _parser = new pb::MessageParser<GoogleAdsFieldDataTypeEnum>(() => new GoogleAdsFieldDataTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GoogleAdsFieldDataTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Enums.GoogleAdsFieldDataTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GoogleAdsFieldDataTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GoogleAdsFieldDataTypeEnum(GoogleAdsFieldDataTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GoogleAdsFieldDataTypeEnum Clone() {
      return new GoogleAdsFieldDataTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GoogleAdsFieldDataTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GoogleAdsFieldDataTypeEnum other) {
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
    public void MergeFrom(GoogleAdsFieldDataTypeEnum other) {
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
    /// <summary>Container for nested types declared in the GoogleAdsFieldDataTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// These are the various types a GoogleAdsService artifact may take on.
      /// </summary>
      public enum GoogleAdsFieldDataType {
        /// <summary>
        /// Unspecified
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Unknown
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Maps to google.protobuf.BoolValue
        ///
        /// Applicable operators:  =, !=
        /// </summary>
        [pbr::OriginalName("BOOLEAN")] Boolean = 2,
        /// <summary>
        /// Maps to google.protobuf.StringValue. It can be compared using the set of
        /// operators specific to dates however.
        ///
        /// Applicable operators:  =, &lt;, >, &lt;=, >=, BETWEEN, DURING, and IN
        /// </summary>
        [pbr::OriginalName("DATE")] Date = 3,
        /// <summary>
        /// Maps to google.protobuf.DoubleValue
        ///
        /// Applicable operators:  =, !=, &lt;, >, IN, NOT IN
        /// </summary>
        [pbr::OriginalName("DOUBLE")] Double = 4,
        /// <summary>
        /// Maps to an enum. It's specific definition can be found at type_url.
        ///
        /// Applicable operators:  =, !=, IN, NOT IN
        /// </summary>
        [pbr::OriginalName("ENUM")] Enum = 5,
        /// <summary>
        /// Maps to google.protobuf.FloatValue
        ///
        /// Applicable operators:  =, !=, &lt;, >, IN, NOT IN
        /// </summary>
        [pbr::OriginalName("FLOAT")] Float = 6,
        /// <summary>
        /// Maps to google.protobuf.Int32Value
        ///
        /// Applicable operators:  =, !=, &lt;, >, &lt;=, >=, BETWEEN, IN, NOT IN
        /// </summary>
        [pbr::OriginalName("INT32")] Int32 = 7,
        /// <summary>
        /// Maps to google.protobuf.Int64Value
        ///
        /// Applicable operators:  =, !=, &lt;, >, &lt;=, >=, BETWEEN, IN, NOT IN
        /// </summary>
        [pbr::OriginalName("INT64")] Int64 = 8,
        /// <summary>
        /// Maps to a protocol buffer message type. The data type's details can be
        /// found in type_url.
        ///
        /// No operators work with MESSAGE fields.
        /// </summary>
        [pbr::OriginalName("MESSAGE")] Message = 9,
        /// <summary>
        /// Maps to google.protobuf.StringValue. Represents the resource name
        /// (unique id) of a resource or one of its foreign keys.
        ///
        /// No operators work with RESOURCE_NAME fields.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NAME")] ResourceName = 10,
        /// <summary>
        /// Maps to google.protobuf.StringValue.
        ///
        /// Applicable operators:  =, !=, LIKE, NOT LIKE, IN, NOT IN
        /// </summary>
        [pbr::OriginalName("STRING")] String = 11,
        /// <summary>
        /// Maps to google.protobuf.UInt64Value
        ///
        /// Applicable operators:  =, !=, &lt;, >, &lt;=, >=, BETWEEN, IN, NOT IN
        /// </summary>
        [pbr::OriginalName("UINT64")] Uint64 = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
