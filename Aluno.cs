using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculaNotaAlunoSemestre
{
    class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;
        
        public double calculaNotaFinal() 
        {
            return nota1 + nota2 + nota3;
        }

        public bool aprovado()
        {
            if (calculaNotaFinal()>60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double notaRestante() 
        {
            if (aprovado())
            {
                return 0;
            }
            else
            {
                return 60.0 - calculaNotaFinal();
            }
        }
    }
}
