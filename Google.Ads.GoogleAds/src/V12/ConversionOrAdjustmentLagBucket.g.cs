// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/enums/conversion_or_adjustment_lag_bucket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/enums/conversion_or_adjustment_lag_bucket.proto</summary>
  public static partial class ConversionOrAdjustmentLagBucketReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/enums/conversion_or_adjustment_lag_bucket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionOrAdjustmentLagBucketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvY29udmVyc2lvbl9v",
            "cl9hZGp1c3RtZW50X2xhZ19idWNrZXQucHJvdG8SHmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxMi5lbnVtcyLLDAojQ29udmVyc2lvbk9yQWRqdXN0bWVudExh",
            "Z0J1Y2tldEVudW0iowwKH0NvbnZlcnNpb25PckFkanVzdG1lbnRMYWdCdWNr",
            "ZXQSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESIAocQ09OVkVSU0lP",
            "Tl9MRVNTX1RIQU5fT05FX0RBWRACEh4KGkNPTlZFUlNJT05fT05FX1RPX1RX",
            "T19EQVlTEAMSIAocQ09OVkVSU0lPTl9UV09fVE9fVEhSRUVfREFZUxAEEiEK",
            "HUNPTlZFUlNJT05fVEhSRUVfVE9fRk9VUl9EQVlTEAUSIAocQ09OVkVSU0lP",
            "Tl9GT1VSX1RPX0ZJVkVfREFZUxAGEh8KG0NPTlZFUlNJT05fRklWRV9UT19T",
            "SVhfREFZUxAHEiAKHENPTlZFUlNJT05fU0lYX1RPX1NFVkVOX0RBWVMQCBIi",
            "Ch5DT05WRVJTSU9OX1NFVkVOX1RPX0VJR0hUX0RBWVMQCRIhCh1DT05WRVJT",
            "SU9OX0VJR0hUX1RPX05JTkVfREFZUxAKEh8KG0NPTlZFUlNJT05fTklORV9U",
            "T19URU5fREFZUxALEiEKHUNPTlZFUlNJT05fVEVOX1RPX0VMRVZFTl9EQVlT",
            "EAwSJAogQ09OVkVSU0lPTl9FTEVWRU5fVE9fVFdFTFZFX0RBWVMQDRImCiJD",
            "T05WRVJTSU9OX1RXRUxWRV9UT19USElSVEVFTl9EQVlTEA4SKAokQ09OVkVS",
            "U0lPTl9USElSVEVFTl9UT19GT1VSVEVFTl9EQVlTEA8SKgomQ09OVkVSU0lP",
            "Tl9GT1VSVEVFTl9UT19UV0VOVFlfT05FX0RBWVMQEBIoCiRDT05WRVJTSU9O",
            "X1RXRU5UWV9PTkVfVE9fVEhJUlRZX0RBWVMQERIoCiRDT05WRVJTSU9OX1RI",
            "SVJUWV9UT19GT1JUWV9GSVZFX0RBWVMQEhInCiNDT05WRVJTSU9OX0ZPUlRZ",
            "X0ZJVkVfVE9fU0lYVFlfREFZUxATEiMKH0NPTlZFUlNJT05fU0lYVFlfVE9f",
            "TklORVRZX0RBWVMQFBIgChxBREpVU1RNRU5UX0xFU1NfVEhBTl9PTkVfREFZ",
            "EBUSHgoaQURKVVNUTUVOVF9PTkVfVE9fVFdPX0RBWVMQFhIgChxBREpVU1RN",
            "RU5UX1RXT19UT19USFJFRV9EQVlTEBcSIQodQURKVVNUTUVOVF9USFJFRV9U",
            "T19GT1VSX0RBWVMQGBIgChxBREpVU1RNRU5UX0ZPVVJfVE9fRklWRV9EQVlT",
            "EBkSHwobQURKVVNUTUVOVF9GSVZFX1RPX1NJWF9EQVlTEBoSIAocQURKVVNU",
            "TUVOVF9TSVhfVE9fU0VWRU5fREFZUxAbEiIKHkFESlVTVE1FTlRfU0VWRU5f",
            "VE9fRUlHSFRfREFZUxAcEiEKHUFESlVTVE1FTlRfRUlHSFRfVE9fTklORV9E",
            "QVlTEB0SHwobQURKVVNUTUVOVF9OSU5FX1RPX1RFTl9EQVlTEB4SIQodQURK",
            "VVNUTUVOVF9URU5fVE9fRUxFVkVOX0RBWVMQHxIkCiBBREpVU1RNRU5UX0VM",
            "RVZFTl9UT19UV0VMVkVfREFZUxAgEiYKIkFESlVTVE1FTlRfVFdFTFZFX1RP",
            "X1RISVJURUVOX0RBWVMQIRIoCiRBREpVU1RNRU5UX1RISVJURUVOX1RPX0ZP",
            "VVJURUVOX0RBWVMQIhIqCiZBREpVU1RNRU5UX0ZPVVJURUVOX1RPX1RXRU5U",
            "WV9PTkVfREFZUxAjEigKJEFESlVTVE1FTlRfVFdFTlRZX09ORV9UT19USElS",
            "VFlfREFZUxAkEigKJEFESlVTVE1FTlRfVEhJUlRZX1RPX0ZPUlRZX0ZJVkVf",
            "REFZUxAlEicKI0FESlVTVE1FTlRfRk9SVFlfRklWRV9UT19TSVhUWV9EQVlT",
            "ECYSIwofQURKVVNUTUVOVF9TSVhUWV9UT19OSU5FVFlfREFZUxAnEjgKNEFE",
            "SlVTVE1FTlRfTklORVRZX1RPX09ORV9IVU5EUkVEX0FORF9GT1JUWV9GSVZF",
            "X0RBWVMQKBIWChJDT05WRVJTSU9OX1VOS05PV04QKRIWChJBREpVU1RNRU5U",
            "X1VOS05PV04QKkL+AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5l",
            "bnVtc0IkQ29udmVyc2lvbk9yQWRqdXN0bWVudExhZ0J1Y2tldFByb3RvUAFa",
            "Q2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92MTIvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMTIuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTJc",
            "RW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTI6OkVudW1zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Enums.ConversionOrAdjustmentLagBucketEnum), global::Google.Ads.GoogleAds.V12.Enums.ConversionOrAdjustmentLagBucketEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Enums.ConversionOrAdjustmentLagBucketEnum.Types.ConversionOrAdjustmentLagBucket) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum representing the number of days between the impression and
  /// the conversion or between the impression and adjustments to the conversion.
  /// </summary>
  public sealed partial class ConversionOrAdjustmentLagBucketEnum : pb::IMessage<ConversionOrAdjustmentLagBucketEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionOrAdjustmentLagBucketEnum> _parser = new pb::MessageParser<ConversionOrAdjustmentLagBucketEnum>(() => new ConversionOrAdjustmentLagBucketEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionOrAdjustmentLagBucketEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Enums.ConversionOrAdjustmentLagBucketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionOrAdjustmentLagBucketEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionOrAdjustmentLagBucketEnum(ConversionOrAdjustmentLagBucketEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionOrAdjustmentLagBucketEnum Clone() {
      return new ConversionOrAdjustmentLagBucketEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionOrAdjustmentLagBucketEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionOrAdjustmentLagBucketEnum other) {
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
    public void MergeFrom(ConversionOrAdjustmentLagBucketEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionOrAdjustmentLagBucketEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum representing the number of days between the impression and the
      /// conversion or between the impression and adjustments to the conversion.
      /// </summary>
      public enum ConversionOrAdjustmentLagBucket {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Conversion lag bucket from 0 to 1 day. 0 day is included, 1 day is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_LESS_THAN_ONE_DAY")] ConversionLessThanOneDay = 2,
        /// <summary>
        /// Conversion lag bucket from 1 to 2 days. 1 day is included, 2 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_ONE_TO_TWO_DAYS")] ConversionOneToTwoDays = 3,
        /// <summary>
        /// Conversion lag bucket from 2 to 3 days. 2 days is included,
        /// 3 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TWO_TO_THREE_DAYS")] ConversionTwoToThreeDays = 4,
        /// <summary>
        /// Conversion lag bucket from 3 to 4 days. 3 days is included,
        /// 4 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_THREE_TO_FOUR_DAYS")] ConversionThreeToFourDays = 5,
        /// <summary>
        /// Conversion lag bucket from 4 to 5 days. 4 days is included,
        /// 5 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_FOUR_TO_FIVE_DAYS")] ConversionFourToFiveDays = 6,
        /// <summary>
        /// Conversion lag bucket from 5 to 6 days. 5 days is included,
        /// 6 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_FIVE_TO_SIX_DAYS")] ConversionFiveToSixDays = 7,
        /// <summary>
        /// Conversion lag bucket from 6 to 7 days. 6 days is included,
        /// 7 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_SIX_TO_SEVEN_DAYS")] ConversionSixToSevenDays = 8,
        /// <summary>
        /// Conversion lag bucket from 7 to 8 days. 7 days is included,
        /// 8 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_SEVEN_TO_EIGHT_DAYS")] ConversionSevenToEightDays = 9,
        /// <summary>
        /// Conversion lag bucket from 8 to 9 days. 8 days is included,
        /// 9 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_EIGHT_TO_NINE_DAYS")] ConversionEightToNineDays = 10,
        /// <summary>
        /// Conversion lag bucket from 9 to 10 days. 9 days is included,
        /// 10 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_NINE_TO_TEN_DAYS")] ConversionNineToTenDays = 11,
        /// <summary>
        /// Conversion lag bucket from 10 to 11 days. 10 days is included,
        /// 11 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TEN_TO_ELEVEN_DAYS")] ConversionTenToElevenDays = 12,
        /// <summary>
        /// Conversion lag bucket from 11 to 12 days. 11 days is included,
        /// 12 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_ELEVEN_TO_TWELVE_DAYS")] ConversionElevenToTwelveDays = 13,
        /// <summary>
        /// Conversion lag bucket from 12 to 13 days. 12 days is included,
        /// 13 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TWELVE_TO_THIRTEEN_DAYS")] ConversionTwelveToThirteenDays = 14,
        /// <summary>
        /// Conversion lag bucket from 13 to 14 days. 13 days is included,
        /// 14 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_THIRTEEN_TO_FOURTEEN_DAYS")] ConversionThirteenToFourteenDays = 15,
        /// <summary>
        /// Conversion lag bucket from 14 to 21 days. 14 days is included,
        /// 21 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_FOURTEEN_TO_TWENTY_ONE_DAYS")] ConversionFourteenToTwentyOneDays = 16,
        /// <summary>
        /// Conversion lag bucket from 21 to 30 days. 21 days is included,
        /// 30 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TWENTY_ONE_TO_THIRTY_DAYS")] ConversionTwentyOneToThirtyDays = 17,
        /// <summary>
        /// Conversion lag bucket from 30 to 45 days. 30 days is included,
        /// 45 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_THIRTY_TO_FORTY_FIVE_DAYS")] ConversionThirtyToFortyFiveDays = 18,
        /// <summary>
        /// Conversion lag bucket from 45 to 60 days. 45 days is included,
        /// 60 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_FORTY_FIVE_TO_SIXTY_DAYS")] ConversionFortyFiveToSixtyDays = 19,
        /// <summary>
        /// Conversion lag bucket from 60 to 90 days. 60 days is included,
        /// 90 days is not.
        /// </summary>
        [pbr::OriginalName("CONVERSION_SIXTY_TO_NINETY_DAYS")] ConversionSixtyToNinetyDays = 20,
        /// <summary>
        /// Conversion adjustment lag bucket from 0 to 1 day. 0 day is included,
        /// 1 day is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_LESS_THAN_ONE_DAY")] AdjustmentLessThanOneDay = 21,
        /// <summary>
        /// Conversion adjustment lag bucket from 1 to 2 days. 1 day is included,
        /// 2 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_ONE_TO_TWO_DAYS")] AdjustmentOneToTwoDays = 22,
        /// <summary>
        /// Conversion adjustment lag bucket from 2 to 3 days. 2 days is included,
        /// 3 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_TWO_TO_THREE_DAYS")] AdjustmentTwoToThreeDays = 23,
        /// <summary>
        /// Conversion adjustment lag bucket from 3 to 4 days. 3 days is included,
        /// 4 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_THREE_TO_FOUR_DAYS")] AdjustmentThreeToFourDays = 24,
        /// <summary>
        /// Conversion adjustment lag bucket from 4 to 5 days. 4 days is included,
        /// 5 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_FOUR_TO_FIVE_DAYS")] AdjustmentFourToFiveDays = 25,
        /// <summary>
        /// Conversion adjustment lag bucket from 5 to 6 days. 5 days is included,
        /// 6 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_FIVE_TO_SIX_DAYS")] AdjustmentFiveToSixDays = 26,
        /// <summary>
        /// Conversion adjustment lag bucket from 6 to 7 days. 6 days is included,
        /// 7 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_SIX_TO_SEVEN_DAYS")] AdjustmentSixToSevenDays = 27,
        /// <summary>
        /// Conversion adjustment lag bucket from 7 to 8 days. 7 days is included,
        /// 8 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_SEVEN_TO_EIGHT_DAYS")] AdjustmentSevenToEightDays = 28,
        /// <summary>
        /// Conversion adjustment lag bucket from 8 to 9 days. 8 days is included,
        /// 9 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_EIGHT_TO_NINE_DAYS")] AdjustmentEightToNineDays = 29,
        /// <summary>
        /// Conversion adjustment lag bucket from 9 to 10 days. 9 days is included,
        /// 10 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_NINE_TO_TEN_DAYS")] AdjustmentNineToTenDays = 30,
        /// <summary>
        /// Conversion adjustment lag bucket from 10 to 11 days. 10 days is included,
        /// 11 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_TEN_TO_ELEVEN_DAYS")] AdjustmentTenToElevenDays = 31,
        /// <summary>
        /// Conversion adjustment lag bucket from 11 to 12 days. 11 days is included,
        /// 12 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_ELEVEN_TO_TWELVE_DAYS")] AdjustmentElevenToTwelveDays = 32,
        /// <summary>
        /// Conversion adjustment lag bucket from 12 to 13 days. 12 days is included,
        /// 13 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_TWELVE_TO_THIRTEEN_DAYS")] AdjustmentTwelveToThirteenDays = 33,
        /// <summary>
        /// Conversion adjustment lag bucket from 13 to 14 days. 13 days is included,
        /// 14 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_THIRTEEN_TO_FOURTEEN_DAYS")] AdjustmentThirteenToFourteenDays = 34,
        /// <summary>
        /// Conversion adjustment lag bucket from 14 to 21 days. 14 days is included,
        /// 21 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_FOURTEEN_TO_TWENTY_ONE_DAYS")] AdjustmentFourteenToTwentyOneDays = 35,
        /// <summary>
        /// Conversion adjustment lag bucket from 21 to 30 days. 21 days is included,
        /// 30 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_TWENTY_ONE_TO_THIRTY_DAYS")] AdjustmentTwentyOneToThirtyDays = 36,
        /// <summary>
        /// Conversion adjustment lag bucket from 30 to 45 days. 30 days is included,
        /// 45 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_THIRTY_TO_FORTY_FIVE_DAYS")] AdjustmentThirtyToFortyFiveDays = 37,
        /// <summary>
        /// Conversion adjustment lag bucket from 45 to 60 days. 45 days is included,
        /// 60 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_FORTY_FIVE_TO_SIXTY_DAYS")] AdjustmentFortyFiveToSixtyDays = 38,
        /// <summary>
        /// Conversion adjustment lag bucket from 60 to 90 days. 60 days is included,
        /// 90 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_SIXTY_TO_NINETY_DAYS")] AdjustmentSixtyToNinetyDays = 39,
        /// <summary>
        /// Conversion adjustment lag bucket from 90 to 145 days. 90 days is
        /// included, 145 days is not.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_NINETY_TO_ONE_HUNDRED_AND_FORTY_FIVE_DAYS")] AdjustmentNinetyToOneHundredAndFortyFiveDays = 40,
        /// <summary>
        /// Conversion lag bucket UNKNOWN. This is for dates before conversion lag
        /// bucket was available in Google Ads.
        /// </summary>
        [pbr::OriginalName("CONVERSION_UNKNOWN")] ConversionUnknown = 41,
        /// <summary>
        /// Conversion adjustment lag bucket UNKNOWN. This is for dates before
        /// conversion adjustment lag bucket was available in Google Ads.
        /// </summary>
        [pbr::OriginalName("ADJUSTMENT_UNKNOWN")] AdjustmentUnknown = 42,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
