using System;

namespace ExerTratamentoExcecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    // criar exceções para o domínio da app (negócio) herdando de Application Exception
    // sub-classe
    {

        // usando a herança do construtor da classe ApplicationException
        public DomainException(string message) : base(message) 
        {
            // instanciarei esse objeto com a mensagem de erro
            // no método da classe que for tratar o erro, 
            // no caso a Withdraw(double amount) // saque
            // throw new DomainException("blah blah blah")
        }

    }
}
