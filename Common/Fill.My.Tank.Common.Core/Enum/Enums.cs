using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill.My.Tank.Common.Core
{
    public  enum EntityScopeEnum : byte
    {
        UniversityPerson = 1,
        FacultyPerson = 2,
        DepartmentPerson = 3,
        ProgramPerson = 4,
        NonAcademicPerson = 5
    }

    public enum GenderEnumApp : byte
    {
        Male = 1,
        Female = 2
    }
}
