using System;

namespace CSGOStats.Infrastructure.Validation
{
    public static partial class ArgumentValidationExtensions
    {
        private static string EnsureArgumentName(this string argumentName) =>
            argumentName ?? throw new NullReferenceException("Argument should have a value.");

        private static string EnsurePreconditionCode(this string preconditionCode) =>
            preconditionCode ?? throw new NullReferenceException("Precondition code should have a value."); // TODO also check for constant set
    }
}