using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance
{
    class Pupil
    {
        public string Title { get; private set; }

        public Pupil(string title)
        {
            this.Title = title;
        }

        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }
    }
}
