﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Interactive.FSharp.KernelHelpers

open Microsoft.DotNet.Interactive
open Microsoft.AspNetCore.Html

module Operators =
    type internal IMarker = interface end
    
    /// Display the object using current display settings
    let display (value: obj) =
        Kernel.display value

    /// Display the object as HTML using current display settings
    let HTML (value: string) =
        HtmlString value

    /// Execute the content as Javascript
    let Javascript (content: string) =
        Kernel.Javascript content
