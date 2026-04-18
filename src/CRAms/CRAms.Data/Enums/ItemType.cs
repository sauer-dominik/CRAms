namespace CRAms.Data.Enums
{
    public enum ItemType
    {
        /// <summary>
        /// Optional Conditions as described by BSI TR-03183. When Condition applies to the Product, Requirements have to be met.
        /// </summary>
        Condition = 0,
        /// <summary>
        /// The Requirements that have to be met, if the Conditions apply to the product, described by BSI TR-03183.
        /// </summary>
        Requirement = 1,
        /// <summary>
        /// The Recommendations that should be met, if the Conditions apply to the product, described by BSI TR-03183.
        /// </summary>
        Recommendation = 2,
        /// <summary>
        /// Necessary assessment criteria as described by BSI TR-03183 for evaluating the compliance with CRA.
        /// </summary>
        Assessment = 3,
    }
}
