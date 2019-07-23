//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef10_8_Wekker
{
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
            if (_alarmTime == DateTime.MinValue) // Eigenaardig dat je wel kan vergelijken met null
                                                 // als dat een non-nullable value type is???
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
                // return DateAdd(DateInterval.Second, _beepTime, _alarmTime) < DateTime.Now;
                // DateAdd werkt niet meer? (nog uitzoeken) Onderstaande is ok.
                return _alarmTime.AddSeconds(_beepTime) < DateTime.Now;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            //_alarmTime = null; gaat niet omdat DateTime een non-nullable value type is!!!
            _alarmTime = DateTime.MinValue; // 1/1/0001 0:00:00
          
            // OF Wat is best?
            // DateTime? _alarmTime; (bovenaan als private declareren)
            // _alarmTime = null;

            // OF Wat is best?
            // Nullable<DateTime> _alarmTime; (bovenaan als private declareren)
            //_alarmTime = null;
            // dit lijkt me een betere methode, maar dan kent hij de method AddSeconds
            // niet. Moet een referentie naar een dll leggen (maar kan niet opzoeken op 
            // internet welke dll) (nog doen)

            // Misschien hierover extra informatie opnemen in de opgave???
        }

        public string AlarmTime
        {
            set
            {
                _alarmTime = Convert.ToDateTime(value);
                // OF
                // _alarmTime = DateTime.Parse(value);
                
                // Kris, onderstaande if heb ik nog toegevoegd zodanig dat je het alarm ook
                // kan instellen dat je 's morgens ook gewekt kan worden (als je het  
                // alarm vóór middernacht instelt)
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
