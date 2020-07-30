# Licensed to the .NET Foundation under one or more agreements.
# The .NET Foundation licenses this file to you under the MIT license.

if(NOT DEFINED MONO_ONLY_COREHOST)
    add_subdirectory(static)
endif()
add_subdirectory(standalone)
