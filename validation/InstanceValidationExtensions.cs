using System.Text.RegularExpressions;

namespace CSGOStats.Infrastructure.Validation
{
    public static class InstanceValidationExtensions
    {
        public static Match ForSucceeded(this Match x) =>
            x.Success 
                ? x 
                : throw new ExpressionNotMatched();
    }
}