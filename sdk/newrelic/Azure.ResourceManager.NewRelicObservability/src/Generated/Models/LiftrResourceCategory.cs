// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Liftr Resource category. </summary>
    public readonly partial struct LiftrResourceCategory : IEquatable<LiftrResourceCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LiftrResourceCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LiftrResourceCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string MonitorLogsValue = "MonitorLogs";

        /// <summary> Unknown. </summary>
        public static LiftrResourceCategory Unknown { get; } = new LiftrResourceCategory(UnknownValue);
        /// <summary> MonitorLogs. </summary>
        public static LiftrResourceCategory MonitorLogs { get; } = new LiftrResourceCategory(MonitorLogsValue);
        /// <summary> Determines if two <see cref="LiftrResourceCategory"/> values are the same. </summary>
        public static bool operator ==(LiftrResourceCategory left, LiftrResourceCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LiftrResourceCategory"/> values are not the same. </summary>
        public static bool operator !=(LiftrResourceCategory left, LiftrResourceCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LiftrResourceCategory"/>. </summary>
        public static implicit operator LiftrResourceCategory(string value) => new LiftrResourceCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LiftrResourceCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LiftrResourceCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
