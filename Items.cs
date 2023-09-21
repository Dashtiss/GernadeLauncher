// -----------------------------------------------------------------------
// <copyright file="Items.cs" company="Joker119">
// Copyright (c) Joker119. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

#pragma warning disable SA1200

using CustomItems.Items;

namespace CustomItems.Configs;

using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// All item config settings.
/// </summary>
public class Items
{
    /// <summary>
    /// Gets the list of grenade launchers.
    /// </summary>
    [Description("The list of grenade launchers.")]
    public List<GrenadeLauncher> GrenadeLaunchers { get; private set; } = new()
    {
        new GrenadeLauncher(),
    };
}