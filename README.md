CampoTetris
===========

My C# implementation of Tetris. Made over the course of a few borning afternoons, purely for entertainment.

Just double-click the .exe to run.  To build, open CampoTetris.csproj or CampoTetris.sln in Visual Studio and build.

Your score is calculated as `SCORE = modifier * num. cleared lines`.  Clearing three lines gives a bonus 2x modifier.  Clearing four lines gives a 4x modifier.  The any bonus applied to your score lasts 45 seconds from the last bonus score (i.e. last time you cleared 3 or 4 lines).

### Controls:
**Arrow Keys** - Block Movement (up arrow is rotate).

**Space** - Drop block.

**P or PAUSE** - Pause game.

**H** - View high scores.