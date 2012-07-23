using System.Collections.Generic;

namespace FluentAssertions.Structural
{
    /// <summary>
    /// Provides the run-time details of the <see cref="StructuralEqualityConfiguration{TSubject}" /> class.
    /// </summary>
    internal interface IStructuralEqualityConfiguration
    {
        /// <summary>
        /// Gets an ordered collection of selection rules that define what properties are included.
        /// </summary>
        IEnumerable<ISelectionRule> SelectionRules { get; }

        /// <summary>
        /// Gets an ordered collection of matching rules that determine which subject properties are matched with which
        /// expectation properties.
        /// </summary>
        IEnumerable<IMatchingRule> MatchingRules { get; }

        /// <summary>
        /// Gets an ordered collection of assertion rules that determine how subject properties are compared for equality with
        /// expectation properties.
        /// </summary>
        IEnumerable<IAssertionRule> AssertionRules { get; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the structural comparison is a deep comparison.
        /// </summary>
        bool IsRecursive { get; }

        CyclicReferenceHandling CyclicReferenceHandling { get; }
    }
}