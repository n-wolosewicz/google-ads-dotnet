// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/google_ads_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/google_ads_field.proto</summary>
  public static partial class GoogleAdsFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/google_ads_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GoogleAdsFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvZ29vZ2xlX2Fk",
            "c19maWVsZC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVzb3Vy",
            "Y2VzGj1nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9nb29nbGVfYWRz",
            "X2ZpZWxkX2NhdGVnb3J5LnByb3RvGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92",
            "Mi9lbnVtcy9nb29nbGVfYWRzX2ZpZWxkX2RhdGFfdHlwZS5wcm90bxofZ29v",
            "Z2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItMHCg5Hb29nbGVBZHNGaWVs",
            "ZBJGCg1yZXNvdXJjZV9uYW1lGAEgASgJQi/gQQP6QSkKJ2dvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbS9Hb29nbGVBZHNGaWVsZBIvCgRuYW1lGAIgASgLMhwu",
            "Z29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQgPgQQMSZwoIY2F0ZWdvcnkY",
            "AyABKA4yUC5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lbnVtcy5Hb29nbGVB",
            "ZHNGaWVsZENhdGVnb3J5RW51bS5Hb29nbGVBZHNGaWVsZENhdGVnb3J5QgPg",
            "QQMSMwoKc2VsZWN0YWJsZRgEIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5Cb29s",
            "VmFsdWVCA+BBAxIzCgpmaWx0ZXJhYmxlGAUgASgLMhouZ29vZ2xlLnByb3Rv",
            "YnVmLkJvb2xWYWx1ZUID4EEDEjEKCHNvcnRhYmxlGAYgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLkJvb2xWYWx1ZUID4EEDEjoKD3NlbGVjdGFibGVfd2l0aBgH",
            "IAMoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EEDEj4KE2F0",
            "dHJpYnV0ZV9yZXNvdXJjZXMYCCADKAsyHC5nb29nbGUucHJvdG9idWYuU3Ry",
            "aW5nVmFsdWVCA+BBAxIyCgdtZXRyaWNzGAkgAygLMhwuZ29vZ2xlLnByb3Rv",
            "YnVmLlN0cmluZ1ZhbHVlQgPgQQMSMwoIc2VnbWVudHMYCiADKAsyHC5nb29n",
            "bGUucHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAxI2CgtlbnVtX3ZhbHVlcxgL",
            "IAMoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EEDEmgKCWRh",
            "dGFfdHlwZRgMIAEoDjJQLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1z",
            "Lkdvb2dsZUFkc0ZpZWxkRGF0YVR5cGVFbnVtLkdvb2dsZUFkc0ZpZWxkRGF0",
            "YVR5cGVCA+BBAxIzCgh0eXBlX3VybBgNIAEoCzIcLmdvb2dsZS5wcm90b2J1",
            "Zi5TdHJpbmdWYWx1ZUID4EEDEjQKC2lzX3JlcGVhdGVkGA4gASgLMhouZ29v",
            "Z2xlLnByb3RvYnVmLkJvb2xWYWx1ZUID4EEDOlDqQU0KJ2dvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbS9Hb29nbGVBZHNGaWVsZBIiZ29vZ2xlQWRzRmllbGRz",
            "L3tnb29nbGVfYWRzX2ZpZWxkfUKAAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYyLnJlc291cmNlc0ITR29vZ2xlQWRzRmllbGRQcm90b1ABWkpnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjIvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlYyLlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRz",
            "XFYyXFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYyOjpS",
            "ZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryReflection.Descriptor, global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.GoogleAdsField), global::Google.Ads.GoogleAds.V2.Resources.GoogleAdsField.Parser, new[]{ "ResourceName", "Name", "Category", "Selectable", "Filterable", "Sortable", "SelectableWith", "AttributeResources", "Metrics", "Segments", "EnumValues", "DataType", "TypeUrl", "IsRepeated" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A field or resource (artifact) used by GoogleAdsService.
  /// </summary>
  public sealed partial class GoogleAdsField : pb::IMessage<GoogleAdsField>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GoogleAdsField> _parser = new pb::MessageParser<GoogleAdsField>(() => new GoogleAdsField());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GoogleAdsField> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.GoogleAdsFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GoogleAdsField() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GoogleAdsField(GoogleAdsField other) : this() {
      resourceName_ = other.resourceName_;
      Name = other.Name;
      category_ = other.category_;
      Selectable = other.Selectable;
      Filterable = other.Filterable;
      Sortable = other.Sortable;
      selectableWith_ = other.selectableWith_.Clone();
      attributeResources_ = other.attributeResources_.Clone();
      metrics_ = other.metrics_.Clone();
      segments_ = other.segments_.Clone();
      enumValues_ = other.enumValues_.Clone();
      dataType_ = other.dataType_;
      TypeUrl = other.TypeUrl;
      IsRepeated = other.IsRepeated;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GoogleAdsField Clone() {
      return new GoogleAdsField(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the artifact.
    /// Artifact resource names have the form:
    ///
    /// `googleAdsFields/{name}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string name_;
    /// <summary>
    /// Output only. The name of the artifact.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory category_ = global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Unspecified;
    /// <summary>
    /// Output only. The category of the artifact.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "selectable" field.</summary>
    public const int SelectableFieldNumber = 4;
    private static readonly pb::FieldCodec<bool?> _single_selectable_codec = pb::FieldCodec.ForStructWrapper<bool>(34);
    private bool? selectable_;
    /// <summary>
    /// Output only. Whether the artifact can be used in a SELECT clause in search
    /// queries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Selectable {
      get { return selectable_; }
      set {
        selectable_ = value;
      }
    }


    /// <summary>Field number for the "filterable" field.</summary>
    public const int FilterableFieldNumber = 5;
    private static readonly pb::FieldCodec<bool?> _single_filterable_codec = pb::FieldCodec.ForStructWrapper<bool>(42);
    private bool? filterable_;
    /// <summary>
    /// Output only. Whether the artifact can be used in a WHERE clause in search
    /// queries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Filterable {
      get { return filterable_; }
      set {
        filterable_ = value;
      }
    }


    /// <summary>Field number for the "sortable" field.</summary>
    public const int SortableFieldNumber = 6;
    private static readonly pb::FieldCodec<bool?> _single_sortable_codec = pb::FieldCodec.ForStructWrapper<bool>(50);
    private bool? sortable_;
    /// <summary>
    /// Output only. Whether the artifact can be used in a ORDER BY clause in search
    /// queries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Sortable {
      get { return sortable_; }
      set {
        sortable_ = value;
      }
    }


    /// <summary>Field number for the "selectable_with" field.</summary>
    public const int SelectableWithFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_selectableWith_codec
        = pb::FieldCodec.ForClassWrapper<string>(58);
    private readonly pbc::RepeatedField<string> selectableWith_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. The names of all resources, segments, and metrics that are selectable with
    /// the described artifact.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> SelectableWith {
      get { return selectableWith_; }
    }

    /// <summary>Field number for the "attribute_resources" field.</summary>
    public const int AttributeResourcesFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _repeated_attributeResources_codec
        = pb::FieldCodec.ForClassWrapper<string>(66);
    private readonly pbc::RepeatedField<string> attributeResources_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. The names of all resources that are selectable with the described
    /// artifact. Fields from these resources do not segment metrics when included
    /// in search queries.
    ///
    /// This field is only set for artifacts whose category is RESOURCE.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AttributeResources {
      get { return attributeResources_; }
    }

    /// <summary>Field number for the "metrics" field.</summary>
    public const int MetricsFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _repeated_metrics_codec
        = pb::FieldCodec.ForClassWrapper<string>(74);
    private readonly pbc::RepeatedField<string> metrics_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. At and beyond version V1 this field lists the names of all metrics that are
    /// selectable with the described artifact when it is used in the FROM clause.
    /// It is only set for artifacts whose category is RESOURCE.
    ///
    /// Before version V1 this field lists the names of all metrics that are
    /// selectable with the described artifact. It is only set for artifacts whose
    /// category is either RESOURCE or SEGMENT
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Metrics {
      get { return metrics_; }
    }

    /// <summary>Field number for the "segments" field.</summary>
    public const int SegmentsFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _repeated_segments_codec
        = pb::FieldCodec.ForClassWrapper<string>(82);
    private readonly pbc::RepeatedField<string> segments_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. At and beyond version V1 this field lists the names of all artifacts,
    /// whether a segment or another resource, that segment metrics when included
    /// in search queries and when the described artifact is used in the FROM
    /// clause. It is only set for artifacts whose category is RESOURCE.
    ///
    /// Before version V1 this field lists the names of all artifacts, whether a
    /// segment or another resource, that segment metrics when included in search
    /// queries. It is only set for artifacts of category RESOURCE, SEGMENT or
    /// METRIC.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Segments {
      get { return segments_; }
    }

    /// <summary>Field number for the "enum_values" field.</summary>
    public const int EnumValuesFieldNumber = 11;
    private static readonly pb::FieldCodec<string> _repeated_enumValues_codec
        = pb::FieldCodec.ForClassWrapper<string>(90);
    private readonly pbc::RepeatedField<string> enumValues_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. Values the artifact can assume if it is a field of type ENUM.
    ///
    /// This field is only set for artifacts of category SEGMENT or ATTRIBUTE.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> EnumValues {
      get { return enumValues_; }
    }

    /// <summary>Field number for the "data_type" field.</summary>
    public const int DataTypeFieldNumber = 12;
    private global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType dataType_ = global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Unspecified;
    /// <summary>
    /// Output only. This field determines the operators that can be used with the artifact
    /// in WHERE clauses.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType DataType {
      get { return dataType_; }
      set {
        dataType_ = value;
      }
    }

    /// <summary>Field number for the "type_url" field.</summary>
    public const int TypeUrlFieldNumber = 13;
    private static readonly pb::FieldCodec<string> _single_typeUrl_codec = pb::FieldCodec.ForClassWrapper<string>(106);
    private string typeUrl_;
    /// <summary>
    /// Output only. The URL of proto describing the artifact's data type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TypeUrl {
      get { return typeUrl_; }
      set {
        typeUrl_ = value;
      }
    }


    /// <summary>Field number for the "is_repeated" field.</summary>
    public const int IsRepeatedFieldNumber = 14;
    private static readonly pb::FieldCodec<bool?> _single_isRepeated_codec = pb::FieldCodec.ForStructWrapper<bool>(114);
    private bool? isRepeated_;
    /// <summary>
    /// Output only. Whether the field artifact is repeated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? IsRepeated {
      get { return isRepeated_; }
      set {
        isRepeated_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GoogleAdsField);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GoogleAdsField other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Name != other.Name) return false;
      if (Category != other.Category) return false;
      if (Selectable != other.Selectable) return false;
      if (Filterable != other.Filterable) return false;
      if (Sortable != other.Sortable) return false;
      if(!selectableWith_.Equals(other.selectableWith_)) return false;
      if(!attributeResources_.Equals(other.attributeResources_)) return false;
      if(!metrics_.Equals(other.metrics_)) return false;
      if(!segments_.Equals(other.segments_)) return false;
      if(!enumValues_.Equals(other.enumValues_)) return false;
      if (DataType != other.DataType) return false;
      if (TypeUrl != other.TypeUrl) return false;
      if (IsRepeated != other.IsRepeated) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (Category != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Unspecified) hash ^= Category.GetHashCode();
      if (selectable_ != null) hash ^= Selectable.GetHashCode();
      if (filterable_ != null) hash ^= Filterable.GetHashCode();
      if (sortable_ != null) hash ^= Sortable.GetHashCode();
      hash ^= selectableWith_.GetHashCode();
      hash ^= attributeResources_.GetHashCode();
      hash ^= metrics_.GetHashCode();
      hash ^= segments_.GetHashCode();
      hash ^= enumValues_.GetHashCode();
      if (DataType != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Unspecified) hash ^= DataType.GetHashCode();
      if (typeUrl_ != null) hash ^= TypeUrl.GetHashCode();
      if (isRepeated_ != null) hash ^= IsRepeated.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (Category != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Category);
      }
      if (selectable_ != null) {
        _single_selectable_codec.WriteTagAndValue(output, Selectable);
      }
      if (filterable_ != null) {
        _single_filterable_codec.WriteTagAndValue(output, Filterable);
      }
      if (sortable_ != null) {
        _single_sortable_codec.WriteTagAndValue(output, Sortable);
      }
      selectableWith_.WriteTo(output, _repeated_selectableWith_codec);
      attributeResources_.WriteTo(output, _repeated_attributeResources_codec);
      metrics_.WriteTo(output, _repeated_metrics_codec);
      segments_.WriteTo(output, _repeated_segments_codec);
      enumValues_.WriteTo(output, _repeated_enumValues_codec);
      if (DataType != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Unspecified) {
        output.WriteRawTag(96);
        output.WriteEnum((int) DataType);
      }
      if (typeUrl_ != null) {
        _single_typeUrl_codec.WriteTagAndValue(output, TypeUrl);
      }
      if (isRepeated_ != null) {
        _single_isRepeated_codec.WriteTagAndValue(output, IsRepeated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(ref output, Name);
      }
      if (Category != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Category);
      }
      if (selectable_ != null) {
        _single_selectable_codec.WriteTagAndValue(ref output, Selectable);
      }
      if (filterable_ != null) {
        _single_filterable_codec.WriteTagAndValue(ref output, Filterable);
      }
      if (sortable_ != null) {
        _single_sortable_codec.WriteTagAndValue(ref output, Sortable);
      }
      selectableWith_.WriteTo(ref output, _repeated_selectableWith_codec);
      attributeResources_.WriteTo(ref output, _repeated_attributeResources_codec);
      metrics_.WriteTo(ref output, _repeated_metrics_codec);
      segments_.WriteTo(ref output, _repeated_segments_codec);
      enumValues_.WriteTo(ref output, _repeated_enumValues_codec);
      if (DataType != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Unspecified) {
        output.WriteRawTag(96);
        output.WriteEnum((int) DataType);
      }
      if (typeUrl_ != null) {
        _single_typeUrl_codec.WriteTagAndValue(ref output, TypeUrl);
      }
      if (isRepeated_ != null) {
        _single_isRepeated_codec.WriteTagAndValue(ref output, IsRepeated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (Category != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
      }
      if (selectable_ != null) {
        size += _single_selectable_codec.CalculateSizeWithTag(Selectable);
      }
      if (filterable_ != null) {
        size += _single_filterable_codec.CalculateSizeWithTag(Filterable);
      }
      if (sortable_ != null) {
        size += _single_sortable_codec.CalculateSizeWithTag(Sortable);
      }
      size += selectableWith_.CalculateSize(_repeated_selectableWith_codec);
      size += attributeResources_.CalculateSize(_repeated_attributeResources_codec);
      size += metrics_.CalculateSize(_repeated_metrics_codec);
      size += segments_.CalculateSize(_repeated_segments_codec);
      size += enumValues_.CalculateSize(_repeated_enumValues_codec);
      if (DataType != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DataType);
      }
      if (typeUrl_ != null) {
        size += _single_typeUrl_codec.CalculateSizeWithTag(TypeUrl);
      }
      if (isRepeated_ != null) {
        size += _single_isRepeated_codec.CalculateSizeWithTag(IsRepeated);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GoogleAdsField other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.Category != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Unspecified) {
        Category = other.Category;
      }
      if (other.selectable_ != null) {
        if (selectable_ == null || other.Selectable != false) {
          Selectable = other.Selectable;
        }
      }
      if (other.filterable_ != null) {
        if (filterable_ == null || other.Filterable != false) {
          Filterable = other.Filterable;
        }
      }
      if (other.sortable_ != null) {
        if (sortable_ == null || other.Sortable != false) {
          Sortable = other.Sortable;
        }
      }
      selectableWith_.Add(other.selectableWith_);
      attributeResources_.Add(other.attributeResources_);
      metrics_.Add(other.metrics_);
      segments_.Add(other.segments_);
      enumValues_.Add(other.enumValues_);
      if (other.DataType != global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Unspecified) {
        DataType = other.DataType;
      }
      if (other.typeUrl_ != null) {
        if (typeUrl_ == null || other.TypeUrl != "") {
          TypeUrl = other.TypeUrl;
        }
      }
      if (other.isRepeated_ != null) {
        if (isRepeated_ == null || other.IsRepeated != false) {
          IsRepeated = other.IsRepeated;
        }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 24: {
            Category = (global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory) input.ReadEnum();
            break;
          }
          case 34: {
            bool? value = _single_selectable_codec.Read(input);
            if (selectable_ == null || value != false) {
              Selectable = value;
            }
            break;
          }
          case 42: {
            bool? value = _single_filterable_codec.Read(input);
            if (filterable_ == null || value != false) {
              Filterable = value;
            }
            break;
          }
          case 50: {
            bool? value = _single_sortable_codec.Read(input);
            if (sortable_ == null || value != false) {
              Sortable = value;
            }
            break;
          }
          case 58: {
            selectableWith_.AddEntriesFrom(input, _repeated_selectableWith_codec);
            break;
          }
          case 66: {
            attributeResources_.AddEntriesFrom(input, _repeated_attributeResources_codec);
            break;
          }
          case 74: {
            metrics_.AddEntriesFrom(input, _repeated_metrics_codec);
            break;
          }
          case 82: {
            segments_.AddEntriesFrom(input, _repeated_segments_codec);
            break;
          }
          case 90: {
            enumValues_.AddEntriesFrom(input, _repeated_enumValues_codec);
            break;
          }
          case 96: {
            DataType = (global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType) input.ReadEnum();
            break;
          }
          case 106: {
            string value = _single_typeUrl_codec.Read(input);
            if (typeUrl_ == null || value != "") {
              TypeUrl = value;
            }
            break;
          }
          case 114: {
            bool? value = _single_isRepeated_codec.Read(input);
            if (isRepeated_ == null || value != false) {
              IsRepeated = value;
            }
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_name_codec.Read(ref input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 24: {
            Category = (global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory) input.ReadEnum();
            break;
          }
          case 34: {
            bool? value = _single_selectable_codec.Read(ref input);
            if (selectable_ == null || value != false) {
              Selectable = value;
            }
            break;
          }
          case 42: {
            bool? value = _single_filterable_codec.Read(ref input);
            if (filterable_ == null || value != false) {
              Filterable = value;
            }
            break;
          }
          case 50: {
            bool? value = _single_sortable_codec.Read(ref input);
            if (sortable_ == null || value != false) {
              Sortable = value;
            }
            break;
          }
          case 58: {
            selectableWith_.AddEntriesFrom(ref input, _repeated_selectableWith_codec);
            break;
          }
          case 66: {
            attributeResources_.AddEntriesFrom(ref input, _repeated_attributeResources_codec);
            break;
          }
          case 74: {
            metrics_.AddEntriesFrom(ref input, _repeated_metrics_codec);
            break;
          }
          case 82: {
            segments_.AddEntriesFrom(ref input, _repeated_segments_codec);
            break;
          }
          case 90: {
            enumValues_.AddEntriesFrom(ref input, _repeated_enumValues_codec);
            break;
          }
          case 96: {
            DataType = (global::Google.Ads.GoogleAds.V2.Enums.GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType) input.ReadEnum();
            break;
          }
          case 106: {
            string value = _single_typeUrl_codec.Read(ref input);
            if (typeUrl_ == null || value != "") {
              TypeUrl = value;
            }
            break;
          }
          case 114: {
            bool? value = _single_isRepeated_codec.Read(ref input);
            if (isRepeated_ == null || value != false) {
              IsRepeated = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
