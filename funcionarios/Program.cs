Empresa empresa = new Empresa();

Funcionario funcionario = new Funcionario("João", 19);

Gerente gerente = new Gerente("Jesus", 100000000, 2000.00);

Estagiario estagiario = new Estagiario("Leo", 27);

empresa.AdicionarFuncionario(funcionario);
empresa.AdicionarFuncionario(gerente);
empresa.AdicionarFuncionario(estagiario);

empresa.ListarFuncionario();