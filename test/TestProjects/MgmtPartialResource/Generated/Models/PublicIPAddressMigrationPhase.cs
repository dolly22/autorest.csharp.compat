// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtPartialResource.Models
{
    /// <summary> Migration phase of Public IP Address. </summary>
    public readonly partial struct PublicIPAddressMigrationPhase : IEquatable<PublicIPAddressMigrationPhase>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PublicIPAddressMigrationPhase"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PublicIPAddressMigrationPhase(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string PrepareValue = "Prepare";
        private const string CommitValue = "Commit";
        private const string AbortValue = "Abort";
        private const string CommittedValue = "Committed";

        /// <summary> None. </summary>
        public static PublicIPAddressMigrationPhase None { get; } = new PublicIPAddressMigrationPhase(NoneValue);
        /// <summary> Prepare. </summary>
        public static PublicIPAddressMigrationPhase Prepare { get; } = new PublicIPAddressMigrationPhase(PrepareValue);
        /// <summary> Commit. </summary>
        public static PublicIPAddressMigrationPhase Commit { get; } = new PublicIPAddressMigrationPhase(CommitValue);
        /// <summary> Abort. </summary>
        public static PublicIPAddressMigrationPhase Abort { get; } = new PublicIPAddressMigrationPhase(AbortValue);
        /// <summary> Committed. </summary>
        public static PublicIPAddressMigrationPhase Committed { get; } = new PublicIPAddressMigrationPhase(CommittedValue);
        /// <summary> Determines if two <see cref="PublicIPAddressMigrationPhase"/> values are the same. </summary>
        public static bool operator ==(PublicIPAddressMigrationPhase left, PublicIPAddressMigrationPhase right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PublicIPAddressMigrationPhase"/> values are not the same. </summary>
        public static bool operator !=(PublicIPAddressMigrationPhase left, PublicIPAddressMigrationPhase right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PublicIPAddressMigrationPhase"/>. </summary>
        public static implicit operator PublicIPAddressMigrationPhase(string value) => new PublicIPAddressMigrationPhase(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PublicIPAddressMigrationPhase other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PublicIPAddressMigrationPhase other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
