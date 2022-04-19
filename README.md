# a-fractral-dragon-curve-graph-generator<br>
<br>
The common way to draw a dragon curve is to CCW the whole image with accordance to the end point, <br>
but it's hard to draw with hand. <br>
One day while waiting for the exam to finish, I came up with the idea (though I think someone else must had this long ago)<br>
<br>
I use '/' to express "turn right", and '\' for "turn left"<br>
as you draw it step by step, you may discover that one specific setp is "//\"<br>
the next one is "//\\/\\", next "//\//\\\//\\/\\", next "//\//\\///\\/\\\//\//\\\//\\/\\"<br>
here is the relationship: the next one is the flip order of the last one, then convert all '\' to '/' and all '/' to '\', and put a '\', and copy the last step. <br>
<br>
For example, this step<br>
/\\<br>
        ↓flip the order<br>
\\/<br>
        ↓convert '/' to '\' and '\' to '/'<br>
//\<br>
        ↓add '\'<br>
//\\<br>
        ↓copy the original step<br>
//\\/\\<br>
exactly the next step!<br>
<br>
Another example: <br>
//\\/\\<br>
        ↓flip the order<br>
\\/\\//<br>
        ↓convert '/' to '\' and '\' to '/'<br>
//\//\\<br>
        ↓add '\'<br>
//\//\\\<br>
        ↓copy the original step<br>
//\//\\\//\\/\\<br>
<br>
so, easily the program can operate without graphic(though i believe it's better to use 0 and 1 for left and right)<br>
then draw with window graphics<br>
<br>
<br>
about coding: <br>
It is made with Visual Studio IDE 2022 .NET Framework C# desktop program, I forgot the .NET version but probably 3.5<br>
for trail without IDE: download and launch /Dragon/bin/Debug/Dragon.exe<br>
<br>
<br>
how to use:<br>
if you have no idea, just click the "+" button for a few times. <br>



