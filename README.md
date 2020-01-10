# CannonBluePixel

Teste para desenvolvedor Unity Blue Pixel

1. Como executar: 

1.1 Ambiente Unity:  Fazer download do arquivo CannonBluePixel-master via GitHUB, ou via link: https://1drv.ms/u/s!AqMwhYXVDzR1oXq7vaOc9LFX-qhM?e=E3bvbs , descomprimir e abrir a pasta via Unity HUB.

1.2 WEB: Fazer download do arquivo CannonBluePixelHTML.zip, no link: https://1drv.ms/u/s!AqMwhYXVDzR1oXmDFqI4bUCzJXdw?e=ijjNPP , descomprimir e abrir a pasta via Unity HUB.

1.3 Android: Inicialmente deve ser celular com Android deve ser iniciado em modo "Desenvolvedor" (utilizar google/duckduckgo afim de descobrir como ativar o modo desenvolvedor no seu smartphone). Após, o celular deverá ser conectado cabo usb no computador com o arquivo cannon.app e fazer uma cópia / download do arquivo para o celular. Depois, procurar o arquivo cannon.app no celular para executá-lo e jogar o game.

2. Como foi organizado o código e projeto e quais os critérios usados para fazer desta forma:
A arquitetura do jogo se baseou inicialmente em fazer a mecânica de movimento de "pêndulo" do canhão, depois o instanciamento do tiro direcionado conforme o angulo do canhão. Após, foi iniciado o desenvolvimento da mecânica dos inimigos, descendo somente na vertical, depois adicionando o movimento em "zig-zag". Após, foram implantadas as placas colisoras afim de "destruir" os inimigos e tiros que saem da tela, com o propósito de economizar memória / aumentar desempenho. Pronto estes detalhes, foram implantados os colisores entre os tiros e os inimigos. Após, foi adicionado a parte de UI para execução da pontuação e incorporados os objetivos do game para ter um canvas de derrota/vitória. Por último foram incorporadas as modelagens3d para o canhão e os inimigos, além de ajustes no nível de dificuldade.

3. Listagem dos pontos adicionais contemplados, com observações, informando quanto tempo levou para desenvolver cada etapa.
O jogo demorou em torno de 60horas para ser realizado. Sendo utilizado para controle de tempo/metas o aplicativos hackNplan. Foram 40 horas para desenvolvimento das mecânicas e códigos para UI, 10horas para a parte gráfica UI, 10horas para incorporação das modelagens e 10horas para eliminação de BUGS e melhorias em gameplay.
