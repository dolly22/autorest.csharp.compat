// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace _Type.Model.Inheritance.EnumDiscriminator.Models
{
    /// <summary> Golden dog model. </summary>
    public partial class Golden : Dog
    {
        /// <summary> Initializes a new instance of Golden. </summary>
        /// <param name="weight"> Weight of the dog. </param>
        public Golden(int weight) : base(weight)
        {
            Kind = DogKind.Golden;
        }

        /// <summary> Initializes a new instance of Golden. </summary>
        /// <param name="kind"> discriminator property. </param>
        /// <param name="weight"> Weight of the dog. </param>
        internal Golden(DogKind kind, int weight) : base(kind, weight)
        {
        }
    }
}
