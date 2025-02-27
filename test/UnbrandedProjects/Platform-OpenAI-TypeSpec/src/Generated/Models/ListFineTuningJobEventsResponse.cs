// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.ClientModel.Internal;

namespace OpenAI.Models
{
    /// <summary> The ListFineTuningJobEventsResponse. </summary>
    public partial class ListFineTuningJobEventsResponse
    {
        /// <summary> Initializes a new instance of ListFineTuningJobEventsResponse. </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="object"/> or <paramref name="data"/> is null. </exception>
        internal ListFineTuningJobEventsResponse(string @object, IEnumerable<FineTuningJobEvent> data)
        {
            ClientUtilities.AssertNotNull(@object, nameof(@object));
            ClientUtilities.AssertNotNull(data, nameof(data));

            Object = @object;
            Data = data.ToList();
        }

        /// <summary> Initializes a new instance of ListFineTuningJobEventsResponse. </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
        internal ListFineTuningJobEventsResponse(string @object, IReadOnlyList<FineTuningJobEvent> data)
        {
            Object = @object;
            Data = data;
        }

        /// <summary> Gets the object. </summary>
        public string Object { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<FineTuningJobEvent> Data { get; }
    }
}
