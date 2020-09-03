// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/feed_item_service.proto
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

namespace Google.Ads.GoogleAds.V5.Services {
  /// <summary>
  /// Service to manage feed items.
  /// </summary>
  public static partial class FeedItemService
  {
    static readonly string __ServiceName = "google.ads.googleads.v5.services.FeedItemService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest> __Marshaller_google_ads_googleads_v5_services_GetFeedItemRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Resources.FeedItem> __Marshaller_google_ads_googleads_v5_resources_FeedItem = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Resources.FeedItem.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest> __Marshaller_google_ads_googleads_v5_services_MutateFeedItemsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse> __Marshaller_google_ads_googleads_v5_services_MutateFeedItemsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest, global::Google.Ads.GoogleAds.V5.Resources.FeedItem> __Method_GetFeedItem = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest, global::Google.Ads.GoogleAds.V5.Resources.FeedItem>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFeedItem",
        __Marshaller_google_ads_googleads_v5_services_GetFeedItemRequest,
        __Marshaller_google_ads_googleads_v5_resources_FeedItem);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest, global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse> __Method_MutateFeedItems = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest, global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateFeedItems",
        __Marshaller_google_ads_googleads_v5_services_MutateFeedItemsRequest,
        __Marshaller_google_ads_googleads_v5_services_MutateFeedItemsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V5.Services.FeedItemServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FeedItemService</summary>
    [grpc::BindServiceMethod(typeof(FeedItemService), "BindService")]
    public abstract partial class FeedItemServiceBase
    {
      /// <summary>
      /// Returns the requested feed item in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Resources.FeedItem> GetFeedItem(global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes feed items. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse> MutateFeedItems(global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FeedItemService</summary>
    public partial class FeedItemServiceClient : grpc::ClientBase<FeedItemServiceClient>
    {
      /// <summary>Creates a new client for FeedItemService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FeedItemServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FeedItemService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FeedItemServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FeedItemServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FeedItemServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested feed item in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.FeedItem GetFeedItem(global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFeedItem(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested feed item in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.FeedItem GetFeedItem(global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFeedItem, null, options, request);
      }
      /// <summary>
      /// Returns the requested feed item in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.FeedItem> GetFeedItemAsync(global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFeedItemAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested feed item in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.FeedItem> GetFeedItemAsync(global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFeedItem, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes feed items. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse MutateFeedItems(global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateFeedItems(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes feed items. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse MutateFeedItems(global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateFeedItems, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes feed items. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse> MutateFeedItemsAsync(global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateFeedItemsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes feed items. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse> MutateFeedItemsAsync(global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateFeedItems, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FeedItemServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FeedItemServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FeedItemServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFeedItem, serviceImpl.GetFeedItem)
          .AddMethod(__Method_MutateFeedItems, serviceImpl.MutateFeedItems).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FeedItemServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetFeedItem, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.GetFeedItemRequest, global::Google.Ads.GoogleAds.V5.Resources.FeedItem>(serviceImpl.GetFeedItem));
      serviceBinder.AddMethod(__Method_MutateFeedItems, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsRequest, global::Google.Ads.GoogleAds.V5.Services.MutateFeedItemsResponse>(serviceImpl.MutateFeedItems));
    }

  }
}
#endregion
