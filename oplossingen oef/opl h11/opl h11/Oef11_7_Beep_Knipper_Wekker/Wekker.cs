//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef11_7_Beep_Knipper_Wekker
{
    /// <summary>
    /// Wekker
    /// </summary>
    public class Wekker
    {
        // tijd waarop de wekker zal afgaan
        private DateTime _alarmTime;

        // aantal seconden dat de wekker zal afgaan
        private int _beepTime;

        public Wekker()
        {
            _beepTime = 10;
            _alarmTime = DateTime.MinValue;
        }

        public bool IsAlarmPassed()
        {
            if (_alarmTime == DateTime.MinValue) 
            {
                return false;
            }
            else
            {
                return DateTime.Now > _alarmTime;
            }
        }

        public bool ShouldStopBeeping()
        {
            if (IsAlarmPassed())
            {
                return _alarmTime.AddSeconds(_beepTime) < DateTime.Now;
            }
            else
            {
                return false;
            }
        }

        public virtual void Reset()
        {
            _alarmTime = DateTime.MinValue;
        }

        public virtual void Go()
        {
        }

        public string AlarmTime
        {
            set
            {
                _alarmTime = Convert.ToDateTime(value);
              
                if (_alarmTime < DateTime.Now)
                {
                    _alarmTime = _alarmTime.AddDays(1);
                }
            }
        }
    
        public int BeepTime
        {
            get { return _beepTime; }
            set { _beepTime = value; }
        }

        public string CurrentTime
        {
            get { return DateTime.Now.ToLongTimeString(); }
        }
    }
}
