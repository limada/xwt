﻿//
// TextEntryMultiLineBackend.cs
//
// Author:
//       Lytico (http://www.limada.org)
//       Vsevolod Kukol <sevo@sevo.org>
//
// Copyright (c) 2014 http://www.limada.org
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Linq;
using Xwt.Backends;

namespace Xwt.GtkBackend
{

    public partial interface IGtkWidgetBackend {
        void AllocEventBox ();
    }

    public partial class WidgetBackend
    {
        protected bool IsDestroyed => destroyed;

        void IGtkWidgetBackend.AllocEventBox () => AllocEventBox ();

        void DisableAllEvents () {
            foreach (var ev in Enum.GetValues(typeof(WidgetEvent)).Cast<WidgetEvent>()) {
                if (enabledEvents.HasFlag (ev)) {
                    DisableEvent (ev);
                }
            }
        }
    }

}