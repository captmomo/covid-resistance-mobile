﻿// =========================================================================
// Copyright 2020 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

using System;

namespace Covi.Features.BluetoothTracing.TracingInformation
{
    /// <summary>
    /// Contains information required for tracing logic to work.
    /// </summary>
    public class TracingInformation
    {
        public static TracingInformation Default = new TracingInformation();

        private TracingInformation()
        {
        }

        public TracingInformation(bool enabled, string deviceId, string serviceId, string characteristicId, TimeSpan dataExpirationTime)
        {
            Enabled = enabled;
            DeviceId = deviceId;
            ServiceId = serviceId;
            CharacteristicId = characteristicId;
            DataExpirationTime = dataExpirationTime;
        }

        public bool Enabled { get; private set; }

        public string ServiceId { get; private set; }

        public string CharacteristicId { get; private set; }

        public string DeviceId { get; private set; }

        public TimeSpan DataExpirationTime { get; private set; }
    }
}