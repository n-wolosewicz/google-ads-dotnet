// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/enums/change_client_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/enums/change_client_type.proto</summary>
  public static partial class ChangeClientTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/enums/change_client_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeClientTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvY2hhbmdlX2NsaWVu",
            "dF90eXBlLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTIuZW51bXMi",
            "7QIKFENoYW5nZUNsaWVudFR5cGVFbnVtItQCChBDaGFuZ2VDbGllbnRUeXBl",
            "Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhkKFUdPT0dMRV9BRFNf",
            "V0VCX0NMSUVOVBACEh0KGUdPT0dMRV9BRFNfQVVUT01BVEVEX1JVTEUQAxIW",
            "ChJHT09HTEVfQURTX1NDUklQVFMQBBIaChZHT09HTEVfQURTX0JVTEtfVVBM",
            "T0FEEAUSEgoOR09PR0xFX0FEU19BUEkQBhIVChFHT09HTEVfQURTX0VESVRP",
            "UhAHEhkKFUdPT0dMRV9BRFNfTU9CSUxFX0FQUBAIEh4KGkdPT0dMRV9BRFNf",
            "UkVDT01NRU5EQVRJT05TEAkSFwoTU0VBUkNIX0FEU18zNjBfU1lOQxAKEhcK",
            "E1NFQVJDSF9BRFNfMzYwX1BPU1QQCxIRCg1JTlRFUk5BTF9UT09MEAwSCQoF",
            "T1RIRVIQDULvAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5lbnVt",
            "c0IVQ2hhbmdlQ2xpZW50VHlwZVByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTIvZW51bXM7",
            "ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTIuRW51bXPK",
            "Ah5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTJcRW51bXPqAiJHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWMTI6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Enums.ChangeClientTypeEnum), global::Google.Ads.GoogleAds.V12.Enums.ChangeClientTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Enums.ChangeClientTypeEnum.Types.ChangeClientType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the sources that the change event resource
  /// was made through.
  /// </summary>
  public sealed partial class ChangeClientTypeEnum : pb::IMessage<ChangeClientTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeClientTypeEnum> _parser = new pb::MessageParser<ChangeClientTypeEnum>(() => new ChangeClientTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeClientTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Enums.ChangeClientTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeClientTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeClientTypeEnum(ChangeClientTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeClientTypeEnum Clone() {
      return new ChangeClientTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeClientTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeClientTypeEnum other) {
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
    public void MergeFrom(ChangeClientTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ChangeClientTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The source that the change_event resource was made through.
      /// </summary>
      public enum ChangeClientType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents an unclassified client type
        /// unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Changes made through the "ads.google.com".
        /// For example, changes made through campaign management.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_WEB_CLIENT")] GoogleAdsWebClient = 2,
        /// <summary>
        /// Changes made through Google Ads automated rules.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_AUTOMATED_RULE")] GoogleAdsAutomatedRule = 3,
        /// <summary>
        /// Changes made through Google Ads scripts.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_SCRIPTS")] GoogleAdsScripts = 4,
        /// <summary>
        /// Changes made by Google Ads bulk upload.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_BULK_UPLOAD")] GoogleAdsBulkUpload = 5,
        /// <summary>
        /// Changes made by Google Ads API.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_API")] GoogleAdsApi = 6,
        /// <summary>
        /// Changes made by Google Ads Editor. This value is a placeholder.
        /// The API does not return these changes.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_EDITOR")] GoogleAdsEditor = 7,
        /// <summary>
        /// Changes made by Google Ads mobile app.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_MOBILE_APP")] GoogleAdsMobileApp = 8,
        /// <summary>
        /// Changes made through Google Ads recommendations.
        /// </summary>
        [pbr::OriginalName("GOOGLE_ADS_RECOMMENDATIONS")] GoogleAdsRecommendations = 9,
        /// <summary>
        /// Changes made through Search Ads 360 Sync.
        /// </summary>
        [pbr::OriginalName("SEARCH_ADS_360_SYNC")] SearchAds360Sync = 10,
        /// <summary>
        /// Changes made through Search Ads 360 Post.
        /// </summary>
        [pbr::OriginalName("SEARCH_ADS_360_POST")] SearchAds360Post = 11,
        /// <summary>
        /// Changes made through internal tools.
        /// For example, when a user sets a URL template on an entity like a
        /// Campaign, it's automatically wrapped with the SA360 Clickserver URL.
        /// </summary>
        [pbr::OriginalName("INTERNAL_TOOL")] InternalTool = 12,
        /// <summary>
        /// Types of changes that are not categorized, for example,
        /// changes made by coupon redemption through Google Ads.
        /// </summary>
        [pbr::OriginalName("OTHER")] Other = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
