using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isBool) : base(name, isBool)
        {
            Type = Enums.GradeBookType.Standard;
        }
        
    }
}
