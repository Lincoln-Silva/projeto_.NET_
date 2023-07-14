-- Cria��o da tabela para armazenar informa��es do aluno
CREATE TABLE Alunos (
    id INT IDENTITY(1,1) PRIMARY KEY, -- coluna de identifica��o �nica para cada aluno, usando a propriedade IDENTITY para gerar valores automaticamente
    Nome VARCHAR(50), -- coluna que armazena o nome do aluno como uma string de at� 50 caracteres
    Nota1Semestre DECIMAL(4,2), -- coluna que armazena a nota do 1� semestre como um valor decimal com 4 d�gitos no total, sendo 2 deles para a parte fracion�ria.
    Nota2Semestre DECIMAL(4,2), -- coluna que armazena a nota do 2� semestre como um valor decimal com 4 d�gitos no total, sendo 2 deles para a parte fracion�ria.
    AnoLancamento INT -- coluna que armazena o ano em que a nota foi lan�ada como um valor inteiro
);