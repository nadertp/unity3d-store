﻿/// Copyright (C) 2012-2014 Soomla Inc.
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
using System.Diagnostics;

namespace SoomlaWpCore
{
    
    public class SoomlaUtils
    {
        public static void LogDebug(String tag, String message)
        {
            if (SoomlaConfig.logDebug)
            {
                Debug.WriteLine(tag + " " + message);
            }
        }

        public static void LogError(String tag, String message)
        {
            Debug.WriteLine("ERROR " + tag + " " + message);
        }

        private const String TAG = "SOOMLA SoomlaUtils"; //used for Log messages
    }
}
