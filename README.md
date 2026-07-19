# PongyPong

This will probally just be a pong clone but with some more things.

W to move up.
S to move down.
Make the ball go past the other paddle to score.

If you clone this project, be aware that your game window resolution must correlate to the game application window resolutions.
(320x180, 480x270, 640x360, 800x450, 960x540, 1120x630, 1280x720, 1440x810, 1600x900, 1760x990, 1920x1080 (ideal))

# Development.

I need to fix the main menu by making it the same as the main game.

Theres also the empty ScoreController which i'll add things later, it'll likely be used for the achievements (If i won't do them, i'll delete it).

Pressing R retries for testing purposes.

# Done.

Currently (i think) if the ball is too fast and touches the upper/bottom parts of the paddle for one frame it might consider it as if it hit the side (hit box is in the front), i'll see how to fix it later.
- Fixed it by putting the ball's collision detection to Continuous.

Currently all pause buttons do nothing. (Retry, settings, menu, quit).
- Made they do stuff.

# Notes

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