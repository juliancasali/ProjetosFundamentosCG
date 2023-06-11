#version 430

layout (location = 0) in vec3 position;
layout (location = 1) in vec3 color;

uniform mat4 model;
out vec4 finalColor;

void main()
{
	//...pode ter mais linhas de código aqui!
	gl_Position = model * vec4(position, 1.5);
	finalColor = vec4(color, 1.0);
}