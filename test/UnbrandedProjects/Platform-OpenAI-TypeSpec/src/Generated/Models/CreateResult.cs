// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel.Internal;

namespace OpenAI.Models
{
    /// <summary> The CreateResult. </summary>
    public partial class CreateResult
    {
        /// <summary> Initializes a new instance of CreateResult. </summary>
        /// <param name="flagged"> Whether the content violates [OpenAI's usage policies](/policies/usage-policies). </param>
        /// <param name="categories"> A list of the categories, and whether they are flagged or not. </param>
        /// <param name="categoryScores"> A list of the categories along with their scores as predicted by model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="categories"/> or <paramref name="categoryScores"/> is null. </exception>
        internal CreateResult(bool flagged, CreateCategories categories, CreateCategoryScores categoryScores)
        {
            ClientUtilities.AssertNotNull(categories, nameof(categories));
            ClientUtilities.AssertNotNull(categoryScores, nameof(categoryScores));

            Flagged = flagged;
            Categories = categories;
            CategoryScores = categoryScores;
        }

        /// <summary> Whether the content violates [OpenAI's usage policies](/policies/usage-policies). </summary>
        public bool Flagged { get; }
        /// <summary> A list of the categories, and whether they are flagged or not. </summary>
        public CreateCategories Categories { get; }
        /// <summary> A list of the categories along with their scores as predicted by model. </summary>
        public CreateCategoryScores CategoryScores { get; }
    }
}
