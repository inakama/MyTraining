using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCompany
{
    class CallCalculator
    {
        private const decimal _fixedCost = 20;

        private IStrategyCalculator _strategy;

        private Call _call;

        public CallCalculator(Call aCall)
        {
            this._call = aCall;
        }

        public void SetCalculator()
        {
            if (this._call.Country == "ARGENTINA")
            {
                if(this._call.Country == "BUENOS_AIRES")
                    this._strategy = new LocalCalculator();
                else
                    switch (this._call.State) 
                    { 
                        case "CORDOBA":
                            this._strategy = new CordobaCalculator();
                            break;
                    }
            }
            else
            {
                switch (this._call.Country)
                {
                    case "JAPAN":
                        this._strategy = new JapanCalculator();
                        break;
                    case "BRASIL":
                        this._strategy = new BrasilCalculator();
                        break;
                }
            }
        }

        private decimal GetCost()
        {
            return this._strategy.CalculateSubTotal(this._call) + _fixedCost;
        }

        public void Start()
        {
            Console.WriteLine("Costo llamada: " + this.GetCost());
            
        }

        static void Main(string[] args)
        {
            new CallCalculator(new Call() { 
                Country = "ARGENTINA",
                State = "BUENOS_AIRES",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddMinutes(45)
            }).Start();

        }
    }
}
