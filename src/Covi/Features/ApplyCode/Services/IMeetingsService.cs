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

using System.Collections.Generic;
using System.Threading.Tasks;
using Covi.Client.Services.Platform.Models;

namespace Covi.Features.ApplyCode.Services
{
    /// <summary>
    /// Provides operations to work with device meetings.
    /// </summary>
    public interface IMeetingsService
    {
        /// <summary>
        /// Gets recently stored meetings.
        /// </summary>
        /// <returns>Collection of device <see cref="Meeting"/>.</returns>
        Task<IReadOnlyCollection<Meeting>> GetMeetingsAsync();
    }
}