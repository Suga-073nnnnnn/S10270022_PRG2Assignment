﻿//==========================================================
// Student Number	: S10270022
// Student Name	: Suganesan
// Partner Name	: Gabriel Lee S10259250
//==========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10270022_PRG2Assignment
{
    class LWTTFlight: Flight
    {
        public double RequestFee { get; set; }
        public LWTTFlight(string flightNumber, string origin, string destination, DateTime expectedTime, string status, double requestFees) : base(flightNumber, origin, destination, expectedTime, status)
        {
            RequestFee = 500;
        }
        public override double CalculateFees()
        {
            return base.CalculateFees() + RequestFee;               // changed to return base function
            //return 500 + 800 + RequestFee;                //not needed anymore
        }
        public override string ToString()
        {
            return base.ToString() + "Special Request Code: LWTT";
        }
    }
}
