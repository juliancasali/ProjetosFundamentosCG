#version 430

in vec4 finalColor;
out vec4 color;

uniform bool isContour;

void main()
{
if (!isContour)
{
    color = finalColor;
    }
    else color = vec4(0.0,0.0,0.0,1.0);
}