using System;

namespace OOPs.Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///  This is main function. Only here Method is should be calling.
            ///  I created two object there for the access the class reference one is ConditionalsStatement 
            /// </summary>

            ConditionalStatement obj = new ConditionalStatement();
            obj.IfConditional();
            obj.ElseIfConditional();
            obj.NestedIfConitional();
            obj.SwitchConditional();
            obj.TernaryOperator();
            obj.BreakConditional();
            obj.ContinueConditional();

        }
    }
}
