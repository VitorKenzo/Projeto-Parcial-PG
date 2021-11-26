# Projeto-Parcial-PG

Repositório para os projetos PP3 e PP4 para a matéria de Processamento Gráfico

## Sobre o Projeto

Para o projeto foi utilizado o unity e suas ferramentas, foram posicionados 5 objetos na cena (uma para cada participante) e uma câmera para permitir observar a cena.

## Como Executar

Haveram dois metodos para executar o projeto, pelo unity e pelo navegador.

Para executar o projeto pelo navegador, basta seguir os seguintes passos:

- Acessar o seguinte link https://chopsticks-user.itch.io/projeto-parcial-de-processamento-grafico
- Colocar a seguinte senha - ProcessamentoGrafico
- Por fim clique em run project
- O projeto demora para carregar da primeira vez (e esta um pouco travado, mas todos os comando devem funcionar sem problemas)

Para executar o projeto pelo unity, basta seguir os seguintes passos:

- Clonar o repositório
- Acessar a pasta "Projeto Parcial 3 e 4" (O Nome esta assim pois o PP3 será aproveitado para o PP4
- Abra o Unity Hub
- Clique em Add e adicione a pasta referente ao projeto no Unity hub
- Execute o projeto
- Com o projeto aberto basta clicar no símbolo "▶️" para executar e visualizar o projeto com a câmera inclusa

## Desenvolvimento Projeto Parcial 3

O desenvolvimento foi bem repetitivo e direto ao ponto, após a configuração inicial do projeto (adicionando a câmera e telas verdes para servirem de base para os outros objetos), cada usuário selecionou um objeto do site "https://free3d.com/" e o importou no projeto, após isso foi necessário fazer escala dos objetos afim de deixa-los em um tamanho desejável para adicionar a cena, a rotação para deixar os objetos na orientação desejada e a translação para posiciona-los como desejado na cena.

## Imagem do Projeto Parcial 3

<img src='https://github.com/VitorKenzo/Projeto-Parcial-PG/blob/main/Foto_cena.jpg'>

## Explicação Detalhada dos conceitos do Projeto Parcial 3

A maioria dos conceitos dados em aula foi representada automaticamente pelo Unity. Contudo vale ressaltar como essas resoluções automáticas foram apresentadas a nós e como nós configuramos manualmente alguns aspectos.

### Posição, Rotação e Escala dos Modelos

Os modelos quando importados estavam em posições, rotações e escalas arbitrárias e para corrigir tivemos que efetuar uma série de manipulações em cada um. Não houve necessidade de aplicar nenhuma técnica de multiplicação de matrizes já que o próprio Unity se responsabiliza por efetuar esses processos, apenas necessitando de um comando.

### Sistemas de Coordenadas

Cada objeto importado tinha seu próprio sistema de coordenadas, ou seja, cada objeto mantinha sua posição rotação e escala em relação a si mesmo, o próprio Unity faz a conversão deste sistema para o sistema de coordenadas do mundo ao importar um modelo. Contudo, era importante ter uma referência dos objetos para com o sistema de coordenação da câmera. Para fazer isso tivemos que manualmente assimilar cada modelo a hierarquia da câmera, assim, além de possuírem uma referência no sistema de coordenada do mundo, o próprio sistema de coordenada do mundo também existia como uma referência a câmera.

## Video do Projeto Parcial 4

https://user-images.githubusercontent.com/48652031/142737048-4c5322f0-c6d7-4998-ae95-aefba7c85ab1.mp4

## Descrição Projeto Parcial 4

### Movimentos

Neste projeto criamos 4 movimentos em 4 objetos diferentes, sendo pelo menos um destes movimentos, dependente de outro, os movimentos criados e como executá-los são os seguintes:

- Um movimento Idle da estátua maoi que executa ao iniciar a cena e permanece em loop, nesta animação é possível observar a estátua rotacionando horizontalmente enquanto flutua oscilando sua altura.
- Um movimento que o macaco realiza um salto mortal para trás, apelidado de "MONKE FLIP", esta animação pode ser ativada pressionando a tecla "M", além disso, esta animação pode ser executada novamente sempre que o macaco terminar a animação anterior.
- Um movimento em que o frango assado "salta" em direção ao veado e se fixa em um de seus chifres, esta animação pode ser ativada pressionando a tecla "A", uma vez que esta animação seja concluída ela não poderá ser executada novamente.
- Um movimento em que o veado junto do frango fixado em seu chifre é abduzido, sendo elevado aos céus enquanto rotaciona horizontalmente, esta animação é ativada após a animação do frango ter terminado.

### Câmeras

No quesito de cameras foram criadas 2 câmeras do qual a visão pode ser alterada entre elas e a projeção de ambas podem ser alteradas, os comandos para isso são os seguintes:

- A tecla "C" alterna entre as câmeras 1 e 2.
- A tecla "P" alterna as perpectivas das câmeras.

## Sumário Comandos PP4

| Tecla | Ação |
|-------|------|
| M | Ativar animação MONKE FLIP |
| A | Ativar animação de Abdução |
| C | Alternar câmeras |
| P | Alternar Perspectiva câmeras|


## Membros

- Amanda Carnio Pascon - 770981
- Eduardo Ravagnani de Melo - 771004
- Felipe Leite Kogus - 771006
- Leonardo Valério Morales - 771030
- Vitor Kenzo Pellegatti - 771066
