
<h1 align="center">📖Testes do desafio .NET</h1>

<h2 align="center">Testes feitos utilizando Visual Studio 2019 Community e sql server, foi utilizada a linguagem C# 

Teste 01: Exibir média do Aluno
Problema: O Professor de uma escola precisa calcular a média anual dos seus
alunos, para isso ele deseja um sistema que ele informe a nota do primeiro e do
segundo semestre, e que esse sistema exibe qual é a média.

Teste 02: Exibir média do Aluno recebendo (x) quantidade de Notas
Problema: Um aluno tem várias provas durante o ano e deseja um sistema que ele
informe o Seu Nome e a nota que recebeu.
Observação: Para cada nota informada deve ser exibido o nome do aluno, a
quantidade de provas, o total de notas, e qual a média desse aluno.

Teste 03: Exibir média de cada aluno
Problema: Um Professor tem vários alunos e ele quer calcular a média anual de
cada aluno, se a média anual do aluno for menos que 6,5 ele está reprovado caso
seja ao contrário, ele foi aprovado.
Observações: Deve ser informado o Nome, a nota do primeiro e do segundo
semestre de cada aluno.
Após digitar o nome, a nota do primeiro e do segundo semestre, exibir a média anual
do aluno e se ele foi aprovado ou não. Após exibir se o aluno foi aprovado ou não,
recomeçar o fluxo de perguntar o nome e as notas.

Teste 04: Criar tela de login no Windows Forms
Observações: Se atentar a alinhamento dos campos, organização dos campos no
formulário e nome das propriedades
O que precisa ser feito: Um formulário de login com:
Dois textbox: login e senha, um botão chamado "Entrar"
Após o usuário preencher o login e senha e clicar no botão entrar, será aberto o
formulário do próximo Teste (Teste 05)
Importante: O Campo Login e o campo senha são obrigatórios, caso o usuário não
preencha o campo, exibir um campo com a mensagem do campo que falta
preencher.
Caso você tenha criado um projeto console application, para realização do Teste 04
e Teste 05 será necessário a criação de um Windows Forms Application (pode ser
dentro da mesma solution)

Teste 05: Criar tela para lançamento de notas
O que precisa ser feito: Um formulário com 3 campos(textbox)
- Nome do Aluno (obrigatório)
- Nota do 1º Semestre (obrigatório)
- Nota do 2º Semestre (obrigatório)
Botão Limpar Campos
Após clicar no botão "Limpar Campos" a tela deve voltar ao estado inicial (campos
vazios e mensagens iniciais).
Botão Enviar
Ao clicar no botão Enviar:
- Deve ser validado se os campos obrigatórios foram preenchidos
- Se a média do aluno for menor que 6,5 (Exibir "Reprovado" com a cor do label
Vermelho (Red)
- Se a média do aluno for maior ou igual a 6,5 (Exibir "Aprovado" com a cor do
label Verde (Green)
Importante: Caso o usuário não preencha os campos obrigatórios
Exibir uma label em vermelho informando que o campo é obrigatório. (cada campo
obrigatório deve ter uma label para informar o erro)

Teste 06: Criar uma tabela no banco de dados para armazenar informações do
aluno.
Problema: Um professor deseja armazenar o nome de seus alunos, a nota do 1º e do
2º semestre e o ano que foi lançada a nota.
Importante: Atentar com o nome da tabela e nome das colunas. Não se esqueça de
criar um identificador para a coluna.

Teste 07: Inserir informações para os Alunos
Após criar a tabela, realizar a inclusão dos scripts
Ano: 2022
Nome: João
Nota 1º Semestre 5
Nota 2º Semestre 10
Ano: 2023
Nome: João
Nota 1º Semestre 7
Nota 2º Semestre 5
Ano: 2022
Nome: Carlos
Nota 1º Semestre 3
Nota 2º Semestre 7
Ano: 2023
Nome: João
Nota 1º Semestre 2
Nota 2º Semestre 10
Ano: 2022
Nome: Vinicius
Nota 1º Semestre 4.5
Nota 2º Semestre 6
Ano: 2022 Nome: Vinicius Nota 1º Semestre 3.1 Nota 2º Semestre 7.7

Teste 08: Consultar informações dos alunos
Se a média anual for menor que 6.5 exiba o Status Reprovado
Caso não, exiba o status Aprovado

Teste 09: Consultar informações dos alunos que a média anual for maior que 6.

Teste 10: Utilizar o Teste 05, e após o usuário clicar em Enviar…
- Salvar as informações em um banco de dados
Ou então
- Salvar as informações em um json.
</h2>
   
