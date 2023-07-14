-- Criação da tabela para armazenar informações do aluno
CREATE TABLE Alunos (
    id INT IDENTITY(1,1) PRIMARY KEY, -- coluna de identificação única para cada aluno, usando a propriedade IDENTITY para gerar valores automaticamente
    Nome VARCHAR(50), -- coluna que armazena o nome do aluno como uma string de até 50 caracteres
    Nota1Semestre DECIMAL(4,2), -- coluna que armazena a nota do 1º semestre como um valor decimal com 4 dígitos no total, sendo 2 deles para a parte fracionária.
    Nota2Semestre DECIMAL(4,2), -- coluna que armazena a nota do 2º semestre como um valor decimal com 4 dígitos no total, sendo 2 deles para a parte fracionária.
    AnoLancamento INT -- coluna que armazena o ano em que a nota foi lançada como um valor inteiro
);