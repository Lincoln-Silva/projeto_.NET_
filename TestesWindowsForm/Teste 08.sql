SELECT 
	Nome as 'Nome do Aluno',
	Nota1Semestre as 'Nota do Primeiro Semestre',
	Nota2Semestre as 'Nota do Segundo Semeste',
	(Nota1Semestre + Nota2Semestre) / 2 as 'Média Anual',
	AnoLancamento as Ano,
	CASE WHEN ((Nota1Semestre + Nota2Semestre) / 2) < 6.5
		THEN 'Reprovado'
		ELSE 'Aprovado'
	END as 'Status'
FROM 
	Alunos