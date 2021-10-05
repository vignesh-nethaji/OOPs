using System;

namespace OOPs.Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            ///<summary>
            ///  This is main function. Only here Method is should be calling.
            ///  I created two object there for the access the class reference one is ConditionalsStatement otherone is LoopsStatement
            ///</summary>

            LoopStatement obj1 = new LoopStatement();

            obj1.Forloop();
            obj1.Foreach();
            obj1.While();
            obj1.DoWhile();
        }
    }
}
