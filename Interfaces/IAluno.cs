using APIBoletim.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBoletim.Interfaces
{
    interface IAluno
    {
        List<Aluno> ListarTodos();
        Aluno BuscarPorID(int ID);
        Aluno Cadastrar(Aluno a);
        Aluno AlterarAluno(Aluno a);
        Aluno Excluir(Aluno a);
    }
}
