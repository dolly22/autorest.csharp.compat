﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using AutoRest.CSharp.AutoRest.Plugins;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Mgmt.AutoRest
{
    internal static class MgmtContext
    {
        private static BuildContext<MgmtOutputLibrary>? _context;
        public static BuildContext<MgmtOutputLibrary> Context => _context ?? throw new InvalidOperationException("MgmtContext was not initialized.");

        public static MgmtOutputLibrary Library => Context.Library;

        public static Configuration Configuration => Context.Configuration;

        public static MgmtConfiguration MgmtConfiguration => Context.Configuration.MgmtConfiguration;

        public static CodeModel CodeModel => Context.CodeModel;

        public static void Initialize(BuildContext<MgmtOutputLibrary> context)
        {
            _context = context;
        }
    }
}
