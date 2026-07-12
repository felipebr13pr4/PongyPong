# PongyPong

This will probally just be a pong clone but with some more things.

W to move up.
S to move down.
Make the ball go past the other paddle.

# Development.

Currently (i think) if the ball is too fast and touches the upper/bottom parts of the paddle for one frame it might consider it as if it hit the side (hit box is in the front), i'll see how to fix it later.
Theres also the empty ScoreController which i'll add things later, it'll likely be used for the achievements (If i won't do them, i'll delete it).
Currently all pause buttons do nothing. (Retry, settings, menu, quit).
Pressing R retries for testing purposes.

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