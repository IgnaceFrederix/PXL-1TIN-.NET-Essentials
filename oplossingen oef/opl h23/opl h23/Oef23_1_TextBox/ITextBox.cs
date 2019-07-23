//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef23_1_TextBox
{
    public interface ITextBox
    {
        bool Enabled { get; set; }
        string Text { get; set; }
        char PasswordChar { get; set; }
        int MaxLength { get; set; }
    }
}
