// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/offline_user_data_job_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/offline_user_data_job_type.proto</summary>
  public static partial class OfflineUserDataJobTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/offline_user_data_job_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineUserDataJobTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9vZmZsaW5lX3VzZXJf",
            "ZGF0YV9qb2JfdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMu",
            "ZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iuwEKGk9mZmxp",
            "bmVVc2VyRGF0YUpvYlR5cGVFbnVtIpwBChZPZmZsaW5lVXNlckRhdGFKb2JU",
            "eXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEiIKHlNUT1JFX1NB",
            "TEVTX1VQTE9BRF9GSVJTVF9QQVJUWRACEiIKHlNUT1JFX1NBTEVTX1VQTE9B",
            "RF9USElSRF9QQVJUWRADEhwKGENVU1RPTUVSX01BVENIX1VTRVJfTElTVBAE",
            "QvABCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXNCG09mZmxp",
            "bmVVc2VyRGF0YUpvYlR5cGVQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvZW51bXM7ZW51",
            "bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMy5FbnVtc8oCHUdv",
            "b2dsZVxBZHNcR29vZ2xlQWRzXFYzXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjM6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobTypeEnum), global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing types of an offline user data job.
  /// </summary>
  public sealed partial class OfflineUserDataJobTypeEnum : pb::IMessage<OfflineUserDataJobTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflineUserDataJobTypeEnum> _parser = new pb::MessageParser<OfflineUserDataJobTypeEnum>(() => new OfflineUserDataJobTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OfflineUserDataJobTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OfflineUserDataJobTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OfflineUserDataJobTypeEnum(OfflineUserDataJobTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OfflineUserDataJobTypeEnum Clone() {
      return new OfflineUserDataJobTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OfflineUserDataJobTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OfflineUserDataJobTypeEnum other) {
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
    public void MergeFrom(OfflineUserDataJobTypeEnum other) {
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
    /// <summary>Container for nested types declared in the OfflineUserDataJobTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The type of an offline user data job.
      /// </summary>
      public enum OfflineUserDataJobType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Store Sales Direct data for self service.
        /// </summary>
        [pbr::OriginalName("STORE_SALES_UPLOAD_FIRST_PARTY")] StoreSalesUploadFirstParty = 2,
        /// <summary>
        /// Store Sales Direct data for third party.
        /// </summary>
        [pbr::OriginalName("STORE_SALES_UPLOAD_THIRD_PARTY")] StoreSalesUploadThirdParty = 3,
        /// <summary>
        /// Customer Match user list data.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_MATCH_USER_LIST")] CustomerMatchUserList = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
