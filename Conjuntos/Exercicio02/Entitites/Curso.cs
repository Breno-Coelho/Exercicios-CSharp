using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entitites
{
    class Curso
    {
        

        public int Aluno { get; set; }
        public Curso(int aluno)
        {
            Aluno = aluno;
        }
        public override int GetHashCode()
        {
            return Aluno.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Curso))
            {
                return false;
            }
            Curso outro = obj as Curso;
            return Aluno.Equals(outro.Aluno);
        }
    }
}
