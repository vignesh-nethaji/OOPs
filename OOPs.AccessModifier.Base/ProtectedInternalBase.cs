using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AccessModifier.Base
{
    #region Protected Internal
    /// <summary>
    /// Protected internal :: Can access same assembly via inherit or instance
    /// Protected internal :: Can inherit outside the assembly, but fields and methods can access only on the inherit class. We can't access using instance
    /// </summary>
    public class ProtectedInternalBase
    {
        protected internal int Id;
    }
    #endregion
}
