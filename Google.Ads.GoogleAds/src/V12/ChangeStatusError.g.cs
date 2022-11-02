// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/errors/change_status_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/errors/change_status_error.proto</summary>
  public static partial class ChangeStatusErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/errors/change_status_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeStatusErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZXJyb3JzL2NoYW5nZV9zdGF0",
            "dXNfZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5lcnJv",
            "cnMi1gEKFUNoYW5nZVN0YXR1c0Vycm9yRW51bSK8AQoRQ2hhbmdlU3RhdHVz",
            "RXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESFgoSU1RBUlRf",
            "REFURV9UT09fT0xEEAMSHgoaQ0hBTkdFX0RBVEVfUkFOR0VfSU5GSU5JVEUQ",
            "BBIeChpDSEFOR0VfREFURV9SQU5HRV9ORUdBVElWRRAFEhcKE0xJTUlUX05P",
            "VF9TUEVDSUZJRUQQBhIYChRJTlZBTElEX0xJTUlUX0NMQVVTRRAHQvYBCiNj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLmVycm9yc0IWQ2hhbmdlU3Rh",
            "dHVzRXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEyL2Vycm9ycztlcnJvcnOiAgNH",
            "QUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTIuRXJyb3JzygIfR29vZ2xl",
            "XEFkc1xHb29nbGVBZHNcVjEyXEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYxMjo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Errors.ChangeStatusErrorEnum), global::Google.Ads.GoogleAds.V12.Errors.ChangeStatusErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V12.Errors.ChangeStatusErrorEnum.Types.ChangeStatusError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible change status errors.
  /// </summary>
  public sealed partial class ChangeStatusErrorEnum : pb::IMessage<ChangeStatusErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeStatusErrorEnum> _parser = new pb::MessageParser<ChangeStatusErrorEnum>(() => new ChangeStatusErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeStatusErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Errors.ChangeStatusErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeStatusErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeStatusErrorEnum(ChangeStatusErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeStatusErrorEnum Clone() {
      return new ChangeStatusErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeStatusErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeStatusErrorEnum other) {
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
    public void MergeFrom(ChangeStatusErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ChangeStatusErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible change status errors.
      /// </summary>
      public enum ChangeStatusError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The requested start date is too old.
        /// </summary>
        [pbr::OriginalName("START_DATE_TOO_OLD")] StartDateTooOld = 3,
        /// <summary>
        /// The change_status search request must specify a finite range filter
        /// on last_change_date_time.
        /// </summary>
        [pbr::OriginalName("CHANGE_DATE_RANGE_INFINITE")] ChangeDateRangeInfinite = 4,
        /// <summary>
        /// The change status search request has specified invalid date time filters
        /// that can never logically produce any valid results (for example, start
        /// time after end time).
        /// </summary>
        [pbr::OriginalName("CHANGE_DATE_RANGE_NEGATIVE")] ChangeDateRangeNegative = 5,
        /// <summary>
        /// The change_status search request must specify a LIMIT.
        /// </summary>
        [pbr::OriginalName("LIMIT_NOT_SPECIFIED")] LimitNotSpecified = 6,
        /// <summary>
        /// The LIMIT specified by change_status request should be less than or equal
        /// to 10K.
        /// </summary>
        [pbr::OriginalName("INVALID_LIMIT_CLAUSE")] InvalidLimitClause = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
