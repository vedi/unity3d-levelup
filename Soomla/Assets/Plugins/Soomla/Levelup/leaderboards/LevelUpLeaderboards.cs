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
///

using System;
using UnityEngine;
using System.Collections.Generic;

namespace Soomla.Levelup {

    public class LevelUpLeaderboards {

        private static LeaderboardsProvider _instance;

        public static void Initialize() {
#if UNITY_IOS
            _instance = new GameCenterLeaderboardsProvider();
#elif UNITY_ANDROID
            //TODO: will be implemented in the GPGS task scope
#else
            //TODO: maybe implement fake stub
#endif
        }

        public static void FetchFriendsStates() {
            if (_instance != null) {
                _instance.FetchFriendsStates();
            } else {
                //TODO: should be managed both with TODO above
            }
        }

    }
}