using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace InterestCalculator
{
    class Interest_calc
    {
        private double _principle;
        private double _rate;
        private double _time;

     
        public double Principle
        {
            get { return this._principle; }
            set { this._principle = value; }
        }
        public double Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }
        public double Time
        {
            get { return this._time; }
            set { this._time = value; }
        }


        public double interest_amount_calc()
        {
            return ((_principle*_rate*_time)/100);
        }
    }
}
