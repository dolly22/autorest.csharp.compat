// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ConfidentLevelsInTsp.Models
{
    /// <summary> This is a model without union types. </summary>
    public partial class UsualModel
    {
        /// <summary> Initializes a new instance of UsualModel. </summary>
        /// <param name="name"> The name. </param>
        /// <param name="age"> The age. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public UsualModel(string name, int age)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Age = age;
        }

        /// <summary> Initializes a new instance of UsualModel. </summary>
        /// <param name="name"> The name. </param>
        /// <param name="age"> The age. </param>
        /// <param name="size"> The size. </param>
        internal UsualModel(string name, int age, double? size)
        {
            Name = name;
            Age = age;
            Size = size;
        }

        /// <summary> The name. </summary>
        public string Name { get; }
        /// <summary> The age. </summary>
        public int Age { get; }
        /// <summary> The size. </summary>
        public double? Size { get; set; }
    }
}
