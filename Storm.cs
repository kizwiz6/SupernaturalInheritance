﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance
{
    class Storm
    {
        public string Essence { get; private set; }
        public bool IsStrong { get; private set; }
        public string Caster { get; private set; }

        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        public string Announce()
        {
            if (IsStrong)
            {
                return $"{Caster} cast a strong {Essence} storm!";
            }
            else
            {
                return $"{Caster} cast a weak {Essence} storm!";
            }
        }
    }
}
