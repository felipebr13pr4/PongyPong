# PongyPong

This repo is for learning. Comments are welcome. I will not be accepting pullings or modifications as that is not the purpose of this repo.

This will probably just be a Pong clone but with some more things.

W to move up.
S to move down.
Make the ball go past the other paddle to score.

If you clone this project, be aware that your game window resolution must correlate to the available resolutions.
(320x180, 480x270, 640x360, 800x450, 960x540, 1120x630, 1280x720, 1440x810, 1600x900, 1760x990, 1920x1080 (ideal))

Link itch: https://felipebr13pr.itch.io/pongy-pong

# Development Notes

Hey. Second time using git and github. Had some trouble with it.

Technically my actual first time as in the last project (flappy cube) where i only used git at the end of that one. This project i used git from the very beginning.

Second project done, as i created this repo together of the unity project i can use the "created-at" in
https://api.github.com/repos/felipebr13pr4/PongyPong
2026-07-05T20:15:49Z
As today's 07/24, 19 days. But, on some days i did not work on it so its around 12 days.
One reason it took longer is that i am trying to maintain a healthier work-time as on the first project i spent a tad too much time hyperfocused that i didn't have time for other things lol. So;
Project time: 19 days.
Theorical time: around 12 days.

I re-learned
- Class Inheritance.
- How to create a font.
- A little more about prefabs.
- How to make a method executable in the editor (in the right button pop up window).
- How to properly config pixel sprites.
- About how when you've made a code in another project, you can re-use it (And that this makes it so you don't need to write things from scratch every time and helps alot).
- Override and virtual.
- Unity order importance.

Things i re-learned but did not implement (and that i'll likely need to eventually use when the situation comes)
- Lists
- Dictionaries
- Interfaces
- Structs.
- How to make a pop-up window with a toggle.

I learned
- Auto-saving and saving on buttons.
- Making a simple AI.
- Changing the application window size.
- Making the application window full screen (And vice-versa).
- A bit of pixel perfect camera.
- Achievement system.
- Singletons.
- Tmp auto sizing.
- How to make a scrollable UI panel.
- More about UI in general.
- Using AI as a learning tool. Mostly to help with specific questions like a personalized Google, and even to explain simpler things. I did not use it for vibe-coding. I have only used it on two parts where it (accidentally, i had told it to avoid making code) generated code that worked. But, as long as the code is something i understand, something that makes sense, is debuggable and doesn't have bugs, from what i understood then its ok. AI did not build the project for me. I used Claude at the end of the project to check for small mistakes and it did well, having a second pairs of eyes is nice.
- A little more about player pref.
- A little more about IEnumerators.
- Readonly vs const.

Next time i should
- Search more.
- Think more (To stop and reconsider things more, when implementing systems thinking if its even necessary, thinking of ways to do a system or thing. Considering sometimes the simpler approach is better).
- Try doing better naming conventions git-wise (Like branches, commits, etc.).
- Perhaps use Claude to check for small mistakes and learn from them to not commit them again.

General Thoughts
- I want to try things i haven't done / used, like using Visual Studio's debug features, using lists, dictionaries, interfaces, structs, jsons, etc. But i know those will all come with time, when the situation arrives and i actually need to use them.
- It was fun. I didn't struggle muuuch, but of course i did a little. I've struggled a bit with git but im understanding it a bit more i'd say. Another thing that i struggled with was the window resolution, i wanted to have lots of resolutions but i learned that it is not that compatible with pixel art. It makes the text wobble a little and i think fundamentally i can't fix it (idk), but its still quite readable so i think its okay.
- I did want to add more things, but i think i should finish this and move on, from what i read finishing projects is a valuable skill. And logically it makes sense to stop as this could go on forever and ever, "oh lets add this!", "lets add that!" even if its small things it slooowly grows and then you realize you built a MMORPG lol.
- On specifics on the git trouble, for some reason i kept facing bugs, things just didn't work in general but eventually i was able to find fixes. I had to create a git pushall, git pullall, git revertlocal. I've also had a bit of trouble understanding things like the difference of a checkout, pulling, pushing, etc.
- I've also experienced the greatness of being able to go back to the last commit as i had broken something in the project and by going back i was able to fix it.
- Git was intimidating at first but its a little better now, using it.
 
# Project Plan

Made at the very start of the repo.

Time to make pong.

Pong core consists of
- Player paddle that can move up and down but doesn't pass from the screen boundaries.
- Ball that constantly moves and bounces off screen borders and player/enemy paddles.
- Score that makes it so if a ball passed you the enemy gains score and vice-versa.
- Enemy AI, which there are alot to choose to make.

What would be nice to add
- Pause button that opens a pause window.
- Pause window with restart, settings, main menu, quit.
- Settings with a volume and maybe other things (like fullscreen, window size).

Ideas for fun?
- Maybe achievements? To test events?
- Maybe make multiple enemy AIs and make it chooseable?
- Maybe make it so you can flip sides and the scoring system to be able to correctly identify and separate who scored?
- Maybe test masking? To make it so when the ball is more to the left it turns one color and vice-versa.


# PT BR

# PongyPong

Este Repo é pra aprendizado. Comentarios são bem-vindos. Eu não estarei aceitando pulls ou modificações já que n é o proposito deste repo.

Isto vai provavelmente ser um clone de Pong com umas coisas a mais.

W pra mover para cima.
S pra mover para baixo.
Faça a bola passar da outra raquete para marcar pontos.

Se voce clonar este projeto, saiba que a sua resolução de janela de jogo tem que ser a mesma das disponiveis no jogo.
(320x180, 480x270, 640x360, 800x450, 960x540, 1120x630, 1280x720, 1440x810, 1600x900, 1760x990, 1920x1080 (ideal))

Link do itch: (Irei botar aqui quando eu cria-lo)

# Notas de desenvolvimento.

Hey. Segunda vez usando git e github. Tive um pouco de problema com eles.

Tecnicamente a minha verdadeira primeira vez é a do ultimo projeto (flappy cube) onde eu apenas usei no final daquele. Este projeto eu usei git deis do começo.

Segundo projeto feito, como eu criei este repo junto do projeto do unity eu posso usar o "created-at" no
https://api.github.com/repos/felipebr13pr4/PongyPong
2026-07-05T20:15:49Z
Já que hoje é 24/07, 19 dias. Só que em algums dias eu não trabalhei então é por volta de 12 dias.
Uma razão que demorou mais foi por que eu estou tentando manter um tempo de trabalho mais saudavel já que no primeiro projeto eu gastei muito tempo e hiperfoquei tanto que eu não tinha tempo pra outras coisas kkkk. Então;
Tempo de projeto: 19 dias.
Tempo teorico: por volta de 12 dias.

Eu re-aprendi
- Herança de classe.
- Como criar uma fonte.
- Um pouco mais sobre prefabs.
- Como fazer um metodo executavel no editor (na janela de botão direito).
- Como configurar corretamente sprites de pixel.
- Sobre quando voce tem codigo em outro projeto, voce pode re-usalo (O que faz com que voce não tenha que escrever tudo do zero toda vez e ajuda muito).
- Override e virtual.
- Importancia da ordem do unity.


Coisas que eu re-aprendi mas que não implementei (E que eu provavelmente irei precisar quando a situação vier)
- Listas.
- Dicionários
- Interfaces.
- Structs.
- Como fazer uma janela de pop-up com um toggle.

Eu aprendi
- Salvamento automatico e salvar em butões.
- Fazer uma IA simples.
- Mudar o tamanho da janela da aplicação.
- Fazer a janela da aplicação tela cheia (e vice-versa).
- Um pouco de pixel perfect camera.
- Sistema de conquistas
- Singletons.
- Tmp auto sizing.
- Como fazer um painel de UI rolável.
- Mais sobre UI em geral.
- Usar IA como uma ferramenta de aprendizado. Majoritariamente para perguntas especificas que nem um Google pessoal, e até para explicar coisas basicas. Eu não usei para vibe-coding. Eu apenas usei em duas partes onde (acidentalmente, eu havia falado para evitar de fazer codigos) gerou codigos que funcionaram. Mas, se o codigo é algo que eu consigo entender, algo que faz sentido, é depurável e não tem bugs, até onde eu entendi é ok. IA não construiu o projeto para mim. Eu usei Claude no final do projeto para checar pequenos erros e foi bem, ter um segundo par de olhos é bom.
- Um pouco mais sobre player prefs.
- Um pouco mais sobre IEnumerators
- Readonly vs const.

Na proxima vez eu devo
- Pesquisar mais.
- Pensar mais (Parar e reconsiderar coisas mais, quando implementando sistemas pensar se sequer é necessario, pensar de jeitos para fazer o sistema ou coisa. Considerar que as vezes o jeito mais simples é melhor).
- Tentar fazer uma convenção de nome melhor na questão git (Tipo branches, commits, etc).
- Talvez usar Claude para checar por pequenos erros e aprender deles para não comete-los novamente.

Pensamentos Gerais
- Eu quero tentar coisas que não fiz / usei, tipo usar as ferramentas de depuração do Visual Studio, usar listas, dicionários, interfaces, structs, jsons, etc. Mas eu sei que eles virão com o tempo, e quando a situação certa vier eu vou precisar deles.
- Foi divertido. Eu não tive taaantos problemas, mas claro que eu tive algumas. Eu tive problemas com o git mas eu estou entendendo ele um pouco mais eu diria. Outra coisa que eu tive problemas foi a resolução da janela, eu queria ter varias resoluções mas eu aprendi que não é tão compativel com pixel art. Isso faz o texto oscilar um pouco e eu acho que fundalmente eu não consigo arrumar isso (não sei), mas ainda é bem legível então eu acho que é ok.
- Eu queria adicionar mais coisas, mas eu acho que é melhor eu terminar o projeto e seguir adiante, do que eu li terminar projetos é uma abilidade valiosa. E logicamente faz sentido parar já que isso pode ir para sempre, "oh vamos adicionar isso!", "vamos adicionar aquilo!" mesmo que seja pequenas coisas ele leeentamente aumenta e ai você percebe que voce construiu um MMORPG kkkk.
- Em especificos do problema do git, foi que por alguma razão eu fiquei dando de cara em bugs, coisas que em geral não funcionavam mas eventualmente eu achei consertos. Eu tive que criar um git pushall, git pullall, git revertlocal. Eu tambem tive um pouco de problema entendo coisas como a diferença entre um checkout, pulling, pushing, etc.
- Eu tambem experienciei grandeza de poder voltar para o ultimo commit já que eu tinha quebrado algo no projeto e voltando consertou o problema.
- Git foi intimidador de primeira mas tá melhorando um pouco, usando ele.


# Planos do Projeto

Feito no inicio do repo.

Hora de fazer pong.

A essencia de pong consiste de
- Raquete do jogador que move para cima e baixo mas não passa das barreiras da tela.
- Bola que constantemente move e quica apartir das bordas da tela e raquetes do jogador/inimigo.
- Pontuação que faz com que se a bola passa de ti o inimigo ganha um ponto e vice-versa.
- IA de inimigo, na qual tem varias para escolher.

O que seria bom de adicionar
- Butões de pausa que abre uma janela de pausa.
- Janela de pausa com reiniciar, configurações, menu principal, sair.
- Configurações com volume e talvez outra coisas (tipo tela cheia, tamanho de janela).

Ideias por diversão?
- Talvez conquistas? Para testar eventos?
- Talvez fazer multiplas IAs de inimigo escolhiveis?
- Talvez fazer com que voce consiga girar lados e o sistema de pontuação consiga corretamente identificar e separar quem pontuou?
- Talvez testar mascara? Fazer com que quando a bola esteja mais para a esquerda ela torne uma cor e vice-versa.