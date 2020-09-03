// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/enums/campaign_experiment_traffic_split_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/enums/campaign_experiment_traffic_split_type.proto</summary>
  public static partial class CampaignExperimentTrafficSplitTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/enums/campaign_experiment_traffic_split_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignExperimentTrafficSplitTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckpnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lbnVtcy9jYW1wYWlnbl9leHBl",
            "cmltZW50X3RyYWZmaWNfc3BsaXRfdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjUuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8iigEKJkNhbXBhaWduRXhwZXJpbWVudFRyYWZmaWNTcGxpdFR5cGVFbnVt",
            "ImAKIkNhbXBhaWduRXhwZXJpbWVudFRyYWZmaWNTcGxpdFR5cGUSDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESEAoMUkFORE9NX1FVRVJZEAISCgoG",
            "Q09PS0lFEANC/AEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NS5lbnVt",
            "c0InQ2FtcGFpZ25FeHBlcmltZW50VHJhZmZpY1NwbGl0VHlwZVByb3RvUAFa",
            "Qmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92NS9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlY1LkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjVcRW51",
            "bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNTo6RW51bXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Enums.CampaignExperimentTrafficSplitTypeEnum), global::Google.Ads.GoogleAds.V5.Enums.CampaignExperimentTrafficSplitTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V5.Enums.CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing campaign experiment traffic split type.
  /// </summary>
  public sealed partial class CampaignExperimentTrafficSplitTypeEnum : pb::IMessage<CampaignExperimentTrafficSplitTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignExperimentTrafficSplitTypeEnum> _parser = new pb::MessageParser<CampaignExperimentTrafficSplitTypeEnum>(() => new CampaignExperimentTrafficSplitTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignExperimentTrafficSplitTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Enums.CampaignExperimentTrafficSplitTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignExperimentTrafficSplitTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignExperimentTrafficSplitTypeEnum(CampaignExperimentTrafficSplitTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignExperimentTrafficSplitTypeEnum Clone() {
      return new CampaignExperimentTrafficSplitTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignExperimentTrafficSplitTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignExperimentTrafficSplitTypeEnum other) {
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
    public void MergeFrom(CampaignExperimentTrafficSplitTypeEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignExperimentTrafficSplitTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum of strategies for splitting traffic between base and experiment
      /// campaigns in campaign experiment.
      /// </summary>
      public enum CampaignExperimentTrafficSplitType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Traffic is randomly assigned to the base or experiment arm for each
        /// query, independent of previous assignments for the same user.
        /// </summary>
        [pbr::OriginalName("RANDOM_QUERY")] RandomQuery = 2,
        /// <summary>
        /// Traffic is split using cookies to keep users in the same arm (base or
        /// experiment) of the experiment.
        /// </summary>
        [pbr::OriginalName("COOKIE")] Cookie = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
