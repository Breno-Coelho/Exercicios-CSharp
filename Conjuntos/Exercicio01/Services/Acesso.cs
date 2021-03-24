using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Services
{
    class Acesso
    {
        public string Name { get; set; }
        public DateTime Log { get; set; }

        public Acesso(string name, DateTime log)
        {
            Name = name;
            Log = log;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Acesso))
            {
                return false;
            }
            Acesso outro = obj as Acesso;  
            return Name.Equals(outro.Name);
        }
    }
}
