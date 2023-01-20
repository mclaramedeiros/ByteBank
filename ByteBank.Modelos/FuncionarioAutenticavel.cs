﻿using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
	public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
	{
		private readonly AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
		public string Senha { get; set; }
		public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
		{ 
		}
		public bool Autenticar(string senha)
		{
			return _autenticacaoHelper.CompararSenhas(Senha, senha);
		}
	}
}
