using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConditionNumber.Model;

public class Kondital
{
    public double BeregnKondital(double mp, double hp)
    {
        double kondital = (mp / hp) * 15.3;

        return kondital;
    }

    public double BeregnIltOptagelse(double konTal, double vægt)
    {
        double iltOptagelse = (konTal * vægt) / 1000;

        return Math.Round(iltOptagelse, 1);
    }
}
