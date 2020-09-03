// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/budget_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/budget_type.proto</summary>
  public static partial class BudgetTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/budget_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BudgetTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9idWRnZXRfdHlwZS5w",
            "cm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXMaHGdvb2dsZS9h",
            "cGkvYW5ub3RhdGlvbnMucHJvdG8icwoOQnVkZ2V0VHlwZUVudW0iYQoKQnVk",
            "Z2V0VHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIMCghTVEFO",
            "REFSRBACEhgKFEhPVEVMX0FEU19DT01NSVNTSU9OEAMSDQoJRklYRURfQ1BB",
            "EARC5AEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lbnVtc0IPQnVk",
            "Z2V0VHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9lbnVtcztlbnVtc6ICA0dBQaoC",
            "HUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLkVudW1zygIdR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjNcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "Mzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.BudgetTypeEnum), global::Google.Ads.GoogleAds.V3.Enums.BudgetTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.BudgetTypeEnum.Types.BudgetType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes Budget types.
  /// </summary>
  public sealed partial class BudgetTypeEnum : pb::IMessage<BudgetTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BudgetTypeEnum> _parser = new pb::MessageParser<BudgetTypeEnum>(() => new BudgetTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BudgetTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.BudgetTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BudgetTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BudgetTypeEnum(BudgetTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BudgetTypeEnum Clone() {
      return new BudgetTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BudgetTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BudgetTypeEnum other) {
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
    public void MergeFrom(BudgetTypeEnum other) {
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
    /// <summary>Container for nested types declared in the BudgetTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible Budget types.
      /// </summary>
      public enum BudgetType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Budget type for standard Google Ads usage.
        /// Caps daily spend at two times the specified budget amount.
        /// Full details: https://support.google.com/google-ads/answer/6385083
        /// </summary>
        [pbr::OriginalName("STANDARD")] Standard = 2,
        /// <summary>
        /// Budget type for Hotels Ads commission program.
        /// Full details: https://support.google.com/google-ads/answer/9243945
        ///
        /// This type is only supported by campaigns with
        /// AdvertisingChannelType.HOTEL, BiddingStrategyType.COMMISSION and
        /// PaymentMode.CONVERSION_VALUE.
        /// </summary>
        [pbr::OriginalName("HOTEL_ADS_COMMISSION")] HotelAdsCommission = 3,
        /// <summary>
        /// Budget type with a fixed cost-per-acquisition (conversion).
        /// Full details: https://support.google.com/google-ads/answer/7528254
        ///
        /// This type is only supported by campaigns with
        /// AdvertisingChannelType.DISPLAY (excluding
        /// AdvertisingChannelSubType.DISPLAY_GMAIL),
        /// BiddingStrategyType.TARGET_CPA and PaymentMode.CONVERSIONS.
        /// </summary>
        [pbr::OriginalName("FIXED_CPA")] FixedCpa = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
