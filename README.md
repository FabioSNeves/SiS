# Sistema de gerenciamento de chamados

Desenvolvimento de um projeto web, desde a interface com o usuário, se que se comunica com o servidor de backend, que faz a persistência de dados se conectando à um banco de dados, utilizando AngularJS, C#, SQL.

### Front End

Framework AngularJS para montar a estrutura do front end + Bootstrap.

### Back End

Linguagem de programação C#, metodologia DDD.

## Funcionalidades

### Diferentes tipos de usuários

O sistema identifica dois tipos de usuário: **colaborador** (abre  chamados) e **atendente** (atende chamados). A interface do portal é diferente nos dois casos.

### Abrir um chamado

Se o usuário logado for um  **colaborador**, o sistema mostra a lista de chamados abertos por este usuário (com seus devidos statuses), além de permitir que o mesmo faça a abertura de um novo chamado.
Um chamado novo possui o status de *new*.

### Atender um chamado

Se o usuário logado for um **atendente**, o sistema lista todos os chamados abertos, e permite que o usuário atenda um chamado. Ao atender o chamado, o chamado passa a ter status *inProgress*.

### Finalizar um chamado

Se o usuário logado for um **atendente**, o sistema permite que chamados com o status *inProgress* possam ser finalizados, passando assim a ter status *finished* .

### Reabrir um chamado

Se o usuário logado for um **colaborador** ou um **atendente**, o sistema permite que ele reabra um chamado que já foi fechado.

