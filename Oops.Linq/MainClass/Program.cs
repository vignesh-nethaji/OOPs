using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Linq_Sln
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("************************************************************");
            ///<summary>
            ///Methods are grouped into Regions of their respective type
            ///Comment/Uncomment the regions as Required
            /// </summary>


            #region Linq Aggregation Methods
            Aggregate.Aggregate_seed();
            Aggregate.Average();
            Aggregate.Count_Lambda();
           Aggregate.LongCount_Lambda();
            Aggregate.Max();
            Aggregate.Min();
            Aggregate.Simple_Aggregate();
            Aggregate.Sum_Lambda();
            #endregion
            #region Linq Conversion Methods
            Conversion.Sample_AsEnumerable_Lambda();
            Conversion.Sample_Cast_Lambda();
            Conversion.Sample_OfType_Lambda();
            Conversion.Sample_ToDictionary_Lambda_Conditional();
            Conversion.Sample_ToDictionary_Lambda_Simple();
            Conversion.Sample_ToList_Lambda();
            Conversion.Sample_ToLookup_Lambda();
            #endregion
            #region Linq Element Methods
            Element.Sample_ElementAtOrDefault_Lambda();
            Element.Sample_ElementAt_Lambda();
            Element.Sample_FirstOrDefault_Lambda();
            Element.Sample_First_Lambda_Conditional();
            Element.Sample_First_Lambda_Simple();
            Element.Sample_LastOrDefault_Conditional();
            Element.Sample_LastOrDefault_Simple();
            Element.Sample_Last_Lambda();
            Element.Sample_SingleOrDefault_Lambda();
            Element.Sample_Single_Lambda();
            #endregion
            #region Linq Generation Mehods
            Generation.Sample_DefaultIfEmpty_Lambda_DefaultValue();
            Generation.Sample_DefaultIfEmpty_Lambda_Simple();
            Generation.Sample_Empty_Lambda();
            Generation.Sample_Range_Lambda();
            Generation.Sample_Repeat_Lambda();
            #endregion
            #region Linq Grouping Mehods
            Grouping.Sample_GroupBy_Lambda();
            #endregion
            #region Linq Join Mehods
            Join.Sample_GroupJoin_Lambda();
            Join.Sample_Join_Lambda();
            #endregion
            #region Linq Ordering Methods
            Ordering.Sample_OrderByDescending_Lambda();
            Ordering.Sample_OrderBy_Lambda_Dates();
            Ordering.Sample_OrderBy_Lambda_Numbers();
            Ordering.Sample_OrderBy_Lambda_Objects();
            Ordering.Sample_Reverse_Lambda();
            Ordering.Sample_ThenByDescending_Lambda();
            Ordering.Sample_ThenBy_Lambda();
            #endregion
            #region Linq Other methods
            Other.Sample_Concat_Lambda_Numbers();
            Other.Sample_Concat_Lambda_Strings();
            Other.Sample_SequenceEqual_Lambda();
            Other.Sample_Zip_Lambda();
            #endregion
            #region Linq Projection Methods
            Partioning.Sample_SkipWhile_Lambda();
            Partioning.Sample_Skip_Lambda();
            Partioning.Sample_TakeWhile_Lambda();
            Partioning.Sample_Take_Lambda();
#endregion
            #region Linq Projection Methods

            Projection.Sample_SelectMany_Lambda();
            Projection.Sample_Select_Lambda_Indexed();
            Projection.Sample_Select_Lambda_Simple();
            #endregion
            #region Linq Quantifiers Methods
            Quantifiers.Sample_All_Lambda();
            Quantifiers.Sample_Any_Lambda();
            Quantifiers.Sample_Contains_Lambda();
            #endregion
            #region Linq Restriction Methods
            Restriction.Sample_Where_Lambda_Indexed();
            Restriction.Sample_Where_Lambda_Numbers();
            Restriction.Sample_Where_Lambda_Objects();
#endregion
            #region Linq Set Methods
            Set.Sample_Distinct_Lambda();
            Set.Sample_Except_Lambda();
            Set.Sample_Intersect_Lambda();
            Set.Sample_Union_Lambda();
            #endregion

            Console.WriteLine("************************************************************");

        }
      
    }
}
