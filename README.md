# PongyPong

This repo is for learning. Comments are welcome. I will not be accepting pullings or modifications as that is not the purpose of this repo.

This will probally just be a Pong clone but with some more things.

W to move up.
S to move down.
Make the ball go past the other paddle to score.

If you clone this project, be aware that your game window resolution must correlate to the game application window resolutions.
(320x180, 480x270, 640x360, 800x450, 960x540, 1120x630, 1280x720, 1440x810, 1600x900, 1760x990, 1920x1080 (ideal))

Link itch: (i'll put it here when i create it)

# Development Notes

Hey. Second time using git and github. Had some trouble with it.

Technically my actual first time as in the last project (flappy cube) i only used git at the end of that one. This project i used git from the very beginning.

Second project done, as i created this repo together of the unity project i can use the created at in
https://api.github.com/repos/felipebr13pr4/PongyPong
2026-07-05T20:15:49Z
As today's 07-21, 16 days. But, on some days i did not work on it so its around 12.
One reason it took longer is that i am trying to maintain a healthier work-time as on the first project i spent a tad too much time hyperfocused that i didn't have time for other things lol. So;
Project time: 16 days.
Theorical time: around 12 days.

I re-learned
- Class Inheritance.
- How to create a font.
- About prefabs.
- How to make a method executable in the editor (in the right button pop up window).
- How to properly config pixel sprites.
- About how when you've made a code in another project, you can re-use it. (And that this makes it so you don't need to write things from scratch every time and helps alot.)

Things i re-learned but did not implement (and that i'll likely need to eventually use when the situation comes)
- Lists
- Dictionaries
- Interfaces
- Structs.

I learned
- Auto-saving and saving on buttons.
- Making a simple AI
- Changing the application window size.
- Making the application window full screen.
- A bit of pixel perfect camera.
- Achievement system.
- Singletons.
- Tmp auto sizing.
- How to make a pop-up window with a Toggle.
- How to make a scrollable UI panel.
- More about UI in general.
- Using AI as a learning tool. Mostly to help with specific questions like a personalized Google, and even to explain simpler things. I did not use it for vibe-coding. I have only used it on two parts where it (accidentally) generated code that worked. But, as long as the code is something i understand, something that makes sense, is debuggable and doesn't have bugs, from what i understood then its ok. AI did not build the project for me..

Next time i should
- Search more.
- Think more. (To stop and reconsider things more, when implementing systems thinking if its even necessary, thinking of ways to do a system or thing. Considering sometimes the simpler approach is better.)
- Try doing better naming conventions git-wise. (Like branches, commits, etc.)

General Thoughts
- I want to try things i haven't done / used, like using Visual Studio's debug features, using lists, dictionaries, interfaces, structs, jsons, etc. But i know those will all come with time, when the situation arrives and i actually need to use them.
- It was fun. I didn't struggle as much as i did with the actual project, but of course i did a little. I've struggled a bit with git but im getting it a bit more i'd say. One thing that i struggled with was the screen resolution, i wanted to have lots of resolutions but i learned that it is not that compatible with pixel art. It makes the text wobble a little and i think fundamentally i can't fix it (idk), but its still quite readable so i think its okay.
- I did want to add more things, but i think i should finish this and move on, from what i read finishing projects is a valuable skill. And logically it makes sense to stop as this could go on forever and ever, "oh lets add this!", "lets add that!" even if its small things it slooowly grows and then you realize you built a MMORPG lol.
- On specifics on the git trouble, for some reason i kept facing bugs, things just didn't work in general but eventually i was able to find fixes. I had to create a git pushall, git pullall, git revertlocal. I've also had a bit of trouble understanding things like the difference of a checkout, pulling, pushing, etc.
- I've also experienced the greatness of being able to go back to the last commit as i had broken something in the project and by going back i was able to fix it.
- Git was intimidating at first but its a little better now, using it.

 
# Project Plan

Made at the very start of the project.

Time to make pong.

Pong Core consists of
- Player paddle that can move up and down but doesn't pass from the screen boundaries.
- Ball that constantly moves and bounces off screen and player/enemy paddles.
- Score that makes it so if a ball passed you the enemy gains score and vice-versa.
- Enemy ai, which there are alot to choose to make.

What would be nice to add, a
- Pause button that opens a pause window.
- Pause window with restart, settings, main menu, quit.
- Settings with a volume and maybe other things (like fullscreen, screen size).

Ideas for fun?
- Maybe achievements? To test events?
- Maybe make multiple enemy ais and make it chooseable?
- Maybe make it so you can flip sides and the scoring system to be able to correctly identify and separate who scored?
- Maybe test masking? To make it so when the ball is more to the left it turns one color and vice-versa.


I'll add a PT-BR version here later.