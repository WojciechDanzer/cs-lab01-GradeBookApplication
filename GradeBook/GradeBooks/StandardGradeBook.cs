using System;
using System.Collections.Generic;
using GradeBook.Enums;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook: BaseGradeBook
    {
        public StandardGradeBook(string name, GradeBookType GradeBookType) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
