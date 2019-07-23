//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef23_5_IMyList
{
    public class StringList : IMyList
    {
        private string[] _contents = new string[100];

        private int _count;
        public StringList()
        {
            _count = 0;
        }

        public int Add(string value)
        {
            if (_count < _contents.Length - 1)
            {
                _contents[_count] = value;
                _count += 1;
                return _count - 1;
            }
            else
            {
                return -1;
            }
        }

        public int IndexOf(string value)
        {
            int itemIndex = -1;

            int i = 0;
            for (i = 0; i <= _count; i++)
            {
                if (_contents[i] == value)
                {
                    itemIndex = i;
                    break;
                }
            }

            return itemIndex;
        }

        public void Remove(string value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 & index < _count)
            {
                int i = 0;
                for (i = index; i < _count; i++)
                {
                    _contents[i] = _contents[i + 1];
                }
                _count = _count - 1;
            }
        }

        public string[] Contents
        {
            get { return _contents; }
        }
    }
}
