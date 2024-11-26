using CalculaSalarioFuncionario;
using CalculaSalarioFuncionario.Modelos;
using CalculaSalarioFuncionario.Modelos.Objetos_de_Valor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCalculadoraSalario
{
    [TestFixture]
    public class CalculadoraDeSalarioTest
    {
        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.DESENVOLVEDOR);
            double salario = calculadora.CalculaSalario(desenvolvedor);
            Assert.That(salario, Is.EqualTo(1500.0 * 0.9));
        }
    }
}
