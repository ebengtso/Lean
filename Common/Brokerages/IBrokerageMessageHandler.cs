/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

namespace QuantConnect.Brokerages
{
    /// <summary>
    /// Provides an plugin point to allow algorithms to directly handle the messages
    /// that come from their brokerage
    /// </summary>
    public interface IBrokerageMessageHandler
    {
        /// <summary>
        /// Handles the message
        /// </summary>
        /// <param name="message">The message to be handled</param>
        void HandleMessage(BrokerageMessageEvent message);

        /// <summary>
        /// Handles a new order placed manually in the brokerage side
        /// </summary>
        /// <param name="eventArgs">The new order event</param>
        /// <returns>Whether the order should be added to the transaction handler</returns>
        bool HandleOrder(NewBrokerageOrderNotificationEventArgs eventArgs);
    }
}
