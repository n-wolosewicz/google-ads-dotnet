// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/hotel_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/hotel_placeholder_field.proto</summary>
  public static partial class HotelPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/hotel_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HotelPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9ob3RlbF9wbGFjZWhv",
            "bGRlcl9maWVsZC5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuZW51",
            "bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8izQMKGUhvdGVsUGxh",
            "Y2Vob2xkZXJGaWVsZEVudW0irwMKFUhvdGVsUGxhY2Vob2xkZXJGaWVsZBIP",
            "CgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIPCgtQUk9QRVJUWV9JRBAC",
            "EhEKDVBST1BFUlRZX05BTUUQAxIUChBERVNUSU5BVElPTl9OQU1FEAQSDwoL",
            "REVTQ1JJUFRJT04QBRILCgdBRERSRVNTEAYSCQoFUFJJQ0UQBxITCg9GT1JN",
            "QVRURURfUFJJQ0UQCBIOCgpTQUxFX1BSSUNFEAkSGAoURk9STUFUVEVEX1NB",
            "TEVfUFJJQ0UQChINCglJTUFHRV9VUkwQCxIMCghDQVRFR09SWRAMEg8KC1NU",
            "QVJfUkFUSU5HEA0SFwoTQ09OVEVYVFVBTF9LRVlXT1JEUxAOEg4KCkZJTkFM",
            "X1VSTFMQDxIVChFGSU5BTF9NT0JJTEVfVVJMUxAQEhAKDFRSQUNLSU5HX1VS",
            "TBAREhQKEEFORFJPSURfQVBQX0xJTksQEhIYChRTSU1JTEFSX1BST1BFUlRZ",
            "X0lEUxATEhAKDElPU19BUFBfTElOSxAUEhQKEElPU19BUFBfU1RPUkVfSUQQ",
            "FULwAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LmVudW1zQhtIb3Rl",
            "bHNQbGFjZWhvbGRlckZpZWxkUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L2VudW1zO2Vu",
            "dW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjQuRW51bXPKAh1H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWNFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlY0OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.HotelPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V4.Enums.HotelPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.HotelPlaceholderFieldEnum.Types.HotelPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Hotel placeholder fields.
  /// For more information about dynamic remarketing feeds, see
  /// https://support.google.com/google-ads/answer/6053288.
  /// </summary>
  public sealed partial class HotelPlaceholderFieldEnum : pb::IMessage<HotelPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HotelPlaceholderFieldEnum> _parser = new pb::MessageParser<HotelPlaceholderFieldEnum>(() => new HotelPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HotelPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Enums.HotelPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HotelPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HotelPlaceholderFieldEnum(HotelPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HotelPlaceholderFieldEnum Clone() {
      return new HotelPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HotelPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HotelPlaceholderFieldEnum other) {
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
    public void MergeFrom(HotelPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the HotelPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Hotel placeholder fields.
      /// </summary>
      public enum HotelPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. Required. Unique ID.
        /// </summary>
        [pbr::OriginalName("PROPERTY_ID")] PropertyId = 2,
        /// <summary>
        /// Data Type: STRING. Required. Main headline with property name to be shown
        /// in dynamic ad.
        /// </summary>
        [pbr::OriginalName("PROPERTY_NAME")] PropertyName = 3,
        /// <summary>
        /// Data Type: STRING. Name of destination to be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("DESTINATION_NAME")] DestinationName = 4,
        /// <summary>
        /// Data Type: STRING. Description of destination to be shown in dynamic ad.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION")] Description = 5,
        /// <summary>
        /// Data Type: STRING. Complete property address, including postal code.
        /// </summary>
        [pbr::OriginalName("ADDRESS")] Address = 6,
        /// <summary>
        /// Data Type: STRING. Price to be shown in the ad.
        /// Example: "100.00 USD"
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 7,
        /// <summary>
        /// Data Type: STRING. Formatted price to be shown in the ad.
        /// Example: "Starting at $100.00 USD", "$80 - $100"
        /// </summary>
        [pbr::OriginalName("FORMATTED_PRICE")] FormattedPrice = 8,
        /// <summary>
        /// Data Type: STRING. Sale price to be shown in the ad.
        /// Example: "80.00 USD"
        /// </summary>
        [pbr::OriginalName("SALE_PRICE")] SalePrice = 9,
        /// <summary>
        /// Data Type: STRING. Formatted sale price to be shown in the ad.
        /// Example: "On sale for $80.00", "$60 - $80"
        /// </summary>
        [pbr::OriginalName("FORMATTED_SALE_PRICE")] FormattedSalePrice = 10,
        /// <summary>
        /// Data Type: URL. Image to be displayed in the ad.
        /// </summary>
        [pbr::OriginalName("IMAGE_URL")] ImageUrl = 11,
        /// <summary>
        /// Data Type: STRING. Category of property used to group like items together
        /// for recommendation engine.
        /// </summary>
        [pbr::OriginalName("CATEGORY")] Category = 12,
        /// <summary>
        /// Data Type: INT64. Star rating (1 to 5) used to group like items
        /// together for recommendation engine.
        /// </summary>
        [pbr::OriginalName("STAR_RATING")] StarRating = 13,
        /// <summary>
        /// Data Type: STRING_LIST. Keywords used for product retrieval.
        /// </summary>
        [pbr::OriginalName("CONTEXTUAL_KEYWORDS")] ContextualKeywords = 14,
        /// <summary>
        /// Data Type: URL_LIST. Required. Final URLs for the ad when using Upgraded
        /// URLs. User will be redirected to these URLs when they click on an ad, or
        /// when they click on a specific flight for ads that show multiple
        /// flights.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS")] FinalUrls = 15,
        /// <summary>
        /// Data Type: URL_LIST. Final mobile URLs for the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS")] FinalMobileUrls = 16,
        /// <summary>
        /// Data Type: URL. Tracking template for the ad when using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 17,
        /// <summary>
        /// Data Type: STRING. Android app link. Must be formatted as:
        /// android-app://{package_id}/{scheme}/{host_path}.
        /// The components are defined as follows:
        /// package_id: app ID as specified in Google Play.
        /// scheme: the scheme to pass to the application. Can be HTTP, or a custom
        ///   scheme.
        /// host_path: identifies the specific content within your application.
        /// </summary>
        [pbr::OriginalName("ANDROID_APP_LINK")] AndroidAppLink = 18,
        /// <summary>
        /// Data Type: STRING_LIST. List of recommended property IDs to show together
        /// with this item.
        /// </summary>
        [pbr::OriginalName("SIMILAR_PROPERTY_IDS")] SimilarPropertyIds = 19,
        /// <summary>
        /// Data Type: STRING. iOS app link.
        /// </summary>
        [pbr::OriginalName("IOS_APP_LINK")] IosAppLink = 20,
        /// <summary>
        /// Data Type: INT64. iOS app store ID.
        /// </summary>
        [pbr::OriginalName("IOS_APP_STORE_ID")] IosAppStoreId = 21,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
