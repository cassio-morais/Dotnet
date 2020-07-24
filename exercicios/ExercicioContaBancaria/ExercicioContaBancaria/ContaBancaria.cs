using System.Globalization;


namespace ExercicioContaBancaria {
    class ContaBancaria {

        public int Numero { get; private set; } // deixo tudo público e trato os acessos via get/set
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
            Saldo = 0.00; // passei saldo explícito mas não precisaria. Valores numéricos são iniciados com zero
        }
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito( double quantia) {
            
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            
            const double TaxaSaque = 5.00;
            Saldo = Saldo - quantia - TaxaSaque;
        }

        public override string ToString() {
            return "Conta: " + Numero 
                    + ", Titular: " + Titular 
                    + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
                    }

    }
}
