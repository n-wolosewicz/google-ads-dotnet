// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/user_data_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V4.Services {
  /// <summary>
  /// Service to manage user data uploads.
  /// Accessible only to customers on the allow-list.
  /// </summary>
  public static partial class UserDataService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.UserDataService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest> __Marshaller_google_ads_googleads_v4_services_UploadUserDataRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse> __Marshaller_google_ads_googleads_v4_services_UploadUserDataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest, global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse> __Method_UploadUserData = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest, global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UploadUserData",
        __Marshaller_google_ads_googleads_v4_services_UploadUserDataRequest,
        __Marshaller_google_ads_googleads_v4_services_UploadUserDataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.UserDataServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UserDataService</summary>
    [grpc::BindServiceMethod(typeof(UserDataService), "BindService")]
    public abstract partial class UserDataServiceBase
    {
      /// <summary>
      /// Uploads the given user data.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse> UploadUserData(global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for UserDataService</summary>
    public partial class UserDataServiceClient : grpc::ClientBase<UserDataServiceClient>
    {
      /// <summary>Creates a new client for UserDataService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public UserDataServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UserDataService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public UserDataServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected UserDataServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected UserDataServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Uploads the given user data.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse UploadUserData(global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadUserData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Uploads the given user data.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse UploadUserData(global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UploadUserData, null, options, request);
      }
      /// <summary>
      /// Uploads the given user data.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse> UploadUserDataAsync(global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadUserDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Uploads the given user data.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse> UploadUserDataAsync(global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UploadUserData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override UserDataServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UserDataServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(UserDataServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_UploadUserData, serviceImpl.UploadUserData).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UserDataServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_UploadUserData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.UploadUserDataRequest, global::Google.Ads.GoogleAds.V4.Services.UploadUserDataResponse>(serviceImpl.UploadUserData));
    }

  }
}
#endregion
