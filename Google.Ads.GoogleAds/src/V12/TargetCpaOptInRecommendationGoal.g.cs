// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/enums/target_cpa_opt_in_recommendation_goal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/enums/target_cpa_opt_in_recommendation_goal.proto</summary>
  public static partial class TargetCpaOptInRecommendationGoalReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/enums/target_cpa_opt_in_recommendation_goal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TargetCpaOptInRecommendationGoalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvdGFyZ2V0X2NwYV9v",
            "cHRfaW5fcmVjb21tZW5kYXRpb25fZ29hbC5wcm90bxIeZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjEyLmVudW1zIq0BCiRUYXJnZXRDcGFPcHRJblJlY29tbWVu",
            "ZGF0aW9uR29hbEVudW0ihAEKIFRhcmdldENwYU9wdEluUmVjb21tZW5kYXRp",
            "b25Hb2FsEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEg0KCVNBTUVf",
            "Q09TVBACEhQKEFNBTUVfQ09OVkVSU0lPTlMQAxIMCghTQU1FX0NQQRAEEg8K",
            "C0NMT1NFU1RfQ1BBEAVC/wEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTIuZW51bXNCJVRhcmdldENwYU9wdEluUmVjb21tZW5kYXRpb25Hb2FsUHJv",
            "dG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YxMi9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlYxMi5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRz",
            "XFYxMlxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMjo6RW51",
            "bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Enums.TargetCpaOptInRecommendationGoalEnum), global::Google.Ads.GoogleAds.V12.Enums.TargetCpaOptInRecommendationGoalEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Enums.TargetCpaOptInRecommendationGoalEnum.Types.TargetCpaOptInRecommendationGoal) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing goals for TargetCpaOptIn recommendation.
  /// </summary>
  public sealed partial class TargetCpaOptInRecommendationGoalEnum : pb::IMessage<TargetCpaOptInRecommendationGoalEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TargetCpaOptInRecommendationGoalEnum> _parser = new pb::MessageParser<TargetCpaOptInRecommendationGoalEnum>(() => new TargetCpaOptInRecommendationGoalEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TargetCpaOptInRecommendationGoalEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Enums.TargetCpaOptInRecommendationGoalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetCpaOptInRecommendationGoalEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetCpaOptInRecommendationGoalEnum(TargetCpaOptInRecommendationGoalEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetCpaOptInRecommendationGoalEnum Clone() {
      return new TargetCpaOptInRecommendationGoalEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TargetCpaOptInRecommendationGoalEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TargetCpaOptInRecommendationGoalEnum other) {
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
    public void MergeFrom(TargetCpaOptInRecommendationGoalEnum other) {
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
    /// <summary>Container for nested types declared in the TargetCpaOptInRecommendationGoalEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Goal of TargetCpaOptIn recommendation.
      /// </summary>
      public enum TargetCpaOptInRecommendationGoal {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Recommendation to set Target CPA to maintain the same cost.
        /// </summary>
        [pbr::OriginalName("SAME_COST")] SameCost = 2,
        /// <summary>
        /// Recommendation to set Target CPA to maintain the same conversions.
        /// </summary>
        [pbr::OriginalName("SAME_CONVERSIONS")] SameConversions = 3,
        /// <summary>
        /// Recommendation to set Target CPA to maintain the same CPA.
        /// </summary>
        [pbr::OriginalName("SAME_CPA")] SameCpa = 4,
        /// <summary>
        /// Recommendation to set Target CPA to a value that is as close as possible
        /// to, yet lower than, the actual CPA (computed for past 28 days).
        /// </summary>
        [pbr::OriginalName("CLOSEST_CPA")] ClosestCpa = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
