/// Copyright (C) 2012-2015 Soomla Inc.
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///      http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.

using System;
using UnityEngine;
using System.Collections.Generic;

namespace Soomla.Levelup
{

    /// <summary>
    /// This class represents a specific leaderboard provider (for example, Game Center, GPGS, etc).
    /// Each leaderboard provider needs to implement the functions in this class.
    /// </summary>
    public abstract class LeaderboardsProvider {

        public abstract void FetchFriendsStates();

        public virtual void Configure(Dictionary<string, string> providerParams) { }

        public abstract bool IsNativelyImplemented();
    }
}

