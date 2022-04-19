# a-fractral-dragon-curve-graph-generator

The common way to draw a dragon curve is to CCW the whole image with accordance to the end point, 
but it's hard to draw with hand. 
One day while waiting for the exam to finish, I came up with the idea (though I think someone else must had this long ago)

I use '/' to express "turn right", and '\' for "turn left"
as you draw it step by step, you may discover that one specific setp is "//\"
the next one is "//\\/\\", next "//\//\\\//\\/\\", next "//\//\\///\\/\\\//\//\\\//\\/\\"
here is the relationship: the next one is the flip order of the last one, then convert all '\' to '/' and all '/' to '\', and put a '\', and copy the last step. 

For example, this step
/\\
        ↓flip the order
\\/
        ↓convert '/' to '\' and '\' to '/'
//\
        ↓add '\'
//\\
        ↓copy the original step
//\\/\\
exactly the next step!

Another example: 
//\\/\\
        ↓flip the order
\\/\\//
        ↓convert '/' to '\' and '\' to '/'
//\//\\
        ↓add '\'
//\//\\\
        ↓copy the original step
//\//\\\//\\/\\

so, easily the program can operate without graphic(though i believe it's better to use 0 and 1 for left and right)
then draw with window graphics


about coding: 
It is made with Visual Studio IDE 2022 .NET Framework C# desktop program, I forgot the .NET version but probably 3.5
for trail without IDE: download and launch /Dragon/bin/Debug/Dragon.exe


how to use:
if you have no idea, just click the "+" button for a few times. 



