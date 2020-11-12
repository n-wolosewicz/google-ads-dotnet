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

using System;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example demonstrates how to reject a Merchant Center link request.
    /// Prerequisite: You need to have access to a Merchant Center account. You can find
    /// instructions to create a Merchant Center account here:
    /// https://support.google.com/merchants/answer/188924.
    /// To run this example, you must use the Merchant Center UI or the Content API for Shopping to
    /// send a link request between your Merchant Center and Google Ads accounts.
    /// </summary>
    public class RejectMerchantCenterLink : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            RejectMerchantCenterLink codeExample = new RejectMerchantCenterLink();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The Merchant Center account ID for the account requesting to link.
            long merchantCenterAccountId = long.Parse("INSERT_MERCHANT_CENTER_ACCOUNT_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, merchantCenterAccountId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example demonstrates how to reject a Merchant Center link request.\n" +
            "Prerequisite: You need to have access to a Merchant Center account. You can find " +
            "instructions to create a Merchant Center account here: " +
            "https://support.google.com/merchants/answer/188924.\n" +
            "To run this example, you must use the Merchant Center UI or the Content API for " +
            "Shopping to send a link request between your Merchant Center and Google Ads accounts.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="merchantCenterAccountId">The Merchant Center account ID for the account
        ///     requesting to link.</param>
        public void Run(GoogleAdsClient client, long customerId, long merchantCenterAccountId)
        {
            // Get the MerchantCenterLinkService.
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient =
                client.GetService(Services.V6.MerchantCenterLinkService);

            try
            {
                // Rejects a pending link request or unlinks an enabled link for a Google Ads
                // account with customerId from a Merchant Center account with
                // merchantCenterAccountId.
                ListMerchantCenterLinksResponse response =
                    merchantCenterLinkServiceClient.ListMerchantCenterLinks(customerId.ToString());

                Console.WriteLine($"{response.MerchantCenterLinks.Count} Merchant Center link(s) " +
                                  "found with the following details:");

                foreach (MerchantCenterLink merchantCenterLink in response.MerchantCenterLinks)
                {
                    Console.WriteLine($"Link '{merchantCenterLink.ResourceName}' has status " +
                                      $"'{merchantCenterLink.Status}'.");

                    // Checks if there is a link for the Merchant Center account we are looking for.
                    if (merchantCenterAccountId == merchantCenterLink.Id)
                    {
                        // If the Merchant Center link is pending, reject it by removing the link.
                        // If the Merchant Center link is enabled, unlink Merchant Center from
                        // Google Ads by removing the link.
                        // In both cases, the remove action is the same.
                        RemoveMerchantCenterLink(merchantCenterLinkServiceClient, customerId,
                            merchantCenterLink);
                        // There is only one MerchantCenterLink object for a given Google Ads
                        // account and Merchant Center account, so we can break early.
                        break;
                    }
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        /// <summary>
        /// Removes a Merchant Center link from a Google Ads client customer account.
        /// </summary>
        /// <param name="merchantCenterLinkServiceClient">The MerchantCenterLinkService
        ///     client.</param>
        /// <param name="customerId">The client customer ID of the Google Ads account that has the
        ///     link request.</param>
        /// <param name="merchantCenterLink">The MerchantCenterLink object to remove.</param>
        private void RemoveMerchantCenterLink(
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient,
            long customerId, MerchantCenterLink merchantCenterLink)
        {
            // Creates a single remove operation, specifying the Merchant Center link resource name.
            MerchantCenterLinkOperation operation = new MerchantCenterLinkOperation
            {
                Remove = merchantCenterLink.ResourceName
            };

            // Sends the operation in a mutate request.
            MutateMerchantCenterLinkResponse response =
                merchantCenterLinkServiceClient.MutateMerchantCenterLink(
                    customerId.ToString(), operation);
            Console.WriteLine("Removed Merchant Center Link with resource name: " +
                              $"{response.Result.ResourceName}");
        }
    }
}
