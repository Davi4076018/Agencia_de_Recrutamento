using System.Text.Json;
using Agencia_de_Recrutamento.Domain.Entities;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agencia_de_Recrutamento.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            var cidade = new Cidade
            {
                Nome = "Batatais",
                Estado = "SP"
            };

            Console.WriteLine(JsonSerializer.Serialize(cidade));
            Assert.AreEqual(cidade.Nome, "Batatais");
            Assert.AreEqual(cidade.Estado, "SP");

        }
        [TestMethod]
        public void TestCandidato()
        {
            var cidade = new Cidade();
            var Candidato = new Candidato();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            Candidato.Nome = "Giovanna";
            Candidato.Email = "gizinha4076018@gmail.com";
            Candidato.Cidade = cidade;
            Candidato.Bairro = "Nova joinvile";
            Candidato.Endereco = "Rua Teste";
            Candidato.CPF = "321.983.928-01";
            Candidato.Formacao = "Engenheira da Computação";
            Candidato.Ativo = true;

            Console.WriteLine(JsonSerializer.Serialize(Candidato));
            Assert.AreEqual(Candidato.Nome, "Giovanna");
            Assert.AreEqual(Candidato.Cidade.Nome, cidade.Nome);
            Assert.AreEqual(Candidato.Cidade.Estado, cidade.Estado);
            Assert.AreEqual(Candidato.Bairro, "Centro");
            Assert.AreEqual(Candidato.Endereco, "Rua Teste");
            Assert.AreEqual(Candidato.CPF, "321.983.928-01");
            Assert.AreEqual(Candidato.Formacao, "Engenheira da Computação");
            Assert.AreEqual(Candidato.Ativo, true);

        }
        [TestMethod]
        public void TesteEmpresa()
        {
            var cidade = new Cidade();
            var Empresa = new Empresa();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            Empresa.Nome = "EMPINIOS";
            Empresa.Endereco = "Rua Teste";
            Empresa.CNPJ = "43.229.561/0001-70";
            Empresa.Bairro = "Nova joinvile";
            Empresa.Cidade = cidade;
            

            Console.WriteLine(JsonSerializer.Serialize(Empresa));
            Assert.AreEqual(Empresa.Nome, "EMPINIOS");
            Assert.AreEqual(Empresa.Endereco, "Rua Teste");
            Assert.AreEqual(Empresa.CNPJ, "43.229.561/0001-70");
            Assert.AreEqual(Empresa.Bairro, "Nova joinvile");
            Assert.AreEqual(Empresa.Cidade.Nome, cidade.Nome);
            Assert.AreEqual(Empresa.Cidade.Estado, cidade.Estado);
        }
        [TestMethod]
        public void TesteRecrutador()
        {
            var Recrutador = new Recrutador();

            Recrutador.Nome = "Roberson Nunes";
            Recrutador.Login = "robin1234";
            Recrutador.Senha = "nunes4321";
            Recrutador.Email = "roberson5000@gmail.com";
            Recrutador.Ativo = true;

            Console.WriteLine(JsonSerializer.Serialize(Recrutador));
            Assert.AreEqual(Recrutador.Nome, "Roberson Nunes");
            Assert.AreEqual(Recrutador.Login, "robin1234");
            Assert.AreEqual(Recrutador.Senha, "nunes4321");
            Assert.AreEqual(Recrutador.Email, "roberson5000@gmail.com");
            Assert.AreEqual(Recrutador.Ativo, true);
        }
        [TestMethod]
        public void TesteVaga()
        {
            var Vaga = new Vaga();
            var Empresa = new Empresa();
            var Candidato = new Candidato();
            var Recrutador = new Recrutador();
            var cidade = new Cidade();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            Empresa.Nome = "EMPINIOS";
            Empresa.Endereco = "Rua Teste";
            Empresa.CNPJ = "43.229.561/0001-70";
            Empresa.Bairro = "Nova joinvile";
            Empresa.Cidade = cidade;


            Console.WriteLine(JsonSerializer.Serialize(Empresa));
            Assert.AreEqual(Empresa.Nome, "EMPINIOS");
            Assert.AreEqual(Empresa.Endereco, "Rua Teste");
            Assert.AreEqual(Empresa.CNPJ, "43.229.561/0001-70");
            Assert.AreEqual(Empresa.Bairro, "Nova joinvile");
            Assert.AreEqual(Empresa.Cidade.Nome, cidade.Nome);
            Assert.AreEqual(Empresa.Cidade.Estado, cidade.Estado);

            Candidato.Nome = "Giovanna";
            Candidato.Email = "gizinha4076018@gmail.com";
            Candidato.Cidade = cidade;
            Candidato.Bairro = "Nova joinvile";
            Candidato.Endereco = "Rua Teste";
            Candidato.CPF = "321.983.928-01";
            Candidato.Formacao = "Engenheira da Computação";
            Candidato.Ativo = true;

            Console.WriteLine(JsonSerializer.Serialize(Candidato));
            Assert.AreEqual(Candidato.Nome, "Giovanna");
            Assert.AreEqual(Candidato.Cidade.Nome, cidade.Nome);
            Assert.AreEqual(Candidato.Cidade.Estado, cidade.Estado);
            Assert.AreEqual(Candidato.Bairro, "Centro");
            Assert.AreEqual(Candidato.Endereco, "Rua Teste");
            Assert.AreEqual(Candidato.CPF, "321.983.928-01");
            Assert.AreEqual(Candidato.Formacao, "Engenheira da Computação");
            Assert.AreEqual(Candidato.Ativo, true);

            Recrutador.Nome = "Roberson Nunes";
            Recrutador.Login = "robin1234";
            Recrutador.Senha = "nunes4321";
            Recrutador.Email = "roberson5000@gmail.com";
            Recrutador.Ativo = true;

            Console.WriteLine(JsonSerializer.Serialize(Recrutador));
            Assert.AreEqual(Recrutador.Nome, "Roberson Nunes");
            Assert.AreEqual(Recrutador.Login, "robin1234");
            Assert.AreEqual(Recrutador.Senha, "nunes4321");
            Assert.AreEqual(Recrutador.Email, "roberson5000@gmail.com");
            Assert.AreEqual(Recrutador.Ativo, true);

            Vaga.Titulo = "Vaga Junior Python";
            Vaga.Descricao = "venha fazer parte da nossa empresa";
            Vaga.Formacao = "Superior na área de tecnologia";
            Vaga.Salario = 4000;
            Vaga.DataCriacao = DateTime.Today;
            Vaga.Ativo = true;

            Vaga.Inscritos.Add(Candidato);

            Console.WriteLine(JsonSerializer.Serialize(Vaga));
            Assert.AreEqual(Vaga.Titulo, "Vaga Junior Python");
            Assert.AreEqual(Vaga.Descricao, "venha fazer parte da nossa empresa");
            Assert.AreEqual(Vaga.Formacao, "Superior na área de tecnologia");
            Assert.AreEqual(Vaga.Salario, 4000);
            Assert.AreEqual(Vaga.DataCriacao, DateTime.Today);
            Assert.AreEqual(Vaga.Inscritos[0].Nome, Candidato.Nome);

        }

    }
}