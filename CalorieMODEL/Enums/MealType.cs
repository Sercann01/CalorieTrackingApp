using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieMODEL.Enums
{
    public enum MealType
    {
        breakfast,
        lunch,
        dinner,
        snack,
        [Description("Team Manager")] TeamManager
    }
}
